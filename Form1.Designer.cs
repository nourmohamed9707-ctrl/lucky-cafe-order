namespace LukyCafeOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.groupDrink = new System.Windows.Forms.GroupBox();
            this.rdoTea = new System.Windows.Forms.RadioButton();
            this.rdoCoffee = new System.Windows.Forms.RadioButton();
            this.rdoJuice = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.chkStudentMember = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblLuckyMessage = new System.Windows.Forms.Label();
            this.ListBoxOrder = new System.Windows.Forms.ListBox();
            this.groupDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(14, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "lucky-Cafe-Order";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 396);
            this.label2.TabIndex = 1;
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.AutoSize = true;
            this.lblCustomerInformation.BackColor = System.Drawing.Color.White;
            this.lblCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInformation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCustomerInformation.Location = new System.Drawing.Point(8, 51);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(242, 26);
            this.lblCustomerInformation.TabIndex = 2;
            this.lblCustomerInformation.Text = "Customer Information";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(14, 100);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(174, 25);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(12, 140);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(556, 26);
            this.txtCustomerName.TabIndex = 4;
            // 
            // groupDrink
            // 
            this.groupDrink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupDrink.Controls.Add(this.rdoJuice);
            this.groupDrink.Controls.Add(this.rdoCoffee);
            this.groupDrink.Controls.Add(this.rdoTea);
            this.groupDrink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupDrink.Location = new System.Drawing.Point(12, 188);
            this.groupDrink.Name = "groupDrink";
            this.groupDrink.Size = new System.Drawing.Size(551, 172);
            this.groupDrink.TabIndex = 5;
            this.groupDrink.TabStop = false;
            this.groupDrink.Text = "Drink Type";
            this.groupDrink.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoTea
            // 
            this.rdoTea.AutoSize = true;
            this.rdoTea.ForeColor = System.Drawing.Color.Black;
            this.rdoTea.Location = new System.Drawing.Point(26, 41);
            this.rdoTea.Name = "rdoTea";
            this.rdoTea.Size = new System.Drawing.Size(101, 24);
            this.rdoTea.TabIndex = 0;
            this.rdoTea.TabStop = true;
            this.rdoTea.Text = "Tea (1$)";
            this.rdoTea.UseVisualStyleBackColor = true;
            // 
            // rdoCoffee
            // 
            this.rdoCoffee.AutoSize = true;
            this.rdoCoffee.ForeColor = System.Drawing.Color.Black;
            this.rdoCoffee.Location = new System.Drawing.Point(26, 71);
            this.rdoCoffee.Name = "rdoCoffee";
            this.rdoCoffee.Size = new System.Drawing.Size(125, 24);
            this.rdoCoffee.TabIndex = 1;
            this.rdoCoffee.TabStop = true;
            this.rdoCoffee.Text = "Coffee (2$)";
            this.rdoCoffee.UseVisualStyleBackColor = true;
            // 
            // rdoJuice
            // 
            this.rdoJuice.AutoSize = true;
            this.rdoJuice.ForeColor = System.Drawing.Color.Black;
            this.rdoJuice.Location = new System.Drawing.Point(26, 101);
            this.rdoJuice.Name = "rdoJuice";
            this.rdoJuice.Size = new System.Drawing.Size(113, 24);
            this.rdoJuice.TabIndex = 2;
            this.rdoJuice.TabStop = true;
            this.rdoJuice.Text = "Juice (3$)";
            this.rdoJuice.UseVisualStyleBackColor = true;
            this.rdoJuice.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(15, 382);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(81, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculate.Location = new System.Drawing.Point(1, 463);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(234, 33);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Order";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(241, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(263, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoad.Location = new System.Drawing.Point(526, 457);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(256, 39);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load From Form";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(834, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(293, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(111, 382);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(159, 26);
            this.textQuantity.TabIndex = 12;
            // 
            // chkStudentMember
            // 
            this.chkStudentMember.AutoSize = true;
            this.chkStudentMember.ForeColor = System.Drawing.Color.Black;
            this.chkStudentMember.Location = new System.Drawing.Point(295, 384);
            this.chkStudentMember.Name = "chkStudentMember";
            this.chkStudentMember.Size = new System.Drawing.Size(255, 24);
            this.chkStudentMember.TabIndex = 13;
            this.chkStudentMember.Text = "Student Member(10% OFF)";
            this.chkStudentMember.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(623, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Order List";
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter.Location = new System.Drawing.Point(8, 510);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1154, 114);
            this.lblFooter.TabIndex = 18;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalPrice.Location = new System.Drawing.Point(15, 521);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(154, 20);
            this.lblTotalPrice.TabIndex = 19;
            this.lblTotalPrice.Text = "Total Price : $0.00";
            // 
            // lblLuckyMessage
            // 
            this.lblLuckyMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLuckyMessage.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLuckyMessage.Location = new System.Drawing.Point(12, 571);
            this.lblLuckyMessage.Name = "lblLuckyMessage";
            this.lblLuckyMessage.Size = new System.Drawing.Size(358, 39);
            this.lblLuckyMessage.TabIndex = 20;
            this.lblLuckyMessage.Click += new System.EventHandler(this.lblLuckyMessage_Click);
            // 
            // ListBoxOrder
            // 
            this.ListBoxOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxOrder.FormattingEnabled = true;
            this.ListBoxOrder.ItemHeight = 20;
            this.ListBoxOrder.Location = new System.Drawing.Point(621, 88);
            this.ListBoxOrder.Name = "ListBoxOrder";
            this.ListBoxOrder.Size = new System.Drawing.Size(519, 342);
            this.ListBoxOrder.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1174, 633);
            this.Controls.Add(this.ListBoxOrder);
            this.Controls.Add(this.lblLuckyMessage);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkStudentMember);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.groupDrink);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Form1";
            this.Text = "Lucky Cafe Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupDrink.ResumeLayout(false);
            this.groupDrink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupDrink;
        private System.Windows.Forms.RadioButton rdoJuice;
        private System.Windows.Forms.RadioButton rdoCoffee;
        private System.Windows.Forms.RadioButton rdoTea;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.CheckBox chkStudentMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblLuckyMessage;
        private System.Windows.Forms.ListBox ListBoxOrder;
    }
}

