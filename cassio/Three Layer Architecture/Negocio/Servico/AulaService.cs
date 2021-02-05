using Database;
using Negocio.Modelos;
using System.Collections.Generic;

namespace Negocio.Servico
{
    public class AulaDBService : BDService
    {
        public override void Salvar<T>(T aula)
        {
            base.Salvar(aula);
        }

        public override List<object> Listar()
        {
            return base.Listar();
        }

    }

}