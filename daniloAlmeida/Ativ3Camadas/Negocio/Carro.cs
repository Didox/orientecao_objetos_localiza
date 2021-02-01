using DataBase;

namespace Negocio
{
    public class Carro : IBase
    {        
        public int Id;
        public string Nome;

        public void Salvar(){
            //CarroDbServices.Salvar(this);

            CarrosService.Salvar(this);
        }

    }  
}