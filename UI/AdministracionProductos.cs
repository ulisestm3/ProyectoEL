using EL;
using BLL;

namespace UI
{
    public partial class AdministracionProductos : Form
    {
        //By Ulisestm3
        //variables gobales
        private static int IdUsuarioSesion = 1;
        private static int IdRegistro = 0;

        public AdministracionProductos()
        {
            InitializeComponent();
        }

        private void AdministracionProductos_Load(object sender, EventArgs e)
        {
            Cargargrip();
        }

        #region Metodos y Funciones

        private void Cargargrip()
        {
            try
            {
                gridProductos.DataSource = BLL_Productos.Lista();
                gridProductos.Columns[1].HeaderText = "Nombre del Producto";
                gridProductos.Columns[2].Visible = true;
                gridProductos.Columns[3].Visible = true;
                gridProductos.Columns[4].Visible = true;
                gridProductos.Columns[5].Visible = true;
                gridProductos.Columns[6].Visible = false;
                gridProductos.Columns[0].Visible = false;
                gridProductos.Columns[7].Visible = false;
                gridProductos.Columns[8].Visible = false;
                gridProductos.Columns[9].Visible = false;
                gridProductos.Columns[10].Visible = false;

                LimpiarCampos();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarFormulario()
        {
            if ((string.IsNullOrEmpty(textNombreProducto.Text)) || string.IsNullOrWhiteSpace(textNombreProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del Producto");
                return false;
            }
            if ((textNombreProducto.Text.Length > 200))
            {
                MessageBox.Show("El campo nombre del Producto debe ser menor a 200 caracteres");
                return false;
            }
            if (BLL_Productos.ExisteNombreProducto(textNombreProducto.Text, IdRegistro))
            {
                MessageBox.Show("El Producto se encuentra registrado");
                return false;
            }

            if ((string.IsNullOrEmpty(textDescripcion.Text)) || string.IsNullOrWhiteSpace(textDescripcion.Text))
            {
                MessageBox.Show("Ingrese la descripcion del Producto");
                return false;
            }
            if ((textDescripcion.Text.Length > 200))
            {
                MessageBox.Show("El campo nombre de la descripcion debe ser menor a 200 caracteres");
                return false;
            }

            if ((string.IsNullOrEmpty(textPrecio.Text)) || string.IsNullOrWhiteSpace(textPrecio.Text))
            {
                MessageBox.Show("Ingrese el precio del Producto");
                return false;
            }
            if ((textPrecio.Text.Length > 10))
            {
                MessageBox.Show("El campo del precio del producto debe ser menor a 10 caracteres");
                return false;
            }

            if ((string.IsNullOrEmpty(textCantidad.Text)) || string.IsNullOrWhiteSpace(textCantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad del Producto");
                return false;
            }
            if ((textCantidad.Text.Length > 10))
            {
                MessageBox.Show("El campo de la cantidad del producto debe ser menor a 10 caracteres");
                return false;
            }

            if ((string.IsNullOrEmpty(textProveedor.Text)) || string.IsNullOrWhiteSpace(textProveedor.Text))
            {
                MessageBox.Show("Ingrese el proveedor del Producto");
                return false;
            }
            if ((textProveedor.Text.Length > 200))
            {
                MessageBox.Show("El campo del proveedor del producto debe ser menor a 200 caracteres");
                return false;
            }

            return true;
        }

        private void Guardar()
        {
            if (validarFormulario())
            {
                Productos Entidad = new Productos();
                Entidad.NombreProducto = textNombreProducto.Text;
                Entidad.Descripcion = textDescripcion.Text;
                Entidad.Precio = textPrecio.Text;
                Entidad.Cantidad = textCantidad.Text;
                Entidad.Proveedor = textProveedor.Text;

                if (IdRegistro > 0)
                {
                    //Actualizar
                    Entidad.IdProducto = IdRegistro;
                    Entidad.IdUsuarioRegistra = IdUsuarioSesion;
                    if (BLL_Productos.Update(Entidad))
                    {
                        MessageBox.Show("Registro actualizado con exito");
                        Cargargrip();
                        return;
                    }
                    MessageBox.Show("Registro no fue actualizado con exito");
                    return;
                }
                //Insertar

                if (BLL_Productos.Insert(Entidad).IdProducto > 0)
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
                Productos entidad = new();
                entidad.IdProducto = IdRegistro;
                entidad.IdUsuarioRegistra = IdUsuarioSesion;
                if (BLL_Productos.Anular(entidad))
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
                IdRegistro = Convert.ToInt32(gridProductos.CurrentRow.Cells[0].Value);
                //lbl_IdRegistro.Text = IdRegistro.ToString();
                textNombreProducto.Text = gridProductos.CurrentRow.Cells[1].Value.ToString();
                textDescripcion.Text = gridProductos.CurrentRow.Cells[2].Value.ToString();
                textPrecio.Text = gridProductos.CurrentRow.Cells[3].Value.ToString();
                textCantidad.Text = gridProductos.CurrentRow.Cells[4].Value.ToString();
                textProveedor.Text = gridProductos.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            IdRegistro = 0;
            textNombreProducto.Text = string.Empty;
            textDescripcion.Text = string.Empty;
            textPrecio.Text = string.Empty;
            textCantidad.Text = string.Empty;
            textProveedor.Text = string.Empty;
        }

        #endregion

        #region Evento de los Controles

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Cargargrip();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }
        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCampos();
        }
        #endregion

    }
}
