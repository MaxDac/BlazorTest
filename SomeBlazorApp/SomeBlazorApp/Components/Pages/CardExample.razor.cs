
namespace SomeBlazorApp.Components.Pages;

public partial class CardExample
{
	public static string? Something { get; private set; }

	protected override async Task OnInitializedAsync()
	{
		await base.OnInitializedAsync();

		await Task.Delay(1000);

		Something = "Something else";
	}
}
