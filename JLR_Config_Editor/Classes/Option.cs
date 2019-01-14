using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Option
    {
        public string value { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string tmId { get; set; }
        public List<Qualifier_map> qualifier_map = new List<Qualifier_map>();

        public Option() { }

    }
}
