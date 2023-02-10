// Decompiled with JetBrains decompiler
// Type: GControl4
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public sealed class GControl4 : Control
{
  private Color color_0;
  private StringFormat stringFormat_0;
  private bool bool_0;
  private bool bool_1;
  private string string_0;

  public GControl4()
  {
    this.color_0 = Color.FromArgb(65, 131, 215);
    this.stringFormat_0 = new StringFormat()
    {
      LineAlignment = StringAlignment.Center,
      Alignment = StringAlignment.Center
    };
    this.bool_0 = false;
    this.bool_1 = false;
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;
    this.method_0(graphics);
    graphics.DrawString(this.Text, this.Font, Brushes.White, (RectangleF) new Rectangle(0, 0, this.Size.Width, this.Size.Height), this.stringFormat_0);
    if (Operators.CompareString(this.method_1(), string.Empty, false) != 0)
    {
      SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
      graphics.DrawImage(this.method_3(this.method_1()), new Point((int) Math.Round(((double) this.Width - (double) sizeF.Width) / 2.0 - 16.0), 5));
    }
    base.OnPaint(e);
  }

  private void method_0(Graphics graphics_0)
  {
    if (this.bool_0)
      graphics_0.Clear(ControlPaint.Light(this.color_0));
    else
      graphics_0.Clear(this.color_0);
    if (this.bool_1)
      graphics_0.Clear(this.color_0);
    if (this.Enabled)
      return;
    graphics_0.Clear(ControlPaint.Dark(this.color_0));
  }

  protected override void OnMouseEnter(EventArgs e)
  {
    this.bool_0 = true;
    this.Invalidate();
    base.OnMouseEnter(e);
  }

  protected override void OnMouseLeave(EventArgs e)
  {
    this.bool_0 = false;
    this.Invalidate();
    base.OnMouseLeave(e);
  }

  protected override void OnMouseDown(MouseEventArgs e)
  {
    this.bool_1 = true;
    this.Invalidate();
    base.OnMouseDown(e);
  }

  protected override void OnMouseUp(MouseEventArgs e)
  {
    this.bool_1 = false;
    this.Invalidate();
    base.OnMouseUp(e);
  }

  public string method_1() => this.string_0;

  public void method_2(string string_1) => this.string_0 = string_1;

  private Image method_3(string string_1)
  {
    using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_1)))
      return Image.FromStream((Stream) memoryStream);
  }
}
