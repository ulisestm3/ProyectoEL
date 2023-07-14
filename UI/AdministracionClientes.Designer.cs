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
            lblNombreCliente.Location = new Point(15, 9);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(110, 15);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // textNombreCliente
            // 
            textNombreCliente.Location = new Point(19, 24);
            textNombreCliente.Name = "textNombreCliente";
            textNombreCliente.Size = new Size(388, 23);
            textNombreCliente.TabIndex = 2;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(19, 75);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(388, 23);
            textNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(15, 60);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(19, 126);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(388, 23);
            textCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(15, 111);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(116, 178);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(209, 178);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(91, 23);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(19, 178);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(91, 23);
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
            gripClientes.Location = new Point(19, 252);
            gripClientes.MultiSelect = false;
            gripClientes.Name = "gripClientes";
            gripClientes.RowHeadersVisible = false;
            gripClientes.RowHeadersWidth = 51;
            gripClientes.RowTemplate.Height = 25;
            gripClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gripClientes.Size = new Size(388, 150);
            gripClientes.TabIndex = 10;
            gripClientes.CellClick += gripClientes_CellClick;
            // 
            // lblgripclientes
            // 
            lblgripclientes.AutoSize = true;
            lblgripclientes.Location = new Point(19, 234);
            lblgripclientes.Name = "lblgripclientes";
            lblgripclientes.Size = new Size(106, 15);
            lblgripclientes.TabIndex = 11;
            lblgripclientes.Text = "Listado de Clientes";
            // 
            // lbl_IdRegistro
            // 
            lbl_IdRegistro.AutoSize = true;
            lbl_IdRegistro.Location = new Point(366, 9);
            lbl_IdRegistro.Name = "lbl_IdRegistro";
            lbl_IdRegistro.Size = new Size(41, 15);
            lbl_IdRegistro.TabIndex = 12;
            lbl_IdRegistro.Text = "Label1";
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 425);
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