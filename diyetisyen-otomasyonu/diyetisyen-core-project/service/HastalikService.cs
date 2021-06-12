using diyetisyen_core_project.dao;
using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.service
{
    class HastalikService
    {
        IHastalikDAO hastalikDAO = new HastalikDAOAccessImp();

        public void ekle(Hastalik hastalik)
        {
            hastalikDAO.ekle(hastalik);
        }
        public void sil(int id)
        {
            hastalikDAO.sil(id);
        }
        public void guncelle(Hastalik hastalik)
        {
            hastalikDAO.guncelle(hastalik);
        }
        public Hastalik bul(int id)
        {
            return hastalikDAO.bul(id);
        }
        public List<Hastalik> tumunuBul()
        {
            return hastalikDAO.tumunuBul();
        }
    }
}
