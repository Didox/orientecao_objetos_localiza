using system;


namespace Singleton.Service.AutenticateService.cs
{
    public class AutenticateService
    {
        private static AutenticateService Instance;
        private AutenticateService()
        {
            Instance == null ? Instance = new AutenticateService() : Instance;
        }
   
    }
}