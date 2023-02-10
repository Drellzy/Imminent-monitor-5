// Decompiled with JetBrains decompiler
// Type: FormLogin
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
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormLogin : Form
{
  private IContainer icontainer_0;
  private Control0 control0_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;
  public bool bool_0;
  public GClass1 gclass1_0;
  private GClass35 gclass35_0;
  private bool bool_1;

  public FormLogin(GClass1 gclass1_1, GClass35 gclass35_1)
  {
    this.FormClosing += new FormClosingEventHandler(this.FormLogin_FormClosing);
    this.Load += new EventHandler(this.FormLogin_Load);
    this.bool_0 = false;
    this.bool_1 = false;
    this.method_0();
    this.method_3();
    using (Graphics graphics = this.CreateGraphics())
      Class97.float_0 = graphics.DpiX;
    CefSharp.Cef.EnableHighDPISupport();
    CefSharpSettings.WcfTimeout = TimeSpan.Zero;
    this.InitializeComponent();
    this.gclass1_0 = gclass1_1;
    this.vmethod_5(gclass35_1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormLogin));
    this.vmethod_1(new Control0());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().BackColor = Color.Transparent;
    this.vmethod_0().ForeColor = Color.White;
    this.vmethod_0().method_3((Control0.Enum9) 0);
    this.vmethod_0().Location = new Point(0, 386);
    this.vmethod_0().Name = "Preloader1";
    this.vmethod_0().method_1(5);
    Control0 control0 = this.vmethod_0();
    Size size1 = new Size(808, 11);
    Size size2 = size1;
    control0.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Text = "Preloader1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(51, 67, 163);
    size1 = new Size(808, 782);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormLogin);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Version: 5.0.0.82";
    this.ResumeLayout(false);
  }

  internal virtual Control0 vmethod_0() => this.control0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Control0 control0_1) => this.control0_0 = control0_1;

  public virtual ChromiumWebBrowser vmethod_2() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_3(ChromiumWebBrowser chromiumWebBrowser_1)
  {
    EventHandler<FrameLoadEndEventArgs> eventHandler = new EventHandler<FrameLoadEndEventArgs>(this.method_9);
    if (this.chromiumWebBrowser_0 != null)
      this.chromiumWebBrowser_0.FrameLoadEnd -= eventHandler;
    this.chromiumWebBrowser_0 = chromiumWebBrowser_1;
    if (this.chromiumWebBrowser_0 == null)
      return;
    this.chromiumWebBrowser_0.FrameLoadEnd += eventHandler;
  }

  private virtual GClass35 vmethod_4() => this.gclass35_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  private virtual void vmethod_5(GClass35 gclass35_1)
  {
    GClass35.GDelegate18 gdelegate18_1 = new GClass35.GDelegate18(this.method_11);
    if (this.gclass35_0 != null)
      this.gclass35_0.method_3(gdelegate18_1);
    this.gclass35_0 = gclass35_1;
    if (this.gclass35_0 == null)
      return;
    this.gclass35_0.method_2(gdelegate18_1);
  }

  private void method_0()
  {
label_0:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = 1;
label_1:
      int num3 = 2;
      this.method_1(Application.StartupPath + "\\Newtonsoft.Json.dll");
label_2:
      num3 = 3;
      this.method_1(Application.StartupPath + "\\PluginCompiler.exe");
label_3:
      num3 = 4;
      this.method_1(Application.StartupPath + "\\SlimDX.dll");
label_4:
      num3 = 5;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.BrowserSubprocess.Core.pdb");
label_5:
      num3 = 6;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.BrowserSubprocess.pdb");
label_6:
      num3 = 7;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.BrowserSubprocess.exe");
label_7:
      num3 = 8;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.Core.pdb");
label_8:
      num3 = 9;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.Core.xml");
label_9:
      num3 = 10;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.pdb");
label_10:
      num3 = 11;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.WinForms.pdb");
label_11:
      num3 = 12;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.WinForms.xml");
label_12:
      num3 = 13;
      this.method_1(Application.StartupPath + "\\bin\\cef\\CefSharp.xml");
label_13:
      num3 = 14;
      this.method_1(Application.StartupPath + "\\bin\\cef\\d3dcompiler_43.dll");
label_14:
      num3 = 15;
      this.method_1(Application.StartupPath + "\\Resources\\Imminent Monitor Dedicated Server.exe");
      goto label_21;
label_16:
      num2 = num3;
      switch (num1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_0;
            case 2:
              goto label_1;
            case 3:
              goto label_2;
            case 4:
              goto label_3;
            case 5:
              goto label_4;
            case 6:
              goto label_5;
            case 7:
              goto label_6;
            case 8:
              goto label_7;
            case 9:
              goto label_8;
            case 10:
              goto label_9;
            case 11:
              goto label_10;
            case 12:
              goto label_11;
            case 13:
              goto label_12;
            case 14:
              goto label_13;
            case 15:
              goto label_14;
            case 16:
              goto label_21;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_16;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_21:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void method_1(string string_0)
  {
    if (!File.Exists(string_0))
      return;
    File.Delete(string_0);
  }

  private void method_2(string string_0)
  {
    if (!Directory.Exists(string_0))
      return;
    Directory.Delete(string_0);
  }

  private void method_3()
  {
    try
    {
      Process process = new Process();
      process.StartInfo.FileName = Application.StartupPath + "\\Resources\\Redist\\SlimDX.msi";
      process.StartInfo.Arguments = "/quiet";
      process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      process.Start();
      process.WaitForExit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void method_4(bool bool_2, string string_0)
  {
    if (bool_2)
    {
      // ISSUE: reference to a compiler-generated method
      Class137.smethod_0().set_Username(string_0);
      Class137.smethod_0().Save();
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      Class137.smethod_0().set_Username(string.Empty);
      Class137.smethod_0().Save();
    }
  }

  private void method_5()
  {
    // ISSUE: reference to a compiler-generated method
    string Left = Class137.smethod_0().get_Username();
    if (Operators.CompareString(Left, string.Empty, false) == 0)
      return;
    Class97.smethod_20(this.vmethod_2(), string.Format("$('#inputCheckbox').prop('checked', true);$('#username').val('{0}');", (object) Left));
    Class97.smethod_20(this.vmethod_2(), "simulateKeyPress();");
  }

  public void method_6()
  {
    foreach (Process process in Process.GetProcessesByName("Imminent.Cef"))
      process.Kill();
  }

  public void method_7() => ((Component) this.vmethod_2()).Dispose();

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_8()
  {
    CefSharp.Cef.Initialize(new CefSettings()
    {
      BrowserSubprocessPath = Application.StartupPath + "\\bin\\cef\\Imminent.Cef.exe"
    });
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\login.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      ProjectData.EndApp();
    }
    BrowserSettings browserSettings = new BrowserSettings();
    browserSettings.FileAccessFromFileUrls = (CefState) 1;
    browserSettings.UniversalAccessFromFileUrls = (CefState) 1;
    browserSettings.WebSecurity = (CefState) 0;
    this.vmethod_3(new ChromiumWebBrowser(path));
    this.vmethod_2().BrowserSettings = browserSettings;
    ((Control) this.vmethod_2()).AllowDrop = false;
    ((Control) this.vmethod_2()).Location = new Point(-1920, -1080);
    ((Control) this.vmethod_2()).Size = new Size(824, 821);
    ((Control) this.vmethod_2()).Dock = DockStyle.None;
    this.Controls.Add((Control) this.vmethod_2());
    ((Control) this.vmethod_2()).Hide();
    this.vmethod_2().RegisterJsObject("login", (object) new LoginCefHandler(this), (BindingOptions) null);
  }

  private void method_9(object sender, FrameLoadEndEventArgs e)
  {
    this.method_5();
    new Thread(new ThreadStart(this.method_10)).Start();
  }

  private void method_10()
  {
    Thread.Sleep(4000);
    this.Invoke((Delegate) (() =>
    {
      ((Control) this.vmethod_2()).Show();
      this.vmethod_0().Visible = false;
      ((Control) this.vmethod_2()).Dock = DockStyle.Fill;
    }));
    this.bool_1 = true;
    new Thread(new ThreadStart(this.method_13)).Start();
  }

  private void method_11()
  {
    if (File.Exists("dont"))
      return;
    this.Invoke((Delegate) new Delegate0(new FormLogin.Class154()
    {
      formUpdate_0 = new FormUpdate(this.vmethod_4())
    }._Lambda\u0024__51));
  }

  private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this.bool_0)
      return;
    this.method_12();
  }

  public void method_12()
  {
    try
    {
      this.bool_1 = false;
      foreach (Process process in Process.GetProcessesByName("Imminent.Cef"))
        process.Kill();
      Process.GetCurrentProcess().Kill();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_13()
  {
    while (this.bool_1)
    {
      if (!this.gclass1_0.bool_0)
      {
        Thread.Sleep(1000);
      }
      else
      {
        this.gclass1_0.method_22();
        this.bool_1 = false;
        break;
      }
    }
  }

  private void FormLogin_Load(object sender, EventArgs e) => this.method_8();

  internal sealed class Class154
  {
    public FormUpdate formUpdate_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__51()
    {
      this.formUpdate_0.TopMost = true;
      int num = (int) this.formUpdate_0.ShowDialog();
    }
  }
}
