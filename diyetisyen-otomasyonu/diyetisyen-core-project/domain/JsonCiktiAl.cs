using diyetisyen_core_project.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.domain
{
    class JsonCiktiAl:ICiktiAl
    {
        public class data
        {
            public string hastatc { get; set; }
            public string hastaad { get; set; }
            public string hastasoyad { get; set; }
            public string diyetisyenad { get; set; }
            public string hastalikad { get; set; }
            public string diyetad { get; set; }
            public string diyetbesin { get; set; }

        }
        public class data1
        {
            public string diyetad { get; set; }
            public string diyetbesin { get; set; }
            public string diyetisyenad { get; set; }
            public string hastatc { get; set; }
            public string hastaad { get; set; }
            public string hastasoyad { get; set; }
            public string hastalikad { get; set; }


        }
        public void hastaDiyetRpr(Hasta hasta, Diyetisyen diyetisyen, Diyet diyet, Hastalik hastalik)
        {
            List<data> _data = new List<data>();
            _data.Add(new data()
            {
                hastatc = hasta.tc,
                hastaad = hasta.ad,
                hastasoyad = hasta.soyad,
                diyetisyenad=diyetisyen.ad,
                hastalikad=hastalik.ad,
                diyetad=diyet.ad,
                diyetbesin=diyet.besin
            });

            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText("htmlRapor.html", json);
        
    }
        public void diyetHastaRpr(Hasta hasta, Diyetisyen diyetisyen, Diyet diyet, Hastalik hastalik)
        {
            List<data1> _data = new List<data1>();
            _data.Add(new data1()
            {
                diyetad = diyet.ad,
                diyetbesin = diyet.besin,
                diyetisyenad = diyetisyen.ad,
                hastatc = hasta.tc,
                hastaad = hasta.ad,
                hastasoyad = hasta.soyad,
                hastalikad = hastalik.ad

            });
            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText("htmlRapor.html", json);
        }
    }
}
