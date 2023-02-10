// Decompiled with JetBrains decompiler
// Type: GClass34
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GClass34 : TreeView
{
  public GClass34()
  {
    this.HandleCreated += new EventHandler(this.GClass34_HandleCreated);
    this.DoubleBuffered = true;
    this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
  }

  [DllImport("uxtheme", CharSet = CharSet.Unicode)]
  public static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);

  private void GClass34_HandleCreated(object sender, EventArgs e)
  {
    this.DoubleBuffered = true;
    GClass34.SetWindowTheme(this.Handle, "explorer", (string) null);
    this.FullRowSelect = true;
    this.ShowLines = true;
  }

  protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
  {
    if (e.Button == MouseButtons.Right)
      this.SelectedNode = e.Node;
    base.OnNodeMouseClick(e);
  }
}
