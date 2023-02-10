// Decompiled with JetBrains decompiler
// Type: GControl1
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Drawing;
using System.Windows.Forms;

public sealed class GControl1 : Control
{
  private GControl1.GEnum0 genum0_0;
  private Color color_0;

  public GControl1()
  {
    this.color_0 = Color.LightGray;
    this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
  }

  public GControl1.GEnum0 method_0() => this.genum0_0;

  public void method_1(GControl1.GEnum0 genum0_1)
  {
    this.genum0_0 = genum0_1;
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Bitmap bitmap = new Bitmap(this.Width, this.Height);
    Graphics graphics = Graphics.FromImage((Image) bitmap);
    switch (this.method_0())
    {
      case (GControl1.GEnum0) 0:
        graphics.DrawLine(Class141.smethod_9(this.color_0), new Point(this.Width / 2 + 1, 0), new Point(this.Width / 2 + 1, this.Height));
        break;
      case (GControl1.GEnum0) 1:
        graphics.DrawLine(Class141.smethod_9(this.color_0), new Point(0, this.Height / 2 + 1), new Point(this.Width, this.Height / 2 + 1));
        break;
    }
    e.Graphics.DrawImage((Image) bitmap, 0, 0);
    graphics.Dispose();
    bitmap.Dispose();
  }

  public enum GEnum0
  {
  }
}
