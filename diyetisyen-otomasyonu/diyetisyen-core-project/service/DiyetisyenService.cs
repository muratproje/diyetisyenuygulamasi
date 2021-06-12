using diyetisyen_core_project.dao;
using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.service
{
    class DiyetisyenService
    {
        IDiyetisyenDAO diyetisyenDAO = new DiyetisyenDAOAccessImp();

        public void ekle(Diyetisyen diyetisyen)
        {
            diyetisyenDAO.ekle(diyetisyen);
        }
        public void sil(string tc)
        {
            diyetisyenDAO.sil(tc);
        }
        public void guncelle(Diyetisyen diyetisyen)
        {
            diyetisyenDAO.guncelle(diyetisyen);
        }
        public Diyetisyen bul(int id)
        {
            return diyetisyenDAO.bul(id);
        }
        public List<Diyetisyen> tumunuBul()
        {
            return diyetisyenDAO.tumunuBul();
        }
    }
}
