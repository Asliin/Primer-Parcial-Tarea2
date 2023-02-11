using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal primerParcial = Convert.ToDecimal(PrimerParcialTextBox.Text);
            decimal segundoParcial = Convert.ToDecimal(SegundoParcialTextBox.Text);
            decimal tercerParcial = Convert.ToDecimal(TercerParcialTextBox.Text);
            decimal cuartoParcial = Convert.ToDecimal(CuartoParcialTextBox.Text);

            decimal resultado = await PromedioFinalAsync(primerParcial, segundoParcial, tercerParcial, cuartoParcial);
            MessageBox.Show($"El promedio final del estudiante es: { resultado}");
        }


        private async Task<decimal> PromedioFinalAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal resultado = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return resultado;
        }

    }
}
