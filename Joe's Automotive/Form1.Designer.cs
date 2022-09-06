namespace Joe_s_Automotive
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gboxOilLube = new System.Windows.Forms.GroupBox();
            this.cboxLube = new System.Windows.Forms.CheckBox();
            this.cboxOil = new System.Windows.Forms.CheckBox();
            this.gboxFlushes = new System.Windows.Forms.GroupBox();
            this.cboxTransmission = new System.Windows.Forms.CheckBox();
            this.cboxRadiator = new System.Windows.Forms.CheckBox();
            this.gboxPartsLabor = new System.Windows.Forms.GroupBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.txtboxLabor = new System.Windows.Forms.TextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtboxParts = new System.Windows.Forms.TextBox();
            this.gboxMisc = new System.Windows.Forms.GroupBox();
            this.cboxTire = new System.Windows.Forms.CheckBox();
            this.cboxMuffler = new System.Windows.Forms.CheckBox();
            this.cboxInspection = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gboxSummary = new System.Windows.Forms.GroupBox();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.txtboxSummaryTotal = new System.Windows.Forms.TextBox();
            this.lblSummaryTax = new System.Windows.Forms.Label();
            this.txtboxSummaryTax = new System.Windows.Forms.TextBox();
            this.lblSummaryParts = new System.Windows.Forms.Label();
            this.txtboxSummaryParts = new System.Windows.Forms.TextBox();
            this.lblSummaryService = new System.Windows.Forms.Label();
            this.txtboxSummaryService = new System.Windows.Forms.TextBox();
            this.gboxOilLube.SuspendLayout();
            this.gboxFlushes.SuspendLayout();
            this.gboxPartsLabor.SuspendLayout();
            this.gboxMisc.SuspendLayout();
            this.gboxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOilLube
            // 
            this.gboxOilLube.Controls.Add(this.cboxLube);
            this.gboxOilLube.Controls.Add(this.cboxOil);
            this.gboxOilLube.Location = new System.Drawing.Point(12, 12);
            this.gboxOilLube.Name = "gboxOilLube";
            this.gboxOilLube.Size = new System.Drawing.Size(206, 80);
            this.gboxOilLube.TabIndex = 0;
            this.gboxOilLube.TabStop = false;
            this.gboxOilLube.Text = "Oil and Lube";
            // 
            // cboxLube
            // 
            this.cboxLube.AutoSize = true;
            this.cboxLube.Location = new System.Drawing.Point(6, 47);
            this.cboxLube.Name = "cboxLube";
            this.cboxLube.Size = new System.Drawing.Size(130, 20);
            this.cboxLube.TabIndex = 2;
            this.cboxLube.Text = "Lube job ($18.00)";
            this.cboxLube.UseVisualStyleBackColor = true;
            // 
            // cboxOil
            // 
            this.cboxOil.AutoSize = true;
            this.cboxOil.Location = new System.Drawing.Point(6, 21);
            this.cboxOil.Name = "cboxOil";
            this.cboxOil.Size = new System.Drawing.Size(142, 20);
            this.cboxOil.TabIndex = 1;
            this.cboxOil.Text = "Oil change ($26.00)";
            this.cboxOil.UseVisualStyleBackColor = true;
            // 
            // gboxFlushes
            // 
            this.gboxFlushes.Controls.Add(this.cboxTransmission);
            this.gboxFlushes.Controls.Add(this.cboxRadiator);
            this.gboxFlushes.Location = new System.Drawing.Point(224, 12);
            this.gboxFlushes.Name = "gboxFlushes";
            this.gboxFlushes.Size = new System.Drawing.Size(206, 80);
            this.gboxFlushes.TabIndex = 3;
            this.gboxFlushes.TabStop = false;
            this.gboxFlushes.Text = "Flushes";
            // 
            // cboxTransmission
            // 
            this.cboxTransmission.AutoSize = true;
            this.cboxTransmission.Location = new System.Drawing.Point(6, 47);
            this.cboxTransmission.Name = "cboxTransmission";
            this.cboxTransmission.Size = new System.Drawing.Size(189, 20);
            this.cboxTransmission.TabIndex = 2;
            this.cboxTransmission.Text = "Transmission flush ($80.00)";
            this.cboxTransmission.UseVisualStyleBackColor = true;
            // 
            // cboxRadiator
            // 
            this.cboxRadiator.AutoSize = true;
            this.cboxRadiator.Location = new System.Drawing.Point(6, 21);
            this.cboxRadiator.Name = "cboxRadiator";
            this.cboxRadiator.Size = new System.Drawing.Size(160, 20);
            this.cboxRadiator.TabIndex = 1;
            this.cboxRadiator.Text = "Radiator flush ($30.00)";
            this.cboxRadiator.UseVisualStyleBackColor = true;
            // 
            // gboxPartsLabor
            // 
            this.gboxPartsLabor.Controls.Add(this.lblLabor);
            this.gboxPartsLabor.Controls.Add(this.txtboxLabor);
            this.gboxPartsLabor.Controls.Add(this.lblParts);
            this.gboxPartsLabor.Controls.Add(this.txtboxParts);
            this.gboxPartsLabor.Location = new System.Drawing.Point(224, 98);
            this.gboxPartsLabor.Name = "gboxPartsLabor";
            this.gboxPartsLabor.Size = new System.Drawing.Size(206, 103);
            this.gboxPartsLabor.TabIndex = 5;
            this.gboxPartsLabor.TabStop = false;
            this.gboxPartsLabor.Text = "Parts and Labor";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(26, 60);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(42, 16);
            this.lblLabor.TabIndex = 10;
            this.lblLabor.Text = "Labor";
            // 
            // txtboxLabor
            // 
            this.txtboxLabor.Location = new System.Drawing.Point(75, 57);
            this.txtboxLabor.Name = "txtboxLabor";
            this.txtboxLabor.Size = new System.Drawing.Size(100, 22);
            this.txtboxLabor.TabIndex = 9;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(26, 32);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(38, 16);
            this.lblParts.TabIndex = 8;
            this.lblParts.Text = "Parts";
            // 
            // txtboxParts
            // 
            this.txtboxParts.Location = new System.Drawing.Point(75, 29);
            this.txtboxParts.Name = "txtboxParts";
            this.txtboxParts.Size = new System.Drawing.Size(100, 22);
            this.txtboxParts.TabIndex = 7;
            // 
            // gboxMisc
            // 
            this.gboxMisc.Controls.Add(this.cboxTire);
            this.gboxMisc.Controls.Add(this.cboxMuffler);
            this.gboxMisc.Controls.Add(this.cboxInspection);
            this.gboxMisc.Location = new System.Drawing.Point(12, 98);
            this.gboxMisc.Name = "gboxMisc";
            this.gboxMisc.Size = new System.Drawing.Size(206, 103);
            this.gboxMisc.TabIndex = 4;
            this.gboxMisc.TabStop = false;
            this.gboxMisc.Text = "Miscellaneous";
            // 
            // cboxTire
            // 
            this.cboxTire.AutoSize = true;
            this.cboxTire.Location = new System.Drawing.Point(6, 73);
            this.cboxTire.Name = "cboxTire";
            this.cboxTire.Size = new System.Drawing.Size(155, 20);
            this.cboxTire.TabIndex = 3;
            this.cboxTire.Text = "Tire Rotation ($20.00)";
            this.cboxTire.UseVisualStyleBackColor = true;
            // 
            // cboxMuffler
            // 
            this.cboxMuffler.AutoSize = true;
            this.cboxMuffler.Location = new System.Drawing.Point(6, 47);
            this.cboxMuffler.Name = "cboxMuffler";
            this.cboxMuffler.Size = new System.Drawing.Size(179, 20);
            this.cboxMuffler.TabIndex = 2;
            this.cboxMuffler.Text = "Replace muffler ($100.00)";
            this.cboxMuffler.UseVisualStyleBackColor = true;
            // 
            // cboxInspection
            // 
            this.cboxInspection.AutoSize = true;
            this.cboxInspection.Location = new System.Drawing.Point(6, 21);
            this.cboxInspection.Name = "cboxInspection";
            this.cboxInspection.Size = new System.Drawing.Size(139, 20);
            this.cboxInspection.TabIndex = 1;
            this.cboxInspection.Text = "Inspection ($15.00)";
            this.cboxInspection.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(88, 349);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(87, 32);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // gboxSummary
            // 
            this.gboxSummary.Controls.Add(this.lblSummaryTotal);
            this.gboxSummary.Controls.Add(this.txtboxSummaryTotal);
            this.gboxSummary.Controls.Add(this.lblSummaryTax);
            this.gboxSummary.Controls.Add(this.txtboxSummaryTax);
            this.gboxSummary.Controls.Add(this.lblSummaryParts);
            this.gboxSummary.Controls.Add(this.txtboxSummaryParts);
            this.gboxSummary.Controls.Add(this.lblSummaryService);
            this.gboxSummary.Controls.Add(this.txtboxSummaryService);
            this.gboxSummary.Location = new System.Drawing.Point(12, 208);
            this.gboxSummary.Name = "gboxSummary";
            this.gboxSummary.Size = new System.Drawing.Size(418, 127);
            this.gboxSummary.TabIndex = 10;
            this.gboxSummary.TabStop = false;
            this.gboxSummary.Text = "Summary";
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.AutoSize = true;
            this.lblSummaryTotal.Location = new System.Drawing.Point(301, 40);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(72, 16);
            this.lblSummaryTotal.TabIndex = 16;
            this.lblSummaryTotal.Text = "Total Fees";
            // 
            // txtboxSummaryTotal
            // 
            this.txtboxSummaryTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxSummaryTotal.Enabled = false;
            this.txtboxSummaryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSummaryTotal.Location = new System.Drawing.Point(287, 61);
            this.txtboxSummaryTotal.Name = "txtboxSummaryTotal";
            this.txtboxSummaryTotal.Size = new System.Drawing.Size(100, 22);
            this.txtboxSummaryTotal.TabIndex = 15;
            this.txtboxSummaryTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSummaryTax
            // 
            this.lblSummaryTax.AutoSize = true;
            this.lblSummaryTax.Location = new System.Drawing.Point(45, 80);
            this.lblSummaryTax.Name = "lblSummaryTax";
            this.lblSummaryTax.Size = new System.Drawing.Size(89, 16);
            this.lblSummaryTax.TabIndex = 14;
            this.lblSummaryTax.Text = "Tax (on parts)";
            // 
            // txtboxSummaryTax
            // 
            this.txtboxSummaryTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxSummaryTax.Enabled = false;
            this.txtboxSummaryTax.Location = new System.Drawing.Point(150, 80);
            this.txtboxSummaryTax.Name = "txtboxSummaryTax";
            this.txtboxSummaryTax.Size = new System.Drawing.Size(100, 22);
            this.txtboxSummaryTax.TabIndex = 13;
            // 
            // lblSummaryParts
            // 
            this.lblSummaryParts.AutoSize = true;
            this.lblSummaryParts.Location = new System.Drawing.Point(96, 52);
            this.lblSummaryParts.Name = "lblSummaryParts";
            this.lblSummaryParts.Size = new System.Drawing.Size(38, 16);
            this.lblSummaryParts.TabIndex = 12;
            this.lblSummaryParts.Text = "Parts";
            // 
            // txtboxSummaryParts
            // 
            this.txtboxSummaryParts.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxSummaryParts.Enabled = false;
            this.txtboxSummaryParts.Location = new System.Drawing.Point(150, 49);
            this.txtboxSummaryParts.Name = "txtboxSummaryParts";
            this.txtboxSummaryParts.Size = new System.Drawing.Size(100, 22);
            this.txtboxSummaryParts.TabIndex = 11;
            // 
            // lblSummaryService
            // 
            this.lblSummaryService.AutoSize = true;
            this.lblSummaryService.Location = new System.Drawing.Point(17, 24);
            this.lblSummaryService.Name = "lblSummaryService";
            this.lblSummaryService.Size = new System.Drawing.Size(117, 16);
            this.lblSummaryService.TabIndex = 10;
            this.lblSummaryService.Text = "Service and Labor";
            // 
            // txtboxSummaryService
            // 
            this.txtboxSummaryService.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxSummaryService.Enabled = false;
            this.txtboxSummaryService.Location = new System.Drawing.Point(150, 21);
            this.txtboxSummaryService.Name = "txtboxSummaryService";
            this.txtboxSummaryService.Size = new System.Drawing.Size(100, 22);
            this.txtboxSummaryService.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 395);
            this.Controls.Add(this.gboxSummary);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboxPartsLabor);
            this.Controls.Add(this.gboxFlushes);
            this.Controls.Add(this.gboxMisc);
            this.Controls.Add(this.gboxOilLube);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Automotive";
            this.gboxOilLube.ResumeLayout(false);
            this.gboxOilLube.PerformLayout();
            this.gboxFlushes.ResumeLayout(false);
            this.gboxFlushes.PerformLayout();
            this.gboxPartsLabor.ResumeLayout(false);
            this.gboxPartsLabor.PerformLayout();
            this.gboxMisc.ResumeLayout(false);
            this.gboxMisc.PerformLayout();
            this.gboxSummary.ResumeLayout(false);
            this.gboxSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxOilLube;
        private System.Windows.Forms.CheckBox cboxLube;
        private System.Windows.Forms.CheckBox cboxOil;
        private System.Windows.Forms.GroupBox gboxFlushes;
        private System.Windows.Forms.CheckBox cboxTransmission;
        private System.Windows.Forms.CheckBox cboxRadiator;
        private System.Windows.Forms.GroupBox gboxPartsLabor;
        private System.Windows.Forms.GroupBox gboxMisc;
        private System.Windows.Forms.CheckBox cboxMuffler;
        private System.Windows.Forms.CheckBox cboxInspection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cboxTire;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.TextBox txtboxLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtboxParts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox gboxSummary;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.TextBox txtboxSummaryTotal;
        private System.Windows.Forms.Label lblSummaryTax;
        private System.Windows.Forms.TextBox txtboxSummaryTax;
        private System.Windows.Forms.Label lblSummaryParts;
        private System.Windows.Forms.TextBox txtboxSummaryParts;
        private System.Windows.Forms.Label lblSummaryService;
        private System.Windows.Forms.TextBox txtboxSummaryService;
    }
}

