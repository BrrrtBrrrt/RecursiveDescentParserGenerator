using System;
using System.Runtime.InteropServices;

namespace Commons.Dlls
{
    /// <summary>
    /// Provides P/Invoke signatures for GDI (Graphics Device Interface) functions from gdi32.dll.
    /// </summary>
    public static partial class Gdi32
    {
        /// <summary>
        /// Deletes a GDI object.
        /// </summary>
        /// <param name="hObject">A handle to the GDI object to be deleted.</param>
        /// <returns>
        /// <c>true</c> if the object is deleted successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// GDI objects include pens, brushes, fonts, bitmaps, regions, or palettes.
        /// This method should be called to free resources allocated to these objects.
        /// </remarks>
        [LibraryImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool DeleteObject(IntPtr hObject);
    }
}
