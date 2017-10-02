using System;
namespace validacoes.Interface
{
    public interface IValidationRule<T>
    {
		string ValidationMessage { get; set; }
		bool Check(T value);
    }
}
