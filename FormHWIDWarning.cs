// Decompiled with JetBrains decompiler
// Type: FormHWIDWarning
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
public sealed class FormHWIDWarning : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private CheckBox checkBox_0;
  private Button button_0;

  public FormHWIDWarning()
  {
    this.Load += new EventHandler(this.FormHWIDWarning_Load);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormHWIDWarning));
    this.vmethod_1(new TextBox());
    this.vmethod_3(new CheckBox());
    this.vmethod_5(new Button());
    this.SuspendLayout();
    this.vmethod_0().Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.vmethod_0();
    Point point1 = new Point(12, 12);
    Point point2 = point1;
    textBox1.Location = point2;
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "TextBoxHWIDWarning";
    TextBox textBox2 = this.vmethod_0();
    Size size1 = new Size(306, 230);
    Size size2 = size1;
    textBox2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Text = componentResourceManager.GetString("TextBoxHWIDWarning.Text");
    this.vmethod_2().AutoSize = true;
    CheckBox checkBox1 = this.vmethod_2();
    point1 = new Point(12, 250);
    Point point3 = point1;
    checkBox1.Location = point3;
    this.vmethod_2().Name = "CheckBoxDontShow";
    CheckBox checkBox2 = this.vmethod_2();
    size1 = new Size(191, 17);
    Size size3 = size1;
    checkBox2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "Don't Show This Message Again";
    this.vmethod_2().UseVisualStyleBackColor = true;
    Button button1 = this.vmethod_4();
    point1 = new Point(243, 248);
    Point point4 = point1;
    button1.Location = point4;
    this.vmethod_4().Name = "ButtonClose";
    Button button2 = this.vmethod_4();
    size1 = new Size(75, 23);
    Size size4 = size1;
    button2.Size = size4;
    this.vmethod_4().TabIndex = 2;
    this.vmethod_4().Text = "Close";
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(330, 277);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (FormHWIDWarning);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Hardware ID Warning";
    this.TopMost = true;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual CheckBox vmethod_2() => this.checkBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(CheckBox checkBox_1) => this.checkBox_0 = checkBox_1;

  internal virtual Button vmethod_4() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  private void FormHWIDWarning_Load(object sender, EventArgs e)
  {
    this.vmethod_4().Focus();
    this.vmethod_4().Select();
    Class97.smethod_11((Form) this);
  }

  private void method_0(object sender, EventArgs e) => this.method_1();

  private void method_1()
  {
    // ISSUE: reference to a compiler-generated method
    Class137.smethod_0().set_DontShow(this.vmethod_2().Checked);
    Class137.smethod_0().Save();
    this.Close();
  }
}
