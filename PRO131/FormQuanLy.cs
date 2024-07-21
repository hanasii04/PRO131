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
    public partial class FormQuanLy : Form
    {
        private string tenNguoiDung;
        public FormQuanLy(string tenNguoiDung)
        {
            InitializeComponent();
            this.tenNguoiDung = tenNguoiDung;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySP qlsp = new QuanLySP(this.tenNguoiDung);
            qlsp.Show();
            this.Hide();
        }
    }
}
