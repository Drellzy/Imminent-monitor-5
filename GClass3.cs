// Decompiled with JetBrains decompiler
// Type: GClass3
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

[StandardModule]
public sealed class GClass3
{
  public static void smethod_0(Socket socket_0, uint uint_0, uint uint_1)
  {
    GClass3.Struct6 structure = new GClass3.Struct6()
    {
      uint_0 = 1,
      uint_2 = uint_0,
      uint_1 = uint_1
    };
    int num1 = Marshal.SizeOf<GClass3.Struct6>(structure);
    IntPtr num2 = Marshal.AllocHGlobal(num1);
    Marshal.StructureToPtr<GClass3.Struct6>(structure, num2, true);
    byte[] numArray = new byte[num1 - 1 + 1];
    Marshal.Copy(num2, numArray, 0, num1);
    Marshal.FreeHGlobal(num2);
    socket_0.IOControl(IOControlCode.KeepAliveValues, numArray, (byte[]) null);
  }

  internal struct Struct6
  {
    internal uint uint_0;
    internal uint uint_1;
    internal uint uint_2;
  }
}
