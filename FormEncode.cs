// Decompiled with JetBrains decompiler
// Type: FormEncode
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class FormEncode : Form
{
  private IContainer icontainer_0;
  private ProgressBar progressBar_0;
  private Label label_0;
  private Button button_0;
  private int int_0;
  private string string_0;
  private string string_1;
  private bool bool_0;

  public FormEncode(int int_1, string string_2)
  {
    this.Load += new EventHandler(this.FormEncode_Load);
    this.bool_0 = false;
    this.int_0 = int_1;
    this.string_1 = string_2;
    this.string_0 = this.method_2();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormEncode));
    this.vmethod_1(new ProgressBar());
    this.vmethod_3(new Label());
    this.vmethod_5(new Button());
    this.SuspendLayout();
    ProgressBar progressBar1 = this.vmethod_0();
    Point point1 = new Point(60, 26);
    Point point2 = point1;
    progressBar1.Location = point2;
    this.vmethod_0().Name = "ProgressBar1";
    ProgressBar progressBar2 = this.vmethod_0();
    Size size1 = new Size(164, 15);
    Size size2 = size1;
    progressBar2.Size = size2;
    this.vmethod_0().TabIndex = 3;
    this.vmethod_2().AutoSize = true;
    Label label1 = this.vmethod_2();
    point1 = new Point(57, 9);
    Point point3 = point1;
    label1.Location = point3;
    this.vmethod_2().Name = "LabelUpdating";
    Label label2 = this.vmethod_2();
    size1 = new Size(115, 13);
    Size size3 = size1;
    label2.Size = size3;
    this.vmethod_2().TabIndex = 2;
    this.vmethod_2().Text = "Encoding Frame 0 / 0";
    Button button1 = this.vmethod_4();
    point1 = new Point(105, 47);
    Point point4 = point1;
    button1.Location = point4;
    this.vmethod_4().Name = "ButtonCancel";
    Button button2 = this.vmethod_4();
    size1 = new Size(75, 23);
    Size size4 = size1;
    button2.Size = size4;
    this.vmethod_4().TabIndex = 4;
    this.vmethod_4().Text = "Cancel";
    this.vmethod_4().UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    size1 = new Size(284, 82);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.vmethod_4());
    this.Controls.Add((Control) this.vmethod_0());
    this.Controls.Add((Control) this.vmethod_2());
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (FormEncode);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Recording Encoder";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual ProgressBar vmethod_0() => this.progressBar_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ProgressBar progressBar_1) => this.progressBar_0 = progressBar_1;

  internal virtual Label vmethod_2() => this.label_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(Label label_1) => this.label_0 = label_1;

  internal virtual Button vmethod_4() => this.button_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_5(Button button_1)
  {
    EventHandler eventHandler = new EventHandler(this.method_4);
    if (this.button_0 != null)
      this.button_0.Click -= eventHandler;
    this.button_0 = button_1;
    if (this.button_0 == null)
      return;
    this.button_0.Click += eventHandler;
  }

  private void method_0()
  {
    try
    {
      if (Operators.CompareString(this.string_0, "0x90", false) == 0)
        this.Close();
      GifEncoder gifEncoder = new GifEncoder();
      gifEncoder.Start(this.string_0);
      gifEncoder.SetRepeat(0);
      int int0 = this.int_0;
      for (int int_2 = 1; int_2 <= int0 && !this.bool_0; ++int_2)
      {
        this.method_1((int) Math.Round(int_2 == this.int_0 ? 100.0 : (double) (int_2 * 100) / (double) this.int_0), int_2);
        gifEncoder.AddFrame((Image) Octree.QuantizeImage((Bitmap) this.method_3(Image.FromFile(string.Format("{0}\\{1}.jpg", (object) this.string_1, (object) int_2)), 1152, 648), 256));
      }
      gifEncoder.Finish();
      foreach (string file in Directory.GetFiles(this.string_1))
        File.Delete(file);
      if (!this.bool_0)
      {
        int num;
        this.Invoke((Delegate) (() => num = (int) MessageBox.Show("Encoding Complete!", "Imminent Monitor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)));
        this.Invoke((Delegate) (() => this.Close()));
      }
      else
        this.Invoke((Delegate) (() => this.Close()));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  private void method_1(int int_1, int int_2)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new FormEncode.Delegate20(this.method_1), (object) int_1, (object) int_2);
    }
    else
    {
      this.vmethod_2().Text = string.Format("Encoding Frame {0} / {1}", (object) int_2, (object) this.int_0);
      this.vmethod_0().Value = int_1;
    }
  }

  public string method_2()
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "Graphics Interchange Format|*.gif";
    return saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : "0x90";
  }

  private Image method_3(Image image_0, int int_1, int int_2)
  {
    int width1 = image_0.Width;
    int height1 = image_0.Height;
    int x1 = 0;
    int y1 = 0;
    int x2 = 0;
    int y2 = 0;
    float num1 = (float) int_1 / (float) width1;
    float num2 = (float) int_2 / (float) height1;
    float num3;
    if ((double) num2 < (double) num1)
    {
      num3 = num2;
      x2 = (int) Convert.ToInt16((float) (((double) int_1 - (double) width1 * (double) num3) / 2.0));
    }
    else
    {
      num3 = num1;
      y2 = (int) Convert.ToInt16((float) (((double) int_2 - (double) height1 * (double) num3) / 2.0));
    }
    int width2 = (int) Math.Round((double) ((float) width1 * num3));
    int height2 = (int) Math.Round((double) ((float) height1 * num3));
    Bitmap bitmap = new Bitmap(int_1, int_2, PixelFormat.Format32bppArgb);
    bitmap.SetResolution(image_0.HorizontalResolution, image_0.VerticalResolution);
    Graphics graphics = Graphics.FromImage((Image) bitmap);
    graphics.Clear(Color.Black);
    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
    graphics.DrawImage(image_0, new Rectangle(x2, y2, width2, height2), new Rectangle(x1, y1, width1, height1), GraphicsUnit.Pixel);
    graphics.Dispose();
    return (Image) bitmap;
  }

  private void FormEncode_Load(object sender, EventArgs e) => new Thread(new ThreadStart(this.method_0)).Start();

  private void method_4(object sender, EventArgs e)
  {
    this.bool_0 = true;
    this.Close();
  }

  private delegate void Delegate20(int int_0, int int_1);
}
