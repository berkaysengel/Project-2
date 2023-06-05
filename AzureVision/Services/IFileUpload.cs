using BlazorInputFile;
namespace AzureVision.Services
{
    public interface IFileUpload
    {
        Task UploadFile(IFileListEntry file);
    }
}
