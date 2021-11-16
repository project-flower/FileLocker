using System;
using System.IO;

namespace FileLocker
{
    public class FileItem : IDisposable
    {
        #region Private Fields

        private string fullName = string.Empty;
        private bool locked = false;
        private FileStream stream = null;

        #endregion

        #region Public Properties

        public string FileName { get; }
        public bool Locked { get { return locked; } }
        public string Path { get; }

        #endregion

        #region Public Methods

        public FileItem(string fileName)
        {
            fullName = fileName;
            var fileInfo = new FileInfo(fullName);

            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException($"The file '{fullName}' was not found.", fullName);
            }

            FileName = fileInfo.Name;
            Path = fileInfo.DirectoryName;
        }

        public void Dispose()
        {
            try
            {
                Release();
            }
            catch
            {
            }
        }

        public void Lock(FileShare fileShare = FileShare.None)
        {
            if (stream != null)
            {
                return;
            }

            stream = new FileStream(fullName, FileMode.Open, FileAccess.Read, fileShare);
            locked = true;
        }

        public void Release()
        {
            if (stream == null)
            {
                return;
            }

            stream.Dispose();
            stream = null;
            locked = false;
        }

        #endregion
    }
}
