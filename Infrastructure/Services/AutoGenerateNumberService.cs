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
        public string GenerateCode(string type, string lastNumber, int padLeftNum)
        {
            string code = type.Substring(0, 4).Trim();
            if (string.IsNullOrEmpty(lastNumber))
                return code + 1.ToString().PadLeft(padLeftNum, '0');

            int newNumber = int.Parse(lastNumber.Substring(lastNumber.Length - padLeftNum)) + 1;
            return (code + newNumber.ToString().PadLeft(padLeftNum, '0')).ToUpper();
        }

        public string GenerateOrderNumber(string type, string lastNumberOfTheDay, int padLeftNum)
        {
            string orderNumber = string.Format("{0}{1}", type, DateTime.UtcNow.ToString("yyyyMMdd"));
            if (string.IsNullOrEmpty(lastNumberOfTheDay) && lastNumberOfTheDay.Contains(DateTime.UtcNow.ToString("yyyyMMdd")))
                return orderNumber + 1.ToString().PadLeft(padLeftNum, '0');

            int newNumber = int.Parse(lastNumberOfTheDay.Substring(lastNumberOfTheDay.Length - padLeftNum)) + 1;
            return (orderNumber + newNumber.ToString().PadLeft(padLeftNum, '0')).ToUpper();
        }
    }
}
