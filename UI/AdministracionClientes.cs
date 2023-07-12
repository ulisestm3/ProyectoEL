using BLL;
using DAL;
using EL;

namespace UI
{
    public partial class AdministracionClientes : Form
    {
        public AdministracionClientes()
        {
            InitializeComponent();
        }
        private void AdministracionClientes_Load(object sender, EventArgs e)
        {
            Cargargrip();
        }

        private void Cargargrip()
        {
            try
            {
                gripClientes.DataSource = BLL_Clientes.Lista();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textNombreCliente.Text = string.Empty;
            textCelular.Text = string.Empty;
            textCorreo.Text = string.Empty;
        }
    }
}