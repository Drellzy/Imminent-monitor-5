// Decompiled with JetBrains decompiler
// Type: Class14
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.IO;
using System.Text;

internal sealed class Class14 : IDisposable
{
  private Class11 class11_0;
  private byte[] byte_0;
  private Decoder decoder_0;
  private byte[] byte_1;
  private char[] char_0;
  private char[] char_1;
  private int int_0;
  private bool bool_0;
  private bool bool_1;

  public Class14(Class11 class11_1)
    : this(class11_1, (Encoding) new UTF8Encoding())
  {
  }

  private Class14(Class11 class11_1, Encoding encoding_0)
  {
    if (class11_1 == null)
      throw new ArgumentNullException();
    if (encoding_0 == null)
      throw new ArgumentNullException();
    this.class11_0 = class11_1.method_0() ? class11_1 : throw new ArgumentException();
    this.decoder_0 = encoding_0.GetDecoder();
    this.int_0 = encoding_0.GetMaxCharCount(128);
    int length = encoding_0.GetMaxByteCount(1);
    if (length < 16)
      length = 16;
    this.byte_0 = new byte[length];
    this.char_1 = (char[]) null;
    this.byte_1 = (byte[]) null;
    this.bool_0 = encoding_0 is UnicodeEncoding;
    this.bool_1 = this.class11_0 != null;
  }

  public Class11 method_0() => this.class11_0;

  public void method_1() => this.method_2(true);

  private void method_2(bool bool_2)
  {
    if (bool_2)
    {
      Class11 class110 = this.class11_0;
      this.class11_0 = (Class11) null;
      class110?.method_3();
    }
    this.class11_0 = (Class11) null;
    this.byte_0 = (byte[]) null;
    this.decoder_0 = (Decoder) null;
    this.byte_1 = (byte[]) null;
    this.char_0 = (char[]) null;
    this.char_1 = (char[]) null;
  }

  void IDisposable.Dispose() => this.method_2(true);

  public int method_3()
  {
    this.method_24();
    if (!this.class11_0.method_1())
      return -1;
    long long_0 = this.class11_0.method_14();
    int num = this.method_4();
    this.class11_0.method_15(long_0);
    return num;
  }

  public int method_4()
  {
    this.method_24();
    return this.method_21();
  }

  public bool method_5()
  {
    this.method_26(1);
    return this.byte_0[0] > (byte) 0;
  }

  public byte method_6()
  {
    this.method_24();
    int num = this.class11_0.method_17();
    return num != -1 ? (byte) num : throw new Exception();
  }

  public sbyte method_7()
  {
    this.method_26(1);
    return (sbyte) this.byte_0[0];
  }

  public char method_8()
  {
    int num = this.method_4();
    return num != -1 ? (char) num : throw new Exception();
  }

  public short method_9()
  {
    this.method_26(2);
    return (short) ((int) this.byte_0[0] | (int) this.byte_0[1] << 8);
  }

  public ushort method_10()
  {
    this.method_26(2);
    return (ushort) ((uint) this.byte_0[0] | (uint) this.byte_0[1] << 8);
  }

  public uint method_11()
  {
    this.method_26(4);
    return (uint) ((int) this.byte_0[0] | (int) this.byte_0[1] << 8 | (int) this.byte_0[2] << 16 | (int) this.byte_0[3] << 24);
  }

  public long method_12()
  {
    this.method_26(8);
    return (long) (uint) ((int) this.byte_0[4] | (int) this.byte_0[5] << 8 | (int) this.byte_0[6] << 16 | (int) this.byte_0[7] << 24) << 32 | (long) (uint) ((int) this.byte_0[0] | (int) this.byte_0[1] << 8 | (int) this.byte_0[2] << 16 | (int) this.byte_0[3] << 24);
  }

  public ulong method_13()
  {
    this.method_26(8);
    return (ulong) (uint) ((int) this.byte_0[4] | (int) this.byte_0[5] << 8 | (int) this.byte_0[6] << 16 | (int) this.byte_0[7] << 24) << 32 | (ulong) (uint) ((int) this.byte_0[0] | (int) this.byte_0[1] << 8 | (int) this.byte_0[2] << 16 | (int) this.byte_0[3] << 24);
  }

