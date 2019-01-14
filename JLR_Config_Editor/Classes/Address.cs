using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Address
    {
        public string module;
        public string t_ccf;
        public string parameterId;
        public string start_address;
        public string stop_address;
        public string merge;

        public List<Qualifier> qualifiers = new List<Qualifier>();

        public Address() { }
    }
}
