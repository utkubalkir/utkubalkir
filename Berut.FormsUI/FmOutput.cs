using Berut.Business.Abstract;
using Berut.Business.Concrete;
using Berut.Entities.Concrete;
using BerutDataAccess.Concrete.MSSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berut.FormsUI
{
    public partial class FmOutput : Form
    {
        

        public FmOutput()
        {
            InitializeComponent();
            _vehicleservice = new OTInsideManager(new MssqlOTInsideDal());
            _vehicleservice2 = new OTOutputManager(new MssqlOTOutputDal());
        }
        private IOTInsideService _vehicleservice;
        private IOTOuputService _vehicleservice2;

      

        

        private void FmOutput_Load(object sender, EventArgs e)
        {
            LoadVehicle();
            lblUsername.Text = FmLogin.nickName.ToString();
            lblTime.Text = DateTime.Now.ToString();
            timer.Start();

        }

        private void LoadVehicle()
        {
            dgwOTInside.DataSource = _vehicleservice.GetAll();
        }

        

        

        private void tbxSearchByPlate_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchByPlate.Text;
            dgwOTInside.DataSource = _vehicleservice.GetByPlate(key);
        }

        private void dgwOTInside_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lblWeight2.BackColor = Color.Red;
            lblWeight2.Text= dgwOTInside.CurrentRow.Cells[5].Value.ToString()+" kg";
            lblWeight2.Visible = true;

            tbxPlate.Text = dgwOTInside.CurrentRow.Cells[1].Value.ToString();
            tbxDriver.Text = dgwOTInside.CurrentRow.Cells[2].Value.ToString();
            tbxEntryWeight.Text = dgwOTInside.CurrentRow.Cells[5].Value.ToString();

            tbxReleaseWeight.Text = "";
            tbxProductWeight.Text = "";
            

           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnVehicleInput_Click(object sender, EventArgs e)
        {
            FmInput fmInput = new FmInput();
            fmInput.Show();

            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FmReport fmReport = new FmReport();
            fmReport.Show();

            this.Close();
        }

        private void btnReadCOM_Click(object sender, EventArgs e)
        {
            
            int weight = Convert.ToInt32(dgwOTInside.CurrentRow.Cells[5].Value.ToString());
            int relWeight = Convert.ToInt32(_vehicleservice2.DummyWeight());

            tbxReleaseWeight.Text = relWeight.ToString();

            int productWeight = relWeight - weight;
            tbxProductWeight.Text = productWeight.ToString();
            lblWeight2.Visible = true;

            lblWeight2.Text = tbxReleaseWeight.Text + " kg";



            lblWeight2.BackColor = Color.Lime;

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {


            _vehicleservice2.Add(new OTOutput
            {
                Plate = tbxPlate.Text,
                Driver = tbxDriver.Text,
                EntryDate = Convert.ToDateTime(dgwOTInside.CurrentRow.Cells[3].Value.ToString()),
                ReleaseDate = DateTime.Now,
                EntryWeight = Convert.ToInt32(dgwOTInside.CurrentRow.Cells[5].Value.ToString()),
                ReleaseWeight = Convert.ToInt32(tbxReleaseWeight.Text),
                ProductWeight = Convert.ToInt32(tbxProductWeight.Text),

                AuthorizedName = FmLogin.nickName.ToString()

            });

            _vehicleservice.Delete(new OTInside
            {
                Id = Convert.ToInt32(dgwOTInside.CurrentRow.Cells[0].Value.ToString())
            });

            LoadVehicle();




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
    }
}
