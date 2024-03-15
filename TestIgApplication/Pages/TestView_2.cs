using Bunit;
using Microsoft.Extensions.DependencyInjection;
using IgApplication.Pages;
using IgApplication.Northwind;

namespace TestIgApplication
{
	[Collection("IgApplication")]
	public class TestView_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<View_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
