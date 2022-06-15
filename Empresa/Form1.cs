using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total_pedido = 0;
        double total_despesa = 0;
        double total_saldo = 0;
        
        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int pedido = int.Parse(txtPedido.Text);
            string cliente = txtCliente.Text;
            double valor_pedido = double.Parse(txtValorPedido.Text);

            ListViewItem pedidos = new ListViewItem(txtCliente.Text);
            pedidos.SubItems.Add(txtPedido.Text);
            pedidos.SubItems.Add(txtValorPedido.Text);
            listPedidos.Items.Add(pedidos);

            total_pedido += pedido * valor_pedido;

            lblPedidos.Text = total_pedido.ToString("C");
        }


        private void btnDespesa_Click(object sender, EventArgs e)
        {
            string despesa = txtDespesa.Text;
            double valor_despesa = double.Parse(txtValorDespesa.Text);

            ListViewItem despesas = new ListViewItem(txtDespesa.Text);
            despesas.SubItems.Add(txtValorDespesa.Text);
            listDespesas.Items.Add(despesas);

            total_despesa += valor_despesa;

            lblDespesas.Text = total_despesa.ToString("C");


        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            total_saldo = total_pedido - total_despesa;

            lblSaldo.Text = total_saldo.ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPedido.Clear();
            txtCliente.Clear();
            txtValorPedido.Clear();
            txtDespesa.Clear();
            txtValorDespesa.Clear();


            txtPedido.Focus();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
