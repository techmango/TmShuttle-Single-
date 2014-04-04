using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RegCodeGenerator
{
    public class IniConfig
    {
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        static string sPath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["ConfigFile"];

        static string SECTION = "BaseInfo";

        public IniConfig() { }

        public IniConfig(string fileName, string section)
        {
            sPath = AppDomain.CurrentDomain.BaseDirectory + fileName + ".ini";
            SECTION = section;
        }

        static public string ReadValue(string key)
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);
            GetPrivateProfileString(SECTION, key, "", temp, 255, sPath);
            return temp.ToString();
        }

        static public void WriteValue(string key, string value)
        {
            WritePrivateProfileString(SECTION, key, value, sPath);
        }
    }

    public static class GlobaConfigInstance
    {
        private static readonly GlobaConfig _Instance = new GlobaConfig();

        public static GlobaConfig Instance
        {
            get { return GlobaConfigInstance._Instance; }
        }
    }

    public class GlobaConfig
    {
        private byte _Addr = 1;
        public byte Addr
        {
            get
            {
                if (!string.IsNullOrEmpty(IniConfig.ReadValue("Addr")))
                {
                    _Addr = byte.Parse(IniConfig.ReadValue("Addr"));
                }
                return _Addr;
            }
            set
            {
                _Addr = value;
                IniConfig.WriteValue("Addr", value.ToString());
            }
        }


        private uint _SerialNum = 1;
        public uint SerialNum
        {
            get
            {
                if (!string.IsNullOrEmpty(IniConfig.ReadValue("SerialNum")))
                {
                    _SerialNum = uint.Parse(IniConfig.ReadValue("SerialNum"));
                }
                return _SerialNum;
            }
            set
            {
                _SerialNum = value;
                IniConfig.WriteValue("SerialNum", value.ToString());
            }
        }

        private uint _Baud = 1;
        public uint Baud
        {
            get
            {
                if (!string.IsNullOrEmpty(IniConfig.ReadValue("Baud")))
                {
                    _Baud = uint.Parse(IniConfig.ReadValue("Baud"));
                }
                return _Baud;
            }
            set
            {
                _Baud = value;
                IniConfig.WriteValue("Baud", value.ToString());
            }
        }
    }
}
