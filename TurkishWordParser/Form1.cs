using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkishWordParser
{
    public partial class Form1 : Form
    {
        List<Word> words = new List<Word>();
        public Form1()
        {
            InitializeComponent();
            comboBoxSet();
            databaseSet.Visible = false;
            previousBtn.Visible = false;
            nextBtn.Visible = false;
            results.DataSource = words;
            results.DisplayMember = "fullInfo";
        }

        //ComboBox
        public void comboBoxSet()
        {
            for (int i = 1; i < 21; i++)
            {
                sllNumb.Items.Add(i);
            }
        }

        DataAccess db = new DataAccess();
        int sllIndex;
        string lastLetter;
        int sllnum;
        bool sllFlag = false;
        bool letterFlag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            current =  0;

            sllIndex = sllNumb.SelectedIndex;
            lastLetter = lastLetters.Text.Trim();
            
            if (sllIndex > -1)
                sllFlag = true;
            if (!lastLetter.Equals(""))
                letterFlag = true;

            if(letterFlag && sllFlag)
            {
                //both  area setted
                sllnum = Convert.ToInt32(sllNumb.Items[sllIndex]);
         
                words = db.GetWords(sllnum, lastLetter,current);
                if (!words.Count.Equals(0))
                {
                    nextBtn.Visible = true;
                    listBoxUpdate(words);
                    current += 10;
                }
                else
                    emptyMessage();

            }
            else if (letterFlag && !sllFlag )
            {
                //sll  is empty
                words = db.GetWords(lastLetter,current);
                if (!words.Count.Equals(0))
                {
                    nextBtn.Visible = true;
                    listBoxUpdate(words);
                    current += 10;
                }
                else
                    emptyMessage();

            }
            else if (!letterFlag && sllFlag)
            {
                //letter  is empty
                sllnum = Convert.ToInt32(sllNumb.Items[sllIndex]);
                words = db.GetWords(sllnum,current);
                if (!words.Count.Equals(0))
                {
                    nextBtn.Visible = true;
                    listBoxUpdate(words);
                    current += 10;
                }
                else
                    emptyMessage();
            }
            else
            {
                // both area are empty
                MessageBox.Show("Alanları Doldurunuz ",
                                "Critical Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign,
                                true);
            }
            
        }
        //Words List Empty
        public void emptyMessage()
        {
            // both area are empty
            MessageBox.Show("Sonuç Bulunamadı \n" +
                            "Yeni Arama Yapınız",
                            "Critical Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign,
                            true);
        }
        //ListBox Update
        public  void listBoxUpdate(List<Word> words)
        {

            results.DataSource = null;
            results.DataSource = words;
            results.DisplayMember = "fullInfo";
        }
        public void transferData(string[] lines)
        {
            foreach (var item in lines)
            {
                string mainString = "";
                int numbSll = 0;
                string[] words = item.Split('\t');

                mainString = words[0].Replace("'", string.Empty).ToLower();
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü' };
                numbSll = mainString.Count(c => vowels.Contains(c));

                DataAccess db = new DataAccess();
                Word word = new Word();
                word.word = mainString;
                word.sllnumber = numbSll;
                db.InsertWord(word);

            }

            MessageBox.Show("Transfer Completed");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\TurkishWords\words.txt", Encoding.UTF8);
            string[] lines1 = System.IO.File.ReadAllLines(@"D:\TurkishWords\words1.txt", Encoding.UTF8);


            Thread thread = new Thread(() => transferData(lines));
            thread.Start();

            Thread thread1 = new Thread(() => transferData(lines1));
            thread1.Start();

        }

        int current = 0;
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (!(current<=10))
            {
                current -= 10;
                
                if (sllIndex > -1)
                    sllFlag = true;
                if (!lastLetter.Equals(""))
                    letterFlag = true;

                if (letterFlag && sllFlag)
                {
                    //both  area setted
                    words = db.GetWords(sllnum, lastLetter, current);
                    if (!words.Count.Equals(0))
                    {
                        listBoxUpdate(words);
                        current -= 10;
                    }
                    else
                        emptyMessage();

                }
                else if (letterFlag && !sllFlag)
                {
                    //sll  is empty
                    words = db.GetWords(lastLetter, current);
                    if (!words.Count.Equals(0))
                    {
                        listBoxUpdate(words);
                        current -= 10;
                    }
                    else
                        emptyMessage();

                }
                else if (!letterFlag && sllFlag)
                {
                    //letter  is empty
                    words = db.GetWords(sllnum, current);
                    if (!words.Count.Equals(0))
                    {
                        listBoxUpdate(words);
                        current -= 10;
                    }
                    else
                        emptyMessage();
                }
                else
                {
                    // both area are empty
                    MessageBox.Show("Alanları Doldurunuz ",
                                    "Critical Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RightAlign,
                                    true);
                }
            }
            else
                previousBtn.Visible = false;

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (!(words.Count<10))
            {
                current += 10;

                if (sllIndex > -1)
                    sllFlag = true;
                if (!lastLetter.Equals(""))
                    letterFlag = true;

                if (letterFlag && sllFlag)
                {
                    //both  area setted
                    words = db.GetWords(sllnum, lastLetter, current);
                    if (!words.Count.Equals(0))
                    {
                        previousBtn.Visible = true;
                        listBoxUpdate(words);
                        current += 10;
                    }
                    else
                        emptyMessage();

                }
                else if (letterFlag && !sllFlag)
                {
                    //sll  is empty
                    words = db.GetWords(lastLetter, current);
                    if (!words.Count.Equals(0))
                    {
                        previousBtn.Visible = true;
                        listBoxUpdate(words);
                        current += 10;
                    }
                    else
                        emptyMessage();

                }
                else if (!letterFlag && sllFlag)
                {
                    //letter  is empty
                    words = db.GetWords(sllnum, current);
                    if (!words.Count.Equals(0))
                    {
                        previousBtn.Visible = true;
                        listBoxUpdate(words);
                        current += 10;
                    }
                    else
                        emptyMessage();
                }
                else
                {
                    // both area are empty
                    MessageBox.Show("Alanları Doldurunuz ",
                                    "Critical Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RightAlign,
                                    true);
                }
            }
            else
                nextBtn.Visible = false;
        }
    }
}
