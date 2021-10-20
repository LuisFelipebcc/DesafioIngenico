using System;

namespace Ingenico.Application.Interfaces
{
    public interface IAppCalcularIdadeService
    {
        long CalcularIdade(DateTime dataNascimento);
    }
}
