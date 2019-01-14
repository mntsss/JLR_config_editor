using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace JLR_Config_Editor.Functions
{
    public class Configurate
    {
        public Configurate() { }

        public string Crc16Ccitt(byte[] bytes)
        {
            const ushort poly = 4129;
            ushort[] table = new ushort[256];
            ushort initialValue = 0xffff;
            ushort temp, a;
            ushort crc = initialValue;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                        temp = (ushort)((temp << 1) ^ poly);
                    else
                        temp <<= 1;
                    a <<= 1;
                }
                table[i] = temp;
            }
            for (int i = 0; i < bytes.Length; ++i)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
            }
            return crc.ToString("X");
        }
        public byte [] SplitToBytes(string str)
        {
            string[] strings = new string[str.Length / 2];

            int i = 0;
            while (i < str.Length)
            {
                strings[i / 2] = str.Substring(i, 2);
                i += 2;
            }

            byte[] array = strings.Select(s => Convert.ToByte(s, 16)).ToArray();
            return array;

        }
        public string ReplaceBytes(string str, int start, int stop, string newBytes)
        {
            var aStringBuilder = new StringBuilder(str);
            aStringBuilder.Remove(start * 2, (stop - start) + 2);
            aStringBuilder.Insert(start * 2, newBytes);
            str = aStringBuilder.ToString();

            return str;
        }

        public void SaveByteChanges(string str, string orgData, string orgCRC, string fileLoc)
        {
            string [] dataStream = File.ReadAllLines(fileLoc);
            string newchecksum = Convert.ToString(Crc16Ccitt(SplitToBytes(str)));
            for (int i = 0; i<dataStream.Count(); i++)
            {
                if(dataStream[i].Contains(orgData) && dataStream[i].Contains(orgCRC))
                {
                    dataStream[i] = dataStream[i].Replace(orgData, str);
                    dataStream[i] = dataStream[i].Replace(orgCRC, "0x"+newchecksum);
                }
            }
            File.WriteAllLines(fileLoc, dataStream);
            MessageBox.Show("Naujas Checksum: " + newchecksum);
        }

        public void ReplaceCategoryValues(ref string[] str)
        {
            for(int i = 0; i<str.Count(); i++)
            {
                if (str[i].Contains("display=\"false\"") || str[i].Contains("edit=\"false\""))
                {
                    str[i] = str[i].Replace("false", "true");
                }
            }
        }

        public void WriteFixed(string [] dataStream, string file)
        {
            File.WriteAllLines(file, dataStream);
        }


        public void WriteSavedParameters(Classes.Group grp, string file)
        {
            foreach(Classes.Parameter prm in grp.parameters)
            {

            }
        }

        public void FixBlockData(Classes.Block blk, string fileloc)
        {
            int oldLength;
            string oldCheckSum;
            string oldData;

            int lastGroupReadingByteStop = blk.groups.Last().stop + 1;

            for (int i = 0; i < blk.block_data.Count; i++)
            {
                if (blk.block_data[i].data.Length <= 2) continue;
                if ((blk.block_data[3].data.Length == lastGroupReadingByteStop * 2 && blk.block_data[i].length != lastGroupReadingByteStop * 2)  || (blk.block_data[3].data.Length == lastGroupReadingByteStop * 2 && blk.block_data[i].length != lastGroupReadingByteStop-1))
                {
                    oldLength = blk.block_data[i].length;
                    oldCheckSum = blk.block_data[i].checksum;
                    oldData = blk.block_data[i].data;

                    blk.block_data[i].length = blk.block_data[3].length;
                    blk.block_data[i].data = blk.block_data[3].data;
                    blk.block_data[i].checksum = blk.block_data[3].checksum;

                    WriteFixedBlockGroups(oldLength.ToString(), oldCheckSum, oldData, blk.block_data[i], fileloc);
                }
                else if(blk.block_data[i].length != lastGroupReadingByteStop-1 || blk.block_data[i].data.Length != lastGroupReadingByteStop*2)
                {
                    oldLength = blk.block_data[i].length;
                    oldCheckSum = blk.block_data[i].checksum;
                    oldData = blk.block_data[i].data;

                    blk.block_data[i].length = lastGroupReadingByteStop;
                    while (blk.block_data[i].data.Length < lastGroupReadingByteStop * 2)
                        blk.block_data[i].data += "00";

                    blk.block_data[i].checksum = "0x"+Crc16Ccitt(SplitToBytes(blk.block_data[i].data));
                    WriteFixedBlockGroups(oldLength.ToString(), oldCheckSum, oldData, blk.block_data[i], fileloc);
                }
            }
            //MessageBox.Show("Bloko duomenys sėkmingai pataisyti.");
        }

        public void WriteFixedBlockGroups(string oldl, string oldch, string olddat, Classes.BlockData blkd, string fileLoc)
        {
            string[] dataStream = File.ReadAllLines(fileLoc);
            
            for (int i = 0; i < dataStream.Count(); i++)
            {
                if (dataStream[i].Contains(oldl.ToString()) && dataStream[i].Contains(oldch) && dataStream[i].Contains(olddat))
                {
                    dataStream[i] = dataStream[i].Replace(oldl, blkd.length.ToString());
                    dataStream[i] = dataStream[i].Replace(oldch, blkd.checksum);
                    dataStream[i] = dataStream[i].Replace(olddat, blkd.data);
                }
            }
            File.WriteAllLines(fileLoc, dataStream);
        }
    }
}
