using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using JLR_Config_Editor.Classes;

namespace JLR_Config_Editor
{
    public partial class ParameterMod : UserControl
    {
        Parameter prm { get; set; }
        public int Id;
        public string dfile { get; set; }

        public ParameterMod(Parameter p, string df)
        {
            dfile = df;
            prm = p;
            InitializeComponent();
            labelTitle.Text = prm.name;
            textBoxEdit.Text = prm.category.edit.ToString();
            textBoxDisplay.Text = prm.category.display.ToString();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(dfile);
            for(int i = 0; i<lines.Count(); i++)
            {
                if(lines[i].Contains(prm.id) && lines[i].Contains(prm.name) && lines[i].Contains(prm.mask) && lines[i].Contains(prm.type))
                {
                    for(int j = i; j<lines.Count(); j++)
                    {
                        if (lines[j].ToLower().Contains("display=\"false\"") || lines[j].ToLower().Contains("edit=\"false\""))
                        {
                            lines[j] = lines[j].Replace("false", "true");
                            lines[j] = lines[j].Replace("False", "True");
                        }
                        if (lines[j].Contains("</parameter>"))
                            break;
                    }
                    break;
                }
            }
            File.WriteAllLines(dfile, lines);

            textBoxDisplay.Text = "True";
            textBoxEdit.Text = "True";

        }
    }
}
