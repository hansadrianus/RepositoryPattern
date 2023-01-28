using Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AutoGenerateNumberService : IAutoGenerateNumberService
    {
        public string GenerateOrderNumber(string type, string lastNumberOfTheDay, int padLeftNum)
        {
            string orderNumber = string.Format("{0}{1}", type, DateTime.UtcNow.ToString("yyyyMMdd"));
            if (string.IsNullOrEmpty(lastNumberOfTheDay))
                return orderNumber + 1.ToString().PadLeft(padLeftNum, '0');

            int newNumber = int.Parse(lastNumberOfTheDay.Substring(lastNumberOfTheDay.Length - padLeftNum)) + 1;
            return orderNumber + newNumber.ToString().PadLeft(padLeftNum, '0');
        }
    }
}
