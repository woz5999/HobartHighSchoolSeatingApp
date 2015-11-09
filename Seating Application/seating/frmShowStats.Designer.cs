namespace seating
{
    partial class frmShowStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowStats));
            this.btnClose = new System.Windows.Forms.Button();
            this.cmboNight = new System.Windows.Forms.ComboBox();
            this.lblNightStudTaken = new System.Windows.Forms.Label();
            this.lblShowSenTaken = new System.Windows.Forms.Label();
            this.lblShowStudTaken = new System.Windows.Forms.Label();
            this.lblShowAdTaken = new System.Windows.Forms.Label();
            this.lblShowTakenTot = new System.Windows.Forms.Label();
            this.lblNightAdTix = new System.Windows.Forms.Label();
            this.lblNightTixTot = new System.Windows.Forms.Label();
            this.lblNightCompTix = new System.Windows.Forms.Label();
            this.lblNightSenTix = new System.Windows.Forms.Label();
            this.lblNightStudTix = new System.Windows.Forms.Label();
            this.lblNightSenTaken = new System.Windows.Forms.Label();
            this.lblNightAdTaken = new System.Windows.Forms.Label();
            this.lblNightTaken = new System.Windows.Forms.Label();
            this.lblShowCompTixTot = new System.Windows.Forms.Label();
            this.lblShowSenTixTot = new System.Windows.Forms.Label();
            this.lblShowStudTixTot = new System.Windows.Forms.Label();
            this.lblShowAdTixTot = new System.Windows.Forms.Label();
            this.lblShowTixTot = new System.Windows.Forms.Label();
            this.lblShowTixTot1 = new System.Windows.Forms.Label();
            this.lblShowAdTixTot1 = new System.Windows.Forms.Label();
            this.lblShowStudTixTot1 = new System.Windows.Forms.Label();
            this.lblShowSenTixTot1 = new System.Windows.Forms.Label();
            this.lblShowCompTixTot1 = new System.Windows.Forms.Label();
            this.lblNightTaken1 = new System.Windows.Forms.Label();
            this.lblNightAdTaken1 = new System.Windows.Forms.Label();
            this.lblNightSenTaken1 = new System.Windows.Forms.Label();
            this.lblNightStudTix1 = new System.Windows.Forms.Label();
            this.lblNightSenTix1 = new System.Windows.Forms.Label();
            this.lblNightCompTix1 = new System.Windows.Forms.Label();
            this.lblNightTixTot1 = new System.Windows.Forms.Label();
            this.lblNightAdTix1 = new System.Windows.Forms.Label();
            this.lblShowTakenTot1 = new System.Windows.Forms.Label();
            this.lblShowAdTaken1 = new System.Windows.Forms.Label();
            this.lblShowStudTaken1 = new System.Windows.Forms.Label();
            this.lblShowSenTaken1 = new System.Windows.Forms.Label();
            this.lblNightStudTaken1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectNight = new System.Windows.Forms.Label();
            this.lblShowParPassTixTot = new System.Windows.Forms.Label();
            this.lblShowParPassTixTot1 = new System.Windows.Forms.Label();
            this.lblShowParPassTaken = new System.Windows.Forms.Label();
            this.lblShowParPassTaken1 = new System.Windows.Forms.Label();
            this.lblNightParPassTix = new System.Windows.Forms.Label();
            this.lblNightParPassTix1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmboNight
            // 
            this.cmboNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboNight.FormattingEnabled = true;
            this.cmboNight.Location = new System.Drawing.Point(83, 137);
            this.cmboNight.Name = "cmboNight";
            this.cmboNight.Size = new System.Drawing.Size(85, 21);
            this.cmboNight.TabIndex = 1;
            this.cmboNight.SelectedIndexChanged += new System.EventHandler(this.cmboNight_SelectedIndexChanged);
            this.cmboNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblNightStudTaken
            // 
            this.lblNightStudTaken.AutoSize = true;
            this.lblNightStudTaken.Location = new System.Drawing.Point(364, 171);
            this.lblNightStudTaken.Name = "lblNightStudTaken";
            this.lblNightStudTaken.Size = new System.Drawing.Size(78, 13);
            this.lblNightStudTaken.TabIndex = 2;
            this.lblNightStudTaken.Text = "From Students:";
            // 
            // lblShowSenTaken
            // 
            this.lblShowSenTaken.AutoSize = true;
            this.lblShowSenTaken.Location = new System.Drawing.Point(364, 57);
            this.lblShowSenTaken.Name = "lblShowSenTaken";
            this.lblShowSenTaken.Size = new System.Drawing.Size(128, 13);
            this.lblShowSenTaken.TabIndex = 9;
            this.lblShowSenTaken.Text = "Total from Senior Tickets:";
            // 
            // lblShowStudTaken
            // 
            this.lblShowStudTaken.AutoSize = true;
            this.lblShowStudTaken.Location = new System.Drawing.Point(364, 41);
            this.lblShowStudTaken.Name = "lblShowStudTaken";
            this.lblShowStudTaken.Size = new System.Drawing.Size(135, 13);
            this.lblShowStudTaken.TabIndex = 10;
            this.lblShowStudTaken.Text = "Total from Student Tickets:";
            // 
            // lblShowAdTaken
            // 
            this.lblShowAdTaken.AutoSize = true;
            this.lblShowAdTaken.Location = new System.Drawing.Point(364, 25);
            this.lblShowAdTaken.Name = "lblShowAdTaken";
            this.lblShowAdTaken.Size = new System.Drawing.Size(122, 13);
            this.lblShowAdTaken.TabIndex = 11;
            this.lblShowAdTaken.Text = "Total from Adult Tickets:";
            // 
            // lblShowTakenTot
            // 
            this.lblShowTakenTot.AutoSize = true;
            this.lblShowTakenTot.Location = new System.Drawing.Point(364, 9);
            this.lblShowTakenTot.Name = "lblShowTakenTot";
            this.lblShowTakenTot.Size = new System.Drawing.Size(106, 13);
            this.lblShowTakenTot.TabIndex = 12;
            this.lblShowTakenTot.Text = "Total Money Taken: ";
            // 
            // lblNightAdTix
            // 
            this.lblNightAdTix.AutoSize = true;
            this.lblNightAdTix.Location = new System.Drawing.Point(178, 155);
            this.lblNightAdTix.Name = "lblNightAdTix";
            this.lblNightAdTix.Size = new System.Drawing.Size(96, 13);
            this.lblNightAdTix.TabIndex = 15;
            this.lblNightAdTix.Text = "Adult Tickets Sold:";
            // 
            // lblNightTixTot
            // 
            this.lblNightTixTot.AutoSize = true;
            this.lblNightTixTot.Location = new System.Drawing.Point(178, 140);
            this.lblNightTixTot.Name = "lblNightTixTot";
            this.lblNightTixTot.Size = new System.Drawing.Size(72, 13);
            this.lblNightTixTot.TabIndex = 18;
            this.lblNightTixTot.Text = "Tickets Sold: ";
            // 
            // lblNightCompTix
            // 
            this.lblNightCompTix.AutoSize = true;
            this.lblNightCompTix.Location = new System.Drawing.Point(178, 219);
            this.lblNightCompTix.Name = "lblNightCompTix";
            this.lblNightCompTix.Size = new System.Drawing.Size(113, 13);
            this.lblNightCompTix.TabIndex = 21;
            this.lblNightCompTix.Text = "Complimentary Tickets";
            // 
            // lblNightSenTix
            // 
            this.lblNightSenTix.AutoSize = true;
            this.lblNightSenTix.Location = new System.Drawing.Point(178, 187);
            this.lblNightSenTix.Name = "lblNightSenTix";
            this.lblNightSenTix.Size = new System.Drawing.Size(102, 13);
            this.lblNightSenTix.TabIndex = 23;
            this.lblNightSenTix.Text = "Senior Tickets Sold:";
            // 
            // lblNightStudTix
            // 
            this.lblNightStudTix.AutoSize = true;
            this.lblNightStudTix.Location = new System.Drawing.Point(178, 171);
            this.lblNightStudTix.Name = "lblNightStudTix";
            this.lblNightStudTix.Size = new System.Drawing.Size(109, 13);
            this.lblNightStudTix.TabIndex = 25;
            this.lblNightStudTix.Text = "Student Tickets Sold:";
            // 
            // lblNightSenTaken
            // 
            this.lblNightSenTaken.AutoSize = true;
            this.lblNightSenTaken.Location = new System.Drawing.Point(364, 187);
            this.lblNightSenTaken.Name = "lblNightSenTaken";
            this.lblNightSenTaken.Size = new System.Drawing.Size(71, 13);
            this.lblNightSenTaken.TabIndex = 28;
            this.lblNightSenTaken.Text = "From Seniors:";
            // 
            // lblNightAdTaken
            // 
            this.lblNightAdTaken.AutoSize = true;
            this.lblNightAdTaken.Location = new System.Drawing.Point(364, 155);
            this.lblNightAdTaken.Name = "lblNightAdTaken";
            this.lblNightAdTaken.Size = new System.Drawing.Size(65, 13);
            this.lblNightAdTaken.TabIndex = 29;
            this.lblNightAdTaken.Text = "From Adults:";
            // 
            // lblNightTaken
            // 
            this.lblNightTaken.AutoSize = true;
            this.lblNightTaken.Location = new System.Drawing.Point(364, 140);
            this.lblNightTaken.Name = "lblNightTaken";
            this.lblNightTaken.Size = new System.Drawing.Size(76, 13);
            this.lblNightTaken.TabIndex = 30;
            this.lblNightTaken.Text = "Money Taken:";
            // 
            // lblShowCompTixTot
            // 
            this.lblShowCompTixTot.AutoSize = true;
            this.lblShowCompTixTot.Location = new System.Drawing.Point(178, 89);
            this.lblShowCompTixTot.Name = "lblShowCompTixTot";
            this.lblShowCompTixTot.Size = new System.Drawing.Size(143, 13);
            this.lblShowCompTixTot.TabIndex = 35;
            this.lblShowCompTixTot.Text = "Total Complimentary Tickets:";
            // 
            // lblShowSenTixTot
            // 
            this.lblShowSenTixTot.AutoSize = true;
            this.lblShowSenTixTot.Location = new System.Drawing.Point(178, 57);
            this.lblShowSenTixTot.Name = "lblShowSenTixTot";
            this.lblShowSenTixTot.Size = new System.Drawing.Size(129, 13);
            this.lblShowSenTixTot.TabIndex = 36;
            this.lblShowSenTixTot.Text = "Total Senior Tickets Sold:";
            // 
            // lblShowStudTixTot
            // 
            this.lblShowStudTixTot.AutoSize = true;
            this.lblShowStudTixTot.Location = new System.Drawing.Point(178, 41);
            this.lblShowStudTixTot.Name = "lblShowStudTixTot";
            this.lblShowStudTixTot.Size = new System.Drawing.Size(136, 13);
            this.lblShowStudTixTot.TabIndex = 37;
            this.lblShowStudTixTot.Text = "Total Student Tickets Sold:";
            // 
            // lblShowAdTixTot
            // 
            this.lblShowAdTixTot.AutoSize = true;
            this.lblShowAdTixTot.Location = new System.Drawing.Point(178, 25);
            this.lblShowAdTixTot.Name = "lblShowAdTixTot";
            this.lblShowAdTixTot.Size = new System.Drawing.Size(123, 13);
            this.lblShowAdTixTot.TabIndex = 38;
            this.lblShowAdTixTot.Text = "Total Adult Tickets Sold:";
            // 
            // lblShowTixTot
            // 
            this.lblShowTixTot.AutoSize = true;
            this.lblShowTixTot.Location = new System.Drawing.Point(178, 9);
            this.lblShowTixTot.Name = "lblShowTixTot";
            this.lblShowTixTot.Size = new System.Drawing.Size(96, 13);
            this.lblShowTixTot.TabIndex = 39;
            this.lblShowTixTot.Text = "Total Tickets Sold:";
            // 
            // lblShowTixTot1
            // 
            this.lblShowTixTot1.AutoSize = true;
            this.lblShowTixTot1.Location = new System.Drawing.Point(321, 9);
            this.lblShowTixTot1.Name = "lblShowTixTot1";
            this.lblShowTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowTixTot1.TabIndex = 57;
            // 
            // lblShowAdTixTot1
            // 
            this.lblShowAdTixTot1.AutoSize = true;
            this.lblShowAdTixTot1.Location = new System.Drawing.Point(321, 25);
            this.lblShowAdTixTot1.Name = "lblShowAdTixTot1";
            this.lblShowAdTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowAdTixTot1.TabIndex = 56;
            // 
            // lblShowStudTixTot1
            // 
            this.lblShowStudTixTot1.AutoSize = true;
            this.lblShowStudTixTot1.Location = new System.Drawing.Point(321, 41);
            this.lblShowStudTixTot1.Name = "lblShowStudTixTot1";
            this.lblShowStudTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowStudTixTot1.TabIndex = 55;
            // 
            // lblShowSenTixTot1
            // 
            this.lblShowSenTixTot1.AutoSize = true;
            this.lblShowSenTixTot1.Location = new System.Drawing.Point(321, 57);
            this.lblShowSenTixTot1.Name = "lblShowSenTixTot1";
            this.lblShowSenTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowSenTixTot1.TabIndex = 54;
            // 
            // lblShowCompTixTot1
            // 
            this.lblShowCompTixTot1.AutoSize = true;
            this.lblShowCompTixTot1.Location = new System.Drawing.Point(321, 89);
            this.lblShowCompTixTot1.Name = "lblShowCompTixTot1";
            this.lblShowCompTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowCompTixTot1.TabIndex = 53;
            // 
            // lblNightTaken1
            // 
            this.lblNightTaken1.AutoSize = true;
            this.lblNightTaken1.Location = new System.Drawing.Point(496, 140);
            this.lblNightTaken1.Name = "lblNightTaken1";
            this.lblNightTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblNightTaken1.TabIndex = 52;
            // 
            // lblNightAdTaken1
            // 
            this.lblNightAdTaken1.AutoSize = true;
            this.lblNightAdTaken1.Location = new System.Drawing.Point(496, 155);
            this.lblNightAdTaken1.Name = "lblNightAdTaken1";
            this.lblNightAdTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblNightAdTaken1.TabIndex = 51;
            // 
            // lblNightSenTaken1
            // 
            this.lblNightSenTaken1.AutoSize = true;
            this.lblNightSenTaken1.Location = new System.Drawing.Point(496, 187);
            this.lblNightSenTaken1.Name = "lblNightSenTaken1";
            this.lblNightSenTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblNightSenTaken1.TabIndex = 50;
            // 
            // lblNightStudTix1
            // 
            this.lblNightStudTix1.AutoSize = true;
            this.lblNightStudTix1.Location = new System.Drawing.Point(321, 171);
            this.lblNightStudTix1.Name = "lblNightStudTix1";
            this.lblNightStudTix1.Size = new System.Drawing.Size(0, 13);
            this.lblNightStudTix1.TabIndex = 49;
            // 
            // lblNightSenTix1
            // 
            this.lblNightSenTix1.AutoSize = true;
            this.lblNightSenTix1.Location = new System.Drawing.Point(321, 187);
            this.lblNightSenTix1.Name = "lblNightSenTix1";
            this.lblNightSenTix1.Size = new System.Drawing.Size(0, 13);
            this.lblNightSenTix1.TabIndex = 48;
            // 
            // lblNightCompTix1
            // 
            this.lblNightCompTix1.AutoSize = true;
            this.lblNightCompTix1.Location = new System.Drawing.Point(321, 219);
            this.lblNightCompTix1.Name = "lblNightCompTix1";
            this.lblNightCompTix1.Size = new System.Drawing.Size(0, 13);
            this.lblNightCompTix1.TabIndex = 47;
            // 
            // lblNightTixTot1
            // 
            this.lblNightTixTot1.AutoSize = true;
            this.lblNightTixTot1.Location = new System.Drawing.Point(321, 140);
            this.lblNightTixTot1.Name = "lblNightTixTot1";
            this.lblNightTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblNightTixTot1.TabIndex = 46;
            // 
            // lblNightAdTix1
            // 
            this.lblNightAdTix1.AutoSize = true;
            this.lblNightAdTix1.Location = new System.Drawing.Point(321, 155);
            this.lblNightAdTix1.Name = "lblNightAdTix1";
            this.lblNightAdTix1.Size = new System.Drawing.Size(0, 13);
            this.lblNightAdTix1.TabIndex = 45;
            // 
            // lblShowTakenTot1
            // 
            this.lblShowTakenTot1.AutoSize = true;
            this.lblShowTakenTot1.Location = new System.Drawing.Point(496, 9);
            this.lblShowTakenTot1.Name = "lblShowTakenTot1";
            this.lblShowTakenTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowTakenTot1.TabIndex = 44;
            // 
            // lblShowAdTaken1
            // 
            this.lblShowAdTaken1.AutoSize = true;
            this.lblShowAdTaken1.Location = new System.Drawing.Point(496, 25);
            this.lblShowAdTaken1.Name = "lblShowAdTaken1";
            this.lblShowAdTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblShowAdTaken1.TabIndex = 43;
            // 
            // lblShowStudTaken1
            // 
            this.lblShowStudTaken1.AutoSize = true;
            this.lblShowStudTaken1.Location = new System.Drawing.Point(496, 41);
            this.lblShowStudTaken1.Name = "lblShowStudTaken1";
            this.lblShowStudTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblShowStudTaken1.TabIndex = 42;
            // 
            // lblShowSenTaken1
            // 
            this.lblShowSenTaken1.AutoSize = true;
            this.lblShowSenTaken1.Location = new System.Drawing.Point(496, 57);
            this.lblShowSenTaken1.Name = "lblShowSenTaken1";
            this.lblShowSenTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblShowSenTaken1.TabIndex = 41;
            // 
            // lblNightStudTaken1
            // 
            this.lblNightStudTaken1.AutoSize = true;
            this.lblNightStudTaken1.Location = new System.Drawing.Point(496, 171);
            this.lblNightStudTaken1.Name = "lblNightStudTaken1";
            this.lblNightStudTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblNightStudTaken1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 116);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectNight
            // 
            this.lblSelectNight.AutoSize = true;
            this.lblSelectNight.Location = new System.Drawing.Point(9, 140);
            this.lblSelectNight.Name = "lblSelectNight";
            this.lblSelectNight.Size = new System.Drawing.Size(68, 13);
            this.lblSelectNight.TabIndex = 59;
            this.lblSelectNight.Text = "Select Night:";
            // 
            // lblShowParPassTixTot
            // 
            this.lblShowParPassTixTot.AutoSize = true;
            this.lblShowParPassTixTot.Location = new System.Drawing.Point(178, 73);
            this.lblShowParPassTixTot.Name = "lblShowParPassTixTot";
            this.lblShowParPassTixTot.Size = new System.Drawing.Size(105, 13);
            this.lblShowParPassTixTot.TabIndex = 60;
            this.lblShowParPassTixTot.Text = "Total Parent Passes:";
            // 
            // lblShowParPassTixTot1
            // 
            this.lblShowParPassTixTot1.AutoSize = true;
            this.lblShowParPassTixTot1.Location = new System.Drawing.Point(321, 73);
            this.lblShowParPassTixTot1.Name = "lblShowParPassTixTot1";
            this.lblShowParPassTixTot1.Size = new System.Drawing.Size(0, 13);
            this.lblShowParPassTixTot1.TabIndex = 61;
            // 
            // lblShowParPassTaken
            // 
            this.lblShowParPassTaken.AutoSize = true;
            this.lblShowParPassTaken.Location = new System.Drawing.Point(364, 73);
            this.lblShowParPassTaken.Name = "lblShowParPassTaken";
            this.lblShowParPassTaken.Size = new System.Drawing.Size(125, 13);
            this.lblShowParPassTaken.TabIndex = 62;
            this.lblShowParPassTaken.Text = "Total from Parent Passes";
            // 
            // lblShowParPassTaken1
            // 
            this.lblShowParPassTaken1.AutoSize = true;
            this.lblShowParPassTaken1.Location = new System.Drawing.Point(496, 73);
            this.lblShowParPassTaken1.Name = "lblShowParPassTaken1";
            this.lblShowParPassTaken1.Size = new System.Drawing.Size(0, 13);
            this.lblShowParPassTaken1.TabIndex = 63;
            // 
            // lblNightParPassTix
            // 
            this.lblNightParPassTix.AutoSize = true;
            this.lblNightParPassTix.Location = new System.Drawing.Point(178, 203);
            this.lblNightParPassTix.Name = "lblNightParPassTix";
            this.lblNightParPassTix.Size = new System.Drawing.Size(102, 13);
            this.lblNightParPassTix.TabIndex = 64;
            this.lblNightParPassTix.Text = "Parent Passes Sold:";
            // 
            // lblNightParPassTix1
            // 
            this.lblNightParPassTix1.AutoSize = true;
            this.lblNightParPassTix1.Location = new System.Drawing.Point(321, 203);
            this.lblNightParPassTix1.Name = "lblNightParPassTix1";
            this.lblNightParPassTix1.Size = new System.Drawing.Size(0, 13);
            this.lblNightParPassTix1.TabIndex = 65;
            // 
            // frmShowStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 279);
            this.Controls.Add(this.lblNightParPassTix1);
            this.Controls.Add(this.lblNightParPassTix);
            this.Controls.Add(this.lblShowParPassTaken1);
            this.Controls.Add(this.lblShowParPassTaken);
            this.Controls.Add(this.lblShowParPassTixTot1);
            this.Controls.Add(this.lblShowParPassTixTot);
            this.Controls.Add(this.lblSelectNight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblShowTixTot1);
            this.Controls.Add(this.lblShowAdTixTot1);
            this.Controls.Add(this.lblShowStudTixTot1);
            this.Controls.Add(this.lblShowSenTixTot1);
            this.Controls.Add(this.lblShowCompTixTot1);
            this.Controls.Add(this.lblNightTaken1);
            this.Controls.Add(this.lblNightAdTaken1);
            this.Controls.Add(this.lblNightSenTaken1);
            this.Controls.Add(this.lblNightStudTix1);
            this.Controls.Add(this.lblNightSenTix1);
            this.Controls.Add(this.lblNightCompTix1);
            this.Controls.Add(this.lblNightTixTot1);
            this.Controls.Add(this.lblNightAdTix1);
            this.Controls.Add(this.lblShowTakenTot1);
            this.Controls.Add(this.lblShowAdTaken1);
            this.Controls.Add(this.lblShowStudTaken1);
            this.Controls.Add(this.lblShowSenTaken1);
            this.Controls.Add(this.lblNightStudTaken1);
            this.Controls.Add(this.lblShowTixTot);
            this.Controls.Add(this.lblShowAdTixTot);
            this.Controls.Add(this.lblShowStudTixTot);
            this.Controls.Add(this.lblShowSenTixTot);
            this.Controls.Add(this.lblShowCompTixTot);
            this.Controls.Add(this.lblNightTaken);
            this.Controls.Add(this.lblNightAdTaken);
            this.Controls.Add(this.lblNightSenTaken);
            this.Controls.Add(this.lblNightStudTix);
            this.Controls.Add(this.lblNightSenTix);
            this.Controls.Add(this.lblNightCompTix);
            this.Controls.Add(this.lblNightTixTot);
            this.Controls.Add(this.lblNightAdTix);
            this.Controls.Add(this.lblShowTakenTot);
            this.Controls.Add(this.lblShowAdTaken);
            this.Controls.Add(this.lblShowStudTaken);
            this.Controls.Add(this.lblShowSenTaken);
            this.Controls.Add(this.lblNightStudTaken);
            this.Controls.Add(this.cmboNight);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShowStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Statistics";
            this.Load += new System.EventHandler(this.frmShowStats_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmboNight;
        private System.Windows.Forms.Label lblNightStudTaken;
        private System.Windows.Forms.Label lblShowSenTaken;
        private System.Windows.Forms.Label lblShowStudTaken;
        private System.Windows.Forms.Label lblShowAdTaken;
        private System.Windows.Forms.Label lblShowTakenTot;
        private System.Windows.Forms.Label lblNightAdTix;
        private System.Windows.Forms.Label lblNightTixTot;
        private System.Windows.Forms.Label lblNightCompTix;
        private System.Windows.Forms.Label lblNightSenTix;
        private System.Windows.Forms.Label lblNightStudTix;
        private System.Windows.Forms.Label lblNightSenTaken;
        private System.Windows.Forms.Label lblNightAdTaken;
        private System.Windows.Forms.Label lblNightTaken;
        private System.Windows.Forms.Label lblShowCompTixTot;
        private System.Windows.Forms.Label lblShowSenTixTot;
        private System.Windows.Forms.Label lblShowStudTixTot;
        private System.Windows.Forms.Label lblShowAdTixTot;
        private System.Windows.Forms.Label lblShowTixTot;
        private System.Windows.Forms.Label lblShowTixTot1;
        private System.Windows.Forms.Label lblShowAdTixTot1;
        private System.Windows.Forms.Label lblShowStudTixTot1;
        private System.Windows.Forms.Label lblShowSenTixTot1;
        private System.Windows.Forms.Label lblShowCompTixTot1;
        private System.Windows.Forms.Label lblNightTaken1;
        private System.Windows.Forms.Label lblNightAdTaken1;
        private System.Windows.Forms.Label lblNightSenTaken1;
        private System.Windows.Forms.Label lblNightStudTix1;
        private System.Windows.Forms.Label lblNightSenTix1;
        private System.Windows.Forms.Label lblNightCompTix1;
        private System.Windows.Forms.Label lblNightTixTot1;
        private System.Windows.Forms.Label lblNightAdTix1;
        private System.Windows.Forms.Label lblShowTakenTot1;
        private System.Windows.Forms.Label lblShowAdTaken1;
        private System.Windows.Forms.Label lblShowStudTaken1;
        private System.Windows.Forms.Label lblShowSenTaken1;
        private System.Windows.Forms.Label lblNightStudTaken1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectNight;
        private System.Windows.Forms.Label lblShowParPassTixTot;
        private System.Windows.Forms.Label lblShowParPassTixTot1;
        private System.Windows.Forms.Label lblShowParPassTaken;
        private System.Windows.Forms.Label lblShowParPassTaken1;
        private System.Windows.Forms.Label lblNightParPassTix;
        private System.Windows.Forms.Label lblNightParPassTix1;
    }
}