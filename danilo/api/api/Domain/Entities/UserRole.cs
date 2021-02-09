using System;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Domain.Entities
{
    public enum UserRole
    {
        Administrador = 1,
        Editor = 2
    }
}
