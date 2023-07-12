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
            textCelular = new TextBox();
            lblCelular = new Label();
            textCorreo = new TextBox();
            lblCorreo = new Label();
            btnGuardar = new Button();
            btnAnular = new Button();
            btnReset = new Button();
            gripClientes = new DataGridView();
            lblgripclientes = new Label();
            ((System.ComponentModel.ISupportInitialize)gripClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(31, 12);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(139, 20);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // textNombreCliente
            // 
            textNombreCliente.Location = new Point(35, 32);
            textNombreCliente.Margin = new Padding(3, 4, 3, 4);
            textNombreCliente.Name = "textNombreCliente";
            textNombreCliente.Size = new Size(302, 27);
            textNombreCliente.TabIndex = 2;
            // 
            // textCelular
            // 
            textCelular.Location = new Point(35, 100);
            textCelular.Margin = new Padding(3, 4, 3, 4);
            textCelular.Name = "textCelular";
            textCelular.Size = new Size(302, 27);
            textCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(31, 80);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(55, 20);
            lblCelular.TabIndex = 3;
            lblCelular.Text = "Celular";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(35, 168);
            textCorreo.Margin = new Padding(3, 4, 3, 4);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(302, 27);
            textCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(31, 148);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(35, 237);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(150, 237);
            btnAnular.Margin = new Padding(3, 4, 3, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(86, 31);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(253, 237);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // gripClientes
            // 
            gripClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gripClientes.Location = new Point(35, 336);
            gripClientes.Margin = new Padding(3, 4, 3, 4);
            gripClientes.Name = "gripClientes";
            gripClientes.RowHeadersWidth = 51;
            gripClientes.RowTemplate.Height = 25;
            gripClientes.Size = new Size(503, 200);
            gripClientes.TabIndex = 10;
            gripClientes.CellContentClick += AdministracionClientes_Load;
            // 
            // lblgripclientes
            // 
            lblgripclientes.AutoSize = true;
            lblgripclientes.Location = new Point(35, 312);
            lblgripclientes.Name = "lblgripclientes";
            lblgripclientes.Size = new Size(134, 20);
            lblgripclientes.TabIndex = 11;
            lblgripclientes.Text = "Listado de Clientes";
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 567);
            Controls.Add(lblgripclientes);
            Controls.Add(gripClientes);
            Controls.Add(btnReset);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(textCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(textCelular);
            Controls.Add(lblCelular);
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
        private TextBox textCelular;
        private Label lblCelular;
        private TextBox textCorreo;
        private Label lblCorreo;
        private Button btnGuardar;
        private Button btnAnular;
        private Button btnReset;
        private DataGridView gripClientes;
        private Label lblgripclientes;
    }
}