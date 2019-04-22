using Berut.Business.Abstract;
using Berut.Business.Concrete;
using Berut.Entities.Concrete;
using BerutDataAccess.Concrete.MSSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berut.FormsUI
{
    
    public partial class FmLogin : Form
    {
        public static string nickName = "";
        public FmLogin()
        {
            InitializeComponent();
            _userservice = new UserManager(new MssqlUserDal());
        }

        private IUserService _userservice;

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
          var x= _userservice.Login(new User
            {
                UserName = tbxUserName.Text,
                Password = tbxPassword.Text 
            });

            if (Convert.ToInt32(x)==1)
            {
                nickName = tbxUserName.Text;
                FmHome fmHome = new FmHome();
                fmHome.Show();

                this.Hide();

                
            }

            else
            {
                MessageBox.Show("Giriş başarısız");
            }

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
