namespace UI
{
    partial class AdministracionClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreCliente = new Label();
            textNombreCliente = new TextBox();
            textNumero = new TextBox();
            lblNumero = new Label();
            textCorreo = new TextBox();
            lblCorreo = new Label();
            btnGuardar = new Button();
            btnAnular = new Button();
            btnNuevo = new Button();
            gripClientes = new DataGridView();
            lblgripclientes = new Label();
            lbl_IdRegistro = new Label();
            ((System.ComponentModel.ISupportInitialize)gripClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(17, 12);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(139, 20);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // textNombreCliente
            // 
            textNombreCliente.Location = new Point(22, 32);
            textNombreCliente.Margin = new Padding(3, 4, 3, 4);
            textNombreCliente.MaxLength = 200;
            textNombreCliente.Name = "textNombreCliente";
            textNombreCliente.Size = new Size(443, 27);
            textNombreCliente.TabIndex = 2;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(22, 100);
            textNumero.Margin = new Padding(3, 4, 3, 4);
            textNumero.MaxLength = 8;
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(443, 27);
            textNumero.TabIndex = 4;
            textNumero.KeyPress += textNumero_KeyPress;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(17, 80);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(22, 168);
            textCorreo.Margin = new Padding(3, 4, 3, 4);
            textCorreo.MaxLength = 200;
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(443, 27);
            textCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(17, 148);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(133, 237);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(239, 237);
            btnAnular.Margin = new Padding(3, 4, 3, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(104, 31);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(22, 237);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(104, 31);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gripClientes
            // 
            gripClientes.AllowUserToAddRows = false;
            gripClientes.AllowUserToDeleteRows = false;
            gripClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gripClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gripClientes.Location = new Point(22, 336);
            gripClientes.Margin = new Padding(3, 4, 3, 4);
            gripClientes.MultiSelect = false;
            gripClientes.Name = "gripClientes";
            gripClientes.RowHeadersVisible = false;
            gripClientes.RowHeadersWidth = 51;
            gripClientes.RowTemplate.Height = 25;
            gripClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gripClientes.Size = new Size(479, 200);
            gripClientes.TabIndex = 10;
            gripClientes.CellClick += gripClientes_CellClick;
            // 
            // lblgripclientes
            // 
            lblgripclientes.AutoSize = true;
            lblgripclientes.Location = new Point(22, 312);
            lblgripclientes.Name = "lblgripclientes";
            lblgripclientes.Size = new Size(134, 20);
            lblgripclientes.TabIndex = 11;
            lblgripclientes.Text = "Listado de Clientes";
            // 
            // lbl_IdRegistro
            // 
            lbl_IdRegistro.AutoSize = true;
            lbl_IdRegistro.Location = new Point(418, 12);
            lbl_IdRegistro.Name = "lbl_IdRegistro";
            lbl_IdRegistro.Size = new Size(53, 20);
            lbl_IdRegistro.TabIndex = 12;
            lbl_IdRegistro.Text = "Label1";
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 567);
            Controls.Add(lbl_IdRegistro);
            Controls.Add(lblgripclientes);
            Controls.Add(gripClientes);
            Controls.Add(btnNuevo);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(textCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(textNumero);
            Controls.Add(lblNumero);
            Controls.Add(textNombreCliente);
            Controls.Add(lblNombreCliente);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdministracionClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de Clientes";
            Load += AdministracionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)gripClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreCliente;
        private TextBox textNombreCliente;
        private TextBox textNumero;
        private Label lblNumero;
        private TextBox textCorreo;
        private Label lblCorreo;
        private Button btnGuardar;
        private Button btnAnular;
        private Button btnNuevo;
        private DataGridView gripClientes;
        private Label lblgripclientes;
        private Label lbl_IdRegistro;
    }
}