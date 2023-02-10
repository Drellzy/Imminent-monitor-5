// Decompiled with JetBrains decompiler
// Type: GClass26
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

[StandardModule]
public sealed class GClass26
{
  private static string string_0 = Application.StartupPath + "\\Settings\\Profiles\\";

  public static void smethod_0(string string_1, ProfileSettings profileSettings_0)
  {
    using (StreamWriter streamWriter = new StreamWriter(string.Format("{0}\\{1}.settings", (object) GClass26.string_0, (object) string_1)))
      XmlSerializer.FromTypes(new System.Type[1]
      {
        typeof (ProfileSettings)
      })[0].Serialize((TextWriter) streamWriter, (object) profileSettings_0);
  }

  public static ProfileSettings smethod_1(string string_1)
  {
    using (StreamReader streamReader = new StreamReader(string.Format("{0}\\{1}.settings", (object) GClass26.string_0, (object) string_1)))
      return (ProfileSettings) XmlSerializer.FromTypes(new System.Type[1]
      {
        typeof (ProfileSettings)
      })[0].Deserialize((TextReader) streamReader);
  }
}
