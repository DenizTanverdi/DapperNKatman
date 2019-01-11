using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

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
           // con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            string adres = "Data Source=SEM-BILGISAYAR;Initial Catalog=test;User ID=test2 ;Password=test2";
           con = new SqlConnection(adres);
        }
        public int PersonelKaydet(Personel p)
        {
            int kayitSayisi = 0;
            string sql = "Insert into Calisan (Ad,Soyad,telefon,email,maas,sehir,departman)Values(@ad,@soyad,@telefon,@email,@maas,@sehir,@departman)";
            
          kayitSayisi=  con.Execute(sql, new { @ad = p.Ad, @soyad = p.Soyad, @telefon = p.Telefon, @email = p.email, @maas = p.maas, @sehir = p.sehir, @departman = p.departman });
            return kayitSayisi;
        }
       

    }
}
