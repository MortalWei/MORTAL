using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MortalLib;
using System.ComponentModel.DataAnnotations;

namespace MortalLib.DataTables
{
    /// <summary>
    /// DataTable转换
    /// </summary>
    public static class DataTableConvert
    {
        /// <summary>
        /// DataTable转换为Json
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string SerializeObject(DataTable args)
        {
            return string.Empty;
        }

        /// <summary>
        /// DataTable转换为实体集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        public static List<T> DeserializeObject<T>(DataTable args) where T : new()
        {
            if (args == null) return null;
            List<T> result = new List<T>();
            args.Rows.ForEach(dr =>
            {
                var model = new T();
                var _Properties = typeof(T).GetProperties();

                foreach (var item in _Properties)
                {
                    var _Type = item.PropertyType;
                    if (!item.CanWrite) continue;
                    var _Attrbutes = item.GetCustomAttributes(typeof(DisplayAttribute), false);

                    if (_Attrbutes == null || _Attrbutes.Length == 0) continue;
                    var _Display = _Attrbutes[0] as DisplayAttribute;
                    if (string.IsNullOrEmpty(_Display.Name)) continue;
                    if (!dr.Table.Columns.Contains(_Display.Name)) continue;
                    if (dr[_Display.Name] is DBNull) continue;


                    if (_Type.IsEnum)
                    {
                        item.SetValue(model, Enum.Parse(item.PropertyType, dr[_Display.Name].ToString()), null);
                    }
                    else if (_Type != dr.Table.Columns[_Display.Name].DataType)
                    {
                        if (_Type.IsGenericType && _Type.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            Type _NonNullable = Nullable.GetUnderlyingType(_Type);
                            item.SetValue(model, Convert.ChangeType(dr[_Display.Name], _NonNullable), null);
                        }
                        else
                        {
                            item.SetValue(model, Convert.ChangeType(dr[_Display.Name], _Type), null);
                        }
                    }
                    else
                    {
                        item.SetValue(model, dr[_Display.Name], null);
                    }
                }
                result.Add(model);
            });
            return result;
        }
    }
}
