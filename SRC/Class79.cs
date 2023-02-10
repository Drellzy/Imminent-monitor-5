// Decompiled with JetBrains decompiler
// Type: Class79
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

internal static class Class79
{
  public static bool smethod_0(int[] int_0, int[] int_1)
  {
    if (int_0 == int_1)
      return true;
    if (int_0 == null || int_1 == null || int_0.Length != int_1.Length)
      return false;
    for (int index = 0; index < int_0.Length; ++index)
    {
      if (int_0[index] != int_1[index])
        return false;
    }
    return true;
  }
}
