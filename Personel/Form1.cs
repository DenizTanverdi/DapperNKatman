using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace Personel
{
    public partial class Form1 : Form
    {
        BLL.BusinessLogicLayer bl;
        public Form1()
        {
            InitializeComponent();
            bl = new BLL.BusinessLogicLayer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string mail = txtBxMail.Text;
            bool kontrol = EmailKontrol(mail);

            if (kontrol == true)
            {
                int k = bl.PersonelKaydet(txtBxName.Text, txtBxSurname.Text, txtBxPhone.Text, txtBxMail.Text, Convert.ToInt32(txtBxMaas.Text), txtBxCity.Text, txtBxDep.Text);
                if (k > 0)
                {
                    MessageBox.Show("Basarili");


                }
                else
                {
                    MessageBox.Show("Basarisiz");
                }
            }
            else
            {
                MessageBox.Show("Yanlış");
            }


            
            
        }

        private void txtBxMaas_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }

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
