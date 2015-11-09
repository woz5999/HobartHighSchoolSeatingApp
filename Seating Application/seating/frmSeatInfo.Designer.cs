namespace seating
{
    partial class frmSeatInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeatInfo));
            this.btnSeatPic = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblSeatNum = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblSeatNumResult = new System.Windows.Forms.Label();
            this.lblAvailabilityResult = new System.Windows.Forms.Label();
            this.txtNightNum = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblNight = new System.Windows.Forms.Label();
            this.lblTixTypeResult = new System.Windows.Forms.Label();
            this.lblTixCostResult = new System.Windows.Forms.Label();
            this.lblTixCost = new System.Windows.Forms.Label();
            this.lblTixType = new System.Windows.Forms.Label();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnSeatPic
            // 
            this.btnSeatPic.FlatAppearance.BorderSize = 0;
            this.btnSeatPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeatPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeatPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeatPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatPic.Location = new System.Drawing.Point(12, 4);
            this.btnSeatPic.Name = "btnSeatPic";
            this.btnSeatPic.Size = new System.Drawing.Size(108, 90);
            this.btnSeatPic.TabIndex = 0;
            this.btnSeatPic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeatPic.UseVisualStyleBackColor = true;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(136, 43);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(59, 13);
            this.lblAvailability.TabIndex = 2;
            this.lblAvailability.Text = "Availability:";
            // 
            // lblSeatNum
            // 
            this.lblSeatNum.AutoSize = true;
            this.lblSeatNum.Location = new System.Drawing.Point(136, 13);
            this.lblSeatNum.Name = "lblSeatNum";
            this.lblSeatNum.Size = new System.Drawing.Size(72, 13);
            this.lblSeatNum.TabIndex = 3;
            this.lblSeatNum.Text = "Seat Number:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(139, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Close";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(12, 143);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(108, 23);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Release";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblSeatNumResult
            // 
            this.lblSeatNumResult.AutoSize = true;
            this.lblSeatNumResult.Location = new System.Drawing.Point(203, 13);
            this.lblSeatNumResult.Name = "lblSeatNumResult";
            this.lblSeatNumResult.Size = new System.Drawing.Size(0, 13);
            this.lblSeatNumResult.TabIndex = 6;
            // 
            // lblAvailabilityResult
            // 
            this.lblAvailabilityResult.AutoSize = true;
            this.lblAvailabilityResult.Location = new System.Drawing.Point(203, 43);
            this.lblAvailabilityResult.Name = "lblAvailabilityResult";
            this.lblAvailabilityResult.Size = new System.Drawing.Size(0, 13);
            this.lblAvailabilityResult.TabIndex = 7;
            // 
            // txtNightNum
            // 
            this.txtNightNum.Location = new System.Drawing.Point(53, 100);
            this.txtNightNum.MaxLength = 2;
            this.txtNightNum.Name = "txtNightNum";
            this.txtNightNum.ReadOnly = true;
            this.txtNightNum.Size = new System.Drawing.Size(27, 20);
            this.txtNightNum.TabIndex = 11;
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(86, 101);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 35);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(12, 101);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 35);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblNight
            // 
            this.lblNight.AutoSize = true;
            this.lblNight.Location = new System.Drawing.Point(48, 123);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(32, 13);
            this.lblNight.TabIndex = 14;
            this.lblNight.Text = "Night";
            // 
            // lblTixTypeResult
            // 
            this.lblTixTypeResult.AutoSize = true;
            this.lblTixTypeResult.Location = new System.Drawing.Point(203, 73);
            this.lblTixTypeResult.Name = "lblTixTypeResult";
            this.lblTixTypeResult.Size = new System.Drawing.Size(0, 13);
            this.lblTixTypeResult.TabIndex = 15;
            // 
            // lblTixCostResult
            // 
            this.lblTixCostResult.AutoSize = true;
            this.lblTixCostResult.Location = new System.Drawing.Point(203, 99);
            this.lblTixCostResult.Name = "lblTixCostResult";
            this.lblTixCostResult.Size = new System.Drawing.Size(0, 13);
            this.lblTixCostResult.TabIndex = 16;
            // 
            // lblTixCost
            // 
            this.lblTixCost.AutoSize = true;
            this.lblTixCost.Location = new System.Drawing.Point(136, 99);
            this.lblTixCost.Name = "lblTixCost";
            this.lblTixCost.Size = new System.Drawing.Size(31, 13);
            this.lblTixCost.TabIndex = 17;
            this.lblTixCost.Text = "Cost:";
            // 
            // lblTixType
            // 
            this.lblTixType.AutoSize = true;
            this.lblTixType.Location = new System.Drawing.Point(136, 73);
            this.lblTixType.Name = "lblTixType";
            this.lblTixType.Size = new System.Drawing.Size(67, 13);
            this.lblTixType.TabIndex = 18;
            this.lblTixType.Text = "Ticket Type:";
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "reser");
            this.imgList1.Images.SetKeyName(1, "availhandi");
            this.imgList1.Images.SetKeyName(2, "reserhandi");
            this.imgList1.Images.SetKeyName(3, "avail");
            // 
            // frmSeatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 178);
            this.Controls.Add(this.lblTixType);
            this.Controls.Add(this.lblTixCost);
            this.Controls.Add(this.lblTixCostResult);
            this.Controls.Add(this.lblTixTypeResult);
            this.Controls.Add(this.lblNight);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtNightNum);
            this.Controls.Add(this.lblAvailabilityResult);
            this.Controls.Add(this.lblSeatNumResult);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSeatNum);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.btnSeatPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeatInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeatInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmSeatInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeatPic;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblSeatNum;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblSeatNumResult;
        private System.Windows.Forms.Label lblAvailabilityResult;
        private System.Windows.Forms.TextBox txtNightNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblNight;
        private System.Windows.Forms.Label lblTixTypeResult;
        private System.Windows.Forms.Label lblTixCostResult;
        private System.Windows.Forms.Label lblTixCost;
        private System.Windows.Forms.Label lblTixType;
        private System.Windows.Forms.ImageList imgList1;
    }
}