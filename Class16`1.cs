// Decompiled with JetBrains decompiler
// Type: Class16`1
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

internal sealed class Class16<T> : IEnumerable<T>, IEnumerable, ICollection
{
  private T[] gparam_0;
  private int int_0;
  private int int_1;
  private object object_0;

  public Class16()
  {
    this.gparam_0 = Class77<T>.gparam_0;
    this.int_0 = 0;
    this.int_1 = 0;
  }

  public Class16(int int_2)
  {
    this.gparam_0 = int_2 >= 0 ? new T[int_2] : throw new ArgumentOutOfRangeException();
    this.int_0 = 0;
    this.int_1 = 0;
  }

  public Class16(IEnumerable<T> ienumerable_0)
  {
    if (ienumerable_0 == null)
      throw new ArgumentNullException();
    if (ienumerable_0 is ICollection<T> objs)
    {
      int count = objs.Count;
      this.gparam_0 = new T[count];
      objs.CopyTo(this.gparam_0, 0);
      this.int_0 = count;
    }
    else
    {
      this.int_0 = 0;
      this.gparam_0 = new T[4];
      foreach (T gparam_1 in ienumerable_0)
        this.method_7(gparam_1);
    }
  }

  public int Count => this.int_0;

  bool ICollection.get_IsSynchronized() => false;

  object ICollection.get_SyncRoot()
  {
    if (this.object_0 == null)
      Interlocked.CompareExchange(ref this.object_0, new object(), (object) null);
    return this.object_0;
  }

  public void method_0()
  {
    Array.Clear((Array) this.gparam_0, 0, this.int_0);
    this.int_0 = 0;
    ++this.int_1;
  }

  public bool method_1(T gparam_1)
  {
    int int0 = this.int_0;
    EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
    while (int0-- > 0)
    {
      if ((object) gparam_1 == null)
      {
        if ((object) this.gparam_0[int0] == null)
          return true;
      }
      else if ((object) this.gparam_0[int0] != null && equalityComparer.Equals(this.gparam_0[int0], gparam_1))
        return true;
    }
    return false;
  }

  public void method_2(T[] gparam_1, int int_2)
  {
    if (gparam_1 == null)
      throw new ArgumentNullException("#=zHyRTQY0=");
    if (int_2 < 0 || int_2 > gparam_1.Length)
      throw new ArgumentOutOfRangeException("#=z_UPiyhU=", "arrayIndex < 0 || arrayIndex > array.Length");
    if (gparam_1.Length - int_2 < this.int_0)
      throw new ArgumentException("Invalid Off Len");
    Array.Copy((Array) this.gparam_0, 0, (Array) gparam_1, int_2, this.int_0);
    Array.Reverse((Array) gparam_1, int_2, this.int_0);
  }

  void ICollection.CopyTo(Array array, int index)
  {
    if (array == null)
      throw new ArgumentNullException();
    if (array.Rank != 1)
      throw new ArgumentException();
    if (array.GetLowerBound(0) != 0)
      throw new ArgumentException();
    if (index < 0 || index > array.Length)
      throw new ArgumentOutOfRangeException();
    if (array.Length - index < this.int_0)
      throw new ArgumentException();
    try
    {
      Array.Copy((Array) this.gparam_0, 0, array, index, this.int_0);
      Array.Reverse(array, index, this.int_0);
    }
    catch (ArrayTypeMismatchException ex)
    {
      throw new ArgumentException();
    }
  }

  public Class16<T>.Struct1 method_3() => new Class16<T>.Struct1(this);

  IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>) new Class16<T>.Struct1(this);

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new Class16<T>.Struct1(this);

  public void method_4()
  {
    if (this.int_0 >= (int) ((double) this.gparam_0.Length * 0.9))
      return;
    T[] destinationArray = new T[this.int_0];
    Array.Copy((Array) this.gparam_0, 0, (Array) destinationArray, 0, this.int_0);
    this.gparam_0 = destinationArray;
    ++this.int_1;
  }

  public T method_5() => this.int_0 != 0 ? this.gparam_0[this.int_0 - 1] : throw new InvalidOperationException();

  public T method_6()
  {
    if (this.int_0 == 0)
      throw new InvalidOperationException();
    ++this.int_1;
    T obj = this.gparam_0[--this.int_0];
    this.gparam_0[this.int_0] = default (T);
    return obj;
  }

  public void method_7(T gparam_1)
  {
    if (this.int_0 == this.gparam_0.Length)
    {
      T[] destinationArray = new T[this.gparam_0.Length == 0 ? 4 : 2 * this.gparam_0.Length];
      Array.Copy((Array) this.gparam_0, 0, (Array) destinationArray, 0, this.int_0);
      this.gparam_0 = destinationArray;
    }
    this.gparam_0[this.int_0++] = gparam_1;
    ++this.int_1;
  }

  public T[] method_8()
  {
    T[] objArray = new T[this.int_0];
    for (int index = 0; index < this.int_0; ++index)
      objArray[index] = this.gparam_0[this.int_0 - index - 1];
    return objArray;
  }

  public T Current
  {
    [SpecialName] get
    {
      if (this.int_0 == -2)
        throw new InvalidOperationException();
      if (this.int_0 == -1)
        throw new InvalidOperationException();
      return this.gparam_0;
    }
  }

  public virtual bool CanRead
  {
    [SpecialName] get => this.method_0().CanRead;
  }

  public struct Struct1 : IEnumerator<T>, IDisposable, IEnumerator
  {
    private Class16<T> class16_0;
    private int int_0;
    private int int_1;
    private T gparam_0;

    internal Struct1(Class16<T> class16_1)
    {
      this.class16_0 = class16_1;
      this.int_1 = this.class16_0.int_1;
      this.int_0 = -2;
      this.gparam_0 = default (T);
    }

    public void Dispose() => this.int_0 = -1;

    public bool MoveNext()
    {
      if (this.int_1 != this.class16_0.int_1)
        throw new InvalidOperationException("EnumFailedVersion");
      if (this.int_0 == -2)
      {
        this.int_0 = this.class16_0.int_0 - 1;
        int num = this.int_0 >= 0 ? 1 : 0;
        if (num == 0)
          return num != 0;
        this.gparam_0 = this.class16_0.gparam_0[this.int_0];
        return num != 0;
      }
      if (this.int_0 == -1)
        return false;
      int num1 = --this.int_0 >= 0 ? 1 : 0;
      if (num1 != 0)
      {
        this.gparam_0 = this.class16_0.gparam_0[this.int_0];
        return num1 != 0;
      }
      this.gparam_0 = default (T);
      return num1 != 0;
    }

    [SpecialName]
    public T get_Current()
    {
      if (this.int_0 == -2)
        throw new InvalidOperationException();
      if (this.int_0 == -1)
        throw new InvalidOperationException();
      return this.gparam_0;
    }

    object IEnumerator.get_Current()
    {
      if (this.int_0 == -2)
        throw new InvalidOperationException();
      if (this.int_0 == -1)
        throw new InvalidOperationException();
      return (object) this.gparam_0;
    }

    void IEnumerator.Reset()
    {
      if (this.int_1 != this.class16_0.int_1)
        throw new InvalidOperationException();
      this.int_0 = -2;
      this.gparam_0 = default (T);
    }

    public virtual bool CanSeek
    {
      [SpecialName] get => this.method_0().CanSeek;
    }

    public virtual bool CanWrite
    {
      [SpecialName] get => this.method_0().CanWrite;
    }
  }
}
