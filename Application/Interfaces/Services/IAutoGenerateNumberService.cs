namespace Application.Interfaces.Services
{
    public interface IAutoGenerateNumberService
    {
        string GenerateOrderNumber(string type, string lastNumberOfTheDay, int padLeftNum);
    }
}