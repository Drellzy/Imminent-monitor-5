// Decompiled with JetBrains decompiler
// Type: GClass15
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;
using System.Threading;

public sealed class GClass15
{
  private GClass15.GDelegate4 gdelegate4_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass15.GDelegate4 gdelegate4_1) => this.gdelegate4_0 += gdelegate4_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass15.GDelegate4 gdelegate4_1) => this.gdelegate4_0 -= gdelegate4_1;

  public void method_2(Exception exception_0, string string_0)
  {
    GClass15.GDelegate4 gdelegate40 = this.gdelegate4_0;
    if (gdelegate40 == null)
      return;
    gdelegate40(exception_0, string_0);
  }

  public void method_3(object sender, UnhandledExceptionEventArgs e)
  {
    Exception exceptionObject = (Exception) e.ExceptionObject;
    GClass15.GDelegate4 gdelegate40 = this.gdelegate4_0;
    if (gdelegate40 == null)
      return;
    gdelegate40(exceptionObject, (string) null);
  }

  public void method_4(object sender, ThreadExceptionEventArgs e)
  {
    GClass15.GDelegate4 gdelegate40 = this.gdelegate4_0;
    if (gdelegate40 == null)
      return;
    gdelegate40(e.Exception, (string) null);
  }

  public delegate void GDelegate4(Exception exception_0, string string_0);
}
