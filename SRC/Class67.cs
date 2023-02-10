// Decompiled with JetBrains decompiler
// Type: Class67
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class67 : Class45
{
  private IntPtr intptr_0;

  public IntPtr method_2() => this.intptr_0;

  public void method_3(IntPtr intptr_1) => this.intptr_0 = intptr_1;

  public override Class45 vmethod_4()
  {
    Class67 class67 = new Class67();
    class67.method_3(this.intptr_0);
    class67.method_1(this.method_0());
    return (Class45) class67;
  }

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3((IntPtr) object_0);

  [SpecialName]
  public override int vmethod_2() => 2;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((IntPtr) (int) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((IntPtr) (long) ((Class62) class45_0).method_2());
        break;
      case 2:
        this.method_3(((Class67) class45_0).method_2());
        break;
      case 3:
        this.method_3((IntPtr) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((IntPtr) (int) ((Class69) class45_0).method_2());
        break;
      case 7:
        this.method_3(new IntPtr(Convert.ToInt64((object) ((Class59) class45_0).method_2())));
        break;
      case 9:
        this.method_3((IntPtr) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((IntPtr) (long) ((Class64) class45_0).method_2());
        break;
      case 14:
        this.method_3((IntPtr) (int) ((Class70) class45_0).method_2());
        break;
      case 15:
        this.method_3((IntPtr) (long) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((IntPtr) (long) ((Class48) class45_0).method_2());
        break;
      case 18:
        this.method_3((IntPtr) (int) ((Class61) class45_0).method_2());
        break;
      case 20:
        this.method_3((IntPtr) ((Class49) class45_0).method_2());
        break;
      case 22:
        this.method_3(((Class68) class45_0).method_4());
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
