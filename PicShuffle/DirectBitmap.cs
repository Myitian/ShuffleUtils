using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Myitian.Drawing;

/// <summary>
/// 修改自 https://stackoverflow.com/questions/24701703
/// </summary>
public struct DirectBitmap : IDisposable
{
    public readonly int[] Bits;
    public readonly int Height;
    public readonly int Width;
    public readonly Bitmap Bitmap;

    private readonly GCHandle BitsHandle;
    public bool Disposed { get; private set; }

    public DirectBitmap(Bitmap src)
    {
        Width = src.Width;
        Height = src.Height;
        Bits = GC.AllocateUninitializedArray<int>(Width * Height, true);
        BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
        Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppArgb, BitsHandle.AddrOfPinnedObject());

        BitmapData srcL = src.LockBits(Rectangle.FromLTRB(0, 0, Width, Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
        Marshal.Copy(srcL.Scan0, Bits, 0, Bits.Length);
        src.UnlockBits(srcL);
    }
    public void Dispose()
    {
        if (Disposed) return;
        Disposed = true;
        Bitmap.Dispose();
        BitsHandle.Free();
    }
}
