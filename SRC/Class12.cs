// Decompiled with JetBrains decompiler
// Type: Class12
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Reflection;
using System.Security;

internal static class Class12
{
  private static readonly bool bool_0 = Class12.smethod_0();

  private static bool smethod_0()
  {
    try
    {
      if (Environment.Version.Major < 4)
        return false;
      Assembly assembly1 = typeof (Class39).Assembly;
      Assembly assembly2 = typeof (SecurityCriticalAttribute).Assembly;
      bool flag = false;
      foreach (object customAttribute in assembly1.GetCustomAttributes(false))
      {
        if (customAttribute is AllowPartiallyTrustedCallersAttribute)
        {
          flag = true;
        }
        else
        {
          Type type = customAttribute.GetType();
          if ((object) type.Assembly == (object) assembly2 && "System.Security.SecurityRulesAttribute".Equals(type.FullName, StringComparison.Ordinal) && (byte) type.GetProperty("RuleSet").GetValue(customAttribute, (object[]) null) != (byte) 2)
            return false;
        }
      }
      return flag;
    }
    catch
    {
      return false;
    }
  }

  public static bool smethod_1() => Class12.bool_0;
}
