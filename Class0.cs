// Decompiled with JetBrains decompiler
// Type: Class0
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.IO;

internal static class Class0
{
  private static readonly uint[] uint_0 = new uint[5]
  {
    52200625U,
    614125U,
    7225U,
    85U,
    1U
  };

  public static byte[] smethod_0(string string_0)
  {
    if (string_0 == null)
      throw new Exception();
    using (MemoryStream stream_0 = new MemoryStream(string_0.Length * 4 / 5))
    {
      int index1 = 0;
      uint uint_1 = 0;
      foreach (char ch in string_0)
      {
        if (ch == 'z' && index1 == 0)
        {
          Class0.smethod_1((Stream) stream_0, uint_1, 0);
        }
        else
        {
          if (ch < '!' || ch > 'u')
            throw new Exception();
          checked { uint_1 += (uint) ((long) Class0.uint_0[index1] * (long) ((int) ch - 33)); }
          ++index1;
          if (index1 == 5)
          {
            Class0.smethod_1((Stream) stream_0, uint_1, 0);
            index1 = 0;
            uint_1 = 0U;
          }
        }
      }
      if (index1 == 1)
        throw new Exception();
      if (index1 > 1)
      {
        for (int index2 = index1; index2 < 5; ++index2)
          checked { uint_1 += 84U * Class0.uint_0[index2]; }
        Class0.smethod_1((Stream) stream_0, uint_1, 5 - index1);
      }
      return stream_0.ToArray();
    }
  }

  private static void smethod_1(Stream stream_0, uint uint_1, int int_0)
  {
    stream_0.WriteByte((byte) (uint_1 >> 24));
    if (int_0 == 3)
      return;
    stream_0.WriteByte((byte) (uint_1 >> 16 & (uint) byte.MaxValue));
    if (int_0 == 2)
      return;
    stream_0.WriteByte((byte) (uint_1 >> 8 & (uint) byte.MaxValue));
    if (int_0 == 1)
      return;
    stream_0.WriteByte((byte) (uint_1 & (uint) byte.MaxValue));
  }
}
