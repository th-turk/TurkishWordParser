namespace TurkishWordParser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.databaseSet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lastLetters = new System.Windows.Forms.TextBox();
            this.sllNumb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.ListBox();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.databaseSet);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lastLetters);
            this.panel1.Controls.Add(this.sllNumb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 105);
            this.panel1.TabIndex = 0;
            // 
            // databaseSet
            // 
            this.databaseSet.Location = new System.Drawing.Point(254, 21);
            this.databaseSet.Name = "databaseSet";
            this.databaseSet.Size = new System.Drawing.Size(90, 70);
            this.databaseSet.TabIndex = 5;
            this.databaseSet.Text = "DatabaseSet";
            this.databaseSet.UseVisualStyleBackColor = true;
            this.databaseSet.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastLetters
            // 
            this.lastLetters.Location = new System.Drawing.Point(7, 71);
            this.lastLetters.Name = "lastLetters";
            this.lastLetters.Size = new System.Drawing.Size(121, 20);
            this.lastLetters.TabIndex = 3;
            // 
            // sllNumb
            // 
            this.sllNumb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.sllNumb.FormattingEnabled = true;
            this.sllNumb.Location = new System.Drawing.Point(7, 21);
            this.sllNumb.Name = "sllNumb";
            this.sllNumb.Size = new System.Drawing.Size(121, 21);
            this.sllNumb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İstenilen Kelime Sonu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hece Sayısı";
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.Location = new System.Drawing.Point(19, 123);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(241, 290);
            this.results.TabIndex = 1;
            // 
            // previousBtn
            // 
            this.previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.Location = new System.Drawing.Point(19, 420);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 2;
            this.previousBtn.Text = "<<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(185, 420);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.results);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lastLetters;
        private System.Windows.Forms.ComboBox sllNumb;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Button databaseSet;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}