  private BinaryReader method_14(int int_1)
  {
    this.method_26(int_1);
    return new BinaryReader((Stream) new MemoryStream(this.byte_0, 0, int_1, false));
  }

  public float method_15()
  {
    BinaryReader binaryReader = this.method_14(4);
    float num = binaryReader.ReadSingle();
    binaryReader.Close();
    return num;
  }

  public double method_16()
  {
    BinaryReader binaryReader = this.method_14(8);
    double num = binaryReader.ReadDouble();
    binaryReader.Close();
    return num;
  }

  private static Decimal smethod_0(int int_1, int int_2, int int_3, int int_4)
  {
    bool isNegative = (int_4 & int.MinValue) != 0;
    byte scale = (byte) (int_4 >> 16);
    return new Decimal(int_1, int_2, int_3, isNegative, scale);
  }

  internal static Decimal smethod_1(byte[] byte_2)
  {
    int int_1 = (int) byte_2[0] | (int) byte_2[1] << 8 | (int) byte_2[2] << 16 | (int) byte_2[3] << 24;
    int num1 = (int) byte_2[4] | (int) byte_2[5] << 8 | (int) byte_2[6] << 16 | (int) byte_2[7] << 24;
    int num2 = (int) byte_2[8] | (int) byte_2[9] << 8 | (int) byte_2[10] << 16 | (int) byte_2[11] << 24;
    int num3 = (int) byte_2[12] | (int) byte_2[13] << 8 | (int) byte_2[14] << 16 | (int) byte_2[15] << 24;
    int int_2 = num1;
    int int_3 = num2;
    int int_4 = num3;
    return Class14.smethod_0(int_1, int_2, int_3, int_4);
  }

  public Decimal method_17()
  {
    this.method_26(16);
    return Class14.smethod_1(this.byte_0);
  }

  public string method_18()
  {
    int num = 0;
    this.method_24();
    int capacity = this.method_27();
    if (capacity < 0)
      throw new IOException();
    if (capacity == 0)
      return string.Empty;
    if (this.byte_1 == null)
      this.byte_1 = new byte[128];
    if (this.char_1 == null)
      this.char_1 = new char[this.int_0];
    StringBuilder stringBuilder = (StringBuilder) null;
    int chars;
    do
    {
      int byteCount = this.class11_0.method_16(this.byte_1, 0, capacity - num > 128 ? 128 : capacity - num);
      if (byteCount != 0)
      {
        chars = this.decoder_0.GetChars(this.byte_1, 0, byteCount, this.char_1, 0);
        if (num != 0 || byteCount != capacity)
        {
          if (stringBuilder == null)
            stringBuilder = new StringBuilder(capacity);
          stringBuilder.Append(this.char_1, 0, chars);
          num += byteCount;
        }
        else
          goto label_15;
      }
      else
        goto label_14;
    }
    while (num < capacity);
    goto label_16;
label_14:
    throw new Exception();
label_15:
    return new string(this.char_1, 0, chars);
label_16:
    return stringBuilder.ToString();
  }

  public int method_19(char[] char_2, int int_1, int int_2)
  {
    if (char_2 == null)
      throw new ArgumentNullException("#=zHyRTQY0=", "ArgumentNull_Buffer");
    if (int_1 < 0)
      throw new ArgumentOutOfRangeException();
    if (int_2 < 0)
      throw new ArgumentOutOfRangeException();
    if (char_2.Length - int_1 < int_2)
      throw new ArgumentException();
    this.method_24();
    return this.method_20(char_2, int_1, int_2);
  }

  private int method_20(char[] char_2, int int_1, int int_2)
  {
    int num1 = int_2;
    if (this.byte_1 == null)
      this.byte_1 = new byte[128];
    while (num1 > 0)
    {
      int num2 = num1;
      if (this.bool_0)
        num2 <<= 1;
      if (num2 > 128)
        num2 = 128;
      int chars;
      if (this.bool_1)
      {
        Class11 class110 = this.class11_0;
        int byteIndex = class110.method_9();
        int byteCount = class110.method_10(num2);
        if (byteCount == 0)
          return int_2 - num1;
        chars = this.decoder_0.GetChars(class110.method_7(), byteIndex, byteCount, char_2, int_1);
      }
      else
      {
        int byteCount = this.class11_0.method_16(this.byte_1, 0, num2);
        if (byteCount == 0)
          return int_2 - num1;
        chars = this.decoder_0.GetChars(this.byte_1, 0, byteCount, char_2, int_1);
      }
      num1 -= chars;
      int_1 += chars;
    }
    return int_2;
  }

