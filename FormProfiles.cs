// Decompiled with JetBrains decompiler
// Type: FormProfiles
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
public sealed class FormProfiles : Form
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private ColumnHeader columnHeader_0;
  private Button button_0;
  private Button button_1;
  private ImageList imageList_0;
  private Bitmap bitmap_0;

  public FormProfiles()
  {
    this.Load += new EventHandler(this.FormProfiles_Load);
    this.bitmap_0 = Class97.smethod_17(Class145.smethod_13());
    this.InitializeComponent();
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
    this.vmethod_5(new Button());
    this.vmethod_7(new Button());
    this.vmethod_9(new ImageList(this.icontainer_0));
    this.vmethod_1(new GClass41());
    this.vmethod_3(new ColumnHeader());
    this.SuspendLayout();
    this.vmethod_4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_4().Enabled = false;
    Button button1 = this.vmethod_4();
    Point point1 = new Point(178, 240);
    Point point2 = point1;
    button1.Location = point2;
    this.vmethod_4().Name = "ButtonLoad";
    Button button2 = this.vmethod_4();
    Size size1 = new Size(131, 25);
    Size size2 = size1;
    button2.Size = size2;
    this.vmethod_4().TabIndex = 1;
    this.vmethod_4().Text = "Load Selected Profile";
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.vmethod_6().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    Button button3 = this.vmethod_6();
    point1 = new Point(10, 240);
    Point point3 = point1;
    button3.Location = point3;
    this.vmethod_6().Name = "ButtonCancel";
    Button button4 = this.vmethod_6();
    size1 = new Size(64, 25);
    Size size3 = size1;
    button4.Size = size3;
    this.vmethod_6().TabIndex = 2;
    this.vmethod_6().Text = "Cancel";
    this.vmethod_6().UseVisualStyleBackColor = true;
    this.vmethod_8().ColorDepth = ColorDepth.Depth24Bit;
    ImageList imageList = this.vmethod_8();
    size1 = new Size(24, 24);
    Size size4 = size1;
    imageList.ImageSize = size4;
    this.vmethod_8().TransparentColor = Color.Transparent;
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[1]
    {
      this.vmethod_2()
    });
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_0();
    point1 = new Point(10, 12);
    Point point4 = point1;
    gclass41_1.Location = point4;
    this.vmethod_0().MultiSelect = false;
    this.vmethod_0().Name = "AeroListviewProfiles";
    GClass41 gclass41_2 = this.vmethod_0();
    size1 = new Size(299, 221);
    Size size5 = size1;
    gclass41_2.Size = size5;
    this.vmethod_0().SmallImageList = this.vmethod_8();
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Details;
    this.vmethod_2().Text = "Profile Name";
    this.vmethod_2().Width = 291;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(319, 275);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormProfiles);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Builder Profiles";
    this.ResumeLayout(false);
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_1);
    if (this.gclass41_0 != null)
      this.gclass41_0.SelectedIndexChanged -= eventHandler;
    this.gclass41_0 = gclass41_1;
    if (this.gclass41_0 == null)
      return;
    this.gclass41_0.SelectedIndexChanged += eventHandler;
  }

  internal virtual ColumnHeader vmethod_2() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ColumnHeader columnHeader_1) => this.columnHeader_0 = columnHeader_1;

  internal virtual Button vmethod_4() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_2;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual Button vmethod_6() => this.button_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_0);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual ImageList vmethod_8() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ImageList imageList_1) => this.imageList_0 = imageList_1;

  private void FormProfiles_Load(object sender, EventArgs e)
  {
    this.vmethod_8().Images.Add((Image) this.bitmap_0);
    this.method_3();
  }

  private void method_0(object sender, EventArgs e) => this.Close();

  private void method_1(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count > 0)
      this.vmethod_4().Enabled = true;
    else
      this.vmethod_4().Enabled = false;
  }

  private void method_2(object sender, EventArgs e)
  {
    Class148.smethod_0(this.vmethod_0().SelectedItems[0].Text);
    this.Close();
  }

  private void method_3()
  {
    this.vmethod_0().Items.Clear();
    if (this.method_4() == null)
      return;
    try
    {
      foreach (string str in this.method_4())
      {
        ListViewItem listViewItem = new ListViewItem()
        {
          Text = str,
          ImageIndex = 0
        };
        this.vmethod_0().Items.Add(listViewItem);
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public List<string> method_4()
  {
    List<string> stringList = new List<string>();
    if (!Directory.Exists(Application.StartupPath + "\\Settings\\Profiles\\"))
      return (List<string>) null;
    foreach (string file in Directory.GetFiles(Application.StartupPath + "\\Settings\\Profiles\\"))
    {
      FileInfo fileInfo = new FileInfo(file);
      if (Operators.CompareString(fileInfo.Name.Split(Conversions.ToCharArrayRankOne("."))[1], "settings", false) == 0)
        stringList.Add(fileInfo.Name.Split('.')[0]);
    }
    return stringList;
  }
}
