using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLR_Config_Editor
{
    public partial class Group_control : UserControl
    {
        public string name;
        public string blk;

        public Group_control(string n, string b)
        {

            name = n;
            blk = b;
            InitializeComponent();
            BorderStyle = BorderStyle.FixedSingle;
            labelName.Text = name;
        }

        private void tableLayoutPanelGroup_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.Fixed3D;
        }

        private void tableLayoutPanelGroup_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void labelName_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.Fixed3D;
        }

        private void labelName_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void tableLayoutPanelGroup_Click(object sender, EventArgs e)
        {
            DataTree parent = this.ParentForm as DataTree;

            parent.ReadParameters(blk, name);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTree parent = this.ParentForm as DataTree;

            parent.ReadParameters(blk, name);
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            DataTree parent = this.ParentForm as DataTree;

            parent.ReadParameters(blk, name);
        }
    }
}
