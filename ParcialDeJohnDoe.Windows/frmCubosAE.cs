using ParcialDeYagoTorres.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialDeJohnDoe.Windows
{
    public partial class frmCubosAE : Form
    {
        public frmCubosAE()
        {
            InitializeComponent();
        }
        private Cubo cubo;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
            if (cubo != null)
            {
                AristaTextBox.Text = cubo.Arista.ToString();
                RellenoComboBox.SelectedItem = (Relleno)cubo.Relleno;
                switch (cubo.Trazo)
                {
                    case Trazo.Continuo:
                        ContinuoRadioButton.Checked = true;
                        break;
                    case Trazo.Rayas:
                        RayasRadioButton.Checked = true;
                        break;
                    case Trazo.Puntos:
                        PuntosRadioButton.Checked = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void CargarComboColores()
        {
            RellenoComboBox.DataSource = Enum.GetValues(typeof(Relleno));
            RellenoComboBox.SelectedIndex = 0;
        }

        public Cubo GetCubo()
        {
            return cubo;
        }

        public void SetCubo(Cubo cubo)
        {
            this.cubo = cubo;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cubo == null)
                {
                    cubo = new Cubo();
                }

                cubo.Arista = int.Parse(AristaTextBox.Text);
                cubo.Relleno = (Relleno)RellenoComboBox.SelectedItem;
                if (ContinuoRadioButton.Checked)
                {
                    cubo.Trazo = Trazo.Continuo;
                }
                else if (RayasRadioButton.Checked)
                {
                    cubo.Trazo = Trazo.Rayas;
                }
                else
                {
                    cubo.Trazo = Trazo.Puntos;
                }

                if (cubo.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                errorProvider1.SetError(AristaTextBox, "La arista debe ser positiva");

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(AristaTextBox.Text, out int radio))
            {
                valido = false;
                errorProvider1.SetError(AristaTextBox, "Arista mal ingresada");
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
