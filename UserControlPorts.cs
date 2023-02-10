// Decompiled with JetBrains decompiler
// Type: UserControlPorts
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlPorts : UserControl
{
  private IContainer icontainer_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ImageList imageList_0;
  private Panel panel_0;
  private Button button_0;
  private Button button_1;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private Panel panel_1;
  private LinkLabel linkLabel_0;
  private ContextMenuStrip contextMenuStrip_1;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private GControl1 gcontrol1_0;
  private LinkLabel linkLabel_1;
  private GControl1 gcontrol1_1;
  private GControl1 gcontrol1_2;
  private LinkLabel linkLabel_2;
  public static CookieContainer cookieContainer_0 = new CookieContainer();

  public UserControlPorts()
  {
    this.Load += new EventHandler(this.UserControlPorts_Load);
    this.AutoSize = true;
    this.InitializeComponent();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlPorts));
    this.vmethod_1(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_3(new ToolStripMenuItem());
    this.vmethod_5(new ToolStripMenuItem());
    this.vmethod_7(new ToolStripSeparator());
    this.vmethod_9(new ToolStripMenuItem());
    this.vmethod_11(new ImageList(this.icontainer_0));
    this.vmethod_13(new Panel());
    this.vmethod_37(new GControl1());
    this.vmethod_15(new Button());
    this.vmethod_17(new Button());
    this.vmethod_19(new GClass41());
    this.vmethod_21(new ColumnHeader());
    this.vmethod_23(new ColumnHeader());
    this.vmethod_25(new ColumnHeader());
    this.vmethod_27(new Panel());
    this.vmethod_43(new GControl1());
    this.vmethod_45(new LinkLabel());
    this.vmethod_39(new LinkLabel());
    this.vmethod_41(new GControl1());
    this.vmethod_29(new LinkLabel());
    this.vmethod_31(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_33(new ToolStripMenuItem());
    this.vmethod_35(new ToolStripMenuItem());
    this.vmethod_0().SuspendLayout();
    this.vmethod_12().SuspendLayout();
    this.vmethod_26().SuspendLayout();
    this.vmethod_30().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_0().Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.vmethod_2(),
      (ToolStripItem) this.vmethod_4(),
      (ToolStripItem) this.vmethod_6(),
      (ToolStripItem) this.vmethod_8()
    });
    this.vmethod_0().Name = "ContextMenuStripPorts";
    ContextMenuStrip contextMenuStrip1 = this.vmethod_0();
    Size size1 = new Size(187, 76);
    Size size2 = size1;
    contextMenuStrip1.Size = size2;
    this.vmethod_2().Image = (Image) Class145.smethod_58();
    this.vmethod_2().Name = "AddPortToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_2();
    size1 = new Size(186, 22);
    Size size3 = size1;
    toolStripMenuItem1.Size = size3;
    this.vmethod_2().Text = "Add";
    this.vmethod_4().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_4().Image = (Image) Class145.smethod_22();
    this.vmethod_4().Name = "RemovePortToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_4();
    size1 = new Size(186, 22);
    Size size4 = size1;
    toolStripMenuItem2.Size = size4;
    this.vmethod_4().Text = "Remove";
    this.vmethod_6().Name = "ToolStripSeparator2";
    ToolStripSeparator toolStripSeparator = this.vmethod_6();
    size1 = new Size(183, 6);
    Size size5 = size1;
    toolStripSeparator.Size = size5;
    this.vmethod_6().Tag = (object) "SEPERATOR";
    this.vmethod_8().Image = (Image) Class145.smethod_34();
    this.vmethod_8().Name = "CheckPortToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_8();
    size1 = new Size(186, 22);
    Size size6 = size1;
    toolStripMenuItem3.Size = size6;
    this.vmethod_8().Text = "Check Port Is Open";
    this.vmethod_10().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListPorts.ImageStream");
    this.vmethod_10().TransparentColor = Color.Transparent;
    this.vmethod_10().Images.SetKeyName(0, "network-hub.png");
    this.vmethod_12().Controls.Add((Control) this.vmethod_36());
    this.vmethod_12().Controls.Add((Control) this.vmethod_14());
    this.vmethod_12().Controls.Add((Control) this.vmethod_16());
    this.vmethod_12().Controls.Add((Control) this.vmethod_18());
    this.vmethod_12().Dock = DockStyle.Fill;
    Panel panel1 = this.vmethod_12();
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    panel1.Location = point2;
    this.vmethod_12().Name = "Panel1";
    Panel panel2 = this.vmethod_12();
    size1 = new Size(769, 448);
    Size size7 = size1;
    panel2.Size = size7;
    this.vmethod_12().TabIndex = 13;
    this.vmethod_36().method_1((GControl1.GEnum0) 1);
    this.vmethod_36().Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    GControl1 gcontrol1_1 = this.vmethod_36();
    point1 = new Point(4, 443);
    Point point3 = point1;
    gcontrol1_1.Location = point3;
    this.vmethod_36().Name = "Seperator2";
    GControl1 gcontrol1_2 = this.vmethod_36();
    size1 = new Size(759, 6);
    Size size8 = size1;
    gcontrol1_2.Size = size8;
    this.vmethod_36().TabIndex = 13;
    this.vmethod_36().Text = "Seperator2";
    this.vmethod_14().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_14().Enabled = false;
    this.vmethod_14().ImageAlign = ContentAlignment.MiddleRight;
    Button button1 = this.vmethod_14();
    point1 = new Point(647, 417);
    Point point4 = point1;
    button1.Location = point4;
    this.vmethod_14().Name = "ButtonStopListen";
    Button button2 = this.vmethod_14();
    size1 = new Size(117, 25);
    Size size9 = size1;
    button2.Size = size9;
    this.vmethod_14().TabIndex = 10;
    this.vmethod_14().Text = "Stop Listening";
    this.vmethod_14().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_14().UseVisualStyleBackColor = true;
    this.vmethod_16().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_16().ImageAlign = ContentAlignment.MiddleRight;
    Button button3 = this.vmethod_16();
    point1 = new Point(517, 417);
    Point point5 = point1;
    button3.Location = point5;
    this.vmethod_16().Name = "ButtonStartListen";
    Button button4 = this.vmethod_16();
    size1 = new Size(125, 25);
    Size size10 = size1;
    button4.Size = size10;
    this.vmethod_16().TabIndex = 9;
    this.vmethod_16().Text = "Start Listening";
    this.vmethod_16().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_16().UseVisualStyleBackColor = true;
    this.vmethod_18().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_18().Columns.AddRange(new ColumnHeader[3]
    {
      this.vmethod_20(),
      this.vmethod_22(),
      this.vmethod_24()
    });
    this.vmethod_18().ContextMenuStrip = this.vmethod_0();
    this.vmethod_18().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_18().FullRowSelect = true;
    this.vmethod_18().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_18();
    point1 = new Point(4, 3);
    Point point6 = point1;
    gclass41_1.Location = point6;
    this.vmethod_18().Name = "AeroListviewPorts";
    this.vmethod_18().OwnerDraw = true;
    GClass41 gclass41_2 = this.vmethod_18();
    size1 = new Size(759, 408);
    Size size11 = size1;
    gclass41_2.Size = size11;
    this.vmethod_18().SmallImageList = this.vmethod_10();
    this.vmethod_18().TabIndex = 8;
    this.vmethod_18().UseCompatibleStateImageBehavior = false;
    this.vmethod_18().View = View.Details;
    this.vmethod_20().Text = "Port";
    this.vmethod_20().Width = 114;
    this.vmethod_22().Text = "Connections";
    this.vmethod_22().Width = 152;
    this.vmethod_24().Text = "Status";
    this.vmethod_24().Width = 424;
    this.vmethod_26().Controls.Add((Control) this.vmethod_42());
    this.vmethod_26().Controls.Add((Control) this.vmethod_44());
    this.vmethod_26().Controls.Add((Control) this.vmethod_38());
    this.vmethod_26().Controls.Add((Control) this.vmethod_40());
    this.vmethod_26().Controls.Add((Control) this.vmethod_28());
    this.vmethod_26().Dock = DockStyle.Bottom;
    Panel panel3 = this.vmethod_26();
    point1 = new Point(0, 448);
    Point point7 = point1;
    panel3.Location = point7;
    this.vmethod_26().Name = "Panel2";
    Panel panel4 = this.vmethod_26();
    size1 = new Size(769, 23);
    Size size12 = size1;
    panel4.Size = size12;
    this.vmethod_26().TabIndex = 14;
    this.vmethod_42().method_1((GControl1.GEnum0) 0);
    this.vmethod_42().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    GControl1 gcontrol1_3 = this.vmethod_42();
    point1 = new Point(311, 4);
    Point point8 = point1;
    gcontrol1_3.Location = point8;
    this.vmethod_42().Name = "Seperator1";
    GControl1 gcontrol1_4 = this.vmethod_42();
    size1 = new Size(11, 15);
    Size size13 = size1;
    gcontrol1_4.Size = size13;
    this.vmethod_42().TabIndex = 22;
    this.vmethod_42().Text = "Seperator1";
    this.vmethod_44().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_44().AutoSize = true;
    LinkLabel linkLabel1 = this.vmethod_44();
    point1 = new Point(328, 6);
    Point point9 = point1;
    linkLabel1.Location = point9;
    this.vmethod_44().Name = "LinkLabelGen";
    LinkLabel linkLabel2 = this.vmethod_44();
    size1 = new Size(158, 13);
    Size size14 = size1;
    linkLabel2.Size = size14;
    this.vmethod_44().TabIndex = 21;
    this.vmethod_44().TabStop = true;
    this.vmethod_44().Text = "Generate Swift Support Code";
    this.vmethod_38().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_38().AutoSize = true;
    LinkLabel linkLabel3 = this.vmethod_38();
    point1 = new Point(3, 6);
    Point point10 = point1;
    linkLabel3.Location = point10;
    this.vmethod_38().Name = "LinkLabelDediConnect";
    LinkLabel linkLabel4 = this.vmethod_38();
    size1 = new Size(142, 13);
    Size size15 = size1;
    linkLabel4.Size = size15;
    this.vmethod_38().TabIndex = 20;
    this.vmethod_38().TabStop = true;
    this.vmethod_38().Text = "Dedicated Server Manager";
    this.vmethod_40().method_1((GControl1.GEnum0) 0);
    this.vmethod_40().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    GControl1 gcontrol1_5 = this.vmethod_40();
    point1 = new Point(147, 4);
    Point point11 = point1;
    gcontrol1_5.Location = point11;
    this.vmethod_40().Name = "Seperator3";
    GControl1 gcontrol1_6 = this.vmethod_40();
    size1 = new Size(11, 15);
    Size size16 = size1;
    gcontrol1_6.Size = size16;
    this.vmethod_40().TabIndex = 19;
    this.vmethod_40().Text = "Seperator3";
    this.vmethod_28().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_28().AutoSize = true;
    LinkLabel linkLabel5 = this.vmethod_28();
    point1 = new Point(164, 6);
    Point point12 = point1;
    linkLabel5.Location = point12;
    this.vmethod_28().Name = "LinkLabelDediHelp";
    LinkLabel linkLabel6 = this.vmethod_28();
    size1 = new Size(147, 13);
    Size size17 = size1;
    linkLabel6.Size = size17;
    this.vmethod_28().TabIndex = 18;
    this.vmethod_28().TabStop = true;
    this.vmethod_28().Text = "What is a dedicated server?";
    this.vmethod_30().Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_32(),
      (ToolStripItem) this.vmethod_34()
    });
    this.vmethod_30().Name = "ContextMenuStrip1";
    ContextMenuStrip contextMenuStrip2 = this.vmethod_30();
    size1 = new Size(118, 48);
    Size size18 = size1;
    contextMenuStrip2.Size = size18;
    this.vmethod_32().Image = (Image) Class145.smethod_58();
    this.vmethod_32().Name = "AddToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem4 = this.vmethod_32();
    size1 = new Size(117, 22);
    Size size19 = size1;
    toolStripMenuItem4.Size = size19;
    this.vmethod_32().Text = "Add";
    this.vmethod_34().Image = (Image) Class145.smethod_22();
    this.vmethod_34().Name = "RemoveToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem5 = this.vmethod_34();
    size1 = new Size(117, 22);
    Size size20 = size1;
    toolStripMenuItem5.Size = size20;
    this.vmethod_34().Text = "Remove";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_26());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlPorts);
    size1 = new Size(769, 471);
    this.Size = size1;
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_12().ResumeLayout(false);
    this.vmethod_26().ResumeLayout(false);
    this.vmethod_26().PerformLayout();
    this.vmethod_30().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual ContextMenuStrip vmethod_0() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ContextMenuStrip contextMenuStrip_2) => this.contextMenuStrip_0 = contextMenuStrip_2;

  internal virtual ToolStripMenuItem vmethod_2() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ToolStripMenuItem toolStripMenuItem_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_5;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_4() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ToolStripMenuItem toolStripMenuItem_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_6);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_5;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_6() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_8() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_7);
    if (this.toolStripMenuItem_2 != null)
      this.toolStripMenuItem_2.Click -= eventHandler;
    this.toolStripMenuItem_2 = toolStripMenuItem_5;
    if (this.toolStripMenuItem_2 == null)
      return;
    this.toolStripMenuItem_2.Click += eventHandler;
  }

  internal virtual ImageList vmethod_10() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ImageList imageList_1) => this.imageList_0 = imageList_1;

  internal virtual Panel vmethod_12() => this.panel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(Panel panel_2) => this.panel_0 = panel_2;

  internal virtual Button vmethod_14() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_14);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_2;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual Button vmethod_16() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_13);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual GClass41 vmethod_18() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(GClass41 gclass41_1) => this.gclass41_0 = gclass41_1;

  internal virtual ColumnHeader vmethod_20() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ColumnHeader columnHeader_3) => this.columnHeader_0 = columnHeader_3;

  internal virtual ColumnHeader vmethod_22() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ColumnHeader columnHeader_3) => this.columnHeader_1 = columnHeader_3;

  internal virtual ColumnHeader vmethod_24() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(ColumnHeader columnHeader_3) => this.columnHeader_2 = columnHeader_3;

  internal virtual Panel vmethod_26() => this.panel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(Panel panel_2) => this.panel_1 = panel_2;

  internal virtual LinkLabel vmethod_28() => this.linkLabel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(LinkLabel linkLabel_3)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_16);
    if (this.linkLabel_0 != null)
      this.linkLabel_0.LinkClicked -= clickedEventHandler;
    this.linkLabel_0 = linkLabel_3;
    if (this.linkLabel_0 == null)
      return;
    this.linkLabel_0.LinkClicked += clickedEventHandler;
  }

  internal virtual ContextMenuStrip vmethod_30() => this.contextMenuStrip_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(ContextMenuStrip contextMenuStrip_2) => this.contextMenuStrip_1 = contextMenuStrip_2;

  internal virtual ToolStripMenuItem vmethod_32() => this.toolStripMenuItem_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(ToolStripMenuItem toolStripMenuItem_5) => this.toolStripMenuItem_3 = toolStripMenuItem_5;

  internal virtual ToolStripMenuItem vmethod_34() => this.toolStripMenuItem_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(ToolStripMenuItem toolStripMenuItem_5) => this.toolStripMenuItem_4 = toolStripMenuItem_5;

  internal virtual GControl1 vmethod_36() => this.gcontrol1_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_37(GControl1 gcontrol1_3) => this.gcontrol1_0 = gcontrol1_3;

  internal virtual LinkLabel vmethod_38() => this.linkLabel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_39(LinkLabel linkLabel_3)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_15);
    if (this.linkLabel_1 != null)
      this.linkLabel_1.LinkClicked -= clickedEventHandler;
    this.linkLabel_1 = linkLabel_3;
    if (this.linkLabel_1 == null)
      return;
    this.linkLabel_1.LinkClicked += clickedEventHandler;
  }

  internal virtual GControl1 vmethod_40() => this.gcontrol1_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_41(GControl1 gcontrol1_3) => this.gcontrol1_1 = gcontrol1_3;

  internal virtual GControl1 vmethod_42() => this.gcontrol1_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_43(GControl1 gcontrol1_3) => this.gcontrol1_2 = gcontrol1_3;

  internal virtual LinkLabel vmethod_44() => this.linkLabel_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_45(LinkLabel linkLabel_3)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_17);
    if (this.linkLabel_2 != null)
      this.linkLabel_2.LinkClicked -= clickedEventHandler;
    this.linkLabel_2 = linkLabel_3;
    if (this.linkLabel_2 == null)
      return;
    this.linkLabel_2.LinkClicked += clickedEventHandler;
  }

  private void UserControlPorts_Load(object sender, EventArgs e)
  {
    this.method_0();
    Class97.smethod_15(this.vmethod_0());
    Class97.smethod_15(this.vmethod_30());
  }

  private void method_0()
  {
    Control control_0 = (Control) this;
    List<Control> controlList = control_0.smethod_1();
    try
    {
      foreach (Control control in controlList)
      {
        if (control is Button)
        {
          Button button = (Button) control;
          button.Image = Class97.smethod_4(button.Name);
        }
      }
    }
    finally
    {
      List<Control>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public void method_1()
  {
    if (this.vmethod_18().Items.Count == 0)
      return;
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_18().Items)
      {
        GClass30 gclass30 = this.method_2(Conversions.ToUShort(listViewItem.Text));
        if (gclass30 != null)
        {
          if (gclass30.method_14())
          {
            listViewItem.ForeColor = Color.Green;
            listViewItem.Tag = (object) gclass30;
            listViewItem.SubItems[2].Text = "Listening!";
            Class97.list_1.Add(gclass30);
          }
          else
          {
            int num = (int) MessageBox.Show("Failed to Listen on Port: " + listViewItem.Text + " Please Check the Server Logs for Details", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
    this.vmethod_16().Enabled = false;
    this.vmethod_14().Enabled = true;
    this.vmethod_2().Enabled = false;
    this.vmethod_4().Enabled = false;
    Class97.bool_2 = true;
  }

  private GClass30 method_2(ushort ushort_0)
  {
    GClass30 gclass30_1;
    try
    {
      Class97.gclass2_0.method_0("[System] Attempting to Listen on Port: " + Conversions.ToString((uint) ushort_0), Class97.gclass2_0.textStyle_2);
      GClass30 gclass30_2 = new GClass30();
      gclass30_2.method_4(new GClass30.GDelegate15(Class97.gclass21_0.method_0));
      gclass30_2.method_6(new GClass30.GDelegate13(Class97.gclass21_0.method_2));
      gclass30_2.method_2(new GClass30.GDelegate14(Class97.gclass21_0.method_1));
      if (!gclass30_2.method_14())
      {
        gclass30_2.method_11((int) ushort.MaxValue);
        gclass30_2.method_17(ushort_0);
      }
      else
        gclass30_2.method_20();
      if (gclass30_2.method_14())
        Class97.gclass2_0.method_0("[System] Successfully Started Listener on Port: " + Conversions.ToString((uint) ushort_0), Class97.gclass2_0.textStyle_1);
      gclass30_1 = gclass30_2;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Class97.gclass2_0.method_0("[Error] Failed To Listen on Port: " + Conversions.ToString((uint) ushort_0) + " " + exception.StackTrace, Class97.gclass2_0.textStyle_3);
      gclass30_1 = (GClass30) null;
      ProjectData.ClearProjectError();
    }
    return gclass30_1;
  }

  public void method_3()
  {
    try
    {
      foreach (GClass30 gclass30 in Class97.list_1)
      {
        gclass30.method_20();
        lock (gclass30.method_16())
        {
          try
          {
            foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
              gclass18.method_32();
          }
          finally
          {
            List<GClass18>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
    }
    finally
    {
      List<GClass30>.Enumerator enumerator;
      enumerator.Dispose();
    }
    GC.Collect();
  }

  public void method_4()
  {
    try
    {
      foreach (GClass30 gclass30 in Class97.list_1)
      {
        gclass30.method_20();
        lock (gclass30.method_16())
        {
          try
          {
            foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
              gclass18.method_32();
          }
          finally
          {
            List<GClass18>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
    }
    finally
    {
      List<GClass30>.Enumerator enumerator;
      enumerator.Dispose();
    }
    GC.Collect();
    this.Invoke((Delegate) (() =>
    {
      try
      {
        foreach (ListViewItem listViewItem in this.vmethod_18().Items)
        {
          listViewItem.SubItems[2].Text = "Idle...";
          listViewItem.ForeColor = Color.Black;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.vmethod_16().Enabled = true;
      this.vmethod_14().Enabled = false;
      this.vmethod_2().Enabled = true;
      this.vmethod_4().Enabled = true;
      Class97.bool_2 = false;
    }));
  }

  private void method_5(object sender, EventArgs e) => this.method_8();

  private void method_6(object sender, EventArgs e) => this.method_9();

  private void method_7(object sender, EventArgs e)
  {
    if (this.vmethod_18().SelectedItems.Count <= 0)
      return;
    new Thread((ParameterizedThreadStart) (object_0 => this.method_10(Conversions.ToUShort(object_0)))).Start((object) this.vmethod_18().SelectedItems[0].SubItems[0].Text);
    this.vmethod_18().SelectedItems[0].SubItems[2].Text = "Checking Port...";
  }

  private void method_8()
  {
    ushort num1 = 0;
    FormDialog formDialog = new FormDialog(true, "Add Port", "Please enter a port number");
    if (formDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      num1 = Conversions.ToUShort(formDialog.vmethod_4().Text);
    if (num1 != (ushort) 0)
    {
      try
      {
        foreach (ListViewItem listViewItem in this.vmethod_18().Items)
        {
          if ((int) Conversions.ToUShort(listViewItem.SubItems[0].Text) == (int) num1)
          {
            int num2 = (int) MessageBox.Show("Error! This port is already in the list!", "Action Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
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
    if (num1 == (ushort) 0 || num1 <= (ushort) 81)
      return;
    this.vmethod_18().Items.Add(new ListViewItem()
    {
      Text = Conversions.ToString((uint) num1),
      SubItems = {
        "0",
        "Idle..."
      },
      ImageIndex = 0
    });
    List<ushort> list = ((IEnumerable<ushort>) Class97.generalSettings_0.get_Ports()).ToList<ushort>();
    list.Add(num1);
    Class97.generalSettings_0.set_Ports(list.ToArray());
    Class148.smethod_6();
  }

  private void method_9()
  {
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_18().SelectedItems)
      {
        this.vmethod_18().Items.Remove(selectedItem);
        List<ushort> list = ((IEnumerable<ushort>) Class97.generalSettings_0.get_Ports()).ToList<ushort>();
        list.Remove(Conversions.ToUShort(selectedItem.Text));
        Class97.generalSettings_0.set_Ports(list.ToArray());
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

  private void method_10(ushort ushort_0)
  {
    UserControlPorts.Class92 class92 = new UserControlPorts.Class92();
    class92.userControlPorts_0 = this;
    class92.ushort_0 = ushort_0;
    if (this.method_12("http://ovh.imminentmethods.net/portcheck.php?port=" + Conversions.ToString((uint) class92.ushort_0)).Contains("Open"))
    {
      int num1 = (int) MessageBox.Show(string.Format("Your port {0} is open!", (object) class92.ushort_0), "Open!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (Class97.bool_2)
    {
      int num2 = (int) MessageBox.Show(string.Format("Your port {0} is closed!", (object) class92.ushort_0), "Closed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int num3 = (int) MessageBox.Show(string.Format("Your port {0} is closed! Try clicking the \"Start Listening\" button and check again", (object) class92.ushort_0), "Closed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    this.Invoke((Delegate) new Delegate0(class92._Lambda\u0024__72));
  }

  public MatchCollection method_11(string string_0, string string_1) => new Regex(string_1).Matches(string_0.Trim());

  public string method_12(string string_0)
  {
    HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(string_0);
    httpWebRequest.CookieContainer = UserControlPorts.cookieContainer_0;
    httpWebRequest.KeepAlive = true;
    httpWebRequest.Method = "GET";
    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.79 Safari/537.36";
    httpWebRequest.Proxy = (IWebProxy) null;
    StreamReader streamReader = new StreamReader(((HttpWebResponse) httpWebRequest.GetResponse()).GetResponseStream());
    string end = streamReader.ReadToEnd();
    streamReader.Close();
    return end;
  }

  private void method_13(object sender, EventArgs e) => this.method_1();

  private void method_14(object sender, EventArgs e)
  {
    new Thread(new ThreadStart(this.method_4)).Start();
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_2();
  }

  private void method_15(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = (int) Class132.smethod_3().method_0().ShowDialog();
  }

  private void method_16(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.youtube.com/watch?v=3k8T24AZsPM");

  private void method_17(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = (int) Class132.smethod_3().method_1().ShowDialog();
  }

  internal sealed class Class92
  {
    public ushort ushort_0;
    public UserControlPorts userControlPorts_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__72()
    {
      try
      {
        foreach (ListViewItem listViewItem in this.userControlPorts_0.vmethod_18().Items)
        {
          if ((int) Conversions.ToUShort(listViewItem.SubItems[0].Text) == (int) this.ushort_0)
            listViewItem.SubItems[2].Text = !Class97.bool_2 ? "Idle..." : "Listening!";
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
}
