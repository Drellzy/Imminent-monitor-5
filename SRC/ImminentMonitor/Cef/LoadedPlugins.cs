// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.LoadedPlugins
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ImminentMonitor.Cef
{
  public class LoadedPlugins
  {
    public LoadedPlugins() => this.set_Plugins(new List<string>());

    [SpecialName]
    public List<string> get_Plugins() => this._Plugins;

    [SpecialName]
    public void set_Plugins(List<string> value) => this._Plugins = value;

    public ushort Port { [SpecialName] get; [SpecialName] set; }
  }
}
