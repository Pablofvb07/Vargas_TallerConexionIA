using Vargas_TallerConexionIA.Interfaces;

namespace Vargas_TallerConexionIA.Repositories
{
    public class OpenAIRepository : IChatbotService
    {
        public Task<string> GetChatbotResponseAsync(string prompt)
        {

            throw new NotImplementedException();
        }

        public Task<bool> SaveResponseInDataBase(string chatbotPrompt, string chatbotResponse)
        {
            throw new NotImplementedException();
        }
    }
}
