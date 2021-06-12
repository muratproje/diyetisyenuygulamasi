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
    class DiyetDAOAccessImp:IDiyetDAO
    {
        public OleDbConnection cnn = new OleDbConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public Diyet bul(int id)
        {
            Diyet diyet = new Diyet();
            string sql = "Select * From diyet where pkdiyet=" + id;
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                diyet.ad = dr["ad"].ToString();
                diyet.besin = dr["besin"].ToString();
            }
            cnn.Close();
            return diyet;
        }

        public void ekle(Diyet diyet)
        {
            string sql = "Insert Into diyet(ad,besin) Values('" + diyet.ad + "','" + diyet.besin + "')";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void guncelle(Diyet diyet)
        {
            string sql = "Update diyet set besin='" + diyet.besin + "', ad='" + diyet.ad + "' Where pkdiyet=" + diyet.id;
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void sil(int id)
        {
            string sql = "Delete From diyet where pkdiyet=" + id;
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public List<Diyet> tumunuBul()
        {
            List<Diyet> diyetler = new List<Diyet>();
            Diyet diyet;
            string sql = "Select * From diyet";
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                diyet = new Diyet();
                diyet.ad = dr["ad"].ToString();
                diyet.besin = dr["besin"].ToString();
                diyet.id = int.Parse(dr["pkdiyet"].ToString());
                diyetler.Add(diyet);
            }
            cnn.Close();

            return diyetler;
        }
    }
}
