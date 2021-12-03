using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public class LuuThongTin
        {
           static public int flag;
        }
        private void ShowForm1()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            int value = KtraUser.Ktra(user, pass);
            if (value == 1)
            {
                LuuThongTin.flag = value;
                Thread thread = new Thread(new ThreadStart(ShowForm1)); //Tạo luồng mới
                thread.Start(); //Khởi chạy luồng
                this.Close(); //đóng Form hiện tại. (Form1)
            }    
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }    
        }
    }
}
