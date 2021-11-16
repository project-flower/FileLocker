using FileLocker.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Win32Api;

namespace FileLocker
{
    public partial class FormMain : Form
    {
        #region Private Classes

        private delegate void Operation<T>(T item);

        #endregion

        #region Private Fields

        private readonly List<FileItem> files = new List<FileItem>();

        #endregion

        #region Public Methods

        public FormMain()
        {
            InitializeComponent();
            MinimumSize = Size;
        }

        #endregion

        #region Private Methods

        private void AddItems(string item)
        {
            var newItem = new FileItem(item);
            files.Add(newItem);
            ++listViewFiles.VirtualListSize;

            if (checkBoxImmediately.Checked)
            {
                newItem.Lock(GetFileShare());
            }
        }

        private void DestroyIcons(IntPtr[] pointers)
        {
            foreach (IntPtr pointer in pointers)
            {
                if (pointer != IntPtr.Zero)
                {
                    User32.DestroyIcon(pointer);
                }
            }
        }

        private FileShare GetFileShare()
        {
            FileShare result = FileShare.None;

            if (!(checkBoxRead.Checked))
            {
                result |= FileShare.Read;
            }

            if (!(checkBoxWrite.Checked))
            {
                result |= FileShare.Write;
            }

            if (!(checkBoxDelete.Checked))
            {
                result |= FileShare.Delete;
            }

            return result;
        }

        private void LoadIcon()
        {
            Settings settings;

            try
            {
                settings = Settings.Default;
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
                return;
            }

            var largeIconHandles = new IntPtr[1] { IntPtr.Zero };
            var smallIconHandles = new IntPtr[1] { IntPtr.Zero };

            try
            {
                Shell32.ExtractIconEx(settings.LibraryOfIconLocked, settings.IconIndexOfLocked, largeIconHandles, smallIconHandles, 1);
                imageList.Images.Add(System.Drawing.Icon.FromHandle(smallIconHandles[0]));
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
            }
            finally
            {
                DestroyIcons(largeIconHandles);
                DestroyIcons(smallIconHandles);
            }
        }

        private void OperateSelectedFiles(Operation<FileItem> operation)
        {
            ListView.SelectedIndexCollection indices = listViewFiles.SelectedIndices;
            var items = new FileItem[indices.Count];

            for (int i = 0; i < items.Length; ++i)
            {
                items[i] = files[indices[i]];
            }

            Repeat(items, operation);
        }

        private void Repeat<T>(T[] items, Operation<T> operation)
        {
            bool ignore = false;
            listViewFiles.BeginUpdate();

            try
            {
                foreach (T item in items)
                {
                    try
                    {
                        operation(item);
                    }
                    catch (Exception exception)
                    {
                        if (ignore)
                        {
                            continue;
                        }

                        DialogResult result = ShowErrorMessage($"{exception.Message}\r\n\r\nDo you want to ignore the error after this?", MessageBoxButtons.YesNoCancel);

                        switch (result)
                        {

                            case DialogResult.Yes:
                                ignore = true;
                                continue;

                            case DialogResult.No:
                                continue;

                            case DialogResult.Cancel:
                                break;
                        }

                        break;
                    }
                }
            }
            finally
            {
                listViewFiles.EndUpdate();
            }
        }

        private DialogResult ShowErrorMessage(string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(this, message, Text, buttons, MessageBoxIcon.Error);
        }

        #endregion

        // Designer's Methods

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            Repeat(openFileDialog.FileNames, AddItems);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewFiles.BeginUpdate();

            try
            {
                files.ForEach(f => f.Release());
                files.Clear();
                listViewFiles.VirtualListSize = 0;
            }
            finally
            {
                listViewFiles.EndUpdate();
            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            FileShare fileShare = GetFileShare();
            OperateSelectedFiles(f => f.Lock(fileShare));
        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            OperateSelectedFiles(f => f.Release());
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = listViewFiles.SelectedIndices;
            var selectedFileItems = new FileItem[indices.Count];

            for (int i = 0; i < selectedFileItems.Length; ++i)
            {
                selectedFileItems[i] = files[indices[i]];
            }

            listViewFiles.BeginUpdate();

            try
            {
                foreach (FileItem item in selectedFileItems)
                {
                    try
                    {
                        item.Release();
                    }
                    catch
                    {
                    }

                    if (files.Remove(item))
                    {
                        --listViewFiles.VirtualListSize;
                    }
                }
            }
            finally
            {
                listViewFiles.EndUpdate();
            }
        }

        private void listViewFiles_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (data == null)
            {
                return;
            }

            Repeat(data, AddItems);
        }

        private void listViewFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void listViewFiles_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            FileItem fileItem = files[e.ItemIndex];

            var item = new ListViewItem()
            {
                ImageIndex = (fileItem.Locked ? 0 : -1),
                Name = fileItem.FileName,
                Text = fileItem.FileName
            };

            item.SubItems.Add(fileItem.Path);
            e.Item = item;
        }

        private void shown(object sender, EventArgs e)
        {
            LoadIcon();
        }
    }
}
