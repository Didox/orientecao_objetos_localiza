using System;
using System.Runtime.Serialization;

namespace api.Domain.UseCase.UserService
{
  [Serializable]
  internal class UserNotFound : Exception
  {
    public UserNotFound(string message) : base(message) { }
  }
}