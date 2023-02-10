// Decompiled with JetBrains decompiler
// Type: FormDialog
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
public sealed class FormDialog : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private Button button_1;
  private TextBox textBox_0;
  private Label label_0;
  private readonly bool bool_0;

  public FormDialog(bool bool_1, string string_0, string string_1)
  {
    this.Load += new EventHandler(this.FormDialog_Load);
    this.InitializeComponent();
    this.Text = string_0;
    this.vmethod_6().Text = string_1;
    this.bool_0 = bool_1;
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
    this.vmethod_5(new TextBox());
    this.vmethod_7(new Label());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().DialogResult = DialogResult.OK;
    Button button1 = this.vmethod_0();
    Point point1 = new Point(110, 54);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_0().Name = "ButtonContinue";
    Button button2 = this.vmethod_0();
    Size size1 = new Size(95, 26);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_0().TabIndex = 7;
    this.vmethod_0().Text = "Continue";
    this.vmethod_0().TextAlign = ContentAlignment.MiddleLeft;
    this.vmethod_0().UseVisualStyleBackColor = true;
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_2().DialogResult = DialogResult.Cancel;
    Button button3 = this.vmethod_2();
    point1 = new Point(14, 54);
    Point point3 = point1;
    button3.Location = point3;
    this.vmethod_2().Name = "ButtonCancel";
    Button button4 = this.vmethod_2();
    size1 = new Size(89, 26);
    Size size3 = size1;
    button4.Size = size3;
    this.vmethod_2().TabIndex = 6;
    this.vmethod_2().Text = "Cancel";
    this.vmethod_2().TextAlign = ContentAlignment.MiddleLeft;
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_4().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_4();
    point1 = new Point(14, 26);
    Point point4 = point1;
    textBox1.Location = point4;
    this.vmethod_4().Multiline = true;
    this.vmethod_4().Name = "TextBox1";
    TextBox textBox2 = this.vmethod_4();
    size1 = new Size(190, 21);
    Size size4 = size1;
    textBox2.Size = size4;
    this.vmethod_4().TabIndex = 5;
    this.vmethod_6().AutoSize = true;
    this.vmethod_6().ForeColor = SystemColors.ControlDarkDark;
    Label label1 = this.vmethod_6();
    point1 = new Point(11, 10);
    Point point5 = point1;
    label1.Location = point5;
    this.vmethod_6().Name = "Label1";
    Label label2 = this.vmethod_6();
    size1 = new Size(0, 13);
    Size size5 = size1;
    label2.Size = size5;
    this.vmethod_6().TabIndex = 4;
    this.AutoScaleDimensions = new SizeF(7f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(214, 91);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (FormDialog);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button vmethod_0() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
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
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual TextBox vmethod_4() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TextBox textBox_1)
  {
    KeyEventHandler keyEventHandler = new KeyEventHandler(this.method_2);
    if (this.textBox_0 != null)
      this.textBox_0.KeyDown -= keyEventHandler;
    this.textBox_0 = textBox_1;
    if (this.textBox_0 == null)
      return;
    this.textBox_0.KeyDown += keyEventHandler;
  }

  internal virtual Label vmethod_6() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Label label_1) => this.label_0 = label_1;

  private void FormDialog_Load(object sender, EventArgs e) => Class97.smethod_11((Form) this);

  private void method_0(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.vmethod_4().Text, (string) null, false) == 0)
      return;
    this.method_3();
  }

  private void method_1(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void method_2(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.method_3();
  }

  private void method_3()
  {
    if (Operators.CompareString(this.vmethod_4().Text, (string) null, false) == 0)
      return;
    if (this.bool_0)
    {
      if (Versioned.IsNumeric((object) this.vmethod_4().Text))
      {
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
      }
    }
    else
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
