// Decompiled with JetBrains decompiler
// Type: GClass14
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Windows.Forms;

public sealed class GClass14 : ToolStripDropDown
{
  private ToolStripControlHost toolStripControlHost_0;

  public GClass14(Control control_0)
  {
    this.toolStripControlHost_0 = (ToolStripControlHost) null;
    this.ResizeRedraw = true;
    this.Margin = Padding.Empty;
    this.Padding = Padding.Empty;
    this.AutoSize = true;
    this.toolStripControlHost_0 = new ToolStripControlHost(control_0);
    this.toolStripControlHost_0.Margin = Padding.Empty;
    this.toolStripControlHost_0.Padding = Padding.Empty;
    this.toolStripControlHost_0.AutoSize = true;
    this.Items.Add((ToolStripItem) this.toolStripControlHost_0);
  }

  public ToolStripControlHost method_0() => this.toolStripControlHost_0;
}
