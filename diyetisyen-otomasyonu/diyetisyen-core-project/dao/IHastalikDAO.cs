using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diyetisyen_core_project.entity;
namespace diyetisyen_core_project.dao
{
    interface IHastalikDAO
    {
        void ekle(Hastalik hastalik);
        void sil(int id);
        void guncelle(Hastalik hastalik);
        Hastalik bul(int id);
        List<Hastalik> tumunuBul();
    }
}
