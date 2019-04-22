namespace Berut.FormsUI
{
    partial class FmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpGap1 = new System.Windows.Forms.DateTimePicker();
            this.dtpGap2 = new System.Windows.Forms.DateTimePicker();
            this.sfdExportExcel = new System.Windows.Forms.SaveFileDialog();
            this.tbxSearchByPlate = new System.Windows.Forms.TextBox();
            this.dgwOTOutputs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblSearcByPlate = new System.Windows.Forms.Label();
            this.lblBtwn2Dts = new System.Windows.Forms.Label();
            this.lblExportExcel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOTOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpGap1
            // 
            this.dtpGap1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGap1.Location = new System.Drawing.Point(370, 406);
            this.dtpGap1.Name = "dtpGap1";
            this.dtpGap1.Size = new System.Drawing.Size(190, 23);
            this.dtpGap1.TabIndex = 2;
            this.dtpGap1.ValueChanged += new System.EventHandler(this.dtpGap1_ValueChanged);
            // 
            // dtpGap2
            // 
            this.dtpGap2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGap2.Location = new System.Drawing.Point(585, 406);
            this.dtpGap2.Name = "dtpGap2";
            this.dtpGap2.Size = new System.Drawing.Size(190, 23);
            this.dtpGap2.TabIndex = 3;
            this.dtpGap2.ValueChanged += new System.EventHandler(this.dtpGap2_ValueChanged);
            // 
            // tbxSearchByPlate
            // 
            this.tbxSearchByPlate.BackColor = System.Drawing.Color.Silver;
            this.tbxSearchByPlate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchByPlate.ForeColor = System.Drawing.Color.Black;
            this.tbxSearchByPlate.Location = new System.Drawing.Point(730, 102);
            this.tbxSearchByPlate.Name = "tbxSearchByPlate";
            this.tbxSearchByPlate.Size = new System.Drawing.Size(135, 25);
            this.tbxSearchByPlate.TabIndex = 6;
            this.tbxSearchByPlate.TextChanged += new System.EventHandler(this.tbxSearchByPlate_TextChanged);
            // 
            // dgwOTOutputs
            // 
            this.dgwOTOutputs.BackgroundColor = System.Drawing.Color.White;
            this.dgwOTOutputs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwOTOutputs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwOTOutputs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwOTOutputs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwOTOutputs.ColumnHeadersHeight = 50;
            this.dgwOTOutputs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Plate,
            this.Driver,
            this.EntryDate,
            this.ReleaseDate,
            this.AuthorizedName,
            this.EntryWeight,
            this.ReleaseWeight,
            this.ProductWeight});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwOTOutputs.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwOTOutputs.EnableHeadersVisualStyles = false;
            this.dgwOTOutputs.Location = new System.Drawing.Point(12, 133);
            this.dgwOTOutputs.Name = "dgwOTOutputs";
            this.dgwOTOutputs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwOTOutputs.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwOTOutputs.RowHeadersVisible = false;
            this.dgwOTOutputs.Size = new System.Drawing.Size(876, 232);
            this.dgwOTOutputs.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Plaka";
            this.Plate.Name = "Plate";
            // 
            // Driver
            // 
            this.Driver.DataPropertyName = "Driver";
            this.Driver.HeaderText = "Sürücü";
            this.Driver.Name = "Driver";
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "Giriş Tarihi";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.Width = 125;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Çıkış Tarihi";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Width = 125;
            // 
            // AuthorizedName
            // 
            this.AuthorizedName.DataPropertyName = "AuthorizedName";
            this.AuthorizedName.HeaderText = "Kayıt Eden";
            this.AuthorizedName.Name = "AuthorizedName";
            this.AuthorizedName.Width = 90;
            // 
            // EntryWeight
            // 
            this.EntryWeight.DataPropertyName = "EntryWeight";
            this.EntryWeight.HeaderText = "Giriş Ağırlığı";
            this.EntryWeight.Name = "EntryWeight";
            this.EntryWeight.Width = 90;
            // 
            // ReleaseWeight
            // 
            this.ReleaseWeight.DataPropertyName = "ReleaseWeight";
            this.ReleaseWeight.HeaderText = "Çıkış Ağırlığı";
            this.ReleaseWeight.Name = "ReleaseWeight";
            this.ReleaseWeight.Width = 90;
            // 
            // ProductWeight
            // 
            this.ProductWeight.DataPropertyName = "ProductWeight";
            this.ProductWeight.HeaderText = "Ürün Ağırlığı";
            this.ProductWeight.Name = "ProductWeight";
            this.ProductWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProductWeight.Width = 85;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.BackColor = System.Drawing.Color.Transparent;
            this.lblReport.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReport.Location = new System.Drawing.Point(32, 75);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(197, 41);
            this.lblReport.TabIndex = 11;
            this.lblReport.Text = "Raporlama";
            // 
            // lblSearcByPlate
            // 
            this.lblSearcByPlate.AutoSize = true;
            this.lblSearcByPlate.BackColor = System.Drawing.Color.Transparent;
            this.lblSearcByPlate.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearcByPlate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSearcByPlate.Location = new System.Drawing.Point(551, 102);
            this.lblSearcByPlate.Name = "lblSearcByPlate";
            this.lblSearcByPlate.Size = new System.Drawing.Size(173, 22);
            this.lblSearcByPlate.TabIndex = 12;
            this.lblSearcByPlate.Text = "Plakaya Göre Ara : ";
            // 
            // lblBtwn2Dts
            // 
            this.lblBtwn2Dts.AutoSize = true;
            this.lblBtwn2Dts.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBtwn2Dts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBtwn2Dts.Location = new System.Drawing.Point(35, 407);
            this.lblBtwn2Dts.Name = "lblBtwn2Dts";
            this.lblBtwn2Dts.Size = new System.Drawing.Size(310, 22);
            this.lblBtwn2Dts.TabIndex = 13;
            this.lblBtwn2Dts.Text = "İki Tarih Arasındaki Verileri Getir : ";
            // 
            // lblExportExcel
            // 
            this.lblExportExcel.AutoSize = true;
            this.lblExportExcel.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExportExcel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExportExcel.Location = new System.Drawing.Point(211, 446);
            this.lblExportExcel.Name = "lblExportExcel";
            this.lblExportExcel.Size = new System.Drawing.Size(134, 22);
            this.lblExportExcel.TabIndex = 14;
            this.lblExportExcel.Text = "Excel\'e Aktar : ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Berut.FormsUI.Properties.Resources.uygcikis;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(790, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 75);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImage = global::Berut.FormsUI.Properties.Resources._7728a6c88b;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(370, 446);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 75);
            this.btnExport.TabIndex = 5;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Berut.FormsUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(30, 513);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Berut.FormsUI.Properties.Resources.RaporBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblExportExcel);
            this.Controls.Add(this.lblBtwn2Dts);
            this.Controls.Add(this.lblSearcByPlate);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.dgwOTOutputs);
            this.Controls.Add(this.tbxSearchByPlate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtpGap2);
            this.Controls.Add(this.dtpGap1);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kapı Kantar Uygulaması";
            this.Load += new System.EventHandler(this.FmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOTOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpGap1;
        private System.Windows.Forms.DateTimePicker dtpGap2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdExportExcel;
        private System.Windows.Forms.TextBox tbxSearchByPlate;
        private System.Windows.Forms.DataGridView dgwOTOutputs;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblSearcByPlate;
        private System.Windows.Forms.Label lblBtwn2Dts;
        private System.Windows.Forms.Label lblExportExcel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductWeight;
    }
}