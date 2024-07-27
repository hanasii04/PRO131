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
    public partial class FormQuanLy : Form
    {
        private string idNhanVien;
        public FormQuanLy(string idNhanVien)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySP qlsp = new QuanLySP(this.idNhanVien);
            qlsp.Show();
            this.Hide();
        }
    }
}
