using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.entity
{
   public class Hasta
    {
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int diyetisyen { get; set; }
        public int hastalik { get; set; }
        public int diyet { get; set; }
        public string diyettanim { get; set; }
        public Hasta()
        {

        }
        public Hasta(string tc, string ad, string soyad)
        {
            this.tc = tc;
            this.ad = ad;
            this.soyad = soyad;           
        }        
        public override string ToString()
        {
            return "Hasta : " + tc + " " + ad + " "+ soyad;
        }
    }


}
