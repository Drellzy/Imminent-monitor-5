// Decompiled with JetBrains decompiler
// Type: UserControlServerLogs
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using FastColoredTextBoxNS;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlServerLogs : UserControl
{
  private IContainer icontainer_0;
  public FastColoredTextBox TextBoxLogs;

  public UserControlServerLogs() => this.InitializeComponent();

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlServerLogs));
    this.TextBoxLogs = new FastColoredTextBox();
    ((ISupportInitialize) this.TextBoxLogs).BeginInit();
    this.SuspendLayout();
    ((Control) this.TextBoxLogs).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.TextBoxLogs.AutoCompleteBracketsList = new char[10]
    {
      '(',
      ')',
      '{',
      '}',
      '[',
      ']',
      '"',
      '"',
      '\'',
      '\''
    };
    this.TextBoxLogs.AutoIndentCharsPatterns = string.Empty;
    FastColoredTextBox textBoxLogs1 = this.TextBoxLogs;
    Size size1 = new Size(0, 15);
    Size size2 = size1;
    textBoxLogs1.AutoScrollMinSize = size2;
    this.TextBoxLogs.BackBrush = (Brush) null;
    ((UserControl) this.TextBoxLogs).BorderStyle = BorderStyle.FixedSingle;
    this.TextBoxLogs.CharHeight = 15;
    this.TextBoxLogs.CharWidth = 7;
    this.TextBoxLogs.Cursor = Cursors.IBeam;
    this.TextBoxLogs.DisabledColor = Color.FromArgb(100, 180, 180, 180);
    this.TextBoxLogs.Font = new Font("Consolas", 9.75f);
    this.TextBoxLogs.IsReplaceMode = false;
    ((Control) this.TextBoxLogs).Location = new Point(3, 3);
    ((Control) this.TextBoxLogs).Name = "TextBoxLogs";
    this.TextBoxLogs.Paddings = new Padding(0);
    this.TextBoxLogs.ReadOnly = true;
    this.TextBoxLogs.SelectionColor = Color.FromArgb(50, 0, 0, (int) byte.MaxValue);
    this.TextBoxLogs.ServiceColors = (ServiceColors) componentResourceManager.GetObject("TextBoxLogs.ServiceColors");
    this.TextBoxLogs.ShowLineNumbers = false;
    FastColoredTextBox textBoxLogs2 = this.TextBoxLogs;
    size1 = new Size(726, 458);
    Size size3 = size1;
    ((Control) textBoxLogs2).Size = size3;
    ((Control) this.TextBoxLogs).TabIndex = 5;
    this.TextBoxLogs.WordWrap = true;
    this.TextBoxLogs.Zoom = 100;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(241, 244, 245);
    this.Controls.Add((Control) this.TextBoxLogs);
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlServerLogs);
    size1 = new Size(732, 464);
    this.Size = size1;
    ((ISupportInitialize) this.TextBoxLogs).EndInit();
    this.ResumeLayout(false);
  }

  public void method_0(string string_0, Style style_0)
  {
    this.TextBoxLogs.BeginUpdate();
    this.TextBoxLogs.Selection.BeginUpdate();
    Range range = this.TextBoxLogs.Selection.Clone();
    Range selection = this.TextBoxLogs.Selection;
    Place place1;
    if (this.TextBoxLogs.LinesCount <= 0)
    {
      Place place2;
      // ISSUE: explicit constructor call
      ((Place) ref place2).\u002Ector(0, 0);
      place1 = place2;
    }
    else
    {
      Place place3;
      // ISSUE: explicit constructor call
      ((Place) ref place3).\u002Ector(this.TextBoxLogs[this.TextBoxLogs.LinesCount - 1].Count, this.TextBoxLogs.LinesCount - 1);
      place1 = place3;
    }
    selection.Start = place1;
    this.TextBoxLogs.InsertText(string_0, style_0);
    if (range.IsEmpty && range.Start.iLine <= this.TextBoxLogs.LinesCount - 2)
    {
      this.TextBoxLogs.DoCaretVisible();
    }
    else
    {
      this.TextBoxLogs.Selection.Start = range.Start;
      this.TextBoxLogs.Selection.End = range.End;
    }
    this.TextBoxLogs.Selection.EndUpdate();
    this.TextBoxLogs.EndUpdate();
  }
}
