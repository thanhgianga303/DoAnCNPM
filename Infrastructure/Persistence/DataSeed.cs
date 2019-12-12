using System;
using System.Linq;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence
{
    public class DataSeed
    {
        public static void Initialize(HeThongQuanLyVPGTContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}