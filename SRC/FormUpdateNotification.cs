// Decompiled with JetBrains decompiler
// Type: FormUpdateNotification
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
public sealed class FormUpdateNotification : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;

  public FormUpdateNotification(string string_0, string string_1)
  {
    this.Load += new EventHandler(this.FormUpdateNotification_Load);
    this.InitializeComponent();
    this.Text = string_0;
    this.vmethod_0().Text = string_1;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormUpdateNotification));
    this.vmethod_1(new TextBox());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Location = new Point(12, 12);
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "TextBoxNotification";
    TextBox textBox = this.vmethod_0();
    Size size1 = new Size(345, 140);
    Size size2 = size1;
    textBox.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(369, 164);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormUpdateNotification);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_1) => this.textBox_0 = textBox_1;

  private void FormUpdateNotification_Load(object sender, EventArgs e) => Class97.smethod_11((Form) this);
}
