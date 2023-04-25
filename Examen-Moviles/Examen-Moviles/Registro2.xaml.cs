using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExamenMoviles
{	
	public partial class Registro2 : ContentPage
	{	
		public Registro2 (string usuario)
		{
			InitializeComponent ();
            lblusuario.Text = "Bienvenido " + usuario;
        }
	}
}

