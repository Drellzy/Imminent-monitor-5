// Decompiled with JetBrains decompiler
// Type: GClass41
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class GClass41 : ListView
{
  private bool bool_0;
  private bool bool_1;

  public GClass41()
  {
    this.ColumnClick += new ColumnClickEventHandler(this.GClass41_ColumnClick);
    this.bool_0 = false;
    this.bool_1 = true;
    this.DoubleBuffered = true;
    this.FullRowSelect = true;
    this.HideSelection = false;
    this.Font = new Font("Segoe UI", 8.25f);
    GClass41.SendMessage_2(this.Handle, 295, this.method_0(1, 1), 0);
  }

  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 8270)
    {
      object lparam = m.GetLParam(typeof (GClass41.Struct18));
      GClass41.Struct18 struct18;
      if ((lparam != null ? (GClass41.Struct18) lparam : struct18).uint_1 == 4294967284U)
      {
        m.Result = new IntPtr(0);
        return;
      }
    }
    base.WndProc(ref m);
  }

  [DllImport("user32.dll")]
  public static extern int SendMessage(
    IntPtr intptr_0,
    int int_0,
    IntPtr intptr_1,
    IntPtr intptr_2);

  [DllImport("user32.dll", EntryPoint = "SendMessage")]
  public static extern bool SendMessage_1(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    ref GClass41.GStruct2 gstruct2_0);

  [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
  private static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);

  [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
  private static extern IntPtr SendMessage_2(IntPtr intptr_0, int int_0, int int_1, int int_2);

  private int method_0(int int_0, int int_1) => (int) this.method_1(int_0) | 65536 * (int) this.method_1(int_1);

  private short method_1(int int_0) => (short) (int_0 & (int) short.MaxValue);

  ~GClass41() => base.Finalize();

  protected override void CreateHandle()
  {
    base.CreateHandle();
    this.Font = new Font("Segoe UI", 8.25f);
    if (!this.method_7())
      return;
    GClass41.SetWindowTheme(this.Handle, "explorer", (string) null);
  }

  protected override void OnDrawItem(DrawListViewItemEventArgs e)
  {
    e.DrawDefault = true;
    base.OnDrawItem(e);
  }

  protected override void OnKeyDown(KeyEventArgs e)
  {
    if (e.KeyCode == Keys.A & e.Modifiers == Keys.Control)
    {
      try
      {
        foreach (ListViewItem listViewItem in this.Items)
          listViewItem.Selected = true;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    base.OnKeyDown(e);
  }

  private int method_2(string string_0)
  {
    UserControlClients userControlClients = Class97.formMain_0.vmethod_0();
    if (Operators.CompareString(string_0, "?", false) == 0)
      return userControlClients.method_50("ping_c");
    if (Conversions.ToInteger(string_0) < 290 | Conversions.ToInteger(string_0) == 290)
      return userControlClients.method_50("ping_a");
    return Conversions.ToInteger(string_0) > 290 && Conversions.ToInteger(string_0) <= 450 ? userControlClients.method_50("ping_b") : userControlClients.method_50("ping_c");
  }

  private int method_3(string string_0)
  {
    UserControlClients userControlClients = Class97.formMain_0.vmethod_0();
    return !Conversions.ToBoolean(string_0) || !Conversions.ToBoolean(string_0) ? userControlClients.method_50("webcam_no") : userControlClients.method_50("webcam_yes");
  }

  private int method_4(string string_0)
  {
    UserControlClients userControlClients = Class97.formMain_0.vmethod_0();
    if (string_0.ToLower().Contains("windows"))
      return userControlClients.method_50("Windows");
    if (string_0.ToLower().Contains("linux"))
      return userControlClients.method_50("Linux");
    return string_0.ToLower().Contains("os x") ? userControlClients.method_50("osx") : userControlClients.method_50("Windows");
  }

  public void method_5(int int_0, int int_1, ListViewItem listViewItem_0)
  {
    this.method_6();
    GClass41.GStruct2 gstruct2_0 = new GClass41.GStruct2();
    switch (int_1)
    {
      case 1:
        int num1 = this.method_2(listViewItem_0.SubItems[1].Text.Split(Conversions.ToCharArrayRankOne(" "))[0]);
        gstruct2_0 = new GClass41.GStruct2()
        {
          uint_0 = 2U,
          int_0 = int_0,
          int_1 = int_1,
          int_3 = num1
        };
        break;
      case 7:
        int num2 = this.method_4(listViewItem_0.SubItems[7].Text);
        gstruct2_0 = new GClass41.GStruct2()
        {
          uint_0 = 2U,
          int_0 = int_0,
          int_1 = int_1,
          int_3 = num2
        };
        break;
      case 10:
        int num3 = this.method_3(listViewItem_0.SubItems[10].Text);
        gstruct2_0 = new GClass41.GStruct2()
        {
          uint_0 = 2U,
          int_0 = int_0,
          int_1 = int_1,
          int_3 = num3
        };
        break;
    }
    GClass41.SendMessage_1(this.Handle, 4102, 0, ref gstruct2_0);
  }

  private void method_6()
  {
    if (this.bool_0)
      return;
    int int_2 = (int) GClass41.SendMessage_2(this.Handle, 4151, 0, 0) | 2;
    if (int_2 != 0)
    {
      long num = (long) GClass41.SendMessage_2(this.Handle, 4150, 0, int_2);
    }
    this.bool_0 = true;
  }

  protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
  {
    e.DrawDefault = true;
    base.OnDrawColumnHeader(e);
  }

  private bool method_7() => Class132.smethod_0().Info.OSFullName.ToLower().Contains("7") | Class132.smethod_0().Info.OSFullName.ToLower().Contains("8") | Class132.smethod_0().Info.OSFullName.ToLower().Contains("vista") | Class132.smethod_0().Info.OSFullName.Contains("10");

  private void GClass41_ColumnClick(object sender, ColumnClickEventArgs e)
  {
    if (this.bool_1)
    {
      this.ListViewItemSorter = (IComparer) new GClass41.GClass42(e.Column, this.bool_1);
      this.bool_1 = false;
      if (!this.method_7())
        return;
      GClass13.smethod_0((ListView) this, e.Column, SortOrder.Descending);
    }
    else
    {
      this.ListViewItemSorter = (IComparer) new GClass41.GClass42(e.Column, this.bool_1);
      this.bool_1 = true;
      if (!this.method_7())
        return;
      GClass13.smethod_0((ListView) this, e.Column, SortOrder.Ascending);
    }
  }

  private void method_8(ListView listView_0, SizeF sizeF_0)
  {
    try
    {
      foreach (ColumnHeader column in listView_0.Columns)
        column.Width = (int) Math.Round(Math.Round((double) column.Width * (double) sizeF_0.Width));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
  {
    base.ScaleControl(factor, specified);
    this.method_8((ListView) this, factor);
  }

  public enum GEnum7
  {
  }

  public struct GStruct1
  {
    public int int_0;
    public int int_1;
    [MarshalAs(UnmanagedType.LPTStr)]
    public string string_0;
    public int int_2;
    [MarshalAs(UnmanagedType.LPTStr)]
    public string string_1;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
  }

  public struct GStruct2
  {
    public uint uint_0;
    public int int_0;
    public int int_1;
    public uint uint_1;
    public uint uint_2;
    public string string_0;
    public int int_2;
    public int int_3;
    public IntPtr intptr_0;
  }

  private struct Struct18
  {
    public IntPtr intptr_0;
    public uint uint_0;
    public uint uint_1;
  }

  public sealed class GClass42 : IComparer
  {
    private int int_0;
    private bool bool_0;

    public GClass42()
    {
      this.int_0 = 0;
      this.bool_0 = true;
    }

    public GClass42(int int_1, bool bool_1)
    {
      this.int_0 = int_1;
      this.bool_0 = bool_1;
    }

    public int Compare(object x, object y) => this.bool_0 ? string.Compare(((ListViewItem) x).SubItems[this.int_0].Text, ((ListViewItem) y).SubItems[this.int_0].Text) : string.Compare(((ListViewItem) y).SubItems[this.int_0].Text, ((ListViewItem) x).SubItems[this.int_0].Text);
  }
}
