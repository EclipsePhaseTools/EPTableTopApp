﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EPTabletopApp.Models
{
    public class StatBlockTemplate
    {
        public string TemplateName { get; set; }
        public string TemplateType { get; set; }
        public string Template { get; set; }
    }
}
