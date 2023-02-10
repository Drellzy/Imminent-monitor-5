// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.DesktopSettings
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class DesktopSettings
  {
    public bool ViewMotionDetection;
    public bool ViewNetworkStats;
    public bool DynamicResizing;
    public int FPSLimit;
    public int Quality;

    public DesktopSettings()
    {
      this.ViewMotionDetection = false;
      this.ViewNetworkStats = false;
      this.DynamicResizing = false;
      this.FPSLimit = 24;
      this.Quality = 45;
    }
  }
}
