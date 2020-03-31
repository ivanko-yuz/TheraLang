using System.Net.Http;

namespace TheraLang.IntegrationTests.DataBuilders
{
    public class FormDataBuilder : IDataBuilder<MultipartFormDataContent>
    {
        private MultipartFormDataContent _formDataContent;

        public FormDataBuilder()
        {
            _formDataContent = new MultipartFormDataContent();
        }

        public MultipartFormDataContent Build()
        {
            return _formDataContent;
        }

        public FormDataBuilder WithField(HttpContent content, string fieldName)
        {
            _formDataContent.Add(content, fieldName);
            return this;
        }

        public FormDataBuilder WithField(HttpContent content)
        {
            _formDataContent.Add(content);
            return this;
        }
    }
}
