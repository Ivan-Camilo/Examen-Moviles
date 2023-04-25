using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExamenMoviles
{	
	public partial class Registro : ContentPage
	{	
		public Registro ()
		{
			InitializeComponent ();
		}

        void RegistroButton_Clicked(System.Object sender, System.EventArgs e)
        {
                string usuario = txtUsuarioRegistrado.Text;
                Navigation.PushAsync(new Registro2(usuario));
            
        }
    }
}

