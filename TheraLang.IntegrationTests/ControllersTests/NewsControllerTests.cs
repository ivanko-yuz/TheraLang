using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheraLang.Web.ViewModels.NewsViewModels;
using Xunit;

namespace TheraLang.IntegrationTests
{
    public class NewsControllerTests : IClassFixture<TestFixture>
    {
        private HttpClient _client;

        public NewsControllerTests(TestFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task GetAll_SuccessStatusCode()
        {
            // Arrange
            var request = "/api/news/all";

            // Act
            var response = await _client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetById_SuccessStatusCode()
        {
            // Arrange
            var request = "/api/news/1";

            // Act
            var response = await _client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Post_SuccessStatusCode()
        {
            // Arrange
            MultipartFormDataContent formDataContent = new MultipartFormDataContent();
            formDataContent.Add(new StringContent("Hello World!"), name: "Title");
            formDataContent.Add(new StringContent("Hello World!"), name: "Text");
            StreamContent file1 = new StreamContent(File.OpenRead(@"C:\Users\AndreyLakusta\Downloads\4_main.jpg"));
            file1.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");
            file1.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
            file1.Headers.ContentDisposition.Name = "MainImage";
            file1.Headers.ContentDisposition.FileName = "4_main.jpg";
            formDataContent.Add(file1);
            
            // Act
            var response = await _client.PostAsync("api/news", formDataContent);
            var value = await response.Content.ReadAsStringAsync();
            //response = await _client.GetAsync("/api/news/all");

            // Assert
            response.EnsureSuccessStatusCode();
        }

        //[Fact]
        //public async Task TestPutStockItemAsync()
        //{
        //    // Arrange
        //    var request = new
        //    {
        //        Url = "/api/v1/Warehouse/StockItem/1",
        //        Body = new
        //        {
        //            StockItemName = string.Format("USB anime flash drive - Vegeta {0}", Guid.NewGuid()),
        //            SupplierID = 12,
        //            Color = 3,
        //            UnitPrice = 39.00m
        //        }
        //    };

        //    // Act
        //    var response = await Client.PutAsync(request.Url, ContentHelper.GetStringContent(request.Body));

        //    // Assert
        //    response.EnsureSuccessStatusCode();
        //}

        //[Fact]
        //public async Task TestDeleteStockItemAsync()
        //{
        //    // Arrange

        //    var postRequest = new
        //    {
        //        Url = "/api/v1/Warehouse/StockItem",
        //        Body = new
        //        {
        //            StockItemName = string.Format("Product to delete {0}", Guid.NewGuid()),
        //            SupplierID = 12,
        //            UnitPackageID = 7,
        //            OuterPackageID = 7,
        //            LeadTimeDays = 14,
        //            QuantityPerOuter = 1,
        //            IsChillerStock = false,
        //            TaxRate = 10.000m,
        //            UnitPrice = 10.00m,
        //            RecommendedRetailPrice = 47.84m,
        //            TypicalWeightPerUnit = 0.050m,
        //            CustomFields = "{ \"CountryOfManufacture\": \"USA\", \"Tags\": [\"Sample\"] }",
        //            Tags = "[\"Sample\"]",
        //            SearchDetails = "Product to delete",
        //            LastEditedBy = 1,
        //            ValidFrom = DateTime.Now,
        //            ValidTo = DateTime.Now.AddYears(5)
        //        }
        //    };

        //    // Act
        //    var postResponse = await Client.PostAsync(postRequest.Url, ContentHelper.GetStringContent(postRequest.Body));
        //    var jsonFromPostResponse = await postResponse.Content.ReadAsStringAsync();

        //    var singleResponse = JsonConvert.DeserializeObject<SingleResponse<StockItem>>(jsonFromPostResponse);

        //    var deleteResponse = await Client.DeleteAsync(string.Format("/api/v1/Warehouse/StockItem/{0}", singleResponse.Model.StockItemID));

        //    // Assert
        //    postResponse.EnsureSuccessStatusCode();

        //    Assert.False(singleResponse.DidError);

        //    deleteResponse.EnsureSuccessStatusCode();
        //}
    }
}
