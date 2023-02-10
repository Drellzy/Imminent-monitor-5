// Decompiled with JetBrains decompiler
// Type: Class65
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;

internal sealed class Class65 : Class45
{
  private UIntPtr uintptr_0;

  public UIntPtr method_2() => this.uintptr_0;

  public void method_3(UIntPtr uintptr_1) => this.uintptr_0 = uintptr_1;

  public override Class45 vmethod_4()
  {
    Class65 class65 = new Class65();
    class65.method_3(this.uintptr_0);
    class65.method_1(this.method_0());
    return (Class45) class65;
  }

  [SpecialName]
  public override object vmethod_0() => (object) this.method_2();

  [SpecialName]
  public override void vmethod_1(object object_0) => this.method_3((UIntPtr) object_0);

  [SpecialName]
  public override int vmethod_2() => 5;

  public override Class45 vmethod_3(Class45 class45_0)
  {
    this.method_1(class45_0.method_0());
    switch (class45_0.vmethod_2())
    {
      case 0:
        this.method_3((UIntPtr) (uint) ((Class51) class45_0).method_2());
        break;
      case 1:
        this.method_3((UIntPtr) ((Class62) class45_0).method_2());
        break;
      case 3:
        this.method_3((UIntPtr) (ulong) ((Class63) class45_0).method_2());
        break;
      case 4:
        this.method_3((UIntPtr) (uint) ((Class69) class45_0).method_2());
        break;
      case 5:
        this.method_3(((Class65) class45_0).method_2());
        break;
      case 7:
        this.method_3(new UIntPtr(Convert.ToUInt64((object) ((Class59) class45_0).method_2())));
        break;
      case 9:
        this.method_3((UIntPtr) (ulong) ((Class46) class45_0).method_2());
        break;
      case 11:
        this.method_3((UIntPtr) ((Class64) class45_0).method_2());
        break;
      case 15:
        this.method_3((UIntPtr) (ulong) ((Class50) class45_0).method_2());
        break;
      case 16:
        this.method_3((UIntPtr) (ulong) ((Class48) class45_0).method_2());
        break;
      case 20:
        this.method_3((UIntPtr) ((Class49) class45_0).method_2());
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
    return (Class45) this;
  }
}
