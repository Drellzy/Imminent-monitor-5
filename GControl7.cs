// Decompiled with JetBrains decompiler
// Type: GControl7
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public sealed class GControl7 : Control
{
  public GControl7()
  {
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    this.Size = new Size(new Point(395, 40));
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(228, 228, 228), Color.White, LinearGradientMode.Vertical);
    e.Graphics.FillRectangle((Brush) linearGradientBrush, this.ClientRectangle);
    e.Graphics.DrawLine(Pens.Gray, new Point(9, this.Height / 2 + 1 - 1), new Point(18, this.Height / 2 + 1 - 1));
    e.Graphics.DrawRectangle(Pens.DarkGray, 0, -1, this.Size.Width - 1, this.Size.Height);
    base.OnPaint(e);
  }
}
