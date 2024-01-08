using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BOOK
{
     class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string strsever = "server=.;database=BOOKMS;uid=sa;pwd=wqaz852456";
            SqlConnection sc=new SqlConnection(strsever);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql) 
        { 
        SqlCommand cmd = new SqlCommand(sql,connect());
            return cmd;
        }
        public int Execute(string sql) //更新
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql) //讀取操作
        { 
            return command(sql).ExecuteReader();
        }
        public void DaoClose() 
        {          
            sc.Close();
        }
    }
}
