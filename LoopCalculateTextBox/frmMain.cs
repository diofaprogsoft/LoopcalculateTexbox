using System;
using System.Windows.Forms;

namespace LoopCalculateTextBox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tm.Text = diofaprogsoft.Info.TradeMark;
            txtRoll.Text = "0";
            txtKg.Text = "0";
        }

        #region Method
        private void CalCount()
        {
            int x = 0;
            foreach (TextBox txtbox in groupBox1.Controls)
            {
                if (txtbox.Text != string.Empty)
                {
                    x += 1;
                }
            }
            txtRoll.Text = x.ToString();
        }

        private void CalTotal()
        {
            double x = 0;
            foreach (TextBox txtbox in groupBox1.Controls)
            {
                if (txtbox.Text != string.Empty)
                {
                    double y = Convert.ToDouble(txtbox.Text);
                    x += y;
                }
            }
            txtKg.Text = x.ToString();
        }
        #endregion

        #region Events
        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalCount();
                CalTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtbox in groupBox1.Controls)
            {
                txtbox.Text = string.Empty;
            }
        }
        #endregion
    }
}