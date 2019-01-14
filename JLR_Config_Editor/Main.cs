using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JLR_Config_Editor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Loading loadForm = new Loading();
            loadForm.Show();*/
            Functions.Reading reading = new Functions.Reading();
            Classes.DataFile datafile = new Classes.DataFile();

            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Nepasirinktas failas.");
                return;
            }
                
            datafile = reading.Import(openFileDialog1.FileName);

            //loadForm.Dispose();
            DataTree form = new DataTree(datafile, openFileDialog1.FileName);
            form.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            labelPath.Text = openFileDialog1.FileName;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
