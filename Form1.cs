using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMensualAutomovil
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcularTarifa_Click(object sender, EventArgs e)
        {
            if (cmbTipoBoleto.Text == "Estudiante")
            {
                boleto = new clsEstudiantes(txtTipo.Text);
            }
            else if (cmbTipo.Text == "Automovil")
            {
                boleto = new Automovil();
            }
            else if (cmbTipoBoleto.Text == "Adulto Mayor")
            {
                boleto = new BoletoAdultoMayor(txtTipo.Text);
            }
        }
    }
}
