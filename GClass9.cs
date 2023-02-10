// Decompiled with JetBrains decompiler
// Type: GClass9
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Collections.Generic;
using System.Xml;

public sealed class GClass9
{
  public List<GClass44> list_0;

  public GClass9()
  {
    this.list_0 = new List<GClass44>();
    this.list_0.Add(new GClass44());
    this.list_0.Add(this.method_0(Class145.smethod_54()));
    this.list_0.Add(this.method_0(Class145.smethod_17()));
    this.list_0.Add(this.method_0(Class145.smethod_66()));
    this.list_0.Add(this.method_0(Class145.smethod_12()));
    this.list_0.Add(this.method_0(Class145.smethod_57()));
    this.list_0.Add(new GClass44());
    this.list_0.Add(this.method_0(Class145.smethod_60()));
    this.list_0.Add(this.method_0(Class145.smethod_69()));
    this.list_0.Add(this.method_0(Class145.smethod_55()));
    this.list_0.Add(this.method_0(Class145.smethod_16()));
    this.list_0.Add(new GClass44());
    this.list_0.Add(this.method_0(Class145.smethod_64()));
    this.list_0.Add(this.method_0(Class145.smethod_63()));
    this.list_0.Add(new GClass44());
  }

  private GClass44 method_0(string string_0)
  {
    new XmlDocument().LoadXml(string_0);
    return new GClass44();
  }
}
