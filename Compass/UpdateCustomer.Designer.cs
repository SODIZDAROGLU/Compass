
namespace Compass
{
    partial class UpdateCustomer
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
            this.labelUpdateCustomer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFname = new System.Windows.Forms.Button();
            this.buttonLname = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonPassport = new System.Windows.Forms.Button();
            this.buttonTicketNo = new System.Windows.Forms.Button();
            this.buttonCustomerID = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(458, 84);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 82;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(373, 87);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(68, 13);
            this.labelCustomerID.TabIndex = 81;
            this.labelCustomerID.Text = "CustomerID :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(760, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 188);
            this.richTextBox1.TabIndex = 80;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(458, 205);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 78;
            this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textCommission
            // 
            this.textCommission.Location = new System.Drawing.Point(458, 169);
            this.textCommission.Name = "textCommission";
            this.textCommission.Size = new System.Drawing.Size(100, 20);
            this.textCommission.TabIndex = 77;
            this.textCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCommission.TextChanged += new System.EventHandler(this.textCommission_TextChanged);
            this.textCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCommission_KeyPress);
            // 
            // textTax
            // 
            this.textTax.Location = new System.Drawing.Point(458, 136);
            this.textTax.Name = "textTax";
            this.textTax.Size = new System.Drawing.Size(100, 20);
            this.textTax.TabIndex = 76;
            this.textTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTax.TextChanged += new System.EventHandler(this.textTax_TextChanged);
            this.textTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTax_KeyPress);
            // 
            // textTfee
            // 
            this.textTfee.Location = new System.Drawing.Point(458, 110);
            this.textTfee.Name = "textTfee";
            this.textTfee.Size = new System.Drawing.Size(100, 20);
            this.textTfee.TabIndex = 75;
            this.textTfee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTfee.TextChanged += new System.EventHandler(this.textTfee_TextChanged);
            this.textTfee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTfee_KeyPress);
            // 
            // textTicket
            // 
            this.textTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textTicket.Location = new System.Drawing.Point(88, 251);
            this.textTicket.Name = "textTicket";
            this.textTicket.Size = new System.Drawing.Size(100, 20);
            this.textTicket.TabIndex = 74;
            this.textTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTicket_KeyPress);
            // 
            // textPassport
            // 
            this.textPassport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPassport.Location = new System.Drawing.Point(88, 221);
            this.textPassport.Name = "textPassport";
            this.textPassport.Size = new System.Drawing.Size(100, 20);
            this.textPassport.TabIndex = 73;
            this.textPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPassport_KeyPress);
            // 
            // textBooking
            // 
            this.textBooking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBooking.Location = new System.Drawing.Point(88, 191);
            this.textBooking.Name = "textBooking";
            this.textBooking.Size = new System.Drawing.Size(100, 20);
            this.textBooking.TabIndex = 72;
            this.textBooking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBooking_KeyPress);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(88, 155);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 71;
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // textLname
            // 
            this.textLname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textLname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLname.Location = new System.Drawing.Point(88, 124);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(100, 20);
            this.textLname.TabIndex = 70;
            this.textLname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textLname_KeyDown);
            this.textLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLname_KeyPress);
            // 
            // textFname
            // 
            this.textFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textFname.Location = new System.Drawing.Point(88, 91);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(100, 20);
            this.textFname.TabIndex = 69;
            this.textFname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFname_KeyDown);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(718, 82);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 13);
            this.labelNote.TabIndex = 68;
            this.labelNote.Text = "Note :";
            // 
            // labelRdate
            // 
            this.labelRdate.AutoSize = true;
            this.labelRdate.Location = new System.Drawing.Point(378, 251);
            this.labelRdate.Name = "labelRdate";
            this.labelRdate.Size = new System.Drawing.Size(71, 13);
            this.labelRdate.TabIndex = 67;
            this.labelRdate.Text = "RecordDate :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(378, 205);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 66;
            this.labelTotal.Text = "Total :";
            // 
            // labelCommision
            // 
            this.labelCommision.AutoSize = true;
            this.labelCommision.Location = new System.Drawing.Point(378, 172);
            this.labelCommision.Name = "labelCommision";
            this.labelCommision.Size = new System.Drawing.Size(63, 13);
            this.labelCommision.TabIndex = 65;
            this.labelCommision.Text = "Commision :";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(373, 143);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(34, 13);
            this.labelTax.TabIndex = 64;
            this.labelTax.Text = " Tax :";
            // 
            // labelTfee
            // 
            this.labelTfee.AutoSize = true;
            this.labelTfee.Location = new System.Drawing.Point(373, 117);
            this.labelTfee.Name = "labelTfee";
            this.labelTfee.Size = new System.Drawing.Size(64, 13);
            this.labelTfee.TabIndex = 63;
            this.labelTfee.Text = "Ticket Fee :";
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(22, 254);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(60, 13);
            this.labelTicket.TabIndex = 62;
            this.labelTicket.Text = "Ticket No :";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(22, 224);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(54, 13);
            this.labelPassport.TabIndex = 61;
            this.labelPassport.Text = "Passport :";
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.Location = new System.Drawing.Point(22, 194);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(52, 13);
            this.labelBooking.TabIndex = 60;
            this.labelBooking.Text = "Booking :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(22, 158);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(44, 13);
            this.labelPhone.TabIndex = 59;
            this.labelPhone.Text = "Phone :";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(24, 127);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(64, 13);
            this.labelLname.TabIndex = 58;
            this.labelLname.Text = "Last Name :";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(22, 91);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(63, 13);
            this.labelFname.TabIndex = 57;
            this.labelFname.Text = "First Name :";
            // 
            // labelUpdateCustomer
            // 
            this.labelUpdateCustomer.AutoSize = true;
            this.labelUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateCustomer.Location = new System.Drawing.Point(467, 9);
            this.labelUpdateCustomer.Name = "labelUpdateCustomer";
            this.labelUpdateCustomer.Size = new System.Drawing.Size(303, 31);
            this.labelUpdateCustomer.TabIndex = 83;
            this.labelUpdateCustomer.Text = "UPDATE CUSTOMER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1195, 326);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(222, 625);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 85;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonFname
            // 
            this.buttonFname.Location = new System.Drawing.Point(222, 91);
            this.buttonFname.Name = "buttonFname";
            this.buttonFname.Size = new System.Drawing.Size(75, 23);
            this.buttonFname.TabIndex = 87;
            this.buttonFname.Text = "Search";
            this.buttonFname.UseVisualStyleBackColor = true;
            this.buttonFname.Click += new System.EventHandler(this.buttonFname_Click);
            // 
            // buttonLname
            // 
            this.buttonLname.Location = new System.Drawing.Point(222, 124);
            this.buttonLname.Name = "buttonLname";
            this.buttonLname.Size = new System.Drawing.Size(75, 23);
            this.buttonLname.TabIndex = 88;
            this.buttonLname.Text = "Search";
            this.buttonLname.UseVisualStyleBackColor = true;
            this.buttonLname.Click += new System.EventHandler(this.buttonLname_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Location = new System.Drawing.Point(222, 187);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(75, 23);
            this.buttonBooking.TabIndex = 89;
            this.buttonBooking.Text = "Search";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonPassport
            // 
            this.buttonPassport.Location = new System.Drawing.Point(222, 217);
            this.buttonPassport.Name = "buttonPassport";
            this.buttonPassport.Size = new System.Drawing.Size(75, 23);
            this.buttonPassport.TabIndex = 90;
            this.buttonPassport.Text = "Search";
            this.buttonPassport.UseVisualStyleBackColor = true;
            this.buttonPassport.Click += new System.EventHandler(this.buttonPassport_Click);
            // 
            // buttonTicketNo
            // 
            this.buttonTicketNo.Location = new System.Drawing.Point(222, 247);
            this.buttonTicketNo.Name = "buttonTicketNo";
            this.buttonTicketNo.Size = new System.Drawing.Size(75, 23);
            this.buttonTicketNo.TabIndex = 91;
            this.buttonTicketNo.Text = "Search";
            this.buttonTicketNo.UseVisualStyleBackColor = true;
            this.buttonTicketNo.Click += new System.EventHandler(this.buttonTicketNo_Click);
            // 
            // buttonCustomerID
            // 
            this.buttonCustomerID.Location = new System.Drawing.Point(570, 82);
            this.buttonCustomerID.Name = "buttonCustomerID";
            this.buttonCustomerID.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerID.TabIndex = 92;
            this.buttonCustomerID.Text = "Search";
            this.buttonCustomerID.UseVisualStyleBackColor = true;
            this.buttonCustomerID.Click += new System.EventHandler(this.buttonCustomerID_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(366, 625);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 93;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 660);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCustomerID);
            this.Controls.Add(this.buttonTicketNo);
            this.Controls.Add(this.buttonPassport);
            this.Controls.Add(this.buttonBooking);
            this.Controls.Add(this.buttonLname);
            this.Controls.Add(this.buttonFname);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelUpdateCustomer);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.labelCustomerID);
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
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
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
        private System.Windows.Forms.Label labelUpdateCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFname;
        private System.Windows.Forms.Button buttonLname;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonPassport;
        private System.Windows.Forms.Button buttonTicketNo;
        private System.Windows.Forms.Button buttonCustomerID;
        private System.Windows.Forms.Button buttonClear;
    }
}