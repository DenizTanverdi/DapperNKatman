using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            int kayitSayisi;
            Personel p = new Personel();
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(departman))
            {
                p.Ad = ad;
                p.Soyad = soyad;
                p.Telefon = string.IsNullOrEmpty(telefon)?"":telefon;
                p.email = email;
                p.maas = (maas>0)?maas:2020;
                p.sehir = string.IsNullOrEmpty(sehir) ? "" : sehir;
                p.departman = departman;
                dal.PersonelKaydet(p);
                kayitSayisi = 1;
            }
            else
            {
                kayitSayisi = -1;
            }
            return kayitSayisi;
        }
        public int LoginKontrol(string email,string password)
        { int ret = 0;
            User u = new User();
           bool kontrol=EmailKontrol(email);
            bool k = !(string.IsNullOrEmpty(password));
            if (kontrol&&k)
            {
                u.email = email;
                u.password = password;
                ret = dal.LoginKontrol(u);
            }
            else
            {
                ret = -1;
            }

            return ret;
        }
        static bool EmailKontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }
    }
}