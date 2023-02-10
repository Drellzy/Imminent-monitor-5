// Decompiled with JetBrains decompiler
// Type: FormGeoIPHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormGeoIPHandler : Form
{
  private IContainer icontainer_0;
  private ComboBox comboBox_0;
  private Label label_0;
  private Button button_0;
  private ProgressBar progressBar_0;
  private Label label_1;
  private string string_0;

  public FormGeoIPHandler()
  {
    this.Load += new EventHandler(this.FormGeoIPHandler_Load);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormGeoIPHandler));
    this.vmethod_1(new ComboBox());
    this.vmethod_3(new Label());
    this.vmethod_5(new Button());
    this.vmethod_7(new ProgressBar());
    this.vmethod_9(new Label());
    this.SuspendLayout();
    this.vmethod_0().DropDownStyle = ComboBoxStyle.DropDownList;
    this.vmethod_0().FormattingEnabled = true;
    ComboBox comboBox1 = this.vmethod_0();
    Point point1 = new Point(15, 27);
    Point point2 = point1;
    comboBox1.Location = point2;
    this.vmethod_0().Name = "ComboBoxSelectedDatabase";
    ComboBox comboBox2 = this.vmethod_0();
    Size size1 = new Size(327, 21);
    Size size2 = size1;
    comboBox2.Size = size2;
    this.vmethod_0().TabIndex = 0;
    this.vmethod_2().AutoSize = true;
    Label label1 = this.vmethod_2();
    point1 = new Point(12, 9);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_2().Name = "LabelSelectedDatabase";
    Label label2 = this.vmethod_2();
    size1 = new Size(101, 13);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_2().TabIndex = 1;
    this.vmethod_2().Text = "Selected Database";
    Button button1 = this.vmethod_4();
    point1 = new Point(267, 54);
    Point point4 = point1;
    button1.Location = point4;
    this.vmethod_4().Name = "ButtonApply";
    Button button2 = this.vmethod_4();
    size1 = new Size(75, 23);
    Size size4 = size1;
    button2.Size = size4;
    this.vmethod_4().TabIndex = 2;
    this.vmethod_4().Text = "Apply";
    this.vmethod_4().UseVisualStyleBackColor = true;
    ProgressBar progressBar1 = this.vmethod_6();
    point1 = new Point(15, 55);
    Point point5 = point1;
    progressBar1.Location = point5;
    this.vmethod_6().Name = "ProgressBarDownload";
    ProgressBar progressBar2 = this.vmethod_6();
    size1 = new Size(246, 21);
    Size size5 = size1;
    progressBar2.Size = size5;
    this.vmethod_6().TabIndex = 3;
    this.vmethod_6().Visible = false;
    this.vmethod_8().AutoSize = true;
    Label label3 = this.vmethod_8();
    point1 = new Point(12, 80);
    Point point6 = point1;
    label3.Location = point6;
    this.vmethod_8().Name = "LabelProgress";
    Label label4 = this.vmethod_8();
    size1 = new Size(51, 13);
    Size size6 = size1;
    label4.Size = size6;
    this.vmethod_8().TabIndex = 4;
    this.vmethod_8().Text = "Progress";
    this.vmethod_8().Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(354, 101);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.vmethod_8());
    this.Controls.Add((Control) this.vmethod_6());
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_2());
    this.Controls.Add((Control) this.vmethod_0());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormGeoIPHandler);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Geo IP Settings";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual ComboBox vmethod_0() => this.comboBox_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ComboBox comboBox_1) => this.comboBox_0 = comboBox_1;

  internal virtual Label vmethod_2() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Label label_2) => this.label_0 = label_2;

  internal virtual Button vmethod_4() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_2);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  internal virtual ProgressBar vmethod_6() => this.progressBar_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_7(ProgressBar progressBar_1) => this.progressBar_0 = progressBar_1;

  internal virtual Label vmethod_8() => this.label_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_9(Label label_2) => this.label_1 = label_2;

  private void FormGeoIPHandler_Load(object sender, EventArgs e)
  {
    Class97.smethod_11((Form) this);
    this.method_0();
  }

  private void method_0()
  {
    this.string_0 = Application.StartupPath + "\\Resources\\Databases";
    this.vmethod_0().Items.Clear();
    this.vmethod_0().Items.Add((object) "Default GeoIP Database");
    if (this.method_1())
      this.vmethod_0().Items.Add((object) "Enhanced GeoIP Database");
    else
      this.vmethod_0().Items.Add((object) "Enhanced GeoIP Database (requires 60.8mb download)");
    this.vmethod_0().SelectedIndex = Class97.generalSettings_0.GeoIPSetting;
  }

  private bool method_1() => System.IO.File.Exists(this.string_0 + "\\maxmind.mmdb");

  private void method_2(object sender, EventArgs e)
  {
    if (this.method_1())
    {
      Class97.generalSettings_0.GeoIPSetting = this.vmethod_0().SelectedIndex;
      Class97.generalSettings_0.SaveSettings();
      this.Close();
    }
    else
    {
      this.vmethod_6().Visible = true;
      this.vmethod_8().Visible = true;
      this.vmethod_4().Enabled = false;
      this.method_3();
    }
  }

  private void method_3()
  {
    WebClient webClient = new WebClient();
    webClient.Proxy = (IWebProxy) null;
    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.method_5);
    webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(this.method_4);
    webClient.DownloadDataAsync(new Uri("http://ovh.imminentmethods.net/dl/maxmind.mmdb"));
  }

  private void method_4(object sender, DownloadDataCompletedEventArgs e)
  {
    System.IO.File.WriteAllBytes(this.string_0 + "\\maxmind.mmdb", e.Result);
    this.Invoke((Delegate) (() => this.method_6()));
  }

  private void method_5(object sender, DownloadProgressChangedEventArgs e)
  {
    FormGeoIPHandler.Class84 class84 = new FormGeoIPHandler.Class84();
    class84.formGeoIPHandler_0 = this;
    double num1 = double.Parse(e.BytesReceived.ToString());
    double num2 = double.Parse(e.TotalBytesToReceive.ToString());
    class84.double_1 = num1 / num2 * 100.0;
    class84.double_0 = num1 / 1024.0 / 1024.0;
    class84.double_2 = num2 / 1024.0 / 1024.0;
    this.Invoke((Delegate) new Delegate0(class84._Lambda\u0024__46));
    this.Invoke((Delegate) new Delegate0(class84._Lambda\u0024__47));
  }

  private void method_6()
  {
    Class97.generalSettings_0.GeoIPSetting = this.vmethod_0().SelectedIndex;
    Class97.generalSettings_0.SaveSettings();
    this.vmethod_6().Visible = false;
    this.vmethod_8().Visible = false;
    this.vmethod_4().Enabled = true;
    int num = (int) MessageBox.Show("Download complete! Database installed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  internal sealed class Class84
  {
    public double double_0;
    public double double_1;
    public double double_2;
    public FormGeoIPHandler formGeoIPHandler_0;

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__46() => this.formGeoIPHandler_0.vmethod_8().Text = string.Format("Downloading Database ({0}%) ({1}mb / {2}mb)", (object) (int) Math.Round(Math.Truncate(this.double_1)), (object) this.double_0.ToString("0.00"), (object) this.double_2.ToString("0.00"));

    [CompilerGenerated]
    [SpecialName]
    public void _Lambda\u0024__47() => this.formGeoIPHandler_0.vmethod_6().Value = (int) Math.Round(Math.Truncate(this.double_1));
  }
}
