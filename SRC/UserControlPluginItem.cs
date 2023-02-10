// Decompiled with JetBrains decompiler
// Type: UserControlPluginItem
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
public sealed class UserControlPluginItem : UserControl
{
  private IContainer icontainer_0;
  private Label label_0;
  private CheckBox checkBox_0;
  private Label label_1;
  private PictureBox pictureBox_0;
  private Label label_2;
  private GControl1 gcontrol1_0;
  private LinkLabel linkLabel_0;
  private Label label_3;
  private GClass43 gclass43_0;

  public UserControlPluginItem(GClass43 gclass43_1)
  {
    this.Load += new EventHandler(this.UserControlPluginItem_Load);
    this.InitializeComponent();
    this.gclass43_0 = gclass43_1;
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
    this.vmethod_1(new Label());
    this.vmethod_3(new CheckBox());
    this.vmethod_5(new Label());
    this.vmethod_7(new PictureBox());
    this.vmethod_9(new Label());
    this.vmethod_11(new GControl1());
    this.vmethod_13(new LinkLabel());
    this.vmethod_15(new Label());
    ((ISupportInitialize) this.vmethod_6()).BeginInit();
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_0().AutoSize = true;
    this.vmethod_0().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1 = this.vmethod_0();
    Point point1 = new Point(79, 75);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_0().Name = "LabelAuthor";
    Label label2 = this.vmethod_0();
    Size size1 = new Size(75, 13);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_0().TabIndex = 15;
    this.vmethod_0().Text = "Author: Null";
    this.vmethod_2().AutoSize = true;
    this.vmethod_2().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox checkBox1 = this.vmethod_2();
    point1 = new Point(11, 74);
    Point point3 = point1;
    checkBox1.Location = point3;
    this.vmethod_2().Name = "CheckBoxEnabled";
    CheckBox checkBox2 = this.vmethod_2();
    size1 = new Size(71, 17);
    Size size3 = size1;
    checkBox2.Size = size3;
    this.vmethod_2().TabIndex = 13;
    this.vmethod_2().Text = "Enabled";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_4().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_4().AutoSize = true;
    this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_4().ForeColor = SystemColors.ControlDark;
    Label label3 = this.vmethod_4();
    point1 = new Point(60, 41);
    Point point4 = point1;
    label3.Location = point4;
    this.vmethod_4().Name = "LabelPluginDescription";
    Label label4 = this.vmethod_4();
    size1 = new Size(28, 13);
    Size size4 = size1;
    label4.Size = size4;
    this.vmethod_4().TabIndex = 12;
    this.vmethod_4().Text = "Null";
    PictureBox pictureBox1 = this.vmethod_6();
    point1 = new Point(9, 12);
    Point point5 = point1;
    pictureBox1.Location = point5;
    this.vmethod_6().Name = "PictureBoxPluginImage";
    PictureBox pictureBox2 = this.vmethod_6();
    size1 = new Size(48, 48);
    Size size5 = size1;
    pictureBox2.Size = size5;
    this.vmethod_6().SizeMode = PictureBoxSizeMode.StretchImage;
    this.vmethod_6().TabIndex = 11;
    this.vmethod_6().TabStop = false;
    this.vmethod_8().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_8().AutoSize = true;
    this.vmethod_8().Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5 = this.vmethod_8();
    point1 = new Point(59, 12);
    Point point6 = point1;
    label5.Location = point6;
    this.vmethod_8().Name = "LabelPluginTitle";
    Label label6 = this.vmethod_8();
    size1 = new Size(87, 21);
    Size size6 = size1;
    label6.Size = size6;
    this.vmethod_8().TabIndex = 10;
    this.vmethod_8().Text = "Plugin Title";
    this.vmethod_10().method_1((GControl1.GEnum0) 1);
    this.vmethod_10().Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_10().BackColor = Color.FromArgb(241, 244, 245);
    GControl1 gcontrol1_1 = this.vmethod_10();
    point1 = new Point(9, 93);
    Point point7 = point1;
    gcontrol1_1.Location = point7;
    this.vmethod_10().Name = "Seperator2";
    GControl1 gcontrol1_2 = this.vmethod_10();
    size1 = new Size(479, 4);
    Size size7 = size1;
    gcontrol1_2.Size = size7;
    this.vmethod_10().TabIndex = 17;
    this.vmethod_10().Text = "Seperator2";
    this.vmethod_12().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_12().AutoSize = true;
    LinkLabel linkLabel1 = this.vmethod_12();
    point1 = new Point(308, 75);
    Point point8 = point1;
    linkLabel1.Location = point8;
    this.vmethod_12().Name = "LinkLabelWebsite";
    LinkLabel linkLabel2 = this.vmethod_12();
    size1 = new Size(184, 13);
    Size size8 = size1;
    linkLabel2.Size = size8;
    this.vmethod_12().TabIndex = 19;
    this.vmethod_12().TabStop = true;
    this.vmethod_12().Text = "Website: http://www.example.com";
    this.vmethod_14().Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.vmethod_14().AutoSize = true;
    this.vmethod_14().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_14().ForeColor = Color.FromArgb(0, 192, 0);
    Label label7 = this.vmethod_14();
    point1 = new Point(316, 12);
    Point point9 = point1;
    label7.Location = point9;
    this.vmethod_14().Name = "LabelOfficial";
    Label label8 = this.vmethod_14();
    size1 = new Size(176, 13);
    Size size9 = size1;
    label8.Size = size9;
    this.vmethod_14().TabIndex = 20;
    this.vmethod_14().Text = "Official Imminent Monitor Plugin";
    this.vmethod_14().Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_8());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlPluginItem);
    size1 = new Size(495, 106);
    this.Size = size1;
    ((ISupportInitialize) this.vmethod_6()).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label vmethod_0() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Label label_4) => this.label_0 = label_4;

  internal virtual CheckBox vmethod_2() => this.checkBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(CheckBox checkBox_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.checkBox_0 != null)
      this.checkBox_0.CheckedChanged -= eventHandler;
    this.checkBox_0 = checkBox_1;
    if (this.checkBox_0 == null)
      return;
    this.checkBox_0.CheckedChanged += eventHandler;
  }

  internal virtual Label vmethod_4() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Label label_4) => this.label_1 = label_4;

  internal virtual PictureBox vmethod_6() => this.pictureBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(PictureBox pictureBox_1) => this.pictureBox_0 = pictureBox_1;

  internal virtual Label vmethod_8() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(Label label_4) => this.label_2 = label_4;

  internal virtual GControl1 vmethod_10() => this.gcontrol1_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(GControl1 gcontrol1_1) => this.gcontrol1_0 = gcontrol1_1;

  internal virtual LinkLabel vmethod_12() => this.linkLabel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(LinkLabel linkLabel_1)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_1);
    if (this.linkLabel_0 != null)
      this.linkLabel_0.LinkClicked -= clickedEventHandler;
    this.linkLabel_0 = linkLabel_1;
    if (this.linkLabel_0 == null)
      return;
    this.linkLabel_0.LinkClicked += clickedEventHandler;
  }

  internal virtual Label vmethod_14() => this.label_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Label label_4) => this.label_3 = label_4;

  private void UserControlPluginItem_Load(object sender, EventArgs e)
  {
    this.vmethod_6().Image = this.gclass43_0.method_10();
    this.vmethod_8().Text = this.gclass43_0.method_0();
    this.vmethod_4().Text = this.gclass43_0.method_6();
    int num = this.vmethod_12().Left + this.vmethod_12().Width;
    this.vmethod_12().Text = string.Format("Website: {0}", (object) this.gclass43_0.method_8());
    this.vmethod_0().Text = string.Format("Author: {0}", (object) this.gclass43_0.method_4());
    this.vmethod_12().Left = num - this.vmethod_12().Width;
    this.vmethod_12().Tag = (object) this.gclass43_0.method_8();
    if (!this.gclass43_0.method_28())
      return;
    this.vmethod_14().Visible = true;
  }

  private void method_0(object sender, EventArgs e)
  {
    if (this.vmethod_2().Checked)
      Class108.smethod_11(this.gclass43_0);
    else
      Class108.smethod_12(this.gclass43_0);
    Class148.smethod_10();
  }

  private void method_1(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start((string) this.vmethod_12().Tag);
}
