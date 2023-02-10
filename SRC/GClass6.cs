// Decompiled with JetBrains decompiler
// Type: GClass6
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

public sealed class GClass6
{
  private bool bool_0;

  public GClass6() => this.bool_0 = false;

  public bool method_0(string string_0)
  {
    this.bool_0 = false;
    if (string.IsNullOrEmpty(string_0))
      return false;
    string_0 = Regex.Replace(string_0, "(@)(.+)$", new MatchEvaluator(this.method_1));
    return !this.bool_0 && Regex.IsMatch(string_0, "^(?(\")(\"[^\"]+?\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9]{2,17}))$", RegexOptions.IgnoreCase);
  }

  private string method_1(Match match_0)
  {
    IdnMapping idnMapping = new IdnMapping();
    string ascii = match_0.Groups[2].Value;
    try
    {
      ascii = idnMapping.GetAscii(ascii);
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.bool_0 = true;
      ProjectData.ClearProjectError();
    }
    return match_0.Groups[1].Value + ascii;
  }
}
