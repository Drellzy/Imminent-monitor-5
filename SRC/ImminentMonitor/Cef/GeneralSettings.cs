// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.GeneralSettings
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ImminentMonitor.Cef
{
  public class GeneralSettings
  {
    public string SettingsPath;
    private Class159 S;

    public GeneralSettings()
    {
      this.SettingsPath = Application.StartupPath + "\\Settings\\User\\GeneralSettings.dat";
      this.S = new Class159();
      this.set_Ports(new ushort[1]{ (ushort) 9003 });
      this.set_AutoListen(false);
      this.set_SortByCountry(true);
      this.set_SortById(false);
      this.set_SortByOperatingSystem(false);
      this.MinTray = false;
      this.CloseTray = false;
      this.Notification = true;
      this.SoundNotification = false;
      this.AnonymousErrorReporting = true;
      this.GeoIPSetting = 0;
    }

    public void SaveSettings()
    {
      List<object> objectList = new List<object>();
      objectList.Add((object) this.get_Ports().Length);
      int num = this.get_Ports().Length - 1;
      for (int index = 0; index <= num; ++index)
        objectList.Add((object) this.get_Ports()[index]);
      objectList.Add((object) this.get_AutoListen());
      objectList.Add((object) this.get_SortByCountry());
      objectList.Add((object) this.get_SortById());
      objectList.Add((object) this.get_SortByOperatingSystem());
      objectList.Add((object) this.MinTray);
      objectList.Add((object) this.CloseTray);
      objectList.Add((object) this.Notification);
      objectList.Add((object) this.SoundNotification);
      objectList.Add((object) this.AnonymousErrorReporting);
      objectList.Add((object) this.GeoIPSetting);
      File.WriteAllBytes(this.SettingsPath, this.S.method_0(objectList.ToArray()));
    }

    public void LoadSettings()
    {
      object[] objArray = this.S.method_2(File.ReadAllBytes(this.SettingsPath));
      if (objArray == null)
        return;
      int newSize = (int) objArray[0];
      ushort[] array = this.get_Ports();
      Array.Resize<ushort>(ref array, newSize);
      this.set_Ports(array);
      int num = newSize;
      for (int index = 1; index <= num; ++index)
        this.get_Ports()[index - 1] = Conversions.ToUShort(objArray[index]);
      this.set_AutoListen(Conversions.ToBoolean(objArray[newSize + 1]));
      this.set_SortByCountry(Conversions.ToBoolean(objArray[newSize + 2]));
      this.set_SortById(Conversions.ToBoolean(objArray[newSize + 3]));
      this.set_SortByOperatingSystem(Conversions.ToBoolean(objArray[newSize + 4]));
      this.MinTray = Conversions.ToBoolean(objArray[newSize + 5]);
      this.CloseTray = Conversions.ToBoolean(objArray[newSize + 6]);
      this.Notification = Conversions.ToBoolean(objArray[newSize + 7]);
      this.SoundNotification = Conversions.ToBoolean(objArray[newSize + 8]);
      if (objArray.Length - 1 > newSize + 8)
        this.AnonymousErrorReporting = Conversions.ToBoolean(objArray[newSize + 9]);
      if (objArray.Length - 1 <= newSize + 9)
        return;
      this.GeoIPSetting = Conversions.ToInteger(objArray[newSize + 10]);
      if (this.GeoIPSetting != 1 || this.IsMaxMindAvailable())
        return;
      this.GeoIPSetting = 0;
    }

    private bool IsMaxMindAvailable() => File.Exists(Application.StartupPath + "\\Resources\\Databases\\maxmind.mmdb");

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

    [SpecialName]
    public bool get_SortByOperatingSystem() => this._SortByOperatingSystem;

    [SpecialName]
    public void set_SortByOperatingSystem(bool value) => this._SortByOperatingSystem = value;

    public bool MinTray { get; set; }

    public bool CloseTray { get; set; }

    public bool Notification { get; set; }

    public bool SoundNotification { get; set; }

    public bool AnonymousErrorReporting { get; set; }

    public int GeoIPSetting { get; set; }

    public int ColorScheme { [SpecialName] get; [SpecialName] set; }

    public ushort[] Ports { [SpecialName] get; [SpecialName] set; }

    public bool AutoListen { [SpecialName] get; [SpecialName] set; }

    public bool SortByCountry { [SpecialName] get; [SpecialName] set; }

    public bool SortById { [SpecialName] get; [SpecialName] set; }
  }
}
