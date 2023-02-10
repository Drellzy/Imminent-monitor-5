// Decompiled with JetBrains decompiler
// Type: FormDediSettings
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormDediSettings : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private TextBox textBox_0;
  private TextBox textBox_1;
  private Label label_1;
  private TextBox textBox_2;
  private Label label_2;
  private CheckBox checkBox_0;
  private Button button_0;
  private Button button_1;

  public FormDediSettings()
  {
    this.Load += new EventHandler(this.FormDediSettings_Load);
    this.InitializeComponent();
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
    this.vmethod_1(new Label());
    this.vmethod_3(new TextBox());
    this.vmethod_5(new TextBox());
    this.vmethod_7(new Label());
    this.vmethod_9(new TextBox());
    this.vmethod_11(new Label());
    this.vmethod_13(new CheckBox());
    this.vmethod_15(new Button());
    this.vmethod_17(new Button());
    this.SuspendLayout();
    this.vmethod_0().AutoSize = true;
    Label label1 = this.vmethod_0();
    Point point1 = new Point(12, 9);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_0().Name = "LabelIP";
    Label label2 = this.vmethod_0();
    Size size1 = new Size(105, 13);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Text = "Dedicated Server IP";
    TextBox textBox1 = this.vmethod_2();
    point1 = new Point(15, 25);
    Point point3 = point1;
    textBox1.Location = point3;
    this.vmethod_2().Name = "TextBoxIP";
    TextBox textBox2 = this.vmethod_2();
    size1 = new Size(266, 22);
    Size size3 = size1;
    textBox2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    TextBox textBox3 = this.vmethod_4();
    point1 = new Point(15, 66);
    Point point4 = point1;
    textBox3.Location = point4;
    this.vmethod_4().Name = "TextBoxPort";
    TextBox textBox4 = this.vmethod_4();
    size1 = new Size(266, 22);
    Size size4 = size1;
    textBox4.Size = size4;
    this.vmethod_4().TabIndex = 3;
    this.vmethod_6().AutoSize = true;
    Label label3 = this.vmethod_6();
    point1 = new Point(12, 50);
    Point point5 = point1;
    label3.Location = point5;
    this.vmethod_6().Name = "LabelPort";
    Label label4 = this.vmethod_6();
    size1 = new Size(117, 13);
    Size size5 = size1;
    label4.Size = size5;
    this.vmethod_6().TabIndex = 2;
    this.vmethod_6().Text = "Dedicated Server Port";
    TextBox textBox5 = this.vmethod_8();
    point1 = new Point(15, 107);
    Point point6 = point1;
    textBox5.Location = point6;
    this.vmethod_8().Name = "TextBoxPassword";
    TextBox textBox6 = this.vmethod_8();
    size1 = new Size(266, 22);
    Size size6 = size1;
    textBox6.Size = size6;
    this.vmethod_8().TabIndex = 5;
    this.vmethod_10().AutoSize = true;
    Label label5 = this.vmethod_10();
    point1 = new Point(12, 91);
    Point point7 = point1;
    label5.Location = point7;
    this.vmethod_10().Name = "LabelPassword";
    Label label6 = this.vmethod_10();
    size1 = new Size(145, 13);
    Size size7 = size1;
    label6.Size = size7;
    this.vmethod_10().TabIndex = 4;
    this.vmethod_10().Text = "Dedicated Server Password";
    this.vmethod_12().AutoSize = true;
    CheckBox checkBox1 = this.vmethod_12();
    point1 = new Point(15, 135);
    Point point8 = point1;
    checkBox1.Location = point8;
    this.vmethod_12().Name = "CheckBoxConnectAutoMatically";
    CheckBox checkBox2 = this.vmethod_12();
    size1 = new Size(186, 17);
    Size size8 = size1;
    checkBox2.Size = size8;
    this.vmethod_12().TabIndex = 6;
    this.vmethod_12().Text = "Automatically connect to server";
    this.vmethod_12().UseVisualStyleBackColor = true;
    Button button1 = this.vmethod_14();
    point1 = new Point(15, 158);
    Point point9 = point1;
    button1.Location = point9;
    this.vmethod_14().Name = "ButtonSave";
    Button button2 = this.vmethod_14();
    size1 = new Size(102, 25);
    Size size9 = size1;
    button2.Size = size9;
    this.vmethod_14().TabIndex = 7;
    this.vmethod_14().Text = "Connect";
    this.vmethod_14().UseVisualStyleBackColor = true;
    Button button3 = this.vmethod_16();
    point1 = new Point(122, 158);
    Point point10 = point1;
    button3.Location = point10;
    this.vmethod_16().Name = "ButtonCancel";
    Button button4 = this.vmethod_16();
    size1 = new Size(75, 25);
    Size size10 = size1;
    button4.Size = size10;
    this.vmethod_16().TabIndex = 8;
    this.vmethod_16().Text = "Cancel";
    this.vmethod_16().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(293, 192);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_16());
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormDediSettings);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Dedicated Server Settings";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label vmethod_0() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Label label_3) => this.label_0 = label_3;

  internal virtual TextBox vmethod_2() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TextBox textBox_3) => this.textBox_0 = textBox_3;

  internal virtual TextBox vmethod_4() => this.textBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TextBox textBox_3) => this.textBox_1 = textBox_3;

  internal virtual Label vmethod_6() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Label label_3) => this.label_1 = label_3;

  internal virtual TextBox vmethod_8() => this.textBox_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(TextBox textBox_3) => this.textBox_2 = textBox_3;

  internal virtual Label vmethod_10() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Label label_3) => this.label_2 = label_3;

  internal virtual CheckBox vmethod_12() => this.checkBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(CheckBox checkBox_1) => this.checkBox_0 = checkBox_1;

  internal virtual Button vmethod_14() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
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
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  private void FormDediSettings_Load(object sender, EventArgs e) => this.method_3();

  private void method_0(object sender, EventArgs e)
  {
    GClass37.smethod_0(new DediSettings()
    {
      IP = this.vmethod_2().Text,
      Port = Conversions.ToUShort(this.vmethod_4().Text),
      Password = Class97.smethod_25(this.vmethod_8().Text),
      ConnectAutomatically = this.vmethod_12().Checked
    });
    if (Class97.gclass39_0 != null)
      Class97.gclass39_0.bool_0 = false;
    this.Close();
  }

  private void method_1(object sender, EventArgs e) => this.method_2();

  private void method_2()
  {
    DediSettings dediSettings_0 = new DediSettings();
    dediSettings_0.IP = this.vmethod_2().Text;
    dediSettings_0.Port = Conversions.ToUShort(this.vmethod_4().Text);
    dediSettings_0.Password = Class97.smethod_25(this.vmethod_8().Text);
    dediSettings_0.ConnectAutomatically = this.vmethod_12().Checked;
    GClass37.smethod_0(dediSettings_0);
    Class97.smethod_27(dediSettings_0.IP, dediSettings_0.Port, this.vmethod_8().Text);
    this.Close();
  }

  private void method_3()
  {
    DediSettings dediSettings = GClass37.smethod_1();
    if (dediSettings == null)
      return;
    this.vmethod_2().Text = dediSettings.IP;
    this.vmethod_4().Text = dediSettings.Port.ToString();
    if (Operators.CompareString(dediSettings.Password, string.Empty, false) != 0)
      this.vmethod_8().Text = Class97.smethod_26(dediSettings.Password);
    this.vmethod_12().Checked = dediSettings.ConnectAutomatically;
  }
}
