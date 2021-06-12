using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.entity
{
    public class Hastalik
    {
        public string ad { get; set; }
        public string tanim { get; set; }
        public int id { get; set; }
        public Hastalik()
        {
            
        }
        public Hastalik(string ad,string tanim)
        {
            this.ad = ad;
            this.tanim = tanim;
        }
        public override string ToString()
        {
            return "Hastaik: " + ad;
        }
    }
}
