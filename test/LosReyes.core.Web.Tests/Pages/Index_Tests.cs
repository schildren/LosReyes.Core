using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LosReyes.core.Pages
{
    public class Index_Tests : coreWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
