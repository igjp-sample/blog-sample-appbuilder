using Bunit;
using Microsoft.Extensions.DependencyInjection;
using IgApplication.Pages;
using IgApplication.Financial;
using IgApplication.Northwind;

namespace TestIgApplication
{
	[Collection("IgApplication")]
	public class TestView_3
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbFinancialChartModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<View_3>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
