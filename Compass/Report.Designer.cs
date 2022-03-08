
namespace Compass
{
    partial class Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearchByDate = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountResult = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalResult = new System.Windows.Forms.Label();
            this.labelTotalCommission = new System.Windows.Forms.Label();
            this.labelTotalCommissionResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(343, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // buttonSearchByDate
            // 
            this.buttonSearchByDate.Location = new System.Drawing.Point(599, 60);
            this.buttonSearchByDate.Name = "buttonSearchByDate";
            this.buttonSearchByDate.Size = new System.Drawing.Size(142, 23);
            this.buttonSearchByDate.TabIndex = 4;
            this.buttonSearchByDate.Text = "SearchByDate";
            this.buttonSearchByDate.UseVisualStyleBackColor = true;
            this.buttonSearchByDate.Click += new System.EventHandler(this.buttonSearchByDate_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(27, 120);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(41, 13);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Count :";
            // 
            // labelCountResult
            // 
            this.labelCountResult.AutoSize = true;
            this.labelCountResult.Location = new System.Drawing.Point(74, 120);
            this.labelCountResult.Name = "labelCountResult";
            this.labelCountResult.Size = new System.Drawing.Size(73, 13);
            this.labelCountResult.TabIndex = 6;
            this.labelCountResult.Text = "___________";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(190, 120);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total :";
            // 
            // labelTotalResult
            // 
            this.labelTotalResult.AutoSize = true;
            this.labelTotalResult.Location = new System.Drawing.Point(233, 120);
            this.labelTotalResult.Name = "labelTotalResult";
            this.labelTotalResult.Size = new System.Drawing.Size(73, 13);
            this.labelTotalResult.TabIndex = 8;
            this.labelTotalResult.Text = "___________";
            // 
            // labelTotalCommission
            // 
            this.labelTotalCommission.AutoSize = true;
            this.labelTotalCommission.Location = new System.Drawing.Point(325, 120);
            this.labelTotalCommission.Name = "labelTotalCommission";
            this.labelTotalCommission.Size = new System.Drawing.Size(95, 13);
            this.labelTotalCommission.TabIndex = 9;
            this.labelTotalCommission.Text = "Total Commission :";
            // 
            // labelTotalCommissionResult
            // 
            this.labelTotalCommissionResult.AutoSize = true;
            this.labelTotalCommissionResult.Location = new System.Drawing.Point(426, 120);
            this.labelTotalCommissionResult.Name = "labelTotalCommissionResult";
            this.labelTotalCommissionResult.Size = new System.Drawing.Size(43, 13);
            this.labelTotalCommissionResult.TabIndex = 10;
            this.labelTotalCommissionResult.Text = "______";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 501);
            this.Controls.Add(this.labelTotalCommissionResult);
            this.Controls.Add(this.labelTotalCommission);
            this.Controls.Add(this.labelTotalResult);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelCountResult);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSearchByDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonSearchByDate;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountResult;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalResult;
        private System.Windows.Forms.Label labelTotalCommission;
        private System.Windows.Forms.Label labelTotalCommissionResult;
    }
}