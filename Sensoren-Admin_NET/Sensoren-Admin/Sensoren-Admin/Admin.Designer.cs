namespace Sensoren {
    partial class Admin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.tabControlTemp = new System.Windows.Forms.TabControl();
            this.tabPageBen = new System.Windows.Forms.TabPage();
            this.dataGridViewBenutzer = new System.Windows.Forms.DataGridView();
            this.tabPageSensoren = new System.Windows.Forms.TabPage();
            this.dataGridViewSensoren = new System.Windows.Forms.DataGridView();
            this.tabPageTemp = new System.Windows.Forms.TabPage();
            this.dataGridViewTemperatur = new System.Windows.Forms.DataGridView();
            this.tabPageSensorMaxTemp = new System.Windows.Forms.TabPage();
            this.dataGridViewMaxTempSensor = new System.Windows.Forms.DataGridView();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControlTemp.SuspendLayout();
            this.tabPageBen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenutzer)).BeginInit();
            this.tabPageSensoren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoren)).BeginInit();
            this.tabPageTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemperatur)).BeginInit();
            this.tabPageSensorMaxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxTempSensor)).BeginInit();
            this.tabPageLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSpeichern);
            this.panel1.Controls.Add(this.buttonBeenden);
            this.panel1.Controls.Add(this.tabControlTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 450);
            this.panel1.TabIndex = 2;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSpeichern.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpeichern.Image")));
            this.buttonSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSpeichern.Location = new System.Drawing.Point(365, 356);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonSpeichern.Size = new System.Drawing.Size(137, 39);
            this.buttonSpeichern.TabIndex = 3;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = false;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBeenden.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeenden.Image = ((System.Drawing.Image)(resources.GetObject("buttonBeenden.Image")));
            this.buttonBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBeenden.Location = new System.Drawing.Point(748, 356);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonBeenden.Size = new System.Drawing.Size(137, 39);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = false;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControlTemp
            // 
            this.tabControlTemp.Controls.Add(this.tabPageBen);
            this.tabControlTemp.Controls.Add(this.tabPageSensoren);
            this.tabControlTemp.Controls.Add(this.tabPageTemp);
            this.tabControlTemp.Controls.Add(this.tabPageSensorMaxTemp);
            this.tabControlTemp.Controls.Add(this.tabPageLogs);
            this.tabControlTemp.ItemSize = new System.Drawing.Size(128, 30);
            this.tabControlTemp.Location = new System.Drawing.Point(0, 3);
            this.tabControlTemp.Name = "tabControlTemp";
            this.tabControlTemp.SelectedIndex = 0;
            this.tabControlTemp.Size = new System.Drawing.Size(924, 297);
            this.tabControlTemp.TabIndex = 0;
            this.tabControlTemp.SelectedIndexChanged += new System.EventHandler(this.tabControlTemp_SelectedIndexChanged);
            // 
            // tabPageBen
            // 
            this.tabPageBen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageBen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageBen.Controls.Add(this.dataGridViewBenutzer);
            this.tabPageBen.Location = new System.Drawing.Point(4, 34);
            this.tabPageBen.Name = "tabPageBen";
            this.tabPageBen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBen.Size = new System.Drawing.Size(916, 259);
            this.tabPageBen.TabIndex = 0;
            this.tabPageBen.Text = "Benutzerverwaltung";
            // 
            // dataGridViewBenutzer
            // 
            this.dataGridViewBenutzer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBenutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBenutzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBenutzer.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBenutzer.Name = "dataGridViewBenutzer";
            this.dataGridViewBenutzer.RowHeadersWidth = 51;
            this.dataGridViewBenutzer.RowTemplate.Height = 24;
            this.dataGridViewBenutzer.Size = new System.Drawing.Size(910, 253);
            this.dataGridViewBenutzer.TabIndex = 0;
            // 
            // tabPageSensoren
            // 
            this.tabPageSensoren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageSensoren.Controls.Add(this.dataGridViewSensoren);
            this.tabPageSensoren.Location = new System.Drawing.Point(4, 34);
            this.tabPageSensoren.Name = "tabPageSensoren";
            this.tabPageSensoren.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensoren.Size = new System.Drawing.Size(916, 259);
            this.tabPageSensoren.TabIndex = 1;
            this.tabPageSensoren.Text = "Sensorverwaltung";
            // 
            // dataGridViewSensoren
            // 
            this.dataGridViewSensoren.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSensoren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensoren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSensoren.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSensoren.Name = "dataGridViewSensoren";
            this.dataGridViewSensoren.RowHeadersWidth = 51;
            this.dataGridViewSensoren.RowTemplate.Height = 24;
            this.dataGridViewSensoren.Size = new System.Drawing.Size(910, 253);
            this.dataGridViewSensoren.TabIndex = 0;
            // 
            // tabPageTemp
            // 
            this.tabPageTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageTemp.Controls.Add(this.dataGridViewTemperatur);
            this.tabPageTemp.Location = new System.Drawing.Point(4, 34);
            this.tabPageTemp.Name = "tabPageTemp";
            this.tabPageTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemp.Size = new System.Drawing.Size(916, 259);
            this.tabPageTemp.TabIndex = 2;
            this.tabPageTemp.Text = "Temperaturverwaltung";
            // 
            // dataGridViewTemperatur
            // 
            this.dataGridViewTemperatur.AllowUserToOrderColumns = true;
            this.dataGridViewTemperatur.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTemperatur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemperatur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTemperatur.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTemperatur.Name = "dataGridViewTemperatur";
            this.dataGridViewTemperatur.RowHeadersWidth = 51;
            this.dataGridViewTemperatur.RowTemplate.Height = 24;
            this.dataGridViewTemperatur.Size = new System.Drawing.Size(910, 253);
            this.dataGridViewTemperatur.TabIndex = 0;
            this.dataGridViewTemperatur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTemperatur_CellClick);
            // 
            // tabPageSensorMaxTemp
            // 
            this.tabPageSensorMaxTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageSensorMaxTemp.Controls.Add(this.dataGridViewMaxTempSensor);
            this.tabPageSensorMaxTemp.Location = new System.Drawing.Point(4, 34);
            this.tabPageSensorMaxTemp.Name = "tabPageSensorMaxTemp";
            this.tabPageSensorMaxTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensorMaxTemp.Size = new System.Drawing.Size(916, 259);
            this.tabPageSensorMaxTemp.TabIndex = 3;
            this.tabPageSensorMaxTemp.Text = "Max. Temp. Verwaltung";
            // 
            // dataGridViewMaxTempSensor
            // 
            this.dataGridViewMaxTempSensor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMaxTempSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaxTempSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaxTempSensor.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMaxTempSensor.Name = "dataGridViewMaxTempSensor";
            this.dataGridViewMaxTempSensor.RowHeadersWidth = 51;
            this.dataGridViewMaxTempSensor.RowTemplate.Height = 24;
            this.dataGridViewMaxTempSensor.Size = new System.Drawing.Size(910, 253);
            this.dataGridViewMaxTempSensor.TabIndex = 0;
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageLogs.Controls.Add(this.dataGridViewLogs);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 34);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(916, 259);
            this.tabPageLogs.TabIndex = 4;
            this.tabPageLogs.Text = "Log-Daten";
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 24;
            this.dataGridViewLogs.Size = new System.Drawing.Size(910, 253);
            this.dataGridViewLogs.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Sensoren-Administrator";
            this.panel1.ResumeLayout(false);
            this.tabControlTemp.ResumeLayout(false);
            this.tabPageBen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenutzer)).EndInit();
            this.tabPageSensoren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoren)).EndInit();
            this.tabPageTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemperatur)).EndInit();
            this.tabPageSensorMaxTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxTempSensor)).EndInit();
            this.tabPageLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlTemp;
        private System.Windows.Forms.TabPage tabPageBen;
        private System.Windows.Forms.TabPage tabPageSensoren;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.DataGridView dataGridViewBenutzer;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.TabPage tabPageTemp;
        private System.Windows.Forms.DataGridView dataGridViewTemperatur;
        private System.Windows.Forms.DataGridView dataGridViewSensoren;
        private System.Windows.Forms.TabPage tabPageSensorMaxTemp;
        private System.Windows.Forms.DataGridView dataGridViewMaxTempSensor;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
    }
}