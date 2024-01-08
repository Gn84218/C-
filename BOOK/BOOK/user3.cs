using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOK
{
    public partial class user3 : Form
    {
        public user3()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            Dao dao = new Dao();
            dataGridView1.Rows.Clear();//清空數據

            string sql = $"select[no],[bid],[datatime] from t_lend where [uid] = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            string a00, a01, a02;
            while (dc.Read())
            {

                a00 = dc[0].ToString();
                a01 = dc[1].ToString();
                a02 = dc[2].ToString();
                
                string[] str = { a00, a01, a02 };
                dataGridView1.Rows.Add(str);
            }
            dc.Close();
        }   //更新
        private void button1_Click(object sender, EventArgs e)
        {
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string bid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete from t_lend where [no]='{no}';UPDATE t_book set number=number+1 where id='{bid}'";
            Dao dao = new Dao();
            if (dao.Execute(sql)>1) 
            {
                MessageBox.Show("歸還成功");
                Table();
            }
        }
    }
}
