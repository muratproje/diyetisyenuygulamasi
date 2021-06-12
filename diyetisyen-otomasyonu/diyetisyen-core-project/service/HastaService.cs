using diyetisyen_core_project.dao;
using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.service
{
    class HastaService
    {
        IHastaDAO hastaDAO = new HastaDAOAccessImp();

        public void ekle(Hasta hasta)
        {
            hastaDAO.ekle(hasta);
        }
        public void sil(string tc)
        {
            hastaDAO.sil(tc);
        }
        public void guncelle(Hasta hasta)
        {
            hastaDAO.guncelle(hasta);
        }
        public Hasta bul(string tc)
        {
            return hastaDAO.bul(tc);
        }
    }
}
