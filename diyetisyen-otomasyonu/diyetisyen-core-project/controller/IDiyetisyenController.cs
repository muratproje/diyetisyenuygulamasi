using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.controller
{
   public interface IDiyetisyenController
    {

        void hastaEkle(string tc, string ad,string soyad,int diyetisyen,int hastalik,int diyet,string diyettanim);
        void hastaSil(string tc);
        void hastaGuncelle(string ad, string soyad, string tc, int diyetisyen, int hastalik, int diyet, string diyettanim);
        Hasta hastaBul(string tc);
    

        void diyetisyenEkle(string tc, string ad, string soyad,string rol);
        void diyetisyenSil(string tc);
        void diyetisyenGuncelle(string ad, string soyad, string tc);
        Diyetisyen diyetisyenBul(int id);
        List<Diyetisyen> diyetisyenTumunuBul();

        List<Diyet> diyetTumunuBul();
        Diyet diyetBul(int id);
        void diyetEkle(string ad, string besin);
        void diyetSil(int id);
        void diyetGuncelle(int id, string ad, string besin);

        List<Hastalik> hastalikTumunuBul();
        Hastalik hastalikBul(int id);
        void hastalikEkle(string ad, string tanim);
        void hastalikSil(int id);
        void hastalikGuncelle(int id, string ad, string tanim);

        void raporAl(Hasta hasta, int tip, int duzen);
    }
}
