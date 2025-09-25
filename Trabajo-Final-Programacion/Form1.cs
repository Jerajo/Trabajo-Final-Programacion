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
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=0123.;Database=postgres";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Formulario a cargando los datos de la DB...");
            GetProductos();
            Debug.WriteLine("Formulario a cargado...");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Producto producto = GetProducto();
            InsertarProducto(producto);
            dgvProducto.Rows.Add(producto.Id, producto.Name, producto.Stock, producto.Stock, producto);
            ReiniciarFormulario();
            GetProductos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto producto = GetProducto();
            ActualizarProducto(producto);
            dgvProducto.Rows.Add(producto.Id, producto.Name, producto.Stock, producto.Stock, producto);
            ReiniciarFormulario();
            GetProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto producto = GetProducto();
            if (producto.Id == 0)
            {
                Debug.WriteLine("Se intento eliminar sin seleccionar un producto...");
                return;
            }
            
            EliminarProducto(producto);
            ReiniciarFormulario();
            GetProductos();
        }

        private Producto GetProducto()
        {
            return new Producto
            {
                Id = string.IsNullOrWhiteSpace(txtID.Text) ? 0 : int.Parse(txtID.Text),
                Name = TxtNombre.Text,
                Precio = string.IsNullOrWhiteSpace(txtPrecio.Text) ? 0 : double.Parse(txtPrecio.Text),
                Stock = string.IsNullOrWhiteSpace(txtPrecio.Text) ? 0 : int.Parse(txtStock.Text),
                FechaRegistro = DateTime.Today
            };
        }

        private void ReiniciarFormulario()
        {
            txtID.Clear();
            TxtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            TxtNombre.Focus();
        }

        private async Task GetProductos()
        {
            try
            {
                await using var conn = new NpgsqlConnection(connectionString);
                await conn.OpenAsync();
                Debug.WriteLine("Conectado a la base de datos...");
                await using var cmd = new NpgsqlCommand("SELECT * FROM inventario.productos", conn);
                await using var reader = await cmd.ExecuteReaderAsync();
                dgvProducto.Rows.Clear();

                while (await reader.ReadAsync())
                {
                    Producto producto = new Producto
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Precio = reader.GetDouble(2),
                        Stock = reader.GetInt32(3),
                        FechaRegistro = reader.GetDateTime(4)
                    };
                    Debug.WriteLine("producto de la db: {0}", producto);
                    dgvProducto.Rows.Add(producto.Id, producto.Name, producto.Precio, producto.Stock,
                        producto.FechaRegistro);
                }
                Debug.WriteLine("Termino de leer la base de datos...");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: {0}", ex.Message);
            }
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

        private async Task ActualizarProducto(Producto producto)
        {
            try
            {
                await using var conn = new NpgsqlConnection(connectionString);
                await conn.OpenAsync();
                Debug.WriteLine("Conectado a la base de datos...");
                await using var cmd = new NpgsqlCommand("UPDATE inventario.productos SET nombre = @nombre, precio = @precio, stock = @stock WHERE id_producto = @id;", conn)
                {
                    Parameters =
                    {
                        new("id", producto.Id),
                        new("nombre", producto.Name),
                        new("precio", producto.Precio),
                        new("stock", producto.Stock),
                    }
                };
                await cmd.ExecuteNonQueryAsync();
                Debug.WriteLine("Producto actualizado: {0}", producto.Name);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: {0}", ex.Message);
            }
        }

        private async Task EliminarProducto(Producto producto)
        {
            try
            {
                await using var conn = new NpgsqlConnection(connectionString);
                await conn.OpenAsync();
                Debug.WriteLine("Conectado a la base de datos...");
                await using var cmd = new NpgsqlCommand("DELETE FROM inventario.productos WHERE id_producto = @id;", conn)
                {
                    Parameters =
                    {
                        new("id", producto.Id),
                    }
                };
                await cmd.ExecuteNonQueryAsync();
                Debug.WriteLine("Producto eliminado: {0}", producto.Name);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: {0}", ex.Message);
            }
        }

        private void registro_seleccionado(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.Rows.Count < 2)
                return;

            DataGridViewRow row = dgvProducto.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value?.ToString();
            TxtNombre.Text = row.Cells[1].Value?.ToString();
            txtPrecio.Text = row.Cells[2].Value?.ToString();
            txtStock.Text = row.Cells[3].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }
    }
}
