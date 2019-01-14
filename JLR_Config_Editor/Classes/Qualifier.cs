using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Qualifier
    {
        public string model;
        public string year;
        public List<Qual> qual = new List<Qual>();

        public Qualifier() { }
    }
}
