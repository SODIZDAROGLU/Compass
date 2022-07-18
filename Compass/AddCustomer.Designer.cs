
namespace Compass
{
    partial class AddCustomer
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
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textCommission = new System.Windows.Forms.TextBox();
            this.textTax = new System.Windows.Forms.TextBox();
            this.textTfee = new System.Windows.Forms.TextBox();
            this.textTicket = new System.Windows.Forms.TextBox();
            this.textPassport = new System.Windows.Forms.TextBox();
            this.textBooking = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelRdate = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCommision = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTfee = new System.Windows.Forms.Label();
            this.labelTicket = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelBooking = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(350, 58);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 56;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(268, 61);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(68, 13);
            this.labelCustomerID.TabIndex = 55;
            this.labelCustomerID.Text = "CustomerID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "NEW CUSTOMER";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 325);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 53;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(589, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 248);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(350, 193);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 50;
            this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textCommission
            // 
            this.textCommission.Location = new System.Drawing.Point(350, 163);
            this.textCommission.Name = "textCommission";
            this.textCommission.Size = new System.Drawing.Size(100, 20);
            this.textCommission.TabIndex = 49;
            this.textCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCommission.TextChanged += new System.EventHandler(this.textCommission_TextChanged);
            this.textCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCommission_KeyPress);
            // 
            // textTax
            // 
            this.textTax.Location = new System.Drawing.Point(350, 128);
            this.textTax.Name = "textTax";
            this.textTax.Size = new System.Drawing.Size(100, 20);
            this.textTax.TabIndex = 48;
            this.textTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTax.TextChanged += new System.EventHandler(this.textTax_TextChanged);
            this.textTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTax_KeyPress);
            // 
            // textTfee
            // 
            this.textTfee.Location = new System.Drawing.Point(350, 92);
            this.textTfee.Name = "textTfee";
            this.textTfee.Size = new System.Drawing.Size(100, 20);
            this.textTfee.TabIndex = 47;
            this.textTfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTfee.TextChanged += new System.EventHandler(this.textTfee_TextChanged);
            this.textTfee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTfee_KeyPress);
            // 
            // textTicket
            // 
            this.textTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textTicket.Location = new System.Drawing.Point(94, 228);
            this.textTicket.Name = "textTicket";
            this.textTicket.Size = new System.Drawing.Size(100, 20);
            this.textTicket.TabIndex = 46;
            this.textTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTicket_KeyPress);
            // 
            // textPassport
            // 
            this.textPassport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPassport.Location = new System.Drawing.Point(94, 196);
            this.textPassport.Name = "textPassport";
            this.textPassport.Size = new System.Drawing.Size(100, 20);
            this.textPassport.TabIndex = 45;
            this.textPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPassport_KeyPress);
            // 
            // textBooking
            // 
            this.textBooking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBooking.Location = new System.Drawing.Point(94, 160);
            this.textBooking.MaxLength = 3256;
            this.textBooking.Name = "textBooking";
            this.textBooking.Size = new System.Drawing.Size(100, 20);
            this.textBooking.TabIndex = 44;
            this.textBooking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBooking_KeyPress);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(94, 125);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 43;
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // textLname
            // 
            this.textLname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textLname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLname.Location = new System.Drawing.Point(94, 92);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(100, 20);
            this.textLname.TabIndex = 42;
            this.textLname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textLname_KeyDown);
            // 
            // textFname
            // 
            this.textFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textFname.Location = new System.Drawing.Point(94, 58);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(100, 20);
            this.textFname.TabIndex = 41;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(536, 61);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 13);
            this.labelNote.TabIndex = 40;
            this.labelNote.Text = "Note :";
            // 
            // labelRdate
            // 
            this.labelRdate.AutoSize = true;
            this.labelRdate.Location = new System.Drawing.Point(28, 269);
            this.labelRdate.Name = "labelRdate";
            this.labelRdate.Size = new System.Drawing.Size(71, 13);
            this.labelRdate.TabIndex = 39;
            this.labelRdate.Text = "RecordDate :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(268, 199);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 38;
            this.labelTotal.Text = "Total :";
            // 
            // labelCommision
            // 
            this.labelCommision.AutoSize = true;
            this.labelCommision.Location = new System.Drawing.Point(269, 166);
            this.labelCommision.Name = "labelCommision";
            this.labelCommision.Size = new System.Drawing.Size(63, 13);
            this.labelCommision.TabIndex = 37;
            this.labelCommision.Text = "Commision :";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(268, 128);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(34, 13);
            this.labelTax.TabIndex = 36;
            this.labelTax.Text = " Tax :";
            // 
            // labelTfee
            // 
            this.labelTfee.AutoSize = true;
            this.labelTfee.Location = new System.Drawing.Point(268, 95);
            this.labelTfee.Name = "labelTfee";
            this.labelTfee.Size = new System.Drawing.Size(64, 13);
            this.labelTfee.TabIndex = 35;
            this.labelTfee.Text = "Ticket Fee :";
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(24, 231);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(60, 13);
            this.labelTicket.TabIndex = 34;
            this.labelTicket.Text = "Ticket No :";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(24, 196);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(54, 13);
            this.labelPassport.TabIndex = 33;
            this.labelPassport.Text = "Passport :";
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.Location = new System.Drawing.Point(24, 160);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(52, 13);
            this.labelBooking.TabIndex = 32;
            this.labelBooking.Text = "Booking :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(24, 125);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(44, 13);
            this.labelPhone.TabIndex = 31;
            this.labelPhone.Text = "Phone :";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(24, 92);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(64, 13);
            this.labelLname.TabIndex = 30;
            this.labelLname.Text = "Last Name :";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(24, 58);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(63, 13);
            this.labelFname.TabIndex = 29;
            this.labelFname.Text = "First Name :";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 509);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textCommission);
            this.Controls.Add(this.textTax);
            this.Controls.Add(this.textTfee);
            this.Controls.Add(this.textTicket);
            this.Controls.Add(this.textPassport);
            this.Controls.Add(this.textBooking);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelRdate);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelCommision);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelTfee);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelBooking);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textCommission;
        private System.Windows.Forms.TextBox textTax;
        private System.Windows.Forms.TextBox textTfee;
        private System.Windows.Forms.TextBox textTicket;
        private System.Windows.Forms.TextBox textPassport;
        private System.Windows.Forms.TextBox textBooking;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelRdate;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCommision;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTfee;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelBooking;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFname;
    }
}