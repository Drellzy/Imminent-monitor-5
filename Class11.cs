// Decompiled with JetBrains decompiler
// Type: Class11
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.IO;
using System.Runtime.InteropServices;

internal sealed class Class11 : IDisposable
{
  private byte[] byte_0;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private bool bool_0;
  private bool bool_1;
  private bool bool_2;
  private bool bool_3;

  public Class11()
    : this(0)
  {
  }

  public Class11(int int_4)
  {
    this.byte_0 = int_4 >= 0 ? new byte[int_4] : throw new ArgumentOutOfRangeException();
    this.int_3 = int_4;
    this.bool_0 = true;
    this.bool_1 = true;
    this.int_0 = 0;
    this.bool_2 = true;
  }

  public Class11(byte[] byte_1)
    : this(byte_1, true)
  {
  }

  public Class11(byte[] byte_1, bool bool_4)
  {
    this.byte_0 = byte_1 != null ? byte_1 : throw new ArgumentNullException();
    this.int_2 = this.int_3 = byte_1.Length;
    this.bool_1 = bool_4;
    this.int_0 = 0;
    this.bool_2 = true;
  }

  public Class11(byte[] byte_1, int int_4, int int_5)
    : this(byte_1, int_4, int_5, true)
  {
  }

  public Class11(byte[] byte_1, int int_4, int int_5, bool bool_4)
  {
    if (byte_1 == null)
      throw new ArgumentNullException();
    if (int_4 < 0)
      throw new ArgumentOutOfRangeException();
    if (int_5 < 0)
      throw new ArgumentOutOfRangeException();
    if (byte_1.Length - int_4 < int_5)
      throw new ArgumentException();
    this.byte_0 = byte_1;
    this.int_0 = this.int_1 = int_4;
    this.int_2 = this.int_3 = int_4 + int_5;
    this.bool_1 = bool_4;
    this.bool_0 = false;
    this.bool_2 = true;
  }

  public bool method_0() => this.bool_2;

  public bool method_1() => this.bool_2;

  public bool method_2() => this.bool_1;

  public void method_3()
  {
    this.method_4(true);
    GC.SuppressFinalize((object) this);
  }

  public void Dispose() => this.method_3();

  private void method_4(bool bool_4)
  {
    if (this.bool_3)
      return;
    if (bool_4)
    {
      this.bool_2 = false;
      this.bool_1 = false;
      this.bool_0 = false;
    }
    this.bool_3 = true;
  }

  private bool method_5(int int_4)
  {
    if (int_4 < 0)
      throw new IOException();
    if (int_4 <= this.int_3)
      return false;
    int int_4_1 = int_4;
    if (int_4_1 < 256)
      int_4_1 = 256;
    if (int_4_1 < this.int_3 * 2)
      int_4_1 = this.int_3 * 2;
    this.method_12(int_4_1);
    return true;
  }

  public void method_6()
  {
  }

  internal byte[] method_7() => this.byte_0;

  internal void method_8(out int int_4, out int int_5)
  {
    if (!this.bool_2)
      throw new Exception();
    int_4 = this.int_0;
    int_5 = this.int_2;
  }

  internal int method_9()
  {
    if (!this.bool_2)
      throw new Exception();
    return this.int_1;
  }

  public int method_10(int int_4)
  {
    if (!this.bool_2)
      throw new Exception();
    int num = this.int_2 - this.int_1;
    if (num > int_4)
      num = int_4;
    if (num < 0)
      num = 0;
    this.int_1 += num;
    return num;
  }

  public int method_11()
  {
    if (!this.bool_2)
      throw new Exception();
    return this.int_3 - this.int_0;
  }

  public void method_12(int int_4)
  {
    if (!this.bool_2)
      throw new Exception();
    if (int_4 == this.int_3)
      return;
    if (!this.bool_0)
      throw new Exception();
    if (int_4 < this.int_2)
      throw new ArgumentOutOfRangeException();
    if (int_4 > 0)
    {
      byte[] dst = new byte[int_4];
      if (this.int_2 > 0)
        Buffer.BlockCopy((Array) this.byte_0, 0, (Array) dst, 0, this.int_2);
      this.byte_0 = dst;
    }
    else
      this.byte_0 = (byte[]) null;
    this.int_3 = int_4;
  }

  public long method_13()
  {
    if (!this.bool_2)
      throw new Exception();
    return (long) (this.int_2 - this.int_0);
  }

  public long method_14()
  {
    if (!this.bool_2)
      throw new Exception();
    return (long) (this.int_1 - this.int_0);
  }

  public void method_15(long long_0)
  {
    if (!this.bool_2)
      throw new Exception();
    if (long_0 < 0L)
      throw new ArgumentOutOfRangeException();
    if (long_0 > (long) int.MaxValue)
      throw new ArgumentOutOfRangeException();
    this.int_1 = this.int_0 + (int) long_0;
  }

