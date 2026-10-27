using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace PryCorderoREPASO
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato;
            int calculo;
            calculo = int.Parse(calculo );
            dato = txtMonto.Text;
            MessageBox.Show("Nombre: " + dato + " codigo: " + calculo);
        }
    }
}
