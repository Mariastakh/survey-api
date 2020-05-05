using Microsoft.AspNetCore.Hosting;

namespace api
{
    public class LambdaEntryPoint : Amazon.Lambda.AspNetCoreServer.APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder webBuilder)
        {
            webBuilder.UseStartup<Startup>();
        }
    }
}