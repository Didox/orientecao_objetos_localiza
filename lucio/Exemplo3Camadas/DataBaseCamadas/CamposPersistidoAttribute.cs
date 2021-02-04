using System;


namespace DataBaseCamadas
{
  public class CamposPersistidoAttribute : Attribute
  {
    public string NomeColuna { get; set; }
  }
}
