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
            lblId = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            txtID = new TextBox();
            TxtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            dgvProducto = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(55, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 18);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            lblId.UseWaitCursor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(35, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 18);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.UseWaitCursor = true;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(37, 102);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(51, 18);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            lblPrecio.UseWaitCursor = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(42, 136);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 18);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            lblStock.UseWaitCursor = true;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(274, 28);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(90, 34);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.UseWaitCursor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(274, 144);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 34);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.UseWaitCursor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(274, 86);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 34);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.UseWaitCursor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(106, 28);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.RightToLeft = RightToLeft.No;
            txtID.Size = new Size(100, 24);
            txtID.TabIndex = 8;
            txtID.UseWaitCursor = true;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(106, 62);
            TxtNombre.Margin = new Padding(3, 4, 3, 4);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 24);
            TxtNombre.TabIndex = 9;
            TxtNombre.UseWaitCursor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(106, 98);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 24);
            txtPrecio.TabIndex = 10;
            txtPrecio.UseWaitCursor = true;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(106, 132);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 24);
            txtStock.TabIndex = 11;
            txtStock.UseWaitCursor = true;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvProducto.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProducto.Location = new Point(40, 222);
            dgvProducto.Margin = new Padding(3, 4, 3, 4);
            dgvProducto.MultiSelect = false;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 24;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(896, 244);
            dgvProducto.TabIndex = 12;
            dgvProducto.TabStop = false;
            dgvProducto.UseWaitCursor = true;
            dgvProducto.RowEnter += registro_seleccionado;
            // 
            // Column1
            // 
            Column1.HeaderText = "id_producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "precio";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "stock";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "fecha_registro";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(400, 86);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 13;
            button1.Text = "Limpiar Formulario";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(963, 630);
            Controls.Add(button1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
    }
}

