using System.Collections.Generic;
using Business.Models;
using Database.Repositories;

namespace Business.Services
{
    public class OrderCrudService
    {
        public static void Save(Order obj)
        {
            BaseFileCrudService.Save(obj);
            BaseRepository.Save(obj);
            BaseEmailService.Send(obj);
            BaseSMSService.Send(obj);
            BaseGatewayService.Pay(obj);
        }
    }
}
