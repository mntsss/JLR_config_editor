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
    public partial class Block_control : UserControl
    {
        public string name;
        public Block_control(string n)
        {
            name = n;
            InitializeComponent();
            labelName.Text = name;
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void tableLayoutPanelBlock_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.Fixed3D;
        }

        private void tableLayoutPanelBlock_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBoxBlock_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxBlock_MouseLeave(object sender, EventArgs e)
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

        private void tableLayoutPanelBlock_Click(object sender, EventArgs e)
        {
            DataTree parent = this.ParentForm as DataTree;

            parent.PopulateGroups(name);
        }

        private void pictureBoxBlock_Click(object sender, EventArgs e)
        {
            DataTree parent = this.ParentForm as DataTree;

            parent.PopulateGroups(name);
        }
    }
}
