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
        public List<Word> GetWords (int numbSll, string lastLetters,int prev)
        {
                using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
                {
                    return conn.Query<Word>($"SELECT id ,word ,sllnumber " +
                                            $"FROM (SELECT ROW_NUMBER() OVER (ORDER BY word) AS MyRowNumber, *" +
                                            $"FROM [TurkishWords].[dbo].[Words]) tbl " +
                                            $"WHERE word LIKE '%{lastLetters}' " +
                                            $"and sllnumber = {numbSll} " +
                                            $"and MyRowNumber BETWEEN {prev} AND {prev+10}" +
                                            $"ORDER BY sllnumber ASC,word ASC  ").ToList();
                }
        }

        //getWords
        public List<Word> GetWords(string lastLetters)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
            {
                return conn.Query<Word>($"Select * " +
                                        $"FROM [TurkishWords].[dbo].[Words] " +
                                        $"WHERE word LIKE '%{lastLetters}' " +
                                        $"ORDER BY sllnumber ASC,word ASC ").ToList();
            }
        }

        //getWords
        public List<Word> GetWords(int numbSll)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WORDSDB")))
            {
                return conn.Query<Word>($"Select * " +
                                        $"FROM [TurkishWords].[dbo].[Words] " +
                                        $"WHERE sllnumber = {numbSll} " +
                                        $"ORDER BY sllnumber ASC,word ASC").ToList();
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
