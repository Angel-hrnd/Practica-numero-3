using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVentas
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Clientes",
                cn.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClientes.DataSource = dt;

            cn.CerrarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Clientes VALUES (@Id,@Nombre,@Correo,@Telefono,@Direccion)",
                cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Cliente guardado ✔");
            Mostrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Clientes SET NombreCompleto=@Nombre, CorreoElectronico=@Correo, Telefono=@Telefono, Direccion=@Direccion WHERE ClienteID=@Id",
                cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Cliente actualizado ✔");
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Clientes WHERE ClienteID=@Id",
                cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@Id", txtID.Text);

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Cliente eliminado ✔");
            Mostrar();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

