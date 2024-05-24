using System;
using System.Windows.Forms;

namespace UocSoBoiSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhapSoA_Click(object sender, EventArgs e)
        {

        }

        private void NhapSoB_Click(object sender, EventArgs e)
        {

        }

        private void USCLonNhat_Click(object sender, EventArgs e)
        {

        }

        private void BSCNhoNhat_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNhapSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultUSCLonNhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultBSCNhoNhat_TextChanged(object sender, EventArgs e)
        {

        }
        private int a, b;

        float uocChungLonNhat(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        float boiChungNhoNhat(int a, int b)
        {
            float result =  uocChungLonNhat((int)a, (int)b);
            return a * b / result;
        }
      
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtNhapSoA.Text);
            b = Convert.ToInt32(txtNhapSoB.Text);
            
            float BCNN = boiChungNhoNhat((int)a, (int)b);
            float UCLN = uocChungLonNhat((int)a, (int)b);

            ResultUSCLonNhat.Text = UCLN.ToString();

            ResultBSCNhoNhat.Text = BCNN.ToString();
        }

       
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNhapSoA.ResetText();
            txtNhapSoB.ResetText();
            ResultBSCNhoNhat.ResetText();
            ResultUSCLonNhat.ResetText();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

       
    }
}
