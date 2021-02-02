using system;


namespace Singleton.Service.AutenticateService.cs
{
    public class AutenticateService
    {
        private static AutenticateService Instance;
        private AutenticateService()
        {
        }
        public static AutenticateService getInstance()
        {
          return Instance == null ? Instance = new AutenticateService() : Instance;
        }
  
    }
}