// Decompiled with JetBrains decompiler
// Type: Class95
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

[StructLayout(LayoutKind.Sequential)]
internal sealed class Class95
{
  public ushort ushort_0;
  public ushort ushort_1;
  public uint uint_0;
  public uint uint_1;
  public ushort ushort_2;
  public ushort ushort_3;
  public ushort ushort_4;

  public override string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("wFormatTag: " + Conversions.ToString((uint) this.ushort_0) + "\r\n");
    stringBuilder.Append("nChannels: " + Conversions.ToString((uint) this.ushort_1) + "\r\n");
    stringBuilder.Append("nSamplesPerSec: " + Conversions.ToString(this.uint_0) + "\r\n");
    stringBuilder.Append("nAvgBytesPerSec: " + Conversions.ToString(this.uint_1) + "\r\n");
    stringBuilder.Append("nBlockAlign: " + Conversions.ToString((uint) this.ushort_2) + "\r\n");
    stringBuilder.Append("wBitsPerSample: " + Conversions.ToString((uint) this.ushort_3) + "\r\n");
    stringBuilder.Append("cbSize: " + Conversions.ToString((uint) this.ushort_4) + "\r\n");
    return stringBuilder.ToString();
  }
}
