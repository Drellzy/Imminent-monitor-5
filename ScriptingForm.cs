// Decompiled with JetBrains decompiler
// Type: ScriptingForm
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
public sealed class ScriptingForm : Form
{
  private IContainer icontainer_0;
  private GControl9 gcontrol9_0;
  private TabPage tabPage_0;
  private TabPage tabPage_1;
  private GClass29 gclass29_0;
  private Button button_0;
  private GClass29 gclass29_1;
  private Button button_1;
  private TabPage tabPage_2;
  private GClass29 gclass29_2;
  private Button button_2;
  private GClass18 gclass18_0;

  public ScriptingForm(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.ScriptingForm_Load);
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.Text = string.Format("{0}/{1} - Remote Scripting", (object) gclass18_1.method_20().string_15, (object) gclass18_1.method_20().string_1);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ScriptingForm));
    this.vmethod_1(new GControl9());
    this.vmethod_3(new TabPage());
    this.vmethod_7(new GClass29());
    this.vmethod_9(new Button());
    this.vmethod_5(new TabPage());
    this.vmethod_11(new GClass29());
    this.vmethod_13(new Button());
    this.vmethod_15(new TabPage());
    this.vmethod_17(new GClass29());
    this.vmethod_19(new Button());
    this.vmethod_0().SuspendLayout();
    this.vmethod_2().SuspendLayout();
    this.vmethod_4().SuspendLayout();
    this.vmethod_14().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Alignment = TabAlignment.Left;
    this.vmethod_0().Controls.Add((Control) this.vmethod_2());
    this.vmethod_0().Controls.Add((Control) this.vmethod_4());
    this.vmethod_0().Controls.Add((Control) this.vmethod_14());
    this.vmethod_0().Dock = DockStyle.Fill;
    this.vmethod_0().DrawMode = TabDrawMode.OwnerDrawFixed;
    this.vmethod_0().method_7(false);
    GControl9 gcontrol9_1 = this.vmethod_0();
    Size size1 = new Size(26, 120);
    Size size2 = size1;
    gcontrol9_1.ItemSize = size2;
    GControl9 gcontrol9_2 = this.vmethod_0();
    Point point1 = new Point(0, 0);
    Point point2 = point1;
    gcontrol9_2.Location = point2;
    this.vmethod_0().Multiline = true;
    this.vmethod_0().Name = "FlatTabMain";
    this.vmethod_0().SelectedIndex = 0;
    GControl9 gcontrol9_3 = this.vmethod_0();
    size1 = new Size(532, 306);
    Size size3 = size1;
    gcontrol9_3.Size = size3;
    this.vmethod_0().SizeMode = TabSizeMode.Fixed;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_2().Controls.Add((Control) this.vmethod_6());
    this.vmethod_2().Controls.Add((Control) this.vmethod_8());
    TabPage tabPage1 = this.vmethod_2();
    point1 = new Point(124, 4);
    Point point3 = point1;
    tabPage1.Location = point3;
    this.vmethod_2().Name = "TabPageHtml";
    TabPage tabPage2 = this.vmethod_2();
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage2.Padding = padding2;
    TabPage tabPage3 = this.vmethod_2();
    size1 = new Size(404, 298);
    Size size4 = size1;
    tabPage3.Size = size4;
    this.vmethod_2().TabIndex = 0;
    this.vmethod_2().Tag = (object) "normal";
    this.vmethod_2().Text = "Html";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_6().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_6().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_1 = this.vmethod_6();
    point1 = new Point(5, 3);
    Point point4 = point1;
    gclass29_1.Location = point4;
    this.vmethod_6().Name = "BetterRichTextboxHtml";
    this.vmethod_6().method_1((string) null);
    GClass29 gclass29_2 = this.vmethod_6();
    size1 = new Size(396, 254);
    Size size5 = size1;
    gclass29_2.Size = size5;
    this.vmethod_6().TabIndex = 3;
    this.vmethod_8().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_8().ImageAlign = ContentAlignment.MiddleRight;
    Button button1 = this.vmethod_8();
    point1 = new Point(302, 263);
    Point point5 = point1;
    button1.Location = point5;
    this.vmethod_8().Name = "ButtonRunHtml";
    Button button2 = this.vmethod_8();
    size1 = new Size(99, 27);
    Size size6 = size1;
    button2.Size = size6;
    this.vmethod_8().TabIndex = 2;
    this.vmethod_8().Text = "Run Script";
    this.vmethod_8().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_8().UseVisualStyleBackColor = true;
    this.vmethod_4().Controls.Add((Control) this.vmethod_10());
    this.vmethod_4().Controls.Add((Control) this.vmethod_12());
    TabPage tabPage4 = this.vmethod_4();
    point1 = new Point(124, 4);
    Point point6 = point1;
    tabPage4.Location = point6;
    this.vmethod_4().Name = "TabPageVbs";
    TabPage tabPage5 = this.vmethod_4();
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage5.Padding = padding3;
    TabPage tabPage6 = this.vmethod_4();
    size1 = new Size(404, 298);
    Size size7 = size1;
    tabPage6.Size = size7;
    this.vmethod_4().TabIndex = 1;
    this.vmethod_4().Tag = (object) "normal";
    this.vmethod_4().Text = "Vbs";
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.vmethod_10().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_10().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_3 = this.vmethod_10();
    point1 = new Point(5, 3);
    Point point7 = point1;
    gclass29_3.Location = point7;
    this.vmethod_10().Name = "BetterRichTextboxVbs";
    this.vmethod_10().method_1((string) null);
    GClass29 gclass29_4 = this.vmethod_10();
    size1 = new Size(396, 254);
    Size size8 = size1;
    gclass29_4.Size = size8;
    this.vmethod_10().TabIndex = 5;
    this.vmethod_12().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_12().ImageAlign = ContentAlignment.MiddleRight;
    Button button3 = this.vmethod_12();
    point1 = new Point(302, 263);
    Point point8 = point1;
    button3.Location = point8;
    this.vmethod_12().Name = "btnRunVbs";
    Button button4 = this.vmethod_12();
    size1 = new Size(99, 27);
    Size size9 = size1;
    button4.Size = size9;
    this.vmethod_12().TabIndex = 4;
    this.vmethod_12().Text = "Run Script";
    this.vmethod_12().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_12().UseVisualStyleBackColor = true;
    this.vmethod_14().Controls.Add((Control) this.vmethod_16());
    this.vmethod_14().Controls.Add((Control) this.vmethod_18());
    TabPage tabPage7 = this.vmethod_14();
    point1 = new Point(124, 4);
    Point point9 = point1;
    tabPage7.Location = point9;
    this.vmethod_14().Name = "TabPageBatch";
    TabPage tabPage8 = this.vmethod_14();
    size1 = new Size(404, 298);
    Size size10 = size1;
    tabPage8.Size = size10;
    this.vmethod_14().TabIndex = 2;
    this.vmethod_14().Tag = (object) "normal";
    this.vmethod_14().Text = "Batch";
    this.vmethod_14().UseVisualStyleBackColor = true;
    this.vmethod_16().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_16().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_5 = this.vmethod_16();
    point1 = new Point(5, 3);
    Point point10 = point1;
    gclass29_5.Location = point10;
    this.vmethod_16().Name = "BetterRichTextboxBatch";
    this.vmethod_16().method_1((string) null);
    GClass29 gclass29_6 = this.vmethod_16();
    size1 = new Size(396, 254);
    Size size11 = size1;
    gclass29_6.Size = size11;
    this.vmethod_16().TabIndex = 7;
    this.vmethod_18().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_18().ImageAlign = ContentAlignment.MiddleRight;
    Button button5 = this.vmethod_18();
    point1 = new Point(302, 263);
    Point point11 = point1;
    button5.Location = point11;
    this.vmethod_18().Name = "btnRunBatch";
    Button button6 = this.vmethod_18();
    size1 = new Size(99, 27);
    Size size12 = size1;
    button6.Size = size12;
    this.vmethod_18().TabIndex = 6;
    this.vmethod_18().Text = "Run Script";
    this.vmethod_18().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_18().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(532, 306);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (ScriptingForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "FormScripting";
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_2().ResumeLayout(false);
    this.vmethod_4().ResumeLayout(false);
    this.vmethod_14().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GControl9 vmethod_0() => this.gcontrol9_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GControl9 gcontrol9_1) => this.gcontrol9_0 = gcontrol9_1;

  internal virtual TabPage vmethod_2() => this.tabPage_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(TabPage tabPage_3) => this.tabPage_0 = tabPage_3;

  internal virtual TabPage vmethod_4() => this.tabPage_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TabPage tabPage_3) => this.tabPage_1 = tabPage_3;

  internal virtual GClass29 vmethod_6() => this.gclass29_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(GClass29 gclass29_3) => this.gclass29_0 = gclass29_3;

  internal virtual Button vmethod_8() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(Button button_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_3;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual GClass29 vmethod_10() => this.gclass29_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(GClass29 gclass29_3) => this.gclass29_1 = gclass29_3;

  internal virtual Button vmethod_12() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(Button button_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_3;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual TabPage vmethod_14() => this.tabPage_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(TabPage tabPage_3) => this.tabPage_2 = tabPage_3;

  internal virtual GClass29 vmethod_16() => this.gclass29_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(GClass29 gclass29_3) => this.gclass29_2 = gclass29_3;

  internal virtual Button vmethod_18() => this.button_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(Button button_3)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.button_2 != null)
      this.button_2.Click -= eventHandler;
    this.button_2 = button_3;
    if (this.button_2 == null)
      return;
    this.button_2.Click += eventHandler;
  }

  private void method_0(object sender, EventArgs e) => this.method_3(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ScriptPacket.Html, this.vmethod_6().richTextBox_0.Text);

  private void method_1(object sender, EventArgs e) => this.method_3(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ScriptPacket.Vbs, this.vmethod_10().richTextBox_0.Text);

  private void method_2(object sender, EventArgs e) => this.method_3(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ScriptPacket.Batch, this.vmethod_16().richTextBox_0.Text);

  private void method_3(
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ScriptPacket scriptPacket_0,
    string string_0)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Scripting,
      (object) scriptPacket_0,
      (object) string_0
    });
  }

  private void ScriptingForm_Load(object sender, EventArgs e)
  {
    this.vmethod_18().Image = (Image) this.Icon.ToBitmap();
    this.vmethod_12().Image = (Image) this.Icon.ToBitmap();
    this.vmethod_8().Image = (Image) this.Icon.ToBitmap();
  }
}
