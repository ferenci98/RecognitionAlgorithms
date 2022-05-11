using Microsoft.AspNetCore.Components.Forms;

namespace Client.Pages
{
    public partial class RecognitionView
    {
        private IBrowserFile _loadedFile;
        private bool _isLoading;

        private void LoadFiles(InputFileChangeEventArgs e)
        {
            _isLoading = true;
            StateHasChanged();

            _loadedFile = e.File;

            _isLoading = false;
            StateHasChanged();
        }

    }
}

