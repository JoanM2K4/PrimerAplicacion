namespace PrimerAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(textNum1.Text);
            valor2 = Convert.ToInt32(textNum2.Text);

            if (rbSuma.Checked)
            {
                resultado = valor1 + valor2;
            }
            else if (rbResta.Checked)
            {
                resultado = valor1 - valor2;
            }
            else if (rbMultiplicacion.Checked)
            {
                resultado = valor1 * valor2;
            }
            else if (rbDivision.Checked)
            {
                resultado = valor1 / valor2;
            }
            else {
                textResultado.Text = "Seleccione una opcion";
                return;
            }


            textResultado.Text = resultado.ToString();

        }

    }
}
