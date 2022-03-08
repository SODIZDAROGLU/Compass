
namespace Compass
{
    partial class RemoveCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.buttonSearchID = new System.Windows.Forms.Button();
            this.buttonSearchFname = new System.Windows.Forms.Button();
            this.buttonSearchLname = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE CUSTOMER";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(29, 89);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(71, 13);
            this.labelCustomerID.TabIndex = 1;
            this.labelCustomerID.Text = "Customer ID :";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(29, 119);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(63, 13);
            this.labelFname.TabIndex = 2;
            this.labelFname.Text = "First Name :";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(29, 155);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(64, 13);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "Last Name :";
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(106, 86);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 4;
            // 
            // textFname
            // 
            this.textFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textFname.Location = new System.Drawing.Point(106, 116);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(100, 20);
            this.textFname.TabIndex = 5;
            // 
            // textLname
            // 
            this.textLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLname.Location = new System.Drawing.Point(106, 151);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(100, 20);
            this.textLname.TabIndex = 6;
            // 
            // buttonSearchID
            // 
            this.buttonSearchID.Location = new System.Drawing.Point(229, 84);
            this.buttonSearchID.Name = "buttonSearchID";
            this.buttonSearchID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchID.TabIndex = 7;
            this.buttonSearchID.Text = "Search";
            this.buttonSearchID.UseVisualStyleBackColor = true;
            this.buttonSearchID.Click += new System.EventHandler(this.buttonSearchID_Click);
            // 
            // buttonSearchFname
            // 
            this.buttonSearchFname.Location = new System.Drawing.Point(229, 117);
            this.buttonSearchFname.Name = "buttonSearchFname";
            this.buttonSearchFname.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchFname.TabIndex = 8;
            this.buttonSearchFname.Text = "Search";
            this.buttonSearchFname.UseVisualStyleBackColor = true;
            this.buttonSearchFname.Click += new System.EventHandler(this.buttonSearchFname_Click);
            // 
            // buttonSearchLname
            // 
            this.buttonSearchLname.Location = new System.Drawing.Point(229, 149);
            this.buttonSearchLname.Name = "buttonSearchLname";
            this.buttonSearchLname.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchLname.TabIndex = 9;
            this.buttonSearchLname.Text = "Search";
            this.buttonSearchLname.UseVisualStyleBackColor = true;
            this.buttonSearchLname.Click += new System.EventHandler(this.buttonSearchLname_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(399, 387);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearchLname);
            this.Controls.Add(this.buttonSearchFname);
            this.Controls.Add(this.buttonSearchID);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "RemoveCustomer";
            this.Text = "RemoveCustomer";
            this.Load += new System.EventHandler(this.RemoveCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.Button buttonSearchID;
        private System.Windows.Forms.Button buttonSearchFname;
        private System.Windows.Forms.Button buttonSearchLname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
    }
}