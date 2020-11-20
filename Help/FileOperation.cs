using System.Windows.Forms;
namespace HelpClass
{
    public static class FileOperation
    {
        public static string FolderPath()
        {
            FolderBrowserDialog _folder = new FolderBrowserDialog();
            DialogResult result = _folder.ShowDialog();
            string _folderPath = string.Empty;
            if (result == DialogResult.OK)
            {
                _folderPath = _folder.SelectedPath;
            }
            return _folderPath;
        }
        public static string FilePath(string filter=null)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }
    }
  
}
