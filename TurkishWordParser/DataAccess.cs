using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace TurkishWordParser
{
    class DataAccess
    {
        //getWords
        public List<Word> GetWords (int numbSll, string lastLetters,int current)
        {
                using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
                {
                    return conn.Query<Word>($"  SELECT id ,word ,sllnumber " +
                                            $"  FROM (SELECT ROW_NUMBER() OVER (ORDER BY sllnumber ASC,word Asc) AS MyRowNumber, *" +
                                            $"  FROM [TurkishWords].[dbo].[Words] " +
                                            $"  WHERE word LIKE '%{lastLetters}' " +
                                            $"  and sllnumber = {numbSll}) tbl" +
                                            $"  WHERE MyRowNumber BETWEEN {current} AND {current + 20}").ToList();
                }
        }
        
        //getWords
        public List<Word> GetWords(string lastLetters,int current)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
            {
                return conn.Query<Word>($"  SELECT id ,word ,sllnumber FROM" +
                                        $"  (SELECT ROW_NUMBER() OVER(ORDER BY sllnumber ASC, word Asc) AS MyRowNumber, *" +
                                        $"  FROM[TurkishWords].[dbo].[Words]" +
                                        $"  Where word Like '%{lastLetters}') tbl" +
                                        $"  WHERE MyRowNumber BETWEEN {current} AND {current+20} ").ToList();
            }
        }

        //getWords
        public List<Word> GetWords(int numbSll,int current)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
            {
                return conn.Query<Word>($"  SELECT id ,word ,sllnumber " +
                                        $"  FROM (SELECT ROW_NUMBER() OVER (ORDER BY sllnumber ASC,word ASC) AS MyRowNumber, *" +
                                        $"  FROM [TurkishWords].[dbo].[Words] " +
                                        $"  WHERE sllnumber = {numbSll} ) tbl" +
                                        $"  WHERE MyRowNumber BETWEEN {current} AND {current + 20}").ToList();
            }
        }

        //Insert Words 
        public void InsertWord(Word word)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
            {
                conn.Query($"INSERT INTO Words VALUES ('" + word.word + "'," +
                                                                               "'" + word.sllnumber + "')");
            }
        }
    }
}
