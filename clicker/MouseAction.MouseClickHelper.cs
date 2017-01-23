﻿namespace Clicker
{
  public partial class MouseAction
  {
    /// <summary>
    /// Contains function for calling mouse clicks through the Windows API.
    /// 
    /// http://stackoverflow.com/questions/8272681/how-can-i-simulate-a-mouse-click-at-a-certain-position-on-the-screen
    /// </summary>
    static class MouseClickHelper
    {
      [System.Runtime.InteropServices.DllImport("user32.dll")]
      static public extern bool SetCursorPos(int x, int y);

      [System.Runtime.InteropServices.DllImport("user32.dll")]
      public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

      public const int MOUSEEVENTF_LEFTDOWN = 0x02;
      public const int MOUSEEVENTF_LEFTUP = 0x04;
    }
  }
}
