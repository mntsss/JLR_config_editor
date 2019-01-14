using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Parameter
    {
        public string id;
        public string name;
        public string mask;
        public string type;
        public Category category;
        public string title;
        public string title_text;

        public List<Option> options = new List<Option>();

        public Parameter() { }

    }
}
