// Decompiled with JetBrains decompiler
// Type: Class146
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

[StandardModule]
internal sealed class Class146
{
  public static List<Control> smethod_0(ref this Form form_0)
  {
    List<Control> controlList = new List<Control>();
    try
    {
      foreach (Control control in form_0.Controls)
      {
        controlList.Add(control);
        if (control.HasChildren)
          controlList.AddRange((IEnumerable<Control>) control.smethod_1());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return controlList;
  }

  public static List<Control> smethod_1(ref this Control control_0)
  {
    List<Control> controlList = new List<Control>();
    if (!control_0.HasChildren)
      return (List<Control>) null;
    try
    {
      foreach (Control control in control_0.Controls)
      {
        controlList.Add(control);
        if (control.HasChildren)
          controlList.AddRange((IEnumerable<Control>) control.smethod_1());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return controlList;
  }
}
