using BLL;
using DAL;
using EL;

namespace UI
{
    public partial class AdministracionClientes : Form
    {
        //variables gobales
        private static int IdUsuarioSesion = 1;
        private static int IdRegistro = 0;


        public AdministracionClientes()
        {
            InitializeComponent();
        }
        private void AdministracionClientes_Load(object sender, EventArgs e)
        {
            Cargargrip();
        }

        #region Metodos y funciones
        private void Cargargrip()
        {
            try
            {
                gripClientes.DataSource = BLL_Clientes.Lista();
                gripClientes.Columns[1].HeaderText = "Nombre del Cliente";
                gripClientes.Columns[2].HeaderText = "Número";
                gripClientes.Columns[0].Visible = false;
                gripClientes.Columns[4].Visible = false;
                gripClientes.Columns[5].Visible = false;
                gripClientes.Columns[6].Visible = false;
                gripClientes.Columns[7].Visible = false;
                gripClientes.Columns[8].Visible = false;
                LimpiarCampos();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarFormulario()
        {
            if ((string.IsNullOrEmpty(textNombreCliente.Text)) || string.IsNullOrWhiteSpace(textNombreCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return false;
            }
            if (!(textNombreCliente.Text.Length < 200))
            {
                MessageBox.Show("El campo nombre del cliente debe ser menor a 200 caracteres");
                return false;
            }

            if ((string.IsNullOrEmpty(textNumero.Text)) || string.IsNullOrWhiteSpace(textNumero.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return false;
            }
            if (!(textNumero.Text.Length < 10))
            {
                MessageBox.Show("El campo número debe ser menor a 10 caracteres");
                return false;
            }

            if ((string.IsNullOrEmpty(textCorreo.Text)) || string.IsNullOrWhiteSpace(textCorreo.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return false;
            }
            if (!(textCorreo.Text.Length < 200))
            {
                MessageBox.Show("El campo correo debe ser menor a 200 caracteres");
                return false;
            }
            return true;
        }

        private void Guardar()
        {
            if (validarFormulario())
            {
                Clientes Entidad = new Clientes();
                Entidad.NombreCliente = textNombreCliente.Text;
                Entidad.Numero = textNumero.Text;
                Entidad.Correo = textCorreo.Text;

                if (IdRegistro > 0)
                {
                    //Actualizar
                    Entidad.IdCliente = IdRegistro;
                    Entidad.IdUsuarioRegistra = IdUsuarioSesion;
                    if (BLL_Clientes.Update(Entidad))
                    {
                        MessageBox.Show("Registro actualizado con exito");
                        Cargargrip();
                        return;
                    }
                    MessageBox.Show("Registro no fue actualizado con exito");
                    return;
                }
                //Insertar

                if (BLL_Clientes.Insert(Entidad).IdCliente > 0)
                {
                    MessageBox.Show("Registro agregado con exito");
                    Cargargrip();
                    return;
                }
                MessageBox.Show("El Registro no fue actualizado con exito");
                return;
            }
        }

        private void Anular()
        {
            try
            {
                Clientes entidad = new();
                entidad.IdCliente = IdRegistro;
                entidad.IdUsuarioRegistra = IdUsuarioSesion;
                if (BLL_Clientes.Anular(entidad))
                {
                    MessageBox.Show("Registro anulado con exito");
                    Cargargrip();
                    return;
                }
                MessageBox.Show("El Registro no fue anulado con exito");
                return;
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);
            }
        }

        private void cargarCampos()
        {
            try
            {
                IdRegistro = Convert.ToInt32(gripClientes.CurrentRow.Cells[0].Value);
                lbl_IdRegistro.Text = IdRegistro.ToString();
                textNombreCliente.Text = gripClientes.CurrentRow.Cells[1].Value.ToString();
                textNumero.Text = gripClientes.CurrentRow.Cells[2].Value.ToString();
                textCorreo.Text = gripClientes.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            IdRegistro = 0;
            textNombreCliente.Text = string.Empty;
            textNumero.Text = string.Empty;
            textCorreo.Text = string.Empty;
            lbl_IdRegistro.Text = string.Empty;
        }

        #endregion

        #region Eventos de los controles
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void gripClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Cargargrip();
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        #endregion


    }
}