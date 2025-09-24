namespace Trabajo_Final_Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            txtID = new System.Windows.Forms.TextBox();
            TxtNombre = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();
            dgvProducto = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblId.Location = new System.Drawing.Point(55, 30);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(22, 18);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            lblId.UseWaitCursor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblNombre.Location = new System.Drawing.Point(35, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(62, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.UseWaitCursor = true;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPrecio.Location = new System.Drawing.Point(37, 102);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(51, 18);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            lblPrecio.UseWaitCursor = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblStock.Location = new System.Drawing.Point(42, 136);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(47, 18);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            lblStock.UseWaitCursor = true;
            // 
            // btnCrear
            // 
            btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnCrear.Location = new System.Drawing.Point(274, 44);
            btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(90, 34);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.UseWaitCursor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnActualizar.Location = new System.Drawing.Point(274, 132);
            btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(90, 34);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.UseWaitCursor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEliminar.Location = new System.Drawing.Point(274, 85);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(90, 34);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.UseWaitCursor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtID
            // 
            txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtID.Location = new System.Drawing.Point(106, 28);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtID.Size = new System.Drawing.Size(100, 24);
            txtID.TabIndex = 8;
            txtID.UseWaitCursor = true;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            TxtNombre.Location = new System.Drawing.Point(106, 62);
            TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(100, 24);
            TxtNombre.TabIndex = 9;
            TxtNombre.UseWaitCursor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtPrecio.Location = new System.Drawing.Point(106, 98);
            txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(100, 24);
            txtPrecio.TabIndex = 10;
            txtPrecio.UseWaitCursor = true;
            // 
            // txtStock
            // 
            txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtStock.Location = new System.Drawing.Point(106, 132);
            txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(100, 24);
            txtStock.TabIndex = 11;
            txtStock.UseWaitCursor = true;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvProducto.Location = new System.Drawing.Point(40, 222);
            dgvProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 24;
            dgvProducto.Size = new System.Drawing.Size(896, 244);
            dgvProducto.TabIndex = 12;
            dgvProducto.UseWaitCursor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "id_producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stock";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha_registro";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.GhostWhite;
            ClientSize = new System.Drawing.Size(963, 630);
            Controls.Add(dgvProducto);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(TxtNombre);
            Controls.Add(txtID);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

