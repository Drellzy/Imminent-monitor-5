// Decompiled with JetBrains decompiler
// Type: Class97
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using CefSharp.WinForms;
using FastColoredTextBoxNS;
using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security.AntiXss;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

[StandardModule]
internal sealed class Class97
{
  public static bool bool_0 = true;
  public static GClass1 gclass1_0;
  public static FormToast[] formToast_0 = new FormToast[6];
  public static GClass45 gclass45_0;
  public static GeneralSettings generalSettings_0 = new GeneralSettings();
  public static FormMain formMain_0;
  public static FormBuildLog formBuildLog_0;
  public static bool bool_1;
  public static Size size_0 = new Size(0, 0);
  public static string string_0;
  public static float float_0 = 0.0f;
  public static GClass2 gclass2_0;
  public static List<GClass18> list_0 = new List<GClass18>();
  public static List<GClass30> list_1 = new List<GClass30>();
  public static GClass21 gclass21_0;
  public static GClass39 gclass39_0;
  public static bool bool_2 = false;
  private static GClass15 gclass15_0;
  public static byte[] byte_0;
  public static string string_1;
  public static string string_2;
  public static string string_3;
  public static int int_0;
  public static int int_1;
  public static int int_2;
  public static int int_3;

  static Class97()
  {
    Class97.smethod_1(new GClass15());
    Class97.byte_0 = new byte[20]
    {
      (byte) 1,
      (byte) 2,
      (byte) 1,
      (byte) 5,
      (byte) 6,
      (byte) 7,
      (byte) 90,
      (byte) 90,
      (byte) 90,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      (byte) 13,
      (byte) 33,
      (byte) 7,
      (byte) 6,
      (byte) 6,
      (byte) 6,
      (byte) 66,
      (byte) 21
    };
    Class97.int_0 = 274;
    Class97.int_1 = 0;
    Class97.int_2 = 2048;
    Class97.int_3 = 1;
  }

  [DllImport("user32.dll")]
  public static extern int SendMessage(IntPtr intptr_0, int int_4, int int_5, int int_6);

  [DllImport("user32.dll")]
  public static extern bool ReleaseCapture();

  public static GClass15 smethod_0() => Class97.gclass15_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public static void smethod_1(GClass15 gclass15_1)
  {
    GClass15.GDelegate4 gdelegate4_1 = new GClass15.GDelegate4(Class97.smethod_23);
    if (Class97.gclass15_0 != null)
      Class97.gclass15_0.method_1(gdelegate4_1);
    Class97.gclass15_0 = gclass15_1;
    if (Class97.gclass15_0 == null)
      return;
    Class97.gclass15_0.method_0(gdelegate4_1);
  }

  public static Image smethod_2(string string_4, string string_5)
  {
    string str = string.Format("{0}\\Resources\\Images\\{1}\\{2}.png", (object) Application.StartupPath, (object) string_4, (object) string_5);
    return File.Exists(str) ? Image.FromFile(str) : (Image) null;
  }

  public static Image smethod_3(string string_4) => Class97.smethod_2("TabIcons", string_4);

  public static Image smethod_4(string string_4)
  {
    Image image;
    try
    {
      string_4 = string_4.ToLower();
      image = !File.Exists(string.Format("{0}\\Resources\\Images\\Buttons\\Main Form\\{1}.png", (object) Application.StartupPath, (object) string_4)) ? (Image) null : Image.FromFile(string.Format("{0}\\Resources\\Images\\Buttons\\Main Form\\{1}.png", (object) Application.StartupPath, (object) string_4));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      image = (Image) null;
      ProjectData.ClearProjectError();
    }
    return image;
  }

  public static Image smethod_5(string string_4) => Class97.smethod_2("ContextMenu\\Main", string_4.Replace(' ', '-').ToLower());

  public static Image smethod_6(string string_4, string string_5)
  {
    string_4 = string_4.Replace(' ', '-').ToLower() + ".png";
    foreach (string file in Directory.GetFiles(string_5))
    {
      if (Operators.CompareString(new FileInfo(file).Name, string_4, false) == 0)
        return Image.FromFile(file);
    }
    return (Image) new Bitmap(16, 16);
  }

