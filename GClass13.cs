// Decompiled with JetBrains decompiler
// Type: GClass13
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[StandardModule]
public sealed class GClass13
{
  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern IntPtr SendMessage(
    IntPtr intptr_0,
    uint uint_0,
    IntPtr intptr_1,
    IntPtr intptr_2);

  [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern IntPtr SendMessage_1(
    IntPtr intptr_0,
    uint uint_0,
    IntPtr intptr_1,
    ref GClass13.GStruct0 gstruct0_0);

  public static void smethod_0(ListView listView_0, int int_0, SortOrder sortOrder_0)
  {
    IntPtr intptr_0 = GClass13.SendMessage(listView_0.Handle, 4127U, IntPtr.Zero, IntPtr.Zero);
    int num = listView_0.Columns.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      IntPtr intptr_1 = new IntPtr(index);
      GClass13.GStruct0 gstruct0_0 = new GClass13.GStruct0();
      gstruct0_0.genum3_0 = (GClass13.GStruct0.GEnum3) 4;
      if (GClass13.SendMessage_1(intptr_0, 4619U, intptr_1, ref gstruct0_0) == IntPtr.Zero)
        throw new Win32Exception();
      if (sortOrder_0 != SortOrder.None && index == int_0)
      {
        switch (sortOrder_0)
        {
          case SortOrder.Ascending:
            gstruct0_0.genum2_0 &= (GClass13.GStruct0.GEnum2) -513;
            gstruct0_0.genum2_0 |= (GClass13.GStruct0.GEnum2) 1024;
            break;
          case SortOrder.Descending:
            gstruct0_0.genum2_0 &= (GClass13.GStruct0.GEnum2) -1025;
            gstruct0_0.genum2_0 |= (GClass13.GStruct0.GEnum2) 512;
            break;
        }
      }
      else
        gstruct0_0.genum2_0 = gstruct0_0.genum2_0 & (GClass13.GStruct0.GEnum2) -513 & (GClass13.GStruct0.GEnum2) -1025;
      if (GClass13.SendMessage_1(intptr_0, 4620U, intptr_1, ref gstruct0_0) == IntPtr.Zero)
        throw new Win32Exception();
    }
  }

  public struct GStruct0
  {
    public GClass13.GStruct0.GEnum3 genum3_0;
    public int int_0;
    [MarshalAs(UnmanagedType.LPTStr)]
    public string string_0;
    public IntPtr intptr_0;
    public int int_1;
    public GClass13.GStruct0.GEnum2 genum2_0;
    public IntPtr intptr_1;
    public int int_2;
    public int int_3;
    public uint uint_0;
    public IntPtr intptr_2;
    public uint uint_1;

    public enum GEnum2
    {
    }

    public enum GEnum3
    {
    }
  }
}
