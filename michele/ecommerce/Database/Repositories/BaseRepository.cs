using System;
using System.Collections.Generic;
using System.Reflection;
using Database.Attributes;


namespace Database.Repositories
{
    public class BaseRepository
    {
        private static List<string> getAttributes<T>(T obj)
        {
            var properties = obj.GetType().GetProperties();
            var tableAttibutes = new List<string>();
            foreach (var property in properties){
                
                var propertyPersist = property.GetCustomAttribute<PersistField>();
                if (propertyPersist != null)
                {
                    var nameAtributte = string.IsNullOrEmpty(propertyPersist.Name) ? property.Name : propertyPersist.Name;
                    tableAttibutes.Add(nameAtributte);
                }

            }

            return tableAttibutes;
            
        }

        private static string getNameTable<T>(T obj){
            
            var nameTable = obj.GetType().Name.ToLower();
            var table = obj.GetType().GetCustomAttribute<TableAtributte>();

            if (table != null && !string.IsNullOrEmpty(table.Name))
            {
                nameTable = table.Name;
            }

            return nameTable;

        }


        private static string getValues<T>(T obj)
        {
            var properties = obj.GetType().GetProperties();
            var values = "";
            foreach (var property in properties){
                
                values += $"\"{property.GetValue(obj)}\", ";

            }

            return values.Substring(0, values.Length -2);
            
        }

        private static List<PropertyInfo> getPrimaryKey<T>(T obj){
            var collumnsPrimary = new List<PropertyInfo>();
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var propertyPrimary = property.GetCustomAttribute<PrimaryKeyAttributte>();
                if(propertyPrimary != null){
                    collumnsPrimary.Add(property);
                }
            }
            return collumnsPrimary;

        }

        public static T Create<T>(T obj){

            var tableName = getNameTable(obj);
            var attrsStr = getAttributes(obj);
            var values = getValues(obj);

            var sql = $"insert into {tableName} ({attrsStr}) values {values}";

            Console.WriteLine(sql);

            return obj;
            
        }

        public static void Delete<T>(T obj){

            var tableName = getNameTable(obj);
            var primarysId = getPrimaryKey(obj);
            var conditions = "";
            foreach(var primaryId in primarysId){
                conditions += conditions != "" ? " and " : "";
                conditions += $"{primaryId.Name.ToLower()} = {primaryId.GetValue(obj)}";
            }
            var sql = $"delete from {tableName} where {conditions}";
            
        }
        
    }
}