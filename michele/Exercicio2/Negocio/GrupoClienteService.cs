using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class GrupoClienteService
    {
        public List<GrupoCliente> Todos()
        {
            var grupos = GrupoClienteDBService.Todos();
            var gruposCast = new List<GrupoCliente>();

            foreach (var grupo in grupos)
            {
                var grupoCast = (GrupoCliente)grupo;
                gruposCast.Add(grupoCast);
            }

            return gruposCast;
        }
    }
}
