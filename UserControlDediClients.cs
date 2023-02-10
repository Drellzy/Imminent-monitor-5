// Decompiled with JetBrains decompiler
// Type: UserControlDediClients
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
public sealed class UserControlDediClients : UserControl
{
  private IContainer icontainer_0;
  private Label label_0;
  private TextBox textBox_0;
  private TextBox textBox_1;
  private Label label_1;
  private Button button_0;
  private TextBox textBox_2;
  private Label label_2;

  public UserControlDediClients() => this.InitializeComponent();

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
    this.vmethod_9(new Button());
    this.vmethod_11(new TextBox());
    this.vmethod_13(new Label());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.None;
    this.vmethod_0().AutoSize = true;
    Label label1 = this.vmethod_0();
    Point point1 = new Point(299, 146);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_0().Name = "LabelIP";
    Label label2 = this.vmethod_0();
    Size size1 = new Size(19, 13);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Text = "IP:";
    this.vmethod_2().Anchor = AnchorStyles.None;
    TextBox textBox1 = this.vmethod_2();
    point1 = new Point(302, 162);
    Point point3 = point1;
    textBox1.Location = point3;
    this.vmethod_2().Name = "TextBoxIP";
    TextBox textBox2 = this.vmethod_2();
    size1 = new Size(131, 22);
    Size size3 = size1;
    textBox2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "127.0.0.1";
    this.vmethod_4().Anchor = AnchorStyles.None;
    TextBox textBox3 = this.vmethod_4();
    point1 = new Point(302, 203);
    Point point4 = point1;
    textBox3.Location = point4;
    this.vmethod_4().Name = "TextBoxPort";
    TextBox textBox4 = this.vmethod_4();
    size1 = new Size(131, 22);
    Size size4 = size1;
    textBox4.Size = size4;
    this.vmethod_4().TabIndex = 3;
    this.vmethod_4().Text = "3009";
    this.vmethod_6().Anchor = AnchorStyles.None;
    this.vmethod_6().AutoSize = true;
    Label label3 = this.vmethod_6();
    point1 = new Point(299, 187);
    Point point5 = point1;
    label3.Location = point5;
    this.vmethod_6().Name = "LabelPort";
    Label label4 = this.vmethod_6();
    size1 = new Size(31, 13);
    Size size5 = size1;
    label4.Size = size5;
    this.vmethod_6().TabIndex = 2;
    this.vmethod_6().Text = "Port:";
    this.vmethod_8().Anchor = AnchorStyles.None;
    Button button1 = this.vmethod_8();
    point1 = new Point(302, 272);
    Point point6 = point1;
    button1.Location = point6;
    this.vmethod_8().Name = "ButtonConnect";
    Button button2 = this.vmethod_8();
    size1 = new Size(131, 23);
    Size size6 = size1;
    button2.Size = size6;
    this.vmethod_8().TabIndex = 4;
    this.vmethod_8().Text = "Connect";
    this.vmethod_8().UseVisualStyleBackColor = true;
    this.vmethod_10().Anchor = AnchorStyles.None;
    TextBox textBox5 = this.vmethod_10();
    point1 = new Point(302, 244);
    Point point7 = point1;
    textBox5.Location = point7;
    this.vmethod_10().Name = "TextBoxPassword";
    TextBox textBox6 = this.vmethod_10();
    size1 = new Size(131, 22);
    Size size7 = size1;
    textBox6.Size = size7;
    this.vmethod_10().TabIndex = 6;
    this.vmethod_10().Text = "test";
    this.vmethod_10().UseSystemPasswordChar = true;
    this.vmethod_12().Anchor = AnchorStyles.None;
    this.vmethod_12().AutoSize = true;
    Label label5 = this.vmethod_12();
    point1 = new Point(299, 228);
    Point point8 = point1;
    label5.Location = point8;
    this.vmethod_12().Name = "LabelPassword";
    Label label6 = this.vmethod_12();
    size1 = new Size(59, 13);
    Size size8 = size1;
    label6.Size = size8;
    this.vmethod_12().TabIndex = 5;
    this.vmethod_12().Text = "Password:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlDediClients);
    size1 = new Size(732, 464);
    this.Size = size1;
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

  internal virtual Button vmethod_8() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual TextBox vmethod_10() => this.textBox_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(TextBox textBox_3) => this.textBox_2 = textBox_3;

  internal virtual Label vmethod_12() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(Label label_3) => this.label_2 = label_3;

  private void method_0(object sender, EventArgs e)
  {
  }
}
