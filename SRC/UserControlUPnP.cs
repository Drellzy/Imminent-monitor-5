// Decompiled with JetBrains decompiler
// Type: UserControlUPnP
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using Mono.Nat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlUPnP : UserControl
{
  private IContainer icontainer_0;
  private GClass41 gclass41_0;
  private Label label_0;
  private Button button_0;
  private Button button_1;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private ColumnHeader columnHeader_5;
  private GClass25 gclass25_0;

  public UserControlUPnP()
  {
    this.Load += new EventHandler(this.UserControlUPnP_Load);
    this.vmethod_21(new GClass25());
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
    this.vmethod_1(new GClass41());
    this.vmethod_3(new Label());
    this.vmethod_5(new Button());
    this.vmethod_7(new Button());
    this.vmethod_9(new ColumnHeader());
    this.vmethod_11(new ColumnHeader());
    this.vmethod_13(new ColumnHeader());
    this.vmethod_15(new ColumnHeader());
    this.vmethod_17(new ColumnHeader());
    this.vmethod_19(new ColumnHeader());
    this.SuspendLayout();
    this.vmethod_0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.vmethod_0().Columns.AddRange(new ColumnHeader[3]
    {
      this.vmethod_14(),
      this.vmethod_16(),
      this.vmethod_18()
    });
    this.vmethod_0().Enabled = false;
    this.vmethod_0().Font = new Font("Segoe UI", 8.25f);
    this.vmethod_0().FullRowSelect = true;
    this.vmethod_0().HideSelection = false;
    GClass41 gclass41_1 = this.vmethod_0();
    Point point1 = new Point(3, 3);
    Point point2 = point1;
    gclass41_1.Location = point2;
    this.vmethod_0().Name = "AeroListviewUPnP";
    GClass41 gclass41_2 = this.vmethod_0();
    Size size1 = new Size(726, 427);
    Size size2 = size1;
    gclass41_2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_0().UseCompatibleStateImageBehavior = false;
    this.vmethod_0().View = View.Details;
    this.vmethod_2().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.vmethod_2().AutoSize = true;
    Label label1 = this.vmethod_2();
    point1 = new Point(3, 442);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_2().Name = "LabelStatus";
    Label label2 = this.vmethod_2();
    size1 = new Size(66, 13);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "Status: Null";
    this.vmethod_4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_4().Enabled = false;
    this.vmethod_4().Image = (Image) Class145.smethod_58();
    Button button1 = this.vmethod_4();
    point1 = new Point(588, 436);
    Point point4 = point1;
    button1.Location = point4;
    this.vmethod_4().Name = "ButtonAddMapping";
    Button button2 = this.vmethod_4();
    size1 = new Size(141, 25);
    Size size4 = size1;
    button2.Size = size4;
    this.vmethod_4().TabIndex = 2;
    this.vmethod_4().Text = "Add Port Mapping";
    this.vmethod_4().TextAlign = ContentAlignment.MiddleRight;
    this.vmethod_4().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.vmethod_6().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.vmethod_6().Enabled = false;
    this.vmethod_6().Image = (Image) Class145.smethod_22();
    Button button3 = this.vmethod_6();
    point1 = new Point(355, 436);
    Point point5 = point1;
    button3.Location = point5;
    this.vmethod_6().Name = "ButtonRemove";
    Button button4 = this.vmethod_6();
    size1 = new Size(227, 25);
    Size size5 = size1;
    button4.Size = size5;
    this.vmethod_6().TabIndex = 3;
    this.vmethod_6().Text = "Remove Selected Port Mapping(s)";
    this.vmethod_6().TextAlign = ContentAlignment.MiddleRight;
    this.vmethod_6().TextImageRelation = TextImageRelation.ImageBeforeText;
    this.vmethod_6().UseVisualStyleBackColor = true;
    this.vmethod_8().Text = "Port";
    this.vmethod_8().Width = 129;
    this.vmethod_10().Text = "Protocol";
    this.vmethod_10().Width = 141;
    this.vmethod_12().Text = "Description";
    this.vmethod_12().Width = 440;
    this.vmethod_14().Text = "Ports";
    this.vmethod_14().Width = 156;
    this.vmethod_16().Text = "Protocol";
    this.vmethod_16().Width = 132;
    this.vmethod_18().Text = "Description";
    this.vmethod_18().Width = 423;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlUPnP);
    size1 = new Size(732, 464);
    this.Size = size1;
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual GClass41 vmethod_0() => this.gclass41_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(GClass41 gclass41_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_4);
    if (this.gclass41_0 != null)
      this.gclass41_0.SelectedIndexChanged -= eventHandler;
    this.gclass41_0 = gclass41_1;
    if (this.gclass41_0 == null)
      return;
    this.gclass41_0.SelectedIndexChanged += eventHandler;
  }

  internal virtual Label vmethod_2() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Label label_1) => this.label_0 = label_1;

  internal virtual Button vmethod_4() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Button button_2)
  {
    EventHandler eventHandler = new EventHandler(this.method_5);
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
    EventHandler eventHandler = new EventHandler(this.method_6);
    if (this.button_1 != null)
      this.button_1.Click -= eventHandler;
    this.button_1 = button_2;
    if (this.button_1 == null)
      return;
    this.button_1.Click += eventHandler;
  }

  internal virtual ColumnHeader vmethod_8() => this.columnHeader_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(ColumnHeader columnHeader_6) => this.columnHeader_0 = columnHeader_6;

  internal virtual ColumnHeader vmethod_10() => this.columnHeader_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_11(ColumnHeader columnHeader_6) => this.columnHeader_1 = columnHeader_6;

  internal virtual ColumnHeader vmethod_12() => this.columnHeader_2;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_13(ColumnHeader columnHeader_6) => this.columnHeader_2 = columnHeader_6;

  internal virtual ColumnHeader vmethod_14() => this.columnHeader_3;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_15(ColumnHeader columnHeader_6) => this.columnHeader_3 = columnHeader_6;

  internal virtual ColumnHeader vmethod_16() => this.columnHeader_4;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_17(ColumnHeader columnHeader_6) => this.columnHeader_4 = columnHeader_6;

  internal virtual ColumnHeader vmethod_18() => this.columnHeader_5;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_19(ColumnHeader columnHeader_6) => this.columnHeader_5 = columnHeader_6;

  public virtual GClass25 vmethod_20() => this.gclass25_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_21(GClass25 gclass25_1)
  {
    GClass25.GDelegate8 gdelegate8_1 = new GClass25.GDelegate8(this.method_2);
    if (this.gclass25_0 != null)
      this.gclass25_0.method_1(gdelegate8_1);
    this.gclass25_0 = gclass25_1;
    if (this.gclass25_0 == null)
      return;
    this.gclass25_0.method_0(gdelegate8_1);
  }

  private void UserControlUPnP_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    new Thread(new ThreadStart(this.method_0)).Start();
    this.method_1("Attempting to find universal plug and play device");
  }

  private void method_0()
  {
    this.vmethod_20().method_4();
    Thread.Sleep(10000);
    this.vmethod_20().method_5();
    if (this.vmethod_20().bool_0)
      return;
    this.method_1("Failed to find universal plug and play device");
  }

  private void method_1(string string_0)
  {
    UserControlUPnP.Class149 class149 = new UserControlUPnP.Class149();
    class149.string_0 = string_0;
    class149.userControlUPnP_0 = this;
    this.Invoke((Delegate) new Delegate0(class149._Lambda\u0024__73));
    Class97.gclass2_0.method_0(class149.string_0, Class97.gclass2_0.textStyle_0);
  }

  private void method_2(INatDevice inatDevice_0)
  {
    this.vmethod_20().method_5();
    this.method_1(string.Format("Connected to UPnP device at: {0}", (object) ((object) inatDevice_0).ToString().Split(':')[1]));
    this.Invoke((Delegate) (() => this.vmethod_4().Enabled = true));
    this.Invoke((Delegate) (() => this.method_3()));
  }

  public void method_3()
  {
    try
    {
      this.method_1("Refreshing port mappings...");
      this.vmethod_0().Items.Clear();
      List<object> objectList = new List<object>();
      objectList.AddRange((IEnumerable<object>) this.vmethod_20().method_7());
      int num = objectList.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        ListViewItem listViewItem = new ListViewItem();
        Mapping mapping = (Mapping) objectList[index];
        listViewItem.Tag = (object) mapping;
        listViewItem.Text = Conversions.ToString(mapping.PublicPort);
        listViewItem.SubItems.Add(((Enum) (object) mapping.Protocol).ToString().ToUpper());
        listViewItem.SubItems.Add(mapping.Description);
        this.vmethod_0().Items.Add(listViewItem);
      }
      this.vmethod_0().Enabled = true;
      this.method_1(string.Format("Connected to UPnP device at: {0}", (object) ((object) this.vmethod_20().method_2()).ToString().Split(':')[1]));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_1("Failed to refresh port mappings.");
      ProjectData.ClearProjectError();
    }
  }

  private void method_4(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count >= 1)
      this.vmethod_6().Enabled = true;
    else
      this.vmethod_6().Enabled = false;
  }

  private void method_5(object sender, EventArgs e)
  {
    try
    {
      ushort ushort_0 = 0;
      FormDialog formDialog = new FormDialog(true, "Add Port Mapping", "Please enter a port number");
      if (formDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
        ushort_0 = Conversions.ToUShort(formDialog.vmethod_4().Text);
      if (ushort_0 >= (ushort) 1024)
      {
        if (ushort_0 == (ushort) 0)
          return;
        this.vmethod_20().method_8(ushort_0);
        this.method_3();
      }
      else
      {
        int num = (int) MessageBox.Show("Port must be larger than 1024", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.method_1("Failed to add port mapping");
      ProjectData.ClearProjectError();
    }
  }

  private void method_6(object sender, EventArgs e)
  {
    if (this.vmethod_0().SelectedItems.Count < 1)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.vmethod_0().SelectedItems)
      {
        try
        {
          this.vmethod_20().method_9((Mapping) selectedItem.Tag);
          this.method_3();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  internal sealed class Class149
  {
    public string string_0;
    public UserControlUPnP userControlUPnP_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__73() => this.userControlUPnP_0.vmethod_2().Text = string.Format("Status: {0}", (object) this.string_0);
  }
}
