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
        }
    }
}
