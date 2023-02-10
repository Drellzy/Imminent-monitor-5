// Decompiled with JetBrains decompiler
// Type: UserControlCipboard
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
public sealed class UserControlCipboard : UserControl
{
  private IContainer icontainer_0;
  private Button button_0;
  private Button button_1;
  private GClass29 gclass29_0;
  private GClass18 gclass18_0;

  public UserControlCipboard() => this.InitializeComponent();

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
    this.vmethod_5(new GClass29());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    Button button1 = this.vmethod_0();
    Point point1 = new Point(122, 453);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_0().Name = "ButtonSetClipBoard";
    Button button2 = this.vmethod_0();
    Size size1 = new Size(111, 27);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_0().TabIndex = 17;
    this.vmethod_0().Text = "Set Clipboard Text";
    this.vmethod_0().UseVisualStyleBackColor = true;
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    Button button3 = this.vmethod_2();
    point1 = new Point(3, 453);
    Point point3 = point1;
    button3.Location = point3;
    this.vmethod_2().Name = "ButtonGetClipBoard";
    Button button4 = this.vmethod_2();
    size1 = new Size(114, 27);
    Size size3 = size1;
    button4.Size = size3;
    this.vmethod_2().TabIndex = 16;
    this.vmethod_2().Text = "Get Clipboard Text";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_4().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_4().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_1 = this.vmethod_4();
    point1 = new Point(3, 3);
    Point point4 = point1;
    gclass29_1.Location = point4;
    this.vmethod_4().Name = "BetterRichTextboxClipboard";
    this.vmethod_4().method_1((string) null);
    GClass29 gclass29_2 = this.vmethod_4();
    size1 = new Size(731, 444);
    Size size4 = size1;
    gclass29_2.Size = size4;
    this.vmethod_4().TabIndex = 19;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlCipboard);
    size1 = new Size(736, 483);
    this.Size = size1;
    this.ResumeLayout(false);
  }

  internal virtual Button vmethod_0() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_6);
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
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual GClass29 vmethod_4() => this.gclass29_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(GClass29 gclass29_1) => this.gclass29_0 = gclass29_1;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  private void method_2() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), new object[1]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClipBoardGet
  });

  public void method_3()
  {
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ClipBoardSet,
      (object) this.vmethod_4().richTextBox_0.Text
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_4(object[] object_0)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Class97.Delegate14(this.method_4), (object) object_0);
    }
    else
    {
      string str = (string) object_0[1];
      this.vmethod_4().richTextBox_0.Text = str;
    }
  }

  private void method_5(object sender, EventArgs e) => this.method_2();

  private void method_6(object sender, EventArgs e) => this.method_3();
}
