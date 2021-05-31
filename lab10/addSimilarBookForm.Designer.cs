
namespace lab10
{
    partial class addSimilarBookForm
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
            this.newSimilarBookBox = new System.Windows.Forms.TextBox();
            this.addsimilarBookCancel = new System.Windows.Forms.Button();
            this.addsimilarBooKOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name of similar book:";
            // 
            // newSimilarBookBox
            // 
            this.newSimilarBookBox.Location = new System.Drawing.Point(174, 75);
            this.newSimilarBookBox.Name = "newSimilarBookBox";
            this.newSimilarBookBox.Size = new System.Drawing.Size(199, 20);
            this.newSimilarBookBox.TabIndex = 1;
            // 
            // addsimilarBookCancel
            // 
            this.addsimilarBookCancel.Location = new System.Drawing.Point(67, 127);
            this.addsimilarBookCancel.Name = "addsimilarBookCancel";
            this.addsimilarBookCancel.Size = new System.Drawing.Size(75, 23);
            this.addsimilarBookCancel.TabIndex = 2;
            this.addsimilarBookCancel.Text = "Cancel";
            this.addsimilarBookCancel.UseVisualStyleBackColor = true;
            this.addsimilarBookCancel.Click += new System.EventHandler(this.addsimilarBookCancel_Click);
            // 
            // addsimilarBooKOk
            // 
            this.addsimilarBooKOk.Location = new System.Drawing.Point(199, 127);
            this.addsimilarBooKOk.Name = "addsimilarBooKOk";
            this.addsimilarBooKOk.Size = new System.Drawing.Size(75, 23);
            this.addsimilarBooKOk.TabIndex = 3;
            this.addsimilarBooKOk.Text = "Ok";
            this.addsimilarBooKOk.UseVisualStyleBackColor = true;
            this.addsimilarBooKOk.Click += new System.EventHandler(this.addsimilarBooKOk_Click);
            // 
            // addSimilarBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addsimilarBooKOk);
            this.Controls.Add(this.addsimilarBookCancel);
            this.Controls.Add(this.newSimilarBookBox);
            this.Controls.Add(this.label1);
            this.Name = "addSimilarBookForm";
            this.Text = "addSimilarBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newSimilarBookBox;
        private System.Windows.Forms.Button addsimilarBookCancel;
        private System.Windows.Forms.Button addsimilarBooKOk;
    }
}