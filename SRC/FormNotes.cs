// Decompiled with JetBrains decompiler
// Type: FormNotes
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
public sealed class FormNotes : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private Button button_0;
  private readonly GClass18 gclass18_0;

  public FormNotes(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.FormNotes_Load);
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.Text = string.Format("{0}/{1} - Notes", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormNotes));
    this.vmethod_1(new TextBox());
    this.vmethod_3(new Button());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_0();
    Point point1 = new Point(12, 12);
    Point point2 = point1;
    textBox1.Location = point2;
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "TextBoxNotes";
    TextBox textBox2 = this.vmethod_0();
    Size size1 = new Size(322, 233);
    Size size2 = size1;
    textBox2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    Button button1 = this.vmethod_2();
    point1 = new Point(243, 251);
    Point point3 = point1;
    button1.Location = point3;
    this.vmethod_2().Name = "ButtonSave";
    Button button2 = this.vmethod_2();
    size1 = new Size(92, 25);
    Size size3 = size1;
    button2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "Save && Exit";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(346, 283);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormNotes);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (FormNotes);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual Button vmethod_2() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  private void FormNotes_Load(object sender, EventArgs e)
  {
    this.vmethod_0().Text = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_13(this.gclass18_0);
    this.vmethod_2().Select();
    Class97.smethod_11((Form) this);
  }

  private void method_0(object sender, EventArgs e) => this.method_1();

  private void method_1()
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_12(this.gclass18_0, this.vmethod_0().Text);
    this.gclass18_0.method_20().listViewItem_4.SubItems[14].Text = this.vmethod_0().Text;
    this.Close();
  }
}