  public static void smethod_7(ContextMenuStrip contextMenuStrip_0)
  {
label_0:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = 1;
label_1:
      int num3 = 2;
      List<ToolStripMenuItem> list_2 = new List<ToolStripMenuItem>();
label_2:
      num3 = 3;
      IEnumerator enumerator1 = contextMenuStrip_0.Items.GetEnumerator();
label_3:
      ToolStripItem current1;
      if (enumerator1.MoveNext())
        current1 = (ToolStripItem) enumerator1.Current;
      else if (enumerator1 is IDisposable)
      {
        (enumerator1 as IDisposable).Dispose();
        goto label_10;
      }
      else
        goto label_10;
label_5:
      num3 = 4;
      if (current1.Tag.ToString().Contains("SEPERATOR"))
        goto label_7;
label_6:
      num3 = 5;
      Class97.smethod_13((ToolStripMenuItem) current1, ref list_2);
label_7:
      num3 = 7;
      goto label_3;
label_10:
      num3 = 8;
      List<ToolStripMenuItem>.Enumerator enumerator2 = list_2.GetEnumerator();
      goto label_14;
label_12:
      num3 = 9;
      ToolStripMenuItem current2;
      current2.Image = Class97.smethod_6(current2.Text, Application.StartupPath + "\\Resources\\Images\\ContextMenu\\System Managers");
label_13:
      num3 = 10;
label_14:
      if (enumerator2.MoveNext())
      {
        current2 = enumerator2.Current;
        goto label_12;
      }
      else
      {
        enumerator2.Dispose();
        goto label_22;
      }
label_17:
      num2 = num3;
      switch (num1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_0;
            case 2:
              goto label_1;
            case 3:
              goto label_2;
            case 4:
              goto label_5;
            case 5:
              goto label_6;
            case 6:
            case 7:
              goto label_7;
            case 8:
              goto label_10;
            case 9:
              goto label_12;
            case 10:
              goto label_13;
            case 11:
              goto label_22;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_17;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_22:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  public static string smethod_8(string string_4) => string.Format("{0}\\Resources\\{1}", (object) Application.StartupPath, (object) string_4);

  [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
  private static extern int SendMessage_1(IntPtr intptr_0, int int_4, int int_5, [MarshalAs(UnmanagedType.LPWStr)] string string_4);

  public static void smethod_9(ref List<TextBox> list_2, List<string> list_3)
  {
    int num = list_2.Count - 1;
    for (int index = 0; index <= num; ++index)
      Class97.SendMessage_1(list_2[index].Handle, 5377, 1, list_3[index]);
  }

  public static void smethod_10(TextBox textBox_0, string string_4) => Class97.SendMessage_1(textBox_0.Handle, 5377, 1, string_4);

  public static void smethod_11(Form form_0)
  {
    float ratio = 1f;
    if ((double) Class97.float_0 > 96.0)
      ratio = Class97.float_0 / 96f;
    if (!(form_0.AutoScaleDimensions == form_0.CurrentAutoScaleDimensions))
      return;
    form_0.Scale(ratio);
  }

  public static void smethod_12(UserControl userControl_0)
  {
    float ratio = 1f;
    if ((double) Class97.float_0 > 96.0)
      ratio = Class97.float_0 / 96f;
    if (!(userControl_0.AutoScaleDimensions == userControl_0.CurrentAutoScaleDimensions))
      return;
    userControl_0.Scale(ratio);
  }

  public static void smethod_13(
    ToolStripMenuItem toolStripMenuItem_0,
    ref List<ToolStripMenuItem> list_2)
  {
    list_2.Add(toolStripMenuItem_0);
    try
    {
      foreach (ToolStripItem dropDownItem in (ArrangedElementCollection) toolStripMenuItem_0.DropDownItems)
      {
        if (dropDownItem is ToolStripMenuItem)
          Class97.smethod_13((ToolStripMenuItem) dropDownItem, ref list_2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static int smethod_14(ListView listView_0, string string_4)
  {
    int num = listView_0.Groups.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Operators.CompareString(listView_0.Groups[index].Header, string_4, false) == 0)
        return index;
    }
    return 0;
  }

  public static void smethod_15(ContextMenuStrip contextMenuStrip_0) => contextMenuStrip_0.Renderer = (ToolStripRenderer) new GClass19((GEnum1) 0);

  public static void smethod_16(MenuStrip menuStrip_0) => menuStrip_0.Renderer = (ToolStripRenderer) new GClass19((GEnum1) 0);

  public static Bitmap smethod_17(Bitmap bitmap_0)
  {
    Bitmap bitmap1;
    try
    {
      Bitmap bitmap2 = new Bitmap(bitmap_0.Width + 8, bitmap_0.Height + 8);
      Graphics graphics = Graphics.FromImage((Image) bitmap2);
      graphics.DrawImage((Image) bitmap_0, 3, 5);
      bitmap_0.Dispose();
      graphics.Dispose();
      bitmap1 = bitmap2;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      bitmap1 = bitmap_0;
      ProjectData.ClearProjectError();
    }
    return bitmap1;
  }

  public static Image smethod_18(byte[] byte_1)
  {
    Image image;
    try
    {
      using (MemoryStream memoryStream = new MemoryStream(byte_1))
        image = Image.FromStream((Stream) memoryStream);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      image = (Image) SystemIcons.Error.ToBitmap();
      ProjectData.ClearProjectError();
    }
    return image;
  }

  public static void smethod_19(
    string string_4,
    string string_5,
    string string_6,
    string string_7,
    byte[] byte_1,
    bool bool_3,
    string string_8)
  {
    if (!Directory.Exists(string_5))
      Directory.CreateDirectory(string_5);
    if (!Directory.Exists(Application.StartupPath + "\\" + string_5 + "\\\\" + string_4 + "\\" + string_6 + "\\"))
      Directory.CreateDirectory(Application.StartupPath + "\\" + string_5 + "\\" + string_4 + "\\" + string_6 + "\\");
    if (!bool_3)
      File.WriteAllBytes(Application.StartupPath + "\\" + string_5 + "\\" + string_4 + "\\" + string_6 + "\\" + string_7, byte_1);
    else
      File.WriteAllText(Application.StartupPath + "\\" + string_5 + "\\\\" + string_4 + "\\" + string_6 + "\\" + string_7, string_8);
  }

  public static void smethod_20(ChromiumWebBrowser chromiumWebBrowser_0, string string_4) => chromiumWebBrowser_0?.GetBrowser().MainFrame.ExecuteJavaScriptAsync(string_4, "about:blank", 1);

  public static string smethod_21(string string_4) => AntiXssEncoder.HtmlEncode(string_4, true);

  public static bool smethod_22(string string_4, string string_5)
  {
    int num = new Version(string_4).CompareTo(new Version(string_5));
    return num > 0 || num >= 0;
  }

  public static void smethod_23(Exception exception_0, string string_4)
  {
    if (Operators.CompareString(string_4, (string) null, false) == 0)
      Class97.gclass2_0.method_0("[Exception] " + exception_0.Message + exception_0.StackTrace + "\r\n\r\n", Class97.gclass2_0.textStyle_3);
    else
      Class97.gclass2_0.method_0("[Exception] Exception from: " + string_4 + " Details: " + exception_0.Message + exception_0.StackTrace + "\r\n\r\n", Class97.gclass2_0.textStyle_3);
    if (exception_0.InnerException != null)
    {
      string str = exception_0.InnerException.Message + exception_0.StackTrace;
      int num = (int) new FormException("[Exception] " + exception_0.Message + exception_0.StackTrace + "\r\n\r\n\r\n" + str).ShowDialog();
    }
    else
    {
      int num1 = (int) new FormException("[Exception] " + exception_0.Message + exception_0.StackTrace + "\r\n\r\n").ShowDialog();
    }
    Class97.smethod_24(exception_0.GetType().ToString(), exception_0.StackTrace);
  }

  public static void smethod_24(string string_4, string string_5)
  {
    if (!Class97.generalSettings_0.AnonymousErrorReporting)
      return;
    Class97.gclass1_0.method_29(string_4, string_5);
  }

  public static string smethod_25(string string_4)
  {
    object[] object_3 = new object[1]{ (object) string_4 };
    return (string) Class86.smethod_0().method_270(Class86.smethod_1(), "hbfQ#Pa.Q$", object_3);
  }

  public static string smethod_26(string string_4)
  {
    object[] object_3 = new object[1]{ (object) string_4 };
    return (string) Class86.smethod_0().method_270(Class86.smethod_1(), ",JoV-Pa.Q$", object_3);
  }

  public static void smethod_27(string string_4, ushort ushort_0, string string_5)
  {
    Class97.string_1 = string_4;
    Class97.string_2 = Conversions.ToString((uint) ushort_0);
    Class97.string_3 = string_5;
    if (Class97.gclass39_0 != null)
    {
      Class97.gclass39_0.method_0();
      Class97.gclass39_0 = (GClass39) null;
    }
    Class97.gclass39_0 = new GClass39(Class97.string_1, Conversions.ToUShort(Class97.string_2), Class97.string_3);
  }

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern IntPtr GetSystemMenu(IntPtr intptr_0, bool bool_3);

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern bool AppendMenu(IntPtr intptr_0, int int_4, int int_5, string string_4);

  public static void smethod_28(Form form_0)
  {
    IntPtr systemMenu = Class97.GetSystemMenu(form_0.Handle, false);
    Class97.AppendMenu(systemMenu, Class97.int_2, 0, string.Empty);
    Class97.AppendMenu(systemMenu, Class97.int_1, Class97.int_3, "&Chromium Developer Tools");
  }

  public static Image smethod_29(string string_4)
  {
    byte[] buffer = Convert.FromBase64String(string_4);
    MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length);
    memoryStream.Write(buffer, 0, buffer.Length);
    return Image.FromStream((Stream) memoryStream, true);
  }

  public static double smethod_30() => (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;

  public static string smethod_31(string string_4)
  {
    using (MD5 md5 = MD5.Create())
      return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(string_4))).Replace("-", string.Empty).ToLower();
  }

  public delegate void Delegate4(string string_0);

  public delegate void Delegate5(GClass18 gclass18_0, Bitmap bitmap_0);

  public delegate void Delegate6(GClass18 gclass18_0);

  public delegate void Delegate7(UserControlThumbnail userControlThumbnail_0, Bitmap bitmap_0);

  public delegate void Delegate8(GClass18 gclass18_0);

  public delegate void Delegate9(object[] object_0);

  public delegate void Delegate10(object[] object_0);

  public delegate void Delegate11(GClass18 gclass18_0);

  public delegate void Delegate12(string string_0);

  public delegate void Delegate13(object[] object_0);

  public delegate void Delegate14(object[] object_0);

  public delegate void Delegate15(GClass18 gclass18_0, string string_0);

  public delegate void Delegate16(object[] object_0);

  public delegate void Delegate17(string string_0, TextStyle textStyle_0);
}
