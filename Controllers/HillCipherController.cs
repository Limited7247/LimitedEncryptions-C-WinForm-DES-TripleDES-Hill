using EncryptionAlgorithms;
using LimitedEncryptions.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitedEncryptions.Controllers
{
    public class HillCipherController
    {
        public static List<string> _plainTexts = new List<string>()
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

        public static string GetDictionnary()
        {
            string dictionary = "";

            int key = 0;

            foreach (var item in SecurityAlgorithm.DictionaryAlphabet)
            {
                dictionary += "'" + item.Key + "': '" + item.Value + "'" + '\t';
                key++;

                if (key == 5)
                {
                    key = 0;
                    dictionary += '\n';
                }
            }

            return dictionary;
        }

        public static string KeyToInverseString(int[,] ramdonKeys)
        {
            MatrixClass matrix = new MatrixClass(ramdonKeys);
            matrix = matrix.Inverse();

            return KeyToString(matrix.getMatrixInt());
        }

        internal static List<int[,]> GetNewKeys()
        {
            List<int[,]> keys = new List<int[,]>();

            Random random = new Random();
            for (int i = 2; i <= 6; i++)
            {
                keys.Add(NewKey(i, random));
                keys.Add(NewKey(i, random));
            }

            return keys;
        }

        public static int[,] KeyStringToArrayKey(string text)
        {
            try
            {
                int size = text.Split('\n').Length;
                int[,] arrayKeys = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    string row = text.Split('\n')[i];

                    for (int j = 0; j < size; j++)
                    {
                        arrayKeys[i, j] = Convert.ToInt32(row.Split(' ')[j]);
                    }
                }

                return arrayKeys;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static int[,] NewKey(int size, Random random)
        {
            int[,] keys = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    keys[i, j] = random.Next(0, 55);
                }
            }

            MatrixClass matrix = new MatrixClass(keys);
            if (matrix.Determinent() == 0)
            {
                return NewKey(size, random);
            }
            
            if (matrix.Inverse().Equals(MatrixClass.NullMatrixClass(size, size)))
            {
                return NewKey(size, random);
            }

            return keys;
        }

        //public static List<string> PlainTexts
        //{
        //    get
        //    {
        //        List<string> list = new List<string>();

        //        foreach (var item in list)
        //        {
        //            list.Add(toPlainTextValidToKey(item, new Random().Next(0, 10)));
        //        }

        //        return list;
        //    }
        //}

        public static string toPlainTextValidToKey(string plainText, int keyLength)
        {
            int plainTextSize = plainText.Length;

            if (plainTextSize % keyLength == 0) return plainText;

            int addLength = keyLength * (plainTextSize / keyLength + 1) - plainTextSize;

            for (int i = 0; i < addLength; i++)
            {
                plainText += " ";
            }

            return plainText;
        }

        public static int[,] NewKey(int size)
        {
            //Random random = new Random();
            //int[,] keys = new int[size, size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        keys[i, j] = random.Next(0, 55);
            //    }
            //}

            //return keys;
            return NewKey(size, new Random());
        }

        public static string KeyToString(int[,] key)
        {
            string keyString = "";

            for (int i = 0; i < key.GetLength(0); i++)
            {
                for (int j = 0;  j < key.GetLength(1);  j++)
                {
                    keyString += key[i, j].ToString("00") + " ";
                }
                keyString += '\n';
            }

            return keyString;
        }

        public static List<StatisticResult> GetListStatisticResult(List<string> plainTexts, List<int[,]> keys)
        {
            List<StatisticResult> list = new List<StatisticResult>();

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Stopwatch watch = Stopwatch.StartNew();
                    new Hill(keys[i]).Encrypt(toPlainTextValidToKey(plainTexts[j], keys[i].GetLength(0)));
                    watch.Stop();
                    list.Add(new StatisticResult(j, i, watch.ElapsedTicks));
                }
            }

            return list;
        }

        public static List<AverageStatisticResult> GetListKeyAverageStatisticResult(List<string> plainTexts, List<int[,]> keys, List<StatisticResult> list)
        {
            List<AverageStatisticResult> averageList = new List<AverageStatisticResult>();

            for (int i = 0; i < 5; i++)
            {
                averageList.Add(new AverageStatisticResult(i, 1, list));
            }

            return averageList;
        }

        public static List<AverageStatisticResult> GetListPlainTextAverageStatisticResult(List<string> plainTexts, List<int[,]> keys, List<StatisticResult> list)
        {
            List<AverageStatisticResult> averageList = new List<AverageStatisticResult>();

            for (int i = 0; i < plainTexts.Count; i++)
            {
                averageList.Add(new AverageStatisticResult(i, 2, list));
            }

            return averageList;
        }

        public string ReadFile()
        {
            try
            {
                FileStream fileStream = File.Open("C:\\Users\\Limited\\Desktop\\Vccs.txt", FileMode.Open);
                fileStream.ToString();
                return "";
            }
            catch (Exception)
            {
                return "";
            }

        }
    }
}
