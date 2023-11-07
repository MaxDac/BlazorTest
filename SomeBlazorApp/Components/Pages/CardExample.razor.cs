using SomeBlazorApp.Models;

namespace SomeBlazorApp.Components.Pages;

public partial class CardExample
{
    public FormModel? Model { get; set; }

	public static string? Something { get; private set; }

	protected override async Task OnInitializedAsync()
	{
		await base.OnInitializedAsync();
		
		Model ??= new();

		await Task.Delay(5000);

		Something = "Something else";
	}
	
	private void Submit()
	{
		logger.LogInformation($"The name: {Model?.Name}");
	}
}
