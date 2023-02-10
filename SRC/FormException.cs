// Decompiled with JetBrains decompiler
// Type: FormException
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
public sealed class FormException : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private TextBox textBox_0;
  private GControl4 gcontrol4_0;
  private Label label_1;

  public FormException(string string_0)
  {
    this.Load += new EventHandler(this.FormException_Load);
    this.InitializeComponent();
    this.vmethod_2().Text = string_0;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormException));
    this.vmethod_1(new Label());
    this.vmethod_3(new TextBox());
    this.vmethod_5(new GControl4());
    this.vmethod_7(new Label());
    this.SuspendLayout();
    this.vmethod_0().AutoSize = true;
    this.vmethod_0().BackColor = Color.White;
    this.vmethod_0().Font = new Font("Segoe UI", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_0().ForeColor = SystemColors.AppWorkspace;
    Label label1 = this.vmethod_0();
    Point point1 = new Point(12, 5);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_0().Name = "Label1";
    Label label2 = this.vmethod_0();
    Size size1 = new Size(286, 30);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().Text = "Oops, something went wrong";
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_2();
    point1 = new Point(17, 42);
    Point point3 = point1;
    textBox1.Location = point3;
    this.vmethod_2().Multiline = true;
    this.vmethod_2().Name = "TextBoxException";
    this.vmethod_2().ScrollBars = ScrollBars.Vertical;
    TextBox textBox2 = this.vmethod_2();
    size1 = new Size(385, 295);
    Size size3 = size1;
    textBox2.Size = size3;
    this.vmethod_2().TabIndex = 2;
    this.vmethod_4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_4().method_2((string) null);
    GControl4 gcontrol4_1 = this.vmethod_4();
    point1 = new Point(308, 343);
    Point point4 = point1;
    gcontrol4_1.Location = point4;
    this.vmethod_4().Name = "MetroButtonContinue";
    GControl4 gcontrol4_2 = this.vmethod_4();
    size1 = new Size(94, 23);
    Size size4 = size1;
    gcontrol4_2.Size = size4;
    this.vmethod_4().TabIndex = 4;
    this.vmethod_4().Text = "Continue";
    this.vmethod_6().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_6().AutoSize = true;
    this.vmethod_6().BackColor = Color.White;
    this.vmethod_6().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_6().ForeColor = SystemColors.AppWorkspace;
    Label label3 = this.vmethod_6();
    point1 = new Point(14, 341);
    Point point5 = point1;
    label3.Location = point5;
    this.vmethod_6().Name = "Label2";
    Label label4 = this.vmethod_6();
    size1 = new Size(229, 26);
    Size size5 = size1;
    label4.Size = size5;
    this.vmethod_6().TabIndex = 5;
    this.vmethod_6().Text = "If you want this to be fixed please send the\r\ncontents of this error to an Administrator";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(414, 373);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormException);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label vmethod_0() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Label label_2) => this.label_0 = label_2;

  internal virtual TextBox vmethod_2() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual GControl4 vmethod_4() => this.gcontrol4_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(GControl4 gcontrol4_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.gcontrol4_0 != null)
      this.gcontrol4_0.Click -= eventHandler;
    this.gcontrol4_0 = gcontrol4_1;
    if (this.gcontrol4_0 == null)
      return;
    this.gcontrol4_0.Click += eventHandler;
  }

  internal virtual Label vmethod_6() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Label label_2) => this.label_1 = label_2;

  private void method_0(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

  private void FormException_Load(object sender, EventArgs e) => this.vmethod_0().Select();
}
