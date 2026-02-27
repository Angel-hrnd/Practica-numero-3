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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Mostrar();
            CargarCategorias();
        }
        private void Mostrar()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Categorias",
                cn.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCategorias.DataSource = dt;

            cn.CerrarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe escribir un nombre.");
                return;
            }

          
            Conexion conexion = new Conexion();
           
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Categorias (NombreCategoria) VALUES (@nombre)",
                    cn.AbrirConexion());

                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Categoría guardada correctamente.");
            Limpiar();
            CargarCategorias();
        }

        private void Limpiar()
        {
            throw new NotImplementedException();
        }

        private void CargarCategorias()
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Categorias",
                con.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCategorias.DataSource = dt;

            con.CerrarConexion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
                return;

            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Categorias SET NombreCategoria=@nombre WHERE CategoriaID=@id",
                con.AbrirConexion());

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

            cmd.ExecuteNonQuery();
            con.CerrarConexion();

            MessageBox.Show("Categoría actualizada.");
            CargarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
                return;

            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Categorias WHERE CategoriaID=@id",
                con.AbrirConexion());

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.CerrarConexion();

            MessageBox.Show("Categoría eliminada.");
            CargarCategorias();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

