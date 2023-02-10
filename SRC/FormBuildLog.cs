// Decompiled with JetBrains decompiler
// Type: FormBuildLog
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormBuildLog : Form
{
  private IContainer icontainer_0;
  private GClass29 gclass29_0;
  private Button button_0;
  private string string_0;

  public FormBuildLog(string string_1)
  {
    this.InitializeComponent();
    this.string_0 = string_1;
    Class97.formBuildLog_0 = this;
    this.ControlBox = false;
    Class97.formBuildLog_0.method_0("Creating Unique Private Key...");
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
    this.vmethod_1(new GClass29());
    this.vmethod_3(new Button());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_1 = this.vmethod_0();
    Point point1 = new Point(12, 12);
    Point point2 = point1;
    gclass29_1.Location = point2;
    this.vmethod_0().Name = "RichTextboxExBuildLog";
    this.vmethod_0().method_1((string) null);
    GClass29 gclass29_2 = this.vmethod_0();
    Size size1 = new Size(403, 291);
    Size size2 = size1;
    gclass29_2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_2().Enabled = false;
    Button button1 = this.vmethod_2();
    point1 = new Point(276, 309);
    Point point3 = point1;
    button1.Location = point3;
    this.vmethod_2().Name = "ButtonOpen";
    Button button2 = this.vmethod_2();
    size1 = new Size(140, 25);
    Size size3 = size1;
    button2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "Open File Location..";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(7f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(427, 343);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormBuildLog);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Processing Build";
    this.ResumeLayout(false);
  }

  internal virtual GClass29 vmethod_0() => this.gclass29_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass29 gclass29_1) => this.gclass29_0 = gclass29_1;

  internal virtual Button vmethod_2() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  public void method_0(string string_1)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Class97.Delegate4(this.method_0), (object) string_1);
    }
    else
    {
      this.vmethod_0().richTextBox_0.Text = this.vmethod_0().richTextBox_0.Text + "[" + Conversions.ToString(DateAndTime.TimeOfDay) + "] " + string_1 + "\r\n";
      this.vmethod_0().richTextBox_0.SelectionStart = this.vmethod_0().richTextBox_0.Text.Length;
      this.vmethod_0().richTextBox_0.ScrollToCaret();
    }
  }

  private void method_1(object sender, EventArgs e) => Process.Start("explorer.exe", string.Format("/select, {0}", (object) this.string_0));

  public void method_2()
  {
    Class97.formBuildLog_0.ControlBox = true;
    Class97.formBuildLog_0.vmethod_2().Enabled = true;
  }
}
