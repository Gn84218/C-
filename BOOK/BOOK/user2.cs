using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOK
{
    public partial class user2 : Form
    {
        public user2()
        {
            InitializeComponent();
        }

        private void user2_Load(object sender, EventArgs e)
        {
            Table();
        }
        public void Table()
        {
            Dao dao = new Dao();
            dataGridView1.Rows.Clear();//清空數據

            string sql = "select *from t_book";
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
        }   //更新

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()); //庫存
            if (number < 1)
            {
                MessageBox.Show("庫存不足 請聯繫管理員");
            }
            else
            {
                string sql = $"insert into t_lend([uid], [bid], [datatime]) values('{Data.UID}','{id}', getdate()); update t_book set number = number - 1 where id= '{id}'";    
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)  //sql有2條指令
                {
                    MessageBox.Show("借出成功");
                    Table();
                }
            }
        }
    }
}
