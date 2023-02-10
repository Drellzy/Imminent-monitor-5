// Decompiled with JetBrains decompiler
// Type: GClass30
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class GClass30
{
  private GClass30.GDelegate12 gdelegate12_0;
  private GClass30.GDelegate14 gdelegate14_0;
  private GClass30.GDelegate15 gdelegate15_0;
  private GClass30.GDelegate13 gdelegate13_0;
  private GClass30.GDelegate11 gdelegate11_0;
  private int int_0;
  private object object_0;
  private bool bool_0;
  private ushort ushort_0;
  private List<GClass18> list_0;
  private Socket socket_0;

  public GClass30()
  {
    this.int_0 = (int) ushort.MaxValue;
    this.list_0 = new List<GClass18>();
  }

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass30.GDelegate12 gdelegate12_1) => this.gdelegate12_0 += gdelegate12_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass30.GDelegate12 gdelegate12_1) => this.gdelegate12_0 -= gdelegate12_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_2(GClass30.GDelegate14 gdelegate14_1) => this.gdelegate14_0 += gdelegate14_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_3(GClass30.GDelegate14 gdelegate14_1) => this.gdelegate14_0 -= gdelegate14_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_4(GClass30.GDelegate15 gdelegate15_1) => this.gdelegate15_0 += gdelegate15_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_5(GClass30.GDelegate15 gdelegate15_1) => this.gdelegate15_0 -= gdelegate15_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_6(GClass30.GDelegate13 gdelegate13_1) => this.gdelegate13_0 += gdelegate13_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_7(GClass30.GDelegate13 gdelegate13_1) => this.gdelegate13_0 -= gdelegate13_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_8(GClass30.GDelegate11 gdelegate11_1) => this.gdelegate11_0 += gdelegate11_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_9(GClass30.GDelegate11 gdelegate11_1) => this.gdelegate11_0 -= gdelegate11_1;

  public int method_10() => this.int_0;

  public void method_11(int int_1) => this.int_0 = int_1 >= 1 ? int_1 : throw new Exception("Value must be greater than 0.");

  public object method_12() => this.object_0;

  public void method_13(object object_1) => this.object_0 = RuntimeHelpers.GetObjectValue(object_1);

  public bool method_14() => this.bool_0;

  public ushort method_15() => 0;

  public GClass18[] method_16() => this.list_0.ToArray();

  public void method_17(ushort ushort_1)
  {
    try
    {
      if (this.bool_0)
        return;
      this.bool_0 = true;
      this.ushort_0 = ushort_1;
      if (this.socket_0 != null)
      {
        this.socket_0.Close();
        this.socket_0 = (Socket) null;
      }
      this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      this.socket_0.Bind((EndPoint) new IPEndPoint(IPAddress.Any, (int) this.ushort_0));
      this.socket_0.Listen(1000);
      GClass30.GDelegate12 gdelegate120 = this.gdelegate12_0;
      if (gdelegate120 != null)
        gdelegate120(this, true);
      this.socket_0.BeginAccept(new AsyncCallback(this.method_18), (object) null);
    }
    catch (SocketException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SocketException socketException = ex;
      if (socketException.ErrorCode == 10048)
      {
        int num1 = (int) MessageBox.Show("Only one usage of each socket address (protocol/network address/port) is normally permitted.", ushort_1.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        int num2 = (int) MessageBox.Show("Unexpected socket error: " + socketException.Message + " error code: " + Conversions.ToString(socketException.ErrorCode));
      }
      this.method_20();
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass30.GDelegate14 gdelegate140 = this.gdelegate14_0;
      if (gdelegate140 != null)
        gdelegate140(this, exception_0);
      this.method_20();
      ProjectData.ClearProjectError();
    }
  }

  private void method_18(IAsyncResult iasyncResult_0)
  {
    try
    {
      if (this.socket_0 == null)
        return;
      this.method_19(this.socket_0.EndAccept(iasyncResult_0));
      this.socket_0.BeginAccept(new AsyncCallback(this.method_18), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass30.GDelegate14 gdelegate140 = this.gdelegate14_0;
      if (gdelegate140 != null)
        gdelegate140(this, exception_0);
      ProjectData.ClearProjectError();
    }
  }

  private void method_19(Socket socket_1)
  {
    try
    {
      if (this.socket_0 == null || this.socket_0 == socket_1)
        return;
      GClass18 gclass18_0 = new GClass18(this, socket_1, this.int_0);
      lock (this.list_0)
      {
        this.list_0.Add(gclass18_0);
        gclass18_0.method_0(new GClass18.GDelegate7(this.method_21));
        gclass18_0.method_4(new GClass18.GDelegate5(this.method_23));
        gclass18_0.method_2(new GClass18.GDelegate6(this.method_22));
        GClass30.GDelegate15 gdelegate150 = this.gdelegate15_0;
        if (gdelegate150 == null)
          return;
        gdelegate150(this, gclass18_0, true);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass30.GDelegate14 gdelegate140 = this.gdelegate14_0;
      if (gdelegate140 != null)
        gdelegate140(this, exception_0);
      ProjectData.ClearProjectError();
    }
  }

  public void method_20()
  {
    if (!this.bool_0)
      return;
    this.bool_0 = false;
    lock (this.list_0)
    {
      while (this.list_0.Count > 0)
        this.list_0[0].method_32();
    }
    if (this.socket_0 != null)
    {
      this.socket_0.Close();
      this.socket_0 = (Socket) null;
    }
    GClass30.GDelegate12 gdelegate120 = this.gdelegate12_0;
    if (gdelegate120 != null)
      gdelegate120(this, false);
    this.object_0 = (object) null;
  }

  private void method_21(GClass18 gclass18_0, bool bool_1)
  {
    lock (this.list_0)
      this.list_0.Remove(gclass18_0);
    GClass30.GDelegate15 gdelegate150 = this.gdelegate15_0;
    if (gdelegate150 == null)
      return;
    gdelegate150(this, gclass18_0, false);
  }

  private void method_22(GClass18 gclass18_0, double double_0, int int_1, int int_2, int int_3)
  {
    GClass30.GDelegate13 gdelegate130 = this.gdelegate13_0;
    if (gdelegate130 == null)
      return;
    gdelegate130(this, gclass18_0, double_0, int_1, int_2, int_3);
  }

  private void method_23(GClass18 gclass18_0, Exception exception_0)
  {
    GClass30.GDelegate11 gdelegate110 = this.gdelegate11_0;
    if (gdelegate110 == null)
      return;
    gdelegate110(this, gclass18_0, exception_0);
  }

  public delegate void GDelegate11(GClass30 gclass30_0, GClass18 gclass18_0, Exception exception_0);

  public delegate void GDelegate12(GClass30 gclass30_0, bool bool_0);

  public delegate void GDelegate13(
    GClass30 gclass30_0,
    GClass18 gclass18_0,
    double double_0,
    int int_0,
    int int_1,
    int int_2);

  public delegate void GDelegate14(GClass30 gclass30_0, Exception exception_0);

  public delegate void GDelegate15(GClass30 gclass30_0, GClass18 gclass18_0, bool bool_0);
}