  private int method_21()
  {
    int num1 = 0;
    long num2 = 0;
    if (this.class11_0.method_1())
      num2 = this.class11_0.method_14();
    if (this.byte_1 == null)
      this.byte_1 = new byte[128];
    if (this.char_0 == null)
      this.char_0 = new char[1];
    while (num1 == 0)
    {
      int byteCount = this.bool_0 ? 2 : 1;
      int num3 = this.class11_0.method_17();
      this.byte_1[0] = (byte) num3;
      if (num3 == -1)
        byteCount = 0;
      if (byteCount == 2)
      {
        int num4 = this.class11_0.method_17();
        this.byte_1[1] = (byte) num4;
        if (num4 == -1)
          byteCount = 1;
      }
      if (byteCount == 0)
        return -1;
      try
      {
        num1 = this.decoder_0.GetChars(this.byte_1, 0, byteCount, this.char_0, 0);
      }
      catch
      {
        if (this.class11_0.method_1())
          this.class11_0.method_18(num2 - this.class11_0.method_14(), SeekOrigin.Current);
        throw;
      }
    }
    return num1 == 0 ? -1 : (int) this.char_0[0];
  }

  public char[] method_22(int int_1)
  {
    this.method_24();
    char[] chArray = int_1 >= 0 ? new char[int_1] : throw new ArgumentOutOfRangeException();
    int length = this.method_20(chArray, 0, int_1);
    if (length != int_1)
    {
      char[] dst = new char[length];
      Buffer.BlockCopy((Array) chArray, 0, (Array) dst, 0, 2 * length);
      chArray = dst;
    }
    return chArray;
  }

  public int method_23(byte[] byte_2, int int_1, int int_2)
  {
    if (byte_2 == null)
      throw new ArgumentNullException();
    if (int_1 < 0)
      throw new ArgumentOutOfRangeException();
    if (int_2 < 0)
      throw new ArgumentOutOfRangeException();
    if (byte_2.Length - int_1 < int_2)
      throw new ArgumentException();
    this.method_24();
    return this.class11_0.method_16(byte_2, int_1, int_2);
  }

  private void method_24()
  {
    if (this.class11_0 == null)
      throw new Exception();
  }

  public byte[] method_25(int int_1)
  {
    if (int_1 < 0)
      throw new ArgumentOutOfRangeException();
    this.method_24();
    byte[] numArray = new byte[int_1];
    int length = 0;
    do
    {
      int num = this.class11_0.method_16(numArray, length, int_1);
      if (num != 0)
      {
        length += num;
        int_1 -= num;
      }
      else
        break;
    }
    while (int_1 > 0);
    if (length != numArray.Length)
    {
      byte[] dst = new byte[length];
      Buffer.BlockCopy((Array) numArray, 0, (Array) dst, 0, length);
      numArray = dst;
    }
    return numArray;
  }

  private void method_26(int int_1)
  {
    this.method_24();
    int int_4 = 0;
    if (int_1 == 1)
    {
      int num = this.class11_0.method_17();
      this.byte_0[0] = num != -1 ? (byte) num : throw new Exception();
    }
    else
    {
      do
      {
        int num = this.class11_0.method_16(this.byte_0, int_4, int_1 - int_4);
        if (num != 0)
          int_4 += num;
        else
          goto label_6;
      }
      while (int_4 < int_1);
      return;
label_6:
      throw new Exception();
    }
  }

  internal int method_27()
  {
    int num1 = 0;
    int num2 = 0;
    while (num2 != 35)
    {
      byte num3 = this.method_6();
      num1 |= ((int) num3 & (int) sbyte.MaxValue) << num2;
      num2 += 7;
      if (((int) num3 & 128) == 0)
        return num1;
    }
    throw new FormatException();
  }

  public int method_28()
  {
    if (this.bool_1)
      return this.class11_0.method_24();
    this.method_26(4);
    return (int) this.byte_0[0] | (int) this.byte_0[3] << 24 | (int) this.byte_0[2] << 16 | (int) this.byte_0[1] << 8;
  }
}
