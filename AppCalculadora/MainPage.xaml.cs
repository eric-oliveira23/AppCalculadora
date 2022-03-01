using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double n1, n2, resultado;
        string operacao;

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            lblNum.Text += 1;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            lblNum.Text += 2;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            lblNum.Text += 3;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            lblNum.Text += 4;
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            lblNum.Text += 5;
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            lblNum.Text += 6;
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            lblNum.Text += 7;
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            lblNum.Text += 8;
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            lblNum.Text += 9;
        }

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            lblNum.Text += 0;
        }

        private void Button_Clicked_mais(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(lblNum.Text);
                lblNum.Text = String.Empty;
                operacao = "+";
            }

            catch (ArgumentNullException)
            {
                DisplayAlert("Erro", "Você precisa inserir um número.", "OK");
            }

            catch (FormatException)
            {
                DisplayAlert("Erro", "Preencha o campo corretamente.", "OK");
            }
        }

        private void Button_Clicked_menos(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(lblNum.Text);
                lblNum.Text = String.Empty;
                operacao = "-";
            }
            catch (ArgumentNullException)
            {
                DisplayAlert("Erro", "Você precisa inserir um número.", "OK");
            }

            catch (FormatException)
            {
                DisplayAlert("Erro", "Preencha o campo corretamente.", "OK");
            }
        }

        private void Button_Clicked_D(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(lblNum.Text);
                lblNum.Text = String.Empty;
                operacao = "d";
            }

            catch (ArgumentNullException)
            {
                DisplayAlert("Erro", "Você precisa inserir um número.", "OK");
            }

            catch (FormatException)
            {
                DisplayAlert("Erro", "Preencha o campo corretamente.", "OK");
            }
        }

        private void Button_Clicked_x(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(lblNum.Text);
                lblNum.Text = String.Empty;
                operacao = "x";
            }

            catch (ArgumentNullException)
            {
                DisplayAlert("Erro", "Você precisa inserir um número.", "OK");
            }

            catch (FormatException)
            {
                DisplayAlert("Erro", "Preencha o campo corretamente.", "OK");
            }
        }

        private void Button_Clicked_result(object sender, EventArgs e)
        {
            try { 
            n2 = double.Parse(lblNum.Text);
            
            if (operacao == "+")
            {
                resultado = n1 + n2;
                lblNum.Text = resultado.ToString();
            }
            else if (operacao == "-")
            {
                resultado = n1 - n2;
                lblNum.Text = resultado.ToString();
            }

            else if (operacao == "x")
            {
                resultado = n1 * n2;
                lblNum.Text = resultado.ToString();
            }

            else if (operacao == "d")
            {
                resultado = n1 / n2;
                lblNum.Text = resultado.ToString();
            }
                }

            catch (FormatException)
            {
                DisplayAlert("Erro", "Preencha o campo corretamente.", "OK");
            }

            catch (DivideByZeroException)
            {
                DisplayAlert("Sério?", "Você não está tentando dividir por zero, está?", "OK");
            }

            catch (ArgumentNullException)
            {
                DisplayAlert("Erro", "Você precisa inserir um número.", "OK");
            }

        }

        private void Button_Clicked_Clear(object sender, EventArgs e)
        {
            lblNum.Text = String.Empty;
            n1 = 0;
            n2 = 0;
            operacao = String.Empty;
            resultado = 0;
        }
    }
}
