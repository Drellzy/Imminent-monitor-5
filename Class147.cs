// Decompiled with JetBrains decompiler
// Type: Class147
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[StandardModule]
internal sealed class Class147
{
  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  private static extern int SendMessage(
    IntPtr intptr_0,
    int int_0,
    IntPtr intptr_1,
    IntPtr intptr_2);

  public static void smethod_0(RichTextBox richTextBox_0) => Class147.SendMessage(richTextBox_0.Handle, 277, (IntPtr) 7, IntPtr.Zero);

  public static void smethod_1(this RichTextBox richTextBox_0, string string_0, Font font_0)
  {
    richTextBox_0.SelectionStart = richTextBox_0.TextLength;
    richTextBox_0.SelectionLength = 0;
    richTextBox_0.SelectionFont = font_0;
    richTextBox_0.AppendText(string_0);
    richTextBox_0.SelectionFont = richTextBox_0.Font;
  }

  public static void smethod_2(this RichTextBox richTextBox_0, string string_0, Color color_0)
  {
    richTextBox_0.SelectionStart = richTextBox_0.TextLength;
    richTextBox_0.SelectionLength = 0;
    richTextBox_0.SelectionColor = color_0;
    richTextBox_0.AppendText(string_0);
    richTextBox_0.SelectionColor = richTextBox_0.ForeColor;
    richTextBox_0.SelectionFont = richTextBox_0.Font;
  }
}
