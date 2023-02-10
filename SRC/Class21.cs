// Decompiled with JetBrains decompiler
// Type: Class21
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Diagnostics;
using System.Threading;

internal static class Class21
{
  internal sealed class Class22 : 
    Interface5<int>,
    Interface3<int>,
    Interface0,
    Interface1,
    Interface4
  {
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    public int int_4;

    [DebuggerHidden]
    public Class22(int int_5)
    {
      this.int_0 = int_5;
      this.int_2 = Thread.CurrentThread.ManagedThreadId;
    }

    [DebuggerHidden]
    void Interface0.imethod_0()
    {
    }

    bool Interface4.imethod_2()
    {
      switch (this.int_0)
      {
        case 0:
          this.int_0 = -1;
          this.int_1 = 1208217261;
          this.int_0 = 1;
          return true;
        case 1:
          this.int_0 = -1;
          this.int_1 = this.int_3 ^ 931506501;
          this.int_0 = 2;
          return true;
        case 2:
          this.int_0 = -1;
          this.int_1 = this.int_3 ^ -1351804023;
          this.int_0 = 3;
          return true;
        case 3:
          this.int_0 = -1;
          this.int_1 = 295005068;
          this.int_0 = 4;
          return true;
        case 4:
          this.int_0 = -1;
          this.int_1 = 1419393862;
          this.int_0 = 5;
          return true;
        case 5:
          this.int_0 = -1;
          this.int_1 = -1321009853;
          this.int_0 = 6;
          return true;
        case 6:
          this.int_0 = -1;
          this.int_1 = this.int_3 ^ 931506501;
          this.int_0 = 7;
          return true;
        case 7:
          this.int_0 = -1;
          this.int_1 = 283486011;
          this.int_0 = 8;
          return true;
        case 8:
          this.int_0 = -1;
          this.int_1 = this.int_3 ^ 931506501;
          this.int_0 = 9;
          return true;
        case 9:
          this.int_0 = -1;
          return false;
        default:
          return false;
      }
    }

    [DebuggerHidden]
    int Interface3<int>.imethod_3() => this.int_1;

    [DebuggerHidden]
    void Interface4.imethod_1() => throw new NotSupportedException();

    [DebuggerHidden]
    object Interface4.imethod_0() => (object) this.int_1;

    [DebuggerHidden]
    Interface3<int> Interface5<int>.imethod_1()
    {
      Class21.Class22 class22;
      if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
      {
        this.int_0 = 0;
        class22 = this;
      }
      else
        class22 = new Class21.Class22(0);
      class22.int_3 = this.int_4;
      return (Interface3<int>) class22;
    }

    [DebuggerHidden]
    Interface4 Interface1.imethod_0() => (Interface4) this.Interface5\u003CSystem\u002EInt32\u003E\u002Eimethod_1();
  }
}
