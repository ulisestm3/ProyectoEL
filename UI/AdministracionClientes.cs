using DAL;
using BLL;
using EL;

namespace UI
{
    public partial class AdministracionClientes : Form
    {
        public AdministracionClientes()
        {
            InitializeComponent();
        }

        private void gripClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargargrip();
        }

        private void Cargargrip()
        {
            try
            {
                gripClientes.DataSource = BLL_Clientes.Listar();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}