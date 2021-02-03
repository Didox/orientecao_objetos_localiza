using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Perfistencia.Infrastructure.Database
{
    public class GenericMap
    {
        public static string Builder<T>(T dado)
        {
            var nome = $"{dado.GetType().Name.ToLower()}s";
            var tabela = dado.GetType().GetCustomAttribute<TableAttribute>();
            if (tabela != null && !string.IsNullOrEmpty(tabela.Name))
            {
                nome = tabela.Name;
            }

            var fields = dado.GetType().GetProperties();

            var sql = $"insert into {nome} (";
            List<string> colsDb = new List<string>();
            List<string> colsDbParameter = new List<string>();

            foreach (var field in fields)
            {
                var persistedField = field.GetCustomAttribute<FieldsAttribute>();
                if (persistedField != null)
                {
                    var nameField = string.IsNullOrEmpty(persistedField.ColumnName) ? field.Name : persistedField.ColumnName;
                    colsDb.Add(nameField);

                    colsDbParameter.Add($"@{nameField}");
                }
            }

            sql += string.Join(",", colsDb.ToArray());

            sql += ") values (";

            sql += string.Join(",", colsDbParameter.ToArray());
            sql += ")";

            return sql;
        }

    public static SqlParameter GetBuilderValue<T>(T obj, string sqlParameter, string objPropriety)
    {
        var value = obj.GetType().GetProperty(objPropriety).GetValue(obj);
        var param = new SqlParameter(sqlParameter, GetDbType(value));
        param.Value = value;
        return param;
    }

    private static SqlDbType GetDbType(object value)
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

    public static List<SqlParameter> BuilderParameters<T>(T obj)
        {
            var fields = obj.GetType().GetProperties();

            List<SqlParameter> parameters = new List<SqlParameter>();

            foreach (var field in fields)
            {
                var persistedField = field.GetCustomAttribute<FieldsAttribute>();
                if (persistedField != null)
                {
                    var nameField = string.IsNullOrEmpty(persistedField.ColumnName) ? field.Name : persistedField.ColumnName;
                    parameters.Add(GetBuilderValue(obj, $"@{nameField}", field.Name));
                }
            }

            return parameters;
        }
    }
}