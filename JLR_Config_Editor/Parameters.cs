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
using JLR_Config_Editor.Functions;

namespace JLR_Config_Editor
{
    public partial class Parameters : Form
    {

        Group grp { get; set; }
        string dfile { get; set; }
        public Parameters(Group g, string df)
        {
            dfile = df;
            grp = g;
            this.Name = grp.name;
            InitializeComponent();
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            int y = 0;
            foreach(Parameter p in grp.parameters)
            {
                ParameterMod ctrl = new ParameterMod(p, dfile);
                ctrl.Location = new Point(0, y);
                panelParam.Controls.Add(ctrl);
                y += 91;
            }
        }

        private void Parameters_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
