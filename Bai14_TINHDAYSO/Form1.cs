using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14_TINHDAYSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int batdau = Int32.Parse(txtBatdau.Text); 
            int ketthuc= Int32.Parse(txtKetthuc.Text);
            long tong = 0, tongchan = 0, tongle = 0;
            if (batdau > ketthuc) 
            {
                MessageBox.Show("Nhập lại số từ nhỏ đến lớn dùm cảm ơn");
            }

            for (int i = batdau; i <= ketthuc; i++)
              
            {
                tong += i;
                if (i%2== 0) 
                {
                    tongchan += i;
                }
                else
                {
                    tongle += i; 
                }
            }
            // xuất kết quả
            txtTong.Text= tong.ToString();
            txtTongchan.Text= tongchan.ToString();
            txtTongle.Text= tongle.ToString();  
        }
    }
}
