using Ingenico.Application.Interfaces;
using System;

namespace Ingenico.Application.Services
{
    public class AppCalcularIdadeService : IAppCalcularIdadeService
    {
        //protected readonly ICalcularIdadeService calcularIdadeService;

        //public AppCalcularIdadeService(ICalcularIdadeService service)
        //{
        //    this.calcularIdadeService = service;
        //}
        //public AppCalcularIdadeService()
        //{
        //    this.calcularIdadeService = new CalcularIdadeService();
        //}

        public long CalcularIdade(DateTime dataNascimento)
        {
            if (dataNascimento > DateTime.Now)
                throw new ArgumentException("Data Invalida");

            long idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                idade--;

            return idade;
        }
    }
}
