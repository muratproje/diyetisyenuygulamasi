using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.entity
{
    public class Diyetisyen
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string rol { get; set; }
        public int id { get; set; }
        public Diyetisyen()
        {

        }
        public Diyetisyen(string tc, string ad,string soyad,string rol)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.tc = tc;
            this.rol = rol;            
        }
        public override string ToString()
        {
            return "Diyetisyen: " + ad + " " + soyad;
        }
    }
}
