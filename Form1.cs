using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3
{
    public partial class E3 : Form
    {
        public E3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbxMemo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxJuan.Clear();
            tbxLuis.Clear();
            tbxMemo.Clear();
            tbxTotal.Clear();
            tbxMemo.Focus();
        }

        private void tbxLuis_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void tbxJuan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double G = Convert.ToDouble(tbxMemo.Text);
            double L = G / 2;
            double J = (G + L) / 2;

            tbxLuis.Text = L.ToString();
            tbxJuan.Text = J.ToString();
            tbxTotal.Text = (G + L + J).ToString();
            tbxTotal.Focus();
        }
    }
}
