namespace seating
{
    partial class frmReservedSeats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservedSeats));
            this.lblSeatsReserved = new System.Windows.Forms.Label();
            this.lstSeatsReserved = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeatsReserved
            // 
            this.lblSeatsReserved.AutoSize = true;
            this.lblSeatsReserved.Location = new System.Drawing.Point(0, 0);
            this.lblSeatsReserved.Name = "lblSeatsReserved";
            this.lblSeatsReserved.Size = new System.Drawing.Size(169, 13);
            this.lblSeatsReserved.TabIndex = 0;
            this.lblSeatsReserved.Text = "These seats have been reserved: ";
            // 
            // lstSeatsReserved
            // 
            this.lstSeatsReserved.FormattingEnabled = true;
            this.lstSeatsReserved.Location = new System.Drawing.Point(3, 16);
            this.lstSeatsReserved.Name = "lstSeatsReserved";
            this.lstSeatsReserved.Size = new System.Drawing.Size(166, 147);
            this.lstSeatsReserved.TabIndex = 1;
            this.lstSeatsReserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(40, 200);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblCostResult
            // 
            this.lblCostResult.AutoSize = true;
            this.lblCostResult.Location = new System.Drawing.Point(64, 175);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(0, 13);
            this.lblCostResult.TabIndex = 3;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(0, 175);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(58, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Total Cost:";
            // 
            // frmReservedSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 230);
            this.ControlBox = false;
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCostResult);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstSeatsReserved);
            this.Controls.Add(this.lblSeatsReserved);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservedSeats";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seats Reserved";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReservedSeats_FormClosing);
            this.Load += new System.EventHandler(this.frmReservedSeats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeatsReserved;
        private System.Windows.Forms.ListBox lstSeatsReserved;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Label lblCost;
    }
}