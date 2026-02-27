using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVentas
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            Mostrar();
        }

        private void CargarCategorias()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT CategoriaID, NombreCategoria FROM Categorias",
                cn.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.CerrarConexion();
        }

        private void Mostrar()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Productos",
                cn.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProductos.DataSource = dt;

            cn.CerrarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
        "INSERT INTO Productos VALUES (@id,@nombre,@desc,@precio,@stock,@cat)",
        cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
            cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
            cmd.Parameters.AddWithValue("@cat", int.Parse(txtCategoriaID.Text));

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Producto guardado.");
        }
        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

