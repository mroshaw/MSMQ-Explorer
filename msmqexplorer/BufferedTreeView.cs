#region

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace MSMQExplorer
{
    internal class BufferedTreeView : TreeView
    {
        // Pinvoke:
        private const int TvmSetextendedstyle = 0x1100 + 44;
        private const int TvsExDoublebuffer = 0x0004;

        protected override void OnHandleCreated(EventArgs e)
        {
            SendMessage(Handle, TvmSetextendedstyle, (IntPtr) TvsExDoublebuffer, (IntPtr) TvsExDoublebuffer);
            base.OnHandleCreated(e);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}