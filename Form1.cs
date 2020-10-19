using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIspis.Text = cmbIzbor.SelectedItem.ToString();
        }

        private void TxtIspis_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPoruka_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbIzbor.SelectedItem.ToString(), "Gae");
        }

        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
        }
    }
}
