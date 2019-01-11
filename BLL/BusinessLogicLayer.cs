using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal;
        public BusinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }
        //@ad = p.Ad, @soyad = p.Soyad, @telefon = p.Telefon, @email = p.email, @maas = p.maas, @sehir = p.sehir, @departman = p.departman 
        public int PersonelKaydet(string ad, string soyad, string telefon, string email,int maas, string sehir, string departman)
        {
            Personel p = new Personel();
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(departman))
            {
                p.Ad = ad;
                p.Soyad = soyad;
                p.Telefon = string.IsNullOrEmpty(telefon)?"":telefon;
                p.email = email;
                p.maas = maas;
                p.sehir = sehir;
                p.departman = departman;
            }
            return 1;
        }
    }
}