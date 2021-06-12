using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.domain
{
    class HtmlCiktiAl:ICiktiAl
    {
        public void hastaDiyetRpr(Hasta hasta, Diyetisyen diyetisyen, Diyet diyet, Hastalik hastalik)
        {
            StreamWriter deneme = new StreamWriter("htmlRapor.html");
            deneme.WriteLine("<head> <meta charset ='"+ "UTF-8"+"'> </head>");
            deneme.WriteLine("<h1> Hasta Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Hasta TC :" + hasta.tc + "</li> ");
            deneme.WriteLine("<li> Hasta Adı :" + hasta.ad + "</li> ");
            deneme.WriteLine("<li> Hasta Soyadı :" + hasta.soyad + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.WriteLine("<h1> Diyetisyen Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Diyetisyen Ad :" + diyetisyen.ad + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.WriteLine("<h1> Hastalık  Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Hastalık Adı :" + hastalik.ad + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.WriteLine("<h1> Diyet  Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Diyet Adı :" + diyet.ad + "</li> ");
            deneme.WriteLine("<li> Diyet Menüsü :" + diyet.besin + "</li> ");
            deneme.WriteLine("</ol>");
            deneme.Close();
        }
        public void diyetHastaRpr(Hasta hasta, Diyetisyen diyetisyen, Diyet diyet, Hastalik hastalik)
        {
            StreamWriter deneme = new StreamWriter("htmlRapor.html");
            deneme.WriteLine("<head> <meta charset ='" + "UTF-8" + "'> </head>");
            deneme.WriteLine("<h1> Diyet  Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Diyet Adı :" + diyet.ad + "</li> ");
            deneme.WriteLine("<li> Diyet Menüsü :" + diyet.besin + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.WriteLine("<h1> Diyetisyen Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Diyetisyen Ad :" + diyetisyen.ad + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.WriteLine("<h1> Hasta Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Hasta TC :" + hasta.tc + "</li> ");
            deneme.WriteLine("<li> Hasta Adı :" + hasta.ad + "</li> ");
            deneme.WriteLine("<li> Hasta Soyadı :" + hasta.soyad + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.WriteLine("<h1> Hastalık  Bilgileri </h1>");
            deneme.WriteLine("<ol>");
            deneme.WriteLine("<li> Hastalık Adı :" + hastalik.ad + "</li> ");
            deneme.WriteLine("</ol>");

            deneme.Close();
        }
    }
}
