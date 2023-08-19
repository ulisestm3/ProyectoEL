namespace UI
{
    partial class AdministracionProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textNombreProducto = new TextBox();
            textDescripcion = new TextBox();
            label2 = new Label();
            textPrecio = new TextBox();
            label3 = new Label();
            textCantidad = new TextBox();
            label4 = new Label();
            textProveedor = new TextBox();
            label5 = new Label();
            btnNuevo = new Button();
            btnAnular = new Button();
            btnGuardar = new Button();
            gridProductos = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // textNombreProducto
            // 
            textNombreProducto.Location = new Point(102, 38);
            textNombreProducto.Name = "textNombreProducto";
            textNombreProducto.Size = new Size(383, 27);
            textNombreProducto.TabIndex = 1;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(102, 82);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(383, 27);
            textDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 82);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(576, 38);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(125, 27);
            textPrecio.TabIndex = 5;
            textPrecio.KeyPress += textPrecio_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 38);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(576, 89);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(125, 27);
            textCantidad.TabIndex = 7;
            textCantidad.KeyPress += textCantidad_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 89);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
            // 
            // textProveedor
            // 
            textProveedor.Location = new Point(101, 123);
            textProveedor.Name = "textProveedor";
            textProveedor.Size = new Size(383, 27);
            textProveedor.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 123);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Proveedor";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(102, 192);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(104, 31);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(380, 192);
            btnAnular.Margin = new Padding(3, 4, 3, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(104, 31);
            btnAnular.TabIndex = 11;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(245, 192);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 31);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gridProductos
            // 
            gridProductos.AllowUserToAddRows = false;
            gridProductos.AllowUserToDeleteRows = false;
            gridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(25, 267);
            gridProductos.MultiSelect = false;
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersVisible = false;
            gridProductos.RowHeadersWidth = 51;
            gridProductos.RowTemplate.Height = 29;
            gridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProductos.Size = new Size(741, 188);
            gridProductos.TabIndex = 13;
            gridProductos.CellClick += gridProductos_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(548, 192);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 31);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // AdministracionProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(btnSalir);
            Controls.Add(gridProductos);
            Controls.Add(btnNuevo);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(textProveedor);
            Controls.Add(label5);
            Controls.Add(textCantidad);
            Controls.Add(label4);
            Controls.Add(textPrecio);
            Controls.Add(label3);
            Controls.Add(textDescripcion);
            Controls.Add(label2);
            Controls.Add(textNombreProducto);
            Controls.Add(label1);
            Name = "AdministracionProductos";
            Text = "AdministracionProductos";
            Load += AdministracionProductos_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNombreProducto;
        private TextBox textDescripcion;
        private Label label2;
        private TextBox textPrecio;
        private Label label3;
        private TextBox textCantidad;
        private Label label4;
        private TextBox textProveedor;
        private Label label5;
        private Button btnNuevo;
        private Button btnAnular;
        private Button btnGuardar;
        private DataGridView gridProductos;
        private Button btnSalir;
    }
}