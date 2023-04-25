using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExamenMoviles
{	
	public partial class Calculadora : ContentPage
	{	
		public Calculadora (string usuario)
		{
			InitializeComponent ();
            lblusuario.Text = "Bienvenido " + usuario;
        }
	}
}

