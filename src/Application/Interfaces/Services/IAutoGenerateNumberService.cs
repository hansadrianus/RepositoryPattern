namespace Application.Interfaces.Services
{
    public interface IAutoGenerateNumberService
    {
        string GenerateCode(string type, string lastNumber, int padLeftNum);
        string GenerateCodeWithUtcDate(string type, string lastNumberOfTheDay, int padLeftNum);
    }
}