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
    class HastalikDAOAccessImp : IHastalikDAO
    {
        public OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public Hastalik bul(int id)
        {
            Hastalik hastalik = new Hastalik();
            string sql = "Select * From hastalik where pkhastalik=" + id;
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                hastalik.ad = dr["ad"].ToString();
                hastalik.tanim = dr["tanim"].ToString();

            }
            cnn.Close();
            return hastalik;
        }
        public List<Hastalik> tumunuBul()
        {
            List<Hastalik> hastaliklar = new List<Hastalik>();
            Hastalik hastalik;
            string sql = "Select * From hastalik";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hastalik = new Hastalik();
                hastalik.id = int.Parse(dr["pkhastalik"].ToString());
                hastalik.ad = dr["ad"].ToString();
                hastalik.tanim = dr["tanim"].ToString();
                hastaliklar.Add(hastalik);
            }
            cnn.Close();
            return hastaliklar;
        }
        public void ekle(Hastalik hastalik)
        {
            string sql = "Insert Into hastalik(ad,tanim) Values('" + hastalik.ad + "','" + hastalik.tanim + "'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void guncelle(Hastalik hastalik)
        {
            string sql = "Update hastalik set tanim='" + hastalik.tanim + "' Where ad='" + hastalik.ad + "'";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void sil(int id)
        {
            string sql = "Delete From hastalik where id=" + id;
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
