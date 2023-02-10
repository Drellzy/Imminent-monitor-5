// Decompiled with JetBrains decompiler
// Type: Control0
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal sealed class Control0 : Control
{
  private Control0.Enum9 enum9_0;
  private readonly Timer timer_0;
  private readonly int[] int_0;
  private int int_1;

  public Control0()
  {
    this.timer_0 = new Timer()
    {
      Interval = 10,
      Enabled = false
    };
    this.int_0 = new int[5]{ -540, -460, -380, -300, -220 };
    this.int_1 = 5;
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
  }

  public int method_0() => this.int_1;

  public void method_1(int int_2) => this.int_1 = int_2 >= 1 ? int_2 : throw new Exception("You kinda want your shape to be visible right? Please set the size to a value bigger than zero.");

  public Control0.Enum9 method_2() => this.enum9_0;

  public void method_3(Control0.Enum9 enum9_1) => this.enum9_0 = enum9_1;

  protected override void OnHandleCreated(EventArgs e)
  {
    base.OnHandleCreated(e);
    this.timer_0.Start();
  }

  private void timer_0_Tick(object sender, EventArgs e)
  {
    int num1 = this.int_0.Length - 1;
    for (int index1 = 0; index1 <= num1; ++index1)
    {
      if (this.int_0[index1] >= this.Width / 2 - 70 && this.int_0[index1] <= this.Width / 2 + 70)
      {
        int[] int0 = this.int_0;
        int index2 = index1;
        int index3 = index2;
        int num2 = this.int_0[index2] + 2;
        int0[index3] = num2;
      }
      else
      {
        int[] int0 = this.int_0;
        int index4 = index1;
        int index5 = index4;
        int num3 = this.int_0[index4] + 8;
        int0[index5] = num3;
      }
      if (this.int_0[index1] > this.Width)
        this.int_0[index1] = -540;
    }
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    if (this.BackColor != Color.Transparent)
      e.Graphics.Clear(this.BackColor);
    SolidBrush solidBrush = new SolidBrush(this.ForeColor);
    switch (this.method_2())
    {
      case (Control0.Enum9) 0:
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        foreach (int num in this.int_0)
          e.Graphics.FillEllipse((Brush) solidBrush, new Rectangle(num - this.int_1 / 2, 0, this.int_1, this.int_1));
        break;
      case (Control0.Enum9) 1:
        foreach (int num in this.int_0)
          e.Graphics.FillRectangle((Brush) solidBrush, new Rectangle(num - this.int_1 / 2, 0, this.int_1, this.int_1));
        break;
    }
    solidBrush.Dispose();
    base.OnPaint(e);
  }

  internal enum Enum9
  {
  }
}
