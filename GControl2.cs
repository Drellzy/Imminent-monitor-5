// Decompiled with JetBrains decompiler
// Type: GControl2
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip | ToolStripItemDesignerAvailability.ContextMenuStrip)]
public sealed class GControl2 : ToolStripControlHost
{
  private EventHandler eventHandler_0;

  public GControl2()
    : base(GControl2.smethod_0())
  {
  }

  public TrackBar method_0() => this.Control as TrackBar;

  private static Control smethod_0() => (Control) new TrackBar()
  {
    AutoSize = false,
    TickStyle = TickStyle.None,
    Maximum = 100,
    Value = 45
  };

  public int method_1() => this.method_0().Value;

  public void method_2(int int_0) => this.method_0().Value = int_0;

  protected override void OnSubscribeControlEvents(Control control)
  {
    base.OnSubscribeControlEvents(control);
    (control as TrackBar).ValueChanged += new EventHandler(this.method_3);
  }

  protected override void OnUnsubscribeControlEvents(Control control)
  {
    base.OnUnsubscribeControlEvents(control);
    (control as TrackBar).ValueChanged += new EventHandler(this.method_3);
  }

  private void method_3(object sender, EventArgs e)
  {
    EventHandler eventHandler0 = this.eventHandler_0;
    if (eventHandler0 == null)
      return;
    eventHandler0(RuntimeHelpers.GetObjectValue(sender), e);
  }

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_4(EventHandler eventHandler_1) => this.eventHandler_0 += eventHandler_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_5(EventHandler eventHandler_1) => this.eventHandler_0 -= eventHandler_1;

  [SpecialName]
  protected override Size get_DefaultSize() => new Size(200, 16);

  public bool SortByCountry { [SpecialName] get; [SpecialName] set; }
}
