using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOK
{
    public partial class Long : Form
    {
        public Long()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_user_id.Text != "" && tb_user_pws.Text != "")
            {
                login();
            }
            else 
            {
                MessageBox.Show("請輸入帳號或密碼");
            }
        }
        public void login() 
        {
            if (radioButtonUser.Checked == true)//會員
            {
                Dao dao = new Dao();
                string sql = $"select * from t_user where id = {tb_user_id.Text} and psw={tb_user_pws.Text}";
                
                IDataReader dc=dao.read(sql);
                //dc.Read();//
                // MessageBox.Show("HI~"+dc[1].ToString()+ dc["name"].ToString() , "測試!!") ;
                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.IDName = dc["name"].ToString();
                    MessageBox.Show("登入成功");
                    user1 user1 = new user1();
                    this.Hide();
                    user1.ShowDialog();
                    this.Show();
                }
                else 
                {
                    MessageBox.Show("登入失敗");
                    
                }
                // dao.DaoClose(); //關閉窗體
                if (admin1.IsOpen == true)
                {
                    this.Enabled = false;
                } //禁用窗體
                else
                {
                    this.Enabled = true;
                } //禁用窗體
            }
            if (radioButtonAdmin.Checked == true)//管理員
            {
                Dao dao = new Dao();
                string sql = $"select * from t_admin where id = '{tb_user_id.Text}' and psw={tb_user_pws.Text}";

                IDataReader dc = dao.read(sql);
                //dc.Read();//
                // MessageBox.Show("HI~"+dc[1].ToString()+ dc["name"].ToString() , "測試!!") ;
                if (dc.Read())
                {
                    MessageBox.Show("登入成功");
                    admin1 admin1= new admin1();
                    this.Hide();
                    admin1.ShowDialog();
                    this.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("登入失敗");
                    
                }

                // dao.DaoClose(); //關閉窗體
               
                if (admin1.IsOpen == true)
                {
                    this.Enabled = false;
                } //禁用窗體
                else 
                {
                    this.Enabled = true;
                }
                
            }
           
        }
    }
}
