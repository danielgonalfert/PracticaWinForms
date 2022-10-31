using System.Data;
using System.Diagnostics.Contracts;

namespace PracticaWinForms
{
    public partial class Formulario : Form
    {

        public static bool modoEdicion = false;
        public static bool modoEliminacion = false;
        public Formulario()
        {
            InitializeComponent();
            ID.Visible = false;
            txtID.Visible = false;
            CargarContenidoBD();
        }



        public Tornillo ObtenerInformacion()
        {
            var longitudString = txtLongitud.Text;
            float longitudDecimal = 0;

            bool validar = ValidarNombre() && ValidarLongitud(longitudString, out longitudDecimal);

            Tornillo tornillo = null;

            if (validar)
            {
                tornillo = new Tornillo();

                tornillo.Nombre = txtNombre.Text;
                tornillo.FechaCreacion = dtpFechaCreacion.Value;
                tornillo.Longitud = longitudDecimal;
            }

            return tornillo;
        }

        public bool ValidarNombre()
        {
            return (txtNombre != null && txtNombre.Text.Length > 0); ;
        }

        public bool ValidarLongitud(string longitudString, out float longitudDecimal)
        {
            float longitudAux;
            bool resultado = true;
            if (longitudString != null)
            {
                resultado = float.TryParse(longitudString, out longitudAux);
                longitudDecimal = longitudAux;
            }
            else
            {
                longitudDecimal = 0;
            }
            return resultado;
        }

        public void CargarContenidoBD()
        {
            DataSet ds = FuncBD.ObtenerTornillos();
            ListaTornillos.DataSource = ds.Tables[0];

        }

        public void ModoEdicion(bool on)
        {
            if (on)
            {
                AddButton.Enabled = false;
                DeleteButton.Enabled = false;

                ID.Visible = true;
                txtID.Visible = true;

                modoEdicion = true;
            }
            else
            {
                AddButton.Enabled = true;
                DeleteButton.Enabled = true;

                ID.Visible = false;
                txtID.Visible = false;

                modoEdicion = false;
            }
        }

        public void ModoEliminacion(bool on)
        {
            if (on)
            {
                AddButton.Enabled = false;
                ModifyButton.Enabled = false;

                ID.Visible = true;
                txtID.Visible = true;

                txtNombre.Visible = false;
                lblNombre.Visible = false;

                lblFechaCreacion.Visible = false;
                dtpFechaCreacion.Visible = false;

                lblLongitud.Visible = false;
                txtLongitud.Visible = false;


                modoEliminacion = true;
            }
            else
            {
                AddButton.Enabled = true;
                ModifyButton.Enabled = true;

                ID.Visible = false;
                txtID.Visible = false;

                txtNombre.Visible = true;
                lblNombre.Visible = true;

                lblFechaCreacion.Visible = true;
                dtpFechaCreacion.Visible = true;

                lblLongitud.Visible = true;
                txtLongitud.Visible = true;

                modoEliminacion = false;
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            CargarContenidoBD();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            Tornillo t = ObtenerInformacion();
            if (t == null)
            {
                MessageBox.Show("Error en la entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FuncBD.CrearTornillo(t);
            }
            CargarContenidoBD();
            LimpiarEntrada();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (!modoEdicion)
            {
                ModoEdicion(true);
            }
            else
            {
                Tornillo t = new Tornillo();

                t = ObtenerInformacion();
                t.Id = int.Parse(txtID.Text); // no hace falta validar ya que solo permitimos escribir numeros naturales

                if(t != null)
                {
                    if (FuncBD.ConsultarID(t.Id))
                    {
                        FuncBD.ModificarTornillo(t);
                        ModoEdicion(false);
                        LimpiarEntrada();
                        CargarContenidoBD();
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error en la entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            CargarContenidoBD();
        }

        public void LimpiarEntrada()
        {
            txtNombre.Text = "";
            txtLongitud.Text = "";
            dtpFechaCreacion.Value = DateTime.Now;
            txtID.Text = "";
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!modoEliminacion)
            {
                ModoEliminacion(true);
            }
            else
            {
                

                
             int ID = int.Parse(txtID.Text); // no hace falta validar ya que solo permitimos escribir numeros naturales
             if (FuncBD.ConsultarID(ID))
             {
                 FuncBD.EliminarTornillo(ID);
                 ModoEdicion(false);
                 LimpiarEntrada();
                 CargarContenidoBD();
             }
             else
             {
                MessageBox.Show("ID no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
               
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                ModoEdicion(false);
            }
            if(modoEliminacion)
            {
                ModoEliminacion(false);
            }
            LimpiarEntrada();
        }
    }
}