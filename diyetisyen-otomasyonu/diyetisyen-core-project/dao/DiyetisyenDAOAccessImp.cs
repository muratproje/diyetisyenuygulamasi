using diyetisyen_core_project.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetisyen_core_project.dao


{
   public class DiyetisyenDAOAccessImp:IDiyetisyenDAO
    {
        public OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

       public void ekle(Diyetisyen diyetisyen)
        {
            string sql = "Insert Into diyetisyen(tc,ad,soyad,rol) Values('" + diyetisyen.tc + "','" + diyetisyen.ad + "','" + diyetisyen.soyad + "','" + diyetisyen.rol + "')";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
       public void sil(string tc)
        {
            string sql = "Delete From diyetisyen where tc='" + tc + "'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
       public void guncelle(Diyetisyen diyetisyen)
        {
            string sql = "Update diyetisyen set ad='" + diyetisyen.ad + "',soyad='" + diyetisyen.soyad + "' Where tc='" + diyetisyen.tc + "'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
      public  Diyetisyen bul(int id)
        {
            Diyetisyen diyetisyen = new Diyetisyen();
            string sql = "Select * From diyetisyen where pkdiyetisyen=" + id;
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                diyetisyen.ad = dr["ad"].ToString();
                diyetisyen.soyad = dr["soyad"].ToString();
                diyetisyen.rol = dr["rol"].ToString();
                diyetisyen.tc = dr["tc"].ToString();
            }
            cnn.Close();
            return diyetisyen;
        }

        public List<Diyetisyen> tumunuBul()
        {
            List<Diyetisyen> diyetisyenler = new List<Diyetisyen>();
            Diyetisyen diyetisyen;
            string sql = "Select * From diyetisyen";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                diyetisyen = new Diyetisyen();
                diyetisyen.tc = dr["tc"].ToString();
                diyetisyen.ad = dr["ad"].ToString();
                diyetisyen.soyad = dr["soyad"].ToString();
                diyetisyen.rol = dr["rol"].ToString();
                diyetisyen.id = int.Parse(dr["pkdiyetisyen"].ToString());
                diyetisyenler.Add(diyetisyen);
            }
            cnn.Close();
            return diyetisyenler;
        }
    }
}
