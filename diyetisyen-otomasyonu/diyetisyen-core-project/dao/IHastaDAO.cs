using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.dao
{
    interface IHastaDAO
    {
        void ekle(Hasta hasta);
        void sil(string tc);
        void guncelle(Hasta hasta);
        Hasta bul(string tc);

    }
}
