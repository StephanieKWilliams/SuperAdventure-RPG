using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Engine
{
    // This is the more complex version
  
        public static class RandomNumberGenerator
        {
            private static Random _generator = new Random();

            public static int NumberBetween(int minimumValue, int maximumValue)
            {
                return _generator.Next(minimumValue, maximumValue + 1);
            }
        }
    


}





