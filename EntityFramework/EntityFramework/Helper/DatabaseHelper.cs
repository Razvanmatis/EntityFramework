using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Helper
{
    public static class DatabaseHelper
    {
        private static FitnessDatabase ctx = new FitnessDatabase();

        public static void SaveMember(string prename)
        { 
            ctx.Members.Add(new Member() { Prename=prename });
            ctx.SaveChanges();
        }
    }
}
