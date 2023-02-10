// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.GeneralSettingsLegacy
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ImminentMonitor.Cef
{
  public class GeneralSettingsLegacy
  {
    public GeneralSettingsLegacy()
    {
      this.set_ColorScheme(0);
      this.set_Ports(new ushort[1]{ (ushort) 9003 });
      this.set_AutoListen(false);
      this.set_SortByCountry(true);
      this.set_SortById(false);
      this.SortByOperatingSystem = false;
      this.MinTray = false;
      this.CloseTray = false;
      this.Notification = true;
      this.SoundNotification = false;
      this.AutoPing = true;
      this.AutoPingSeconds = 40;
      this.AutoInfo = true;
      this.AutoInfoSeconds = 55;
      this.NetworkStats = true;
    }

    [SpecialName]
    public int get_ColorScheme() => this._ColorScheme;

    [SpecialName]
    public void set_ColorScheme(int value) => this._ColorScheme = value;

    [SpecialName]
    public ushort[] get_Ports() => this._Ports;

    [SpecialName]
    public void set_Ports(ushort[] value) => this._Ports = value;

    [SpecialName]
    public bool get_AutoListen() => this._AutoListen;

    [SpecialName]
    public void set_AutoListen(bool value) => this._AutoListen = value;

    [SpecialName]
    public bool get_SortByCountry() => this._SortByCountry;

    [SpecialName]
    public void set_SortByCountry(bool value) => this._SortByCountry = value;

    [SpecialName]
    public bool get_SortById() => this._SortById;

    [SpecialName]
    public void set_SortById(bool value) => this._SortById = value;

    public bool SortByOperatingSystem { get; set; }

    public bool MinTray { get; set; }

    public bool CloseTray { get; set; }

    public bool Notification { get; set; }

    public bool SoundNotification { get; set; }

    public bool WindowProperties { get; set; }

    public bool AutoPing { get; set; }

    public int AutoPingSeconds { get; set; }

    public bool AutoInfo { get; set; }

    public int AutoInfoSeconds { get; set; }

    public bool NetworkStats { get; set; }

    public List<string> Plugins { [SpecialName] get; [SpecialName] set; }

    public string CompanyName { [SpecialName] get; [SpecialName] set; }

    public string ContactEmail { [SpecialName] get; [SpecialName] set; }

    public bool InvisibleClient { [SpecialName] get; [SpecialName] set; }

    public string IP { [SpecialName] get; [SpecialName] set; }
  }
}
