using System;
using System.Collections.Generic;
using System.Data;

namespace ClassyAdsWinApp.Utils
{
    internal static class DataSetHelper
    {
        public static DataSet CreateDataSet<T>(IEnumerable<T> data, string tableName)
        {
            try
            {
                var dataSet = new DataSet();
                var dataTable = new DataTable(tableName);

                var properties = typeof(T).GetProperties();

                foreach (var property in properties)
                {
                    Type propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    dataTable.Columns.Add(property.Name, propertyType);
                }

                foreach (var item in data)
                {
                    var row = dataTable.NewRow();

                    foreach (var property in properties)
                    {
                        object value = property.GetValue(item);
                        row[property.Name] = value ?? DBNull.Value;
                    }

                    dataTable.Rows.Add(row);
                }

                dataSet.Tables.Add(dataTable);
                return dataSet;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}