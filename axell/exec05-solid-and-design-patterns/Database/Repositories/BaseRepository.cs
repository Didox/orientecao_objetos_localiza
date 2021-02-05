using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Database.Attributes;

namespace Database.Repositories
{
    public class BaseRepository
    {
        public static string getTableName<T>(T obj)
        {
            var attr = obj.GetType().GetCustomAttribute<ModelAttribute>(true);
            return attr != null ? attr.Table : obj.GetType().Name.ToLower();
        }

        public static IEnumerable<PropertyInfo> getProperties<T>(T obj)
        {
            return obj.GetType().GetProperties().Where(
                prop => (
                    prop.IsDefined(typeof(ColumnAttribute), true)
                    && !prop.IsDefined(typeof(PkAttribute), true)
                )
            );
        }

        public static string getAttributes<T>(T obj)
        {
            var attrs = "";
            var properties = getProperties(obj);

            foreach (var property in properties)
            {
                attrs += property.Name.ToLower() + ", ";
            }

            return attrs.Substring(0, attrs.Length - 2);
        }

        public static string getValues<T>(T obj)
        {
            var values = "";
            var properties = getProperties(obj);

            foreach (var property in properties)
            {
                values += $"\"{property.GetValue(obj)}\", ";
            }

            return values.Substring(0, values.Length - 2);
        }

        public static void Save<T>(T obj)
        {
            var tableName = getTableName(obj);
            var attrsStr = getAttributes(obj);
            var attrsValues = getValues(obj);
            var sql = $"INSERT INTO {tableName} ({attrsStr}) VALUES ({attrsValues});";
            Console.WriteLine(sql);
        }
    }
}
