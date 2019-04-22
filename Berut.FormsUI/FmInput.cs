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
    public partial class FmInput : Form
    {
        public FmInput()
        {
            InitializeComponent();
            _vehicleservice = new OTInsideManager(new MssqlOTInsideDal());
        }
        private IOTInsideService _vehicleservice;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _vehicleservice.Add(new OTInside
                {
                    Plate = tbxPlate.Text,
                    Driver = tbxDriver.Text,
                    EntryDate = DateTime.Now,
                    Weight = Convert.ToInt32(tbxWeight.Text),
                    AuthorizedName = FmLogin.nickName.ToString()


                });
                lblSuccess.Visible = true;
                lblSuccess.Text = "Kayıt başarılı";
            }
            catch 
            {
                lblSuccess.Visible = true;
                lblSuccess.Text = "Kayıt başarısız";
                
            }

            
            

        }

        private void FmInput_Load(object sender, EventArgs e)
        {
            lblUsername.Text = FmLogin.nickName.ToString();
            lblTime.Text = DateTime.Now.ToString();

            timer.Start();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FmOutput fmOutput = new FmOutput();
            fmOutput.Show();

            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FmReport fmReport = new FmReport();
            fmReport.Show();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FmHome fmHome = new FmHome();
            fmHome.Show();

            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

       
    }
}
