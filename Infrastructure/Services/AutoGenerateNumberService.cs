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
            string code = type.Replace(" ", "");
            if (string.IsNullOrEmpty(lastNumber))
                return (code + 1.ToString().PadLeft(padLeftNum, '0')).ToUpper();

            int newNumber = int.Parse(lastNumber.Substring(lastNumber.Length - padLeftNum)) + 1;
            return (code + newNumber.ToString().PadLeft(padLeftNum, '0')).ToUpper();
        }

        public string GenerateOrderNumber(string type, string lastNumberOfTheDay, int padLeftNum)
        {
            string orderNumber = string.Format("{0}{1}", type.Replace(" ",""), DateTime.UtcNow.ToString("yyyyMMdd"));
            if (string.IsNullOrEmpty(lastNumberOfTheDay))
                return (orderNumber + 1.ToString().PadLeft(padLeftNum, '0')).ToUpper();

            int newNumber = int.Parse(lastNumberOfTheDay.Substring(lastNumberOfTheDay.Length - padLeftNum)) + 1;
            return (orderNumber + newNumber.ToString().PadLeft(padLeftNum, '0')).ToUpper();
        }
    }
}
