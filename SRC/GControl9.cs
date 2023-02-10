// Decompiled with JetBrains decompiler
// Type: GControl9
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public sealed class GControl9 : TabControl
{
  private Color color_0;
  private Color color_1;
  private Brush brush_0;
  private Brush brush_1;
  private GClass9 gclass9_0;
  private Brush brush_2;
  private Font font_0;
  private Pen pen_0;
  private StringFormat stringFormat_0;
  private List<TabPage> list_0;
  private List<int> list_1;
  private bool bool_0;
  private bool bool_1;
  private bool bool_2;

  public GControl9()
  {
    this.color_0 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this.color_1 = Color.FromArgb(66, 133, 244);
    this.brush_0 = (Brush) new SolidBrush(Color.FromArgb(246, 246, 246));
    this.brush_1 = (Brush) new SolidBrush(Color.FromArgb(66, 133, 244));
    this.brush_2 = (Brush) new SolidBrush(Color.FromArgb(117, 117, 117));
    this.font_0 = new Font("Segoe UI", 8.25f, FontStyle.Bold);
    this.pen_0 = new Pen(Color.FromArgb(230, 230, 230), 1f);
    this.stringFormat_0 = new StringFormat()
    {
      LineAlignment = StringAlignment.Center,
      Alignment = StringAlignment.Near
    };
    this.list_0 = new List<TabPage>();
    this.list_1 = new List<int>();
    this.bool_0 = false;
    this.bool_1 = false;
    if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
      this.gclass9_0 = new GClass9();
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    this.DrawMode = TabDrawMode.OwnerDrawFixed;
    this.ItemSize = new Size(30, 150);
    this.Alignment = TabAlignment.Left;
    this.SizeMode = TabSizeMode.Fixed;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    if (this.list_0.Count == 0)
      this.method_2();
    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
    if (this.method_6())
      this.method_0(e.Graphics);
    else
      this.method_1(e.Graphics);
    base.OnPaint(e);
  }

  private void method_0(Graphics graphics_0)
  {
    if (!this.bool_0)
    {
      this.bool_1 = this.method_5();
      this.bool_0 = true;
    }
    graphics_0.Clear(this.color_0);
    int num = this.TabPages.Count - 1;
    Point point1;
    Point point2;
    for (int index = 0; index <= num; ++index)
    {
      TabPage tabPage = this.TabPages[index];
      Rectangle tabRect = this.GetTabRect(index);
      Rectangle layoutRectangle1 = new Rectangle(tabRect.X + 35, tabRect.Y, tabRect.Width - 26, tabRect.Height);
      Rectangle layoutRectangle2 = new Rectangle(layoutRectangle1.X - 32, layoutRectangle1.Y + 1, layoutRectangle1.Width, layoutRectangle1.Height);
      Rectangle rectangle_0 = new Rectangle(layoutRectangle1.X - 25, layoutRectangle1.Y + 5, 18, 18);
      if (tabPage.Tag != null && Operators.CompareString(tabPage.Tag.ToString(), "Header", false) != 0)
      {
        if (tabPage == this.SelectedTab)
        {
          graphics_0.FillRectangle(this.brush_0, tabRect);
          if (this.method_3())
            graphics_0.DrawString(tabPage.Text, this.font_0, this.brush_1, (RectangleF) layoutRectangle1, this.stringFormat_0);
          if (this.method_6() && !this.bool_1)
            this.method_4(index, graphics_0, rectangle_0, true);
        }
        else
        {
          if (this.method_3())
            graphics_0.DrawString(tabPage.Text, this.font_0, this.brush_2, (RectangleF) layoutRectangle1, this.stringFormat_0);
          if (this.method_6() && !this.bool_1)
            this.method_4(index, graphics_0, rectangle_0, false);
        }
      }
      else
      {
        if (this.method_3())
          graphics_0.DrawString(tabPage.Text, this.font_0, this.brush_2, (RectangleF) layoutRectangle2, this.stringFormat_0);
        Graphics graphics = graphics_0;
        Pen pen0 = this.pen_0;
        point1 = new Point(0, layoutRectangle1.Y + layoutRectangle2.Height - 5);
        Point pt1 = point1;
        point2 = new Point(this.ItemSize.Height + 1, layoutRectangle1.Y + layoutRectangle2.Height - 5);
        Point pt2 = point2;
        graphics.DrawLine(pen0, pt1, pt2);
      }
    }
    Graphics graphics1 = graphics_0;
    Pen pen0_1 = this.pen_0;
    point2 = new Point(this.ItemSize.Height + 2, 0);
    Point pt1_1 = point2;
    point1 = new Point(this.ItemSize.Height + 2, this.Height);
    Point pt2_1 = point1;
    graphics1.DrawLine(pen0_1, pt1_1, pt2_1);
  }

  private void method_1(Graphics graphics_0)
  {
    graphics_0.Clear(this.color_0);
    int num = this.TabPages.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      TabPage tabPage = this.TabPages[index];
      Rectangle tabRect = this.GetTabRect(index);
      Rectangle layoutRectangle = new Rectangle(tabRect.X + 10, tabRect.Y, tabRect.Width - 26, tabRect.Height);
      if (tabPage == this.SelectedTab)
      {
        graphics_0.FillRectangle(this.brush_0, tabRect);
        if (this.method_3())
          graphics_0.DrawString(tabPage.Text, this.font_0, this.brush_1, (RectangleF) layoutRectangle, this.stringFormat_0);
      }
      else if (this.method_3())
        graphics_0.DrawString(tabPage.Text, this.font_0, this.brush_2, (RectangleF) layoutRectangle, this.stringFormat_0);
    }
    graphics_0.DrawLine(this.pen_0, new Point(this.ItemSize.Height + 2, 0), new Point(this.ItemSize.Height + 2, this.Height));
  }

  private void method_2()
  {
    this.list_0.Clear();
    this.list_1.Clear();
    try
    {
      foreach (TabPage tabPage in this.TabPages)
      {
        if (Operators.CompareString(tabPage.Tag.ToString(), "Header", false) == 0)
        {
          this.list_0.Add(tabPage);
          this.list_1.Add(this.TabPages.IndexOf(tabPage));
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private bool method_3() => this.ItemSize.Height >= 120;

  private void method_4(int int_0, Graphics graphics_0, Rectangle rectangle_0, bool bool_3)
  {
    if (this.gclass9_0.list_0.Count <= int_0)
      return;
    if (bool_3)
      graphics_0.DrawImage((Image) this.gclass9_0.list_0[int_0].bitmap_1, rectangle_0);
    else
      graphics_0.DrawImage((Image) this.gclass9_0.list_0[int_0].bitmap_0, rectangle_0);
  }

  public bool method_5() => Process.GetCurrentProcess().ProcessName.ToLower().Contains("devenv");

  public bool method_6() => this.bool_2;

  public void method_7(bool bool_3) => this.bool_2 = bool_3;
}
