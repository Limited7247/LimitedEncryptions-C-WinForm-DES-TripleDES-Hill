using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedEncryptions.Models
{
    public class AverageStatisticResult
    {
        public int Key { get; set; }
        public long AverageTicks { get; set; }

        public AverageStatisticResult(int key, long averageTicks)
        {
            Key = key;
            AverageTicks = averageTicks;
        }

        public AverageStatisticResult(int key, int index, List<StatisticResult> list)
        {
            this.Key = key;
            AverageTicks = 0;
            foreach (var item in list)
            {
                if (index == 1)
                {
                    if (item.KeyIndex == key) AverageTicks += item.Time;
                }
                else
                {
                    if (item.PlaintTextIndex == key) AverageTicks += item.Time;
                }
            }
            AverageTicks = AverageTicks / list.Count;
        }

        public override string ToString()
        {
            return Key.ToString() + '\t' + AverageTicks.ToString() + " Ticks";
        }
    }
}
