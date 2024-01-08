using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOK
{
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
            
        }

        private void admin2_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//獲取輸號
        }
        public void Table() 
        {
            Dao dao = new Dao();
            dataGridView1.Rows.Clear();//清空數據
           
            string sql ="select *from t_book";
            IDataReader dc =dao.read(sql);
            string a00, a01, a02, a03, a04;
            while (dc.Read())
            {
                
                a00 = dc[0].ToString();
                a01 = dc[1].ToString();
                a02 = dc[2].ToString();
                a03 = dc[3].ToString();
                a04 = dc[4].ToString();
                string [] str = { a00, a01, a02, a03, a04 };
                dataGridView1.Rows.Add(str);
            }           
            dc.Close();           
        }   //更新

        public void TableID() 
        {
            Dao dao = new Dao();
            dataGridView1.Rows.Clear();//清空數據

            string sql = $"select *from t_book where id='{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            string a00, a01, a02, a03, a04;
            while (dc.Read())
            {

                a00 = dc[0].ToString();
                a01 = dc[1].ToString();
                a02 = dc[2].ToString();
                a03 = dc[3].ToString();
                a04 = dc[4].ToString();
                string[] str = { a00, a01, a02, a03, a04 };
                dataGridView1.Rows.Add(str);
            }
            dc.Close();
        }  //ID查詢

        public void TableName() 
        {
            Dao dao = new Dao();
            dataGridView1.Rows.Clear();//清空數據

            string sql = $"select *from t_book where [name] like'%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            string a00, a01, a02, a03, a04;
            while (dc.Read())
            {

                a00 = dc[0].ToString();
                a01 = dc[1].ToString();
                a02 = dc[2].ToString();
                a03 = dc[3].ToString();
                a04 = dc[4].ToString();
                string[] str = { a00, a01, a02, a03, a04 };
                dataGridView1.Rows.Add(str);
            }
            dc.Close();
        }  //書名查詢

        private void button1_Click(object sender, EventArgs e)
        {
            admin2_1 admin2_1 = new admin2_1();
            admin2_1.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        } //刷新

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//獲取輸號
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr= MessageBox.Show("確認刪除?","訊息提示!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if (dr == DialogResult.OK) 
                {
                    string sql = $"delete from t_book where id='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("刪除成功");
                        Table();
                    }
                    else 
                    {
                        MessageBox.Show("刪除失敗");                        
                    }
                    //dao.DaoClose();//
                }
            }
            catch 
            {
                MessageBox.Show("請先在表格中選擇刪除目標","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//獲取輸號
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                string id= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                admin2_2 admin2_2 = new admin2_2(id,name,author,press,number);
                admin2_2.ShowDialog();
                Table();
            }
            catch 
            {
                MessageBox.Show("錯誤");
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableID();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableName();
        }

       
    }
}
