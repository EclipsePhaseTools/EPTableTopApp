using EPTools.Models;

namespace EPTools.Services
{
    public class StatBlockTemplateService
    {
        private FetchService FetchService { get; set; }
        public StatBlockTemplateService(FetchService fetchService)
        {
            this.FetchService = fetchService;
        }

        public async Task<List<StatBlockTemplate>> GetStatBlockTemplates()
        {
            return await FetchService.GetTFromFileAsync<List<StatBlockTemplate>>("StatBlockTemplates");
        }
    }
}
