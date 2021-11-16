using System;
using System.Runtime.InteropServices;

namespace Win32Api
{
    public static partial class Shell32
    {
        #region Public Methods

        [DllImport(AssemblyName, CharSet = CharSet.Auto)]
        public static extern uint ExtractIconEx(string szFileName, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

        #endregion
    }
}
