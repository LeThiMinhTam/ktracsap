using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ShowFormLogin()
        {
            LoginForm lgs = new LoginForm();
            lgs.ShowDialog();
        }
        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Thread thread = new Thread(new ThreadStart(ShowFormLogin)); //Tạo luồng mới
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int flag = LoginForm.LuuThongTin.flag;
            if(flag == 1)
            {
                logInToolStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
            }    
            else
            {
                manageToolStripMenuItem.Enabled = false;
                searchToolStripMenuItem.Enabled = false;
                printToolStripMenuItem.Enabled = false;
                logOutToolStripMenuItem.Enabled = false;
            }    
        }
    }
}
