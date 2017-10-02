using System;
using System.Collections.Generic;
using validacoes.ViewModel;
using Xamarin.Forms;

namespace validacoes.View
{
    public partial class LoginPageView : ContentPage
    {
        public LoginPageView()
        {
            InitializeComponent();

            this.BindingContext = new LoginViewModel();
        }
    }
}
