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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.liveSym = new System.Windows.Forms.Label();
            this.symRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.poemArea = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.databaseSet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.databaseSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.databaseSet.Location = new System.Drawing.Point(254, 21);
            this.databaseSet.Name = "databaseSet";
            this.databaseSet.Size = new System.Drawing.Size(90, 70);
            this.databaseSet.TabIndex = 5;
            this.databaseSet.Text = "DatabaseSet";
            this.databaseSet.UseVisualStyleBackColor = false;
            this.databaseSet.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(158, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
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
            this.sllNumb.FormattingEnabled = true;
            this.sllNumb.Location = new System.Drawing.Point(7, 21);
            this.sllNumb.Name = "sllNumb";
            this.sllNumb.Size = new System.Drawing.Size(121, 21);
            this.sllNumb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İstenilen Kelime Sonu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hece Sayısı";
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.LightSkyBlue;
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results.FormattingEnabled = true;
            this.results.Location = new System.Drawing.Point(19, 150);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(241, 286);
            this.results.TabIndex = 1;
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.previousBtn.Location = new System.Drawing.Point(19, 447);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 23);
            this.previousBtn.TabIndex = 2;
            this.previousBtn.Text = "<<";
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.nextBtn.Location = new System.Drawing.Point(185, 447);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelimeler ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.liveSym);
            this.panel2.Controls.Add(this.symRecord);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.poemArea);
            this.panel2.Location = new System.Drawing.Point(267, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 347);
            this.panel2.TabIndex = 6;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.InfoText;
            this.save.Location = new System.Drawing.Point(6, 316);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(245, 28);
            this.save.TabIndex = 18;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Son Sayır Hece Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Toplam Hece Sayısı:";
            // 
            // liveSym
            // 
            this.liveSym.AutoSize = true;
            this.liveSym.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveSym.ForeColor = System.Drawing.Color.LightGray;
            this.liveSym.Location = new System.Drawing.Point(171, 294);
            this.liveSym.Name = "liveSym";
            this.liveSym.Size = new System.Drawing.Size(32, 19);
            this.liveSym.TabIndex = 15;
            this.liveSym.Text = "sda";
            // 
            // symRecord
            // 
            this.symRecord.AutoSize = true;
            this.symRecord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symRecord.ForeColor = System.Drawing.Color.LightGray;
            this.symRecord.Location = new System.Drawing.Point(171, 275);
            this.symRecord.Name = "symRecord";
            this.symRecord.Size = new System.Drawing.Size(63, 19);
            this.symRecord.TabIndex = 14;
            this.symRecord.Text = "asdasda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Şiir/Beste";
            // 
            // poemArea
            // 
            this.poemArea.BackColor = System.Drawing.Color.SkyBlue;
            this.poemArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poemArea.Location = new System.Drawing.Point(6, 27);
            this.poemArea.Name = "poemArea";
            this.poemArea.Size = new System.Drawing.Size(248, 245);
            this.poemArea.TabIndex = 12;
            this.poemArea.Text = "";
            this.poemArea.TextChanged += new System.EventHandler(this.poemArea_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(527, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.results);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label liveSym;
        private System.Windows.Forms.Label symRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox poemArea;
    }
}

