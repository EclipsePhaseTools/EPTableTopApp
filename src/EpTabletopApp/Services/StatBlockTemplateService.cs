﻿using EPTabletopApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EPTabletopApp.Services
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
