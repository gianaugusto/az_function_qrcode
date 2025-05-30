using System.Net;
using System.Threading.Tasks;
using az_function_qrcode.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace az_function_qrcode
{
    public class az_function_qrcode
    {
        private readonly ILogger<az_function_qrcode> _logger;

        public az_function_qrcode(ILogger<az_function_qrcode> log)
        {
            _logger = log;
        }

        [FunctionName("az_function_qrcode")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "content" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code",
            In = OpenApiSecurityLocationType.Query)]
        [OpenApiParameter(name: "content", In = ParameterLocation.Query, Required = true, Type = typeof(string),
            Description = "The **content** parameter")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string),
            Description = "The OK response")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request to generate new qrcode.");

            string content = req.Query["content"];
            var qrCodeBase64 = QrCode.GenerateQrCodeBase64(content ?? "Teste 123");

            return new OkObjectResult($"data:image/png;base64,{qrCodeBase64}");
        }
    }
}