using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.domain
{
    interface ICiktiAl
    {
        void hastaDiyetRpr(Hasta hasta,Diyetisyen diyetisyen,Diyet diyet,Hastalik hastalik);
        void diyetHastaRpr(Hasta hasta,Diyetisyen diyetisyen, Diyet diyet,Hastalik hastalik);
    }
}
