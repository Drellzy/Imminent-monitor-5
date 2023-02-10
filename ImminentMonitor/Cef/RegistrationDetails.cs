// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.RegistrationDetails
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.My;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ImminentMonitor.Cef
{
  public class RegistrationDetails
  {
    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot
    {
      get
      {
        if (this.object_0 == null)
          Interlocked.CompareExchange(ref this.object_0, new object(), (object) null);
        return this.object_0;
      }
    }

    [SpecialName]
    public string get_Code() => this._Code;

    [SpecialName]
    public void set_Code(string value) => this._Code = value;

    [SpecialName]
    public string get_Email() => this._Email;

    [SpecialName]
    public void set_Email(string value) => this._Email = value;

    [SpecialName]
    public string get_Password() => this._Password;

    [SpecialName]
    public void set_Password(string value) => this._Password = value;

    [SpecialName]
    public string get_ConfirmPassword() => this._ConfirmPassword;

    [SpecialName]
    public void set_ConfirmPassword(string value) => this._ConfirmPassword = value;

    [SpecialName]
    public string get_Username() => this._Username;

    [SpecialName]
    public void set_Username(string value) => this._Username = value;

    public static MySettings Default
    {
      [SpecialName] get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(handlerLockObject, ref lockTaken);
            if (!MySettings.addedHandler)
            {
              Class132.smethod_1().Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!Class132.smethod_1().SaveMySettingsOnExit)
                  return;
                Class137.smethod_0().Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(handlerLockObject);
          }
        }
        return MySettings.defaultInstance;
      }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string Username
    {
      [SpecialName] get => Conversions.ToString(this["Username"]);
      [SpecialName] set => this["Username"] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    public bool DontShow
    {
      [SpecialName] get => Conversions.ToBoolean(this["DontShow"]);
      [SpecialName] set => this["DontShow"] = (object) value;
    }
  }
}
