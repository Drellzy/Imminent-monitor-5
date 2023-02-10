// Decompiled with JetBrains decompiler
// Type: GControl6
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Windows.Forms;

public sealed class GControl6 : TabControl
{
  public GControl6() => this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 4904)
      m.Result = IntPtr.Zero;
    else
      base.WndProc(ref m);
  }
}
