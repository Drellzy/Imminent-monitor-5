// Decompiled with JetBrains decompiler
// Type: GClass19
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public sealed class GClass19 : ToolStripSystemRenderer
{
  private VisualStyleRenderer visualStyleRenderer_0;
  private static readonly int int_0 = 6;
  private GEnum1 genum1_0;

  public GClass19(GEnum1 genum1_1) => this.method_2(genum1_1);

  private Padding method_0(IDeviceContext ideviceContext_0, GClass19.Enum2 enum2_0)
  {
    try
    {
      GClass19.Class109.Struct11 struct11_0;
      return 0 == GClass19.Class109.GetThemeMargins(this.visualStyleRenderer_0.Handle, ideviceContext_0.GetHdc(), this.visualStyleRenderer_0.Part, this.visualStyleRenderer_0.State, (int) enum2_0, IntPtr.Zero, ref struct11_0) ? new Padding(struct11_0.int_0, struct11_0.int_2, struct11_0.int_1, struct11_0.int_3) : new Padding(0);
    }
    finally
    {
      ideviceContext_0.ReleaseHdc();
    }
  }

  private static int smethod_0(ToolStripItem toolStripItem_0)
  {
    bool selected = toolStripItem_0.Selected;
    return toolStripItem_0.IsOnDropDown ? (toolStripItem_0.Enabled ? (!selected ? 1 : 2) : (!selected ? 3 : 4)) : (toolStripItem_0.Pressed ? (!toolStripItem_0.Enabled ? 6 : 3) : (toolStripItem_0.Enabled ? (!selected ? 1 : 2) : (!selected ? 4 : 5)));
  }

  public GEnum1 method_1() => this.genum1_0;

  public void method_2(GEnum1 genum1_1) => this.genum1_0 = genum1_1;

  private string method_3() => this.method_5() + "Rebar";

  private string method_4() => this.method_5() + "Menu";

  private string method_5()
  {
    switch (this.method_1())
    {
      case (GEnum1) 1:
        return "Media::";
      case (GEnum1) 2:
        return "Communications::";
      case (GEnum1) 3:
        return "BrowserTabBar::";
      case (GEnum1) 4:
        return "Help::";
      default:
        return string.Empty;
    }
  }

  private bool method_6()
  {
    if (!this.method_9())
      return false;
    if (this.visualStyleRenderer_0 == null)
      this.visualStyleRenderer_0 = new VisualStyleRenderer(VisualStyleElement.Button.PushButton.Normal);
    return true;
  }

  protected override void Initialize(ToolStrip toolStrip)
  {
    if (toolStrip.Parent is ToolStripPanel)
      toolStrip.BackColor = Color.Transparent;
    base.Initialize(toolStrip);
  }

  protected override void InitializePanel(ToolStripPanel toolStripPanel)
  {
    try
    {
      foreach (Control control in toolStripPanel.Controls)
      {
        if (control is ToolStrip toolStrip)
          this.Initialize(toolStrip);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    base.InitializePanel(toolStripPanel);
  }

  protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
  {
    if (this.method_6())
    {
      this.visualStyleRenderer_0.SetParameters(this.method_4(), 10, 0);
      if (!e.ToolStrip.IsDropDown)
        return;
      Region clip = e.Graphics.Clip;
      Rectangle clientRectangle = e.ToolStrip.ClientRectangle;
      clientRectangle.Inflate(-1, -1);
      e.Graphics.ExcludeClip(clientRectangle);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, e.ToolStrip.ClientRectangle, e.AffectedBounds);
      e.Graphics.Clip = clip;
    }
    else
      base.OnRenderToolStripBorder(e);
  }

  private Rectangle method_7(ToolStripItem toolStripItem_0)
  {
    if (!toolStripItem_0.IsOnDropDown)
      return new Rectangle(new Point(), toolStripItem_0.Bounds.Size);
    return toolStripItem_0.Bounds with
    {
      X = toolStripItem_0.ContentRectangle.X + 1,
      Width = toolStripItem_0.ContentRectangle.Width - 1,
      Y = 0
    };
  }

  protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
  {
    if (this.method_6())
    {
      int part = e.Item.IsOnDropDown ? 14 : 8;
      this.visualStyleRenderer_0.SetParameters(this.method_4(), part, GClass19.smethod_0(e.Item));
      Rectangle rectangle = this.method_7(e.Item);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, rectangle, rectangle);
    }
    else
      base.OnRenderMenuItemBackground(e);
  }

  protected override void OnRenderToolStripPanelBackground(ToolStripPanelRenderEventArgs e)
  {
    if (this.method_6())
    {
      if (VisualStyleRenderer.IsElementDefined(VisualStyleElement.CreateElement(this.method_3(), GClass19.int_0, 0)))
        this.visualStyleRenderer_0.SetParameters(this.method_3(), GClass19.int_0, 0);
      else
        this.visualStyleRenderer_0.SetParameters(this.method_3(), 0, 0);
      if (this.visualStyleRenderer_0.IsBackgroundPartiallyTransparent())
        this.visualStyleRenderer_0.DrawParentBackground((IDeviceContext) e.Graphics, e.ToolStripPanel.ClientRectangle, (Control) e.ToolStripPanel);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, e.ToolStripPanel.ClientRectangle);
      e.Handled = true;
    }
    else
      base.OnRenderToolStripPanelBackground(e);
  }

  protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
  {
    if (this.method_6())
    {
      if (e.ToolStrip.IsDropDown)
      {
        this.visualStyleRenderer_0.SetParameters(this.method_4(), 9, 0);
      }
      else
      {
        if (e.ToolStrip.Parent is ToolStripPanel)
          return;
        if (VisualStyleRenderer.IsElementDefined(VisualStyleElement.CreateElement(this.method_3(), GClass19.int_0, 0)))
          this.visualStyleRenderer_0.SetParameters(this.method_3(), GClass19.int_0, 0);
        else
          this.visualStyleRenderer_0.SetParameters(this.method_3(), 0, 0);
      }
      if (!this.visualStyleRenderer_0.IsBackgroundPartiallyTransparent())
        return;
      this.visualStyleRenderer_0.DrawParentBackground((IDeviceContext) e.Graphics, e.ToolStrip.ClientRectangle, (Control) e.ToolStrip);
    }
    else
      base.OnRenderToolStripBackground(e);
  }

  protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e)
  {
    if (this.method_6())
    {
      ToolStripSplitButton stripSplitButton = (ToolStripSplitButton) e.Item;
      base.OnRenderSplitButtonBackground(e);
      this.OnRenderArrow(new ToolStripArrowRenderEventArgs(e.Graphics, (ToolStripItem) stripSplitButton, stripSplitButton.DropDownButtonBounds, Color.Red, ArrowDirection.Down));
    }
    else
      base.OnRenderSplitButtonBackground(e);
  }

  private Color method_8(ToolStripItem toolStripItem_0)
  {
    int part = toolStripItem_0.IsOnDropDown ? 14 : 8;
    this.visualStyleRenderer_0.SetParameters(this.method_4(), part, GClass19.smethod_0(toolStripItem_0));
    return this.visualStyleRenderer_0.GetColor(ColorProperty.TextColor);
  }

  protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
  {
    if (this.method_6())
      e.TextColor = this.method_8(e.Item);
    base.OnRenderItemText(e);
  }

  protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
  {
    if (this.method_6())
    {
      if (!e.ToolStrip.IsDropDown)
        return;
      this.visualStyleRenderer_0.SetParameters(this.method_4(), 13, 0);
      Padding padding = this.method_0((IDeviceContext) e.Graphics, (GClass19.Enum2) 3601);
      int num = e.ToolStrip.Width - e.ToolStrip.DisplayRectangle.Width - padding.Left - padding.Right - 1 - e.AffectedBounds.Width;
      Rectangle bounds = e.AffectedBounds;
      bounds.Y += 2;
      bounds.Height -= 4;
      int width = this.visualStyleRenderer_0.GetPartSize((IDeviceContext) e.Graphics, ThemeSizeType.True).Width;
      if (e.ToolStrip.RightToLeft == RightToLeft.Yes)
      {
        bounds = new Rectangle(bounds.X - num, bounds.Y, width, bounds.Height);
        bounds.X += width;
      }
      else
        bounds = new Rectangle(bounds.Width + num - width, bounds.Y, width, bounds.Height);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, bounds);
    }
    else
      base.OnRenderImageMargin(e);
  }

  protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
  {
    if (e.ToolStrip.IsDropDown && this.method_6())
    {
      this.visualStyleRenderer_0.SetParameters(this.method_4(), 15, 0);
      Rectangle rectangle = new Rectangle(e.ToolStrip.DisplayRectangle.Left, 0, e.ToolStrip.DisplayRectangle.Width, e.Item.Height);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, rectangle, rectangle);
    }
    else
      base.OnRenderSeparator(e);
  }

  protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
  {
    if (this.method_6())
    {
      Rectangle bounds = this.method_7(e.Item);
      bounds.Width = bounds.Height;
      if (e.Item.RightToLeft == RightToLeft.Yes)
        bounds = new Rectangle(e.ToolStrip.ClientSize.Width - bounds.X - bounds.Width, bounds.Y, bounds.Width, bounds.Height);
      this.visualStyleRenderer_0.SetParameters(this.method_4(), 12, e.Item.Enabled ? 2 : 1);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, bounds);
      Rectangle imageRectangle = e.ImageRectangle;
      imageRectangle.X = bounds.X + bounds.Width / 2 - imageRectangle.Width / 2;
      imageRectangle.Y = bounds.Y + bounds.Height / 2 - imageRectangle.Height / 2;
      this.visualStyleRenderer_0.SetParameters(this.method_4(), 11, e.Item.Enabled ? 1 : 2);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, imageRectangle);
    }
    else
      base.OnRenderItemCheck(e);
  }

  protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
  {
    if (this.method_6())
      e.ArrowColor = this.method_8(e.Item);
    base.OnRenderArrow(e);
  }

  protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
  {
    if (this.method_6())
    {
      string className = this.method_3();
      if (this.method_1() == (GEnum1) 3)
        className = "Rebar";
      int state = VisualStyleElement.Rebar.Chevron.Normal.State;
      if (e.Item.Pressed)
        state = VisualStyleElement.Rebar.Chevron.Pressed.State;
      else if (e.Item.Selected)
        state = VisualStyleElement.Rebar.Chevron.Hot.State;
      this.visualStyleRenderer_0.SetParameters(className, VisualStyleElement.Rebar.Chevron.Normal.Part, state);
      this.visualStyleRenderer_0.DrawBackground((IDeviceContext) e.Graphics, new Rectangle(Point.Empty, e.Item.Size));
    }
    else
      base.OnRenderOverflowButtonBackground(e);
  }

  public bool method_9() => VisualStyleRenderer.IsSupported && VisualStyleRenderer.IsElementDefined(VisualStyleElement.CreateElement("Menu", 7, 1));

  private enum Enum2
  {
  }

  private enum Enum3
  {
  }

  internal sealed class Class109
  {
    private Class109()
    {
    }

    [DllImport("uxtheme.dll")]
    public static extern int GetThemeMargins(
      IntPtr intptr_0,
      IntPtr intptr_1,
      int int_0,
      int int_1,
      int int_2,
      IntPtr intptr_2,
      ref GClass19.Class109.Struct11 struct11_0);

    public struct Struct11
    {
      public int int_0;
      public int int_1;
      public int int_2;
      public int int_3;
    }
  }

  private enum Enum4
  {
  }

  private enum Enum5
  {
  }

  private enum Enum6
  {
  }

  private enum Enum7
  {
  }

  private enum Enum8
  {
  }
}
