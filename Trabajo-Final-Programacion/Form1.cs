using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Trabajo_Final_Programacion
{
    public partial class Form1 : Form
    {
        string connectionString = "Host=localhost:5432;Username=postgres;Password=1234.;Database=Invetario";
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }
      
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Producto producto = GetProducto();
            InsertarProducto(producto);
            dgvProducto.Rows.Add(producto.Id, producto.Name, producto.Stock, producto.Stock, producto);
            ReiniciarFormulario();
        }

        private Producto GetProducto()
        {
            return new Producto
            {
                Name = TxtNombre.Text,
                Precio = double.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                FechaRegistro = DateTime.Today
            };
        }

        private void ReiniciarFormulario()
        {
            TxtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            TxtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvProducto.Rows.RemoveAt(dgvProducto.CurrentRow.Index);
        }

        private async Task InsertarProducto(Producto producto)
        {
            try
            {
                await using var conn = new NpgsqlConnection(connectionString);
                await conn.OpenAsync();
                Debug.WriteLine("Conectado a la base de datos...");
                await using var cmd = new NpgsqlCommand("INSERT INTO inventario.productos(nombre, precio, stock, fecha_registro) VALUES (@nombre, @precio, @stock, @fecha_registro);", conn)
                {
                    Parameters =
                    {
                        new("nombre", producto.Name),
                        new("precio", producto.Precio),
                        new("stock", producto.Stock),
                        new("fecha_registro", producto.FechaRegistro),
                    }
                };
                await cmd.ExecuteNonQueryAsync();
                Debug.WriteLine("Producto insertado: {0}", producto.Name);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
