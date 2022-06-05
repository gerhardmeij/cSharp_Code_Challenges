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
                var northWalkProgress = 0;
                var southWalkProgress = 0;
                var eastWalkProgress = 0;
                var westWalkProgress = 0;

                for (int i = 0; i < walk.Length; i++)
                {
                    switch (walk[i])
                    {
                        case "n":
                            northWalkProgress++;
                            break;
                        case "s":
                            southWalkProgress++;
                            break;
                        case "e":
                            eastWalkProgress++;
                            break;
                        case "w":
                            westWalkProgress++;
                            break;
                        default:
                            return false;
                    }
                }
                if (northWalkProgress == southWalkProgress && eastWalkProgress == westWalkProgress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
