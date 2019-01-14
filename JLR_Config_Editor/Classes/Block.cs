using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Block
    {
        public int id;
        public string name;
        public string serviceIdRd;
        public string serviceIdWr;
        public string dl_exclude;

        public string nameParam;

        public List<Address> Addresses = new List<Address>();

        public List<BlockData> block_data = new List<BlockData>();
        public List<Group> groups = new List<Group>();

        public Block() { }
    }
}
