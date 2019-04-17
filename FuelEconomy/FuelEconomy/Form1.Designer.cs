namespace FuelEconomy
{
    partial class Form1
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
            this.lblMIles = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.lblMPG = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMIles
            // 
            this.lblMIles.AutoSize = true;
            this.lblMIles.Location = new System.Drawing.Point(24, 9);
            this.lblMIles.Name = "lblMIles";
            this.lblMIles.Size = new System.Drawing.Size(161, 13);
            this.lblMIles.TabIndex = 0;
            this.lblMIles.Text = "Enter the number of miles driven:";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(24, 37);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(147, 13);
            this.lblGallons.TabIndex = 1;
            this.lblGallons.Text = "Enter the gallons of gas used:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(24, 62);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Your cars MPG:";
            this.lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(191, 6);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(191, 34);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 4;
            // 
            // lblMPG
            // 
            this.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMPG.Location = new System.Drawing.Point(191, 61);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(100, 23);
            this.lblMPG.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(27, 98);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(351, 146);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblMIles);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMIles;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

