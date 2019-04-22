namespace Berut.FormsUI
{
    partial class FmHome
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblVehicleCount = new System.Windows.Forms.Label();
            this.lblInsideVehicleCount = new System.Windows.Forms.Label();
            this.btnVehicleInput = new System.Windows.Forms.Button();
            this.btnVehicleOutput = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgwOTInside = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOTInside)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(548, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 19);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "KullanıcıAdı";
            // 
            // lblVehicleCount
            // 
            this.lblVehicleCount.AutoSize = true;
            this.lblVehicleCount.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleCount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVehicleCount.ForeColor = System.Drawing.Color.White;
            this.lblVehicleCount.Location = new System.Drawing.Point(416, 21);
            this.lblVehicleCount.Name = "lblVehicleCount";
            this.lblVehicleCount.Size = new System.Drawing.Size(84, 19);
            this.lblVehicleCount.TabIndex = 5;
            this.lblVehicleCount.Text = "AraçSayısı";
            // 
            // lblInsideVehicleCount
            // 
            this.lblInsideVehicleCount.AutoSize = true;
            this.lblInsideVehicleCount.BackColor = System.Drawing.Color.Transparent;
            this.lblInsideVehicleCount.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInsideVehicleCount.ForeColor = System.Drawing.Color.White;
            this.lblInsideVehicleCount.Location = new System.Drawing.Point(263, 21);
            this.lblInsideVehicleCount.Name = "lblInsideVehicleCount";
            this.lblInsideVehicleCount.Size = new System.Drawing.Size(165, 19);
            this.lblInsideVehicleCount.TabIndex = 4;
            this.lblInsideVehicleCount.Text = "İçerideki araç sayısı : ";
            // 
            // btnVehicleInput
            // 
            this.btnVehicleInput.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleInput.BackgroundImage = global::Berut.FormsUI.Properties.Resources.aracgiris;
            this.btnVehicleInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVehicleInput.FlatAppearance.BorderSize = 0;
            this.btnVehicleInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVehicleInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVehicleInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleInput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVehicleInput.Location = new System.Drawing.Point(128, 230);
            this.btnVehicleInput.Name = "btnVehicleInput";
            this.btnVehicleInput.Size = new System.Drawing.Size(110, 110);
            this.btnVehicleInput.TabIndex = 0;
            this.btnVehicleInput.UseVisualStyleBackColor = false;
            this.btnVehicleInput.Click += new System.EventHandler(this.btnVehicleInput_Click);
            // 
            // btnVehicleOutput
            // 
            this.btnVehicleOutput.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleOutput.BackgroundImage = global::Berut.FormsUI.Properties.Resources.araccikis;
            this.btnVehicleOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVehicleOutput.FlatAppearance.BorderSize = 0;
            this.btnVehicleOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVehicleOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVehicleOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleOutput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVehicleOutput.Location = new System.Drawing.Point(12, 230);
            this.btnVehicleOutput.Name = "btnVehicleOutput";
            this.btnVehicleOutput.Size = new System.Drawing.Size(110, 110);
            this.btnVehicleOutput.TabIndex = 1;
            this.btnVehicleOutput.UseVisualStyleBackColor = false;
            this.btnVehicleOutput.Click += new System.EventHandler(this.btnVehicleOutput_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecord.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecord.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRecord.Location = new System.Drawing.Point(260, 100);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(291, 41);
            this.lblRecord.TabIndex = 8;
            this.lblRecord.Text = "İçerideki Araçlar";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(737, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 19);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "TarihveSaat";
            // 
            // dgwOTInside
            // 
            this.dgwOTInside.BackgroundColor = System.Drawing.Color.White;
            this.dgwOTInside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwOTInside.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwOTInside.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwOTInside.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwOTInside.ColumnHeadersHeight = 30;
            this.dgwOTInside.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Plate,
            this.Driver,
            this.EntryDate,
            this.AuthorizedName,
            this.Weight});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwOTInside.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwOTInside.EnableHeadersVisualStyles = false;
            this.dgwOTInside.Location = new System.Drawing.Point(267, 171);
            this.dgwOTInside.Name = "dgwOTInside";
            this.dgwOTInside.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwOTInside.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwOTInside.RowHeadersVisible = false;
            this.dgwOTInside.Size = new System.Drawing.Size(630, 303);
            this.dgwOTInside.TabIndex = 9;
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
            // AuthorizedName
            // 
            this.AuthorizedName.DataPropertyName = "AuthorizedName";
            this.AuthorizedName.HeaderText = "Kayıt Eden";
            this.AuthorizedName.Name = "AuthorizedName";
            this.AuthorizedName.Width = 120;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Giriş Ağırlığı";
            this.Weight.Name = "Weight";
            this.Weight.Width = 125;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.btnBack.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Location = new System.Drawing.Point(12, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImage = global::Berut.FormsUI.Properties.Resources.aracrapor;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReport.Location = new System.Drawing.Point(74, 346);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 110);
            this.btnReport.TabIndex = 2;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::Berut.FormsUI.Properties.Resources.uygcikis;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(813, 513);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 75);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Berut.FormsUI.Properties.Resources.GenelBG3;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnVehicleOutput);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnVehicleInput);
            this.Controls.Add(this.lblVehicleCount);
            this.Controls.Add(this.lblInsideVehicleCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwOTInside);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kapı Kantar Uygulaması";
            this.Load += new System.EventHandler(this.FmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOTInside)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVehicleCount;
        private System.Windows.Forms.Label lblInsideVehicleCount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnVehicleInput;
        private System.Windows.Forms.Button btnVehicleOutput;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridView dgwOTInside;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.Button btnBack;
    }
}