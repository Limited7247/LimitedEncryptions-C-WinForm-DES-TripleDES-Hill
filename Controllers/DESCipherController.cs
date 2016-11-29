using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LimitedEncryptions.Models;
using System.Diagnostics;

namespace LimitedEncryptions.Controllers
{
    public class DESCipherController
    {
        private const int KEY_LENGTH = 24;
        private const int KEY_COUNT = 10;

        #region PLAIN TEXTS
        public static List<string> plainTexts = new List<string>()
        {
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. "
                + "Nullam semper faucibus enim, nec pellentesque magna dapibus eu. "
                + "Aenean libero lacus, tempus sed imperdiet et, feugiat id metus. "
                + "Pellentesque nec ligula eget lacus dictum eleifend at id magna. "
                + "Nulla facilisi. Sed sed ultrices justo. Sed dapibus sed lectus pellentesque hendrerit. "
                + "Aenean elementum sapien a accumsan condimentum. Curabitur aliquet dui in nulla congue egestas. "
                + "Suspendisse gravida lacus id justo volutpat feugiat. Phasellus accumsan tempus iaculis. "
                + "Integer tristique interdum sodales. Morbi tincidunt nunc porttitor lectus tempus posuere. "
                + "Fusce ultricies a neque et dictum. Aliquam mattis nibh id finibus blandit. "
                + "Mauris ultrices massa ipsum, tincidunt aliquet erat dictum a." },

            {
                "Nunc vitae tincidunt nunc. Pellentesque nec risus id metus cursus sagittis in vitae urna. "
                + "Interdum et malesuada fames ac ante ipsum primis in faucibus. Mauris ut fermentum nunc, vitae molestie ante. "
                + "Donec et erat semper, lobortis mauris facilisis, sollicitudin velit. "
                + "Maecenas viverra, est non venenatis volutpat, nisi est pellentesque erat, sit amet finibus diam magna ut dolor. "
                + "Donec congue mauris vitae fermentum auctor."
            },

            {
                "In vulputate purus vehicula nunc pharetra consequat. Fusce sodales consequat massa nec rutrum. "
                + "Donec mollis cursus odio. Etiam eu lorem interdum, scelerisque velit eget, semper elit. "
                + "Aliquam ac risus sit amet diam lobortis bibendum. Sed dui nibh, eleifend non mi ac, porta tristique felis. "
                + "Nullam non augue quis leo ultrices condimentum et eget urna."
            },

            {
                "Aliquam rutrum odio quis metus aliquet, in ornare ante euismod. Sed vel fermentum tellus. "
                + "Aenean tincidunt aliquet auctor. "
                + "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. "
                + "Donec dolor arcu, commodo at odio at, dictum pharetra urna. "
                + "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. "
                + "Donec vel dapibus risus. Duis mollis lectus nisl, et dignissim orci vehicula vel."
            },

            {
                "Sed luctus nulla eu dui pellentesque, eget luctus libero elementum. "
                + "Nunc ultrices, nunc non posuere pulvinar, turpis ipsum convallis velit, sed facilisis eros purus vel sapien. "
                + "Mauris libero tellus, finibus vel ullamcorper et, suscipit et metus. "
                + "Ut fringilla magna mauris, eget vulputate tortor volutpat eu. "
                + "Quisque sit amet eros pretium, porta neque quis, luctus turpis. Mauris lacinia ut odio et dictum. "
                + "Etiam accumsan odio fringilla ligula dapibus, non aliquam orci aliquam. "
                + "Quisque malesuada tempus odio sed tincidunt. Proin et volutpat est. "
                + "Vivamus viverra lacus placerat pellentesque tincidunt."
            },

            {
                "Sed elementum purus gravida nunc condimentum, quis imperdiet justo euismod. Suspendisse at lobortis urna, eu commodo tortor. Nunc nec velit venenatis lorem tempor sollicitudin non at nunc. Pellentesque eget orci in sem sollicitudin volutpat ut et elit. Curabitur tincidunt ullamcorper libero sed imperdiet. Donec sodales purus vitae sem vestibulum, nec sagittis lacus elementum. Vestibulum ac diam sit amet felis viverra varius a id augue. Maecenas imperdiet tristique nunc vitae scelerisque."
            },

            {
                "Nam rhoncus, nibh quis pulvinar cursus, justo nisi porttitor diam, dignissim tempus neque tellus nec diam. Morbi eu ligula iaculis, rutrum eros a, suscipit ligula. Maecenas nisl nunc, aliquam eu turpis rhoncus, feugiat placerat velit. Nulla eros diam, tincidunt ut maximus ac, aliquam sed arcu. Proin sit amet metus eget massa venenatis sollicitudin ac quis eros. Vivamus porta ligula quis urna accumsan, eu mollis sapien volutpat. Nullam non mattis nisl. Praesent feugiat, mi in aliquam ullamcorper, nisi est facilisis lectus, et placerat nunc nisi nec erat."
            },

            {
                "Nulla ut dui vel urna ultrices efficitur. Suspendisse vel pulvinar diam. Duis nisi lectus, vestibulum sed est eget, tincidunt egestas erat. Cras maximus et nunc ac consequat. Suspendisse potenti. Phasellus in fermentum ex. Quisque ac suscipit erat. Ut turpis tortor, ultrices eu sapien et, malesuada fringilla sem. Ut a fringilla nulla. Curabitur aliquet a purus nec condimentum."
            },

