using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;

namespace Client.Pages
{
	public partial class RecognitionView
	{
        private List<IBrowserFile> loadedFiles = new();
        private bool isLoading;

        private void LoadFiles(InputFileChangeEventArgs e)
        {
            isLoading = true;
            StateHasChanged();

            loadedFiles.Clear();

            foreach (var file in e.GetMultipleFiles(5))
            {
                try
                {
                    loadedFiles.Add(file);
                }
                catch (Exception ex)
                {
               
                }
            }

            isLoading = false;
            StateHasChanged();
        }

    }
}

