using System;
using System.Runtime.Serialization;

namespace api.Domain.UseCase.UserService
{
  [Serializable]
  internal class UserEmptyId : Exception
  {
    public UserEmptyId(string message) : base(message) { }
  }
}