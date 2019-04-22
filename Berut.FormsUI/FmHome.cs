using Berut.Business.Abstract;
using Berut.Business.Concrete;
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
    public partial class FmHome : Form
    {
        public FmHome()
        {
            InitializeComponent();
            _vehicleservice = new OTInsideManager(new MssqlOTInsideDal());
        }
        private IOTInsideService _vehicleservice;

       

        private void FmHome_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            timer.Start();

            LoadVehicle();


            int count = _vehicleservice.VehicleCount();
            lblVehicleCount.Text = count.ToString();

            lblUsername.Text = FmLogin.nickName.ToString();
        }

        private void LoadVehicle()
        {
            dgwOTInside.DataSource = _vehicleservice.GetAll();
        }

        private void btnVehicleInput_Click(object sender, EventArgs e)
        {
            FmInput fmInput = new FmInput();
            fmInput.Show();

            this.Close();
        }

        private void btnVehicleOutput_Click(object sender, EventArgs e)
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


        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FmLogin fmLogin = new FmLogin();
            fmLogin.Show();

            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
