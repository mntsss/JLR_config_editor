using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class DataFile
    {
        public List<string> Header = new List<string>();
        public List<string> Version = new List<string>();
        public Ccf ccf = new Ccf();
        public List<string> postUpdate = new List<string>();
        public List<Vehicle_Data_Files> vdf = new List<Vehicle_Data_Files>();

        public List<Block> blocks = new List<Block>();

        public DataFile() { }
    }
}
