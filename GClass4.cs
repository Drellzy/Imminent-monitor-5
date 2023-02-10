// Decompiled with JetBrains decompiler
// Type: GClass4
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public sealed class GClass4 : MenuStrip
{
  public GClass4()
  {
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    this.AutoSize = true;
    this.Dock = DockStyle.None;
    this.Anchor = AnchorStyles.None;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.White, LinearGradientMode.Vertical);
    e.Graphics.FillRectangle((Brush) linearGradientBrush, this.ClientRectangle);
    e.Graphics.DrawRectangle(Pens.DarkGray, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
    base.OnPaint(e);
  }
}
