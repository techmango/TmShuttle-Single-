using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TmShuttle
{
    public class RegisterUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mvNumber">机器码</param>
        /// <param name="serialNumber">序列号</param>
        /// <param name="companyName"></param>
        /// <param name="productName"></param>
        /// <returns></returns>
        public static bool Register2Computer(string mvNumber, string serialNumber, string companyName, string productName)
        {
            bool isSuccess = false;
            try
            {
                if (RegisterUtility.getSerialNum(mvNumber).Equals(serialNumber))
                {
                    RegistryAccess regedit = new RegistryAccess(companyName, productName);
                    string regValue = DESTransform.EncryptDES(RegisterUtility.getMvNum(), DESTransform.EncrptKey);
                    regedit.WriteRegistryValue("MvNumber", regValue);
                    IniConfig.WriteValue("SerialNumber", serialNumber);
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
                
            }
            catch{}
            return isSuccess;
        }

        public static bool CheckRegister(string companyName, string productName, string serialNumber)
        {
            bool isSuccess = false;
            try
            {
                RegistryAccess regedit = new RegistryAccess(companyName, productName);
                string regValue = regedit.ReadRegistryValue("MvNumber");
                if (string.IsNullOrEmpty(regValue))
                {
                    if (CheckEffectiveDateTime(companyName, productName) == true)
                        isSuccess = true;
                    else
                        isSuccess = false;
                }
                else
                {
                    string mvNumber = DESTransform.DecryptDES(regValue, DESTransform.EncrptKey);
                    string regSerialNumber = RegisterUtility.getSerialNum(mvNumber);
                    if (regSerialNumber.Equals(serialNumber))
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
            }
            catch { }
            return isSuccess;
        }

        private static bool CheckEffectiveDateTime(string companyName, string productName)
        {
            bool isValidate = false;
            UTF8Encoding byteConverter = new UTF8Encoding();
            RegistryAccess register = new RegistryAccess("Windows", "FirstRun");
            string firstUseTime = register.ReadRegistryValue("FirstUseTime");
            if (!string.IsNullOrEmpty(firstUseTime))
            {
                DateTime decryFirstUseTime = Convert.ToDateTime(DESTransform.DecryptDES(firstUseTime, DESTransform.EncrptKey));
                if ((decryFirstUseTime - DateTime.Now).Days == 0)
                    isValidate = false;
                else
                    isValidate = true;
            }
            else
            {
                string firstUseTimeStr = DESTransform.EncryptDES(DateTime.Now.Date.ToString(), DESTransform.EncrptKey);
                register.WriteRegistryValue("FirstUseTime", firstUseTimeStr);
                //then write MvNumber at the first time
                register.WriteRegistryValue("MvNumber", DESTransform.EncryptDES(RegisterUtility.getMvNum(), DESTransform.EncrptKey));
                isValidate = true;
            }
            return isValidate;
        }

        //生成机器码
        public static string getMvNum()
        {
            string strNum = ComputerInfo.GetProcessorId() + ComputerInfo.GetHDid();//获得24位Cpu和硬盘序列号
            string strMNum = strNum.Substring(0, 24);//从生成的字符串中取出前24个字符做为机器码
            return strMNum;
        }
        private static int[] intCode = new int[127];//存储密钥
        private static int[] intNumber = new int[25];//存机器码的Ascii值
        private static char[] Charcode = new char[25];//存储机器码字
        private static void setIntCode()//给数组赋值小于10的数
        {
            for (int i = 1; i < intCode.Length; i++)
            {
                intCode[i] = i % 9;
            }
        }

        public static string getSerialNum(string mvNum)
        {
            setIntCode();//初始化127位数组
            for (int i = 1; i < Charcode.Length; i++)//把机器码存入数组中
            {
                Charcode[i] = Convert.ToChar(mvNum.Substring(i - 1, 1));
            }
            for (int j = 1; j < intNumber.Length; j++)//把字符的ASCII值存入一个整数组中。
            {
                intNumber[j] = intCode[Convert.ToInt32(Charcode[j])] + Convert.ToInt32(Charcode[j]);
            }
            string strAsciiName = "";//用于存储注册码
            for (int j = 1; j < intNumber.Length; j++)
            {
                if (intNumber[j] >= 48 && intNumber[j] <= 57)//判断字符ASCII值是否0－9之间
                {
                    strAsciiName += Convert.ToChar(intNumber[j]).ToString();
                }
                else if (intNumber[j] >= 65 && intNumber[j] <= 90)//判断字符ASCII值是否A－Z之间
                {
                    strAsciiName += Convert.ToChar(intNumber[j]).ToString();
                }
                else if (intNumber[j] >= 97 && intNumber[j] <= 122)//判断字符ASCII值是否a－z之间
                {
                    strAsciiName += Convert.ToChar(intNumber[j]).ToString();
                }
                else//判断字符ASCII值不在以上范围内
                {
                    if (intNumber[j] > 122)//判断字符ASCII值是否大于z
                    {
                        strAsciiName += Convert.ToChar(intNumber[j] - 10).ToString();
                    }
                    else
                    {
                        strAsciiName += Convert.ToChar(intNumber[j] - 9).ToString();
                    }
                }
            }

            string serialNumber = "";
            int count = 0;
            foreach (char c in strAsciiName.ToCharArray())
            {
                count++;
                serialNumber += c.ToString();
                if (count % 4 == 0)
                {
                    serialNumber += "-";
                }
                
            }
            return serialNumber.Trim('-');
        }
    }
}
