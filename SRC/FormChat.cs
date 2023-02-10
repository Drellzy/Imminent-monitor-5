// Decompiled with JetBrains decompiler
// Type: FormChat
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
public sealed class FormChat : Form
{
  private IContainer icontainer_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;
  public GClass18 gclass18_0;
  public string string_0;

  public FormChat(GClass18 gclass18_1)
  {
    this.FormClosing += new FormClosingEventHandler(this.FormChat_FormClosing);
    this.MinimumSize = new Size(532, 512);
    this.gclass18_0 = gclass18_1;
    this.method_0();
    this.InitializeComponent();
    this.method_1();
    this.Text = string.Format("{0}/{1}", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormChat));
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.ClientSize = new Size(516, 473);
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormChat);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.ResumeLayout(false);
  }

  public virtual ChromiumWebBrowser vmethod_0() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_1(ChromiumWebBrowser chromiumWebBrowser_1) => this.chromiumWebBrowser_0 = chromiumWebBrowser_1;

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_0()
  {
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\chat.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      ProjectData.EndApp();
    }
    this.vmethod_1(new ChromiumWebBrowser(path));
    ((Control) this.vmethod_0()).AllowDrop = false;
    ((Control) this.vmethod_0()).Dock = DockStyle.Fill;
    this.Controls.Add((Control) this.vmethod_0());
    this.vmethod_0().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 0
    };
    this.vmethod_0().RegisterJsObject("chat", (object) new ChatCefHandler(this), (BindingOptions) null);
  }

  private void method_1()
  {
    string Left = (string) null;
    FormDialog formDialog = new FormDialog(false, "Chat", "Please enter your display name");
    if (formDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      Left = formDialog.vmethod_4().Text;
    if (Operators.CompareString(Left, (string) null, false) != 0)
    {
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
      {
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Chat,
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ChatHeaderPacket.ShowChat,
        (object) Left
      });
      this.string_0 = Left;
    }
    else
      this.Close();
  }

  public void method_2(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Chat,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ChatHeaderPacket.Message,
    (object) string_1
  });

  public void method_3(object[] object_0) => this.method_4("chat", Class97.smethod_21((string) object_0[2]), this.gclass18_0.method_20().string_1[0].ToString().ToUpper());

  public void method_4(string string_1, string string_2, string string_3)
  {
    string string_4 = "$('.chats').append('" + string.Format(Class145.smethod_15(), (object) string_1, (object) string_2, (object) DateTime.Now.ToShortTimeString(), (object) string_3).Replace(Environment.NewLine, string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty).Replace("'", "\\'") + "');$(window).scrollTop($(document).height());";
    Class97.smethod_20(this.vmethod_0(), string_4);
  }

  private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Chat,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ChatHeaderPacket.CloseChat
    });
    ((Component) this.vmethod_0()).Dispose();
  }
}
