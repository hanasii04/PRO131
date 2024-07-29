using PRO131.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131
{
    public partial class QuanLyHD : Form
    {
        public QuanLyHD()
        {
            InitializeComponent();
        }
        
        DuAn da = new DuAn();
        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            string trangThai = "";
            if(radioTC.Checked == true)
            {
                trangThai = "Thành công";
            }
            if (radioTB.Checked)
            {
                trangThai = "Thất bại";
            }
        }
    }
}
