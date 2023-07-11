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
            lblNombreCliente.Location = new Point(27, 9);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(110, 15);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // textNombreCliente
            // 
            textNombreCliente.Location = new Point(31, 24);
            textNombreCliente.Name = "textNombreCliente";
            textNombreCliente.Size = new Size(265, 23);
            textNombreCliente.TabIndex = 2;
            // 
            // textCelular
            // 
            textCelular.Location = new Point(31, 75);
            textCelular.Name = "textCelular";
            textCelular.Size = new Size(265, 23);
            textCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(27, 60);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 3;
            lblCelular.Text = "Celular";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(31, 126);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(265, 23);
            textCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(27, 111);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 178);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(131, 178);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(75, 23);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(221, 178);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // gripClientes
            // 
            gripClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gripClientes.Location = new Point(31, 252);
            gripClientes.Name = "gripClientes";
            gripClientes.RowTemplate.Height = 25;
            gripClientes.Size = new Size(440, 150);
            gripClientes.TabIndex = 10;
            gripClientes.CellContentClick += gripClientes_CellContentClick;
            // 
            // lblgripclientes
            // 
            lblgripclientes.AutoSize = true;
            lblgripclientes.Location = new Point(31, 234);
            lblgripclientes.Name = "lblgripclientes";
            lblgripclientes.Size = new Size(106, 15);
            lblgripclientes.TabIndex = 11;
            lblgripclientes.Text = "Listado de Clientes";
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 425);
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
            MaximizeBox = false;
            Name = "AdministracionClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de Clientes";
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