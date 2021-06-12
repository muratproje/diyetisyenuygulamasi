using diyetisyen_core_project.dao;
using diyetisyen_core_project.domain;
using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.service
{
    class CiktiAliciService
    {
        private static CiktiAliciService instance=null;

        ICiktiAl ciktiAl;
        Diyetisyen diyetisyen;
        Diyet diyet;
        Hastalik hastalik;
        IDiyetDAO diyetDAO = new DiyetDAOAccessImp();
        IDiyetisyenDAO diyetisyenDAO = new DiyetisyenDAOAccessImp();
        IHastalikDAO hastalikDAO = new HastalikDAOAccessImp();

        private CiktiAliciService()
        {

        }

        public static CiktiAliciService getInstance()
        {
            if (instance == null)
                instance = new CiktiAliciService();
            return instance;
        }
        public void ciktiAL(Hasta hasta, int tipi, int duzen)
        {
            diyet = diyetDAO.bul(hasta.diyet);
            diyetisyen = diyetisyenDAO.bul(hasta.diyetisyen);
            hastalik = hastalikDAO.bul(hasta.hastalik);
            
            if(tipi==1)
                ciktiAl = new HtmlCiktiAl();
            else
                ciktiAl = new JsonCiktiAl();

            if(duzen==1)
                ciktiAl.hastaDiyetRpr(hasta, diyetisyen, diyet, hastalik);
            else
                ciktiAl.diyetHastaRpr(hasta, diyetisyen, diyet, hastalik);            
        }
    }
}
