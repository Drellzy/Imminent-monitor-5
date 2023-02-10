// Decompiled with JetBrains decompiler
// Type: UserControlOnConnect
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
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlOnConnect : UserControl
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ComboBox comboBox_0;
  private Label label_0;
  private ComboBox comboBox_1;
  private Label label_1;
  private TextBox textBox_0;
  private Label label_2;
  private Button button_0;
  private ContextMenuStrip contextMenuStrip_0;
  private ToolStripMenuItem toolStripMenuItem_0;

  public UserControlOnConnect()
  {
    this.Load += new EventHandler(this.UserControlOnConnect_Load);
    this.InitializeComponent();
    if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
      return;
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
    this.vmethod_9(new ComboBox());
    this.vmethod_11(new Label());
    this.vmethod_13(new ComboBox());
    this.vmethod_15(new Label());
    this.vmethod_17(new TextBox());
    this.vmethod_19(new Label());
    this.vmethod_21(new Button());
    this.vmethod_1(new GClass41());
    this.vmethod_3(new ColumnHeader());
    this.vmethod_5(new ColumnHeader());
    this.vmethod_7(new ColumnHeader());
    this.vmethod_23(new ContextMenuStrip(this.icontainer_0));
    this.vmethod_25(new ToolStripMenuItem());
    this.vmethod_22().SuspendLayout();
    this.SuspendLayout();
    this.vmethod_8().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_8().DropDownStyle = ComboBoxStyle.DropDownList;
    this.vmethod_8().FormattingEnabled = true;
    this.vmethod_8().Items.AddRange(new object[3]
    {
      (object) "Download & Execute",
      (object) "Update",
      (object) "Elevate"
    });
    ComboBox comboBox1 = this.vmethod_8();
    Point point1 = new Point(3, 437);
    Point point2 = point1;
    comboBox1.Location = point2;
    this.vmethod_8().Name = "ComboBoxCommand";
    ComboBox comboBox2 = this.vmethod_8();
    Size size1 = new Size(190, 21);
    Size size2 = size1;
    comboBox2.Size = size2;
    this.vmethod_8().TabIndex = 2;
    this.vmethod_10().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_10().AutoSize = true;
    Label label1 = this.vmethod_10();
    point1 = new Point(0, 421);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_10().Name = "LabelCommand";
    Label label2 = this.vmethod_10();
    size1 = new Size(59, 13);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_10().TabIndex = 3;
    this.vmethod_10().Text = "Command";
    this.vmethod_12().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_12().DropDownStyle = ComboBoxStyle.DropDownList;
    this.vmethod_12().FormattingEnabled = true;
    this.vmethod_12().Items.AddRange(new object[12]
    {
      (object) "All",
      (object) "5.0.0.3",
      (object) "4.5.1",
      (object) "4.4.1",
      (object) "4.4",
      (object) "4.3",
      (object) "4.2",
      (object) "4.1",
      (object) "4.0",
      (object) "3.9.5",
      (object) "3.9.4",
      (object) "3.9"
    });
    ComboBox comboBox3 = this.vmethod_12();
    point1 = new Point(199, 437);
    Point point4 = point1;
    comboBox3.Location = point4;
    this.vmethod_12().Name = "ComboBoxCommandType";
    ComboBox comboBox4 = this.vmethod_12();
    size1 = new Size(151, 21);
    Size size4 = size1;
    comboBox4.Size = size4;
    this.vmethod_12().TabIndex = 4;
    this.vmethod_14().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_14().AutoSize = true;
    Label label3 = this.vmethod_14();
    point1 = new Point(196, 421);
    Point point5 = point1;
    label3.Location = point5;
    this.vmethod_14().Name = "LabelCommandType";
    Label label4 = this.vmethod_14();
    size1 = new Size(99, 13);
    Size size5 = size1;
    label4.Size = size5;
    this.vmethod_14().TabIndex = 5;
    this.vmethod_14().Text = "If Client Version =";
    this.vmethod_16().Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    TextBox textBox1 = this.vmethod_16();
    point1 = new Point(356, 436);
    Point point6 = point1;
    textBox1.Location = point6;
    this.vmethod_16().Name = "TextBox1";
    TextBox textBox2 = this.vmethod_16();
    size1 = new Size(290, 22);
    Size size6 = size1;
    textBox2.Size = size6;
    this.vmethod_16().TabIndex = 6;
    this.vmethod_18().Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_18().AutoSize = true;
    Label label5 = this.vmethod_18();
    point1 = new Point(353, 420);
    Point point7 = point1;
    label5.Location = point7;
    this.vmethod_18().Name = "LabelCommandData";
    Label label6 = this.vmethod_18();
    size1 = new Size(86, 13);
    Size size7 = size1;
    label6.Size = size7;
    this.vmethod_18().TabIndex = 7;
    this.vmethod_18().Text = "Command Data";
    this.vmethod_20().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_20().Image = (Image) Class145.smethod_58();
    Button button1 = this.vmethod_20();
    point1 = new Point(654, 435);
    Point point8 = point1;
    button1.Location = point8;
    this.vmethod_20().Name = "ButtonAdd";
    Button button2 = this.vmethod_20();
    size1 = new Size(75, 24);
    Size size8 = size1;
    button2.Size = size8;
    this.vmethod_20().TabIndex = 8;
    this.vmethod_20().Text = "Add";
    this.vmethod_20().TextAlign = ContentAlignment.MiddleRight;
    this.vmethod_20().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_20().UseVisualStyleBackColor = true;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[3]
    {
      this.vmethod_2(),
      this.vmethod_4(),
      this.vmethod_6()
    });
    this.vmethod_0().ContextMenuStrip = this.vmethod_22();
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_0();
    point1 = new Point(3, 3);
    Point point9 = point1;
    gclass41_1.Location = point9;
    this.vmethod_0().Name = "AeroListviewOnConnect";
    GClass41 gclass41_2 = this.vmethod_0();
    size1 = new Size(725, 415);
    Size size9 = size1;
    gclass41_2.Size = size9;
    this.vmethod_0().TabIndex = 1;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Details;
    this.vmethod_2().Text = "Command";
    this.vmethod_2().Width = 194;
    this.vmethod_4().Text = "Client Version";
    this.vmethod_4().Width = 150;
    this.vmethod_6().Text = "Command Data";
    this.vmethod_6().Width = 376;
    this.vmethod_22().Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.vmethod_24()
    });
    this.vmethod_22().Name = "ContextMenuStrip1";
    ContextMenuStrip contextMenuStrip = this.vmethod_22();
    size1 = new Size(108, 26);
    Size size10 = size1;
    contextMenuStrip.Size = size10;
    this.vmethod_24().Name = "DeleteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem = this.vmethod_24();
    size1 = new Size(107, 22);
    Size size11 = size1;
    toolStripMenuItem.Size = size11;
    this.vmethod_24().Text = "Delete";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_20());
    this.Controls.Add((Control) this.vmethod_18());
    this.Controls.Add((Control) this.vmethod_16());
    this.Controls.Add((Control) this.vmethod_14());
    this.Controls.Add((Control) this.vmethod_12());
    this.Controls.Add((Control) this.vmethod_10());
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlOnConnect);
    size1 = new Size(732, 464);
    this.Size = size1;
    this.vmethod_22().ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_1) => this.gclass41_0 = gclass41_1;

  internal virtual ColumnHeader vmethod_2() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ColumnHeader columnHeader_3) => this.columnHeader_0 = columnHeader_3;

  internal virtual ColumnHeader vmethod_4() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(ColumnHeader columnHeader_3) => this.columnHeader_1 = columnHeader_3;

  internal virtual ColumnHeader vmethod_6() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ColumnHeader columnHeader_3) => this.columnHeader_2 = columnHeader_3;

  internal virtual ComboBox vmethod_8() => this.comboBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ComboBox comboBox_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_4);
    if (this.comboBox_0 != null)
      this.comboBox_0.SelectedIndexChanged -= eventHandler;
    this.comboBox_0 = comboBox_2;
    if (this.comboBox_0 == null)
      return;
    this.comboBox_0.SelectedIndexChanged += eventHandler;
  }

  internal virtual Label vmethod_10() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(Label label_3) => this.label_0 = label_3;

  internal virtual ComboBox vmethod_12() => this.comboBox_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ComboBox comboBox_2) => this.comboBox_1 = comboBox_2;

  internal virtual Label vmethod_14() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(Label label_3) => this.label_1 = label_3;

  internal virtual TextBox vmethod_16() => this.textBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(TextBox textBox_1) => this.textBox_0 = textBox_1;

  internal virtual Label vmethod_18() => this.label_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(Label label_3) => this.label_2 = label_3;

  internal virtual Button vmethod_20() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_21(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual ContextMenuStrip vmethod_22() => this.contextMenuStrip_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_23(ContextMenuStrip contextMenuStrip_1) => this.contextMenuStrip_0 = contextMenuStrip_1;

  internal virtual ToolStripMenuItem vmethod_24() => this.toolStripMenuItem_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_25(ToolStripMenuItem toolStripMenuItem_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.toolStripMenuItem_0 != null)
      this.toolStripMenuItem_0.Click -= eventHandler;
    this.toolStripMenuItem_0 = toolStripMenuItem_1;
    if (this.toolStripMenuItem_0 == null)
      return;
    this.toolStripMenuItem_0.Click += eventHandler;
  }

  private void method_0()
  {
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_8();
    if (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0 == null)
      return;
    try
    {
      foreach (GClass20 gclass20 in dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0)
        this.vmethod_0().Items.Add(new ListViewItem()
        {
          Text = gclass20.genum6_0.ToString(),
          SubItems = {
            gclass20.string_1,
            gclass20.string_0
          },
          Tag = (object) gclass20.string_2
        });
    }
    finally
    {
      List<GClass20>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void UserControlOnConnect_Load(object sender, EventArgs e)
  {
    this.vmethod_20().Image = (Image) Class145.smethod_58();
    Class97.smethod_10(this.vmethod_16(), "http://www.example.com/direct.exe");
    this.vmethod_8().SelectedIndex = 0;
    this.vmethod_12().SelectedIndex = 0;
  }

  private void method_1(object sender, EventArgs e)
  {
    string str = Guid.NewGuid().ToString();
    this.vmethod_0().Items.Add(new ListViewItem()
    {
      Text = this.vmethod_8().Text,
      SubItems = {
        this.vmethod_12().Text,
        this.vmethod_16().Text
      },
      Tag = (object) str
    });
    GClass20 gclass20_0 = new GClass20();
    gclass20_0.string_1 = this.vmethod_12().Text;
    gclass20_0.genum6_0 = (GClass20.GEnum6) this.vmethod_8().SelectedIndex;
    gclass20_0.string_0 = this.vmethod_16().Text;
    gclass20_0.string_2 = str;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0.Add(gclass20_0);
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_9(gclass20_0);
  }

  private void method_2(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count == 0)
      return;
    ListViewItem selectedItem = this.vmethod_0().SelectedItems[0];
    this.method_3((string) selectedItem.Tag);
    if (selectedItem == null)
      return;
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.gclass22_0.method_10((string) selectedItem.Tag);
    this.vmethod_0().Items.Remove(selectedItem);
  }

  private void method_3(string string_0)
  {
    try
    {
      foreach (GClass20 gclass20 in dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0)
      {
        if (Operators.CompareString(gclass20.string_2, string_0, false) == 0)
        {
          dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.list_0.Remove(gclass20);
          break;
        }
      }
    }
    finally
    {
      List<GClass20>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void method_4(object sender, EventArgs e)
  {
    if (this.vmethod_8().SelectedIndex == 2)
    {
      this.vmethod_16().Visible = false;
      this.vmethod_18().Visible = false;
    }
    else
    {
      this.vmethod_16().Visible = true;
      this.vmethod_18().Visible = true;
    }
  }
}
