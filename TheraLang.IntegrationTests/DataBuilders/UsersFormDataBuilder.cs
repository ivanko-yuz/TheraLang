using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TheraLang.IntegrationTests.DataBuilders
{
   public class UsersFormDataBuilder: FormDataBuilder
    {
        public UsersFormDataBuilder WithDefaultFirstName()
        {
            WithField(new StringContent("Andriana"), "FirstName");
            return this;
        }
        public UsersFormDataBuilder WithDefaultLastName()
        {
            WithField(new StringContent("Baran"), "LastName");
            return this;
        }

        public UsersFormDataBuilder WithDefaultEmail()
        {
            WithField(new StringContent("newmail@gmail.com"), "Email");
            return this;
        }

        public UsersFormDataBuilder WithDefaultPassword()
        {
            WithField(new StringContent("password"), "Password");
            return this;
        }
        public UsersFormDataBuilder WithDefaultConfirmPassword()
        {
            WithField(new StringContent("password"), "ConfirmPassword");
            return this;
        }

        public UsersFormDataBuilder WithDefaultImage(string fieldName)
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
