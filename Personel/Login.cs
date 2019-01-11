using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace Personel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        BLL.BusinessLogicLayer bll ;
        private void button1_Click(object sender, EventArgs e)
        {
             bll = new BLL.BusinessLogicLayer();
           if( bll.LoginKontrol(textBox1.Text, textBox2.Text) > 0)
            {
                this.Visible = false;
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
    }
}
