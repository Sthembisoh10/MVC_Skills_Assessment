using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Skills_A.Models
{
    public class Random
    {

        public static string GenerateRandomID()
        {
            Random random = new Random();
            return "ID" + random.Next(1000, 9999).ToString();
        }

        private object Next(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}