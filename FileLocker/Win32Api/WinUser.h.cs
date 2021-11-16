using System;
using System.Runtime.InteropServices;

namespace Win32Api
{
    public static partial class User32
    {
        #region Public Methods

        [DllImport(AssemblyName, SetLastError = true)]
        public static extern bool DestroyIcon(IntPtr hIcon);

        #endregion
    }
}
