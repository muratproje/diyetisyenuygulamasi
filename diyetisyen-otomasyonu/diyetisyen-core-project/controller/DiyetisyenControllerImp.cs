using diyetisyen_core_project.entity;
using diyetisyen_core_project.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.controller
{
    public class DiyetisyenControllerImp:IDiyetisyenController
    {        
        HastaService hastaservice = new HastaService();
        DiyetisyenService diyetisyenservice = new DiyetisyenService();
        HastalikService hastalikservice = new HastalikService();
        DiyetService diyetservice = new DiyetService();
        CiktiAliciService ciktiAlici = CiktiAliciService.getInstance();//singleton 

        private static IDiyetisyenController instance = null;
        private DiyetisyenControllerImp()
        {

        }
        public static IDiyetisyenController getInstance()
        {
            if (instance == null)
                instance = new DiyetisyenControllerImp();
            return instance;
        }





        #region ///HASTA
        public Hasta hastaBul(string tc)
        {
            return hastaservice.bul(tc);
        }
        public void hastaEkle(string tc, string ad, string soyad, int diyetisyen, int hastalik, int diyet,string diyettanim)
        {
            Hasta hasta = new Hasta();
            hasta.tc = tc;
            hasta.ad = ad;
            hasta.soyad = soyad;
            hasta.diyetisyen = diyetisyen;
            hasta.hastalik = hastalik;
            hasta.diyet = diyet;
            hasta.diyettanim = diyettanim;
            hastaservice.ekle(hasta);
        }
        public void hastaGuncelle(string ad, string soyad, string tc, int diyetisyen, int hastalik, int diyet, string diyettanim)
        {
            Hasta hasta = new Hasta();
            hasta.tc = tc;
            hasta.ad = ad;
            hasta.soyad = soyad;
            hasta.diyetisyen = diyetisyen;
            hasta.hastalik = hastalik;
            hasta.diyet = diyet;
            hasta.diyettanim = diyettanim;
            hastaservice.guncelle(hasta);
        }
        public void hastaSil(string tc)
        {
            hastaservice.sil(tc);
        }
        //////////////HASTA
        #endregion
        #region///DİYETİSYEN
        public Diyetisyen diyetisyenBul(int id)
        {
            return diyetisyenservice.bul(id);
        }
        public List<Diyetisyen> diyetisyenTumunuBul()
        {
            return diyetisyenservice.tumunuBul();
        }
        public void diyetisyenEkle(string tc, string ad, string soyad,string rol)
        {
            Diyetisyen diyetisyen = new Diyetisyen(tc, ad, soyad,rol);
            diyetisyenservice.ekle(diyetisyen);
        }
        public void diyetisyenGuncelle(string tc, string ad, string soyad)
        {
            Diyetisyen diyetisyen = new Diyetisyen();
            diyetisyen.tc = tc;
            diyetisyen.ad = ad;
            diyetisyen.soyad = soyad;
            diyetisyenservice.guncelle(diyetisyen);
        }
        public void diyetisyenSil(string tc)
        {
            diyetisyenservice.sil(tc);
        }
        //////////////DİYETİSYEN
        #endregion
        #region///HASTALİK
        public Hastalik hastalikBul(int id)
        {
            return hastalikservice.bul(id);
        }
        public List<Hastalik> hastalikTumunuBul()
        {
            return hastalikservice.tumunuBul();
        }
        public void hastalikEkle(string ad, string tanim)
        {
            Hastalik hastalik = new Hastalik(ad, tanim);
            hastalikservice.ekle(hastalik);
        }

        public void hastalikGuncelle(int id,string ad, string tanim)
        {
            Hastalik hastalik = new Hastalik();
            hastalik.ad = ad;
            hastalik.tanim = tanim;
            hastalikservice.guncelle(hastalik);
        }

        public void hastalikSil(int id)
        {
            hastalikservice.sil(id);
        }

        //////////////HASTALİK
        #endregion
        #region///DİYET
        public Diyet diyetBul(int id)
        {
            return diyetservice.bul(id);
        }
        public List<Diyet> diyetTumunuBul()
        {
            return diyetservice.tumunuBul();
        }
        public void diyetEkle(string ad, string besin)
        {
            Diyet diyet = new Diyet(ad, besin);
            diyetservice.ekle(diyet);
        }

        public void diyetGuncelle(int id,string ad, string besin)
        {
            Diyet diyet = new Diyet();
            diyet.ad = ad;
            diyet.besin = besin;
            diyet.id = id;
            diyetservice.guncelle(diyet);
        }

        public void diyetSil(int id)
        {
            diyetservice.sil(id);
        }
        //////////////DİYET
        #endregion
        public void raporAl(Hasta hasta,int tip,int duzen)
        {
            ciktiAlici.ciktiAL(hasta, tip, duzen);
        }
    }
}
