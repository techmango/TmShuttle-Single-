using System;
using System.Reflection;
using Microsoft.Win32;

namespace RegCodeGenerator
{
    public class RegistryAccess
    {
       private RegistryKey _Software;
       private RegistryKey _Company;
       private RegistryKey _Product;
       public  RegistryAccess():this(((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),typeof(AssemblyCompanyAttribute),true )).Company,
           ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),typeof(AssemblyProductAttribute),true )).Product)
       {

       }

       public RegistryAccess(string CompanyName, string ProductName)
       {
           _Software = Registry.LocalMachine.OpenSubKey("Software");
           _Company = _Software.OpenSubKey(CompanyName);
           if (null == _Company)
           {
               _Company = Registry.LocalMachine.CreateSubKey(@"Software\" + CompanyName);

           }
           //temporarily add Windows sub key
           RegistryKey windowSubKey = _Company.OpenSubKey("Windows");
           if (windowSubKey == null)
           {
               windowSubKey = Registry.LocalMachine.CreateSubKey(string.Format(@"Software\Windows"));
           }
           _Product = _Company.OpenSubKey(ProductName, true);
           if (null == _Product)
           {
               _Product=Registry.LocalMachine.CreateSubKey(string.Format ("Software\\{0}\\{1}",CompanyName,ProductName ));
           }
       }
       /// <summary>
       /// 写注册表
       /// </summary>
       /// <param name="ValueName"></param>
       /// <param name="Value"></param>
       public void WriteRegistryValue(string ValueName, string Value)
       {
           _Product.SetValue(ValueName, Value);
       }
       /// <summary>
       /// 读注册表
       /// </summary>
       /// <param name="ValueName"></param>
       /// <returns></returns>
       public string ReadRegistryValue(string ValueName)
       {
           return (string)_Product.GetValue(ValueName);
       }
          

    }
}
