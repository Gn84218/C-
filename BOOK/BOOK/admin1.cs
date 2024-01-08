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
    public partial class admin1 : Form
    {
        public admin1()
        {
            InitializeComponent();

        }

        private void 圖書館裡ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            admin2 admin2 = new admin2();
            admin2.ShowDialog();


        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }
        public static bool IsOpen = false;
        private void FormB_Load(object sender, EventArgs e)
        {
            IsOpen = true;
        }

        // 在 FormB 關閉時設置變數為 false
        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsOpen = false;
        }
    }
}
