
namespace lab10
{
    partial class addnewBook
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
            this.addnewBookBox = new System.Windows.Forms.TextBox();
            this.addnewBookCancel = new System.Windows.Forms.Button();
            this.addnewBooKOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name of new book:";
            // 
            // addnewBookBox
            // 
            this.addnewBookBox.Location = new System.Drawing.Point(193, 63);
            this.addnewBookBox.Name = "addnewBookBox";
            this.addnewBookBox.Size = new System.Drawing.Size(237, 20);
            this.addnewBookBox.TabIndex = 1;
            // 
            // addnewBookCancel
            // 
            this.addnewBookCancel.Location = new System.Drawing.Point(112, 115);
            this.addnewBookCancel.Name = "addnewBookCancel";
            this.addnewBookCancel.Size = new System.Drawing.Size(75, 23);
            this.addnewBookCancel.TabIndex = 2;
            this.addnewBookCancel.Text = "Cancel";
            this.addnewBookCancel.UseVisualStyleBackColor = true;
            this.addnewBookCancel.Click += new System.EventHandler(this.addnewBookCancel_Click);
            // 
            // addnewBooKOk
            // 
            this.addnewBooKOk.Location = new System.Drawing.Point(279, 115);
            this.addnewBooKOk.Name = "addnewBooKOk";
            this.addnewBooKOk.Size = new System.Drawing.Size(75, 23);
            this.addnewBooKOk.TabIndex = 3;
            this.addnewBooKOk.Text = "OK";
            this.addnewBooKOk.UseVisualStyleBackColor = true;
            this.addnewBooKOk.Click += new System.EventHandler(this.addnewBooKOk_Click);
            // 
            // addnewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addnewBooKOk);
            this.Controls.Add(this.addnewBookCancel);
            this.Controls.Add(this.addnewBookBox);
            this.Controls.Add(this.label1);
            this.Name = "addnewBook";
            this.Text = "addNewBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addnewBookBox;
        private System.Windows.Forms.Button addnewBookCancel;
        private System.Windows.Forms.Button addnewBooKOk;
    }
}