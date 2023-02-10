// Decompiled with JetBrains decompiler
// Type: Class105
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class105
{
  private IntPtr intptr_0;
  private IntPtr intptr_1;

  public Class105()
  {
    Process currentProcess = Process.GetCurrentProcess();
    this.intptr_0 = currentProcess.Handle;
    this.intptr_1 = new IntPtr(currentProcess.Threads[0].Id);
    this.method_7();
  }

  private bool method_0() => Debugger.IsAttached;

  private bool method_1()
  {
    bool bool_0;
    return Class105.CheckRemoteDebuggerPresent(this.intptr_0, ref bool_0) && bool_0;
  }

  private bool method_2() => Class105.IsDebuggerPresent();

  private bool method_3()
  {
    uint uint_1;
    uint uint_2;
    return Class105.NtQueryInformationProcess(this.intptr_0, 7U, ref uint_1, 4, ref uint_2) == 0 && uint_1 != 0U;
  }

  private bool method_4()
  {
    uint uint_1;
    uint uint_2;
    return Class105.NtQueryInformationProcess(this.intptr_0, 30U, ref uint_1, 4, ref uint_2) == 0 && uint_1 != 0U;
  }

  private bool method_5()
  {
    uint uint_1;
    uint uint_2;
    return Class105.NtQueryInformationProcess(this.intptr_0, 31U, ref uint_1, 4, ref uint_2) == 0 && uint_1 == 0U;
  }

  private bool method_6()
  {
    Class105.Struct10 struct10_0 = new Class105.Struct10();
    struct10_0.uint_0 = 65552U;
    return Class105.GetThreadContext(this.intptr_1, ref struct10_0) && (struct10_0.uint_1 != 0U || struct10_0.uint_2 != 0U || struct10_0.uint_3 != 0U || struct10_0.uint_4 != 0U);
  }

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_7()
  {
    try
    {
      if (this.method_1())
        ProjectData.EndApp();
      if (this.method_2())
        ProjectData.EndApp();
      if (this.method_6())
        ProjectData.EndApp();
      if (this.method_3())
        ProjectData.EndApp();
      if (this.method_4())
        ProjectData.EndApp();
      if (!this.method_5())
        return;
      ProjectData.EndApp();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  [DllImport("kernel32.dll")]
  private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_2, ref bool bool_0);

  [DllImport("kernel32.dll")]
  private static extern bool IsDebuggerPresent();

  [DllImport("ntdll.dll")]
  private static extern int NtQueryInformationProcess(
    IntPtr intptr_2,
    uint uint_0,
    ref uint uint_1,
    int int_0,
    ref uint uint_2);

  [DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess")]
  private static extern int NtQueryInformationProcess_1(
    IntPtr intptr_2,
    uint uint_0,
    ref Class105.Struct8 struct8_0,
    int int_0,
    ref uint uint_1);

  [DllImport("kernel32.dll")]
  private static extern bool GetThreadContext(IntPtr intptr_2, ref Class105.Struct10 struct10_0);

  [DllImport("kernel32.dll")]
  private static extern uint QueryDosDevice(
    string string_0,
    StringBuilder stringBuilder_0,
    uint uint_0);

  [DllImport("psapi.dll")]
  private static extern uint GetProcessImageFileName(
    IntPtr intptr_2,
    StringBuilder stringBuilder_0,
    uint uint_0);

  [DllImport("Kernel32.dll")]
  private static extern IntPtr OpenProcess(uint uint_0, bool bool_0, uint uint_1);

  [DllImport("kernel32.dll")]
  private static extern bool CloseHandle(IntPtr intptr_2);

  [DllImport("kernel32.dll")]
  private static extern bool GlobalMemoryStatusEx(ref Class105.Struct9 struct9_0);

  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  private struct Struct8
  {
    public IntPtr intptr_0;
    public IntPtr intptr_1;
    public IntPtr intptr_2;
    public IntPtr intptr_3;
    public IntPtr intptr_4;
    public IntPtr intptr_5;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  private struct Struct9
  {
    public int int_0;
    public uint uint_0;
    public ulong ulong_0;
    public ulong ulong_1;
    public ulong ulong_2;
    public ulong ulong_3;
    public ulong ulong_4;
    public ulong ulong_5;
    public ulong ulong_6;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  private struct Struct10
  {
    public uint uint_0;
    public uint uint_1;
    public uint uint_2;
    public uint uint_3;
    public uint uint_4;
    public uint uint_5;
    public uint uint_6;
  }
}
