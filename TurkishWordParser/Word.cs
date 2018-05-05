using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkishWordParser
{
    public  class Word
    {
        public int id { get; set; }
        public string word { get; set; }
        public int sllnumber{ get; set; }

        public string fullInfo
        {
            get
            {
                return  $"({sllnumber} Heceli)  ||  {word}";
            }
        }

    }
}
