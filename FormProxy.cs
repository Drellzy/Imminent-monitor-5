// Decompiled with JetBrains decompiler
// Type: FormProxy
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
public sealed class FormProxy : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private Button button_1;
  private Label label_0;
  private NumericUpDown numericUpDown_0;
  private GControl1 gcontrol1_0;
  private Label label_1;
  private TextBox textBox_0;
  private Label label_2;
  private GClass18 gclass18_0;
  private Random random_0;

  public FormProxy(GClass18 gclass18_1)
  {
    this.random_0 = new Random();
    this.gclass18_0 = gclass18_1;
    this.gclass18_0.method_20().formProxy_0 = this;
    this.InitializeComponent();
    this.Text = string.Format("{0}", (object) this.gclass18_0.method_20().string_1);
    this.vmethod_6().Value = new Decimal((int) this.method_4());
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormProxy));
    this.vmethod_1(new Button());
    this.vmethod_3(new Button());
    this.vmethod_5(new Label());
    this.vmethod_7(new NumericUpDown());
    this.vmethod_11(new Label());
    this.vmethod_9(new GControl1());
    this.vmethod_13(new TextBox());
    this.vmethod_15(new Label());
    this.vmethod_6().BeginInit();
    this.SuspendLayout();
    this.vmethod_0().Image = (Image) Class145.smethod_21();
    Button button1 = this.vmethod_0();
    Point point1 = new Point(164, 91);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_0().Name = "ButtonCancel";
    Button button2 = this.vmethod_0();
    Size size1 = new Size(83, 25);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_0().TabIndex = 9;
    this.vmethod_0().Text = "Cancel";
    this.vmethod_0().TextAlign = ContentAlignment.MiddleRight;
    this.vmethod_0().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_0().UseVisualStyleBackColor = true;
    this.vmethod_2().Image = (Image) Class145.smethod_34();
    Button button3 = this.vmethod_2();
    point1 = new Point(12, 91);
    Point point3 = point1;
    button3.Location = point3;
    this.vmethod_2().Name = "ButtonStart";
    Button button4 = this.vmethod_2();
    size1 = new Size(146, 25);
    Size size3 = size1;
    button4.Size = size3;
    this.vmethod_2().TabIndex = 8;
    this.vmethod_2().Text = "Start Proxy";
    this.vmethod_2().TextAlign = ContentAlignment.MiddleRight;
    this.vmethod_2().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_4().AutoSize = true;
    Label label1 = this.vmethod_4();
    point1 = new Point(161, 47);
    Point point4 = point1;
    label1.Location = point4;
    this.vmethod_4().Name = "LabelPort";
    Label label2 = this.vmethod_4();
    size1 = new Size(31, 13);
    Size size4 = size1;
    label2.Size = size4;
    this.vmethod_4().TabIndex = 10;
    this.vmethod_4().Text = "Port:";
    NumericUpDown numericUpDown1 = this.vmethod_6();
    point1 = new Point(164, 63);
    Point point5 = point1;
    numericUpDown1.Location = point5;
    this.vmethod_6().Maximum = new Decimal(new int[4]
    {
      (int) ushort.MaxValue,
      0,
      0,
      0
    });
    this.vmethod_6().Name = "NumericUpDownPort";
    NumericUpDown numericUpDown2 = this.vmethod_6();
    size1 = new Size(83, 22);
    Size size5 = size1;
    numericUpDown2.Size = size5;
    this.vmethod_6().TabIndex = 11;
    this.vmethod_10().AutoSize = true;
    Label label3 = this.vmethod_10();
    point1 = new Point(10, 14);
    Point point6 = point1;
    label3.Location = point6;
    this.vmethod_10().Name = "LabelTitle";
    Label label4 = this.vmethod_10();
    size1 = new Size(140, 13);
    Size size6 = size1;
    label4.Size = size6;
    this.vmethod_10().TabIndex = 14;
    this.vmethod_10().Text = "Reverse SOCKS5/SSL Proxy";
    this.vmethod_8().method_1((GControl1.GEnum0) 1);
    GControl1 gcontrol1_1 = this.vmethod_8();
    point1 = new Point(13, 30);
    Point point7 = point1;
    gcontrol1_1.Location = point7;
    this.vmethod_8().Name = "Seperator1";
    GControl1 gcontrol1_2 = this.vmethod_8();
    size1 = new Size(246, 10);
    Size size7 = size1;
    gcontrol1_2.Size = size7;
    this.vmethod_8().TabIndex = 13;
    this.vmethod_8().Text = "Seperator1";
    this.vmethod_12().Enabled = false;
    TextBox textBox1 = this.vmethod_12();
    point1 = new Point(13, 62);
    Point point8 = point1;
    textBox1.Location = point8;
    this.vmethod_12().Name = "TextBox1";
    TextBox textBox2 = this.vmethod_12();
    size1 = new Size(145, 22);
    Size size8 = size1;
    textBox2.Size = size8;
    this.vmethod_12().TabIndex = 15;
    this.vmethod_12().Text = "127.0.0.1";
    this.vmethod_14().AutoSize = true;
    Label label5 = this.vmethod_14();
    point1 = new Point(12, 46);
    Point point9 = point1;
    label5.Location = point9;
    this.vmethod_14().Name = "LabelIP";
    Label label6 = this.vmethod_14();
    size1 = new Size(19, 13);
    Size size9 = size1;
    label6.Size = size9;
    this.vmethod_14().TabIndex = 16;
    this.vmethod_14().Text = "IP:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(271, 129);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = SystemColors.ControlText;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormProxy);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.vmethod_6().EndInit();
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
  internal virtual void vmethod_5(Label label_3) => this.label_0 = label_3;

  internal virtual NumericUpDown vmethod_6() => this.numericUpDown_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(NumericUpDown numericUpDown_1) => this.numericUpDown_0 = numericUpDown_1;

  internal virtual GControl1 vmethod_8() => this.gcontrol1_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(GControl1 gcontrol1_1) => this.gcontrol1_0 = gcontrol1_1;

  internal virtual Label vmethod_10() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Label label_3) => this.label_1 = label_3;

  internal virtual TextBox vmethod_12() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual Label vmethod_14() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Label label_3) => this.label_2 = label_3;

  private void method_0(object sender, EventArgs e)
  {
    this.method_2();
    this.Close();
  }

  private void method_1(object sender, EventArgs e) => this.Close();

  private void method_2()
  {
    new GClass27().method_6(this.gclass18_0, "127.0.0.1", Convert.ToInt32(this.vmethod_6().Value));
    this.method_3(Convert.ToUInt16(this.vmethod_6().Value));
  }

  private void method_3(ushort ushort_0)
  {
    FormProxy.Class106 class106 = new FormProxy.Class106()
    {
      listViewItem_0 = new ListViewItem()
    };
    class106.listViewItem_0.Text = this.gclass18_0.method_20().string_1;
    class106.listViewItem_0.SubItems.Add(string.Format("{0}:{1}", (object) "127.0.0.1", (object) ushort_0));
    class106.listViewItem_0.SubItems.Add("SOCKS 5/HTTPS");
    class106.listViewItem_0.Tag = (object) this.gclass18_0;
    class106.listViewItem_0.Name = this.gclass18_0.method_20().string_0;
    class106.listViewItem_0.ImageIndex = Class97.formMain_0.vmethod_0().method_49(this.gclass18_0.method_20().string_7);
    FormProxy.Class106.Class107 class107 = new FormProxy.Class106.Class107();
    class107.class106_0 = class106;
    class107.formMain_0 = Class97.formMain_0;
    class107.formMain_0.Invoke((Delegate) new Delegate0(class107._Lambda\u0024__52));
    class107.formMain_0 = (FormMain) null;
    this.gclass18_0.method_20().listViewItem_3 = class106.listViewItem_0;
  }

  private ushort method_4() => (ushort) this.random_0.Next(1, (int) ushort.MaxValue);

  internal sealed class Class106
  {
    public ListViewItem listViewItem_0;

    internal sealed class Class107
    {
      public FormMain formMain_0;
      public FormProxy.Class106 class106_0;

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__52()
      {
        this.formMain_0.vmethod_14().vmethod_0().Items.Add(this.class106_0.listViewItem_0);
        this.formMain_0.vmethod_14().vmethod_20().Start();
      }
    }
  }
}
