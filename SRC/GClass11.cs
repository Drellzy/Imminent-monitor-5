// Decompiled with JetBrains decompiler
// Type: GClass11
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using MaxMind.Db;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net;
using System.Windows.Forms;

public sealed class GClass11
{
  private SQLiteConnection sqliteConnection_0;

  public GClass11()
  {
    this.sqliteConnection_0 = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\Resources\\Databases\\geoip.sqlite");
    this.sqliteConnection_0.Open();
  }

  private string method_0(string string_0)
  {
    string str;
    try
    {
      SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
      if (this.method_3(string_0) == 0)
      {
        str = "0";
      }
      else
      {
        command.CommandText = string.Format("SELECT country FROM ip2nation WHERE ip < {0} ORDER BY ip DESC LIMIT 0,1", (object) this.method_3(string_0));
        SQLiteDataReader sqLiteDataReader = command.ExecuteReader();
        str = sqLiteDataReader.Read() ? sqLiteDataReader.GetString(0) : "0";
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = "0";
      ProjectData.ClearProjectError();
    }
    return str;
  }

  public string method_1(string string_0)
  {
    string str;
    try
    {
      string Left = this.method_0(string_0);
      if (Operators.CompareString(Left, "0", false) == 0)
      {
        str = "0";
      }
      else
      {
        SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
        command.CommandText = string.Format("SELECT country FROM ip2nationcountries WHERE code='{0}'", (object) Left);
        SQLiteDataReader sqLiteDataReader = command.ExecuteReader();
        str = sqLiteDataReader.Read() ? sqLiteDataReader.GetString(0) : "0";
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = "0";
      ProjectData.ClearProjectError();
    }
    return str;
  }

  public string method_2(string string_0)
  {
    string str;
    try
    {
      using (Reader reader = new Reader(Application.StartupPath + "\\Resources\\Databases\\maxmind.mmdb"))
      {
        IPAddress ipAddress = IPAddress.Parse(string_0);
        Dictionary<string, object> dictionary1 = reader.Find<Dictionary<string, object>>(ipAddress, (InjectableValues) null);
        if (dictionary1 != null)
        {
          if (dictionary1.ContainsKey("country"))
          {
            Dictionary<string, object> dictionary2 = (Dictionary<string, object>) dictionary1["country"];
            if (dictionary2.ContainsKey("names"))
            {
              str = Conversions.ToString(((Dictionary<string, object>) dictionary2["names"])["en"]);
              goto label_8;
            }
          }
        }
      }
      str = this.method_1(string_0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = this.method_1(string_0);
      ProjectData.ClearProjectError();
    }
label_8:
    return str;
  }

  private int method_3(string string_0)
  {
    int num;
    try
    {
      byte[] addressBytes = IPAddress.Parse(string_0).GetAddressBytes();
      num = (int) (((uint) addressBytes[0] << 24) + ((uint) addressBytes[1] << 16) + ((uint) addressBytes[2] << 8) + (uint) addressBytes[3]);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0;
      ProjectData.ClearProjectError();
    }
    return num;
  }
}
