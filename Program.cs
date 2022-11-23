using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[DllImport("gdi32.dll")]
static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
{ 
        IntPtr hdc = g.GetHdc();
        int resultW = GetDeviceCaps(hdc, 4); //Длина экрана
        int resultH = GetDeviceCaps(hdc, 6); //Ширина экрана
        g.ReleaseHdc();
        int resultDiag = (int)((Math.Sqrt(Math.Pow(resultW, 2) + Math.Pow(resultH, 2)))/ 25.4);
        Console.WriteLine($"Диагональ монитора: {resultDiag} дюйма");
}


