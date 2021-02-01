

using System;
using Strategy.Services;

namespace Strategy.Dominio.UseCase
{
  public class EntidadeUseCase
  {
      public static void Salvar<T>(T entidade)
      {
        DbService.Instancia().Salvar(entidade);
        SmsService.Instancia().Enviar(entidade);
        EmailService.Instancia().Enviar(entidade);
      }
  }
}