using Bunit;
using Microsoft.Extensions.DependencyInjection;
using IgApplication.Pages;
using IgApplication.Northwind;
using IgApplication.Financial;

namespace TestIgApplication
{
	[Collection("IgApplication")]
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbFinancialChartModule),
				typeof(IgbCategoryChartModule),
				typeof(IgbCalendarModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
