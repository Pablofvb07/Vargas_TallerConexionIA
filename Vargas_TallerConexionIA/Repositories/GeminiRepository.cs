using Newtonsoft.Json;
using System.Text;
using Vargas_TallerConexionIA.Interfaces;
using Vargas_TallerConexionIA.Models;
using static System.Net.WebRequestMethods;  

namespace Vargas_TallerConexionIA.Repositories
{
    public class GeminiRepository : IChatbotService
    {
        private HttpClient _httpClient;
        private string geminiApiKey = "AIzaSyBZFA1dpLS1DejGK4otzvJCCmf1dgSn6SI";
        public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string>  GetChatbotResponseAsync(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" + geminiApiKey;
            GeminiRequest request= new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts= new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text= prompt
                            }
                        }
                    }
                }
            };
            string requestJson = JsonConvert.SerializeObject(request);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            var answer = await response.Content.ReadAsStringAsync();

            return answer;
        }

        public Task<bool> SaveResponseInDataBase(string chatbotPrompt, string chatbotResponse)
        {
            throw new NotImplementedException();
        }
    }
}
    