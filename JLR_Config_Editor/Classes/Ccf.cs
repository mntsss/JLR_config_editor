using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLR_Config_Editor.Classes
{
    public class Ccf
    {

        //Sources name / status
        public List<Ccf_sync> syncs = new List<Ccf_sync>();
        public List<Ccf_source> sources = new List<Ccf_source>();

        public Ccf() { }
    }
}
