using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace TheraLang.IntegrationTests
{
    class ContentHelper
    {
        public static StringContent GetStringContent(object obj)
            => new StringContent(JsonConvert.SerializeObject(obj), Encoding.Default, "application/json");
    }
}
