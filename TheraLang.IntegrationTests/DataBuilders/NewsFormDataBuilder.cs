using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TheraLang.IntegrationTests.DataBuilders
{
    public class NewsFormDataBuilder : FormDataBuilder
    {
        public NewsFormDataBuilder WithDefaultTitle()
        {
            WithField(new StringContent("Hello World!"), "Title");
            return this;
        }

        public NewsFormDataBuilder WithDefaultText()
        {
            WithField(new StringContent("Hello World!"), "Text");
            return this;
        }

        public NewsFormDataBuilder WithDefaultImage(string fieldName)
        {
            var filePath = Path.GetFullPath(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                "../../../../TheraLang.Web/ClientApp/src/assets/img/uttmm.png"));
            StreamContent file1 = new StreamContent(File.OpenRead(filePath));

            file1.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");
            file1.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
            file1.Headers.ContentDisposition.Name = fieldName;
            file1.Headers.ContentDisposition.FileName = "uttmm.png";
            WithField(file1);

            return this;
        }
    }
}
