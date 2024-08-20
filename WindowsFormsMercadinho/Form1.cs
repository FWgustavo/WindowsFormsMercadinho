using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMercadinho
{
    public partial class Form1 : Form
    {
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQtde.Text);
            double valor = int.Parse(txtValor.Text);

            ListBox lista = lstProdutos;
            lista.Items.Add(produto + "/" + quantidade + "/" + valor);

            total += quantidade * valor;

            lblTotal.Text = total.ToString("C");

            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();

            txtProduto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();

            lstProdutos.Items.Clear();

            lblTotal.Text = "R$ 00,00";

            txtProduto.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
