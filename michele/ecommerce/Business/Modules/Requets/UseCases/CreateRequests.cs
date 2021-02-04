using System;
using Business.Modules.Requets.Entities;
using Database.Repositories.RequestsReposytory;
using Business.Shared.Container.GatewayProvider.Models;
using Business.Shared.Container.MailProvider.Models;
using Business.Shared.Container.SmsProvider.Models;


namespace Business.Modules.Requets.UseCases
{
    public class CreateRequests
    {
        public Request Create(
            Request request, 
            IRequestRepository requestRepository,
            IMailProvider mailProvider,
            ISmsProvider smsProvider,
            IGatewayProvider gatewayProvider
        ){
            var newRequest = requestRepository.Create(request);
            mailProvider.Send("Enviando e-mail.");
            smsProvider.Send("Enviando SMS.");
            gatewayProvider.Pay();

            return newRequest;
        }
    }
}