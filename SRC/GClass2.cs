// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using FastColoredTextBoxNS;
using System;
using System.Drawing;

public sealed class GClass2
{
  public TextStyle textStyle_0;
  public TextStyle textStyle_1;
  public TextStyle textStyle_2;
  public TextStyle textStyle_3;

  public GClass2()
  {
    this.textStyle_0 = new TextStyle(Brushes.Black, (Brush) null, FontStyle.Regular);
    this.textStyle_1 = new TextStyle(Brushes.Green, (Brush) null, FontStyle.Regular);
    this.textStyle_2 = new TextStyle(Brushes.BurlyWood, (Brush) null, FontStyle.Regular);
    this.textStyle_3 = new TextStyle(Brushes.Red, (Brush) null, FontStyle.Regular);
  }

  public void method_0(string string_0, TextStyle textStyle_4)
  {
    if (Class97.formMain_0.vmethod_32() == null)
      return;
    if (Class97.formMain_0.vmethod_32().InvokeRequired)
    {
      Class97.formMain_0.vmethod_32().Invoke((Delegate) new Class97.Delegate17(this.method_0), (object) string_0, (object) textStyle_4);
    }
    else
    {
      string str = string.Format("[{0}] ", (object) DateTime.Now.ToLongTimeString());
      Class97.formMain_0.vmethod_32().method_0(str + string_0 + "\r\n", (Style) textStyle_4);
    }
  }
}
