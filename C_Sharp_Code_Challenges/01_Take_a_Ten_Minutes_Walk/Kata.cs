using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Take_a_Ten_Minutes_Walk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if(walk.Length > 10 == false && walk.Length < 10 == false)
            {
                var secondHalfOfJourney = (walk.Length / 2);
                for (int i = 0; i < (walk.Length/2); i++)
                {
                    switch (walk[i])
                    {
                        case "n":
                            if (walk[secondHalfOfJourney] != "s")
                            {
                                return false;
                            }
                            break;
                        case "s":
                            if (walk[secondHalfOfJourney] != "n")
                            {
                                return false;
                            }
                            break;
                        case "e":
                            if (walk[secondHalfOfJourney] != "w")
                            {
                                return false;
                            }
                            break;
                        case "w":
                            if (walk[secondHalfOfJourney] != "e")
                            {
                                return false;
                            }
                            break;
                        default:
                            return false;
                    }
                    secondHalfOfJourney++;

                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
