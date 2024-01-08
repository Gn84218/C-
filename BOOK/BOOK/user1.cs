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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void 查看借閱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 user2 = new user2();
            user2.ShowDialog(); 

        }

        private void 借出與歸還ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 user3 = new user3();
            user3.ShowDialog();
        }
    }
}
