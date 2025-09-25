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
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin.;Database=bdinventario";
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
        ///actualisar a la base de datos 

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=bdinventario";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.IsNewRow) continue;

                    string nombre = row.Cells[1].Value?.ToString() ?? "";
                    decimal precio = Convert.ToDecimal(row.Cells[2].Value ?? 0);
                    int stock = Convert.ToInt32(row.Cells[3].Value ?? 0);

                    // UPDATE por nombre
                    string queryUpdate = @"
            UPDATE inventario.productos
            SET precio = @precio, stock = @stock
            WHERE nombre = @nombre";

                    using (var cmd = new NpgsqlCommand(queryUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("precio", precio);
                        cmd.Parameters.AddWithValue("stock", stock);
                        cmd.Parameters.AddWithValue("nombre", nombre);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Si no existe el nombre, puedes insertar
                        if (filasAfectadas == 0)
                        {
                            string queryInsert = @"
                    INSERT INTO inventario.productos (nombre, precio, stock)
                    VALUES (@nombre, @precio, @stock)";

                            using (var cmdInsert = new NpgsqlCommand(queryInsert, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("nombre", nombre);
                                cmdInsert.Parameters.AddWithValue("precio", precio);
                                cmdInsert.Parameters.AddWithValue("stock", stock);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Datos actualizados correctamente en PostgreSQL (por nombre)");
            }
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ///agregar a la base de datos 
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=bdinventario";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.IsNewRow) continue;

                    object idValue = row.Cells[0].Value;
                    string nombre = row.Cells[1].Value?.ToString() ?? "";
                    decimal precio = Convert.ToDecimal(row.Cells[2].Value ?? 0);
                    int stock = Convert.ToInt32(row.Cells[3].Value ?? 0);

                    // Si existe ID válido -> UPDATE
                    if (idValue != null && idValue != DBNull.Value && Convert.ToInt32(idValue) > 0)
                    {
                        int idProd = Convert.ToInt32(idValue);

                        string queryUpdate = @"
                        UPDATE inventario.productos
                        SET nombre = @nombre, precio = @precio, stock = @stock
                        WHERE id_producto = @id";

                        using (var cmd = new NpgsqlCommand(queryUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("nombre", nombre);
                            cmd.Parameters.AddWithValue("precio", precio);
                            cmd.Parameters.AddWithValue("stock", stock);
                            cmd.Parameters.AddWithValue("id", idProd);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else // Si no hay ID válido -> INSERT
                    {
                        string queryInsert = @"
                    INSERT INTO inventario.productos (nombre, precio, stock)
                    VALUES (@nombre, @precio, @stock)
                    RETURNING id_producto";

                        using (var cmd = new NpgsqlCommand(queryInsert, conn))
                        {
                            cmd.Parameters.AddWithValue("nombre", nombre);
                            cmd.Parameters.AddWithValue("precio", precio);
                            cmd.Parameters.AddWithValue("stock", stock);

                            int newId = (int)cmd.ExecuteScalar();
                            row.Cells[0].Value = newId; // Asigna el ID al DataGridView
                        }
                    }
                }

                MessageBox.Show("Datos guardados correctamente en PostgreSQL");
            }
        }

        
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
