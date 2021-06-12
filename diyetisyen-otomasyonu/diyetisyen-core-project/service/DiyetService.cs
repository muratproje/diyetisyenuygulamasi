using diyetisyen_core_project.dao;
using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.service
{
    class DiyetService
    {
        IDiyetDAO diyetDAO = new DiyetDAOAccessImp();

        public void ekle(Diyet diyet)
        {
            diyetDAO.ekle(diyet);
        }
        public void sil(int id)
        {
            diyetDAO.sil(id);
        }
        public void guncelle(Diyet diyet)
        {
            diyetDAO.guncelle(diyet);
        }
        public Diyet bul(int id)
        {
            return diyetDAO.bul(id);
        }
        public List<Diyet> tumunuBul()
        {
            return diyetDAO.tumunuBul();
        }
    }
}
