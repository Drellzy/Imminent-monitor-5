// Decompiled with JetBrains decompiler
// Type: GClass28
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

public sealed class GClass28
{
  public static void smethod_0(string string_0, string string_1) => GClass28.smethod_1(string_0, string_1, 1U, 1U);

  public static void smethod_1(string string_0, string string_1, uint uint_0, uint uint_1)
  {
    GClass28.Class143 class143 = GClass28.Class143.smethod_0(string_1);
    IntPtr intptr_0_1 = GClass28.Class144.BeginUpdateResource(string_0, false);
    byte[] numArray1 = class143.method_2(uint_1);
    IntPtr intptr_0_2 = intptr_0_1;
    IntPtr num1 = new IntPtr(14L);
    IntPtr intptr_1_1 = num1;
    IntPtr num2 = new IntPtr((long) uint_0);
    IntPtr intptr_2_1 = num2;
    byte[] byte_0_1 = numArray1;
    int length1 = numArray1.Length;
    GClass28.Class144.UpdateResource(intptr_0_2, intptr_1_1, intptr_2_1, (short) 0, byte_0_1, length1);
    int num3 = class143.method_0() - 1;
    for (int int_0 = 0; int_0 <= num3; ++int_0)
    {
      byte[] numArray2 = class143.method_1(int_0);
      IntPtr intptr_0_3 = intptr_0_1;
      num2 = new IntPtr(3L);
      IntPtr intptr_1_2 = num2;
      num1 = new IntPtr((long) uint_1 + (long) int_0);
      IntPtr intptr_2_2 = num1;
      byte[] byte_0_2 = numArray2;
      int length2 = numArray2.Length;
      GClass28.Class144.UpdateResource(intptr_0_3, intptr_1_2, intptr_2_2, (short) 0, byte_0_2, length2);
    }
    GClass28.Class144.EndUpdateResource(intptr_0_1, false);
  }

  private sealed class Class143
  {
    private GClass28.Struct12 struct12_0;
    private GClass28.Struct14[] struct14_0;
    private byte[][] byte_0;

    private Class143() => this.struct12_0 = new GClass28.Struct12();

    public int method_0() => (int) this.struct12_0.ushort_2;

    public byte[] method_1(int int_0) => this.byte_0[int_0];

    public static GClass28.Class143 smethod_0(string string_0)
    {
      GClass28.Class143 class143 = new GClass28.Class143();
      byte[] src = File.ReadAllBytes(string_0);
      GCHandle gcHandle = GCHandle.Alloc((object) src, GCHandleType.Pinned);
      class143.struct12_0 = (GClass28.Struct12) Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof (GClass28.Struct12));
      class143.struct14_0 = new GClass28.Struct14[(int) class143.struct12_0.ushort_2 - 1 + 1];
      class143.byte_0 = new byte[(int) class143.struct12_0.ushort_2 - 1 + 1][];
      int num1 = Marshal.SizeOf<GClass28.Struct12>(class143.struct12_0);
      Type type = typeof (GClass28.Struct14);
      int num2 = Marshal.SizeOf(type);
      int num3 = (int) class143.struct12_0.ushort_2 - 1;
      for (int index = 0; index <= num3; ++index)
      {
        GClass28.Struct14 structure = (GClass28.Struct14) Marshal.PtrToStructure(new IntPtr(gcHandle.AddrOfPinnedObject().ToInt64() + (long) num1), type);
        class143.struct14_0[index] = structure;
        class143.byte_0[index] = new byte[structure.int_0 - 1 + 1];
        Buffer.BlockCopy((Array) src, structure.int_1, (Array) class143.byte_0[index], 0, structure.int_0);
        num1 += num2;
      }
      gcHandle.Free();
      return class143;
    }

    public byte[] method_2(uint uint_0)
    {
      byte[] numArray = new byte[Marshal.SizeOf(typeof (GClass28.Struct12)) + Marshal.SizeOf(typeof (GClass28.Struct15)) * this.method_0() - 1 + 1];
      GCHandle gcHandle1 = GCHandle.Alloc((object) numArray, GCHandleType.Pinned);
      Marshal.StructureToPtr<GClass28.Struct12>(this.struct12_0, gcHandle1.AddrOfPinnedObject(), false);
      int num1 = Marshal.SizeOf<GClass28.Struct12>(this.struct12_0);
      int num2 = this.method_0() - 1;
      for (int int_0 = 0; int_0 <= num2; ++int_0)
      {
        GClass28.Struct15 structure = new GClass28.Struct15();
        GClass28.Struct13 struct13 = new GClass28.Struct13();
        GCHandle gcHandle2 = GCHandle.Alloc((object) struct13, GCHandleType.Pinned);
        Marshal.Copy(this.method_1(int_0), 0, gcHandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof (GClass28.Struct13)));
        gcHandle2.Free();
        structure.byte_0 = this.struct14_0[int_0].byte_0;
        structure.byte_1 = this.struct14_0[int_0].byte_1;
        structure.byte_2 = this.struct14_0[int_0].byte_2;
        structure.byte_3 = this.struct14_0[int_0].byte_3;
        structure.ushort_0 = struct13.ushort_0;
        structure.ushort_1 = struct13.ushort_1;
        structure.int_0 = this.struct14_0[int_0].int_0;
        structure.ushort_2 = (ushort) ((ulong) uint_0 + (ulong) int_0);
        Marshal.StructureToPtr<GClass28.Struct15>(structure, new IntPtr(gcHandle1.AddrOfPinnedObject().ToInt64() + (long) num1), false);
        num1 += Marshal.SizeOf(typeof (GClass28.Struct15));
      }
      gcHandle1.Free();
      return numArray;
    }
  }

  private struct Struct12
  {
    public ushort ushort_0;
    public ushort ushort_1;
    public ushort ushort_2;
  }

  [SuppressUnmanagedCodeSecurity]
  private sealed class Class144
  {
    [DllImport("kernel32")]
    public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

    [DllImport("kernel32")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UpdateResource(
      IntPtr intptr_0,
      IntPtr intptr_1,
      IntPtr intptr_2,
      short short_0,
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] byte_0,
      int int_0);

    [DllImport("kernel32")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EndUpdateResource(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);
  }

  private struct Struct13
  {
    public uint uint_0;
    public int int_0;
    public int int_1;
    public ushort ushort_0;
    public ushort ushort_1;
    public uint uint_1;
    public uint uint_2;
    public int int_2;
    public int int_3;
    public uint uint_3;
    public uint uint_4;
  }

  private struct Struct14
  {
    public byte byte_0;
    public byte byte_1;
    public byte byte_2;
    public byte byte_3;
    public ushort ushort_0;
    public ushort ushort_1;
    public int int_0;
    public int int_1;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  private struct Struct15
  {
    public byte byte_0;
    public byte byte_1;
    public byte byte_2;
    public byte byte_3;
    public ushort ushort_0;
    public ushort ushort_1;
    public int int_0;
    public ushort ushort_2;
  }
}
