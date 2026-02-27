using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias f = new FrmCategorias();
            f.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos f = new FrmProductos();
            f.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes f = new FrmClientes();
            f.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores f = new FrmProveedores();
            f.ShowDialog();
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            {
                FrmProveedores frm = new FrmProveedores();
                frm.Show();
            }
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            {
                FrmClientes frm = new FrmClientes();
                frm.Show();
            }
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            {
                FrmProductos frm = new FrmProductos();
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

