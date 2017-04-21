﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace Microservices.Services.Todo.Api.Models
{
    public class CardEntity : TableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorEmail { get; set; }
    }
}
