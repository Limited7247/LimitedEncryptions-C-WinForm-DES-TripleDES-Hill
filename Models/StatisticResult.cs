using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedEncryptions.Models
{
    public class StatisticResult
    {
        public int PlaintTextIndex { get; set; }
        public int KeyIndex { get; set; }
        public long Time { get; set; }

        public StatisticResult()
        {

        }

        public StatisticResult(int plaintTextIndex, int keyIndex, long time)
        {
            PlaintTextIndex = plaintTextIndex;
            KeyIndex = keyIndex;
            Time = time;
        }

        public override string ToString()
        {
            return PlaintTextIndex + " " + KeyIndex + " " + Time + " Ticks";
        }
    }
}
