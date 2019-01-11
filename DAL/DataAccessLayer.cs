using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        SqlDataReader rdr;
        public DataAccessLayer()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);

        }
        public int PersonelKaydet(Personel p)
        {
            string sql = "Insert into Calisan (Ad,Soyad,telefon,email,maas,sehir,departman)Values(@ad,@soyad,@telefon,@email,@maas,@sehir,@departman)";
            con.Execute(sql, new { @ad = p.Ad, @soyad = p.Soyad, @telefon = p.Telefon, @email = p.email, @maas = p.maas, @sehir = p.sehir, @departman = p.departman });
            return 1;
        }

    }
}
