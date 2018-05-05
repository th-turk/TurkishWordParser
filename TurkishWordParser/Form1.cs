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

        private void button1_Click(object sender, EventArgs e)
        {
            bool sllFlag = false;
            bool letterFlag = false;

            int sllIndex = sllNumb.SelectedIndex;
            string lastLetter = lastLetters.Text.Trim();

            DataAccess db = new DataAccess();

            if (sllIndex > -1)
                sllFlag = true;
            if (!lastLetter.Equals(""))
                letterFlag = true;

            if(letterFlag && sllFlag)
            {
                //both  area setted
                
                int sllnum = Convert.ToInt32(sllNumb.Items[sllIndex]);
         
                words = db.GetWords(sllnum, lastLetter,prev);
                listBoxUpdate(words);

            }
            else if (letterFlag && !sllFlag )
            {
                //sll  is empty
                words = db.GetWords(lastLetter);
                listBoxUpdate(words);
            }
            else if (!letterFlag && sllFlag)
            {
                //letter  is empty
                int sllnum = Convert.ToInt32(sllNumb.Items[sllIndex]);
                words = db.GetWords(sllnum);
                listBoxUpdate(words);
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

        int prev = 0;
        private void previousBtn_Click(object sender, EventArgs e)
        {
            prev+=10;

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
