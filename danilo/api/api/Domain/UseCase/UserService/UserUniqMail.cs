using System;
using System.Runtime.Serialization;

namespace api.Domain.UseCase.UserService
{
  [Serializable]
  internal class UserUniqMail : Exception
  {
    public UserUniqMail(string message) : base(message) { }
  }
}