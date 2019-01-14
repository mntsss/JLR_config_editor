using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using JLR_Config_Editor.Classes;
using System.Xml;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JLR_Config_Editor.Functions
{
    public class Reading
    {

        public DataFile Import(string file)
        {
            string line;
            DataFile dfile = new DataFile();
            int i = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                
                while ((line = reader.ReadLine()) != null)
                {
                    //Headeriu skaitymas
                    if (line.Contains("<?xml") && line != null)
                    {
                        while (!(line = reader.ReadLine()).Contains("<version>") && line != null)
                        {
                            dfile.Header.Add(line);
                        }
                    }
                    //Versijos skaitymas
                    if (line.Contains("<version>") && line != null)
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            i++;
                            if (line.Contains("</version>"))
                                break;
                            dfile.Version.Add(line);

                        }
                    }

                    //Ccf skaitymas
                    if (line.Contains("<ccf>") && line != null)
                    {
                        while ((line  = reader.ReadLine()) != null)
                        {
                            
                            if (line.Contains("</ccf>"))
                                break;
                            if (line.Contains("sync"))
                            {
                                dfile.ccf.syncs.Add(ParseCcfSync(line));

                            }
                            if (line.Contains("source"))
                            {
                                dfile.ccf.sources.Add(ParseCcfSource(line));

                            }
                        }

                    }
                    //post_update skaitymas
                    if (line.Contains("<post_update>") && line != null)
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            
                            if (line.Contains("</post_update>"))
                                break;

                            dfile.postUpdate.Add(line);
                        }
                    }
                    //vdf skaitymas
                    /*
                    if (line.Contains("<vehice_data_file>"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            
                            if (line.Contains("<vdf_block>"))
                                continue;
                            if (line.Contains("</vdf_block>"))
                                continue;
                            if (line.Contains("</vehice_data_file>"))
                                break;
                            if(line.Contains("<block_order"))
                                dfile.vdf.Add(ParseVDF(line));
                        }
                    }*/

                    //bloku skaitymas
                    if(line.Contains("<block"))
                    {
                        Block blk = new Block();
                        blk = ParseBlock(line);

                        while ((line = reader.ReadLine()) != null)
                        {
                            
                            if (line.Contains("</block>"))
                            {
                                dfile.blocks.Add(blk);
                                break;
                            }


                            if (line.Contains("<name>"))
                            {
                                blk.nameParam = ParseVersion(line).Trim();
                            }
                            //adresu skaitymas
                            if (line.Contains("<address"))
                            {
                                bool endCycle = false;
                                Address adr = new Address();
                                adr = ParseAddress(line);
                                while ((line = reader.ReadLine()) != null)
                                {

                                    if (line.Contains("</address>") || endCycle)
                                    {
                                        blk.Addresses.Add(adr);
                                        break;
                                    }
                                    //adresu qualifieriu skaitymas
                                    if (line.Contains("<qualifier "))
                                    {
                                        Qualifier qualifier = new Qualifier();
                                        qualifier = ParseQualifier(line);

                                        while ((line = reader.ReadLine()) != null)
                                        {

                                            if (line.Contains("</qualifier>"))
                                            {
                                                adr.qualifiers.Add(qualifier);
                                                break;
                                            }
                                            else if (line.Contains("</address>"))
                                            {
                                                adr.qualifiers.Add(qualifier);
                                                blk.Addresses.Add(adr);
                                                endCycle = true;
                                                break;
                                            }
                                            // adresu qualifieriu qualu skaitymas
                                            if (line.Contains("<qual "))
                                            {
                                                Qual qual = new Qual();
                                                qual = ParseQual(line);
                                                qualifier.qual.Add(qual);
                                            }
                                        }
                                    }
                               }
                            }
                            
                            if(line.Contains("<block_data>"))
                            {
                                
                                while((line = reader.ReadLine()) != null)
                                {
                                    BlockData blkd = new BlockData();
                                    if(line.Contains("</block_data>"))
                                    {
                                        break;
                                    }
                                    if(line.Contains("<data"))
                                        blk.block_data.Add(ParseBlockData(line));
                                }
                            }

                            //grupiu skaitymas
                            if(line.Contains("<group"))
                            {
                                Classes.Group grp = new Classes.Group();
                                grp = ParseGroup(line);
                                while((line = reader.ReadLine()) != null)
                                {
                                    if(line.Contains("</group>"))
                                    {
                                        blk.groups.Add(grp);
                                        break;
                                    }

                                    if (line.Contains("<title"))
                                    {
                                        grp.title = reader.ReadLine();
                                        continue;
                                    }
                                    //parametru skaitymas
                                    if(line.Contains("<parameter"))
                                    {
                                        Parameter prm = new Parameter();
                                        prm = ParseParameter(line);

                                        while((line = reader.ReadLine()) != null)
                                        {
                                            if(line.Contains("</parameter>"))
                                            {
                                                grp.parameters.Add(prm);
                                                break;
                                            }
                                            //kategoriju skaitymas
                                            if(line.Contains("<category"))
                                            {
                                                Category ctg = new Category();
                                                ctg = ParseCategory(line);
                                                prm.category = ctg;
                                            }
                                            //opciju skaitymas
                                            if(line.Contains("<option") && !line.Contains("<!--"))
                                            {
                                                Option opt = new Option();
                                                opt = ParseOption(line);
                                                prm.options.Add(opt);
                                            }
                                        }
                                    }
                                        
                                }
                            }
                        }
                    }
                }
            }

            
                return dfile;
        }

        public string ParseVersion(string code)
        { 

            return Regex.Replace(code, "<[^>]+>", string.Empty);

        }

        public Ccf_sync ParseCcfSync(string code)
        {
            Ccf_sync sync = new Ccf_sync();

            code = code.Trim();
            string[] parts = code.Split('>');
            parts[0].Replace("\"","");
            char status;
            status = (char)parts[0][parts[0].Length-2];
            sync.status = Convert.ToInt32(status.ToString());
            sync.name = parts[1].Split('<')[0];
            return sync;
        }

        public Ccf_source ParseCcfSource(string code)
        {
            Ccf_source sync = new Ccf_source();

            code = code.Trim();
            string[] parts = code.Split('>');
            parts[0].Replace("\"", "");
            char status;
            status = (char)parts[0][parts[0].Length-2];
            sync.status = Convert.ToInt32(status.ToString());
            sync.name = parts[1].Split('<')[0];
            return sync;
        }

        public Vehicle_Data_Files ParseVDF(string code)
        {
            Vehicle_Data_Files vdf = new Vehicle_Data_Files();

            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            string[] parts = code.Split(' ');

            vdf.module = parts[1].Split('=')[1];
            vdf.numHeaderBytes = Convert.ToInt32(parts[2].Split('=')[1]);
            vdf.numBlockIDs = Convert.ToInt32(parts[3].Split('=')[1]);
            vdf.version = Convert.ToInt32(parts[4].Split('=')[1][0].ToString());

            vdf.data = parts[4].Split('=')[1].Split('>')[1].Split('<')[0];

            return vdf;
        }

        public Block ParseBlock(string code)
        {
            Block blk = new Block();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", "");
            string[] parts = code.Split(' ');
            blk.id = Convert.ToInt32(parts[1].Split('=')[1].ToString());
            blk.name =  parts[2].Split('=')[1].ToString();
            blk.serviceIdRd = parts[3].Split('=')[1].ToString();
            blk.serviceIdWr = parts[4].Split('=')[1].ToString();
            blk.dl_exclude = parts[5].Split('=')[1].ToString();
            return blk;
        }

        public Address ParseAddress(string code)
        {
            Address adr = new Address();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", "");
            string[] parts = code.Split(' ');
            adr.module = parts[1].Split('=')[1].ToString();
            adr.t_ccf = parts[2].Split('=')[1].ToString();
            adr.parameterId = parts[3].Split('=')[1].ToString();
            adr.start_address = parts[4].Split('=')[1].ToString();
            adr.stop_address = parts[5].Split('=')[1].ToString();
            adr.merge = parts[6].Split('=')[1].ToString();
            return adr;
        }

        public Qualifier ParseQualifier(string code)
        {
            Qualifier qualifier = new Qualifier();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", "");
            string[] parts = code.Split(' ');
            qualifier.model = parts[1].Split('=')[1].ToString();
            qualifier.year = parts[2].Split('=')[1].ToString();
            return qualifier;
        }

        public Qual ParseQual(string code)
        {
            Qual qual = new Qual();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", "");
            string[] parts = code.Split(' ');
            qual.type = parts[1].Split('=')[1].ToString();
            qual.value = parts[2].Split('=')[1].ToString();
            return qual;
        }
        public BlockData ParseBlockData(string code)
        {
            BlockData blkd = new BlockData();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", " ");
            string[] parts = code.Split(' ');
            blkd.module = parts[1].Split('=')[1].ToString();
            blkd.length = Convert.ToInt32(parts[2].Split('=')[1].ToString());
            blkd.checksum = parts[3].Split('=')[1].ToString();
            blkd.data = parts[4].Split('<')[0].ToString();
            return blkd;
        }

        public Classes.Group ParseGroup(string code)
        {
            Classes.Group grp = new Classes.Group();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", "");
            string[] parts = code.Split(' ');
            grp.start = Convert.ToInt32(parts[1].Split('=')[1].ToString());
            grp.stop = Convert.ToInt32(parts[2].Split('=')[1].ToString());
            grp.name = parts[3].Split('=')[1].ToString().Replace(">", "");
            return grp;
        }

        public Parameter ParseParameter(string code)
        {
            Parameter prm = new Parameter();
            code = code.Trim();
            string[] parts = code.Split('=');
            prm.id = ParseFromQoutes(parts[1]);
            prm.name = ParseFromQoutes(parts[2]);
            prm.mask = ParseFromQoutes(parts[3]);
            prm.type = ParseFromQoutes(parts[4]);
            return prm;
        }

        public Category ParseCategory(string code)
        {
            Category ctg = new Category();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace("/>", "");
            string[] parts = code.Split(' ');
            ctg.display = Convert.ToBoolean(parts[1].Split('=')[1].ToString());
            ctg.edit = Convert.ToBoolean(parts[2].Split('=')[1].ToString());
            ctg.scope = parts[3].Split('=')[1].ToString();
            return ctg;
        }

        public string ParseFromQoutes(string code)
        {
            int firstQoute;
            int textLenght = 0;

            for(int i = 0; i<code.Length; i++)
            {
                if (code[i] == '"')
                {
                    firstQoute = i;
                    for (int j = i + 1; j < code.Length; j++)
                    {
                        if (code[j] == '"')
                            return code.Substring(firstQoute + 1, textLenght);
                        textLenght++;
                    }
                }
            }
            return "";
        }

        public Option ParseOption(string code)
        {
            Option opt = new Option();
            code = code.Trim();
            code = code.Replace("\\", "").Replace("\"", "");
            code = code.Replace(">", "");
            string[] parts = code.Split(' ');
            opt.value = parts[1].Split('=')[1].ToString();
            opt.name = parts[2].Split('=')[1].ToString();
            return opt;
        }
    }
}