            {
                "Nunc hendrerit sagittis dolor a pretium. Duis sed tortor odio. Pellentesque porta nulla in nisi elementum, et dictum diam malesuada. Praesent mollis justo et nisl vehicula finibus. Proin venenatis feugiat sodales. Curabitur consectetur, turpis a sodales tempus, leo orci vestibulum ligula, et auctor augue purus at felis. Etiam fringilla egestas commodo. Praesent euismod pretium libero, eu sollicitudin nibh porttitor a. Quisque congue pretium pharetra. Suspendisse malesuada ultrices tristique. Donec et ornare nisi. Praesent sollicitudin sapien odio, eu hendrerit velit faucibus in. Maecenas suscipit pulvinar lectus non posuere. Sed velit dolor, commodo eu auctor sit amet, euismod in ligula. Mauris mattis, lectus at pulvinar dictum, erat nulla commodo ex, eu dictum mauris risus quis neque."
            },

            {
                "Proin vestibulum sagittis neque, in venenatis sem congue non. Duis sem arcu, fringilla eu elit eget, egestas lobortis purus. Nullam ut quam rutrum, aliquam metus eget, auctor mauris. Maecenas porttitor dictum mauris nec laoreet. Sed accumsan ante ex, a tincidunt neque dapibus aliquam. Proin sagittis nisl euismod sem maximus, a pharetra est egestas. Donec mollis nunc vitae vestibulum hendrerit. Sed faucibus nunc at hendrerit euismod. Duis eget leo sed ex condimentum mattis nec et mauris. Curabitur facilisis pharetra mauris, id venenatis sem pulvinar vel. Sed iaculis placerat risus, volutpat semper mauris elementum vel. Etiam posuere porta mauris, venenatis vulputate augue malesuada sed."
            }///,

            //{
            //    "abca"
            //}


        };







        #endregion

        public static List<string> GetNewKeys(int? keyCount = KEY_COUNT)
        {
            try
            {
                List<string> keys = new List<string>();

                Random random = new Random();

                for (int i = 0; i < keyCount; i++)
                {
                    keys.Add(GetNewKey(random, KEY_LENGTH));
                }

                return keys;
            }
            catch (Exception)
            {
                return GetNewKeys();
            }

        }

        public static string GetNewKey(Random random, int? keyLength = KEY_LENGTH)
        {
            try
            {
                //string key = "";

                //for (int i = 0; i < keyLength; i++)
                //{
                //    key += 
                //}

                //return key;

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";

                return 
                    new string(
                        Enumerable.Repeat(chars, keyLength.Value)
                        .Select(s => s[random.Next(s.Length)])
                        .ToArray()
                    );
            }
            catch (Exception)
            {
                return GetNewKey(random);
            }
        }

        public static string HashingKey(string key)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //release any resource held by the MD5CryptoServiceProvider

            hashmd5.Clear();

            return Convert.ToBase64String(keyArray, 0, keyArray.Length);
        }

        #region 3DES
        public static string Encrypt(string plainText, string key, bool useHashing)
        {
            ///bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(plainText);

            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string cipherText, string key, bool useHashing)
        {
            ///bool useHashing = true;
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherText);

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        #endregion

        #region DES
        public static string DESEncrypt(string plainText, string key, bool useHashing)
        {
            ///bool useHashing = true;
            byte[] keyArray = new byte[8];
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(plainText);

            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                byte[] keyArray16 = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
                Array.Copy(keyArray16, 8, keyArray, 0, 8);
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            DESCryptoServiceProvider tdes = new DESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string DESDecrypt(string cipherText, string key, bool useHashing)
        {
            ///bool useHashing = true;
            byte[] keyArray = new byte[8];
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherText);

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                byte[] keyArray16 = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
                Array.Copy(keyArray16, 8, keyArray, 0, 8);
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            DESCryptoServiceProvider tdes = new DESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        #endregion

        public static string Encrypt(string plainText, string key, bool useDES, bool useHashing)
        {
            if (useDES) return DESEncrypt(plainText, key, useHashing);

            return Encrypt(plainText, key, useHashing);
        }

        public static string Decrypt(string cipherText, string key, bool useDES, bool useHashing)
        {
            if (useDES) return DESDecrypt(cipherText, key, useHashing);

            return Decrypt(cipherText, key, useHashing);
        }

        #region Statistics
        public static List<AverageStatisticResult> GetListPlainTextAverageStatisticResult(List<string> plainTexts, List<string> keys, List<StatisticResult> list)
        {
            List<AverageStatisticResult> averageList = new List<AverageStatisticResult>();

            for (int i = 0; i < plainTexts.Count; i++)
            {
                averageList.Add(new AverageStatisticResult(i, 2, list));
            }

            return averageList;
        }

        public static List<AverageStatisticResult> GetListKeyAverageStatisticResult(List<string> plainTexts, List<string> keys, List<StatisticResult> list)
        {
            List<AverageStatisticResult> averageList = new List<AverageStatisticResult>();

            for (int i = 0; i < 5; i++)
            {
                averageList.Add(new AverageStatisticResult(i, 1, list));
            }

            return averageList;
        }

        public static List<StatisticResult> GetListStatisticResult(bool useDES, List<string> plainTexts, List<string> keys)
        {
            List<StatisticResult> list = new List<StatisticResult>();

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Stopwatch watch = Stopwatch.StartNew();
                    ///new Hill(keys[i]).Encrypt(toPlainTextValidToKey(plainTexts[j], keys[i].GetLength(0)));

                    Encrypt(plainTexts[j], keys[i], useDES, true);

                    watch.Stop();
                    list.Add(new StatisticResult(j, i, watch.ElapsedTicks));
                }
            }

            return list;
        }
        #endregion
    }
}
