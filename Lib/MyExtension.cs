using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class MyExtension
    {
        //Encode Password
        public static string EnCodePassword(string pass)
        {
            #region RSA
            /*  var byteArrayData = Encoding.Unicode.GetBytes(pass);
              StreamReader rd = new StreamReader(string.Concat(AppPath, @"\\PublicKey.xml"));
              var seriali = new XmlSerializer(typeof(RSAParameters));
              var publicKey = (RSAParameters)seriali.Deserialize(rd);

              using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
              {
                  rsa.ImportParameters(publicKey);
                  var result = rsa.Encrypt(byteArrayData,false);
                  return Encoding.Unicode.GetString(result);
              }*/
            #endregion
            #region SHA
            SHA256Managed crypt = new SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(pass), 0, Encoding.UTF8.GetByteCount(pass));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
            #endregion
        }
        public static decimal toDecimal(this double x)
        {
            return decimal.Parse(x.ToString());
        }
        public static long toLong(this object x)
        {
            return long.Parse(x.ToString());
        }
        public static double toDouble(this object x)
        {
            return double.Parse(x.ToString());
        }
        public static double toDoubleS(this string x)
        {
            return double.Parse(x);
        }
        public static double toDoubleString(this string x)
        {
           return double.Parse(x.Replace(',', '.'), CultureInfo.CreateSpecificCulture("en-US"));

        }
        public static int toInt(this object x)
        {
            return int.Parse(x.ToString());
        }
        public static DateTime toDateTime(this object x)
        {
            return DateTime.ParseExact(x.ToString(),"MM/dd/yyyy",null);
        }
        public static T To<T>(this DataRow row)
        {
            var obj = (T)Activator.CreateInstance(typeof(T));
            try
            {
                if (row != null)
                {
                    foreach (PropertyInfo p in obj.GetType().GetProperties())
                    {
                        if (p.CanWrite)
                        {
                            if (row.Table.Columns.Contains(p.Name) && row[p.Name] != null)
                            {
                                if (p.PropertyType == typeof(decimal) || p.PropertyType == typeof(decimal?))
                                {
                                    p.SetValue(obj, decimal.Parse(row[p.Name].ToString()), null);
                                }
                                else if (p.PropertyType == typeof(double) || p.PropertyType == typeof(double?))
                                {
                         
                                    p.SetValue(obj, double.Parse(row[p.Name].ToString()), null);
                                }
                                else if (p.PropertyType == typeof(bool) || p.PropertyType == typeof(bool?))
                                {
                                    p.SetValue(obj, bool.Parse(row[p.Name].ToString()), null);
                                }
                                else if (p.PropertyType == typeof(int) || p.PropertyType == typeof(int?))
                                {
                                    p.SetValue(obj, int.Parse(row[p.Name].ToString()), null);
                                }
                                else if (p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?))
                                {
                                    if (string.IsNullOrEmpty(row[p.Name].ToString()) && p.PropertyType == typeof(DateTime?))
                                    {
                                        p.SetValue(obj, null, null);
                                    }
                                    else
                                        p.SetValue(obj, DateTime.Parse(row[p.Name].ToString()), null);
                                }
                                else
                                {
                                    if (row[p.Name] is DBNull)
                                    {
                                        p.SetValue(obj, "", null);
                                    }
                                    else
                                    {
                                        p.SetValue(obj, row[p.Name], null);
                                    }
                                }
                            }
                            else
                            {
                                p.SetValue(obj, null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return obj;
        }
        public static List<TDestination> To<TDestination>(this DataTable sourceList)
        {
            List<TDestination> ret = new List<TDestination>();
            foreach (DataRow row in sourceList.Rows)
            {
                TDestination t = row.To<TDestination>();
                ret.Add(t);
            }
            return ret;
        }

    }
}
