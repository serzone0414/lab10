
namespace lab10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.resultlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addBookbtn = new System.Windows.Forms.Button();
            this.addSimilarBookbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.booklistbox = new System.Windows.Forms.ListBox();
            this.similarbookslistbox = new System.Windows.Forms.ListBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.noresultlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.booklistbox);
            this.groupBox1.Location = new System.Drawing.Point(31, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AvailableBooks";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.similarbookslistbox);
            this.groupBox2.Location = new System.Drawing.Point(271, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Similarbooks";
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Location = new System.Drawing.Point(28, 25);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(41, 13);
            this.searchlbl.TabIndex = 2;
            this.searchlbl.Text = "Search";
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(211, 29);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(75, 13);
            this.resultlbl.TabIndex = 3;
            this.resultlbl.Text = "Results Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(486, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(71, 175);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ISBN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Year";
            // 
            // addBookbtn
            // 
            this.addBookbtn.Location = new System.Drawing.Point(31, 381);
            this.addBookbtn.Name = "addBookbtn";
            this.addBookbtn.Size = new System.Drawing.Size(107, 24);
            this.addBookbtn.TabIndex = 7;
            this.addBookbtn.Text = "AddBook";
            this.addBookbtn.UseVisualStyleBackColor = true;
            this.addBookbtn.Click += new System.EventHandler(this.addBookbtn_Click);
            // 
            // addSimilarBookbtn
            // 
            this.addSimilarBookbtn.Location = new System.Drawing.Point(271, 381);
            this.addSimilarBookbtn.Name = "addSimilarBookbtn";
            this.addSimilarBookbtn.Size = new System.Drawing.Size(147, 24);
            this.addSimilarBookbtn.TabIndex = 8;
            this.addSimilarBookbtn.Text = "AddSimilarBook";
            this.addSimilarBookbtn.UseVisualStyleBackColor = true;
            this.addSimilarBookbtn.Click += new System.EventHandler(this.addSimilarBookbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // booklistbox
            // 
            this.booklistbox.FormattingEnabled = true;
            this.booklistbox.Location = new System.Drawing.Point(6, 19);
            this.booklistbox.Name = "booklistbox";
            this.booklistbox.Size = new System.Drawing.Size(192, 212);
            this.booklistbox.TabIndex = 0;
            this.booklistbox.SelectedIndexChanged += new System.EventHandler(this.booklistbox_SelectedIndexChanged);
            // 
            // similarbookslistbox
            // 
            this.similarbookslistbox.FormattingEnabled = true;
            this.similarbookslistbox.Location = new System.Drawing.Point(8, 18);
            this.similarbookslistbox.Name = "similarbookslistbox";
            this.similarbookslistbox.Size = new System.Drawing.Size(192, 212);
            this.similarbookslistbox.TabIndex = 1;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(573, 259);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(107, 24);
            this.saveChanges.TabIndex = 10;
            this.saveChanges.Text = "saveChanges";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(69, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(117, 20);
            this.searchBox.TabIndex = 11;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_Text);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(563, 143);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(117, 20);
            this.priceBox.TabIndex = 12;
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(563, 169);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(117, 20);
            this.isbnBox.TabIndex = 13;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(563, 200);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(117, 20);
            this.authorBox.TabIndex = 14;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(563, 229);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(117, 20);
            this.yearBox.TabIndex = 15;
            // 
            // noresultlbl
            // 
            this.noresultlbl.AutoSize = true;
            this.noresultlbl.Location = new System.Drawing.Point(211, 29);
            this.noresultlbl.Name = "noresultlbl";
            this.noresultlbl.Size = new System.Drawing.Size(92, 13);
            this.noresultlbl.TabIndex = 16;
            this.noresultlbl.Text = "No Results Found";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entries:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Entries:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noresultlbl);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addSimilarBookbtn);
            this.Controls.Add(this.addBookbtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox booklistbox;
        private System.Windows.Forms.ListBox similarbookslistbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBookbtn;
        private System.Windows.Forms.Button addSimilarBookbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label noresultlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

