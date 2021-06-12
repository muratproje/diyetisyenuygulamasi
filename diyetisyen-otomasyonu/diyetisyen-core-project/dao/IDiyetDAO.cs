using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diyetisyen_core_project.entity;
namespace diyetisyen_core_project.dao
{
    interface IDiyetDAO
    {
        void ekle(Diyet diyet);
        void sil(int id);
        void guncelle(Diyet diyet);
        Diyet bul(int id);
        List<Diyet> tumunuBul();
    }
}
