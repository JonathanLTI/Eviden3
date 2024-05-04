namespace Nutribyte
{
    partial class AdultAdolec
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTalla = new System.Windows.Forms.TextBox();
            txtCircunferenciaMuñeca = new System.Windows.Forms.TextBox();
            txtCircunferenciaBrazo = new System.Windows.Forms.TextBox();
            txtPliegueTricipital = new System.Windows.Forms.TextBox();
            txtCircunferenciaCintura = new System.Windows.Forms.TextBox();
            txtCircunferenciaCadera = new System.Windows.Forms.TextBox();
            btnCalcular = new System.Windows.Forms.Button();
            // Otros controles aquí

            // 
            // Asignación de propiedades y configuración de otros controles aquí
            // 

            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTalla;
        private TextBox txtCircunferenciaMuñeca;
        private TextBox txtCircunferenciaBrazo;
        private TextBox txtPliegueTricipital;
        private TextBox txtCircunferenciaCintura;
        private TextBox txtCircunferenciaCadera;
        private Button btnCalcular;
        // Otros controles aquí
    }
}