// Decompiled with JetBrains decompiler
// Type: GClass29
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Drawing;
using System.Windows.Forms;

public sealed class GClass29 : Panel
{
  private string string_0;
  public RichTextBox richTextBox_0;

  public GClass29()
  {
    this.richTextBox_0 = new RichTextBox();
    this.richTextBox_0.BorderStyle = BorderStyle.None;
    this.richTextBox_0.Height = this.Height - 2;
    this.richTextBox_0.Width = this.Width - 2;
    this.richTextBox_0.Location = new Point(1, 1);
    this.richTextBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.BackColor = Color.FromArgb(171, 173, 179);
    this.Controls.Add((Control) this.richTextBox_0);
  }

  public string method_0() => this.string_0;

  public void method_1(string string_1)
  {
    this.richTextBox_0.Text = string_1;
    this.string_0 = string_1;
  }
}
