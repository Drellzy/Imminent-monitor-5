// Decompiled with JetBrains decompiler
// Type: GControl5
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl5 : Control
{
  private bool bool_0;
  private bool bool_1;
  private Pen pen_0;
  private SolidBrush solidBrush_0;
  private StringFormat stringFormat_0;

  public GControl5()
  {
    this.bool_0 = false;
    this.bool_1 = false;
    this.stringFormat_0 = new StringFormat()
    {
      LineAlignment = StringAlignment.Center,
      Alignment = StringAlignment.Center
    };
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
    this.pen_0 = new Pen(Color.FromArgb(223, 229, 229));
    this.solidBrush_0 = new SolidBrush(Color.FromArgb(92, 104, 104));
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;
    Rectangle layoutRectangle = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
    graphics.DrawRectangle(this.pen_0, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
    graphics.DrawString(this.Text, this.Font, (Brush) this.solidBrush_0, (RectangleF) layoutRectangle, this.stringFormat_0);
    if (this.bool_1)
      this.BackColor = Color.FromArgb(226, 228, 228);
    if (this.bool_0 & !this.bool_1)
      this.BackColor = Color.FromArgb(239, 240, 240);
    if (!this.bool_1 & !this.bool_0)
      this.BackColor = Color.White;
    base.OnPaint(e);
  }

  protected override void OnMouseUp(MouseEventArgs e)
  {
    this.bool_1 = false;
    this.Invalidate();
    base.OnMouseUp(e);
  }

  protected override void OnMouseDown(MouseEventArgs e)
  {
    this.bool_1 = true;
    this.Invalidate();
    base.OnMouseDown(e);
  }

  protected override void OnMouseLeave(EventArgs e)
  {
    this.bool_0 = false;
    this.Invalidate();
    base.OnMouseLeave(e);
  }

  protected override void OnMouseEnter(EventArgs e)
  {
    this.bool_0 = true;
    this.Invalidate();
    base.OnMouseEnter(e);
  }
}
