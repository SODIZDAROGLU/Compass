
namespace Compass
{
    partial class Menu
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUpdateCustomer = new System.Windows.Forms.Label();
            this.labelRemoveCustomer = new System.Windows.Forms.Label();
            this.labelAddCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(61, 41);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(178, 31);
            this.labelMenu.TabIndex = 9;
            this.labelMenu.Text = "MAIN MENU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "4.Customer List";
            // 
            // labelUpdateCustomer
            // 
            this.labelUpdateCustomer.AutoSize = true;
            this.labelUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateCustomer.Location = new System.Drawing.Point(63, 171);
            this.labelUpdateCustomer.Name = "labelUpdateCustomer";
            this.labelUpdateCustomer.Size = new System.Drawing.Size(165, 20);
            this.labelUpdateCustomer.TabIndex = 7;
            this.labelUpdateCustomer.Text = "3.Update Customer";
            // 
            // labelRemoveCustomer
            // 
            this.labelRemoveCustomer.AutoSize = true;
            this.labelRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveCustomer.Location = new System.Drawing.Point(63, 135);
            this.labelRemoveCustomer.Name = "labelRemoveCustomer";
            this.labelRemoveCustomer.Size = new System.Drawing.Size(171, 20);
            this.labelRemoveCustomer.TabIndex = 6;
            this.labelRemoveCustomer.Text = "2.Remove Customer";
            // 
            // labelAddCustomer
            // 
            this.labelAddCustomer.AutoSize = true;
            this.labelAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCustomer.Location = new System.Drawing.Point(63, 99);
            this.labelAddCustomer.Name = "labelAddCustomer";
            this.labelAddCustomer.Size = new System.Drawing.Size(138, 20);
            this.labelAddCustomer.TabIndex = 5;
            this.labelAddCustomer.Text = "1.Add Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "5.REPORTS";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUpdateCustomer);
            this.Controls.Add(this.labelRemoveCustomer);
            this.Controls.Add(this.labelAddCustomer);
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUpdateCustomer;
        private System.Windows.Forms.Label labelRemoveCustomer;
        private System.Windows.Forms.Label labelAddCustomer;
        private System.Windows.Forms.Label label1;
    }
}

