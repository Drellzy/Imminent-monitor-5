// Decompiled with JetBrains decompiler
// Type: FormUpdate
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormUpdate : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private Label label_0;
  private ProgressBar progressBar_0;
  private GClass35 gclass35_0;

  public FormUpdate(GClass35 gclass35_1)
  {
    this.Load += new EventHandler(this.FormUpdate_Load);
    this.InitializeComponent();
    this.vmethod_7(gclass35_1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormUpdate));
    this.vmethod_1(new TextBox());
    this.vmethod_3(new Label());
    this.vmethod_5(new ProgressBar());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_0();
    Point point1 = new Point(12, 54);
    Point point2 = point1;
    textBox1.Location = point2;
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "TextBoxLogs";
    this.vmethod_0().ScrollBars = ScrollBars.Vertical;
    TextBox textBox2 = this.vmethod_0();
    Size size1 = new Size(344, 109);
    Size size2 = size1;
    textBox2.Size = size2;
    this.vmethod_0().TabIndex = 5;
    this.vmethod_2().AutoSize = true;
    Label label1 = this.vmethod_2();
    point1 = new Point(9, 37);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_2().Name = "LabelStatus";
    Label label2 = this.vmethod_2();
    size1 = new Size(131, 13);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_2().TabIndex = 4;
    this.vmethod_2().Text = "Downloading Update... ";
    this.vmethod_4().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ProgressBar progressBar1 = this.vmethod_4();
    point1 = new Point(12, 12);
    Point point4 = point1;
    progressBar1.Location = point4;
    this.vmethod_4().Name = "ProgressBarUpdate";
    ProgressBar progressBar2 = this.vmethod_4();
    size1 = new Size(344, 23);
    Size size4 = size1;
    progressBar2.Size = size4;
    this.vmethod_4().TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(368, 175);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_4());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormUpdate);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Updater";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual Label vmethod_2() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Label label_1) => this.label_0 = label_1;

  internal virtual ProgressBar vmethod_4() => this.progressBar_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ProgressBar progressBar_1) => this.progressBar_0 = progressBar_1;

  public virtual GClass35 vmethod_6() => this.gclass35_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_7(GClass35 gclass35_1)
  {
    GClass35.GDelegate19 gdelegate19_1 = new GClass35.GDelegate19(this.method_1);
    GClass35.GDelegate22 gdelegate22_1 = new GClass35.GDelegate22(this.method_0);
    if (this.gclass35_0 != null)
    {
      this.gclass35_0.method_7(gdelegate19_1);
      this.gclass35_0.method_9(gdelegate22_1);
    }
    this.gclass35_0 = gclass35_1;
    if (this.gclass35_0 == null)
      return;
    this.gclass35_0.method_6(gdelegate19_1);
    this.gclass35_0.method_8(gdelegate22_1);
  }

  private void FormUpdate_Load(object sender, EventArgs e)
  {
    this.TopMost = true;
    this.ControlBox = false;
  }

  private void method_0(string string_0) => this.Invoke((Delegate) new Delegate0(new FormUpdate.Class102()
  {
    formUpdate_0 = this,
    string_0 = string_0
  }._Lambda\u0024__53));

  private void method_1(int int_0, double double_0, double double_1) => this.method_2(int_0, double_0, double_1);

  private void method_2(int int_0, double double_0, double double_1) => this.Invoke((Delegate) new Delegate0(new FormUpdate.Class103()
  {
    formUpdate_0 = this,
    int_0 = int_0,
    double_0 = double_0,
    double_1 = double_1
  }._Lambda\u0024__54));

  internal sealed class Class102
  {
    public string string_0;
    public FormUpdate formUpdate_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__53()
    {
      try
      {
        this.formUpdate_0.vmethod_0().AppendText(string.Format("[{0}] {1}", (object) DateTime.Now.ToLongTimeString(), (object) (this.string_0 + "\r\n")));
        File.WriteAllText("update.log", this.formUpdate_0.vmethod_0().Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
  }

  internal sealed class Class103
  {
    public double double_0;
    public int int_0;
    public double double_1;
    public FormUpdate formUpdate_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__54()
    {
      this.formUpdate_0.vmethod_4().Value = this.int_0;
      this.formUpdate_0.vmethod_2().Text = string.Format("Downloading Update... ({0}mb / {1}mb)", (object) this.double_0.ToString("0.00"), (object) this.double_1.ToString("0.00"));
    }
  }
}
