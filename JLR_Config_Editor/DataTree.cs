using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JLR_Config_Editor.Classes;
using System.IO;
namespace JLR_Config_Editor
{
    public partial class DataTree : Form
    {

        public int start;
        public int stop;
        public string orgData;
        public string newBytes;
        public string orgCRC;

        //po data pakeitimu issaugojima, kintamieji uzkrautai informacijai pakeisti
        public string newCRC;
        public string blkName;

        //paskutinis pasirinktas blokas
        public string lastViewedBlock;

        public string dfileLocation;

        DataFile dfile = new DataFile();
        Group selectedGroup = new Group();

        public DataTree(DataFile df, string dfl)
        {

            dfileLocation = dfl;
            dfile = df;



            Functions.Configurate config = new Functions.Configurate();
            config.FixBlockData(dfile.blocks[0], dfileLocation);


            InitializeComponent();
            int x = 5;
            int y = 10;
            foreach(Block b in dfile.blocks)
            {
                Block_control bctr = new Block_control(b.nameParam);
                panelMain.Controls.Add(bctr);
                bctr.Location = new Point(x, y);
                y += 70;
            }
            textBox1.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Return)
                {
                    buttonSearch.PerformClick();
                }
            };
        }

        private void DataTree_Load(object sender, EventArgs e)
        {
            /*Functions.Configurate config = new Functions.Configurate();
            config.FixBlockData(dfile.blocks[0], dfileLocation);*/
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void PopulateGroups(string blkname)
        {
            lastViewedBlock = blkname;
            panelGroups.Controls.Clear();
            panelParameters.Visible = false;
            
            for(int i= 0; i<dfile.blocks.Count; i++)
            {
                if(dfile.blocks[i].nameParam == blkname)
                {
                    int x = 5;
                    int y = 10;
                    foreach(Group g in dfile.blocks[i].groups)
                    {
                        Group_control grp = new Group_control(g.name, blkname);
                        panelGroups.Controls.Add(grp);
                        grp.Location = new Point(x, y);
                        y += 70;
                    }
                }
            }

        }

        public void SearchGroups(string query)
        {
            panelGroups.Controls.Clear();
            panelParameters.Visible = false;

            for (int i = 0; i < dfile.blocks.Count; i++)
            {
                if (dfile.blocks[i].nameParam == lastViewedBlock)
                {
                    int x = 5;
                    int y = 10;
                    foreach (Group g in dfile.blocks[i].groups)
                    {
                        if(g.name.Contains(query.ToUpper()))
                        {
                            Group_control grp = new Group_control(g.name, lastViewedBlock);
                            panelGroups.Controls.Add(grp);
                            grp.Location = new Point(x, y);
                            y += 70;
                        }
                        
                    }
                }
            }

        }

        public void ReadParameters(string blk, string grp)
        {
            panelParameters.Visible = true;
            labelParamTitle.Text = grp;

            for (int i = 0; i < dfile.blocks.Count; i++)
            {
                if (dfile.blocks[i].nameParam == blk)
                {
                    foreach (Group g in dfile.blocks[i].groups)
                    {
                        if(g.name == grp)
                        {
                            selectedGroup = g;
                            /*textBoxDisplay.Text = g.parameters[0].category.display.ToString();
                            textBoxEdit.Text = g.parameters[0].category.edit.ToString();

                            textBoxScope.Text = g.parameters[0].category.scope;*/

                            start = g.start;
                            stop = g.stop;
                            orgData = dfile.blocks[i].block_data[0].data;
                            orgCRC = dfile.blocks[i].block_data[0].checksum;
                            dataGridViewValues.DataSource = g.parameters[0].options;
                            if(g.start * 2 +(g.stop - g.start) + 2 > dfile.blocks[i].block_data[0].data.Length)
                                textBoxBytes.Text = dfile.blocks[i].block_data[0].data.Substring(g.start * 2, (g.stop - g.start) + 1);
                            else
                                textBoxBytes.Text = dfile.blocks[i].block_data[0].data.Substring(g.start * 2, (g.stop - g.start) + 2);
                            blkName = blk;

                            break;

                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Functions.Configurate config = new Functions.Configurate();

            string newData = config.ReplaceBytes(orgData, start, stop, textBoxBytes.Text);
            config.SaveByteChanges(newData, orgData, orgCRC, dfileLocation);
            SaveChangedDataInMemory(newData);
            MessageBox.Show("Išsaugota.");
        }


        public void SaveChangedDataInMemory(string ndata)
        {
            for (int i = 0; i < dfile.blocks.Count; i++)
            {
                if (dfile.blocks[i].nameParam == blkName)
                {
                    foreach (BlockData bd in dfile.blocks[i].block_data)
                    {
                        if(bd.data == orgData && bd.checksum == orgCRC)
                        {
                            Functions.Configurate config = new Functions.Configurate();
                            bd.data = ndata;
                            bd.checksum = "0x"+config.Crc16Ccitt(config.SplitToBytes(ndata));
                        }

                    }
                }
            }
        }
        private void DataTree_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewValues_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewValues.SelectedRows.Count > 0)
                textBoxBytes.Text = dataGridViewValues.SelectedRows[0].Cells[0].Value.ToString().Split('x')[1];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchGroups(textBox1.Text);
        }

        private void keisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Loading loadForm = new Loading();
            loadForm.Show();*/
            Functions.Configurate config = new Functions.Configurate();

            string[] dataStream = File.ReadAllLines(dfileLocation);

            config.ReplaceCategoryValues(ref dataStream);
            config.WriteFixed(dataStream, dfileLocation);
            //loadForm.Dispose();
            MessageBox.Show("Parametrai pakeisti.");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Parameters form = new Parameters(selectedGroup, dfileLocation);
            form.Show();
        }
    }
}
