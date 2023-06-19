using Alba;
using BusinessClockApi.Models;
using System.Net;

namespace BusinessClock.IntegrationTests.Status;

public class GettingTheStatus
{
    //[Fact]
    //public async Task OpenHours()
    //{
    //    HttpClient client = new HttpClient();
    //    client.BaseAddress = new Uri("http://localhost:1337");

    //    HttpResponseMessage response = await client.GetAsync("/status");

    //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    //}

    [Fact]
    public async Task OpenHours()
    {
        var host = await AlbaHost.For<Program>();

        var response = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });

        Assert.NotNull(response); // did we get something back?
        GetStatusResponse? responseMessage = response.ReadAsJson<GetStatusResponse>();
        Assert.NotNull(responseMessage);
        Assert.True(responseMessage.Open);
        Assert.Null(responseMessage.OpensAt);
    }

    [Fact]
    public async Task ClosedHours()
    {
        var host = await AlbaHost.For<Program>();

        var response = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });

        Assert.NotNull(response); // did we get something back?
        GetStatusResponse? responseMessage = response.ReadAsJson<GetStatusResponse>();
        Assert.NotNull(responseMessage);
        Assert.False(responseMessage.Open);
        Assert.NotNull(responseMessage.OpensAt);
    }
}
