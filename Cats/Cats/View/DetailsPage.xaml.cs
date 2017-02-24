﻿using Cats.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cats.View
{
	public partial class DetailsPage : ContentPage
    {
        //Cat atual
        Cat SelectedCat;
        //Cat selecionado
        public DetailsPage(Cat selectedCat)
        {
            InitializeComponent();
            this.SelectedCat = selectedCat;
            //contexto de ligação setado para o gato selecionado
            BindingContext = this.SelectedCat;            
        }
    }
}
