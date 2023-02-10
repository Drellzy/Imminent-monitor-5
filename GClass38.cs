// Decompiled with JetBrains decompiler
// Type: GClass38
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

[StandardModule]
public sealed class GClass38
{
  public static string string_0 = Application.StartupPath + "\\Settings\\User\\LoadedPlugins.xml";

  public static void smethod_0(LoadedPlugins loadedPlugins_0)
  {
    using (StreamWriter streamWriter = new StreamWriter(GClass38.string_0))
      XmlSerializer.FromTypes(new System.Type[1]
      {
        typeof (LoadedPlugins)
      })[0].Serialize((TextWriter) streamWriter, (object) loadedPlugins_0);
  }

  public static LoadedPlugins smethod_1()
  {
    LoadedPlugins loadedPlugins;
    try
    {
      if (File.Exists(GClass38.string_0))
      {
        using (StreamReader streamReader = new StreamReader(GClass38.string_0))
          loadedPlugins = (LoadedPlugins) XmlSerializer.FromTypes(new System.Type[1]
          {
            typeof (LoadedPlugins)
          })[0].Deserialize((TextReader) streamReader);
      }
      else
        loadedPlugins = (LoadedPlugins) null;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      loadedPlugins = (LoadedPlugins) null;
      ProjectData.ClearProjectError();
    }
    return loadedPlugins;
  }
}
