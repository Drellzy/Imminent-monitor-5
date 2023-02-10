// Decompiled with JetBrains decompiler
// Type: GControl0
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

public sealed class GControl0 : ContainerControl
{
  private Rectangle rectangle_0;
  private readonly SolidBrush solidBrush_0;
  private readonly Brush brush_0;
  private readonly Brush brush_1;
  private Size size_0;
  private bool bool_0;
  private bool bool_1;

  public GControl0()
  {
    this.solidBrush_0 = new SolidBrush(Color.FromArgb(241, 244, 245));
    this.brush_0 = (Brush) new SolidBrush(Color.FromArgb(101, 101, 101));
    this.brush_1 = (Brush) new SolidBrush(Color.FromArgb(66, 133, 244));
    this.bool_0 = true;
    this.bool_1 = true;
    this.Size = new Size(200, 100);
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
  }

  public Size method_0() => this.size_0;

  public void method_1(Size size_1)
  {
    this.size_0 = size_1;
    this.Invalidate();
  }

  public bool method_2() => this.bool_0;

  public void method_3(bool bool_2)
  {
    this.bool_0 = bool_2;
    if (bool_2)
      this.Size = this.method_0();
    this.Invalidate();
  }

  public bool method_4() => this.bool_1;

  public void method_5(bool bool_2)
  {
    this.bool_1 = bool_2;
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;
    this.rectangle_0 = new Rectangle(10, 0, this.Width - 20, 24);
    graphics.FillRectangle((Brush) this.solidBrush_0, this.rectangle_0);
    if (this.method_2())
    {
      graphics.DrawString("-", new Font("Segoe UI", 9.25f, FontStyle.Bold), this.brush_0, (float) (this.Width - 26), 5f);
      graphics.DrawRectangle(Pens.LightGray, new Rectangle(0, 0, this.Width - 1, this.Height - 3));
      this.method_7();
      graphics.DrawString(this.Text, new Font("Segoe UI", 8.25f, FontStyle.Bold), this.brush_1, 12f, 5f);
    }
    else
    {
      graphics.DrawString("+", new Font("Segoe UI", 9.25f, FontStyle.Bold), this.brush_1, (float) (this.Width - 28), 5f);
      graphics.DrawRectangle(Pens.LightGray, new Rectangle(0, 0, this.Width - 1, this.Height - 3));
      this.Size = new Size(this.rectangle_0.Width + 20, this.rectangle_0.Height + 5);
      this.method_6();
      graphics.DrawString(this.Text, new Font("Segoe UI", 8.25f, FontStyle.Bold), this.brush_0, 12f, 5f);
    }
    base.OnPaint(e);
  }

  protected override void OnMouseDown(MouseEventArgs e)
  {
    if (this.method_4() && this.rectangle_0.Contains(e.Location))
    {
      if (this.method_2())
      {
        this.method_1(this.Size);
        this.method_3(false);
      }
      else
        this.method_3(true);
    }
    base.OnMouseDown(e);
  }

  protected override void OnCreateControl()
  {
    this.method_1(this.Size);
    base.OnCreateControl();
  }

  protected override void OnResize(EventArgs e)
  {
    this.Invalidate();
    base.OnResize(e);
  }

  private void method_6()
  {
    try
    {
      foreach (Control control in this.Controls)
        control.Visible = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_7()
  {
    try
    {
      foreach (Control control in this.Controls)
        control.Visible = true;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
