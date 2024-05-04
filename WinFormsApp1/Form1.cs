using System;
using System.Windows.Forms;

namespace Nutribyte
{
    public partial class AdultAdolec : Form
    {
        public AdultAdolec()
        {
            InitializeComponent();
            btnCalcular.Click += BtnCalcular_Click;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double talla = Convert.ToDouble(txtTalla.Text);
                double circunferenciaMu�eca = Convert.ToDouble(txtCircunferenciaMu�eca.Text);
                double circunferenciaBrazo = Convert.ToDouble(txtCircunferenciaBrazo.Text);
                double pliegueTricipital = Convert.ToDouble(txtPliegueTricipital.Text);
                double circunferenciaCintura = Convert.ToDouble(txtCircunferenciaCintura.Text);
                double circunferenciaCadera = Convert.ToDouble(txtCircunferenciaCadera.Text);

                double complexionCorporal = talla / circunferenciaMu�eca;
                double circunferenciaMuscularBrazo = circunferenciaBrazo - (pliegueTricipital * Math.PI);
                double indiceCinturaCadera = circunferenciaCintura / circunferenciaCadera;

                txtComplexionCorporal.Text = complexionCorporal.ToString("F2");
                txtCircunferenciaMuscularBrazo.Text = circunferenciaMuscularBrazo.ToString("F2");
                txtIndiceCinturaCadera.Text = indiceCinturaCadera.ToString("F2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, introduzca valores num�ricos v�lidos. Detalle del error: " + ex.Message);
            }
        }
    }
}