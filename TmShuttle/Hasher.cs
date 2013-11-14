using System;
using System.IO;
using System.Security.Cryptography;

namespace TmShuttle
{
    public class Hasher
    {
        private byte[] _HashKey;   //哈希密钥存储变量
        private string _HashText;  //待加密的字符串
        public Hasher()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="hashText">待加密的字符串</param>
        public Hasher(string hashText)
        {
            this._HashText = hashText;
        }
        /**/
        /// <summary>
        /// 哈希密钥
        /// </summary>
        public byte[] HashKey
        {
            set
            {
                _HashKey = value;
            }
            get
            {
                return _HashKey;
            }
        }

        /**/
        /// <summary>
        /// 需要产生加密哈希的字符串
        /// </summary>
        public string HashText
        {
            set
            {
                _HashText = value;
            }
            get
            {
                return _HashText;
            }
        }

        /**/
        /// <summary>
        /// 使用HMACSHA1类产生长度为 20 字节的哈希序列。需提供相应的密钥，接受任何大小的密钥。
        /// </summary>
        /// <returns></returns>
        public string HMACSHA1Hasher()
        {
            byte[] HmacKey = HashKey;
            byte[] HmacData = System.Text.Encoding.UTF8.GetBytes(HashText);

            HMACSHA1 Hmac = new HMACSHA1(HmacKey);

            CryptoStream cs = new CryptoStream(Stream.Null, Hmac, CryptoStreamMode.Write);
            cs.Write(HmacData, 0, HmacData.Length);
            cs.Close();

            byte[] Result = Hmac.Hash;

            return Convert.ToBase64String(Result);  //返回长度为28字节字符串
        }

        /**/
        /// <summary>
        /// 使用MACTripleDES类产生长度为 8 字节的哈希序列。需提供相应的密钥，密钥长度可为 8、16 或 24 字节的密钥。
        /// </summary>
        /// <returns></returns>
        public string MACTripleDESHasher()
        {
            byte[] MacKey = HashKey;
            byte[] MacData = System.Text.Encoding.UTF8.GetBytes(HashText);

            MACTripleDES Mac = new MACTripleDES(MacKey);

            byte[] Result = Mac.ComputeHash(MacData);

            return Convert.ToBase64String(Result);  //返回长度为12字节字符串
        }

        /**/
        /// <summary>
        /// 使用MD5CryptoServiceProvider类产生哈希值。不需要提供密钥。
        /// </summary>
        /// <returns></returns>
        public string MD5Hasher()
        {
            byte[] MD5Data = System.Text.Encoding.UTF8.GetBytes(HashText);

            MD5 Md5 = new MD5CryptoServiceProvider();

            byte[] Result = Md5.ComputeHash(MD5Data);

            return Convert.ToBase64String(Result); //返回长度为25字节字符串
        }

    }

    public class DESTransform
    {
        public static string EncrptKey = "%@#123_+";
        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        /**/
        /**/
        /**/
        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = System.Text.Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch(Exception ex)
            {
                return encryptString;
            }
        }

        /**/
        /**/
        /**/
        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                byte[] rgbKey = System.Text.Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return System.Text.Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        } 
    }
}