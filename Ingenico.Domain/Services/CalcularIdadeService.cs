using Ingenico.Domain.Interfaces;
using System;

namespace Ingenico.Domain.Services
{
    public class CalcularIdadeService : ICalcularIdadeService
    {
        public long CalcularIdade(DateTime dataNascimento)
        {
            ///var dataAtual = DateTime.Now;
            if (dataNascimento > DateTime.Now)
                throw new ArgumentException("Data Invalida");

            long idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                idade--;

            return idade;
        }
    }
}
