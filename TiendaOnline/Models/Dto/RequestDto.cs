﻿using Microsoft.AspNetCore.Mvc;
using static TiendaOnline.Utility.Utilities;

namespace TiendaOnline.Models.Dto
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
        public ContentType ContentType { get; set; } = ContentType.Json; 
    }
}
