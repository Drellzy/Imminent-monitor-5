// Decompiled with JetBrains decompiler
// Type: UserControlSavedData
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlSavedData : UserControl
{
  private IContainer icontainer_0;
  private GClass34 gclass34_0;
  private GControl6 gcontrol6_0;
  private TabPage tabPage_0;
  private GClass29 gclass29_0;
  private TabPage tabPage_1;
  private WebBrowser webBrowser_0;
  private ImageList imageList_0;
  private Button button_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;

  public UserControlSavedData()
  {
    this.Load += new EventHandler(this.UserControlSavedData_Load);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlSavedData));
    TreeNode treeNode = new TreeNode("Saved Data");
    this.vmethod_13(new ImageList(this.icontainer_0));
    this.vmethod_15(new Button());
    this.vmethod_17(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_19(new ToolStripMenuItem());
    this.vmethod_21(new ToolStripMenuItem());
    this.vmethod_3(new GControl6());
    this.vmethod_5(new TabPage());
    this.vmethod_7(new GClass29());
    this.vmethod_9(new TabPage());
    this.vmethod_11(new WebBrowser());
    this.vmethod_1(new GClass34());
    this.vmethod_16().SuspendLayout();
    this.vmethod_2().SuspendLayout();
    this.vmethod_4().SuspendLayout();
    this.vmethod_8().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_12().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListSavedData.ImageStream");
    this.vmethod_12().TransparentColor = Color.Transparent;
    this.vmethod_12().Images.SetKeyName(0, "folder-open.png");
    this.vmethod_12().Images.SetKeyName(1, "blue-document--arrow.png");
    this.vmethod_14().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    Button button1 = this.vmethod_14();
    Point point1 = new Point(3, 435);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_14().Name = "ButtonRefresh";
    Button button2 = this.vmethod_14();
    Size size1 = new Size(277, 23);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_14().TabIndex = 2;
    this.vmethod_14().Text = "Refresh";
    this.vmethod_14().UseVisualStyleBackColor = true;
    this.vmethod_16().Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_18(),
      (ToolStripItem) this.vmethod_20()
    });
    this.vmethod_16().Name = "ContextMenuStripSavedData";
    ContextMenuStrip contextMenuStrip = this.vmethod_16();
    size1 = new Size(169, 48);
    Size size3 = size1;
    contextMenuStrip.Size = size3;
    this.vmethod_18().Image = (Image) Class145.smethod_22();
    this.vmethod_18().Name = "DeleteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_18();
    size1 = new Size(168, 22);
    Size size4 = size1;
    toolStripMenuItem1.Size = size4;
    this.vmethod_18().Text = "Delete";
    this.vmethod_20().Image = (Image) Class145.smethod_27();
    this.vmethod_20().Name = "OpenFileLocationToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_20();
    size1 = new Size(168, 22);
    Size size5 = size1;
    toolStripMenuItem2.Size = size5;
    this.vmethod_20().Text = "Open file location";
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_2().Controls.Add((Control) this.vmethod_4());
    this.vmethod_2().Controls.Add((Control) this.vmethod_8());
    GControl6 gcontrol6_1 = this.vmethod_2();
    point1 = new Point(286, 3);
    Point point3 = point1;
    gcontrol6_1.Location = point3;
    this.vmethod_2().Name = "HiddenTabControl1";
    this.vmethod_2().SelectedIndex = 0;
    GControl6 gcontrol6_2 = this.vmethod_2();
    size1 = new Size(443, 458);
    Size size6 = size1;
    gcontrol6_2.Size = size6;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_4().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_4().Controls.Add((Control) this.vmethod_6());
    TabPage tabPage1 = this.vmethod_4();
    point1 = new Point(0, 0);
    Point point4 = point1;
    tabPage1.Location = point4;
    this.vmethod_4().Name = "TabPage1";
    TabPage tabPage2 = this.vmethod_4();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage2.Padding = padding2;
    TabPage tabPage3 = this.vmethod_4();
    size1 = new Size(443, 458);
    Size size7 = size1;
    tabPage3.Size = size7;
    this.vmethod_4().TabIndex = 0;
    this.vmethod_4().Text = "TabPage1";
    this.vmethod_6().BackColor = Color.FromArgb(171, 173, 179);
    this.vmethod_6().Dock = DockStyle.Fill;
    GClass29 gclass29_1 = this.vmethod_6();
    point1 = new Point(3, 3);
    Point point5 = point1;
    gclass29_1.Location = point5;
    this.vmethod_6().Name = "RichTextboxEx1";
    this.vmethod_6().method_1((string) null);
    GClass29 gclass29_2 = this.vmethod_6();
    size1 = new Size(437, 452);
    Size size8 = size1;
    gclass29_2.Size = size8;
    this.vmethod_6().TabIndex = 0;
    this.vmethod_8().BackColor = Color.FromArgb(241, 244, 245);
    this.vmethod_8().Controls.Add((Control) this.vmethod_10());
    TabPage tabPage4 = this.vmethod_8();
    point1 = new Point(0, 0);
    Point point6 = point1;
    tabPage4.Location = point6;
    this.vmethod_8().Name = "TabPage2";
    TabPage tabPage5 = this.vmethod_8();
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage5.Padding = padding3;
    TabPage tabPage6 = this.vmethod_8();
    size1 = new Size(443, 458);
    Size size9 = size1;
    tabPage6.Size = size9;
    this.vmethod_8().TabIndex = 1;
    this.vmethod_8().Text = "TabPage2";
    this.vmethod_10().Dock = DockStyle.Fill;
    WebBrowser webBrowser1 = this.vmethod_10();
    point1 = new Point(3, 3);
    Point point7 = point1;
    webBrowser1.Location = point7;
    WebBrowser webBrowser2 = this.vmethod_10();
    size1 = new Size(20, 20);
    Size size10 = size1;
    webBrowser2.MinimumSize = size10;
    this.vmethod_10().Name = "WebBrowser1";
    this.vmethod_10().ScriptErrorsSuppressed = true;
    this.vmethod_10().ScrollBarsEnabled = false;
    WebBrowser webBrowser3 = this.vmethod_10();
    size1 = new Size(437, 452);
    Size size11 = size1;
    webBrowser3.Size = size11;
    this.vmethod_10().TabIndex = 0;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_0().ContextMenuStrip = this.vmethod_16();
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().ImageIndex = 0;
    this.vmethod_0().ImageList = this.vmethod_12();
    GClass34 gclass34_1 = this.vmethod_0();
    point1 = new Point(3, 6);
    Point point8 = point1;
    gclass34_1.Location = point8;
    this.vmethod_0().Name = "AeroTreeView1";
    treeNode.Name = "NodeSavedData";
    treeNode.Text = "Saved Data";
    this.vmethod_0().Nodes.AddRange(new TreeNode[1]
    {
      treeNode
    });
    this.vmethod_0().SelectedImageIndex = 0;
    GClass34 gclass34_2 = this.vmethod_0();
    size1 = new Size(277, 423);
    Size size12 = size1;
    gclass34_2.Size = size12;
    this.vmethod_0().TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlSavedData);
    size1 = new Size(732, 464);
    this.Size = size1;
    this.vmethod_16().ResumeLayout(false);
    this.vmethod_2().ResumeLayout(false);
    this.vmethod_4().ResumeLayout(false);
    this.vmethod_8().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GClass34 vmethod_0() => this.gclass34_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass34 gclass34_1)
  {
    TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.method_2);
    if (this.gclass34_0 != null)
      this.gclass34_0.AfterSelect -= viewEventHandler;
    this.gclass34_0 = gclass34_1;
    if (this.gclass34_0 == null)
      return;
    this.gclass34_0.AfterSelect += viewEventHandler;
  }

  internal virtual GControl6 vmethod_2() => this.gcontrol6_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(GControl6 gcontrol6_1) => this.gcontrol6_0 = gcontrol6_1;

  internal virtual TabPage vmethod_4() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TabPage tabPage_2) => this.tabPage_0 = tabPage_2;

  internal virtual GClass29 vmethod_6() => this.gclass29_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(GClass29 gclass29_1) => this.gclass29_0 = gclass29_1;

  internal virtual TabPage vmethod_8() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(TabPage tabPage_2) => this.tabPage_1 = tabPage_2;

  internal virtual WebBrowser vmethod_10() => this.webBrowser_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(WebBrowser webBrowser_1) => this.webBrowser_0 = webBrowser_1;

  internal virtual ImageList vmethod_12() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ImageList imageList_1) => this.imageList_0 = imageList_1;

  internal virtual Button vmethod_14() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual ContextMenuStrip vmethod_16() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_18() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_20() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_6);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  private void UserControlSavedData_Load(object sender, EventArgs e)
  {
    if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
      return;
    this.method_0();
  }

  private void method_0()
  {
    this.vmethod_0().Nodes.Clear();
    this.vmethod_0().Nodes.Add(new TreeNode()
    {
      Text = "Saved Data",
      Tag = (object) (Application.StartupPath + "\\Saved Data\\")
    });
    this.vmethod_0().Nodes[0].Expand();
    if (!Directory.Exists(Application.StartupPath + "\\Saved Data\\"))
      return;
    foreach (DirectoryInfo directory1 in new DirectoryInfo(Application.StartupPath + "\\Saved Data\\").GetDirectories())
    {
      TreeNode node1 = new TreeNode();
      node1.Text = directory1.Name;
      if (Directory.Exists(Application.StartupPath + "\\Saved Data\\" + directory1.Name))
      {
        node1.Tag = (object) (Application.StartupPath + "\\Saved Data\\" + directory1.Name);
        foreach (DirectoryInfo directory2 in new DirectoryInfo(Application.StartupPath + "\\Saved Data\\" + directory1.Name).GetDirectories())
        {
          TreeNode node2 = new TreeNode();
          node2.Text = directory2.Name;
          node2.Tag = (object) (Application.StartupPath + "\\Saved Data\\" + directory1.Name + "\\" + directory2.Name + "\\");
          node1.Nodes.Add(node2);
          if (Directory.Exists(Application.StartupPath + "\\Saved Data\\" + directory1.Name + "\\" + directory2.Name + "\\"))
          {
            string[] strArray = new string[6]
            {
              Application.StartupPath,
              "\\Saved Data\\",
              directory1.Name,
              "\\",
              directory2.Name,
              "\\"
            };
            foreach (FileInfo file in new DirectoryInfo(string.Concat(strArray)).GetFiles())
              node2.Nodes.Add(new TreeNode()
              {
                Text = file.Name,
                Tag = (object) (Application.StartupPath + "\\Saved Data\\" + directory1.Name + "\\" + directory2.Name + "\\" + file.Name),
                SelectedImageIndex = 1,
                ImageIndex = 1
              });
          }
        }
      }
      this.vmethod_0().Nodes[0].Nodes.Add(node1);
    }
  }

  private void method_1(object sender, EventArgs e) => this.method_0();

  private void method_2(object sender, TreeViewEventArgs e)
  {
    string tag = (string) e.Node.Tag;
    if (!Path.HasExtension(tag))
      return;
    string lower = Path.GetExtension(tag).ToLower();
    if (Operators.CompareString(lower, ".log", false) == 0)
      this.method_3(tag);
    else if (Operators.CompareString(lower, ".txt", false) == 0)
      this.method_3(tag);
    else if (Operators.CompareString(lower, ".html", false) == 0)
      this.method_4(tag);
    else if (Operators.CompareString(lower, ".png", false) == 0)
      this.method_4(tag);
    else if (Operators.CompareString(lower, ".jpg", false) == 0)
      this.method_4(tag);
    else if (Operators.CompareString(lower, ".gif", false) == 0)
      this.method_4(tag);
    else if (Operators.CompareString(lower, ".png", false) == 0)
    {
      this.method_4(tag);
    }
    else
    {
      int num = (int) MessageBox.Show("Unsupported Extension", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void method_3(string string_0)
  {
    this.vmethod_6().richTextBox_0.Clear();
    this.vmethod_2().SelectedIndex = 0;
    this.vmethod_6().richTextBox_0.Text = File.ReadAllText(string_0);
  }

  private void method_4(string string_0)
  {
    this.vmethod_10().Navigate(string.Empty);
    this.vmethod_2().SelectedIndex = 1;
    this.vmethod_10().Navigate(string_0);
  }

  private void method_5(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedNode == null)
      return;
    string tag = (string) this.vmethod_0().SelectedNode.Tag;
    if (Path.HasExtension(tag))
    {
      try
      {
        File.Delete(tag);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(string.Format("Failed to delete file, error: {0}", (object) ex.Message), "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      try
      {
        Directory.Delete(tag, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(string.Format("Failed to delete folder, error: {0}", (object) ex.Message), "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
    }
    this.method_0();
  }

  private void method_6(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedNode == null)
      return;
    Process.Start("explorer.exe", string.Format("/select, {0}", (object) (string) this.vmethod_0().SelectedNode.Tag));
  }
}
