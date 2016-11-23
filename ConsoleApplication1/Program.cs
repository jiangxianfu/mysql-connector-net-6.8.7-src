using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           string result= MySqlHelper.EscapeString("ab'c'\"d'efh\\gh\"ijk'");
           MySqlConnection conn = new MySqlConnection("server=server;port=55944;database=dbtest;uid;");
           conn.Open();
           MySqlCommand cmd = conn.CreateCommand();
           cmd.CommandType = System.Data.CommandType.Text;
           cmd.CommandText = "insert into tb_c2(connid) values('"+result+"')";
           cmd.ExecuteNonQuery();
        }
    }
}
