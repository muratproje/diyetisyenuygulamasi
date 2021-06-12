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
    
    class HastaDAOAccessImp:IHastaDAO
    {
        public OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public void ekle(Hasta hasta)
        {
            string sql = "Insert Into hasta(tc,ad,soyad,hastalikid,diyetisyenid,diyetid,diyettanim) Values('" + hasta.tc + "','" + hasta.ad + "','" + hasta.soyad + "','"+hasta.hastalik+"','"+hasta.diyetisyen+"','"+hasta.diyet+"','"+hasta.diyettanim+"')";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void sil(string tc)
        {
            string sql = "Delete From hasta where tc='"+tc+"'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void guncelle(Hasta hasta)
        {
            string sql = "Update hasta set ad='"+hasta.ad+"',soyad='"+hasta.soyad+ "',diyetisyenid='" + hasta.diyetisyen + "',hastalikid='" + hasta.hastalik + "',diyetid='" + hasta.diyet + "' Where tc='" + hasta.tc+"'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public Hasta bul(string tc)
        {
            Hasta hasta = new Hasta();
            Diyet diyet = new Diyet();
            Diyetisyen diyetisyen = new Diyetisyen();
            Hastalik hastalik = new Hastalik();

            string sql = "Select * From hasta where tc='" + tc + "'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                hasta.tc = tc;
                hasta.ad = dr["ad"].ToString();
                hasta.soyad = dr["soyad"].ToString();
                hasta.diyettanim = dr["diyettanim"].ToString();
                hasta.diyet= int.Parse(dr["diyetid"].ToString());
                hasta.diyetisyen = int.Parse(dr["diyetisyenid"].ToString());
                hasta.hastalik = int.Parse(dr["hastalikid"].ToString());
            }
            cnn.Close();
            return hasta;
        }
    }
}
