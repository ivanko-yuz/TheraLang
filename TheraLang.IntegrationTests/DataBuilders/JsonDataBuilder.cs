using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace TheraLang.IntegrationTests.DataBuilders
{
    class JsonDataBuilder : IDataBuilder<StringContent>
    {
        private Dictionary<string, string> _content;

        public JsonDataBuilder()
        {
            _content = new Dictionary<string, string>();
        }

        public StringContent Build()
        {
            var request = JsonConvert.SerializeObject(_content);
            return new StringContent(request, Encoding.UTF8, "application/json");
        }

        public JsonDataBuilder WithField(string key, string value)
        {
            _content.Add(key, value);
            return this;
        }
    }
}
