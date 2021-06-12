using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diyetisyen_core_project.entity;

namespace diyetisyen_core_project.dao
{
    public interface IDiyetisyenDAO
    {
        void ekle(Diyetisyen diyetisyen);
        void sil(string tc);
        void guncelle(Diyetisyen diyetisyen);
        Diyetisyen bul(int id);
        List<Diyetisyen> tumunuBul();
    }
}
