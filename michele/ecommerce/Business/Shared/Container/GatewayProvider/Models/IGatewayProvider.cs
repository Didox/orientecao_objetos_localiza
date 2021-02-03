using System;

namespace Business.Shared.Container.GatewayProvider.Models
{
    public interface IGatewayProvider
    {
        bool Pay();
        
    }
}