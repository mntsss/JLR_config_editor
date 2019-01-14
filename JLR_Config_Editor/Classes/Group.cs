using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Group
    {
        public int start;
        public int stop;
        public string name;

        public string title;
        public string title_text;

        public List<Parameter> parameters = new List<Parameter>();

        public Group() { }
    }
}
