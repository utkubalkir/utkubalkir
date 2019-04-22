namespace Berut.FormsUI
{
    partial class FmInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmInput));
            this.tbxPlate = new System.Windows.Forms.TextBox();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.tbxDriver = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblVehicleInput = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPlate
            // 
            this.tbxPlate.BackColor = System.Drawing.Color.Silver;
            this.tbxPlate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPlate.ForeColor = System.Drawing.Color.Black;
            this.tbxPlate.Location = new System.Drawing.Point(536, 208);
            this.tbxPlate.Name = "tbxPlate";
            this.tbxPlate.Size = new System.Drawing.Size(161, 26);
            this.tbxPlate.TabIndex = 5;
            // 
            // tbxWeight
            // 
            this.tbxWeight.BackColor = System.Drawing.Color.Silver;
            this.tbxWeight.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxWeight.ForeColor = System.Drawing.Color.Black;
            this.tbxWeight.Location = new System.Drawing.Point(536, 291);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(161, 26);
            this.tbxWeight.TabIndex = 7;
            // 
            // tbxDriver
            // 
            this.tbxDriver.BackColor = System.Drawing.Color.Silver;
            this.tbxDriver.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDriver.ForeColor = System.Drawing.Color.Black;
            this.tbxDriver.Location = new System.Drawing.Point(536, 251);
            this.tbxDriver.Name = "tbxDriver";
            this.tbxDriver.Size = new System.Drawing.Size(161, 26);
            this.tbxDriver.TabIndex = 6;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPlate.Location = new System.Drawing.Point(444, 208);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(72, 22);
            this.lblPlate.TabIndex = 4;
            this.lblPlate.Text = "Plaka : ";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDriver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDriver.Location = new System.Drawing.Point(432, 251);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(84, 22);
            this.lblDriver.TabIndex = 8;
            this.lblDriver.Text = "Sürücü : ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWeight.Location = new System.Drawing.Point(437, 291);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(79, 22);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Ağırlık :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(737, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "TarihVeSaat";
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
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "KullanıcıAdı";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Black;
            this.lblSuccess.Location = new System.Drawing.Point(511, 431);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(161, 28);
            this.lblSuccess.TabIndex = 13;
            this.lblSuccess.Text = "KayıtDurumu";
            this.lblSuccess.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblVehicleInput
            // 
            this.lblVehicleInput.AutoSize = true;
            this.lblVehicleInput.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleInput.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVehicleInput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVehicleInput.Location = new System.Drawing.Point(260, 100);
            this.lblVehicleInput.Name = "lblVehicleInput";
            this.lblVehicleInput.Size = new System.Drawing.Size(187, 41);
            this.lblVehicleInput.TabIndex = 14;
            this.lblVehicleInput.Text = "Araç Girişi";
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
            this.btnReport.Location = new System.Drawing.Point(57, 373);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(125, 125);
            this.btnReport.TabIndex = 1;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.Transparent;
            this.btnOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOutput.BackgroundImage")));
            this.btnOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOutput.FlatAppearance.BorderSize = 0;
            this.btnOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOutput.Location = new System.Drawing.Point(57, 208);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(125, 125);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
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
            this.btnExit.Location = new System.Drawing.Point(813, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 75);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::Berut.FormsUI.Properties.Resources.datarecord;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(552, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Berut.FormsUI.Properties.Resources.GenelBG3;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVehicleInput);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.tbxDriver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxPlate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.tbxWeight);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblDriver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kapı Kantar Uygulaması";
            this.Load += new System.EventHandler(this.FmInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox tbxPlate;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox tbxDriver;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbxWeight;
        
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblVehicleInput;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnReport;
    }
}