// Decompiled with JetBrains decompiler
// Type: GControl8
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public sealed class GControl8 : Control
{
  private bool bool_0;
  private bool bool_1;
  private Color color_0;
  private Color color_1;
  private Color color_2;
  private Pen pen_0;
  private Pen pen_1;
  private Image image_0;
  private string string_0;

  public GControl8()
  {
    this.bool_0 = false;
    this.bool_1 = false;
    this.color_0 = Color.FromArgb(245, 245, 245);
    this.color_1 = Color.FromArgb(171, 173, 179);
    this.color_2 = Color.FromArgb(126, 180, 234);
    this.pen_0 = new Pen(this.color_1);
    this.pen_1 = new Pen(this.color_2);
    this.string_0 = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAOxAAADsQBlSsOGwAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAFuSURBVDiN5ZMxaxRRFIW/M7O7phLmD4jpDIg29hYSEWzstQnCVnEL01nM3DedlSZEiaIigr1lClPERrYQmwXLaJ1UpliDzB4LZ3FZXAVbT/fufd8998E7Yk51XV+cTCZ9SVeAM8AE+Ay8tf0sIkbTuyml0PQQEUvAA0l9IJsf3KoBdmzflXQPqDSFJe0Cl4HvwCvbL3u93qdut/ttPB6ft30T6AOngANgGaADIOlhCx9JulaW5Yc55yEwjIgXkvanMEAnIi60kxtJV8uy/LhgfSTdAE7P1jp5nh83TbMp6eRPcEopgGpR/3+WUkr+TT1VVRWLoIi4D/TyPN/q/AN8SdIGkDVN83z+y361/eYv8C6QA48jYjS7wQGwLGkYEU+B18AIWMqybMX2GnAL6AJ7RVFswK/QJNvnbG8DuaR1Se8lHUs6tP0OWGudHxVFcX0wGJzAzyzMvvlOXdc7tm8Dq8DZ1uSL7T3gyWycAX4Ajl2KH8cQlaUAAAAASUVORK5CYII=";
    this.Size = new Size(24, 21);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
    this.method_2();
  }

  public string method_0() => this.string_0;

  public void method_1(string string_1)
  {
    this.string_0 = string_1;
    this.method_2();
    this.Invalidate();
  }

  private void method_2()
  {
    using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(this.method_0())))
      this.image_0 = Image.FromStream((Stream) memoryStream);
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;
    if (this.bool_1)
      graphics.Clear(this.color_0);
    else
      graphics.Clear(Color.FromArgb(241, 244, 245));
    if (this.bool_0)
      graphics.DrawRectangle(this.pen_1, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
    else
      graphics.DrawRectangle(this.pen_0, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
    graphics.DrawImage(this.image_0, 4, 3);
    base.OnPaint(e);
  }

  protected override void OnMouseDown(MouseEventArgs e)
  {
    if (!this.bool_1)
    {
      this.bool_1 = true;
      this.Invalidate();
    }
    base.OnMouseDown(e);
  }

  protected override void OnMouseUp(MouseEventArgs e)
  {
    this.bool_1 = false;
    this.Invalidate();
    base.OnMouseUp(e);
  }

  protected override void OnMouseEnter(EventArgs e)
  {
    if (!this.bool_0)
    {
      this.bool_0 = true;
      this.Invalidate();
    }
    base.OnMouseEnter(e);
  }

  protected override void OnMouseLeave(EventArgs e)
  {
    this.bool_0 = false;
    this.Invalidate();
    base.OnMouseLeave(e);
  }
}
