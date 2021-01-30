namespace Database
{
    public class Map
    {
        public static string Builder(IBase iBase){
            var nome = $"{iBase.GetType().Name.ToLower()}";
            var tabela = iBase.GetType().GetCustomAttributes();
            if( tabela !=null && !string.IsNullOrEmpty(tabela)){
                nome = tabela.Nome;
            }

            var campos = iBase.GetType().GetProperties();
            var sql = $"insert into {nome} value(";
            List<String> colunasDb = new List<String>();

            foreach(var campo in campos){
                var campoPersistir = campo.GetCustomAttributes();
                if(campoPersistir != null){
                    //var nomeCampo
                    //colunasDb.Add(nomeCampo);
                }
            }
            sql += string.Join("," colunasDb.ToArray());

            return sql;
        }
    }
}