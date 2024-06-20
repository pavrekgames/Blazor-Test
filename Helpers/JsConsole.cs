using Microsoft.JSInterop;

namespace BlazorLearning.Helpers
{
	public class JsConsole
	{

		private readonly IJSRuntime jSRuntime;
		public JsConsole(IJSRuntime jSRuntime)
		{
			this.jSRuntime = jSRuntime;
		}

		public async Task LogAsync(string message)
		{
			await jSRuntime.InvokeVoidAsync("console.log", message);
		}

	}
}
