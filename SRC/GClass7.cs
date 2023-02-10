// Decompiled with JetBrains decompiler
// Type: GClass7
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
public sealed class GClass7
{
  private static string string_0 = Application.StartupPath + "\\Settings\\User\\GeneralSettings.xml";

  public static void smethod_0(GeneralSettingsLegacy generalSettingsLegacy_0)
  {
    try
    {
      using (StreamWriter streamWriter = new StreamWriter(GClass7.string_0))
        XmlSerializer.FromTypes(new System.Type[1]
        {
          typeof (GeneralSettingsLegacy)
        })[0].Serialize((TextWriter) streamWriter, (object) generalSettingsLegacy_0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public static GeneralSettingsLegacy smethod_1()
  {
    GeneralSettingsLegacy generalSettingsLegacy;
    try
    {
      using (StreamReader streamReader = new StreamReader(GClass7.string_0))
        generalSettingsLegacy = (GeneralSettingsLegacy) XmlSerializer.FromTypes(new System.Type[1]
        {
          typeof (GeneralSettingsLegacy)
        })[0].Deserialize((TextReader) streamReader);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      generalSettingsLegacy = (GeneralSettingsLegacy) null;
      ProjectData.ClearProjectError();
    }
    return generalSettingsLegacy;
  }
}