  public int method_16([In, Out] byte[] byte_1, int int_4, int int_5)
  {
    if (!this.bool_2)
      throw new Exception();
    if (byte_1 == null)
      throw new ArgumentNullException();
    if (int_4 < 0)
      throw new ArgumentOutOfRangeException();
    if (int_5 < 0)
      throw new ArgumentOutOfRangeException();
    if (byte_1.Length - int_4 < int_5)
      throw new ArgumentException();
    int count = this.int_2 - this.int_1;
    if (count > int_5)
      count = int_5;
    if (count <= 0)
      return 0;
    if (count <= 8)
    {
      int num = count;
      while (--num >= 0)
        byte_1[int_4 + num] = this.byte_0[this.int_1 + num];
    }
    else
      Buffer.BlockCopy((Array) this.byte_0, this.int_1, (Array) byte_1, int_4, count);
    this.int_1 += count;
    return count;
  }

  public int method_17()
  {
    if (!this.bool_2)
      throw new Exception();
    return this.int_1 >= this.int_2 ? -1 : (int) this.byte_0[this.int_1++];
  }

  public long method_18(long long_0, SeekOrigin seekOrigin_0)
  {
    if (!this.bool_2)
      throw new Exception();
    if (long_0 > (long) int.MaxValue)
      throw new ArgumentOutOfRangeException();
    switch (seekOrigin_0)
    {
      case SeekOrigin.Begin:
        if (long_0 < 0L)
          throw new IOException();
        this.int_1 = this.int_0 + (int) long_0;
        break;
      case SeekOrigin.Current:
        if (long_0 + (long) this.int_1 < (long) this.int_0)
          throw new IOException();
        this.int_1 += (int) long_0;
        break;
      case SeekOrigin.End:
        if ((long) this.int_2 + long_0 < (long) this.int_0)
          throw new IOException();
        this.int_1 = this.int_2 + (int) long_0;
        break;
      default:
        throw new ArgumentException();
    }
    return (long) this.int_1;
  }

  public void method_19(long long_0)
  {
    if (!this.bool_1)
      throw new Exception();
    if (long_0 > (long) int.MaxValue)
      throw new ArgumentOutOfRangeException();
    if (long_0 < 0L || long_0 > (long) (int.MaxValue - this.int_0))
      throw new ArgumentOutOfRangeException();
    int int_4 = this.int_0 + (int) long_0;
    if (!this.method_5(int_4) && int_4 > this.int_2)
      Array.Clear((Array) this.byte_0, this.int_2, int_4 - this.int_2);
    this.int_2 = int_4;
    if (this.int_1 <= int_4)
      return;
    this.int_1 = int_4;
  }

  public byte[] method_20()
  {
    byte[] dst = new byte[this.int_2 - this.int_0];
    Buffer.BlockCopy((Array) this.byte_0, this.int_0, (Array) dst, 0, this.int_2 - this.int_0);
    return dst;
  }

  public void method_21(byte[] byte_1, int int_4, int int_5)
  {
    if (!this.bool_2)
      throw new Exception();
    if (!this.bool_1)
      throw new Exception();
    if (byte_1 == null)
      throw new ArgumentNullException();
    if (int_4 < 0)
      throw new ArgumentOutOfRangeException();
    if (int_5 < 0)
      throw new ArgumentOutOfRangeException();
    if (byte_1.Length - int_4 < int_5)
      throw new ArgumentException();
    int int_4_1 = this.int_1 + int_5;
    if (int_4_1 < 0)
      throw new IOException();
    if (int_4_1 > this.int_2)
    {
      bool flag = this.int_1 > this.int_2;
      if (int_4_1 > this.int_3 && this.method_5(int_4_1))
        flag = false;
      if (flag)
        Array.Clear((Array) this.byte_0, this.int_2, int_4_1 - this.int_2);
      this.int_2 = int_4_1;
    }
    if (int_5 <= 8)
    {
      int num = int_5;
      while (--num >= 0)
        this.byte_0[this.int_1 + num] = byte_1[int_4 + num];
    }
    else
      Buffer.BlockCopy((Array) byte_1, int_4, (Array) this.byte_0, this.int_1, int_5);
    this.int_1 = int_4_1;
  }

  public void method_22(byte byte_1)
  {
    if (!this.bool_2)
      throw new Exception();
    if (!this.bool_1)
      throw new Exception();
    if (this.int_1 >= this.int_2)
    {
      int int_4 = this.int_1 + 1;
      bool flag = this.int_1 > this.int_2;
      if (int_4 >= this.int_3 && this.method_5(int_4))
        flag = false;
      if (flag)
        Array.Clear((Array) this.byte_0, this.int_2, this.int_1 - this.int_2);
      this.int_2 = int_4;
    }
    this.byte_0[this.int_1++] = byte_1;
  }

  public void method_23(Stream stream_0)
  {
    if (!this.bool_2)
      throw new Exception();
    if (stream_0 == null)
      throw new ArgumentNullException();
    stream_0.Write(this.byte_0, this.int_0, this.int_2 - this.int_0);
  }

  internal int method_24()
  {
    if (!this.bool_2)
      throw new Exception();
    int num = this.int_1 += 4;
    if (num > this.int_2)
    {
      this.int_1 = this.int_2;
      throw new Exception();
    }
    return (int) this.byte_0[num - 3] << 8 | (int) this.byte_0[num - 4] | (int) this.byte_0[num - 2] << 16 | (int) this.byte_0[num - 1] << 24;
  }
}
