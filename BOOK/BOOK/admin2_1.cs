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
    public partial class admin2_1 : Form
    {
        public admin2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) 
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;

                    if (textBox.Text == "")
                    {
                        MessageBox.Show("請輸入完整");

                        return;

                    }
                    else 
                    {
                        Dao dc = new Dao();
                        string sql = $"INSERT INTO t_book values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')";
                        int n = dc.Execute(sql);
                        if (n > 0)
                        {
                            MessageBox.Show("輸入成功");
                            return;
                        }
                        
                    }
                    
                    
                }
            }//選取所有窗口裡的 TextBox

            //Dao dc = new Dao();
            //string sql = $"INSERT INTO t_book values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')";
            //int n = dc.Execute(sql);
            //if (n > 0)
            //{
            //    MessageBox.Show("輸入成功");
            //}
            //else
            //{
            //    MessageBox.Show("輸入失敗");
            //}




            //foreach (Control ctr in this.Controls)
            //{
            //    if (ctr is TextBox)
            //    {
            //        ctr.Text = "";
            //    }
            //}

        }
    }
}
