
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
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.buttonSearchFname = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSearchLname = new System.Windows.Forms.Button();
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
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(42, 60);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(63, 13);
            this.labelFname.TabIndex = 2;
            this.labelFname.Text = "First Name :";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(260, 56);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(64, 13);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "Last Name :";
            // 
            // textFname
            // 
            this.textFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textFname.Location = new System.Drawing.Point(111, 53);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(100, 20);
            this.textFname.TabIndex = 5;
            // 
            // textLname
            // 
            this.textLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLname.Location = new System.Drawing.Point(330, 53);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(100, 20);
            this.textLname.TabIndex = 6;
            // 
            // buttonSearchFname
            // 
            this.buttonSearchFname.Location = new System.Drawing.Point(123, 81);
            this.buttonSearchFname.Name = "buttonSearchFname";
            this.buttonSearchFname.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchFname.TabIndex = 8;
            this.buttonSearchFname.Text = "Search";
            this.buttonSearchFname.UseVisualStyleBackColor = true;
            this.buttonSearchFname.Click += new System.EventHandler(this.buttonSearchFname_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 304);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(657, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(754, 55);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 12;
            // 
            // buttonSearchLname
            // 
            this.buttonSearchLname.Location = new System.Drawing.Point(343, 81);
            this.buttonSearchLname.Name = "buttonSearchLname";
            this.buttonSearchLname.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchLname.TabIndex = 13;
            this.buttonSearchLname.Text = "Search";
            this.buttonSearchLname.UseVisualStyleBackColor = true;
            this.buttonSearchLname.Click += new System.EventHandler(this.buttonSearchLname_Click_1);
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.buttonSearchLname);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearchFname);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
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
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.Button buttonSearchFname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSearchLname;
    }
}