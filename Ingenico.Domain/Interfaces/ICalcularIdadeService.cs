using System;

namespace Ingenico.Domain.Interfaces
{
    public interface ICalcularIdadeService
    {
        long CalcularIdade(DateTime dataNascimento);
    }
}
