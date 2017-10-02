using System;
namespace validacoes.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
        }

        /*
		private string _user;
		public string User
		{
			get { return _user; }
			set
			{
				_user = value;
				this.Notify(nameof(User));
			}
		}
		*/

		private string _senha;
		public string Senha
		{
			get { return _senha; }
			set
			{
				_senha = value;
				this.Notify(nameof(Senha));
			}
		}

		public ValidatableObject<string> User
		{
			get
			{
				return _user;
			}
			set
			{
				_user = value;
				RaisePropertyChanged(() => User);
			}
		}


    }
}
