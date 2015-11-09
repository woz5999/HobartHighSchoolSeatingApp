namespace seating
{
    partial class frmReserveTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserveTickets));
            this.cmboAdults = new System.Windows.Forms.ComboBox();
            this.cmboStudents = new System.Windows.Forms.ComboBox();
            this.cmboComps = new System.Windows.Forms.ComboBox();
            this.cmboSeniors = new System.Windows.Forms.ComboBox();
            this.lblAdultsNum = new System.Windows.Forms.Label();
            this.lblSeniorsNum = new System.Windows.Forms.Label();
            this.lblStudentsNum = new System.Windows.Forms.Label();
            this.lblCompsNum = new System.Windows.Forms.Label();
            this.chkHandi = new System.Windows.Forms.CheckBox();
            this.lblHandi = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboAdults
            // 
            this.cmboAdults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboAdults.FormattingEnabled = true;
            this.cmboAdults.Location = new System.Drawing.Point(64, 12);
            this.cmboAdults.Name = "cmboAdults";
            this.cmboAdults.Size = new System.Drawing.Size(121, 21);
            this.cmboAdults.TabIndex = 0;
            this.cmboAdults.SelectedIndexChanged += new System.EventHandler(this.cmbo_SelectedIndexChanged);
            // 
            // cmboStudents
            // 
            this.cmboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboStudents.FormattingEnabled = true;
            this.cmboStudents.Location = new System.Drawing.Point(64, 39);
            this.cmboStudents.Name = "cmboStudents";
            this.cmboStudents.Size = new System.Drawing.Size(121, 21);
            this.cmboStudents.TabIndex = 1;
            this.cmboStudents.SelectedIndexChanged += new System.EventHandler(this.cmbo_SelectedIndexChanged);
            // 
            // cmboComps
            // 
            this.cmboComps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboComps.FormattingEnabled = true;
            this.cmboComps.Location = new System.Drawing.Point(64, 93);
            this.cmboComps.Name = "cmboComps";
            this.cmboComps.Size = new System.Drawing.Size(121, 21);
            this.cmboComps.TabIndex = 3;
            this.cmboComps.SelectedIndexChanged += new System.EventHandler(this.cmbo_SelectedIndexChanged);
            // 
            // cmboSeniors
            // 
            this.cmboSeniors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSeniors.FormattingEnabled = true;
            this.cmboSeniors.Location = new System.Drawing.Point(64, 66);
            this.cmboSeniors.Name = "cmboSeniors";
            this.cmboSeniors.Size = new System.Drawing.Size(121, 21);
            this.cmboSeniors.TabIndex = 2;
            this.cmboSeniors.SelectedIndexChanged += new System.EventHandler(this.cmbo_SelectedIndexChanged);
            // 
            // lblAdultsNum
            // 
            this.lblAdultsNum.AutoSize = true;
            this.lblAdultsNum.Location = new System.Drawing.Point(12, 15);
            this.lblAdultsNum.Name = "lblAdultsNum";
            this.lblAdultsNum.Size = new System.Drawing.Size(39, 13);
            this.lblAdultsNum.TabIndex = 4;
            this.lblAdultsNum.Text = "Adults:";
            // 
            // lblSeniorsNum
            // 
            this.lblSeniorsNum.AutoSize = true;
            this.lblSeniorsNum.Location = new System.Drawing.Point(12, 69);
            this.lblSeniorsNum.Name = "lblSeniorsNum";
            this.lblSeniorsNum.Size = new System.Drawing.Size(45, 13);
            this.lblSeniorsNum.TabIndex = 5;
            this.lblSeniorsNum.Text = "Seniors:";
            // 
            // lblStudentsNum
            // 
            this.lblStudentsNum.AutoSize = true;
            this.lblStudentsNum.Location = new System.Drawing.Point(12, 42);
            this.lblStudentsNum.Name = "lblStudentsNum";
            this.lblStudentsNum.Size = new System.Drawing.Size(52, 13);
            this.lblStudentsNum.TabIndex = 6;
            this.lblStudentsNum.Text = "Students:";
            // 
            // lblCompsNum
            // 
            this.lblCompsNum.AutoSize = true;
            this.lblCompsNum.Location = new System.Drawing.Point(12, 96);
            this.lblCompsNum.Name = "lblCompsNum";
            this.lblCompsNum.Size = new System.Drawing.Size(42, 13);
            this.lblCompsNum.TabIndex = 7;
            this.lblCompsNum.Text = "Comps:";
            // 
            // chkHandi
            // 
            this.chkHandi.AutoSize = true;
            this.chkHandi.Location = new System.Drawing.Point(170, 128);
            this.chkHandi.Name = "chkHandi";
            this.chkHandi.Size = new System.Drawing.Size(15, 14);
            this.chkHandi.TabIndex = 4;
            this.chkHandi.UseVisualStyleBackColor = true;
            this.chkHandi.CheckedChanged += new System.EventHandler(this.chkHandi_CheckedChanged);
            // 
            // lblHandi
            // 
            this.lblHandi.AutoSize = true;
            this.lblHandi.Location = new System.Drawing.Point(12, 128);
            this.lblHandi.Name = "lblHandi";
            this.lblHandi.Size = new System.Drawing.Size(77, 13);
            this.lblHandi.TabIndex = 12;
            this.lblHandi.Text = "Handicapped?";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(15, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(110, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReserveTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 193);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblHandi);
            this.Controls.Add(this.chkHandi);
            this.Controls.Add(this.lblCompsNum);
            this.Controls.Add(this.lblStudentsNum);
            this.Controls.Add(this.lblSeniorsNum);
            this.Controls.Add(this.lblAdultsNum);
            this.Controls.Add(this.cmboSeniors);
            this.Controls.Add(this.cmboComps);
            this.Controls.Add(this.cmboStudents);
            this.Controls.Add(this.cmboAdults);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReserveTickets";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserve Tickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReserveTickets_FormClosing);
            this.Load += new System.EventHandler(this.frmReserveTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboAdults;
        private System.Windows.Forms.ComboBox cmboStudents;
        private System.Windows.Forms.ComboBox cmboComps;
        private System.Windows.Forms.ComboBox cmboSeniors;
        private System.Windows.Forms.Label lblAdultsNum;
        private System.Windows.Forms.Label lblSeniorsNum;
        private System.Windows.Forms.Label lblStudentsNum;
        private System.Windows.Forms.Label lblCompsNum;
        private System.Windows.Forms.CheckBox chkHandi;
        private System.Windows.Forms.Label lblHandi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
    }
}