using Commons.Dlls;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RecursiveDescentParserGenerator.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="Bitmap"/> objects.
    /// </summary>
    public static class BitmapExtensions
    {
        #region Public functions

        /// <summary>
        /// Converts a <see cref="Bitmap"/> to an <see cref="ImageSource"/>.
        /// </summary>
        /// <param name="bmp">The <see cref="Bitmap"/> to convert.</param>
        /// <returns>An <see cref="ImageSource"/> representation of the <see cref="Bitmap"/>.</returns>
        /// <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the conversion fails.</exception>
        public static ImageSource ToImageSource(this Bitmap bmp)
        {
            // Get a handle to the GDI bitmap object
            nint handle = bmp.GetHbitmap();
            try
            {
                // Create a BitmapSource from the GDI bitmap handle
                return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                // Release the GDI bitmap handle
                Gdi32.DeleteObject(handle);
            }
        }

        #endregion
    }
}
