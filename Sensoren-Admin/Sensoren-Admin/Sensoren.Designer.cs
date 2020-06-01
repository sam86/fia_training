namespace Sensoren {
    partial class Sensoren {
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
            this.panelSen = new System.Windows.Forms.Panel();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonTmpSensHer = new System.Windows.Forms.Button();
            this.buttonSensorTemp = new System.Windows.Forms.Button();
            this.buttonSensoren = new System.Windows.Forms.Button();
            this.buttonUeber = new System.Windows.Forms.Button();
            this.tabControlTemp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSensoren = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonTempDateDesc = new System.Windows.Forms.Button();
            this.buttonTempGen = new System.Windows.Forms.Button();
            this.buttonSensMax = new System.Windows.Forms.Button();
            this.buttonSensAvg = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.panelSen.SuspendLayout();
            this.tabControlTemp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoren)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSen
            // 
            this.panelSen.Controls.Add(this.buttonBeenden);
            this.panelSen.Controls.Add(this.Test);
            this.panelSen.Controls.Add(this.buttonSpeichern);
            this.panelSen.Controls.Add(this.buttonSensAvg);
            this.panelSen.Controls.Add(this.buttonSensMax);
            this.panelSen.Controls.Add(this.buttonTempGen);
            this.panelSen.Controls.Add(this.buttonTempDateDesc);
            this.panelSen.Controls.Add(this.buttonLast);
            this.panelSen.Controls.Add(this.buttonTmpSensHer);
            this.panelSen.Controls.Add(this.buttonSensorTemp);
            this.panelSen.Controls.Add(this.buttonSensoren);
            this.panelSen.Controls.Add(this.buttonUeber);
            this.panelSen.Controls.Add(this.tabControlTemp);
            this.panelSen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSen.Location = new System.Drawing.Point(0, 0);
            this.panelSen.Name = "panelSen";
            this.panelSen.Size = new System.Drawing.Size(1174, 518);
            this.panelSen.TabIndex = 0;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(14, 447);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(121, 31);
            this.buttonLast.TabIndex = 6;
            this.buttonLast.Text = "Letzte 10 Temp";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonTmpSensHer
            // 
            this.buttonTmpSensHer.Location = new System.Drawing.Point(14, 410);
            this.buttonTmpSensHer.Name = "buttonTmpSensHer";
            this.buttonTmpSensHer.Size = new System.Drawing.Size(121, 31);
            this.buttonTmpSensHer.TabIndex = 5;
            this.buttonTmpSensHer.Text = "TempSensHers";
            this.buttonTmpSensHer.UseVisualStyleBackColor = true;
            this.buttonTmpSensHer.Click += new System.EventHandler(this.buttonTmpSensHer_Click);
            // 
            // buttonSensorTemp
            // 
            this.buttonSensorTemp.Location = new System.Drawing.Point(13, 376);
            this.buttonSensorTemp.Name = "buttonSensorTemp";
            this.buttonSensorTemp.Size = new System.Drawing.Size(122, 30);
            this.buttonSensorTemp.TabIndex = 4;
            this.buttonSensorTemp.Text = "SensorenTemp";
            this.buttonSensorTemp.UseVisualStyleBackColor = true;
            this.buttonSensorTemp.Click += new System.EventHandler(this.buttonSensorTemp_Click);
            // 
            // buttonSensoren
            // 
            this.buttonSensoren.Location = new System.Drawing.Point(12, 339);
            this.buttonSensoren.Name = "buttonSensoren";
            this.buttonSensoren.Size = new System.Drawing.Size(122, 30);
            this.buttonSensoren.TabIndex = 3;
            this.buttonSensoren.Text = "Sensoren";
            this.buttonSensoren.UseVisualStyleBackColor = true;
            this.buttonSensoren.Click += new System.EventHandler(this.buttonSensoren_Click);
            // 
            // buttonUeber
            // 
            this.buttonUeber.Location = new System.Drawing.Point(12, 302);
            this.buttonUeber.Name = "buttonUeber";
            this.buttonUeber.Size = new System.Drawing.Size(122, 31);
            this.buttonUeber.TabIndex = 2;
            this.buttonUeber.Text = "Übersicht";
            this.buttonUeber.UseVisualStyleBackColor = true;
            this.buttonUeber.Click += new System.EventHandler(this.buttonUeber_Click);
            // 
            // tabControlTemp
            // 
            this.tabControlTemp.Controls.Add(this.tabPage1);
            this.tabControlTemp.Controls.Add(this.tabPage2);
            this.tabControlTemp.Controls.Add(this.tabPage3);
            this.tabControlTemp.Location = new System.Drawing.Point(3, 0);
            this.tabControlTemp.Name = "tabControlTemp";
            this.tabControlTemp.SelectedIndex = 0;
            this.tabControlTemp.Size = new System.Drawing.Size(1171, 296);
            this.tabControlTemp.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1163, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übersicht";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1157, 261);
            this.dataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSensoren);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1163, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sensoren";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSensoren
            // 
            this.dataGridViewSensoren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensoren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSensoren.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSensoren.Name = "dataGridViewSensoren";
            this.dataGridViewSensoren.RowHeadersWidth = 51;
            this.dataGridViewSensoren.RowTemplate.Height = 24;
            this.dataGridViewSensoren.Size = new System.Drawing.Size(1157, 261);
            this.dataGridViewSensoren.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1163, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SensorenTemp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1157, 261);
            this.dataGridView3.TabIndex = 0;
            // 
            // buttonTempDateDesc
            // 
            this.buttonTempDateDesc.Location = new System.Drawing.Point(14, 482);
            this.buttonTempDateDesc.Name = "buttonTempDateDesc";
            this.buttonTempDateDesc.Size = new System.Drawing.Size(188, 31);
            this.buttonTempDateDesc.TabIndex = 7;
            this.buttonTempDateDesc.Text = "letz 10 Temp Date Desc";
            this.buttonTempDateDesc.UseVisualStyleBackColor = true;
            this.buttonTempDateDesc.Click += new System.EventHandler(this.buttonTempDateDesc_Click);
            // 
            // buttonTempGen
            // 
            this.buttonTempGen.Location = new System.Drawing.Point(1043, 311);
            this.buttonTempGen.Name = "buttonTempGen";
            this.buttonTempGen.Size = new System.Drawing.Size(124, 44);
            this.buttonTempGen.TabIndex = 8;
            this.buttonTempGen.Text = "Temperatur generieren";
            this.buttonTempGen.UseVisualStyleBackColor = true;
            this.buttonTempGen.Click += new System.EventHandler(this.buttonTempGen_Click);
            // 
            // buttonSensMax
            // 
            this.buttonSensMax.Location = new System.Drawing.Point(141, 303);
            this.buttonSensMax.Name = "buttonSensMax";
            this.buttonSensMax.Size = new System.Drawing.Size(138, 30);
            this.buttonSensMax.TabIndex = 9;
            this.buttonSensMax.Text = "MaxTempSensor";
            this.buttonSensMax.UseVisualStyleBackColor = true;
            this.buttonSensMax.Click += new System.EventHandler(this.buttonSensMax_Click);
            // 
            // buttonSensAvg
            // 
            this.buttonSensAvg.Location = new System.Drawing.Point(141, 339);
            this.buttonSensAvg.Name = "buttonSensAvg";
            this.buttonSensAvg.Size = new System.Drawing.Size(138, 30);
            this.buttonSensAvg.TabIndex = 10;
            this.buttonSensAvg.Text = "AvgTempSensor";
            this.buttonSensAvg.UseVisualStyleBackColor = true;
            this.buttonSensAvg.Click += new System.EventHandler(this.buttonSensAvg_Click);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(1043, 383);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(119, 42);
            this.buttonSpeichern.TabIndex = 11;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(878, 454);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(97, 42);
            this.Test.TabIndex = 12;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(1043, 453);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(119, 44);
            this.buttonBeenden.TabIndex = 13;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // Sensoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 518);
            this.Controls.Add(this.panelSen);
            this.Name = "Sensoren";
            this.Text = "Sensoren";
            this.panelSen.ResumeLayout(false);
            this.tabControlTemp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensoren)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSen;
        private System.Windows.Forms.TabControl tabControlTemp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSensoren;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonUeber;
        private System.Windows.Forms.Button buttonSensoren;
        private System.Windows.Forms.Button buttonSensorTemp;
        private System.Windows.Forms.Button buttonTmpSensHer;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonTempDateDesc;
        private System.Windows.Forms.Button buttonTempGen;
        private System.Windows.Forms.Button buttonSensMax;
        private System.Windows.Forms.Button buttonSensAvg;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button buttonBeenden;
    }
}