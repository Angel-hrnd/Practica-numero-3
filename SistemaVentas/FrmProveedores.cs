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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Proveedores",
                cn.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProveedores.DataSource = dt;

            cn.CerrarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Proveedores VALUES (@Id,@Nombre,@Telefono,@Correo)",
                cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Proveedor guardado ✔");
            Mostrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Proveedores SET NombreProveedor=@Nombre, Telefono=@Telefono, CorreoElectronico=@Correo WHERE ProveedorID=@Id",
                cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Proveedor actualizado ✔");
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Proveedores WHERE ProveedorID=@Id",
                cn.AbrirConexion());

            cmd.Parameters.AddWithValue("@Id", txtID.Text);

            cmd.ExecuteNonQuery();
            cn.CerrarConexion();

            MessageBox.Show("Proveedor eliminado ✔");
            Mostrar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

