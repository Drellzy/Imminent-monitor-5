// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.ProfileSettings
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Runtime.CompilerServices;

namespace ImminentMonitor.Cef
{
  public class ProfileSettings
  {
    [SpecialName]
    public string get_CompanyName() => this._CompanyName;

    [SpecialName]
    public void set_CompanyName(string value) => this._CompanyName = value;

    [SpecialName]
    public string get_ContactEmail() => this._ContactEmail;

    [SpecialName]
    public void set_ContactEmail(string value) => this._ContactEmail = value;

    [SpecialName]
    public bool get_InvisibleClient() => this._InvisibleClient;

    [SpecialName]
    public void set_InvisibleClient(bool value) => this._InvisibleClient = value;

    [SpecialName]
    public string get_IP() => this._IP;

    [SpecialName]
    public void set_IP(string value) => this._IP = value;

    [SpecialName]
    public ushort get_Port() => this._Port;

    [SpecialName]
    public void set_Port(ushort value) => this._Port = value;

    public string Group { get; set; }

    public bool FileIntegration { get; set; }

    public bool HiddenProperties { get; set; }

    public bool ClientStartupProtector { get; set; }

    public bool DisableTaskManager { get; set; }

    public bool ProcessSecurityFlag { get; set; }

    public bool CriticalProcessFlag { get; set; }

    public bool ProcessWatcher { get; set; }

    public bool EnableStartup { get; set; }

    public string StartupEntryName { get; set; }

    public string StartupFolderName { get; set; }

    public string StartupFileName { get; set; }

    public string AssemblyTitle { get; set; }

    public string AssemblyDescription { get; set; }

    public string AssemblyCompany { get; set; }

    public string AssemblyProduct { get; set; }

    public string AssemblyCopyright { get; set; }

    public string AssemblyVersion { get; set; }

    public string AssemblyIcon { get; set; }

    public string Code { [SpecialName] get; [SpecialName] set; }

    public string Email { [SpecialName] get; [SpecialName] set; }

    public string Password { [SpecialName] get; [SpecialName] set; }

    public string ConfirmPassword { [SpecialName] get; [SpecialName] set; }

    public string Username { [SpecialName] get; [SpecialName] set; }
  }
}
