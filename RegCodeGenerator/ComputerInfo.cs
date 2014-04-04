using System;
using System.Management;

namespace RegCodeGenerator
{
    public class ComputerInfo
    {
        /// <summary>
        /// 网卡配置信息
        /// </summary>
        public static string GetMACAddress()
        {
            string MACAddress = string.Empty;
            try
            {
                Console.WriteLine("网卡配置信息");
                ManagementObjectSearcher searcher =
        new ManagementObjectSearcher("Select * From Win32_NetworkAdapterConfiguration");
                foreach (ManagementObject mo in searcher.Get())
                {
                    MACAddress = (string)mo.Properties["MACAddress"].Value;
                }
            }
            catch
            {
            }
            return MACAddress;
        }


        /// <summary>
        /// CPU信息
        /// </summary>
        public static string GetProcessorId()
        {
            string processorId = string.Empty;
            try
            {
                Console.WriteLine("CPU信息");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Processor");
                foreach (ManagementObject mo in searcher.Get())
                {
                    processorId = (string)mo.Properties["ProcessorId"].Value;
                }
            }
            catch
            {
            }
            return processorId;
        }


        /// <summary>
        /// 逻辑磁盘信息
        /// </summary>
        public static string GetHDid()
        {
            string HDid = string.Empty;
            try
            {
                Console.WriteLine("逻辑磁盘信息");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_DiskDrive");
                foreach (ManagementObject mo in searcher.Get())
                {
                    HDid = (string)mo.Properties["Model"].Value;
                    break;
                }
            }
            catch
            {
            }
            return HDid;
        }
    }
}
