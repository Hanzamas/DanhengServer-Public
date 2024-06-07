﻿using Newtonsoft.Json;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Database
{
    public class CustomSerializeService : ISerializeService
    {
        private JsonSerializerSettings _jsonSettings;

        public CustomSerializeService()
        {
            _jsonSettings = new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore  // ignore default values
            };
        }

        public string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value, _jsonSettings);
        }

        public T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value)!;
        }

        public string SugarSerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value, _jsonSettings);
        }
    }
}
