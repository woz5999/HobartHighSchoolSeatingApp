namespace seating
{
    partial class frmNumberNightsPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumberNightsPrompt));
            this.lblNumNights = new System.Windows.Forms.Label();
            this.cmboNumNights = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.lblShowName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumNights
            // 
            this.lblNumNights.AutoSize = true;
            this.lblNumNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumNights.Location = new System.Drawing.Point(8, 41);
            this.lblNumNights.Name = "lblNumNights";
            this.lblNumNights.Size = new System.Drawing.Size(92, 13);
            this.lblNumNights.TabIndex = 1;
            this.lblNumNights.Text = "Number of Nights:";
            // 
            // cmboNumNights
            // 
            this.cmboNumNights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboNumNights.FormattingEnabled = true;
            this.cmboNumNights.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmboNumNights.Location = new System.Drawing.Point(106, 38);
            this.cmboNumNights.Name = "cmboNumNights";
            this.cmboNumNights.Size = new System.Drawing.Size(126, 21);
            this.cmboNumNights.TabIndex = 1;
            this.cmboNumNights.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(106, 69);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtShowName
            // 
            this.txtShowName.Location = new System.Drawing.Point(106, 9);
            this.txtShowName.MaxLength = 100;
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.Size = new System.Drawing.Size(126, 20);
            this.txtShowName.TabIndex = 0;
            this.txtShowName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Location = new System.Drawing.Point(9, 9);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(68, 13);
            this.lblShowName.TabIndex = 4;
            this.lblShowName.Text = "Show Name:";
            // 
            // frmNumberNightsPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 98);
            this.ControlBox = false;
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.txtShowName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmboNumNights);
            this.Controls.Add(this.lblNumNights);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNumberNightsPrompt";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number of Nights";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumNights;
        private System.Windows.Forms.ComboBox cmboNumNights;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtShowName;
        private System.Windows.Forms.Label lblShowName;
    }
}