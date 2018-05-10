using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            symRecord.Text = "";
            liveSym.Text = "";
            databaseSet.Visible = false;
            previousBtn.Visible = false;
            nextBtn.Visible = false;
            save.Visible = false;
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
            sllNumb.SelectedIndex = -1;
        }

        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü' };
        DataAccess db = new DataAccess();
        int sllIndex;
        string lastLetter;
        int sllnum;
        bool sllFlag = false;
        bool letterFlag = false;
        int current = 0;
        bool clickFlag = false;
        int symSize = 7;
        List<int> error = new List<int> { };

        private void button1_Click(object sender, EventArgs e)
        {
            current =  0;
            sllIndex = sllNumb.SelectedIndex;
            lastLetter = lastLetters.Text.Trim();
            //MessageBox.Show("begin   " + current.ToString());
            if (sllIndex > -1)
                sllFlag = true;
            if (!lastLetter.Equals(""))
                letterFlag = true;
            //MessageBox.Show(sllFlag + "  " + letterFlag);
            if(letterFlag && sllFlag)
            {
                //both  area setted
                sllnum = Convert.ToInt32(sllNumb.Items[sllIndex]);
         
                words = db.GetWords(sllnum, lastLetter,current);
                if (!words.Count.Equals(0))
                {
                    nextBtn.Visible = true;
                    previousBtn.Visible = false;
                    listBoxUpdate(words);
                    current += 20;
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
                    previousBtn.Visible = false;
                    listBoxUpdate(words);
                    current += 20;
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
                    previousBtn.Visible = false;
                    listBoxUpdate(words);
                    current += 20;
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
            nextBtn.Visible = false;
            previousBtn.Visible = false;
        }
        //ListBox Update
        public  void listBoxUpdate(List<Word> words)
        {

            results.DataSource = null;
            results.DataSource = words;
            results.DisplayMember = "fullInfo";
        }
        //Add new Words to Databasee 
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
        //Words Read and Add Button
        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\TurkishWords\words.txt", Encoding.UTF8);
            string[] lines1 = System.IO.File.ReadAllLines(@"D:\TurkishWords\words1.txt", Encoding.UTF8);


            Thread thread = new Thread(() => transferData(lines));
            thread.Start();

            Thread thread1 = new Thread(() => transferData(lines1));
            thread1.Start();

        }
        //Previous element in database 20 items 
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (!(current.Equals(0)))
            {
                if (!clickFlag)
                {
                    current -= 20;
                    clickFlag = true;
                }
                current -= 20;
                nextBtn.Visible = true;
                //MessageBox.Show("prec   "+current.ToString());
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
                if(current.Equals(0))
                    previousBtn.Visible = false;

            }
                

        }
        //Next elemeny in database 20 items 
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (!(words.Count<20))
            {
                //MessageBox.Show("next   " + current.ToString());
                if (sllIndex > -1)
                    sllFlag = true;
                if (!lastLetter.Equals(""))
                    letterFlag = true;
                if(clickFlag)
                {
                    current += 20;
                    clickFlag = false;
                }
                if (letterFlag && sllFlag)
                {
                    //both  area setted
                    words = db.GetWords(sllnum, lastLetter, current);
                    if (!words.Count.Equals(0))
                    {
                        previousBtn.Visible = true;
                        listBoxUpdate(words);
                        current += 20;
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
                        current += 20;
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
                        current += 20;
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

                if(words.Count < 20)
                    nextBtn.Visible = false;
            }
                           
        }
        //Sym Counter live While Write Poem 
        private void poemArea_TextChanged_1(object sender, EventArgs e)
        {
            error.Clear();
            string mainString = "";
            int numbSll = 0;
            int numbSllLive = 0;
            mainString = poemArea.Text;
            if (!mainString.Length.Equals(0))
            {
                save.Visible = true;
                mainString = mainString.ToLower();
                string[] words = mainString.Split('\n');

                if (mainString[mainString.Length - 1].Equals('\n'))
                {
                    if (words[words.Length - 1].Length.Equals(0)) 
                        for (int i = 0; i < words.Length-1; i++)
                        {
                            int symSizelc = words[i].Count(c => vowels.Contains(c));
                            liveSym.Text = symSizelc.ToString();
                            if (symSizelc != symSize)
                            {
                                if (!error.Contains(i + 1))
                                {
                                    error.Add(i + 1);
                                }
                            }
                        }
                    symRecord.Text = "";
                    foreach (var item in error)
                    {
                        symRecord.Text += item.ToString() + " ";
                    }
                    
                }
                int symSizelv = words[words.Length-1].Count(c => vowels.Contains(c));

                if(symSizelv < symSize)
                   liveSym.ForeColor = Color.Blue;
                else if (symSizelv == symSize)
                    liveSym.ForeColor = Color.Green;
                else
                    liveSym.ForeColor = Color.Red;
                liveSym.Text = symSizelv.ToString();
            }
            else
                save.Visible = false;
        }
        //Save Poem
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);

                string poem = poemArea.Text;
                string[] coloums = poem.Split('\n');
                foreach (var coloum in coloums)
                {
                    sw.WriteLine(coloum);
                }
                sw.Close();
            }
        }


        //Select Radio button selected 
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                //Code to use radioButton's properties to do something useful.
                if (radioButton.Checked)
                {
                    int index = radioButton.Text.LastIndexOf("'");
                    symSize = Convert.ToInt16(radioButton.Text.Substring(0, index));
                }

            }
        }
    }
}
