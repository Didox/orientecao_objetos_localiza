using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Interfaces.Generics
{
    public abstract class AcoesBancoDeDados<T>
    {
        [Table(PrimaryKey="Id")]
        public virtual int Id { get; set; }

        public void Salvar()
        {
            if (!this.Validado()) throw new Exception("Erro na validação de dados");

            Console.WriteLine("Salvando o objeto no banco de dados");
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                //cn.ConnectionString = "MinhaStrConnection";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                List<string> cols = new List<string>();
                List<object> values = new List<object>();

                foreach (var p in this.GetType().GetProperties())
                {
                    if (p.GetValue(this) == null) continue;

                    TableAttribute[] propertyAttributes = (TableAttribute[])p.GetCustomAttributes(typeof(TableAttribute), false);
                    if (propertyAttributes != null && propertyAttributes.Length > 0)
                    {
                        if (!propertyAttributes[0].IsNotOnDataBase && string.IsNullOrEmpty(propertyAttributes[0].PrimaryKey))
                        {
                            cols.Add(p.Name);
                            values.Add(p.GetValue(this));
                        }
                    }
                    else
                    {
                        cols.Add(p.Name);
                        values.Add(p.GetValue(this));
                    }
                }

                string table = this.nomeTabela();

                string sql = string.Empty;
                if (this.Id == 0)
                {
                    sql = $"insert into {table} (";
                    sql += string.Join(',', cols);
                    sql += ") values ( ";
                    sql += "@" + string.Join(", @", cols);
                    sql += ")";
                }
                else
                {
                    sql = $"update {table} set ";

                    var colsUpdate = new List<string>();
                    foreach (string col in cols)
                    {
                        colsUpdate.Add($"{col}=@${col}");
                    }
                    sql += string.Join(',', colsUpdate);

                    sql += $"where Id = {this.Id}";
                }

                for (var i = 0; i < cols.Count; i++)
                {
                    var value = values[i];
                    var col = cols[i];

                    cmd.Parameters.Add($"@{col}", GetDbType(value));
                    cmd.Parameters[$"@{col}"].Value = value;
                }

                cmd.CommandText = sql;

                //cn.Open();
                //this.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            Console.WriteLine("Salvando o objeto no banco de dados");
        }

        private string camposParaInserir()
        {
            return " .... Campos ....";
        }

        private string valoresParaInserir()
        {
            return " .... Valores ....";
        }

        private bool Validado()
        {
            Console.WriteLine("Validando classe");
            return true;
        }

        private string nomeTabela()
        {
            var table = $"{this.GetType().Name.ToLower()}s";

            TableAttribute tableAttribute = this.GetType().GetCustomAttribute<TableAttribute>();
            if (tableAttribute != null)
            {
                table = tableAttribute.Name;
            }
            return table;
        }

        private SqlDbType GetDbType(object value)
        {
            var result = SqlDbType.VarChar;

            try
            {
                Type type = value.GetType();

                switch (Type.GetTypeCode(type))
                {
                    case TypeCode.Object:
                        result = SqlDbType.Variant;
                        break;
                    case TypeCode.Boolean:
                        result = SqlDbType.Bit;
                        break;
                    case TypeCode.Char:
                        result = SqlDbType.NChar;
                        break;
                    case TypeCode.SByte:
                        result = SqlDbType.SmallInt;
                        break;
                    case TypeCode.Byte:
                        result = SqlDbType.TinyInt;
                        break;
                    case TypeCode.Int16:
                        result = SqlDbType.SmallInt;
                        break;
                    case TypeCode.UInt16:
                        result = SqlDbType.Int;
                        break;
                    case TypeCode.Int32:
                        result = SqlDbType.Int;
                        break;
                    case TypeCode.UInt32:
                        result = SqlDbType.BigInt;
                        break;
                    case TypeCode.Int64:
                        result = SqlDbType.BigInt;
                        break;
                    case TypeCode.UInt64:
                        result = SqlDbType.Decimal;
                        break;
                    case TypeCode.Single:
                        result = SqlDbType.Real;
                        break;
                    case TypeCode.Double:
                        result = SqlDbType.Float;
                        break;
                    case TypeCode.Decimal:
                        result = SqlDbType.Money;
                        break;
                    case TypeCode.DateTime:
                        result = SqlDbType.DateTime;
                        break;
                    case TypeCode.String:
                        result = SqlDbType.VarChar;
                        break;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return result;
        }

        public void Excluir()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaStrConnection";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from clientes where id=" + this.Id;

                cn.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Salvando o objeto no banco de dados");
            }
        }

        public static List<T> Buscar()
        {
            Console.WriteLine("Buscando lista de clientes");
            return new List<T>();
        }
    }
}
