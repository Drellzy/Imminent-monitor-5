// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.My.MySettings
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ImminentMonitor.My
{
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    object IEnumerator.Current
    {
      get
      {
        if (this.int_0 == -2)
          throw new InvalidOperationException();
        if (this.int_0 == -1)
          throw new InvalidOperationException();
        return (object) this.gparam_0;
      }
    }

    Class17 IEnumerator<Class17>.Current
    {
      [DebuggerHidden] get => this.class17_0;
    }

    object IEnumerator.Current
    {
      [DebuggerHidden] get => (object) this.class17_0;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerNonUserCode]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!Class132.smethod_1().SaveMySettingsOnExit)
        return;
      Class137.smethod_0().Save();
    }

    [SpecialName]
    public static MySettings get_Default()
    {
      // ISSUE: reference to a compiler-generated field
      if (!MySettings.addedHandler)
      {
        // ISSUE: reference to a compiler-generated field
        object handlerLockObject = MySettings.addedHandlerLockObject;
        ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(handlerLockObject, ref lockTaken);
          // ISSUE: reference to a compiler-generated field
          if (!MySettings.addedHandler)
          {
            Class132.smethod_1().Shutdown += (ShutdownEventHandler) ((sender, e) =>
            {
              if (!Class132.smethod_1().SaveMySettingsOnExit)
                return;
              Class137.smethod_0().Save();
            });
            // ISSUE: reference to a compiler-generated field
            MySettings.addedHandler = true;
          }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(handlerLockObject);
        }
      }
      // ISSUE: reference to a compiler-generated field
      return MySettings.defaultInstance;
    }

    [SpecialName]
    public string get_Username() => Conversions.ToString(this["Username"]);

    [SpecialName]
    public void set_Username(string value) => this["Username"] = (object) value;

    [SpecialName]
    public bool get_DontShow() => Conversions.ToBoolean(this["DontShow"]);

    [SpecialName]
    public void set_DontShow(bool value) => this["DontShow"] = (object) value;
  }
}
