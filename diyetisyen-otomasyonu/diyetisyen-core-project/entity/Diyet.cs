using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.entity
{
    public class Diyet
    {
        public string ad { get; set; }
        public string besin { get; set; }
        public int id { get; set; }
        public Diyet()
        {

        }
        public Diyet(string ad,string besin)
        {
            this.ad = ad;
            this.besin = besin;
        }
        public override string ToString()
        {
            return "Diyet: " + ad + " " +besin;
        }
    }
}
