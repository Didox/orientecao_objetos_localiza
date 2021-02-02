using System;
using singleton.Services;

namespace singleton.Domain.UseCases
{
    public class EntityUseCase
    {
        public static void Save<T>(T obj)
        {
            DbService.Get().Save(obj);
            SMSService.Get().Send(obj);
            EmailService.Get().Send(obj);
        }
    }
}
