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
using Excel =Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace Berut.FormsUI
{
    public partial class FmReport : Form
    {
        public FmReport()
        {
            _vehicleService = new OTOutputManager(new MssqlOTOutputDal());
            InitializeComponent();

        }

        private IOTOuputService _vehicleService;

        private void btnBack_Click(object sender, EventArgs e)
        {
            FmHome fmHome = new FmHome();
            fmHome.Show();

            this.Close();

        }

        private void FmReport_Load(object sender, EventArgs e)
        {
            LoadVehicle();
        }

        private void LoadVehicle()
        {
            dgwOTOutputs.DataSource = _vehicleService.GetAll();

        }

       

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            sfdExportExcel.InitialDirectory = "C:";
            sfdExportExcel.Title = "Save as Excel File";
            sfdExportExcel.FileName = "";
            sfdExportExcel.Filter = "Excel Files(2007)|*.xlsx";

            if (sfdExportExcel.ShowDialog() != DialogResult.Cancel)
            {
               

                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgwOTOutputs.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dgwOTOutputs.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgwOTOutputs.Rows.Count; i++)
                {
                    for (int j = 0; j < dgwOTOutputs.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dgwOTOutputs.Rows[i].Cells[j].Value.ToString();
                    }
                }

                excelApp.ActiveWorkbook.SaveCopyAs(sfdExportExcel.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();
            }
        }

        private void tbxSearchByPlate_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchByPlate.Text;
            dgwOTOutputs.DataSource = _vehicleService.GetByPlate(key);
        }

        private void dtpGap2_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dtpGap1.Value.ToShortDateString();
            string date2 = dtpGap2.Value.AddDays(1).ToShortDateString();

            dgwOTOutputs.DataSource = _vehicleService.GetByDate(date1, date2);
        }

        private void dtpGap1_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dtpGap1.Value.ToShortDateString();
            string date2 = dtpGap2.Value.AddDays(1).ToShortDateString();

            dgwOTOutputs.DataSource = _vehicleService.GetByDate(date1, date2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
