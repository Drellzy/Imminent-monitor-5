// Decompiled with JetBrains decompiler
// Type: Class74
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal sealed class Class74 : IDisposable, Interface2
{
  private List<byte> list_0 = new List<byte>();

  [SpecialName]
  public int imethod_0() => this.list_0.Count;

  public void imethod_3() => this.list_0.Clear();

  public Interface2 imethod_4() => (Interface2) new Class74();

  public void Dispose()
  {
    this.imethod_3();
    this.list_0 = (List<byte>) null;
  }

  public void imethod_1(int int_0, out byte byte_0) => byte_0 = this.method_0(this.list_0[int_0], int_0);

  public void imethod_2(int int_0, ref byte byte_0)
  {
    for (int count = this.list_0.Count; count <= int_0; ++count)
    {
      if (count != int_0)
      {
        this.list_0.Add(this.method_1((byte) 0, count));
      }
      else
      {
        this.list_0.Add(this.method_1(byte_0, count));
        return;
      }
    }
    this.list_0[int_0] = this.method_1(byte_0, int_0);
  }

  private byte method_0(byte byte_0, int int_0) => throw new NotImplementedException();

  private byte method_1(byte byte_0, int int_0) => throw new NotImplementedException();
}
