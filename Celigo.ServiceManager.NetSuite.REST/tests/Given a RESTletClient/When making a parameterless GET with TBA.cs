using FakeItEasy;
using FluentAssertions;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace _.Given_a_RestletClient
{
    public class When_making_a_parameterless_GET: GivenRestletClient
    {
        [Fact]
        public async Task It_invokes_the_RESTlet_hosted_in_the_target_account()
        {
            var response = await this.Client.Get("TSTDRV12345", "DUMMYTKN", "DUMMYTKNSEC");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            
            A.CallTo(() => this.MessageHandler.SendAsync(
                                A<HttpRequestMessage>.That.Matches(m => IsExpectedOAuthRequest(m, ExpectedBasePath)), 
                                A<CancellationToken>.Ignored)
            ).MustHaveHappenedOnceExactly();
        }
    }
}