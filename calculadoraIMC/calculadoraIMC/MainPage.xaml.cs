﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Peso bajo";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Peso normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Sobrepeso";
                }
                else
                {
                    resultado = "Obesidad";
                }

                DisplayAlert("Resultado", resultado, "Ok");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Debes llenar todos los campos", "Ok");
            }
            
        }
    }
}
