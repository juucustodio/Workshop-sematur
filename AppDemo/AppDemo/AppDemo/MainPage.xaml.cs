using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            int NumeroA = int.Parse(TextoA.Text);
            int NumeroB = int.Parse(TextoB.Text);
            int Total = NumeroA + NumeroB;

            Resultado.Text = "Total = "+Total;
        }
    }
}
