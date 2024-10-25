using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadFishKata
{
    public class DeadFish
    {
        public static int[] Parse(string data)
        {
            var value = 0;
            var outcome = new List<int>();
            foreach(var command in data)
            {
                switch (command)
                {
                    case 'i':
                        value++;
                        break;
                    case 'd':
                        value--;
                        break;
                    case 's':
                        value *= value;
                        break;
                    case 'o':
                        outcome.Add(value);
                        break;
                    default:
                        throw new Exception("that wasn't a valid command");
                }
            }

            return outcome.ToArray();
        }
    }
}
