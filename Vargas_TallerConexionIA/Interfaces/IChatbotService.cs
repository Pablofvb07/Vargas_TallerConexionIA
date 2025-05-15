namespace Vargas_TallerConexionIA.Interfaces
{
    public interface IChatbotService
    {
        public Task<string> GetChatbotResponseAsync(string prompt);
        public Task<Boolean> SaveResponseInDataBase(string chatbotPrompt, string chatbotResponse);
    }
}
