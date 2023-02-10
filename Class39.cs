// Decompiled with JetBrains decompiler
// Type: Class39
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

internal sealed class Class39
{
  private readonly Class35 class35_0;
  private readonly Dictionary<Class39.Struct3, Class39.Delegate2> dictionary_0;
  private Class45[] class45_0;
  private readonly Class16<Class45> class16_0;
  private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();
  private static Type type_0;
  private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();
  private bool bool_0;
  private readonly Dictionary<MethodBase, int> dictionary_3;
  private static Type type_1;
  private BinaryReader binaryReader_0;
  private object[] object_0;
  private bool bool_1;
  private Class45[] class45_1;
  private static Type type_2;
  private Class14 class14_0;
  private readonly Module module_0;
  private object object_1;
  private long long_0;
  private Type type_3;
  private static Type type_4;
  private Class38 class38_0;
  private Class34[] class34_0;
  private byte[] byte_0;
  private Stream stream_0;
  private static object object_2 = new object();
  private static Type type_5;
  private uint? nullable_0;
  private static Type type_6;
  private readonly Class16<Class39.Struct5> class16_1;
  private Type[] type_7;
  private Dictionary<MethodBase, object> dictionary_4;
  private Type[] type_8;
  private Dictionary<int, Class39.Class43> dictionary_5;

  public Class39(Class35 class35_1, Module module_1)
  {
    this.class16_1 = new Class16<Class39.Struct5>();
    this.class16_0 = new Class16<Class45>();
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.class35_0 = class35_1;
    this.module_0 = module_1;
    this.method_23();
  }

  public Class39(Class35 class35_1)
    : this(class35_1, typeof (Class39).Module)
  {
  }

  static Class39()
  {
    Class39.type_0 = typeof (void);
    Class39.type_5 = typeof (object[]);
    Class39.type_1 = typeof (IntPtr);
    Class39.type_2 = typeof (Assembly);
    Class39.type_6 = typeof (MethodBase);
    Class39.type_4 = typeof (RuntimeHelpers);
  }

  private void method_0(Class45 class45_2) => throw new NotSupportedException("Refanytype is not supported.");

  private void method_1(Class45 class45_2) => this.method_238();

  private void method_2(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    ushort int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = checked ((ushort) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = checked ((ushort) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = checked ((ushort) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = checked ((ushort) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3((int) int_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_3(Class45 class45_2)
  {
    Type t = this.method_257(((Class46) class45_2).method_2(), true);
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(Marshal.SizeOf(t));
    this.method_176((Class45) class45_2_1);
  }

  private void method_4(Class45 class45_2, Class45 class45_3)
  {
    switch (class45_2.vmethod_2())
    {
      case 6:
        ((Class53) class45_2).method_2().vmethod_3(class45_3);
        break;
      case 12:
        Class55 class55 = (Class55) class45_2;
        FieldInfo fieldInfo = class55.method_4();
        Class45 class45_1 = Class80.smethod_1(class45_3.vmethod_0(), fieldInfo.FieldType);
        fieldInfo.SetValue(class55.method_2(), class45_1.vmethod_0());
        break;
      case 17:
      case 21:
        Class56 class56 = (Class56) class45_2;
        Class45 class45_4 = Class80.smethod_1(class45_3.vmethod_0(), class56.method_2());
        class56.vmethod_7(class45_4.vmethod_0());
        break;
      case 19:
        this.class45_1[((Class54) class45_2).method_2()].vmethod_3(class45_3);
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  private void method_5(Class45 class45_2) => this.method_183(typeof (sbyte));

  private void method_6(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_69(this.method_10(), class45_3, false, false));
  }

  private static bool smethod_0(Class45 class45_2, Class45 class45_3)
  {
    bool flag;
    switch (class45_2.vmethod_2())
    {
      case 2:
        flag = class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null ? ((Class67) class45_2).method_2() != ((Class67) class45_3).method_2() : ((Class67) class45_2).method_2() != IntPtr.Zero;
        break;
      case 3:
        flag = (ulong) ((Class63) class45_2).method_2() > (ulong) ((Class63) class45_3).method_2();
        break;
      case 5:
        flag = class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null ? ((Class65) class45_2).method_2() != ((Class65) class45_3).method_2() : ((Class65) class45_2).method_2() != UIntPtr.Zero;
        break;
      case 7:
        flag = Convert.ToInt64((object) ((Class59) class45_2).method_2()) != (class45_3.vmethod_2() != 9 ? Convert.ToInt64((object) ((Class59) class45_3).method_2()) : (long) ((Class46) class45_3).method_2());
        break;
      case 9:
        flag = (uint) ((Class46) class45_2).method_2() > (uint) ((Class46) class45_3).method_2();
        break;
      case 16:
        double d1 = ((Class48) class45_2).method_2();
        double d2 = ((Class48) class45_3).method_2();
        flag = d1 > d2 || double.IsNaN(d1) || double.IsNaN(d2);
        break;
      case 20:
        flag = ((Class49) class45_2).method_2() != ((Class49) class45_3).method_2();
        break;
      case 24:
        flag = class45_3.vmethod_2() == 20 && class45_3.vmethod_0() == null || ((Class71) class45_2).method_2() != ((Class71) class45_3).method_2();
        break;
      default:
        flag = class45_2.vmethod_0() != class45_3.vmethod_0();
        break;
    }
    return flag;
  }

  private void method_7(Class45 class45_2) => this.method_238();

  private void method_8(Class45 class45_2)
  {
  }

  private void method_9(Class45 class45_2)
  {
    string string_1 = this.method_95(((Class46) class45_2).method_2());
    Class66 class45_2_1 = new Class66();
    class45_2_1.method_3(string_1);
    this.method_176((Class45) class45_2_1);
  }

  private Class45 method_10() => this.class16_0.method_6();

  private void method_11(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    double double_1;
    switch (class45.vmethod_2())
    {
      case 3:
        double_1 = (double) ((Class63) class45).method_2();
        break;
      case 7:
        double_1 = (double) Convert.ToUInt64((object) ((Class59) class45).method_2());
        break;
      case 9:
        double_1 = (double) ((Class46) class45).method_2();
        break;
      case 16:
        double_1 = ((Class48) class45).method_2();
        break;
      default:
        throw new InvalidOperationException();
    }
    Class48 class45_2_1 = new Class48();
    class45_2_1.method_3(double_1);
    this.method_176((Class45) class45_2_1);
  }

  private static BindingFlags smethod_1(bool bool_2)
  {
    BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
    return !bool_2 ? bindingFlags | BindingFlags.Instance : bindingFlags | BindingFlags.Static;
  }

  private void method_12(Class45 class45_2)
  {
    int int_0 = ((Class46) class45_2).method_2();
    Class33 class33 = this.method_169(int_0);
    object object_1;
    if (class33.method_0() == (byte) 1)
    {
      object_1 = this.method_141(class33.method_2());
    }
    else
    {
      switch (class33.method_4().vmethod_0())
      {
        case 1:
          object_1 = (object) this.method_229(int_0).FieldHandle;
          break;
        case 2:
          object_1 = (object) this.method_225(int_0).MethodHandle;
          break;
        case 4:
          object_1 = (object) this.method_257(int_0, true).TypeHandle;
          break;
        default:
          throw new InvalidOperationException();
      }
    }
    Class49 class45_2_1 = new Class49();
    class45_2_1.method_3(object_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_13(MemberInfo memberInfo_0)
  {
    if (!Class39.smethod_3() || this.class38_0.method_13())
      return;
    bool flag = false;
    Assembly assembly = typeof (SecurityCriticalAttribute).Assembly;
    for (MemberInfo memberInfo = memberInfo_0; (object) memberInfo != null; memberInfo = (MemberInfo) memberInfo.DeclaringType)
    {
      foreach (object customAttribute in memberInfo.GetCustomAttributes(false))
      {
        Type type = customAttribute.GetType();
        if ((object) type.Assembly == (object) assembly)
        {
          string fullName = type.FullName;
          if (!"System.Security.SecurityCriticalAttribute".Equals(fullName, StringComparison.Ordinal))
          {
            if ("System.Security.SecuritySafeCriticalAttribute".Equals(fullName, StringComparison.Ordinal))
              goto label_12;
          }
          else
          {
            flag = true;
            goto label_12;
          }
        }
      }
    }
label_12:
    if (!flag)
      return;
    if ((object) (memberInfo_0 as MethodBase) != null)
    {
      string string_1 = Class39.smethod_22((MethodBase) memberInfo_0);
      throw Class39.smethod_30(this.method_239(this.class38_0), string_1);
    }
    if ((object) (memberInfo_0 as FieldInfo) != null)
    {
      string string_1 = string.Format("{0}.{1}", (object) memberInfo_0.DeclaringType.FullName, (object) memberInfo_0.Name);
      throw Class39.smethod_5(this.method_239(this.class38_0), string_1);
    }
    string string_1_1 = (object) (memberInfo_0 as Type) != null ? ((Type) memberInfo_0).FullName : throw new SecurityException("A caller does not have the permissions required to access a resource.");
    throw Class39.smethod_7(this.method_239(this.class38_0), string_1_1);
  }

  private void method_14(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_67(this.method_10(), class45_3));
  }

  private static Class34 smethod_2(BinaryReader binaryReader_1)
  {
    Class34 class34 = new Class34();
    class34.method_3((int) binaryReader_1.ReadByte());
    class34.method_1(binaryReader_1.ReadInt32());
    class34.method_5(binaryReader_1.ReadUInt32());
    class34.method_7(binaryReader_1.ReadUInt32());
    class34.method_9(binaryReader_1.ReadUInt32());
    class34.method_11(binaryReader_1.ReadUInt32());
    return class34;
  }

  private void method_15(Class45 class45_2) => this.method_176(this.class45_1[(int) ((Class51) class45_2).method_2()].vmethod_4());

  private void method_16(Class45 class45_2) => this.method_238();

  private void method_17(Class45 class45_2) => this.method_183(Class20.type_0);

  private void method_18(Class45 class45_2) => this.method_183(typeof (uint));

  private void method_19(Class45 class45_2) => this.method_42(true);

  private bool method_20(
    MethodBase methodBase_0,
    object object_3,
    ref object object_4,
    object[] object_5)
  {
    if (!methodBase_0.IsStatic && methodBase_0.Name == "Address")
    {
      MethodInfo methodInfo = methodBase_0 as MethodInfo;
      if ((object) methodInfo != null)
      {
        Type returnType = methodInfo.ReturnType;
        if (returnType.IsByRef)
        {
          Type elementType = returnType.GetElementType();
          int length = object_5.Length;
          if (length >= 1 && object_5[0] is int)
          {
            int[] int_1 = new int[length];
            for (int index = 0; index < length; ++index)
              int_1[index] = (int) object_5[index];
            ref object local = ref object_4;
            Class57 class57 = new Class57();
            class57.method_5((Array) object_3);
            class57.method_7(int_1);
            class57.method_3(elementType);
            local = (object) class57;
            return true;
          }
        }
      }
    }
    return false;
  }

  private Dictionary<int, Class39.Class43> method_21() => new Dictionary<int, Class39.Class43>(256)
  {
    {
      this.class35_0.class17_137.method_0(),
      new Class39.Class43(this.class35_0.class17_137, new Class39.Delegate1(this.method_79))
    },
    {
      this.class35_0.class17_186.method_0(),
      new Class39.Class43(this.class35_0.class17_186, new Class39.Delegate1(this.method_212))
    },
    {
      this.class35_0.class17_205.method_0(),
      new Class39.Class43(this.class35_0.class17_205, new Class39.Delegate1(this.method_210))
    },
    {
      this.class35_0.class17_37.method_0(),
      new Class39.Class43(this.class35_0.class17_37, new Class39.Delegate1(this.method_148))
    },
    {
      this.class35_0.class17_123.method_0(),
      new Class39.Class43(this.class35_0.class17_123, new Class39.Delegate1(this.method_268))
    },
    {
      this.class35_0.class17_209.method_0(),
      new Class39.Class43(this.class35_0.class17_209, new Class39.Delegate1(this.method_34))
    },
    {
      this.class35_0.class17_155.method_0(),
      new Class39.Class43(this.class35_0.class17_155, new Class39.Delegate1(this.method_52))
    },
    {
      this.class35_0.class17_154.method_0(),
      new Class39.Class43(this.class35_0.class17_154, new Class39.Delegate1(this.method_54))
    },
    {
      this.class35_0.class17_47.method_0(),
      new Class39.Class43(this.class35_0.class17_47, new Class39.Delegate1(this.method_17))
    },
    {
      this.class35_0.class17_125.method_0(),
      new Class39.Class43(this.class35_0.class17_125, new Class39.Delegate1(this.method_171))
    },
    {
      this.class35_0.class17_152.method_0(),
      new Class39.Class43(this.class35_0.class17_152, new Class39.Delegate1(this.method_287))
    },
    {
      this.class35_0.class17_110.method_0(),
      new Class39.Class43(this.class35_0.class17_110, new Class39.Delegate1(this.method_75))
    },
    {
      this.class35_0.class17_65.method_0(),
      new Class39.Class43(this.class35_0.class17_65, new Class39.Delegate1(this.method_86))
    },
    {
      this.class35_0.class17_202.method_0(),
      new Class39.Class43(this.class35_0.class17_202, new Class39.Delegate1(this.method_27))
    },
    {
      this.class35_0.class17_59.method_0(),
      new Class39.Class43(this.class35_0.class17_59, new Class39.Delegate1(this.method_158))
    },
    {
      this.class35_0.class17_102.method_0(),
      new Class39.Class43(this.class35_0.class17_102, new Class39.Delegate1(this.method_144))
    },
    {
      this.class35_0.class17_178.method_0(),
      new Class39.Class43(this.class35_0.class17_178, new Class39.Delegate1(this.method_126))
    },
    {
      this.class35_0.class17_20.method_0(),
      new Class39.Class43(this.class35_0.class17_20, new Class39.Delegate1(this.method_46))
    },
    {
      this.class35_0.class17_180.method_0(),
      new Class39.Class43(this.class35_0.class17_180, new Class39.Delegate1(this.method_7))
    },
    {
      this.class35_0.class17_121.method_0(),
      new Class39.Class43(this.class35_0.class17_121, new Class39.Delegate1(this.method_63))
    },
    {
      this.class35_0.class17_81.method_0(),
      new Class39.Class43(this.class35_0.class17_81, new Class39.Delegate1(this.method_214))
    },
    {
      this.class35_0.class17_105.method_0(),
      new Class39.Class43(this.class35_0.class17_105, new Class39.Delegate1(this.method_264))
    },
    {
      this.class35_0.class17_72.method_0(),
      new Class39.Class43(this.class35_0.class17_72, new Class39.Delegate1(this.method_286))
    },
    {
      this.class35_0.class17_126.method_0(),
      new Class39.Class43(this.class35_0.class17_126, new Class39.Delegate1(this.method_256))
    },
    {
      this.class35_0.class17_54.method_0(),
      new Class39.Class43(this.class35_0.class17_54, new Class39.Delegate1(this.method_202))
    },
    {
      this.class35_0.class17_175.method_0(),
      new Class39.Class43(this.class35_0.class17_175, new Class39.Delegate1(this.method_259))
    },
    {
      this.class35_0.class17_183.method_0(),
      new Class39.Class43(this.class35_0.class17_107, new Class39.Delegate1(this.method_8))
    },
    {
      this.class35_0.class17_139.method_0(),
      new Class39.Class43(this.class35_0.class17_139, new Class39.Delegate1(this.method_147))
    },
    {
      this.class35_0.class17_4.method_0(),
      new Class39.Class43(this.class35_0.class17_4, new Class39.Delegate1(this.method_105))
    },
    {
      this.class35_0.class17_101.method_0(),
      new Class39.Class43(this.class35_0.class17_101, new Class39.Delegate1(this.method_175))
    },
    {
      this.class35_0.class17_158.method_0(),
      new Class39.Class43(this.class35_0.class17_158, new Class39.Delegate1(this.method_16))
    },
    {
      this.class35_0.class17_177.method_0(),
      new Class39.Class43(this.class35_0.class17_177, new Class39.Delegate1(this.method_94))
    },
    {
      this.class35_0.class17_43.method_0(),
      new Class39.Class43(this.class35_0.class17_43, new Class39.Delegate1(this.method_231))
    },
    {
      this.class35_0.class17_49.method_0(),
      new Class39.Class43(this.class35_0.class17_49, new Class39.Delegate1(this.method_78))
    },
    {
      this.class35_0.class17_75.method_0(),
      new Class39.Class43(this.class35_0.class17_75, new Class39.Delegate1(this.method_276))
    },
    {
      this.class35_0.class17_117.method_0(),
      new Class39.Class43(this.class35_0.class17_117, new Class39.Delegate1(this.method_283))
    },
    {
      this.class35_0.class17_119.method_0(),
      new Class39.Class43(this.class35_0.class17_119, new Class39.Delegate1(this.method_59))
    },
    {
      this.class35_0.class17_190.method_0(),
      new Class39.Class43(this.class35_0.class17_190, new Class39.Delegate1(this.method_196))
    },
    {
      this.class35_0.class17_143.method_0(),
      new Class39.Class43(this.class35_0.class17_143, new Class39.Delegate1(this.method_118))
    },
    {
      this.class35_0.class17_187.method_0(),
      new Class39.Class43(this.class35_0.class17_187, new Class39.Delegate1(this.method_236))
    },
    {
      this.class35_0.class17_96.method_0(),
      new Class39.Class43(this.class35_0.class17_96, new Class39.Delegate1(this.method_45))
    },
    {
      this.class35_0.class17_77.method_0(),
      new Class39.Class43(this.class35_0.class17_77, new Class39.Delegate1(this.method_128))
    },
    {
      this.class35_0.class17_128.method_0(),
      new Class39.Class43(this.class35_0.class17_128, new Class39.Delegate1(this.method_136))
    },
    {
      this.class35_0.class17_91.method_0(),
      new Class39.Class43(this.class35_0.class17_91, new Class39.Delegate1(this.method_273))
    },
    {
      this.class35_0.class17_184.method_0(),
      new Class39.Class43(this.class35_0.class17_184, new Class39.Delegate1(this.method_58))
    },
    {
      this.class35_0.class17_78.method_0(),
      new Class39.Class43(this.class35_0.class17_78, new Class39.Delegate1(this.method_85))
    },
    {
      this.class35_0.class17_195.method_0(),
      new Class39.Class43(this.class35_0.class17_195, new Class39.Delegate1(this.method_290))
    },
    {
      this.class35_0.class17_153.method_0(),
      new Class39.Class43(this.class35_0.class17_153, new Class39.Delegate1(this.method_149))
    },
    {
      this.class35_0.class17_68.method_0(),
      new Class39.Class43(this.class35_0.class17_68, new Class39.Delegate1(this.method_246))
    },
    {
      this.class35_0.class17_17.method_0(),
      new Class39.Class43(this.class35_0.class17_17, new Class39.Delegate1(this.method_200))
    },
    {
      this.class35_0.class17_87.method_0(),
      new Class39.Class43(this.class35_0.class17_87, new Class39.Delegate1(this.method_96))
    },
    {
      this.class35_0.class17_168.method_0(),
      new Class39.Class43(this.class35_0.class17_168, new Class39.Delegate1(this.method_62))
    },
    {
      this.class35_0.class17_32.method_0(),
      new Class39.Class43(this.class35_0.class17_32, new Class39.Delegate1(this.method_222))
    },
    {
      this.class35_0.class17_166.method_0(),
      new Class39.Class43(this.class35_0.class17_166, new Class39.Delegate1(this.method_115))
    },
    {
      this.class35_0.class17_69.method_0(),
      new Class39.Class43(this.class35_0.class17_69, new Class39.Delegate1(this.method_179))
    },
    {
      this.class35_0.class17_74.method_0(),
      new Class39.Class43(this.class35_0.class17_74, new Class39.Delegate1(this.method_182))
    },
    {
      this.class35_0.class17_50.method_0(),
      new Class39.Class43(this.class35_0.class17_50, new Class39.Delegate1(this.method_293))
    },
    {
      this.class35_0.class17_204.method_0(),
      new Class39.Class43(this.class35_0.class17_204, new Class39.Delegate1(this.method_1))
    },
    {
      this.class35_0.class17_141.method_0(),
      new Class39.Class43(this.class35_0.class17_141, new Class39.Delegate1(this.method_291))
    },
    {
      this.class35_0.class17_2.method_0(),
      new Class39.Class43(this.class35_0.class17_2, new Class39.Delegate1(this.method_241))
    },
    {
      this.class35_0.class17_170.method_0(),
      new Class39.Class43(this.class35_0.class17_170, new Class39.Delegate1(this.method_151))
    },
    {
      this.class35_0.class17_9.method_0(),
      new Class39.Class43(this.class35_0.class17_9, new Class39.Delegate1(this.method_73))
    },
    {
      this.class35_0.class17_76.method_0(),
      new Class39.Class43(this.class35_0.class17_76, new Class39.Delegate1(this.method_250))
    },
    {
      this.class35_0.class17_48.method_0(),
      new Class39.Class43(this.class35_0.class17_48, new Class39.Delegate1(this.method_279))
    },
    {
      this.class35_0.class17_199.method_0(),
      new Class39.Class43(this.class35_0.class17_199, new Class39.Delegate1(this.method_36))
    },
    {
      this.class35_0.class17_211.method_0(),
      new Class39.Class43(this.class35_0.class17_211, new Class39.Delegate1(this.method_77))
    },
    {
      this.class35_0.class17_115.method_0(),
      new Class39.Class43(this.class35_0.class17_115, new Class39.Delegate1(this.method_125))
    },
    {
      this.class35_0.class17_185.method_0(),
      new Class39.Class43(this.class35_0.class17_185, new Class39.Delegate1(this.method_93))
    },
    {
      this.class35_0.class17_38.method_0(),
      new Class39.Class43(this.class35_0.class17_38, new Class39.Delegate1(this.method_107))
    },
    {
      this.class35_0.class17_86.method_0(),
      new Class39.Class43(this.class35_0.class17_86, new Class39.Delegate1(this.method_217))
    },
    {
      this.class35_0.class17_118.method_0(),
      new Class39.Class43(this.class35_0.class17_118, new Class39.Delegate1(this.method_146))
    },
    {
      this.class35_0.class17_89.method_0(),
      new Class39.Class43(this.class35_0.class17_89, new Class39.Delegate1(this.method_102))
    },
    {
      this.class35_0.class17_83.method_0(),
      new Class39.Class43(this.class35_0.class17_83, new Class39.Delegate1(this.method_0))
    },
    {
      this.class35_0.class17_181.method_0(),
      new Class39.Class43(this.class35_0.class17_181, new Class39.Delegate1(this.method_226))
    },
    {
      this.class35_0.class17_191.method_0(),
      new Class39.Class43(this.class35_0.class17_191, new Class39.Delegate1(this.method_140))
    },
    {
      this.class35_0.class17_45.method_0(),
      new Class39.Class43(this.class35_0.class17_45, new Class39.Delegate1(this.method_142))
    },
    {
      this.class35_0.class17_196.method_0(),
      new Class39.Class43(this.class35_0.class17_196, new Class39.Delegate1(this.method_41))
    },
    {
      this.class35_0.class17_164.method_0(),
      new Class39.Class43(this.class35_0.class17_164, new Class39.Delegate1(this.method_135))
    },
    {
      this.class35_0.class17_64.method_0(),
      new Class39.Class43(this.class35_0.class17_64, new Class39.Delegate1(this.method_253))
    },
    {
      this.class35_0.class17_188.method_0(),
      new Class39.Class43(this.class35_0.class17_188, new Class39.Delegate1(this.method_49))
    },
    {
      this.class35_0.class17_85.method_0(),
      new Class39.Class43(this.class35_0.class17_85, new Class39.Delegate1(this.method_162))
    },
    {
      this.class35_0.class17_146.method_0(),
      new Class39.Class43(this.class35_0.class17_146, new Class39.Delegate1(this.method_50))
    },
    {
      this.class35_0.class17_10.method_0(),
      new Class39.Class43(this.class35_0.class17_10, new Class39.Delegate1(this.method_163))
    },
    {
      this.class35_0.class17_208.method_0(),
      new Class39.Class43(this.class35_0.class17_208, new Class39.Delegate1(this.method_14))
    },
    {
      this.class35_0.class17_16.method_0(),
      new Class39.Class43(this.class35_0.class17_16, new Class39.Delegate1(this.method_64))
    },
    {
      this.class35_0.class17_36.method_0(),
      new Class39.Class43(this.class35_0.class17_36, new Class39.Delegate1(this.method_211))
    },
    {
      this.class35_0.class17_19.method_0(),
      new Class39.Class43(this.class35_0.class17_19, new Class39.Delegate1(this.method_233))
    },
    {
      this.class35_0.class17_35.method_0(),
      new Class39.Class43(this.class35_0.class17_35, new Class39.Delegate1(this.method_60))
    },
    {
      this.class35_0.class17_13.method_0(),
      new Class39.Class43(this.class35_0.class17_13, new Class39.Delegate1(this.method_285))
    },
    {
      this.class35_0.class17_53.method_0(),
      new Class39.Class43(this.class35_0.class17_53, new Class39.Delegate1(this.method_11))
    },
    {
      this.class35_0.class17_122.method_0(),
      new Class39.Class43(this.class35_0.class17_122, new Class39.Delegate1(this.method_65))
    },
    {
      this.class35_0.class17_103.method_0(),
      new Class39.Class43(this.class35_0.class17_103, new Class39.Delegate1(this.method_282))
    },
    {
      this.class35_0.class17_192.method_0(),
      new Class39.Class43(this.class35_0.class17_192, new Class39.Delegate1(this.method_71))
    },
    {
      this.class35_0.class17_106.method_0(),
      new Class39.Class43(this.class35_0.class17_106, new Class39.Delegate1(this.method_221))
    },
    {
      this.class35_0.class17_95.method_0(),
      new Class39.Class43(this.class35_0.class17_95, new Class39.Delegate1(this.method_198))
    },
    {
      this.class35_0.class17_0.method_0(),
      new Class39.Class43(this.class35_0.class17_0, new Class39.Delegate1(this.method_2))
    },
    {
      this.class35_0.class17_41.method_0(),
      new Class39.Class43(this.class35_0.class17_41, new Class39.Delegate1(this.method_301))
    },
    {
      this.class35_0.class17_14.method_0(),
      new Class39.Class43(this.class35_0.class17_14, new Class39.Delegate1(this.method_138))
    },
    {
      this.class35_0.class17_165.method_0(),
      new Class39.Class43(this.class35_0.class17_165, new Class39.Delegate1(this.method_121))
    },
    {
      this.class35_0.class17_206.method_0(),
      new Class39.Class43(this.class35_0.class17_206, new Class39.Delegate1(this.method_203))
    },
    {
      this.class35_0.class17_63.method_0(),
      new Class39.Class43(this.class35_0.class17_63, new Class39.Delegate1(this.method_139))
    },
    {
      this.class35_0.class17_151.method_0(),
      new Class39.Class43(this.class35_0.class17_151, new Class39.Delegate1(this.method_230))
    },
    {
      this.class35_0.class17_42.method_0(),
      new Class39.Class43(this.class35_0.class17_42, new Class39.Delegate1(this.method_240))
    },
    {
      this.class35_0.class17_33.method_0(),
      new Class39.Class43(this.class35_0.class17_33, new Class39.Delegate1(this.method_112))
    },
    {
      this.class35_0.class17_203.method_0(),
      new Class39.Class43(this.class35_0.class17_203, new Class39.Delegate1(this.method_48))
    },
    {
      this.class35_0.class17_109.method_0(),
      new Class39.Class43(this.class35_0.class17_109, new Class39.Delegate1(this.method_208))
    },
    {
      this.class35_0.class17_8.method_0(),
      new Class39.Class43(this.class35_0.class17_8, new Class39.Delegate1(this.method_119))
    },
    {
      this.class35_0.class17_174.method_0(),
      new Class39.Class43(this.class35_0.class17_174, new Class39.Delegate1(this.method_251))
    },
    {
      this.class35_0.class17_27.method_0(),
      new Class39.Class43(this.class35_0.class17_27, new Class39.Delegate1(this.method_206))
    },
    {
      this.class35_0.class17_176.method_0(),
      new Class39.Class43(this.class35_0.class17_176, new Class39.Delegate1(this.method_288))
    },
    {
      this.class35_0.class17_173.method_0(),
      new Class39.Class43(this.class35_0.class17_173, new Class39.Delegate1(this.method_80))
    },
    {
      this.class35_0.class17_140.method_0(),
      new Class39.Class43(this.class35_0.class17_140, new Class39.Delegate1(this.method_82))
    },
    {
      this.class35_0.class17_136.method_0(),
      new Class39.Class43(this.class35_0.class17_136, new Class39.Delegate1(this.method_272))
    },
    {
      this.class35_0.class17_150.method_0(),
      new Class39.Class43(this.class35_0.class17_150, new Class39.Delegate1(this.method_209))
    },
    {
      this.class35_0.class17_159.method_0(),
      new Class39.Class43(this.class35_0.class17_159, new Class39.Delegate1(this.method_244))
    },
    {
      this.class35_0.class17_114.method_0(),
      new Class39.Class43(this.class35_0.class17_114, new Class39.Delegate1(this.method_173))
    },
    {
      this.class35_0.class17_12.method_0(),
      new Class39.Class43(this.class35_0.class17_12, new Class39.Delegate1(this.method_220))
    },
    {
      this.class35_0.class17_182.method_0(),
      new Class39.Class43(this.class35_0.class17_182, new Class39.Delegate1(this.method_261))
    },
    {
      this.class35_0.class17_171.method_0(),
      new Class39.Class43(this.class35_0.class17_171, new Class39.Delegate1(this.method_207))
    },
    {
      this.class35_0.class17_29.method_0(),
      new Class39.Class43(this.class35_0.class17_29, new Class39.Delegate1(this.method_81))
    },
    {
      this.class35_0.class17_161.method_0(),
      new Class39.Class43(this.class35_0.class17_161, new Class39.Delegate1(this.method_193))
    },
    {
      this.class35_0.class17_130.method_0(),
      new Class39.Class43(this.class35_0.class17_130, new Class39.Delegate1(this.method_300))
    },
    {
      this.class35_0.class17_207.method_0(),
      new Class39.Class43(this.class35_0.class17_207, new Class39.Delegate1(this.method_129))
    },
    {
      this.class35_0.class17_157.method_0(),
      new Class39.Class43(this.class35_0.class17_157, new Class39.Delegate1(this.method_83))
    },
    {
      this.class35_0.class17_7.method_0(),
      new Class39.Class43(this.class35_0.class17_7, new Class39.Delegate1(this.method_89))
    },
    {
      this.class35_0.class17_22.method_0(),
      new Class39.Class43(this.class35_0.class17_22, new Class39.Delegate1(this.method_216))
    },
    {
      this.class35_0.class17_24.method_0(),
      new Class39.Class43(this.class35_0.class17_24, new Class39.Delegate1(this.method_76))
    },
    {
      this.class35_0.class17_11.method_0(),
      new Class39.Class43(this.class35_0.class17_11, new Class39.Delegate1(this.method_188))
    },
    {
      this.class35_0.class17_100.method_0(),
      new Class39.Class43(this.class35_0.class17_100, new Class39.Delegate1(this.method_195))
    },
    {
      this.class35_0.class17_113.method_0(),
      new Class39.Class43(this.class35_0.class17_113, new Class39.Delegate1(this.method_88))
    },
    {
      this.class35_0.class17_1.method_0(),
      new Class39.Class43(this.class35_0.class17_1, new Class39.Delegate1(this.method_116))
    },
    {
      this.class35_0.class17_62.method_0(),
      new Class39.Class43(this.class35_0.class17_62, new Class39.Delegate1(this.method_269))
    },
    {
      this.class35_0.class17_15.method_0(),
      new Class39.Class43(this.class35_0.class17_15, new Class39.Delegate1(this.method_153))
    },
    {
      this.class35_0.class17_25.method_0(),
      new Class39.Class43(this.class35_0.class17_25, new Class39.Delegate1(this.method_15))
    },
    {
      this.class35_0.class17_58.method_0(),
      new Class39.Class43(this.class35_0.class17_58, new Class39.Delegate1(this.method_297))
    },
    {
      this.class35_0.class17_88.method_0(),
      new Class39.Class43(this.class35_0.class17_88, new Class39.Delegate1(this.method_172))
    },
    {
      this.class35_0.class17_90.method_0(),
      new Class39.Class43(this.class35_0.class17_90, new Class39.Delegate1(this.method_255))
    },
    {
      this.class35_0.class17_147.method_0(),
      new Class39.Class43(this.class35_0.class17_147, new Class39.Delegate1(this.method_120))
    },
    {
      this.class35_0.class17_134.method_0(),
      new Class39.Class43(this.class35_0.class17_134, new Class39.Delegate1(this.method_284))
    },
    {
      this.class35_0.class17_156.method_0(),
      new Class39.Class43(this.class35_0.class17_156, new Class39.Delegate1(this.method_204))
    },
    {
      this.class35_0.class17_31.method_0(),
      new Class39.Class43(this.class35_0.class17_31, new Class39.Delegate1(this.method_165))
    },
    {
      this.class35_0.class17_99.method_0(),
      new Class39.Class43(this.class35_0.class17_99, new Class39.Delegate1(this.method_97))
    },
    {
      this.class35_0.class17_40.method_0(),
      new Class39.Class43(this.class35_0.class17_40, new Class39.Delegate1(this.method_189))
    },
    {
      this.class35_0.class17_111.method_0(),
      new Class39.Class43(this.class35_0.class17_111, new Class39.Delegate1(this.method_296))
    },
    {
      this.class35_0.class17_172.method_0(),
      new Class39.Class43(this.class35_0.class17_172, new Class39.Delegate1(this.method_66))
    },
    {
      this.class35_0.class17_18.method_0(),
      new Class39.Class43(this.class35_0.class17_18, new Class39.Delegate1(this.method_9))
    },
    {
      this.class35_0.class17_3.method_0(),
      new Class39.Class43(this.class35_0.class17_3, new Class39.Delegate1(this.method_12))
    },
    {
      this.class35_0.class17_21.method_0(),
      new Class39.Class43(this.class35_0.class17_21, new Class39.Delegate1(this.method_130))
    },
    {
      this.class35_0.class17_116.method_0(),
      new Class39.Class43(this.class35_0.class17_116, new Class39.Delegate1(this.method_150))
    },
    {
      this.class35_0.class17_23.method_0(),
      new Class39.Class43(this.class35_0.class17_23, new Class39.Delegate1(this.method_289))
    },
    {
      this.class35_0.class17_104.method_0(),
      new Class39.Class43(this.class35_0.class17_104, new Class39.Delegate1(this.method_90))
    },
    {
      this.class35_0.class17_61.method_0(),
      new Class39.Class43(this.class35_0.class17_61, new Class39.Delegate1(this.method_227))
    },
    {
      this.class35_0.class17_135.method_0(),
      new Class39.Class43(this.class35_0.class17_135, new Class39.Delegate1(this.method_113))
    },
    {
      this.class35_0.class17_93.method_0(),
      new Class39.Class43(this.class35_0.class17_93, new Class39.Delegate1(this.method_117))
    },
    {
      this.class35_0.class17_80.method_0(),
      new Class39.Class43(this.class35_0.class17_80, new Class39.Delegate1(this.method_295))
    },
    {
      this.class35_0.class17_132.method_0(),
      new Class39.Class43(this.class35_0.class17_132, new Class39.Delegate1(this.method_47))
    },
    {
      this.class35_0.class17_52.method_0(),
      new Class39.Class43(this.class35_0.class17_52, new Class39.Delegate1(this.method_55))
    },
    {
      this.class35_0.class17_198.method_0(),
      new Class39.Class43(this.class35_0.class17_198, new Class39.Delegate1(this.method_277))
    },
    {
      this.class35_0.class17_46.method_0(),
      new Class39.Class43(this.class35_0.class17_46, new Class39.Delegate1(this.method_132))
    },
    {
      this.class35_0.class17_160.method_0(),
      new Class39.Class43(this.class35_0.class17_160, new Class39.Delegate1(this.method_197))
    },
    {
      this.class35_0.class17_30.method_0(),
      new Class39.Class43(this.class35_0.class17_30, new Class39.Delegate1(this.method_190))
    },
    {
      this.class35_0.class17_67.method_0(),
      new Class39.Class43(this.class35_0.class17_67, new Class39.Delegate1(this.method_32))
    },
    {
      this.class35_0.class17_179.method_0(),
      new Class39.Class43(this.class35_0.class17_179, new Class39.Delegate1(this.method_53))
    },
    {
      this.class35_0.class17_39.method_0(),
      new Class39.Class43(this.class35_0.class17_39, new Class39.Delegate1(this.method_156))
    },
    {
      this.class35_0.class17_200.method_0(),
      new Class39.Class43(this.class35_0.class17_200, new Class39.Delegate1(this.method_243))
    },
    {
      this.class35_0.class17_193.method_0(),
      new Class39.Class43(this.class35_0.class17_193, new Class39.Delegate1(this.method_101))
    },
    {
      this.class35_0.class17_71.method_0(),
      new Class39.Class43(this.class35_0.class17_71, new Class39.Delegate1(this.method_40))
    },
    {
      this.class35_0.class17_129.method_0(),
      new Class39.Class43(this.class35_0.class17_129, new Class39.Delegate1(this.method_18))
    },
    {
      this.class35_0.class17_44.method_0(),
      new Class39.Class43(this.class35_0.class17_44, new Class39.Delegate1(this.method_280))
    },
    {
      this.class35_0.class17_112.method_0(),
      new Class39.Class43(this.class35_0.class17_112, new Class39.Delegate1(this.method_167))
    },
    {
      this.class35_0.class17_138.method_0(),
      new Class39.Class43(this.class35_0.class17_138, new Class39.Delegate1(this.method_274))
    },
    {
      this.class35_0.class17_133.method_0(),
      new Class39.Class43(this.class35_0.class17_133, new Class39.Delegate1(this.method_154))
    },
    {
      this.class35_0.class17_82.method_0(),
      new Class39.Class43(this.class35_0.class17_82, new Class39.Delegate1(this.method_281))
    },
    {
      this.class35_0.class17_189.method_0(),
      new Class39.Class43(this.class35_0.class17_189, new Class39.Delegate1(this.method_109))
    },
    {
      this.class35_0.class17_124.method_0(),
      new Class39.Class43(this.class35_0.class17_124, new Class39.Delegate1(this.method_37))
    },
    {
      this.class35_0.class17_6.method_0(),
      new Class39.Class43(this.class35_0.class17_6, new Class39.Delegate1(this.method_134))
    },
    {
      this.class35_0.class17_73.method_0(),
      new Class39.Class43(this.class35_0.class17_73, new Class39.Delegate1(this.method_155))
    },
    {
      this.class35_0.class17_108.method_0(),
      new Class39.Class43(this.class35_0.class17_108, new Class39.Delegate1(this.method_38))
    },
    {
      this.class35_0.class17_51.method_0(),
      new Class39.Class43(this.class35_0.class17_51, new Class39.Delegate1(this.method_19))
    },
    {
      this.class35_0.class17_94.method_0(),
      new Class39.Class43(this.class35_0.class17_94, new Class39.Delegate1(this.method_242))
    },
    {
      this.class35_0.class17_57.method_0(),
      new Class39.Class43(this.class35_0.class17_57, new Class39.Delegate1(this.method_177))
    },
    {
      this.class35_0.class17_142.method_0(),
      new Class39.Class43(this.class35_0.class17_142, new Class39.Delegate1(this.method_191))
    },
    {
      this.class35_0.class17_107.method_0(),
      new Class39.Class43(this.class35_0.class17_107, new Class39.Delegate1(this.method_108))
    },
    {
      this.class35_0.class17_70.method_0(),
      new Class39.Class43(this.class35_0.class17_70, new Class39.Delegate1(this.method_232))
    },
    {
      this.class35_0.class17_212.method_0(),
      new Class39.Class43(this.class35_0.class17_212, new Class39.Delegate1(this.method_299))
    },
    {
      this.class35_0.class17_120.method_0(),
      new Class39.Class43(this.class35_0.class17_120, new Class39.Delegate1(this.method_249))
    },
    {
      this.class35_0.class17_144.method_0(),
      new Class39.Class43(this.class35_0.class17_144, new Class39.Delegate1(this.method_265))
    },
    {
      this.class35_0.class17_145.method_0(),
      new Class39.Class43(this.class35_0.class17_145, new Class39.Delegate1(this.method_111))
    },
    {
      this.class35_0.class17_56.method_0(),
      new Class39.Class43(this.class35_0.class17_56, new Class39.Delegate1(this.method_201))
    },
    {
      this.class35_0.class17_201.method_0(),
      new Class39.Class43(this.class35_0.class17_201, new Class39.Delegate1(this.method_5))
    },
    {
      this.class35_0.class17_169.method_0(),
      new Class39.Class43(this.class35_0.class17_169, new Class39.Delegate1(this.method_31))
    },
    {
      this.class35_0.class17_26.method_0(),
      new Class39.Class43(this.class35_0.class17_26, new Class39.Delegate1(this.method_234))
    },
    {
      this.class35_0.class17_5.method_0(),
      new Class39.Class43(this.class35_0.class17_5, new Class39.Delegate1(this.method_228))
    },
    {
      this.class35_0.class17_92.method_0(),
      new Class39.Class43(this.class35_0.class17_92, new Class39.Delegate1(this.method_3))
    },
    {
      this.class35_0.class17_131.method_0(),
      new Class39.Class43(this.class35_0.class17_131, new Class39.Delegate1(this.method_72))
    },
    {
      this.class35_0.class17_213.method_0(),
      new Class39.Class43(this.class35_0.class17_213, new Class39.Delegate1(this.method_99))
    },
    {
      this.class35_0.class17_28.method_0(),
      new Class39.Class43(this.class35_0.class17_28, new Class39.Delegate1(this.method_266))
    },
    {
      this.class35_0.class17_127.method_0(),
      new Class39.Class43(this.class35_0.class17_127, new Class39.Delegate1(this.method_6))
    },
    {
      this.class35_0.class17_163.method_0(),
      new Class39.Class43(this.class35_0.class17_163, new Class39.Delegate1(this.method_237))
    },
    {
      this.class35_0.class17_210.method_0(),
      new Class39.Class43(this.class35_0.class17_210, new Class39.Delegate1(this.method_137))
    },
    {
      this.class35_0.class17_60.method_0(),
      new Class39.Class43(this.class35_0.class17_60, new Class39.Delegate1(this.method_92))
    },
    {
      this.class35_0.class17_34.method_0(),
      new Class39.Class43(this.class35_0.class17_34, new Class39.Delegate1(this.method_205))
    },
    {
      this.class35_0.class17_97.method_0(),
      new Class39.Class43(this.class35_0.class17_97, new Class39.Delegate1(this.method_278))
    }
  };

  public object method_22(
    Stream stream_1,
    string string_0,
    object[] object_3,
    Type[] type_9,
    Type[] type_10,
    object[] object_4)
  {
    this.stream_0 = stream_1;
    this.method_28(string_0, stream_1);
    return this.method_213(object_3, type_9, type_10, object_4);
  }

  private void method_23()
  {
    if (!this.class35_0.method_1())
    {
      lock (this.class35_0)
      {
        if (!this.class35_0.method_1())
        {
          this.dictionary_5 = this.method_21();
          this.method_271();
          this.class35_0.method_2(true);
        }
      }
    }
    if (this.dictionary_5 != null)
      return;
    this.dictionary_5 = this.method_21();
  }

  private Class45 method_24(Class45 class45_2, Class45 class45_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int num1 = ((Class46) class45_2).method_2();
        int num2 = ((Class46) class45_3).method_2();
        Class46 class46 = new Class46();
        class46.method_3(num1 ^ num2);
        return (Class45) class46;
      }
      if (class45_3.vmethod_2() == 7)
      {
        int num = ((Class46) class45_2).method_2();
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          int int32 = Convert.ToInt32(class45_3.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(num ^ int32);
          return (Class45) class46;
        }
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3((long) num ^ int64);
        return (Class45) class63;
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
      {
        long num3 = ((Class63) class45_2).method_2();
        long num4 = ((Class63) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(num3 ^ num4);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        int num = ((Class46) class45_2).method_2();
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3((long) num ^ int64);
        return (Class45) class63;
      }
    }
    if (class45_2.vmethod_2() == 7)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int num = ((Class46) class45_3).method_2();
        Type underlyingType = Enum.GetUnderlyingType(class45_2.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          int int32 = Convert.ToInt32(class45_2.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(int32 ^ num);
          return (Class45) class46;
        }
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3(int64 ^ (long) num);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 3)
      {
        long int64 = Convert.ToInt64(class45_2.vmethod_0());
        long num = ((Class63) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(int64 ^ num);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType1 = Enum.GetUnderlyingType(class45_2.vmethod_0().GetType());
        Type underlyingType2 = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType1 != (object) typeof (long) && (object) underlyingType1 != (object) typeof (ulong) && (object) underlyingType2 != (object) typeof (long) && (object) underlyingType2 != (object) typeof (ulong))
        {
          int int32_1 = Convert.ToInt32(class45_2.vmethod_0());
          int int32_2 = Convert.ToInt32(class45_3.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(int32_1 ^ int32_2);
          return (Class45) class46;
        }
        long int64_1 = Convert.ToInt64(class45_2.vmethod_0());
        long int64_2 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3(int64_1 ^ int64_2);
        return (Class45) class63;
      }
    }
    throw new InvalidOperationException();
  }

  private void method_25(Type type_9)
  {
    object object_3 = this.method_10().vmethod_0();
    long long_1 = this.method_215();
    Array array_0 = (Array) this.method_10().vmethod_0();
    this.method_87(type_9, object_3, long_1, array_0);
  }

  private void method_26(bool bool_2)
  {
    Class45 class45 = this.method_10();
    ushort int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = !bool_2 ? (ushort) ((Class63) class45).method_2() : checked ((ushort) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = !bool_2 ? (ushort) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((ushort) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = !bool_2 ? (ushort) ((Class46) class45).method_2() : checked ((ushort) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = !bool_2 ? (ushort) ((Class48) class45).method_2() : checked ((ushort) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2 = new Class46();
    class45_2.method_3((int) int_1);
    this.method_176((Class45) class45_2);
  }

  private void method_27(Class45 class45_2)
  {
    if (this.object_1 == null)
      throw new InvalidOperationException();
    this.method_184(this.object_1);
  }

  private static bool smethod_3() => false;

  private void method_28(string string_0, Stream stream_1) => this.method_39(0L, stream_1, string_0);

  private Class45 method_29(Class45 class45_2, Class45 class45_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int int_1 = ((Class46) class45_2).method_2() << ((Class46) class45_3).method_2();
        Class46 class46 = new Class46();
        class46.method_3(int_1);
        return (Class45) class46;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Class45 class45_2_1 = class45_2;
        Class46 class45_3_1 = new Class46();
        class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
        return this.method_29(class45_2_1, (Class45) class45_3_1);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 9)
      {
        long long_1 = ((Class63) class45_2).method_2() << ((Class46) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(long_1);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Class45 class45_2_2 = class45_2;
        Class46 class45_3_2 = new Class46();
        class45_3_2.method_3(Convert.ToInt32(class45_3.vmethod_0()));
        return this.method_29(class45_2_2, (Class45) class45_3_2);
      }
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_3 = new Class46();
      class45_2_3.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_29((Class45) class45_2_3, class45_3);
    }
    Class63 class45_2_4 = new Class63();
    class45_2_4.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_29((Class45) class45_2_4, class45_3);
  }

  private void method_30(int int_0, Type[] type_9, Type[] type_10, bool bool_2)
  {
    this.binaryReader_0.BaseStream.Seek((long) int_0, SeekOrigin.Begin);
    this.method_35(this.binaryReader_0);
    Class38 class38_1 = this.method_223(this.binaryReader_0);
    this.method_51(class38_1);
    int length = class38_1.method_2().Length;
    object[] object_3 = new object[length];
    Class45[] class45Array = new Class45[length];
    if (this.type_3 != null & bool_2)
    {
      int num = class38_1.method_12() ? 0 : 1;
      Type[] types = new Type[length - num];
      for (int index = length - 1; index >= num; --index)
        types[index] = this.method_257(class38_1.method_2()[index].method_0(), true);
      MethodInfo method = this.type_3.GetMethod(class38_1.method_4(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, (Binder) null, types, (ParameterModifier[]) null);
      this.type_3 = (Type) null;
      if ((object) method != null)
      {
        this.method_186((MethodBase) method, true);
        return;
      }
    }
    for (int index = length - 1; index >= 0; --index)
    {
      Class45 class45_1 = this.method_10();
      class45Array[index] = class45_1;
      if (class45_1.vmethod_5())
        class45_1 = this.method_219(class45_1);
      if ((object) class45_1.method_0() != null)
        class45_1 = Class80.smethod_1((object) null, class45_1.method_0()).vmethod_3(class45_1);
      Class45 class45_2 = Class80.smethod_1((object) null, this.method_257(class38_1.method_2()[index].method_0(), true)).vmethod_3(class45_1);
      object_3[index] = class45_2.vmethod_0();
      if (index == 0 & bool_2 && !class38_1.method_12() && object_3[index] == null)
        throw new NullReferenceException();
    }
    Class39 class39 = new Class39(this.class35_0);
    object[] object_4 = new object[1]
    {
      (object) this.module_0.Assembly
    };
    object object_0_1;
    try
    {
      object_0_1 = class39.method_70(this.stream_0, int_0, object_3, type_9, type_10, object_4);
    }
    finally
    {
      for (int index = 0; index < class45Array.Length; ++index)
      {
        Class45 class45_2 = class45Array[index];
        if (class45_2.vmethod_5())
        {
          object object_0_2 = object_3[index];
          this.method_4(class45_2, Class80.smethod_1(object_0_2, (Type) null));
        }
      }
    }
    Type type_0 = class39.method_257(class39.class38_0.method_8(), true);
    if ((object) type_0 == (object) Class39.type_0)
      return;
    this.method_176(Class80.smethod_1(object_0_1, type_0));
  }

  private static Class45 smethod_4(Class45 class45_2, Class45 class45_3, bool bool_2)
  {
    if (!bool_2)
    {
      long num1 = ((Class63) class45_2).method_2();
      long num2 = ((Class63) class45_3).method_2();
      Class63 class63 = new Class63();
      class63.method_3(num1 % num2);
      return (Class45) class63;
    }
    ulong num3 = (ulong) ((Class63) class45_2).method_2();
    ulong num4 = (ulong) ((Class63) class45_3).method_2();
    Class63 class63_1 = new Class63();
    class63_1.method_3((long) (num3 % num4));
    return (Class45) class63_1;
  }

  private void method_31(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_69(this.method_10(), class45_3, true, false));
  }

  private void method_32(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    double double_1;
    switch (class45.vmethod_2())
    {
      case 3:
        double_1 = (double) (ulong) ((Class63) class45).method_2();
        break;
      case 7:
        double_1 = (double) Convert.ToUInt64((object) ((Class59) class45).method_2());
        break;
      case 9:
        double_1 = (double) (uint) ((Class46) class45).method_2();
        break;
      default:
        throw new InvalidOperationException();
    }
    Class48 class45_2_1 = new Class48();
    class45_2_1.method_3(double_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_33()
  {
    try
    {
      this.method_248();
    }
    catch (Exception ex)
    {
      this.method_159((object) ex, 0U);
      this.method_248();
    }
  }

  private void method_34(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    long long_1;
    switch (class45.vmethod_2())
    {
      case 3:
        long_1 = checked ((long) (ulong) ((Class63) class45).method_2());
        break;
      case 7:
        long_1 = checked ((long) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        long_1 = (long) checked ((uint) ((Class46) class45).method_2());
        break;
      case 16:
        long_1 = checked ((long) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class63 class45_2_1 = new Class63();
    class45_2_1.method_3(long_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_35(BinaryReader binaryReader_1)
  {
  }

  private void method_36(Class45 class45_2)
  {
    Type type_9 = this.method_257(((Class46) class45_2).method_2(), true);
    Class45 class45_2_1 = this.method_10();
    if (!this.method_143(class45_2_1, type_9))
      throw new InvalidCastException();
    this.method_176(class45_2_1);
  }

  private void method_37(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    bool flag;
    switch (class45.vmethod_2())
    {
      case 2:
        flag = ((Class67) class45).method_2() == IntPtr.Zero;
        break;
      case 3:
        flag = ((Class63) class45).method_2() == 0L;
        break;
      case 5:
        flag = ((Class65) class45).method_2() == UIntPtr.Zero;
        break;
      case 7:
        flag = !Convert.ToBoolean((object) ((Class59) class45).method_2());
        break;
      case 9:
        flag = ((Class46) class45).method_2() == 0;
        break;
      case 20:
        flag = ((Class49) class45).method_2() == null;
        break;
      default:
        flag = class45.vmethod_0() == null;
        break;
    }
    if (!flag)
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_38(Class45 class45_2) => this.method_176(this.class45_0[(int) ((Class51) class45_2).method_2()].vmethod_4());

  private void method_39(long long_1, Stream stream_1, string string_0)
  {
    int int_1 = this.method_245();
    this.binaryReader_0 = new BinaryReader((Stream) new Stream0(stream_1, int_1));
    lock (this.binaryReader_0.BaseStream)
    {
      if (string_0 != null)
        long_1 = this.method_235(string_0);
      this.binaryReader_0.BaseStream.Seek(long_1, SeekOrigin.Begin);
      this.method_35(this.binaryReader_0);
      this.class38_0 = this.method_223(this.binaryReader_0);
      this.class34_0 = Class39.smethod_16(this.binaryReader_0);
      this.method_258();
      this.byte_0 = Class39.smethod_11(this.binaryReader_0);
    }
  }

  private void method_40(Class45 class45_2) => this.method_178((int) ((Class51) class45_2).method_2());

  private void method_41(Class45 class45_2) => this.method_238();

  private void method_42(bool bool_2)
  {
    Class45 class45 = this.method_10();
    uint int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = !bool_2 ? (uint) ((Class63) class45).method_2() : checked ((uint) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = !bool_2 ? (uint) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((uint) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = !bool_2 ? (uint) (ushort) ((Class46) class45).method_2() : checked ((uint) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = !bool_2 ? (uint) ((Class48) class45).method_2() : checked ((uint) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2 = new Class46();
    class45_2.method_3((int) int_1);
    this.method_176((Class45) class45_2);
  }

  private MethodBase method_43(MethodBase methodBase_0, bool bool_2)
  {
    lock (Class39.dictionary_2)
    {
      DynamicMethod dynamicMethod;
      if (Class39.dictionary_2.TryGetValue(methodBase_0, out dynamicMethod))
        return (MethodBase) dynamicMethod;
      string empty = string.Empty;
      MethodInfo methodInfo = methodBase_0 as MethodInfo;
      Type returnType = (object) methodInfo == null ? Class39.type_0 : methodInfo.ReturnType;
      ParameterInfo[] parameters = methodBase_0.GetParameters();
      Type[] parameterTypes;
      if (methodBase_0.IsStatic)
      {
        parameterTypes = new Type[parameters.Length];
        for (int index = 0; index < parameters.Length; ++index)
          parameterTypes[index] = parameters[index].ParameterType;
      }
      else
      {
        parameterTypes = new Type[parameters.Length + 1];
        Type type = methodBase_0.DeclaringType;
        if (type.IsValueType)
        {
          type = type.MakeByRefType();
          bool_2 = false;
        }
        parameterTypes[0] = type;
        for (int index = 0; index < parameters.Length; ++index)
          parameterTypes[index + 1] = parameters[index].ParameterType;
      }
      if (dynamicMethod == null)
        dynamicMethod = new DynamicMethod(empty, returnType, parameterTypes, this.method_257(this.class38_0.method_6(), true), true);
      ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
      for (int index = 0; index < parameterTypes.Length; ++index)
        ilGenerator.Emit(OpCodes.Ldarg, index);
      ConstructorInfo con = methodBase_0 as ConstructorInfo;
      if ((object) con != null)
        ilGenerator.Emit(bool_2 ? OpCodes.Callvirt : OpCodes.Call, con);
      else
        ilGenerator.Emit(bool_2 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo) methodBase_0);
      ilGenerator.Emit(OpCodes.Ret);
      Class39.dictionary_2.Add(methodBase_0, dynamicMethod);
      return (MethodBase) dynamicMethod;
    }
  }

  private void method_44()
  {
    if (this.class16_1.Count == 0)
    {
      if (!this.bool_0)
        return;
      this.method_184(this.object_1);
    }
    else
    {
      Class39.Struct5 struct5 = this.class16_1.method_6();
      if (struct5.method_1() != null)
      {
        Class49 class45_2 = new Class49();
        class45_2.vmethod_1(struct5.method_1());
        this.method_176((Class45) class45_2);
      }
      else
        this.class16_0.method_0();
      this.method_160(struct5.method_0());
    }
  }

  private void method_45(Class45 class45_2) => this.method_160(((Class64) class45_2).method_2());

  private void method_46(Class45 class45_2) => Debugger.Break();

  private void method_47(Class45 class45_2) => this.method_192(typeof (byte));

  private void method_48(Class45 class45_2) => this.method_159((object) null, ((Class64) class45_2).method_2());

  private void method_49(Class45 class45_2) => throw new NotSupportedException("Cpblk not supported.");

  private void method_50(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    if (!(class45_2_1.vmethod_2() != 16 ? !Class39.smethod_0(class45_2_1, class45_3) : !Class39.smethod_24(class45_2_1, class45_3)))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_51(Class38 class38_1)
  {
    if (Class39.smethod_3() && !this.class38_0.method_13() && class38_1.method_13() && !class38_1.method_14())
    {
      string string_1 = this.method_239(class38_1);
      throw Class39.smethod_30(this.method_239(this.class38_0), string_1);
    }
  }

  private void method_52(Class45 class45_2) => throw new NotSupportedException("Mkrefany is not supported.");

  private void method_53(Class45 class45_2)
  {
    FieldInfo fieldInfo = this.method_229(((Class46) class45_2).method_2());
    Class45 class45 = Class80.smethod_1(this.method_10().vmethod_0(), fieldInfo.FieldType);
    fieldInfo.SetValue((object) null, class45.vmethod_0());
  }

  private static Exception smethod_5(string string_0, string string_1) => (Exception) new FieldAccessException(Class39.smethod_13(string.Format("security transparent method '{0}'", (object) string_0), string.Format("security critical field '{0}'", (object) string_1)));

  private void method_54(Class45 class45_2) => this.method_238();

  private void method_55(Class45 class45_2) => this.method_176(class45_2);

  private bool method_56(long long_1, uint uint_0, uint uint_1) => long_1 >= (long) uint_0 && long_1 <= (long) (uint_0 + uint_1);

  private Class45 method_57(Class45 class45_2, Class45 class45_3, bool bool_2)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_2)
        {
          int num1 = ((Class46) class45_2).method_2();
          int num2 = ((Class46) class45_3).method_2();
          Class46 class46 = new Class46();
          class46.method_3(num1 >> num2);
          return (Class45) class46;
        }
        uint num3 = (uint) ((Class46) class45_2).method_2();
        int num4 = ((Class46) class45_3).method_2();
        Class46 class46_1 = new Class46();
        class46_1.method_3((int) (num3 >> num4));
        return (Class45) class46_1;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Class45 class45_2_1 = class45_2;
        Class46 class45_3_1 = new Class46();
        class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
        int num = bool_2 ? 1 : 0;
        return this.method_57(class45_2_1, (Class45) class45_3_1, num != 0);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_2)
        {
          long num5 = ((Class63) class45_2).method_2();
          int num6 = ((Class46) class45_3).method_2();
          Class63 class63 = new Class63();
          class63.method_3(num5 >> num6);
          return (Class45) class63;
        }
        ulong num7 = (ulong) ((Class63) class45_2).method_2();
        int num8 = ((Class46) class45_3).method_2();
        Class63 class63_1 = new Class63();
        class63_1.method_3((long) (num7 >> num8));
        return (Class45) class63_1;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Class45 class45_2_2 = class45_2;
        Class46 class45_3_2 = new Class46();
        class45_3_2.method_3(Convert.ToInt32(class45_3.vmethod_0()));
        int num = bool_2 ? 1 : 0;
        return this.method_57(class45_2_2, (Class45) class45_3_2, num != 0);
      }
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_3 = new Class46();
      class45_2_3.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_57((Class45) class45_2_3, class45_3, bool_2);
    }
    Class63 class45_2_4 = new Class63();
    class45_2_4.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_57((Class45) class45_2_4, class45_3, bool_2);
  }

  private void method_58(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_84(this.method_10(), class45_3));
  }

  private void method_59(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    byte int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = checked ((byte) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = checked ((byte) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = checked ((byte) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = checked ((byte) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3((int) int_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_60(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    IntPtr intptr_1;
    switch (class45.vmethod_2())
    {
      case 3:
        intptr_1 = new IntPtr(checked ((long) (ulong) ((Class63) class45).method_2()));
        break;
      case 7:
        intptr_1 = new IntPtr(checked ((long) Convert.ToUInt64((object) ((Class59) class45).method_2())));
        break;
      case 9:
        intptr_1 = new IntPtr((long) checked ((uint) ((Class46) class45).method_2()));
        break;
      case 16:
        intptr_1 = new IntPtr(checked ((long) ((Class48) class45).method_2()));
        break;
      default:
        throw new InvalidOperationException();
    }
    Class67 class45_2_1 = new Class67();
    class45_2_1.method_3(intptr_1);
    this.method_176((Class45) class45_2_1);
  }

  private MethodBase method_61(Class31 class31_0)
  {
    Type type = this.method_257(class31_0.method_4().method_2(), false);
    BindingFlags bindingAttr = Class39.smethod_1(class31_0.method_2());
    MemberInfo[] member = type.GetMember(class31_0.method_6(), bindingAttr);
    MethodInfo methodInfo1 = (MethodInfo) null;
    foreach (MethodInfo methodInfo2 in member)
    {
      if (methodInfo2.IsGenericMethodDefinition)
      {
        ParameterInfo[] parameters = methodInfo2.GetParameters();
        if (parameters.Length == class31_0.method_8().Length && methodInfo2.GetGenericArguments().Length == class31_0.method_10().Length && this.method_181(methodInfo2.ReturnType, class31_0.method_12()))
        {
          bool flag = true;
          for (int index = 0; index < parameters.Length; ++index)
          {
            if (!this.method_181(parameters[index].ParameterType, class31_0.method_8()[index]))
            {
              flag = false;
              break;
            }
          }
          if (flag)
          {
            methodInfo1 = methodInfo2;
            break;
          }
        }
      }
    }
    if ((object) methodInfo1 == null)
      throw new Exception(string.Format("Cannot bind method: {0}.{1}", (object) type.Name, (object) class31_0.method_6()));
    Type[] typeArray = new Type[class31_0.method_10().Length];
    for (int index = 0; index < typeArray.Length; ++index)
      typeArray[index] = this.method_257(class31_0.method_10()[index].method_2(), true);
    return (MethodBase) methodInfo1.MakeGenericMethod(typeArray);
  }

  private void method_62(Class45 class45_2) => this.method_238();

  private void method_63(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_161(this.method_10(), class45_3, false));
  }

  private void method_64(Class45 class45_2) => this.method_170(true);

  private void method_65(Class45 class45_2) => this.method_183(typeof (short));

  private static void smethod_6(object object_3) => throw object_3;

  private void method_66(Class45 class45_2) => this.method_122(false);

  private Class45 method_67(Class45 class45_2, Class45 class45_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int num1 = ((Class46) class45_2).method_2();
        int num2 = ((Class46) class45_3).method_2();
        Class46 class46 = new Class46();
        class46.method_3(num1 | num2);
        return (Class45) class46;
      }
      if (class45_3.vmethod_2() == 7)
      {
        int num = ((Class46) class45_2).method_2();
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          int int32 = Convert.ToInt32(class45_3.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(num | int32);
          return (Class45) class46;
        }
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3((long) num | int64);
        return (Class45) class63;
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
      {
        long num3 = ((Class63) class45_2).method_2();
        long num4 = ((Class63) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(num3 | num4);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        int num = ((Class46) class45_2).method_2();
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3((long) num | int64);
        return (Class45) class63;
      }
    }
    if (class45_2.vmethod_2() == 7)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int num = ((Class46) class45_3).method_2();
        Type underlyingType = Enum.GetUnderlyingType(class45_2.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          int int32 = Convert.ToInt32(class45_2.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(int32 | num);
          return (Class45) class46;
        }
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3(int64 | (long) num);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 3)
      {
        long int64 = Convert.ToInt64(class45_2.vmethod_0());
        long num = ((Class63) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(int64 | num);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType1 = Enum.GetUnderlyingType(class45_2.vmethod_0().GetType());
        Type underlyingType2 = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType1 != (object) typeof (long) && (object) underlyingType1 != (object) typeof (ulong) && (object) underlyingType2 != (object) typeof (long) && (object) underlyingType2 != (object) typeof (ulong))
        {
          int int32_1 = Convert.ToInt32(class45_2.vmethod_0());
          int int32_2 = Convert.ToInt32(class45_3.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(int32_1 | int32_2);
          return (Class45) class46;
        }
        long int64_1 = Convert.ToInt64(class45_2.vmethod_0());
        long int64_2 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3(int64_1 | int64_2);
        return (Class45) class63;
      }
    }
    throw new InvalidOperationException();
  }

  public void method_68(Stream stream_1, string string_0, object[] object_3) => this.method_270(stream_1, string_0, object_3);

  private Class45 method_69(Class45 class45_2, Class45 class45_3, bool bool_2, bool bool_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_3)
        {
          int num1 = ((Class46) class45_2).method_2();
          int num2 = ((Class46) class45_3).method_2();
          int int_1 = !bool_2 ? num1 * num2 : checked (num1 * num2);
          Class46 class46 = new Class46();
          class46.method_3(int_1);
          return (Class45) class46;
        }
        uint num3 = (uint) ((Class46) class45_2).method_2();
        uint num4 = (uint) ((Class46) class45_3).method_2();
        uint int_1_1 = !bool_2 ? num3 * num4 : checked (num3 * num4);
        Class46 class46_1 = new Class46();
        class46_1.method_3((int) int_1_1);
        return (Class45) class46_1;
      }
      if (class45_3.vmethod_2() == 3)
      {
        Class63 class45_2_1 = new Class63();
        class45_2_1.method_3((long) ((Class46) class45_2).method_2());
        return Class39.smethod_10((Class45) class45_2_1, class45_3, bool_2, bool_3);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_2 = class45_2;
          Class46 class45_3_1 = new Class46();
          class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num5 = bool_2 ? 1 : 0;
          int num6 = bool_3 ? 1 : 0;
          return this.method_69(class45_2_2, (Class45) class45_3_1, num5 != 0, num6 != 0);
        }
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3((long) ((Class46) class45_2).method_2());
        Class63 class45_3_2 = new Class63();
        class45_3_2.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        return Class39.smethod_10((Class45) class45_2_3, (Class45) class45_3_2, bool_2, bool_3);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
        return Class39.smethod_10(class45_2, class45_3, bool_2, bool_3);
      if (class45_3.vmethod_2() == 9)
      {
        Class45 class45_2_4 = class45_2;
        Class63 class45_3_3 = new Class63();
        class45_3_3.method_3((long) ((Class46) class45_3).method_2());
        int num7 = bool_2 ? 1 : 0;
        int num8 = bool_3 ? 1 : 0;
        return Class39.smethod_10(class45_2_4, (Class45) class45_3_3, num7 != 0, num8 != 0);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_5 = class45_2;
          Class46 class45_3_4 = new Class46();
          class45_3_4.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num9 = bool_2 ? 1 : 0;
          int num10 = bool_3 ? 1 : 0;
          return Class39.smethod_10(class45_2_5, (Class45) class45_3_4, num9 != 0, num10 != 0);
        }
        Class45 class45_2_6 = class45_2;
        Class63 class45_3_5 = new Class63();
        class45_3_5.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        int num11 = bool_2 ? 1 : 0;
        int num12 = bool_3 ? 1 : 0;
        return Class39.smethod_10(class45_2_6, (Class45) class45_3_5, num11 != 0, num12 != 0);
      }
    }
    if (class45_2.vmethod_2() == 16 && class45_3.vmethod_2() == 16)
    {
      Class48 class48 = new Class48();
      class48.method_3(((Class48) class45_2).method_2() * ((Class48) class45_3).method_2());
      return (Class45) class48;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_7 = new Class46();
      class45_2_7.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_69((Class45) class45_2_7, class45_3, bool_2, bool_3);
    }
    Class63 class45_2_8 = new Class63();
    class45_2_8.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_69((Class45) class45_2_8, class45_3, bool_2, bool_3);
  }

  private object method_70(
    Stream stream_1,
    int int_0,
    object[] object_3,
    Type[] type_9,
    Type[] type_10,
    object[] object_4)
  {
    this.stream_0 = stream_1;
    this.method_39((long) int_0, stream_1, (string) null);
    return this.method_213(object_3, type_9, type_10, object_4);
  }

  private void method_71(Class45 class45_2)
  {
    MethodBase methodBase_1 = this.method_225(((Class46) class45_2).method_2());
    Class68 class45_2_1 = new Class68();
    class45_2_1.method_3(methodBase_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_72(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_187(this.method_10(), class45_3, false));
  }

  private static Exception smethod_7(string string_0, string string_1) => (Exception) new TypeLoadException(Class39.smethod_13(string.Format("security transparent method '{0}'", (object) string_0), string.Format("security critical type '{0}'", (object) string_1)));

  private void method_73(Class45 class45_2)
  {
    Class45 class45_2_1 = this.method_10();
    Class45 class45_2_2 = class45_2_1.vmethod_4();
    this.method_176(class45_2_1);
    this.method_176(class45_2_2);
  }

  private Type method_74(int int_0, Class33 class33_0, ref bool bool_2, bool bool_3)
  {
    if (class33_0.method_0() == (byte) 1)
      return this.module_0.ResolveType(class33_0.method_2());
    Class30 class30 = (Class30) class33_0.method_4();
    if (class30.method_2())
    {
      Type type_0;
      if (class30.method_10() != -1)
        type_0 = this.type_8[class30.method_10()];
      else
        type_0 = class30.method_8() != -1 ? this.type_7[class30.method_8()] : throw new Exception();
      Class16<Struct2> class16_0 = Class25.smethod_3(class30.method_0());
      Type type = Class25.smethod_4(type_0, class16_0);
      bool_2 = false;
      return type;
    }
    string typeName = class30.method_0();
    Type type_0_1 = Type.GetType(typeName);
    if ((object) type_0_1 == null)
    {
      int length = typeName.IndexOf(',');
      string name = typeName.Substring(0, length);
      string assemblyString = typeName.Substring(length + 1).Trim();
      Assembly assembly0 = Class20.assembly_0;
      if (assemblyString.Equals(assembly0.FullName, StringComparison.Ordinal))
      {
        type_0_1 = assembly0.GetType(name);
      }
      else
      {
        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
          string str = (string) null;
          try
          {
            str = assembly.Location;
          }
          catch (NotSupportedException ex)
          {
          }
          if (string.IsNullOrEmpty(str) && assembly.FullName.Equals(assemblyString, StringComparison.Ordinal))
          {
            type_0_1 = assembly.GetType(name);
            if ((object) type_0_1 != null)
              break;
          }
        }
      }
      if ((object) type_0_1 == null && name.StartsWith("<PrivateImplementationDetails><", StringComparison.Ordinal))
      {
        if (name.Contains("."))
        {
          try
          {
            foreach (Type type in Assembly.Load(assemblyString).GetTypes())
            {
              if (type.FullName == name)
              {
                type_0_1 = type;
                break;
              }
            }
          }
          catch
          {
          }
        }
      }
    }
    if (class30.method_4())
    {
      Type[] typeArray = new Type[class30.method_6().Length];
      for (int index = 0; index < class30.method_6().Length; ++index)
        typeArray[index] = this.method_257(class30.method_6()[index].method_2(), bool_3);
      Type genericTypeDefinition = Class25.smethod_0(type_0_1).GetGenericTypeDefinition();
      Class16<Struct2> class16_0 = Class25.smethod_2(type_0_1);
      type_0_1 = Class25.smethod_4(genericTypeDefinition.MakeGenericType(typeArray), class16_0);
      bool_2 = false;
    }
    return type_0_1;
  }

  private void method_75(Class45 class45_2)
  {
    Type type_9 = this.method_257(((Class46) class45_2).method_2(), true);
    Class45 class45_2_1 = this.method_10();
    if (this.method_143(class45_2_1, type_9))
      this.method_176(class45_2_1);
    else
      this.method_176((Class45) new Class49());
  }

  private void method_76(Class45 class45_2) => this.method_176(this.class45_1[3].vmethod_4());

  private void method_77(Class45 class45_2) => this.method_192(typeof (short));

  private void method_78(Class45 class45_2) => this.method_25(Class20.type_0);

  private void method_79(Class45 class45_2) => this.method_194(true);

  private void method_80(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    sbyte int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = checked ((sbyte) (ulong) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = checked ((sbyte) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = checked ((sbyte) (uint) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = checked ((sbyte) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3((int) int_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_81(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_187(this.method_10(), class45_3, true));
  }

  private void method_82(Class45 class45_2)
  {
    Class69 class69 = (Class69) class45_2;
    Class53 class45_2_1 = new Class53();
    class45_2_1.method_3(this.class45_0[(int) class69.method_2()]);
    this.method_176((Class45) class45_2_1);
  }

  private void method_83(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_29(this.method_10(), class45_3));
  }

  private Class45 method_84(Class45 class45_2, Class45 class45_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int num1 = ((Class46) class45_2).method_2();
        int num2 = ((Class46) class45_3).method_2();
        Class46 class46 = new Class46();
        class46.method_3(num1 & num2);
        return (Class45) class46;
      }
      if (class45_3.vmethod_2() == 7)
      {
        int num = ((Class46) class45_2).method_2();
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          int int32 = Convert.ToInt32(class45_3.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(num & int32);
          return (Class45) class46;
        }
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3((long) num & int64);
        return (Class45) class63;
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
      {
        long num3 = ((Class63) class45_2).method_2();
        long num4 = ((Class63) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(num3 & num4);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        int num = ((Class46) class45_2).method_2();
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3((long) num & int64);
        return (Class45) class63;
      }
    }
    if (class45_2.vmethod_2() == 7)
    {
      if (class45_3.vmethod_2() == 9)
      {
        int num = ((Class46) class45_3).method_2();
        Type underlyingType = Enum.GetUnderlyingType(class45_2.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          int int32 = Convert.ToInt32(class45_2.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(int32 & num);
          return (Class45) class46;
        }
        long int64 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3(int64 & (long) num);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 3)
      {
        long int64 = Convert.ToInt64(class45_2.vmethod_0());
        long num = ((Class63) class45_3).method_2();
        Class63 class63 = new Class63();
        class63.method_3(int64 & num);
        return (Class45) class63;
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType1 = Enum.GetUnderlyingType(class45_2.vmethod_0().GetType());
        Type underlyingType2 = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType1 != (object) typeof (long) && (object) underlyingType1 != (object) typeof (ulong) && (object) underlyingType2 != (object) typeof (long) && (object) underlyingType2 != (object) typeof (ulong))
        {
          int int32_1 = Convert.ToInt32(class45_2.vmethod_0());
          int int32_2 = Convert.ToInt32(class45_3.vmethod_0());
          Class46 class46 = new Class46();
          class46.method_3(int32_1 & int32_2);
          return (Class45) class46;
        }
        long int64_1 = Convert.ToInt64(class45_2.vmethod_0());
        long int64_2 = Convert.ToInt64(class45_3.vmethod_0());
        Class63 class63 = new Class63();
        class63.method_3(int64_1 & int64_2);
        return (Class45) class63;
      }
    }
    throw new InvalidOperationException();
  }

  private static void smethod_8(ILGenerator ilgenerator_0, Type type_9)
  {
    if (!type_9.IsValueType && !Class25.smethod_0(type_9).IsGenericParameter)
      Class39.smethod_9(ilgenerator_0, type_9);
    else
      ilgenerator_0.Emit(OpCodes.Unbox_Any, type_9);
  }

  private void method_85(Class45 class45_2) => this.method_25(typeof (double));

  private void method_86(Class45 class45_2) => this.method_192(typeof (sbyte));

  private void method_87(Type type_9, object object_3, long long_1, Array array_0)
  {
    Class45 class45 = Class80.smethod_1(object_3, type_9);
    array_0.SetValue(class45.vmethod_0(), long_1);
  }

  private void method_88(Class45 class45_2)
  {
    Type type = this.method_257(((Class46) class45_2).method_2(), true);
    Class45 class45_2_1 = Class80.smethod_1(this.method_10().vmethod_0(), type);
    class45_2_1.method_1(type);
    this.method_176(class45_2_1);
  }

  private void method_89(Class45 class45_2) => this.method_263(true);

  private void method_90(Class45 class45_2) => this.method_183(typeof (double));

  private void method_91(bool bool_2)
  {
    Class45 class45 = this.method_10();
    byte int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = !bool_2 ? (byte) ((Class63) class45).method_2() : checked ((byte) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = !bool_2 ? (byte) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((byte) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = !bool_2 ? (byte) ((Class46) class45).method_2() : checked ((byte) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = !bool_2 ? (byte) ((Class48) class45).method_2() : checked ((byte) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2 = new Class46();
    class45_2.method_3((int) int_1);
    this.method_176((Class45) class45_2);
  }

  private void method_92(Class45 class45_2) => this.method_186(this.method_225(((Class46) class45_2).method_2()), false);

  private void method_93(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(5);
    this.method_176((Class45) class45_2_1);
  }

  private void method_94(Class45 class45_2)
  {
    object obj = this.method_10().vmethod_0();
    long long_1 = this.method_215();
    Array array_0 = (Array) this.method_10().vmethod_0();
    Type elementType = array_0.GetType().GetElementType();
    if ((object) elementType == (object) typeof (sbyte))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (sbyte));
      ((sbyte[]) array_0)[long_1] = (sbyte) class45.vmethod_0();
    }
    else if ((object) elementType == (object) typeof (byte))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (byte));
      ((byte[]) array_0)[long_1] = (byte) class45.vmethod_0();
    }
    else if ((object) elementType == (object) typeof (bool))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (bool));
      ((bool[]) array_0)[long_1] = (bool) class45.vmethod_0();
    }
    else if (elementType.IsEnum)
      this.method_87(elementType, obj, long_1, array_0);
    else
      this.method_87(typeof (sbyte), obj, long_1, array_0);
  }

  private string method_95(int int_0)
  {
    lock (Class39.dictionary_1)
    {
      bool flag = true;
      object obj;
      if (Class39.dictionary_1.TryGetValue(int_0, out obj))
        return (string) obj;
      Class33 class33 = this.method_169(int_0);
      if (class33.method_0() == (byte) 1)
        return this.module_0.ResolveString(class33.method_2());
      string str = ((Class32) class33.method_4()).method_0();
      if (flag)
        Class39.dictionary_1.Add(int_0, (object) str);
      return str;
    }
  }

  private void method_96(Class45 class45_2) => this.method_178(2);

  private void method_97(Class45 class45_2) => this.method_178(1);

  private Class45 method_98(Class45 class45_2, Class45 class45_3, bool bool_2, bool bool_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_3)
        {
          int num1 = ((Class46) class45_2).method_2();
          int num2 = ((Class46) class45_3).method_2();
          int int_1 = !bool_2 ? num1 - num2 : checked (num1 - num2);
          Class46 class46 = new Class46();
          class46.method_3(int_1);
          return (Class45) class46;
        }
        uint num3 = (uint) ((Class46) class45_2).method_2();
        uint num4 = (uint) ((Class46) class45_3).method_2();
        uint int_1_1 = !bool_2 ? num3 - num4 : checked (num3 - num4);
        Class46 class46_1 = new Class46();
        class46_1.method_3((int) int_1_1);
        return (Class45) class46_1;
      }
      if (class45_3.vmethod_2() == 3)
      {
        Class63 class45_2_1 = new Class63();
        class45_2_1.method_3((long) ((Class46) class45_2).method_2());
        return Class39.smethod_28((Class45) class45_2_1, class45_3, bool_2, bool_3);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_2 = class45_2;
          Class46 class45_3_1 = new Class46();
          class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num5 = bool_2 ? 1 : 0;
          int num6 = bool_3 ? 1 : 0;
          return this.method_98(class45_2_2, (Class45) class45_3_1, num5 != 0, num6 != 0);
        }
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3((long) ((Class46) class45_2).method_2());
        Class63 class45_3_2 = new Class63();
        class45_3_2.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        return Class39.smethod_28((Class45) class45_2_3, (Class45) class45_3_2, bool_2, bool_3);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
        return Class39.smethod_28(class45_2, class45_3, bool_2, bool_3);
      if (class45_3.vmethod_2() == 9)
      {
        Class45 class45_2_4 = class45_2;
        Class63 class45_3_3 = new Class63();
        class45_3_3.method_3((long) ((Class46) class45_3).method_2());
        int num7 = bool_2 ? 1 : 0;
        int num8 = bool_3 ? 1 : 0;
        return Class39.smethod_28(class45_2_4, (Class45) class45_3_3, num7 != 0, num8 != 0);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_5 = class45_2;
          Class46 class45_3_4 = new Class46();
          class45_3_4.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num9 = bool_2 ? 1 : 0;
          int num10 = bool_3 ? 1 : 0;
          return Class39.smethod_28(class45_2_5, (Class45) class45_3_4, num9 != 0, num10 != 0);
        }
        Class45 class45_2_6 = class45_2;
        Class63 class45_3_5 = new Class63();
        class45_3_5.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        int num11 = bool_2 ? 1 : 0;
        int num12 = bool_3 ? 1 : 0;
        return Class39.smethod_28(class45_2_6, (Class45) class45_3_5, num11 != 0, num12 != 0);
      }
    }
    if (class45_2.vmethod_2() == 16 && class45_3.vmethod_2() == 16)
    {
      Class48 class48 = new Class48();
      class48.method_3(((Class48) class45_2).method_2() - ((Class48) class45_3).method_2());
      return (Class45) class48;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_7 = new Class46();
      class45_2_7.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_98((Class45) class45_2_7, class45_3, bool_2, bool_3);
    }
    Class63 class45_2_8 = new Class63();
    class45_2_8.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_98((Class45) class45_2_8, class45_3, bool_2, bool_3);
  }

  private void method_99(Class45 class45_2) => this.method_192(this.method_257(((Class46) class45_2).method_2(), true));

  private Class45[] method_100()
  {
    Class19[] class19Array = this.class38_0.method_0();
    int length = class19Array.Length;
    Class45[] class45Array = new Class45[length];
    for (int index = 0; index < length; ++index)
      class45Array[index] = Class80.smethod_1((object) null, this.method_257(class19Array[index].method_0(), false));
    return class45Array;
  }

  private void method_101(Class45 class45_2)
  {
    object obj = this.method_10().vmethod_0();
    long long_1 = this.method_215();
    Array array_0 = (Array) this.method_10().vmethod_0();
    Type elementType = array_0.GetType().GetElementType();
    if ((object) elementType == (object) typeof (long))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (long));
      ((long[]) array_0)[long_1] = (long) class45.vmethod_0();
    }
    else if ((object) elementType == (object) typeof (ulong))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (ulong));
      ((ulong[]) array_0)[long_1] = (ulong) class45.vmethod_0();
    }
    else if (elementType.IsEnum)
      this.method_87(elementType, obj, long_1, array_0);
    else
      this.method_87(typeof (long), obj, long_1, array_0);
  }

  private void method_102(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    short int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = checked ((short) (ulong) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = checked ((short) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = checked ((short) (uint) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = checked ((short) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3((int) int_1);
    this.method_176((Class45) class45_2_1);
  }

  private Class27 method_103(BinaryReader binaryReader_1)
  {
    switch (binaryReader_1.ReadByte())
    {
      case 0:
        Class28 class28 = new Class28();
        class28.method_1(binaryReader_1.ReadInt32());
        class28.method_3(binaryReader_1.ReadInt32());
        return (Class27) class28;
      case 1:
        Class29 class29 = new Class29();
        Class33 class33_1_1 = new Class33();
        class33_1_1.method_1((byte) 0);
        class33_1_1.method_3(binaryReader_1.ReadInt32());
        class29.method_1(class33_1_1);
        class29.method_3(binaryReader_1.ReadString());
        class29.method_5(binaryReader_1.ReadBoolean());
        return (Class27) class29;
      case 2:
        Class31 class31_1 = new Class31();
        Class31 class31_2 = class31_1;
        Class33 class33_4_1 = new Class33();
        class33_4_1.method_1((byte) 0);
        class33_4_1.method_3(binaryReader_1.ReadInt32());
        class31_2.method_5(class33_4_1);
        class31_1.method_1(binaryReader_1.ReadByte());
        class31_1.method_7(binaryReader_1.ReadString());
        Class31 class31_3 = class31_1;
        Class33 class33_4_2 = new Class33();
        class33_4_2.method_1((byte) 0);
        class33_4_2.method_3(binaryReader_1.ReadInt32());
        class31_3.method_13(class33_4_2);
        int length1 = (int) binaryReader_1.ReadInt16();
        Class33[] class33_4_3 = new Class33[length1];
        for (int index1 = 0; index1 < length1; ++index1)
        {
          Class33[] class33Array = class33_4_3;
          int index2 = index1;
          Class33 class33 = new Class33();
          class33.method_1((byte) 0);
          class33.method_3(binaryReader_1.ReadInt32());
          class33Array[index2] = class33;
        }
        class31_1.method_9(class33_4_3);
        int length2 = (int) binaryReader_1.ReadInt16();
        Class33[] class33_4_4 = new Class33[length2];
        for (int index3 = 0; index3 < length2; ++index3)
        {
          Class33[] class33Array = class33_4_4;
          int index4 = index3;
          Class33 class33 = new Class33();
          class33.method_1((byte) 0);
          class33.method_3(binaryReader_1.ReadInt32());
          class33Array[index4] = class33;
        }
        class31_1.method_11(class33_4_4);
        return (Class27) class31_1;
      case 3:
        Class32 class32 = new Class32();
        class32.method_1(binaryReader_1.ReadString());
        return (Class27) class32;
      case 4:
        Class30 class30 = new Class30();
        class30.method_11(binaryReader_1.ReadInt32());
        class30.method_9(binaryReader_1.ReadInt32());
        class30.method_3(binaryReader_1.ReadBoolean());
        class30.method_1(binaryReader_1.ReadString());
        class30.method_5(binaryReader_1.ReadBoolean());
        int length3 = (int) binaryReader_1.ReadInt16();
        Class33[] class33_1_2 = new Class33[length3];
        for (int index5 = 0; index5 < length3; ++index5)
        {
          Class33[] class33Array = class33_1_2;
          int index6 = index5;
          Class33 class33 = new Class33();
          class33.method_1((byte) 0);
          class33.method_3(binaryReader_1.ReadInt32());
          class33Array[index6] = class33;
        }
        class30.method_7(class33_1_2);
        return (Class27) class30;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  private void method_104(ref Class39.Struct4 struct4_0)
  {
    if (!struct4_0.bool_0)
      return;
    Monitor.Exit(Class39.object_2);
  }

  private void method_105(Class45 class45_2) => this.method_176(this.class45_1[(int) ((Class69) class45_2).method_2()].vmethod_4());

  private Class45 method_106(Class45 class45_2)
  {
    if (class45_2.vmethod_2() == 9)
    {
      int num = ((Class46) class45_2).method_2();
      Class46 class46 = new Class46();
      class46.method_3(-num);
      return (Class45) class46;
    }
    if (class45_2.vmethod_2() == 3)
    {
      long num = ((Class63) class45_2).method_2();
      Class63 class63 = new Class63();
      class63.method_3(-num);
      return (Class45) class63;
    }
    if (class45_2.vmethod_2() == 16)
    {
      Class48 class48 = new Class48();
      class48.method_3(-((Class48) class45_2).method_2());
      return (Class45) class48;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_1 = new Class46();
      class45_2_1.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_106((Class45) class45_2_1);
    }
    Class63 class45_2_2 = new Class63();
    class45_2_2.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_106((Class45) class45_2_2);
  }

  private static void smethod_9(ILGenerator ilgenerator_0, Type type_9)
  {
    if ((object) type_9 == (object) Class20.type_0)
      return;
    ilgenerator_0.Emit(OpCodes.Castclass, type_9);
  }

  private void method_107(Class45 class45_2) => this.method_192(typeof (double));

  private void method_108(Class45 class45_2)
  {
  }

  private void method_109(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    if (!(class45_2_1.vmethod_2() != 16 ? !Class39.smethod_24(class45_2_1, class45_3) : !Class39.smethod_0(class45_2_1, class45_3)))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_110(ref Class39.Struct4 struct4_0, MethodBase methodBase_0, bool bool_2)
  {
    bool flag = false;
    if ((object) methodBase_0.DeclaringType == (object) typeof (Interlocked) && methodBase_0.IsStatic)
    {
      string name = methodBase_0.Name;
      if (name == "Add" || name == "CompareExchange" || name == "Decrement" || name == "Exchange" || name == "Increment" || name == "Read")
        flag = true;
    }
    if (!flag)
      return;
    try
    {
    }
    finally
    {
      Monitor.Enter(Class39.object_2);
      struct4_0.bool_0 = true;
    }
  }

  private static Class45 smethod_10(
    Class45 class45_2,
    Class45 class45_3,
    bool bool_2,
    bool bool_3)
  {
    if (!bool_3)
    {
      long num1 = ((Class63) class45_2).method_2();
      long num2 = ((Class63) class45_3).method_2();
      long long_1 = !bool_2 ? num1 * num2 : checked (num1 * num2);
      Class63 class63 = new Class63();
      class63.method_3(long_1);
      return (Class45) class63;
    }
    ulong num3 = (ulong) ((Class63) class45_2).method_2();
    ulong num4 = (ulong) ((Class63) class45_3).method_2();
    ulong long_1_1 = !bool_2 ? num3 * num4 : checked (num3 * num4);
    Class63 class63_1 = new Class63();
    class63_1.method_3((long) long_1_1);
    return (Class45) class63_1;
  }

  private void method_111(Class45 class45_2) => this.method_183(typeof (ushort));

  private void method_112(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_98(this.method_10(), class45_3, false, false));
  }

  private void method_113(Class45 class45_2) => this.method_192(Class39.type_1);

  private static byte[] smethod_11(BinaryReader binaryReader_1)
  {
    int count = binaryReader_1.ReadInt32();
    byte[] buffer = new byte[count];
    binaryReader_1.Read(buffer, 0, count);
    return buffer;
  }

  private bool method_114(
    MethodBase methodBase_0,
    object object_3,
    Class45[] class45_2,
    object[] object_4,
    bool bool_2,
    ref object object_5)
  {
    Type declaringType = methodBase_0.DeclaringType;
    if ((object) declaringType == null || (object) declaringType != (object) Class39.type_4 || !(methodBase_0.Name == "InitializeArray") || object_4.Length != 2 || !(methodBase_0.ToString() == "Void InitializeArray(System.Array, System.RuntimeFieldHandle)"))
      return false;
    Class81.smethod_0((Array) object_4[0], (RuntimeFieldHandle) object_4[1]);
    return true;
  }

  private void method_115(Class45 class45_2) => this.method_176(this.class45_1[2].vmethod_4());

  private void method_116(Class45 class45_2) => this.method_294(true);

  private void method_117(Class45 class45_2)
  {
    FieldInfo fieldInfo = this.method_229(((Class46) class45_2).method_2());
    Class45 class45_1 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    object object_0 = !class45_2_1.vmethod_5() ? class45_2_1.vmethod_0() : this.method_219(class45_2_1).vmethod_0();
    if (object_0 == null)
      throw new NullReferenceException();
    Class45 class45_3 = Class80.smethod_1(class45_1.vmethod_0(), fieldInfo.FieldType);
    fieldInfo.SetValue(object_0, class45_3.vmethod_0());
    if (!class45_2_1.vmethod_5() || object_0 == null || !object_0.GetType().IsValueType)
      return;
    this.method_4(class45_2_1, Class80.smethod_1(object_0, (Type) null));
  }

  private static bool smethod_12() => false;

  private void method_118(Class45 class45_2)
  {
    object obj = this.method_10().vmethod_0();
    long long_1 = this.method_215();
    Array array_0 = (Array) this.method_10().vmethod_0();
    Type elementType = array_0.GetType().GetElementType();
    if ((object) elementType == (object) typeof (int))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (int));
      ((int[]) array_0)[long_1] = (int) class45.vmethod_0();
    }
    else if ((object) elementType == (object) typeof (uint))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (uint));
      ((uint[]) array_0)[long_1] = (uint) class45.vmethod_0();
    }
    else if (elementType.IsEnum)
      this.method_87(elementType, obj, long_1, array_0);
    else
      this.method_87(typeof (int), obj, long_1, array_0);
  }

  private void method_119(Class45 class45_2)
  {
    Type type_2 = this.method_257(((Class46) class45_2).method_2(), true);
    long long_1 = this.method_215();
    Array array_1 = (Array) this.method_10().vmethod_0();
    Class58 class45_2_1 = new Class58();
    class45_2_1.method_5(array_1);
    class45_2_1.method_3(type_2);
    class45_2_1.method_7(long_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_120(Class45 class45_2)
  {
    MethodBase methodBase_0 = this.method_225(((Class46) class45_2).method_2());
    foreach (Class45 class45_2_1 in this.class45_0)
      this.method_176(class45_2_1);
    this.method_186(methodBase_0, false);
  }

  private void method_121(Class45 class45_2) => this.method_192(typeof (long));

  private void method_122(bool bool_2)
  {
    Class45 class45 = this.method_10();
    int int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = !bool_2 ? (int) ((Class63) class45).method_2() : checked ((int) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = !bool_2 ? (int) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((int) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = !bool_2 ? ((Class46) class45).method_2() : ((Class46) class45).method_2();
        break;
      case 16:
        int_1 = !bool_2 ? (int) ((Class48) class45).method_2() : checked ((int) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2 = new Class46();
    class45_2.method_3(int_1);
    this.method_176((Class45) class45_2);
  }

  private Class75 method_123(BinaryReader binaryReader_1)
  {
    Class75 class75 = new Class75();
    class75.method_1(binaryReader_1.ReadInt32());
    class75.method_3(binaryReader_1.ReadBoolean());
    return class75;
  }

  [DebuggerNonUserCode]
  private MethodBase method_124(int int_0, Class33 class33_0)
  {
    lock (Class39.dictionary_1)
    {
      bool flag1 = true;
      object obj;
      if (Class39.dictionary_1.TryGetValue(int_0, out obj))
        return (MethodBase) obj;
      if (class33_0.method_0() == (byte) 1)
      {
        MethodBase methodBase = this.module_0.ResolveMethod(class33_0.method_2());
        if (flag1)
          Class39.dictionary_1.Add(int_0, (object) methodBase);
        return methodBase;
      }
      Class31 class31_0 = (Class31) class33_0.method_4();
      if (class31_0.method_3())
        return this.method_61(class31_0);
      Type type1 = this.method_257(class31_0.method_4().method_2(), false);
      Type type2 = this.method_257(class31_0.method_12().method_2(), true);
      Type[] types = new Type[class31_0.method_8().Length];
      for (int index = 0; index < types.Length; ++index)
        types[index] = this.method_257(class31_0.method_8()[index].method_2(), true);
      if (type1.IsGenericType)
        flag1 = false;
      if (class31_0.method_6() == ".ctor")
      {
        ConstructorInfo constructor = type1.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, CallingConventions.Any, types, (ParameterModifier[]) null);
        if ((object) constructor == null)
          throw new Exception();
        if (flag1)
          Class39.dictionary_1.Add(int_0, (object) constructor);
        return (MethodBase) constructor;
      }
      BindingFlags bindingAttr = Class39.smethod_1(class31_0.method_2());
      MethodBase methodBase1 = (MethodBase) null;
      try
      {
        methodBase1 = (MethodBase) type1.GetMethod(class31_0.method_6(), bindingAttr, (Binder) null, CallingConventions.Any, types, (ParameterModifier[]) null);
      }
      catch (AmbiguousMatchException ex)
      {
        foreach (MethodInfo method in type1.GetMethods(bindingAttr))
        {
          if (!(method.Name != class31_0.method_6()) && (object) method.ReturnType == (object) type2)
          {
            ParameterInfo[] parameters = method.GetParameters();
            if (parameters.Length == types.Length)
            {
              bool flag2 = false;
              for (int index = 0; index < types.Length; ++index)
              {
                if ((object) parameters[index].ParameterType != (object) types[index])
                {
                  flag2 = true;
                  break;
                }
              }
              if (!flag2)
              {
                methodBase1 = (MethodBase) method;
                break;
              }
            }
          }
        }
      }
      if ((object) methodBase1 == null)
        throw new Exception(string.Format("Cannot bind method: {0}.{1}", (object) type1.Name, (object) class31_0.method_6()));
      if (flag1)
        Class39.dictionary_1.Add(int_0, (object) methodBase1);
      return methodBase1;
    }
  }

  private void method_125(Class45 class45_2) => this.method_176(this.class45_1[0].vmethod_4());

  private void method_126(Class45 class45_2) => this.method_183(typeof (long));

  private object method_127(
    MethodBase methodBase_0,
    object object_3,
    object[] object_4,
    bool bool_2)
  {
    Class39.Struct3 struct3_0 = new Class39.Struct3(methodBase_0, bool_2);
    Class39.Delegate2 delegate2 = this.method_168(struct3_0);
    if (delegate2 == null)
    {
      bool flag;
      lock (this.dictionary_3)
      {
        int num;
        this.dictionary_3.TryGetValue(methodBase_0, out num);
        if (!(flag = num >= 50))
          this.dictionary_3[methodBase_0] = num + 1;
      }
      if (!flag && !bool_2 && object_3 == null && !methodBase_0.IsStatic && !methodBase_0.IsConstructor)
        flag = true;
      if (!flag && Class39.smethod_19(methodBase_0))
        flag = true;
      if (!flag)
        return this.method_157(methodBase_0, object_3, object_4);
      delegate2 = this.method_131(struct3_0);
      lock (this.dictionary_3)
        this.dictionary_3.Remove(methodBase_0);
    }
    return delegate2(object_3, object_4);
  }

  private void method_128(Class45 class45_2)
  {
    MethodBase methodBase_0 = this.method_225(((Class46) class45_2).method_2());
    if ((object) this.type_3 != null)
    {
      ParameterInfo[] parameters = methodBase_0.GetParameters();
      Type[] types = new Type[parameters.Length];
      int num = 0;
      foreach (ParameterInfo parameterInfo in parameters)
        types[num++] = parameterInfo.ParameterType;
      MethodInfo method = this.type_3.GetMethod(methodBase_0.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, (Binder) null, types, (ParameterModifier[]) null);
      if ((object) method != null)
        methodBase_0 = (MethodBase) method;
      this.type_3 = (Type) null;
    }
    this.method_186(methodBase_0, true);
  }

  private void method_129(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    int int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = checked ((int) (ulong) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = checked ((int) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = checked ((int) (uint) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = checked ((int) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(int_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_130(Class45 class45_2) => throw new NotSupportedException("Refanyval is not supported.");

  private Class39.Delegate2 method_131(Class39.Struct3 struct3_0)
  {
    Class39.Delegate2 delegate2;
    lock (this.dictionary_0)
      this.dictionary_0.TryGetValue(struct3_0, out delegate2);
    if (delegate2 != null)
      return delegate2;
    MethodBase methodBase = struct3_0.method_0();
    lock (this.dictionary_4)
    {
      while (this.dictionary_4.ContainsKey(methodBase))
        Monitor.Wait((object) this.dictionary_4);
      this.dictionary_4[methodBase] = (object) null;
    }
    try
    {
      lock (this.dictionary_0)
        this.dictionary_0.TryGetValue(struct3_0, out delegate2);
      if (delegate2 == null)
      {
        delegate2 = this.method_298(methodBase, struct3_0.method_1());
        lock (this.dictionary_0)
          this.dictionary_0[struct3_0] = delegate2;
      }
      return delegate2;
    }
    finally
    {
      lock (this.dictionary_4)
      {
        this.dictionary_4.Remove(methodBase);
        Monitor.PulseAll((object) this.dictionary_4);
      }
    }
  }

  private void method_132(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_262(this.method_10(), class45_3, true, false));
  }

  private void method_133(bool bool_2)
  {
    Class45 class45 = this.method_10();
    IntPtr intptr_1;
    switch (class45.vmethod_2())
    {
      case 3:
        intptr_1 = !bool_2 ? new IntPtr(((Class63) class45).method_2()) : new IntPtr(((Class63) class45).method_2());
        break;
      case 7:
        intptr_1 = !bool_2 ? new IntPtr((long) Convert.ToUInt64((object) ((Class59) class45).method_2())) : new IntPtr(checked ((long) Convert.ToUInt64((object) ((Class59) class45).method_2())));
        break;
      case 9:
        intptr_1 = !bool_2 ? new IntPtr(((Class46) class45).method_2()) : new IntPtr(((Class46) class45).method_2());
        break;
      case 16:
        intptr_1 = !bool_2 ? new IntPtr((long) ((Class48) class45).method_2()) : new IntPtr(checked ((long) ((Class48) class45).method_2()));
        break;
      default:
        throw new InvalidOperationException();
    }
    Class67 class45_2 = new Class67();
    class45_2.method_3(intptr_1);
    this.method_176((Class45) class45_2);
  }

  private void method_134(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    Class46 class45_2_2 = new Class46();
    class45_2_2.method_3(Class39.smethod_15(class45_2_1, class45_3) ? 1 : 0);
    this.method_176((Class45) class45_2_2);
  }

  private void method_135(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_57(this.method_10(), class45_3, false));
  }

  private static string smethod_13(string string_0, string string_1)
  {
    string fullName = typeof (Class39).Assembly.FullName;
    return string.Format("Attempt by {0} to access {1} failed.", (object) string_0, (object) string_1) + Environment.NewLine + Environment.NewLine + string.Format("Assembly '{0}' is marked with the AllowPartiallyTrustedCallersAttribute, and uses the level 2 security transparency model. ", (object) fullName) + "Level 2 transparency causes all methods in AllowPartiallyTrustedCallers assemblies to become security transparent by default, which may be the cause of this exception.";
  }

  private void method_136(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (!Class39.smethod_14(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_137(Class45 class45_2) => this.method_192(typeof (int));

  private void method_138(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(3);
    this.method_176((Class45) class45_2_1);
  }

  private void method_139(Class45 class45_2)
  {
    Class48 class45_2_1 = (Class48) this.method_10();
    if (double.IsNaN(class45_2_1.method_2()) || double.IsInfinity(class45_2_1.method_2()))
      throw new OverflowException("The value is not finite real number.");
    this.method_176((Class45) class45_2_1);
  }

  private void method_140(Class45 class45_2) => this.method_44();

  private object method_141(int int_0)
  {
    object obj;
    switch (Class76.smethod_0(int_0))
    {
      case 16777216:
      case 33554432:
      case 452984832:
        obj = (object) this.module_0.ModuleHandle.ResolveTypeHandle(int_0);
        break;
      case 67108864:
        obj = (object) this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
        break;
      case 100663296:
      case 721420288:
        obj = (object) this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
        break;
      case 167772160:
        try
        {
          obj = (object) this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
          break;
        }
        catch
        {
          try
          {
            obj = (object) this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
            break;
          }
          catch
          {
            throw new InvalidOperationException();
          }
        }
      default:
        throw new InvalidOperationException();
    }
    return obj;
  }

  private void method_142(Class45 class45_2) => this.method_183(typeof (int));

  private bool method_143(Class45 class45_2, Type type_9)
  {
    if (class45_2.vmethod_0() == null)
      return true;
    Type type = class45_2.method_0();
    if ((object) type == null)
      type = class45_2.vmethod_0().GetType();
    Type c = type;
    if ((object) c == (object) type_9 || type_9.IsAssignableFrom(c))
      return true;
    if (!c.IsValueType && !type_9.IsValueType)
    {
      if (Marshal.IsComObject(class45_2.vmethod_0()))
      {
        IntPtr pUnk;
        try
        {
          pUnk = Marshal.GetComInterfaceForObject(class45_2.vmethod_0(), type_9);
        }
        catch (InvalidCastException ex)
        {
          pUnk = IntPtr.Zero;
        }
        if (pUnk != IntPtr.Zero)
        {
          try
          {
            Marshal.Release(pUnk);
          }
          catch
          {
          }
          return true;
        }
      }
    }
    return false;
  }

  private void method_144(Class45 class45_2) => this.method_170(false);

  private bool method_145(
    MethodBase methodBase_0,
    object object_3,
    ref object object_4,
    object[] object_5)
  {
    Type declaringType = methodBase_0.DeclaringType;
    if ((object) declaringType == null)
      return false;
    if (Class20.smethod_0(declaringType))
    {
      if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
        object_4 = (object) (object_3 != null);
      else if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
      {
        if (object_3 == null)
          return new bool?().Value;
        object_4 = object_3;
      }
      else if (methodBase_0.Name.Equals("GetValueOrDefault", StringComparison.Ordinal))
      {
        if (object_3 == null)
          object_4 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
        object_4 = object_3;
      }
      else
      {
        if (object_3 != null || methodBase_0.IsStatic)
          return false;
        object_4 = (object) null;
      }
      return true;
    }
    if ((object) declaringType == (object) Class20.type_2)
    {
      string name = methodBase_0.Name;
      switch (object_5.Length)
      {
        case 1:
          switch (name)
          {
            case "GetTargetType":
              object_4 = (object) TypedReference.GetTargetType((TypedReference) object_5[0]);
              return true;
            case "TargetTypeToken":
              object_4 = (object) TypedReference.TargetTypeToken((TypedReference) object_5[0]);
              return true;
            case "ToObject":
              object_4 = TypedReference.ToObject((TypedReference) object_5[0]);
              return true;
          }
          break;
        case 2:
          if (name == "SetTypedReference")
          {
            TypedReference.SetTypedReference((TypedReference) object_5[0], object_5[1]);
            return true;
          }
          break;
      }
    }
    else if ((object) declaringType == (object) Class39.type_2)
    {
      if (this.object_0 != null && methodBase_0.Name == "GetCallingAssembly")
      {
        foreach (object obj in this.object_0)
        {
          Assembly assembly = obj as Assembly;
          if ((object) assembly != null)
          {
            object_4 = (object) assembly;
            return true;
          }
        }
      }
    }
    else if ((object) declaringType == (object) Class39.type_6)
    {
      if (methodBase_0.Name == "GetCurrentMethod")
      {
        if (this.object_0 != null)
        {
          foreach (object obj in this.object_0)
          {
            MethodBase methodBase = obj as MethodBase;
            if ((object) methodBase != null)
            {
              object_4 = (object) methodBase;
              return true;
            }
          }
        }
        object_4 = (object) MethodBase.GetCurrentMethod();
        return true;
      }
    }
    else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
      return this.method_20(methodBase_0, object_3, ref object_4, object_5);
    return false;
  }

  private void method_146(Class45 class45_2) => this.method_176(this.class45_0[1].vmethod_4());

  private static bool smethod_14(Class45 class45_2, Class45 class45_3)
  {
    bool flag = false;
    switch (class45_2.vmethod_2())
    {
      case 3:
        if (class45_3.vmethod_2() == 7)
        {
          Class45 class45_2_1 = class45_2;
          Class63 class45_3_1 = new Class63();
          class45_3_1.method_3(Convert.ToInt64((object) ((Class59) class45_3).method_2()));
          return Class39.smethod_14(class45_2_1, (Class45) class45_3_1);
        }
        if (class45_3.vmethod_2() == 9)
        {
          Class45 class45_2_2 = class45_2;
          Class63 class45_3_2 = new Class63();
          class45_3_2.method_3((long) ((Class46) class45_3).method_2());
          return Class39.smethod_14(class45_2_2, (Class45) class45_3_2);
        }
        flag = ((Class63) class45_2).method_2() < ((Class63) class45_3).method_2();
        break;
      case 7:
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3(Convert.ToInt64((object) ((Class59) class45_2).method_2()));
        return Class39.smethod_14((Class45) class45_2_3, class45_3);
      case 9:
        if (class45_3.vmethod_2() == 7)
        {
          Class45 class45_2_4 = class45_2;
          Class46 class45_3_3 = new Class46();
          class45_3_3.method_3(Convert.ToInt32((object) ((Class59) class45_3).method_2()));
          return Class39.smethod_14(class45_2_4, (Class45) class45_3_3);
        }
        flag = ((Class46) class45_2).method_2() < ((Class46) class45_3).method_2();
        break;
      case 16:
        flag = ((Class48) class45_2).method_2() < ((Class48) class45_3).method_2();
        break;
    }
    return flag;
  }

  private void method_147(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    uint int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = checked ((uint) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = checked ((uint) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = checked ((uint) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = checked ((uint) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3((int) int_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_148(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (Class39.smethod_14(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_149(Class45 class45_2) => this.method_176(this.method_106(this.method_10()));

  private void method_150(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(7);
    this.method_176((Class45) class45_2_1);
  }

  private void method_151(Class45 class45_2) => this.method_184(this.method_10().vmethod_0());

  private Class45 method_152(Class45 class45_2)
  {
    if (class45_2.vmethod_2() == 9)
    {
      int num = ((Class46) class45_2).method_2();
      Class46 class46 = new Class46();
      class46.method_3(~num);
      return (Class45) class46;
    }
    if (class45_2.vmethod_2() == 3)
    {
      long num = ((Class63) class45_2).method_2();
      Class63 class63 = new Class63();
      class63.method_3(~num);
      return (Class45) class63;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      int int32 = Convert.ToInt32(class45_2.vmethod_0());
      Class46 class46 = new Class46();
      class46.method_3(~int32);
      return (Class45) class46;
    }
    long int64 = Convert.ToInt64(class45_2.vmethod_0());
    Class63 class63_1 = new Class63();
    class63_1.method_3(~int64);
    return (Class45) class63_1;
  }

  private void method_153(Class45 class45_2) => this.method_178(0);

  private void method_154(Class45 class45_2) => this.type_3 = this.method_257(((Class46) class45_2).method_2(), true);

  private void method_155(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (Class39.smethod_27(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_156(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    ulong long_1;
    switch (class45.vmethod_2())
    {
      case 3:
        long_1 = checked ((ulong) ((Class63) class45).method_2());
        break;
      case 7:
        long_1 = Convert.ToUInt64((object) ((Class59) class45).method_2());
        break;
      case 9:
        long_1 = checked ((ulong) ((Class46) class45).method_2());
        break;
      case 16:
        long_1 = checked ((ulong) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class63 class45_2_1 = new Class63();
    class45_2_1.method_3((long) long_1);
    this.method_176((Class45) class45_2_1);
  }

  private static bool smethod_15(Class45 class45_2, Class45 class45_3)
  {
    bool flag = false;
    switch (class45_2.vmethod_2())
    {
      case 2:
        flag = class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null ? (class45_3.vmethod_2() != 9 ? (class45_3.vmethod_2() != 3 ? ((Class67) class45_2).method_2() == ((Class67) class45_3).method_2() : ((Class67) class45_2).method_2() == new IntPtr(((Class63) class45_3).method_2())) : ((Class67) class45_2).method_2() == new IntPtr(((Class46) class45_3).method_2())) : ((Class67) class45_2).method_2() == IntPtr.Zero;
        break;
      case 3:
        flag = class45_3.vmethod_2() != 7 ? (class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null ? ((Class63) class45_2).method_2() == ((Class63) class45_3).method_2() : ((Class63) class45_2).method_2() == 0L) : ((Class63) class45_2).method_2() == Convert.ToInt64((object) ((Class59) class45_3).method_2());
        break;
      case 5:
        flag = class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null ? (class45_3.vmethod_2() != 9 ? (class45_3.vmethod_2() != 3 ? ((Class65) class45_2).method_2() == ((Class65) class45_3).method_2() : ((Class65) class45_2).method_2() == new UIntPtr((ulong) ((Class63) class45_3).method_2())) : ((Class65) class45_2).method_2() == new UIntPtr((uint) ((Class46) class45_3).method_2())) : ((Class65) class45_2).method_2() == UIntPtr.Zero;
        break;
      case 6:
        Class53 class53_1 = (Class53) class45_2;
        Class53 class53_2 = (Class53) class45_3;
        flag = Class39.smethod_15(class53_1.method_2(), class53_2.method_2());
        break;
      case 7:
        Class59 class59 = (Class59) class45_2;
        if (class45_3.vmethod_2() == 7)
        {
          flag = Convert.ToInt64((object) class59.method_2()) == Convert.ToInt64((object) ((Class59) class45_3).method_2());
          break;
        }
        if (class59.method_2() == null)
        {
          flag = class45_3.vmethod_0() == null;
          break;
        }
        if (class45_3.vmethod_0() != null)
        {
          flag = Convert.ToInt64((object) class59.method_2()) == Convert.ToInt64(class45_3.vmethod_0());
          break;
        }
        break;
      case 9:
        flag = class45_3.vmethod_2() != 7 ? (class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null ? ((Class46) class45_2).method_2() == ((Class46) class45_3).method_2() : ((Class46) class45_2).method_2() == 0) : (long) ((Class46) class45_2).method_2() == Convert.ToInt64((object) ((Class59) class45_3).method_2());
        break;
      case 12:
        Class55 class55_1 = (Class55) class45_2;
        Class55 class55_2 = (Class55) class45_3;
        flag = class55_1.method_2() == class55_2.method_2() && (object) class55_1.method_4() == (object) class55_2.method_4();
        break;
      case 16:
        double d1 = ((Class48) class45_2).method_2();
        double d2 = ((Class48) class45_3).method_2();
        flag = !double.IsNaN(d1) && !double.IsNaN(d2) && d1.Equals(d2);
        break;
      case 17:
      case 21:
        flag = ((Class56) class45_2).vmethod_8((Class56) class45_3);
        break;
      case 19:
        Class54 class54_1 = (Class54) class45_2;
        Class54 class54_2 = (Class54) class45_3;
        flag = class54_1.method_2() == class54_2.method_2();
        break;
      case 20:
        flag = class45_2.vmethod_0() == class45_3.vmethod_0();
        break;
      case 24:
        flag = (class45_3.vmethod_2() != 20 || class45_3.vmethod_0() != null) && ((Class71) class45_2).method_2() == ((Class71) class45_3).method_2();
        break;
      default:
        flag = class45_2.vmethod_0() == class45_3.vmethod_0();
        break;
    }
    return flag;
  }

  private object method_157(MethodBase methodBase_0, object object_3, object[] object_4) => methodBase_0.IsConstructor ? Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, object_4, (CultureInfo) null) : methodBase_0.Invoke(object_3, object_4);

  private void method_158(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    UIntPtr uintptr_1;
    switch (class45.vmethod_2())
    {
      case 3:
        uintptr_1 = new UIntPtr((ulong) ((Class63) class45).method_2());
        break;
      case 7:
        uintptr_1 = new UIntPtr(Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        uintptr_1 = new UIntPtr((uint) ((Class46) class45).method_2());
        break;
      case 16:
        uintptr_1 = new UIntPtr((ulong) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class65 class45_2_1 = new Class65();
    class45_2_1.method_3(uintptr_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_159(object object_3, uint uint_0)
  {
    bool flag = object_3 != null;
    this.object_1 = object_3;
    if (flag)
      this.class16_1.method_0();
    this.bool_0 = flag;
    if (!flag)
      this.class16_1.method_7(new Class39.Struct5(uint_0));
    foreach (Class34 class34 in this.class34_0)
    {
      if (this.method_56(this.long_0, class34.method_8(), class34.method_6()))
      {
        switch (class34.method_2())
        {
          case 0:
            if (flag)
            {
              Type type = object_3.GetType();
              Type c = this.method_257(class34.method_0(), true);
              if ((object) type == (object) c || type.IsSubclassOf(c))
              {
                this.class16_1.method_7(new Class39.Struct5(class34.method_4(), object_3));
                this.bool_0 = false;
                continue;
              }
              continue;
            }
            continue;
          case 1:
            if (flag || !this.method_56((long) uint_0, class34.method_8(), class34.method_6()))
            {
              this.class16_1.method_7(new Class39.Struct5(class34.method_4()));
              continue;
            }
            continue;
          case 2:
            if (flag)
            {
              this.class16_1.method_7(new Class39.Struct5(class34.method_4()));
              continue;
            }
            continue;
          case 4:
            if (flag)
            {
              this.class16_1.method_7(new Class39.Struct5(class34.method_10(), object_3));
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }
    this.method_44();
  }

  private void method_160(uint uint_0) => this.nullable_0 = new uint?(uint_0);

  private Class45 method_161(Class45 class45_2, Class45 class45_3, bool bool_2)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_2)
        {
          int num1 = ((Class46) class45_2).method_2();
          int num2 = ((Class46) class45_3).method_2();
          Class46 class46 = new Class46();
          class46.method_3(num1 / num2);
          return (Class45) class46;
        }
        uint num3 = (uint) ((Class46) class45_2).method_2();
        uint num4 = (uint) ((Class46) class45_3).method_2();
        Class46 class46_1 = new Class46();
        class46_1.method_3((int) (num3 / num4));
        return (Class45) class46_1;
      }
      if (class45_3.vmethod_2() == 3)
      {
        Class63 class45_2_1 = new Class63();
        class45_2_1.method_3((long) ((Class46) class45_2).method_2());
        return Class39.smethod_21((Class45) class45_2_1, class45_3, bool_2);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_2 = class45_2;
          Class46 class45_3_1 = new Class46();
          class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num = bool_2 ? 1 : 0;
          return this.method_161(class45_2_2, (Class45) class45_3_1, num != 0);
        }
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3((long) ((Class46) class45_2).method_2());
        Class63 class45_3_2 = new Class63();
        class45_3_2.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        return Class39.smethod_21((Class45) class45_2_3, (Class45) class45_3_2, bool_2);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
        return Class39.smethod_21(class45_2, class45_3, bool_2);
      if (class45_3.vmethod_2() == 9)
      {
        Class45 class45_2_4 = class45_2;
        Class63 class45_3_3 = new Class63();
        class45_3_3.method_3((long) ((Class46) class45_3).method_2());
        int num = bool_2 ? 1 : 0;
        return Class39.smethod_21(class45_2_4, (Class45) class45_3_3, num != 0);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_5 = class45_2;
          Class46 class45_3_4 = new Class46();
          class45_3_4.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num = bool_2 ? 1 : 0;
          return Class39.smethod_21(class45_2_5, (Class45) class45_3_4, num != 0);
        }
        Class45 class45_2_6 = class45_2;
        Class63 class45_3_5 = new Class63();
        class45_3_5.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        int num5 = bool_2 ? 1 : 0;
        return Class39.smethod_21(class45_2_6, (Class45) class45_3_5, num5 != 0);
      }
    }
    if (class45_2.vmethod_2() == 16 && class45_3.vmethod_2() == 16)
    {
      Class48 class48 = new Class48();
      class48.method_3(((Class48) class45_2).method_2() / ((Class48) class45_3).method_2());
      return (Class45) class48;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_7 = new Class46();
      class45_2_7.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_161((Class45) class45_2_7, class45_3, bool_2);
    }
    Class63 class45_2_8 = new Class63();
    class45_2_8.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_161((Class45) class45_2_8, class45_3, bool_2);
  }

  private void method_162(Class45 class45_2) => this.method_183(typeof (float));

  private void method_163(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(4);
    this.method_176((Class45) class45_2_1);
  }

  private Class17 method_164(int int_0)
  {
    foreach (Class17 class17 in this.class35_0.method_0())
    {
      if (class17.method_0() == int_0)
        return class17;
    }
    return (Class17) null;
  }

  private void method_165(Class45 class45_2) => this.method_176(class45_2);

  private void method_166()
  {
    try
    {
      this.method_218();
    }
    catch (object ex)
    {
      this.method_159(ex, 0U);
    }
  }

  private void method_167(Class45 class45_2) => this.method_238();

  private Class39.Delegate2 method_168(Class39.Struct3 struct3_0)
  {
    Class39.Delegate2 delegate2;
    lock (this.dictionary_0)
      this.dictionary_0.TryGetValue(struct3_0, out delegate2);
    return delegate2;
  }

  private Class33 method_169(int int_0)
  {
    if (this.binaryReader_0 == null)
      throw new InvalidOperationException();
    lock (this.binaryReader_0.BaseStream)
    {
      this.binaryReader_0.BaseStream.Seek((long) int_0, SeekOrigin.Begin);
      Class33 class33 = new Class33();
      class33.method_1(this.binaryReader_0.ReadByte());
      if (class33.method_0() == (byte) 1)
        class33.method_3(this.binaryReader_0.ReadInt32());
      else
        class33.method_5(this.method_103(this.binaryReader_0));
      return class33;
    }
  }

  private void method_170(bool bool_2)
  {
    Class45 class45 = this.method_10();
    short int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = !bool_2 ? (short) ((Class63) class45).method_2() : checked ((short) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = !bool_2 ? (short) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((short) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = !bool_2 ? (short) ((Class46) class45).method_2() : checked ((short) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = !bool_2 ? (short) ((Class48) class45).method_2() : checked ((short) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2 = new Class46();
    class45_2.method_3((int) int_1);
    this.method_176((Class45) class45_2);
  }

  private void method_171(Class45 class45_2)
  {
    Type type = this.method_257(((Class46) class45_2).method_2(), true);
    Class45 class45_2_1 = this.method_10();
    if (type.IsValueType)
    {
      object obj = this.method_219(class45_2_1).vmethod_0();
      if (Class20.smethod_0(type))
      {
        Class45 class45_2_2 = class45_2_1;
        Class49 class45_3 = new Class49();
        class45_3.method_1(type);
        this.method_4(class45_2_2, (Class45) class45_3);
      }
      else
      {
        foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
          field.SetValue(obj, Class39.smethod_29(field.FieldType));
      }
    }
    else
      this.method_4(class45_2_1, (Class45) new Class49());
  }

  private static Class34[] smethod_16(BinaryReader binaryReader_1)
  {
    int length = (int) binaryReader_1.ReadInt16();
    Class34[] class34Array = new Class34[length];
    for (int index = 0; index < length; ++index)
      class34Array[index] = Class39.smethod_2(binaryReader_1);
    return class34Array;
  }

  private void method_172(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (!Class39.smethod_27(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_173(Class45 class45_2) => this.method_263(false);

  private void method_174(bool bool_2)
  {
    Class45 class45 = this.method_10();
    ulong long_1;
    switch (class45.vmethod_2())
    {
      case 3:
        long_1 = !bool_2 ? (ulong) ((Class63) class45).method_2() : checked ((ulong) ((Class63) class45).method_2());
        break;
      case 7:
        long_1 = !bool_2 ? Convert.ToUInt64((object) ((Class59) class45).method_2()) : Convert.ToUInt64((object) ((Class59) class45).method_2());
        break;
      case 9:
        long_1 = !bool_2 ? (ulong) (uint) ((Class46) class45).method_2() : checked ((ulong) ((Class46) class45).method_2());
        break;
      case 16:
        long_1 = !bool_2 ? (ulong) ((Class48) class45).method_2() : checked ((ulong) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class63 class45_2 = new Class63();
    class45_2.method_3((long) long_1);
    this.method_176((Class45) class45_2);
  }

  private void method_175(Class45 class45_2) => this.method_174(false);

  private void method_176(Class45 class45_2)
  {
    if (class45_2 == null)
      throw new ArgumentNullException("obj");
    Class45 gparam_1;
    if ((object) class45_2.method_0() != null)
    {
      gparam_1 = class45_2;
    }
    else
    {
      switch (class45_2.vmethod_2())
      {
        case 0:
          Class46 class46_1 = new Class46();
          class46_1.method_3((int) ((Class51) class45_2).method_2());
          class46_1.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_1;
          break;
        case 1:
          Class63 class63 = new Class63();
          class63.method_3((long) ((Class62) class45_2).method_2());
          class63.method_1(class45_2.method_0());
          gparam_1 = (Class45) class63;
          break;
        case 4:
          Class46 class46_2 = new Class46();
          class46_2.method_3((int) ((Class69) class45_2).method_2());
          class46_2.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_2;
          break;
        case 10:
          Class46 class46_3 = new Class46();
          class46_3.method_3((int) ((Class72) class45_2).method_2());
          class46_3.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_3;
          break;
        case 11:
          Class46 class46_4 = new Class46();
          class46_4.method_3((int) ((Class64) class45_2).method_2());
          class46_4.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_4;
          break;
        case 14:
          Class46 class46_5 = new Class46();
          class46_5.method_3((int) ((Class70) class45_2).method_2());
          class46_5.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_5;
          break;
        case 15:
          Class48 class48 = new Class48();
          class48.method_3((double) ((Class50) class45_2).method_2());
          class48.method_1(class45_2.method_0());
          gparam_1 = (Class45) class48;
          break;
        case 18:
          Class46 class46_6 = new Class46();
          class46_6.method_3((int) ((Class61) class45_2).method_2());
          class46_6.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_6;
          break;
        case 20:
          object object_0 = class45_2.vmethod_0();
          if (object_0 == null)
          {
            gparam_1 = class45_2;
            break;
          }
          Type type_0 = object_0.GetType();
          if (type_0.HasElementType && !type_0.IsArray)
            type_0 = type_0.GetElementType();
          gparam_1 = (object) type_0 == null || type_0.IsValueType || type_0.IsEnum ? Class80.smethod_1(object_0, type_0) : class45_2;
          break;
        case 23:
          Class46 class46_7 = new Class46();
          class46_7.method_3(((Class47) class45_2).method_2() ? 1 : 0);
          class46_7.method_1(class45_2.method_0());
          gparam_1 = (Class45) class46_7;
          break;
        default:
          gparam_1 = class45_2;
          break;
      }
    }
    this.class16_0.method_7(gparam_1);
  }

  private void method_177(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    uint index;
    switch (class45.vmethod_2())
    {
      case 3:
        index = (uint) ((Class63) class45).method_2();
        break;
      case 7:
        index = (uint) Convert.ToInt64(class45.vmethod_0());
        break;
      case 9:
        index = (uint) ((Class46) class45).method_2();
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46[] class46Array = (Class46[]) ((Class60) class45_2).method_2();
    if ((long) index >= (long) class46Array.Length)
      return;
    this.method_160((uint) class46Array[(int) index].method_2());
  }

  private void method_178(int int_0)
  {
    Class45 class45_0 = this.method_10();
    if (class45_0 is Class52)
      this.class45_1[int_0] = class45_0;
    else
      this.class45_1[int_0].vmethod_3(class45_0);
  }

  private void method_179(Class45 class45_2) => this.method_10();

  private Class19[] method_180(BinaryReader binaryReader_1)
  {
    Class19[] class19Array = new Class19[(int) binaryReader_1.ReadInt16()];
    for (int index = 0; index < class19Array.Length; ++index)
      class19Array[index] = this.method_247(binaryReader_1);
    return class19Array;
  }

  private bool method_181(Type type_9, Class33 class33_0)
  {
    Class30 class30 = (Class30) class33_0.method_4();
    if (Class25.smethod_0(type_9).IsGenericParameter)
      return class30 == null || class30.method_2();
    Type type_1 = this.method_257(class33_0.method_2(), false);
    return Class24.smethod_0(type_9, type_1);
  }

  private void method_182(Class45 class45_2) => this.method_176(this.class45_0[2].vmethod_4());

  private static Class45 smethod_17(
    Class45 class45_2,
    Class45 class45_3,
    bool bool_2,
    bool bool_3)
  {
    if (!bool_3)
    {
      long num1 = ((Class63) class45_2).method_2();
      long num2 = ((Class63) class45_3).method_2();
      long long_1 = !bool_2 ? num1 + num2 : checked (num1 + num2);
      Class63 class63 = new Class63();
      class63.method_3(long_1);
      return (Class45) class63;
    }
    ulong num3 = (ulong) ((Class63) class45_2).method_2();
    ulong num4 = (ulong) ((Class63) class45_3).method_2();
    ulong long_1_1 = !bool_2 ? num3 + num4 : checked (num3 + num4);
    Class63 class63_1 = new Class63();
    class63_1.method_3((long) long_1_1);
    return (Class45) class63_1;
  }

  public static void smethod_18<T>(T[] gparam_0, Comparison<T> comparison_0)
  {
    KeyValuePair<int, T>[] keys = new KeyValuePair<int, T>[gparam_0.Length];
    for (int key = 0; key < gparam_0.Length; ++key)
      keys[key] = new KeyValuePair<int, T>(key, gparam_0[key]);
    Array.Sort<KeyValuePair<int, T>, T>(keys, gparam_0, (IComparer<KeyValuePair<int, T>>) new Class39.Class42<T>(comparison_0));
  }

  private void method_183(Type type_9)
  {
    long index = this.method_215();
    this.method_176(Class80.smethod_1(((Array) this.method_10().vmethod_0()).GetValue(index), type_9));
  }

  private void method_184(object object_3)
  {
    if (object_3 is Exception exception_0)
      Class39.smethod_26(exception_0);
    Class39.smethod_6(object_3);
  }

  private Class45[] method_185(object[] object_3)
  {
    Class75[] class75Array = this.class38_0.method_2();
    int length = class75Array.Length;
    Class45[] class45Array1 = new Class45[length];
    for (int index = 0; index < length; ++index)
    {
      object object_0 = object_3[index];
      Type type_0 = this.method_257(class75Array[index].method_0(), false);
      Type type_5 = Class25.smethod_1(type_0);
      Type type = (object) type_5 == (object) Class20.type_0 || Class20.smethod_0(type_5) ? type_0 : (object_0 != null ? object_0.GetType() : type_0);
      if (object_0 != null && !type_0.IsAssignableFrom(type) && type_0.IsByRef && !type_0.GetElementType().IsAssignableFrom(type))
        throw new ArgumentException(string.Format("Object of type {0} cannot be converted to type {1}.", (object) type, (object) type_0));
      class45Array1[index] = Class80.smethod_1(object_0, type);
    }
    if (!this.class38_0.method_12() && this.method_257(this.class38_0.method_6(), false).IsValueType)
    {
      Class45[] class45Array2 = class45Array1;
      Class53 class53 = new Class53();
      class53.method_3(class45Array1[0]);
      class45Array2[0] = (Class45) class53;
    }
    for (int index1 = 0; index1 < length; ++index1)
    {
      if (class75Array[index1].method_2())
      {
        Class45[] class45Array3 = class45Array1;
        int index2 = index1;
        Class53 class53 = new Class53();
        class53.method_3(class45Array1[index1]);
        class45Array3[index2] = (Class45) class53;
      }
    }
    return class45Array1;
  }

  private void method_186(MethodBase methodBase_0, bool bool_2)
  {
    if (!bool_2 && this.method_224(methodBase_0))
      methodBase_0 = this.method_43(methodBase_0, bool_2);
    ParameterInfo[] parameters = methodBase_0.GetParameters();
    int length = parameters.Length;
    Class45[] class45_2_1 = new Class45[length];
    object[] objArray = new object[length];
    Class39.Struct4 struct4_0 = new Class39.Struct4();
    try
    {
      this.method_110(ref struct4_0, methodBase_0, bool_2);
      for (int index = length - 1; index >= 0; --index)
      {
        Class45 class45_1 = this.method_10();
        class45_2_1[index] = class45_1;
        if (class45_1.vmethod_5())
          class45_1 = this.method_219(class45_1);
        if ((object) class45_1.method_0() != null)
          class45_1 = Class80.smethod_1((object) null, class45_1.method_0()).vmethod_3(class45_1);
        Class45 class45_2 = Class80.smethod_1((object) null, parameters[index].ParameterType).vmethod_3(class45_1);
        objArray[index] = class45_2.vmethod_0();
      }
      Class45 class45_3 = (Class45) null;
      if (!methodBase_0.IsStatic)
      {
        class45_3 = this.method_10();
        if (class45_3 != null && (object) class45_3.method_0() != null)
          class45_3 = Class80.smethod_1((object) null, class45_3.method_0()).vmethod_3(class45_3);
      }
      object object_0_1 = (object) null;
      try
      {
        if (methodBase_0.IsConstructor)
        {
          object_0_1 = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, objArray, (CultureInfo) null);
          if (class45_3 != null && !class45_3.vmethod_5())
            throw new InvalidOperationException();
          this.method_4(class45_3, Class80.smethod_1(object_0_1, methodBase_0.DeclaringType));
        }
        else
        {
          object obj = (object) null;
          if (class45_3 != null)
          {
            Class45 class45_4 = class45_3;
            if (class45_3.vmethod_5())
              class45_4 = this.method_219(class45_3);
            obj = class45_4.vmethod_0();
          }
          try
          {
            if (!this.method_145(methodBase_0, obj, ref object_0_1, objArray))
            {
              if (bool_2 && !methodBase_0.IsStatic && obj == null)
                throw new NullReferenceException();
              if (!this.method_114(methodBase_0, obj, class45_2_1, objArray, bool_2, ref object_0_1))
                object_0_1 = this.method_127(methodBase_0, obj, objArray, bool_2);
            }
            if (class45_3 != null)
            {
              if (class45_3.vmethod_5())
                this.method_4(class45_3, Class80.smethod_1(obj, methodBase_0.DeclaringType));
            }
          }
          catch (TargetInvocationException ex)
          {
            this.method_184((object) (ex.InnerException ?? (Exception) ex));
          }
        }
      }
      finally
      {
        for (int index = 0; index < class45_2_1.Length; ++index)
        {
          Class45 class45_2_2 = class45_2_1[index];
          if (class45_2_2.vmethod_5())
          {
            object object_0_2 = objArray[index];
            this.method_4(class45_2_2, Class80.smethod_1(object_0_2, (Type) null));
          }
        }
      }
      MethodInfo methodInfo = methodBase_0 as MethodInfo;
      if ((object) methodInfo == null)
        return;
      Type returnType = methodInfo.ReturnType;
      if ((object) returnType == (object) Class39.type_0)
        return;
      this.method_176(Class80.smethod_1(object_0_1, returnType));
    }
    finally
    {
      this.method_104(ref struct4_0);
    }
  }

  private Class45 method_187(Class45 class45_2, Class45 class45_3, bool bool_2)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_2)
        {
          int num1 = ((Class46) class45_2).method_2();
          int num2 = ((Class46) class45_3).method_2();
          Class46 class46 = new Class46();
          class46.method_3(num1 % num2);
          return (Class45) class46;
        }
        uint num3 = (uint) ((Class46) class45_2).method_2();
        uint num4 = (uint) ((Class46) class45_3).method_2();
        Class46 class46_1 = new Class46();
        class46_1.method_3((int) (num3 % num4));
        return (Class45) class46_1;
      }
      if (class45_3.vmethod_2() == 3)
      {
        Class63 class45_2_1 = new Class63();
        class45_2_1.method_3((long) ((Class46) class45_2).method_2());
        return Class39.smethod_4((Class45) class45_2_1, class45_3, bool_2);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_2 = class45_2;
          Class46 class45_3_1 = new Class46();
          class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num = bool_2 ? 1 : 0;
          return this.method_187(class45_2_2, (Class45) class45_3_1, num != 0);
        }
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3((long) ((Class46) class45_2).method_2());
        Class63 class45_3_2 = new Class63();
        class45_3_2.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        return Class39.smethod_4((Class45) class45_2_3, (Class45) class45_3_2, bool_2);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
        return Class39.smethod_4(class45_2, class45_3, bool_2);
      if (class45_3.vmethod_2() == 9)
      {
        Class45 class45_2_4 = class45_2;
        Class63 class45_3_3 = new Class63();
        class45_3_3.method_3((long) ((Class46) class45_3).method_2());
        int num = bool_2 ? 1 : 0;
        return Class39.smethod_4(class45_2_4, (Class45) class45_3_3, num != 0);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_5 = class45_2;
          Class46 class45_3_4 = new Class46();
          class45_3_4.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num = bool_2 ? 1 : 0;
          return Class39.smethod_4(class45_2_5, (Class45) class45_3_4, num != 0);
        }
        Class45 class45_2_6 = class45_2;
        Class63 class45_3_5 = new Class63();
        class45_3_5.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        int num5 = bool_2 ? 1 : 0;
        return Class39.smethod_4(class45_2_6, (Class45) class45_3_5, num5 != 0);
      }
    }
    if (class45_2.vmethod_2() == 16 && class45_3.vmethod_2() == 16)
    {
      Class48 class48 = new Class48();
      class48.method_3(((Class48) class45_2).method_2() % ((Class48) class45_3).method_2());
      return (Class45) class48;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_7 = new Class46();
      class45_2_7.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_187((Class45) class45_2_7, class45_3, bool_2);
    }
    Class63 class45_2_8 = new Class63();
    class45_2_8.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_187((Class45) class45_2_8, class45_3, bool_2);
  }

  private void method_188(Class45 class45_2)
  {
    Class51 class51 = (Class51) class45_2;
    Class54 class45_2_1 = new Class54();
    class45_2_1.method_3((int) class51.method_2());
    this.method_176((Class45) class45_2_1);
  }

  private static bool smethod_19(MethodBase methodBase_0)
  {
    foreach (ParameterInfo parameter in methodBase_0.GetParameters())
    {
      if (parameter.ParameterType.IsByRef)
        return true;
    }
    return false;
  }

  private void method_189(Class45 class45_2) => this.method_176(class45_2);

  private void method_190(Class45 class45_2) => this.method_192(typeof (float));

  private void method_191(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_57(this.method_10(), class45_3, true));
  }

  private void method_192(Type type_9) => this.method_176(Class80.smethod_1(this.method_219(this.method_10()).vmethod_0(), type_9));

  private static void smethod_20(ILGenerator ilgenerator_0, Type type_9)
  {
    if (!type_9.IsValueType && !Class25.smethod_0(type_9).IsGenericParameter)
      return;
    ilgenerator_0.Emit(OpCodes.Box, type_9);
  }

  private void method_193(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    Class46 class45_2_2 = new Class46();
    class45_2_2.method_3(Class39.smethod_24(class45_2_1, class45_3) ? 1 : 0);
    this.method_176((Class45) class45_2_2);
  }

  private void method_194(bool bool_2)
  {
    Class45 class45 = this.method_10();
    sbyte int_1;
    switch (class45.vmethod_2())
    {
      case 3:
        int_1 = !bool_2 ? (sbyte) ((Class63) class45).method_2() : checked ((sbyte) ((Class63) class45).method_2());
        break;
      case 7:
        int_1 = !bool_2 ? (sbyte) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((sbyte) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        int_1 = !bool_2 ? (sbyte) ((Class46) class45).method_2() : checked ((sbyte) ((Class46) class45).method_2());
        break;
      case 16:
        int_1 = !bool_2 ? (sbyte) ((Class48) class45).method_2() : checked ((sbyte) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class46 class45_2 = new Class46();
    class45_2.method_3((int) int_1);
    this.method_176((Class45) class45_2);
  }

  private void method_195(Class45 class45_2) => this.method_178((int) ((Class69) class45_2).method_2());

  private void method_196(Class45 class45_2) => this.method_133(true);

  private void method_197(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (!Class39.smethod_15(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_198(Class45 class45_2)
  {
    FieldInfo fieldInfo = this.method_229(((Class46) class45_2).method_2());
    Class45 class45_2_1 = this.method_10();
    if (class45_2_1.vmethod_5())
      class45_2_1 = this.method_219(class45_2_1);
    this.method_176(Class80.smethod_1(fieldInfo.GetValue(class45_2_1.vmethod_0() ?? throw new NullReferenceException()), fieldInfo.FieldType));
  }

  private Class75[] method_199(BinaryReader binaryReader_1)
  {
    Class75[] class75Array = new Class75[(int) binaryReader_1.ReadInt16()];
    for (int index = 0; index < class75Array.Length; ++index)
      class75Array[index] = this.method_123(binaryReader_1);
    return class75Array;
  }

  private void method_200(Class45 class45_2) => this.method_192(Class20.type_0);

  private void method_201(Class45 class45_2)
  {
    MethodBase methodBase = this.method_225(((Class46) class45_2).method_2());
    Type declaringType = methodBase.DeclaringType;
    Type type1 = this.method_10().vmethod_0().GetType();
    ParameterInfo[] parameters = methodBase.GetParameters();
    Type[] types = new Type[parameters.Length];
    for (int index = 0; index < parameters.Length; ++index)
      types[index] = parameters[index].ParameterType;
    MethodBase methodBase_1 = (MethodBase) null;
    for (Type type2 = type1; (object) type2 != null && (object) type2 != (object) declaringType; type2 = type2.BaseType)
    {
      MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, (Binder) null, CallingConventions.Any, types, (ParameterModifier[]) null);
      if ((object) method != null && (object) method.GetBaseDefinition() == (object) methodBase)
      {
        methodBase_1 = (MethodBase) method;
        break;
      }
    }
    if ((object) methodBase_1 == null)
      methodBase_1 = methodBase;
    Class68 class45_2_1 = new Class68();
    class45_2_1.method_3(methodBase_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_202(Class45 class45_2)
  {
    MethodBase methodBase_0 = this.method_225(((Class46) class45_2).method_2());
    Type declaringType = methodBase_0.DeclaringType;
    ParameterInfo[] parameters = methodBase_0.GetParameters();
    int length = parameters.Length;
    object[] object_4 = new object[length];
    Dictionary<int, Class45> dictionary = new Dictionary<int, Class45>();
    for (int key = length - 1; key >= 0; --key)
    {
      Class45 class45_1 = this.method_10();
      if (class45_1.vmethod_5())
      {
        dictionary.Add(key, class45_1);
        class45_1 = this.method_219(class45_1);
      }
      if ((object) class45_1.method_0() != null)
        class45_1 = Class80.smethod_1((object) null, class45_1.method_0()).vmethod_3(class45_1);
      Class45 class45_3 = Class80.smethod_1((object) null, parameters[key].ParameterType).vmethod_3(class45_1);
      object_4[key] = class45_3.vmethod_0();
    }
    object object_0;
    try
    {
      object_0 = this.method_127(methodBase_0, (object) null, object_4, false);
    }
    catch (TargetInvocationException ex)
    {
      this.method_184((object) (ex.InnerException ?? (Exception) ex));
      return;
    }
    foreach (KeyValuePair<int, Class45> keyValuePair in dictionary)
      this.method_4(keyValuePair.Value, Class80.smethod_1(object_4[keyValuePair.Key], (Type) null));
    this.method_176(Class80.smethod_1(object_0, declaringType));
  }

  private void method_203(Class45 class45_2) => this.method_275();

  private void method_204(Class45 class45_2) => throw new NotSupportedException("Arglist is not supported.");

  private void method_205(Class45 class45_2) => this.method_25(typeof (float));

  private void method_206(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(0);
    this.method_176((Class45) class45_2_1);
  }

  private void method_207(Class45 class45_2) => this.method_238();

  private void method_208(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_24(this.method_10(), class45_3));
  }

  private void method_209(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(2);
    this.method_176((Class45) class45_2_1);
  }

  private static Class45 smethod_21(Class45 class45_2, Class45 class45_3, bool bool_2)
  {
    if (!bool_2)
    {
      long num1 = ((Class63) class45_2).method_2();
      long num2 = ((Class63) class45_3).method_2();
      Class63 class63 = new Class63();
      class63.method_3(num1 / num2);
      return (Class45) class63;
    }
    ulong num3 = (ulong) ((Class63) class45_2).method_2();
    ulong num4 = (ulong) ((Class63) class45_3).method_2();
    Class63 class63_1 = new Class63();
    class63_1.method_3((long) (num3 / num4));
    return (Class45) class63_1;
  }

  private void method_210(Class45 class45_2)
  {
    FieldInfo fieldInfo_1 = this.method_229(((Class46) class45_2).method_2());
    Class55 class45_2_1 = new Class55();
    class45_2_1.method_5(fieldInfo_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_211(Class45 class45_2) => this.method_91(false);

  private void method_212(Class45 class45_2) => this.method_294(false);

  private object method_213(object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
  {
    if (object_3 == null)
      object_3 = Class77<object>.gparam_0;
    if (type_9 == null)
      type_9 = Type.EmptyTypes;
    if (type_10 == null)
      type_10 = Type.EmptyTypes;
    this.object_0 = object_4;
    this.type_8 = type_9;
    this.type_7 = type_10;
    this.class45_0 = this.method_185(object_3);
    this.class45_1 = this.method_100();
    try
    {
      using (Class11 class11_1 = new Class11(this.byte_0))
      {
        using (this.class14_0 = new Class14(class11_1))
        {
          this.bool_1 = false;
          this.nullable_0 = new uint?();
          this.class16_0.method_0();
          this.method_33();
        }
      }
      Type type_0 = this.method_257(this.class38_0.method_8(), false);
      return (object) type_0 != (object) Class39.type_0 && this.class16_0.Count > 0 ? Class80.smethod_1((object) null, type_0).vmethod_3(this.method_10()).vmethod_0() : (object) null;
    }
    finally
    {
      for (int index = 0; index < this.class38_0.method_2().Length; ++index)
      {
        Class75 class75 = this.class38_0.method_2()[index];
        if (class75.method_2())
        {
          Class53 class53 = (Class53) this.class45_0[index];
          Type type = this.method_257(class75.method_0(), false);
          object_3[index] = Class80.smethod_1((object) null, type.GetElementType()).vmethod_3(class53.method_2()).vmethod_0();
        }
      }
      this.object_0 = (object[]) null;
      this.class45_0 = (Class45[]) null;
      this.class45_1 = (Class45[]) null;
    }
  }

  private void method_214(Class45 class45_2)
  {
    FieldInfo fieldInfo_1 = this.method_229(((Class46) class45_2).method_2());
    Class45 class45_2_1 = this.method_10();
    object object_1 = !class45_2_1.vmethod_5() ? class45_2_1.vmethod_0() : this.method_219(class45_2_1).vmethod_0();
    Class55 class45_2_2 = new Class55();
    class45_2_2.method_5(fieldInfo_1);
    class45_2_2.method_3(object_1);
    this.method_176((Class45) class45_2_2);
  }

  private long method_215()
  {
    Class45 class45 = this.method_10();
    long num;
    switch (class45.vmethod_2())
    {
      case 2:
        num = ((Class67) class45).method_2().ToInt64();
        break;
      case 5:
        num = (long) ((Class65) class45).method_2().ToUInt64();
        break;
      case 7:
        num = Convert.ToInt64((object) ((Class59) class45).method_2());
        break;
      case 9:
        num = (long) ((Class46) class45).method_2();
        break;
      default:
        throw new Exception("Unexpected value on the stack.");
    }
    return num;
  }

  private static string smethod_22(MethodBase methodBase_0)
  {
    Type declaringType = methodBase_0.DeclaringType;
    ParameterInfo[] parameters = methodBase_0.GetParameters();
    string[] strArray = new string[parameters.Length];
    for (int index = 0; index < parameters.Length; ++index)
    {
      ParameterInfo parameterInfo = parameters[index];
      strArray[index] = string.Format("{0} {1}", (object) parameterInfo.ParameterType, (object) parameterInfo.Name);
    }
    string str = string.Join(", ", strArray);
    return string.Format("{0}.{1}({2})", (object) declaringType.FullName, (object) methodBase_0.Name, (object) str);
  }

  [Conditional("DEBUG")]
  public static void smethod_23(string string_0)
  {
  }

  private void method_216(Class45 class45_2) => this.method_91(true);

  private void method_217(Class45 class45_2) => this.method_25(this.method_257(((Class46) class45_2).method_2(), true));

  private void method_218()
  {
    long num = this.class14_0.method_0().method_14();
    Class39.Class43 class43;
    if (!this.dictionary_5.TryGetValue(this.class14_0.method_28(), out class43))
      throw new InvalidOperationException("Unsupported instruction.");
    this.long_0 = num;
    class43.delegate1_0(this.method_254(this.class14_0, class43.class17_0.method_2()));
  }

  private Class45 method_219(Class45 class45_2)
  {
    if (!class45_2.vmethod_5())
      throw new ArgumentException();
    switch (class45_2.vmethod_2())
    {
      case 6:
        return ((Class53) class45_2).method_2();
      case 12:
        Class55 class55 = (Class55) class45_2;
        return Class80.smethod_1(class55.method_4().GetValue(class55.method_2()), (Type) null);
      case 17:
      case 21:
        Class56 class56 = (Class56) class45_2;
        return Class80.smethod_1(class56.vmethod_6(), class56.method_2());
      case 19:
        return this.class45_1[((Class54) class45_2).method_2()];
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  private void method_220(Class45 class45_2) => this.class45_0[(int) ((Class51) class45_2).method_2()].vmethod_3(this.method_10());

  private void method_221(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_262(this.method_10(), class45_3, false, false));
  }

  private void method_222(Class45 class45_2) => this.method_26(true);

  private Class38 method_223(BinaryReader binaryReader_1)
  {
    Class38 class38 = new Class38();
    class38.method_9(binaryReader_1.ReadInt32());
    class38.method_1(this.method_180(binaryReader_1));
    class38.method_11(binaryReader_1.ReadByte());
    class38.method_3(this.method_199(binaryReader_1));
    class38.method_5(binaryReader_1.ReadString());
    class38.method_7(binaryReader_1.ReadInt32());
    return class38;
  }

  private bool method_224(MethodBase methodBase_0) => methodBase_0.IsVirtual && this.method_257(this.class38_0.method_6(), true).IsSubclassOf(methodBase_0.DeclaringType);

  [DebuggerNonUserCode]
  private MethodBase method_225(int int_0)
  {
    Class33 class33_0 = this.method_169(int_0);
    MethodBase memberInfo_0 = this.method_124(int_0, class33_0);
    this.method_13((MemberInfo) memberInfo_0);
    return memberInfo_0;
  }

  private void method_226(Class45 class45_2) => throw new NotSupportedException("Initblk not supported.");

  private void method_227(Class45 class45_2) => this.method_174(true);

  private void method_228(Class45 class45_2)
  {
    object obj = this.method_10().vmethod_0();
    long long_1 = this.method_215();
    Array array_0 = (Array) this.method_10().vmethod_0();
    Type elementType = array_0.GetType().GetElementType();
    if ((object) elementType == (object) typeof (short))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (short));
      ((short[]) array_0)[long_1] = (short) class45.vmethod_0();
    }
    else if ((object) elementType == (object) typeof (ushort))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (ushort));
      ((ushort[]) array_0)[long_1] = (ushort) class45.vmethod_0();
    }
    else if ((object) elementType == (object) typeof (char))
    {
      Class45 class45 = Class80.smethod_1(obj, typeof (char));
      ((char[]) array_0)[long_1] = (char) class45.vmethod_0();
    }
    else if (elementType.IsEnum)
      this.method_87(elementType, obj, long_1, array_0);
    else
      this.method_87(typeof (short), obj, long_1, array_0);
  }

  private FieldInfo method_229(int int_0)
  {
    lock (Class39.dictionary_1)
    {
      bool bool_2 = true;
      object obj;
      FieldInfo memberInfo_0;
      if (Class39.dictionary_1.TryGetValue(int_0, out obj))
      {
        memberInfo_0 = (FieldInfo) obj;
      }
      else
      {
        Class33 class33_0 = this.method_169(int_0);
        memberInfo_0 = this.method_292(int_0, class33_0, ref bool_2);
        if (bool_2)
          Class39.dictionary_1.Add(int_0, (object) memberInfo_0);
      }
      this.method_13((MemberInfo) memberInfo_0);
      return memberInfo_0;
    }
  }

  private void method_230(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_98(this.method_10(), class45_3, true, true));
  }

  private void method_231(Class45 class45_2) => this.method_194(false);

  private void method_232(Class45 class45_2) => this.method_176(this.class45_1[1].vmethod_4());

  private void method_233(Class45 class45_2) => this.method_183(this.method_257(((Class46) class45_2).method_2(), true));

  private void method_234(Class45 class45_2)
  {
  }

  private long method_235(string string_0)
  {
    MemoryStream stream_1 = new MemoryStream(Class0.smethod_0(string_0));
    long num = new BinaryReader((Stream) new Stream0((Stream) stream_1, this.method_252())).ReadInt64();
    stream_1.Dispose();
    return num;
  }

  private void method_236(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_98(this.method_10(), class45_3, true, false));
  }

  private void method_237(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    bool flag;
    switch (class45.vmethod_2())
    {
      case 2:
        flag = ((Class67) class45).method_2() != IntPtr.Zero;
        break;
      case 3:
        flag = ((Class63) class45).method_2() != 0L;
        break;
      case 5:
        flag = ((Class65) class45).method_2() != UIntPtr.Zero;
        break;
      case 7:
        flag = Convert.ToBoolean((object) ((Class59) class45).method_2());
        break;
      case 9:
        flag = ((Class46) class45).method_2() != 0;
        break;
      case 20:
        flag = ((Class49) class45).method_2() != null;
        break;
      default:
        flag = class45.vmethod_0() != null;
        break;
    }
    if (!flag)
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_238()
  {
    Class45 class45_3 = this.method_10();
    this.method_4(this.method_10(), class45_3);
  }

  private string method_239(Class38 class38_1)
  {
    Type type = this.method_257(class38_1.method_6(), false);
    Class75[] class75Array = class38_1.method_2();
    string[] strArray = new string[class75Array.Length];
    for (int index = 0; index < class75Array.Length; ++index)
      strArray[index] = this.method_257(class75Array[index].method_0(), false)?.FullName;
    string str = string.Join(", ", strArray);
    return string.Format("{0}.{1}({2})", (object) type.FullName, (object) class38_1.method_4(), (object) str);
  }

  private void method_240(Class45 class45_2) => throw new NotSupportedException("Cpobj is not supported.");

  private void method_241(Class45 class45_2) => this.method_176(class45_2);

  private void method_242(Class45 class45_2)
  {
    Array array = (Array) this.method_10().vmethod_0();
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(array.Length);
    this.method_176((Class45) class45_2_1);
  }

  private void method_243(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(-1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_244(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(1);
    this.method_176((Class45) class45_2_1);
  }

  private int method_245() => -873667919;

  private void method_246(Class45 class45_2) => this.method_238();

  private Class19 method_247(BinaryReader binaryReader_1)
  {
    Class19 class19 = new Class19();
    class19.method_1(binaryReader_1.ReadInt32());
    return class19;
  }

  private void method_248()
  {
    long num = this.class14_0.method_0().method_13();
    while (!this.bool_1)
    {
      if (this.nullable_0.HasValue)
      {
        this.class14_0.method_0().method_15((long) this.nullable_0.Value);
        this.nullable_0 = new uint?();
      }
      this.method_166();
      if (this.class14_0.method_0().method_14() >= num && !this.nullable_0.HasValue)
        break;
    }
  }

  private void method_249(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(6);
    this.method_176((Class45) class45_2_1);
  }

  private void method_250(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (!Class39.smethod_0(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_251(Class45 class45_2) => this.method_176(this.method_152(this.method_10()));

  private static bool smethod_24(Class45 class45_2, Class45 class45_3)
  {
    bool flag = false;
    switch (class45_2.vmethod_2())
    {
      case 3:
        if (class45_3.vmethod_2() == 7)
        {
          Class45 class45_2_1 = class45_2;
          Class63 class45_3_1 = new Class63();
          class45_3_1.method_3(Convert.ToInt64((object) ((Class59) class45_3).method_2()));
          return Class39.smethod_24(class45_2_1, (Class45) class45_3_1);
        }
        if (class45_3.vmethod_2() == 9)
        {
          Class45 class45_2_2 = class45_2;
          Class63 class45_3_2 = new Class63();
          class45_3_2.method_3((long) ((Class46) class45_3).method_2());
          return Class39.smethod_24(class45_2_2, (Class45) class45_3_2);
        }
        flag = ((Class63) class45_2).method_2() > ((Class63) class45_3).method_2();
        break;
      case 7:
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3(Convert.ToInt64((object) ((Class59) class45_2).method_2()));
        return Class39.smethod_24((Class45) class45_2_3, class45_3);
      case 9:
        if (class45_3.vmethod_2() == 7)
        {
          Class45 class45_2_4 = class45_2;
          Class46 class45_3_3 = new Class46();
          class45_3_3.method_3(Convert.ToInt32((object) ((Class59) class45_3).method_2()));
          return Class39.smethod_24(class45_2_4, (Class45) class45_3_3);
        }
        flag = ((Class46) class45_2).method_2() > ((Class46) class45_3).method_2();
        break;
      case 16:
        double d1 = ((Class48) class45_2).method_2();
        double d2 = ((Class48) class45_3).method_2();
        flag = !double.IsNaN(d1) && !double.IsNaN(d2) && d1 > d2;
        break;
    }
    return flag;
  }

  private int method_252() => -896962595;

  private void method_253(Class45 class45_2) => this.method_183(typeof (byte));

  private static void smethod_25(ILGenerator ilgenerator_0, int int_0)
  {
    switch (int_0)
    {
      case -1:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
        break;
      case 0:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
        break;
      case 1:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
        break;
      case 2:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
        break;
      case 3:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
        break;
      case 4:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
        break;
      case 5:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
        break;
      case 6:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
        break;
      case 7:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
        break;
      case 8:
        ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
        break;
      default:
        if (int_0 > -129 && int_0 < 128)
        {
          ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte) int_0);
          break;
        }
        ilgenerator_0.Emit(OpCodes.Ldc_I4, int_0);
        break;
    }
  }

  private Class45 method_254(Class14 class14_1, int int_0)
  {
    switch (int_0)
    {
      case 0:
        Class50 class50 = new Class50();
        class50.method_3(class14_1.method_15());
        return (Class45) class50;
      case 1:
        return (Class45) null;
      case 2:
        int length = class14_1.method_28();
        Class46[] array_1 = new Class46[length];
        for (int index1 = 0; index1 < length; ++index1)
        {
          Class46[] class46Array = array_1;
          int index2 = index1;
          Class46 class46 = new Class46();
          class46.method_3(class14_1.method_28());
          class46Array[index2] = class46;
        }
        Class60 class60 = new Class60();
        class60.method_3((Array) array_1);
        return (Class45) class60;
      case 3:
      case 8:
        Class69 class69 = new Class69();
        class69.method_3(class14_1.method_10());
        return (Class45) class69;
      case 4:
        Class63 class63 = new Class63();
        class63.method_3(class14_1.method_12());
        return (Class45) class63;
      case 5:
        Class64 class64 = new Class64();
        class64.method_3(class14_1.method_11());
        return (Class45) class64;
      case 6:
      case 10:
        Class46 class46_1 = new Class46();
        class46_1.method_3(class14_1.method_28());
        return (Class45) class46_1;
      case 7:
      case 11:
        Class51 class51 = new Class51();
        class51.method_3(class14_1.method_6());
        return (Class45) class51;
      case 9:
        Class61 class61 = new Class61();
        class61.method_3(class14_1.method_7());
        return (Class45) class61;
      case 12:
        Class48 class48 = new Class48();
        class48.method_3(class14_1.method_16());
        return (Class45) class48;
      default:
        throw new Exception("Unknown operand type.");
    }
  }

  private void method_255(Class45 class45_2) => this.method_176(this.class45_0[(int) ((Class69) class45_2).method_2()].vmethod_4());

  private void method_256(Class45 class45_2) => this.method_186(((Class68) this.method_10()).method_2(), false);

  private Type method_257(int int_0, bool bool_2)
  {
    Type memberInfo_0;
    lock (Class39.dictionary_1)
    {
      bool bool_2_1 = true;
      object obj;
      if (Class39.dictionary_1.TryGetValue(int_0, out obj))
      {
        memberInfo_0 = (Type) obj;
      }
      else
      {
        Class33 class33_0 = this.method_169(int_0);
        memberInfo_0 = this.method_74(int_0, class33_0, ref bool_2_1, bool_2);
        if (bool_2_1)
          Class39.dictionary_1.Add(int_0, (object) memberInfo_0);
      }
    }
    if (bool_2)
      this.method_13((MemberInfo) memberInfo_0);
    return memberInfo_0;
  }

  private static void smethod_26(Exception exception_0) => ExceptionDispatchInfo.Capture(exception_0).Throw();

  private void method_258() => Class39.smethod_18<Class34>(this.class34_0, Class39.Class40.comparison_0 ?? (Class39.Class40.comparison_0 = new Comparison<Class34>(Class39.Class40.class40_0.method_0)));

  private void method_259(Class45 class45_2) => this.method_192(typeof (ushort));

  [Conditional("DEBUG")]
  private void method_260(object object_3)
  {
  }

  private void method_261(Class45 class45_2) => this.method_176(this.class45_0[0].vmethod_4());

  private Class45 method_262(Class45 class45_2, Class45 class45_3, bool bool_2, bool bool_3)
  {
    if (class45_2.vmethod_2() == 9)
    {
      if (class45_3.vmethod_2() == 9)
      {
        if (!bool_3)
        {
          int num1 = ((Class46) class45_2).method_2();
          int num2 = ((Class46) class45_3).method_2();
          int int_1 = !bool_2 ? num1 + num2 : checked (num1 + num2);
          Class46 class46 = new Class46();
          class46.method_3(int_1);
          return (Class45) class46;
        }
        uint num3 = (uint) ((Class46) class45_2).method_2();
        uint num4 = (uint) ((Class46) class45_3).method_2();
        uint int_1_1 = !bool_2 ? num3 + num4 : checked (num3 + num4);
        Class46 class46_1 = new Class46();
        class46_1.method_3((int) int_1_1);
        return (Class45) class46_1;
      }
      if (class45_3.vmethod_2() == 3)
      {
        Class63 class45_2_1 = new Class63();
        class45_2_1.method_3((long) ((Class46) class45_2).method_2());
        return Class39.smethod_17((Class45) class45_2_1, class45_3, bool_2, bool_3);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_2 = class45_2;
          Class46 class45_3_1 = new Class46();
          class45_3_1.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num5 = bool_2 ? 1 : 0;
          int num6 = bool_3 ? 1 : 0;
          return this.method_262(class45_2_2, (Class45) class45_3_1, num5 != 0, num6 != 0);
        }
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3((long) ((Class46) class45_2).method_2());
        Class63 class45_3_2 = new Class63();
        class45_3_2.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        return Class39.smethod_17((Class45) class45_2_3, (Class45) class45_3_2, bool_2, bool_3);
      }
    }
    if (class45_2.vmethod_2() == 3)
    {
      if (class45_3.vmethod_2() == 3)
        return Class39.smethod_17(class45_2, class45_3, bool_2, bool_3);
      if (class45_3.vmethod_2() == 9)
      {
        Class45 class45_2_4 = class45_2;
        Class63 class45_3_3 = new Class63();
        class45_3_3.method_3((long) ((Class46) class45_3).method_2());
        int num7 = bool_2 ? 1 : 0;
        int num8 = bool_3 ? 1 : 0;
        return Class39.smethod_17(class45_2_4, (Class45) class45_3_3, num7 != 0, num8 != 0);
      }
      if (class45_3.vmethod_2() == 7)
      {
        Type underlyingType = Enum.GetUnderlyingType(class45_3.vmethod_0().GetType());
        if ((object) underlyingType != (object) typeof (long) && (object) underlyingType != (object) typeof (ulong))
        {
          Class45 class45_2_5 = class45_2;
          Class46 class45_3_4 = new Class46();
          class45_3_4.method_3(Convert.ToInt32(class45_3.vmethod_0()));
          int num9 = bool_2 ? 1 : 0;
          int num10 = bool_3 ? 1 : 0;
          return Class39.smethod_17(class45_2_5, (Class45) class45_3_4, num9 != 0, num10 != 0);
        }
        Class45 class45_2_6 = class45_2;
        Class63 class45_3_5 = new Class63();
        class45_3_5.method_3(Convert.ToInt64(class45_3.vmethod_0()));
        int num11 = bool_2 ? 1 : 0;
        int num12 = bool_3 ? 1 : 0;
        return Class39.smethod_17(class45_2_6, (Class45) class45_3_5, num11 != 0, num12 != 0);
      }
    }
    if (class45_2.vmethod_2() == 16 && class45_3.vmethod_2() == 16)
    {
      Class48 class48 = new Class48();
      class48.method_3(((Class48) class45_2).method_2() + ((Class48) class45_3).method_2());
      return (Class45) class48;
    }
    Type type = class45_2.vmethod_2() == 7 ? Enum.GetUnderlyingType(class45_2.vmethod_0().GetType()) : throw new InvalidOperationException();
    if ((object) type != (object) typeof (long) && (object) type != (object) typeof (ulong))
    {
      Class46 class45_2_7 = new Class46();
      class45_2_7.method_3(Convert.ToInt32(class45_2.vmethod_0()));
      return this.method_262((Class45) class45_2_7, class45_3, bool_2, bool_3);
    }
    Class63 class45_2_8 = new Class63();
    class45_2_8.method_3(Convert.ToInt64(class45_2.vmethod_0()));
    return this.method_262((Class45) class45_2_8, class45_3, bool_2, bool_3);
  }

  private void method_263(bool bool_2)
  {
    Class45 class45 = this.method_10();
    UIntPtr uintptr_1;
    switch (class45.vmethod_2())
    {
      case 3:
        uintptr_1 = !bool_2 ? new UIntPtr((ulong) ((Class63) class45).method_2()) : new UIntPtr(checked ((ulong) ((Class63) class45).method_2()));
        break;
      case 7:
        uintptr_1 = !bool_2 ? new UIntPtr(Convert.ToUInt64((object) ((Class59) class45).method_2())) : new UIntPtr(Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        uintptr_1 = !bool_2 ? new UIntPtr((uint) ((Class46) class45).method_2()) : new UIntPtr(checked ((uint) ((Class46) class45).method_2()));
        break;
      case 16:
        uintptr_1 = !bool_2 ? new UIntPtr((ulong) ((Class48) class45).method_2()) : new UIntPtr(checked ((ulong) ((Class48) class45).method_2()));
        break;
      default:
        throw new InvalidOperationException();
    }
    Class65 class45_2 = new Class65();
    class45_2.method_3(uintptr_1);
    this.method_176((Class45) class45_2);
  }

  private void method_264(Class45 class45_2)
  {
    if (((Class46) this.method_10()).method_2() != 0)
    {
      this.class16_1.method_7(new Class39.Struct5((uint) this.class14_0.method_0().method_14(), this.object_1));
      this.bool_0 = false;
    }
    this.method_44();
  }

  private void method_265(Class45 class45_2)
  {
  }

  private void method_266(Class45 class45_2) => this.method_176(this.class45_0[3].vmethod_4());

  private void method_267(Class28 class28_0)
  {
    Class33 class33_0 = this.method_169(class28_0.method_2());
    Class31 class31 = (Class31) class33_0.method_4();
    MethodBase methodBase = this.method_124(class28_0.method_2(), class33_0);
    methodBase.GetParameters();
    int num = class28_0.method_0();
    bool bool_2 = (num & 1073741824) != 0;
    int int_0 = num & -1073741825;
    Type[] type8 = this.type_8;
    Type[] type7 = this.type_7;
    try
    {
      this.type_8 = (object) (methodBase as ConstructorInfo) != null ? Type.EmptyTypes : methodBase.GetGenericArguments();
      this.type_7 = methodBase.DeclaringType.GetGenericArguments();
      this.method_30(int_0, this.type_8, this.type_7, bool_2);
    }
    finally
    {
      this.type_8 = type8;
      this.type_7 = type7;
    }
  }

  private void method_268(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    Class46 class45_2_2 = new Class46();
    class45_2_2.method_3(Class39.smethod_0(class45_2_1, class45_3) ? 1 : 0);
    this.method_176((Class45) class45_2_2);
  }

  private void method_269(Class45 class45_2)
  {
    FieldInfo fieldInfo = this.method_229(((Class46) class45_2).method_2());
    this.method_176(Class80.smethod_1(fieldInfo.GetValue((object) null), fieldInfo.FieldType));
  }

  public object method_270(Stream stream_1, string string_0, object[] object_3) => this.method_22(stream_1, string_0, object_3, (Type[]) null, (Type[]) null, (object[]) null);

  private void method_271()
  {
  }

  private void method_272(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_262(this.method_10(), class45_3, true, true));
  }

  private void method_273(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (Class39.smethod_15(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_274(Class45 class45_2) => this.method_176((Class45) new Class49());

  private void method_275() => this.bool_1 = true;

  private void method_276(Class45 class45_2)
  {
    Class69 class69 = (Class69) class45_2;
    Class54 class45_2_1 = new Class54();
    class45_2_1.method_3((int) class69.method_2());
    this.method_176((Class45) class45_2_1);
  }

  private void method_277(Class45 class45_2) => this.method_192(typeof (uint));

  private void method_278(Class45 class45_2)
  {
    int num1 = ((Class46) class45_2).method_2();
    int num2 = (num1 & int.MinValue) != 0 ? 1 : 0;
    bool bool_2 = (num1 & 1073741824) != 0;
    int int_0 = num1 & 1073741823;
    if (num2 != 0)
      this.method_30(int_0, (Type[]) null, (Type[]) null, bool_2);
    else
      this.method_267((Class28) this.method_169(int_0).method_4());
  }

  private void method_279(Class45 class45_2)
  {
    Class46 class45_2_1 = new Class46();
    class45_2_1.method_3(8);
    this.method_176((Class45) class45_2_1);
  }

  private static bool smethod_27(Class45 class45_2, Class45 class45_3)
  {
    bool flag = false;
    switch (class45_2.vmethod_2())
    {
      case 3:
        if (class45_3.vmethod_2() == 7)
        {
          Class45 class45_2_1 = class45_2;
          Class63 class45_3_1 = new Class63();
          class45_3_1.method_3(Convert.ToInt64((object) ((Class59) class45_3).method_2()));
          return Class39.smethod_27(class45_2_1, (Class45) class45_3_1);
        }
        if (class45_3.vmethod_2() == 9)
        {
          Class45 class45_2_2 = class45_2;
          Class63 class45_3_2 = new Class63();
          class45_3_2.method_3((long) ((Class46) class45_3).method_2());
          return Class39.smethod_27(class45_2_2, (Class45) class45_3_2);
        }
        flag = (ulong) ((Class63) class45_2).method_2() < (ulong) ((Class63) class45_3).method_2();
        break;
      case 7:
        Class63 class45_2_3 = new Class63();
        class45_2_3.method_3(Convert.ToInt64((object) ((Class59) class45_2).method_2()));
        return Class39.smethod_27((Class45) class45_2_3, class45_3);
      case 9:
        if (class45_3.vmethod_2() == 7)
        {
          Class45 class45_2_4 = class45_2;
          Class46 class45_3_3 = new Class46();
          class45_3_3.method_3(Convert.ToInt32((object) ((Class59) class45_3).method_2()));
          return Class39.smethod_27(class45_2_4, (Class45) class45_3_3);
        }
        flag = (uint) ((Class46) class45_2).method_2() < (uint) ((Class46) class45_3).method_2();
        break;
      case 16:
        double d1 = ((Class48) class45_2).method_2();
        double d2 = ((Class48) class45_3).method_2();
        flag = d1 < d2 || double.IsNaN(d1) || double.IsNaN(d2);
        break;
    }
    return flag;
  }

  private void method_280(Class45 class45_2)
  {
    Type elementType = this.method_257(((Class46) class45_2).method_2(), true);
    int num;
    switch (this.method_10())
    {
      case Class46 class46:
        num = class46.method_2();
        break;
      case Class67 class67:
        num = class67.method_2().ToInt32();
        break;
      case Class65 class65:
        num = (int) class65.method_2().ToUInt32();
        break;
      default:
        throw new Exception();
    }
    int length = num;
    Array instance = Array.CreateInstance(elementType, length);
    Class60 class45_2_1 = new Class60();
    class45_2_1.method_3(instance);
    this.method_176((Class45) class45_2_1);
  }

  private void method_281(Class45 class45_2) => this.method_178(3);

  private void method_282(Class45 class45_2) => this.method_26(false);

  private void method_283(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    Class46 class45_2_2 = new Class46();
    class45_2_2.method_3(Class39.smethod_27(class45_2_1, class45_3) ? 1 : 0);
    this.method_176((Class45) class45_2_2);
  }

  private void method_284(Class45 class45_2) => this.method_42(false);

  private void method_285(Class45 class45_2) => this.method_25(Class39.type_1);

  private void method_286(Class45 class45_2)
  {
    Type type_0 = this.method_257(((Class46) class45_2).method_2(), true);
    this.method_176(Class80.smethod_1(this.method_10().vmethod_0(), type_0));
  }

  private static Class45 smethod_28(
    Class45 class45_2,
    Class45 class45_3,
    bool bool_2,
    bool bool_3)
  {
    if (!bool_3)
    {
      long num1 = ((Class63) class45_2).method_2();
      long num2 = ((Class63) class45_3).method_2();
      long long_1 = !bool_2 ? num1 - num2 : checked (num1 - num2);
      Class63 class63 = new Class63();
      class63.method_3(long_1);
      return (Class45) class63;
    }
    ulong num3 = (ulong) ((Class63) class45_2).method_2();
    ulong num4 = (ulong) ((Class63) class45_3).method_2();
    ulong long_1_1 = !bool_2 ? num3 - num4 : checked (num3 - num4);
    Class63 class63_1 = new Class63();
    class63_1.method_3((long) long_1_1);
    return (Class45) class63_1;
  }

  private void method_287(Class45 class45_2) => this.method_183(Class39.type_1);

  private void method_288(Class45 class45_2) => this.method_133(false);

  public static object smethod_29(Type type_9) => type_9.IsValueType ? Activator.CreateInstance(type_9) : (object) null;

  private void method_289(Class45 class45_2)
  {
    Class45 class45 = this.method_10();
    float double_1;
    switch (class45.vmethod_2())
    {
      case 3:
        double_1 = (float) ((Class63) class45).method_2();
        break;
      case 7:
        double_1 = (float) Convert.ToUInt64((object) ((Class59) class45).method_2());
        break;
      case 9:
        double_1 = (float) ((Class46) class45).method_2();
        break;
      case 16:
        double_1 = (float) ((Class48) class45).method_2();
        break;
      default:
        throw new InvalidOperationException();
    }
    Class48 class45_2_1 = new Class48();
    class45_2_1.method_3((double) double_1);
    this.method_176((Class45) class45_2_1);
  }

  private void method_290(Class45 class45_2)
  {
    Class51 class51 = (Class51) class45_2;
    Class53 class45_2_1 = new Class53();
    class45_2_1.method_3(this.class45_0[(int) class51.method_2()]);
    this.method_176((Class45) class45_2_1);
  }

  private void method_291(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_69(this.method_10(), class45_3, true, true));
  }

  private FieldInfo method_292(int int_0, Class33 class33_0, ref bool bool_2)
  {
    if (class33_0.method_0() == (byte) 1)
    {
      bool_2 = false;
      return this.module_0.ResolveField(class33_0.method_2());
    }
    Class29 class29 = (Class29) class33_0.method_4();
    Type type = this.method_257(class29.method_0().method_2(), false);
    if (type.IsGenericType)
      bool_2 = false;
    BindingFlags bindingAttr = Class39.smethod_1(class29.method_4());
    return type.GetField(class29.method_2(), bindingAttr);
  }

  private void method_293(Class45 class45_2) => this.method_122(true);

  private void method_294(bool bool_2)
  {
    Class45 class45 = this.method_10();
    long long_1;
    switch (class45.vmethod_2())
    {
      case 3:
        long_1 = !bool_2 ? ((Class63) class45).method_2() : ((Class63) class45).method_2();
        break;
      case 7:
        long_1 = !bool_2 ? (long) Convert.ToUInt64((object) ((Class59) class45).method_2()) : checked ((long) Convert.ToUInt64((object) ((Class59) class45).method_2()));
        break;
      case 9:
        long_1 = !bool_2 ? (long) ((Class46) class45).method_2() : (long) ((Class46) class45).method_2();
        break;
      case 16:
        long_1 = !bool_2 ? (long) ((Class48) class45).method_2() : checked ((long) ((Class48) class45).method_2());
        break;
      default:
        throw new InvalidOperationException();
    }
    Class63 class45_2 = new Class63();
    class45_2.method_3(long_1);
    this.method_176((Class45) class45_2);
  }

  private void method_295(Class45 class45_2)
  {
    Class69 class69 = (Class69) class45_2;
    Class45 class45_0 = this.method_10();
    this.class45_0[(int) class69.method_2()].vmethod_3(class45_0);
  }

  private void method_296(Class45 class45_2) => throw new NotSupportedException("Localloc not supported.");

  private void method_297(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    this.method_176(this.method_161(this.method_10(), class45_3, true));
  }

  private Class39.Delegate2 method_298(MethodBase methodBase_0, bool bool_2)
  {
    DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, Class20.type_0, new Type[2]
    {
      Class20.type_0,
      Class39.type_5
    }, typeof (Class39).Module, true);
    ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
    ParameterInfo[] parameters = methodBase_0.GetParameters();
    Type[] typeArray = new Type[parameters.Length];
    bool flag = false;
    for (int index = 0; index < parameters.Length; ++index)
    {
      Type type = parameters[index].ParameterType;
      if (type.IsByRef)
      {
        flag = true;
        type = type.GetElementType();
      }
      typeArray[index] = type;
    }
    LocalBuilder[] localBuilderArray = new LocalBuilder[typeArray.Length];
    if (localBuilderArray.Length != 0)
      dynamicMethod.InitLocals = true;
    for (int index = 0; index < typeArray.Length; ++index)
      localBuilderArray[index] = ilGenerator.DeclareLocal(typeArray[index]);
    for (int int_0 = 0; int_0 < typeArray.Length; ++int_0)
    {
      ilGenerator.Emit(OpCodes.Ldarg_1);
      Class39.smethod_25(ilGenerator, int_0);
      ilGenerator.Emit(OpCodes.Ldelem_Ref);
      Class39.smethod_8(ilGenerator, typeArray[int_0]);
      ilGenerator.Emit(OpCodes.Stloc, localBuilderArray[int_0]);
    }
    if (flag)
      ilGenerator.BeginExceptionBlock();
    if (!methodBase_0.IsStatic && !methodBase_0.IsConstructor)
    {
      ilGenerator.Emit(OpCodes.Ldarg_0);
      Type declaringType = methodBase_0.DeclaringType;
      if (declaringType.IsValueType)
      {
        ilGenerator.Emit(OpCodes.Unbox, declaringType);
        bool_2 = false;
      }
      else
        Class39.smethod_9(ilGenerator, declaringType);
    }
    for (int index = 0; index < typeArray.Length; ++index)
    {
      if (parameters[index].ParameterType.IsByRef)
        ilGenerator.Emit(OpCodes.Ldloca_S, localBuilderArray[index]);
      else
        ilGenerator.Emit(OpCodes.Ldloc, localBuilderArray[index]);
    }
    if (methodBase_0.IsConstructor)
    {
      ilGenerator.Emit(OpCodes.Newobj, (ConstructorInfo) methodBase_0);
      Class39.smethod_20(ilGenerator, methodBase_0.DeclaringType);
    }
    else
    {
      MethodInfo methodInfo = (MethodInfo) methodBase_0;
      if (bool_2 && !methodBase_0.IsStatic)
        ilGenerator.EmitCall(OpCodes.Callvirt, methodInfo, (Type[]) null);
      else
        ilGenerator.EmitCall(OpCodes.Call, methodInfo, (Type[]) null);
      if ((object) methodInfo.ReturnType == (object) Class39.type_0)
        ilGenerator.Emit(OpCodes.Ldnull);
      else
        Class39.smethod_20(ilGenerator, methodInfo.ReturnType);
    }
    if (flag)
    {
      LocalBuilder local = ilGenerator.DeclareLocal(Class20.type_0);
      ilGenerator.Emit(OpCodes.Stloc, local);
      ilGenerator.BeginFinallyBlock();
      for (int int_0 = 0; int_0 < typeArray.Length; ++int_0)
      {
        if (parameters[int_0].ParameterType.IsByRef)
        {
          ilGenerator.Emit(OpCodes.Ldarg_1);
          Class39.smethod_25(ilGenerator, int_0);
          ilGenerator.Emit(OpCodes.Ldloc, localBuilderArray[int_0]);
          if (localBuilderArray[int_0].LocalType.IsValueType || Class25.smethod_0(localBuilderArray[int_0].LocalType).IsGenericParameter)
            ilGenerator.Emit(OpCodes.Box, localBuilderArray[int_0].LocalType);
          ilGenerator.Emit(OpCodes.Stelem_Ref);
        }
      }
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc, local);
    }
    ilGenerator.Emit(OpCodes.Ret);
    return (Class39.Delegate2) dynamicMethod.CreateDelegate(typeof (Class39.Delegate2));
  }

  private void method_299(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    Class45 class45_2_1 = this.method_10();
    Class46 class45_2_2 = new Class46();
    class45_2_2.method_3(Class39.smethod_14(class45_2_1, class45_3) ? 1 : 0);
    this.method_176((Class45) class45_2_2);
  }

  private static Exception smethod_30(string string_0, string string_1) => (Exception) new MethodAccessException(Class39.smethod_13(string.Format("security transparent method '{0}'", (object) string_0), string.Format("security critical method '{0}'", (object) string_1)));

  private void method_300(Class45 class45_2)
  {
    Class45 class45_3 = this.method_10();
    if (!Class39.smethod_24(this.method_10(), class45_3))
      return;
    this.method_160(((Class64) class45_2).method_2());
  }

  private void method_301(Class45 class45_2) => this.method_176(class45_2);

  private delegate void Delegate1(Class45 class45_0);

  [Serializable]
  private sealed class Class40
  {
    public static readonly Class39.Class40 class40_0 = new Class39.Class40();
    public static Comparison<Class34> comparison_0;

    internal int method_0(Class34 class34_0, Class34 class34_1) => (int) class34_0.method_8() == (int) class34_1.method_8() ? class34_1.method_6().CompareTo(class34_0.method_6()) : class34_0.method_8().CompareTo(class34_1.method_8());
  }

  private struct Struct3 : IEquatable<Class39.Struct3>
  {
    private readonly MethodBase methodBase_0;
    private readonly bool bool_0;

    public Struct3(MethodBase methodBase_1, bool bool_1)
    {
      this.methodBase_0 = methodBase_1;
      this.bool_0 = bool_1;
    }

    public MethodBase method_0() => this.methodBase_0;

    public bool method_1() => this.bool_0;

    public override int GetHashCode() => this.method_0().GetHashCode() ^ this.method_1().GetHashCode();

    public override bool Equals(object obj) => obj is Class39.Struct3 other && this.Equals(other);

    public bool Equals(Class39.Struct3 other) => (object) this.method_0() == (object) other.method_0() && this.method_1() == other.method_1();
  }

  private sealed class Class41
  {
    private string string_0;
    private Type type_0;

    public string method_0() => this.string_0;

    public void method_1(string string_1) => this.string_0 = string_1;

    public Type method_2() => this.type_0;

    public void method_3(Type type_1) => this.type_0 = type_1;
  }

  private struct Struct4
  {
    public bool bool_0;
  }

  private struct Struct5
  {
    private readonly uint uint_0;
    private readonly object object_0;

    public Struct5(uint uint_1)
    {
      this.uint_0 = uint_1;
      this.object_0 = (object) null;
    }

    public Struct5(uint uint_1, object object_1)
    {
      this.uint_0 = uint_1;
      this.object_0 = object_1;
    }

    public uint method_0() => this.uint_0;

    public object method_1() => this.object_0;
  }

  private sealed class Class42<T> : IComparer<KeyValuePair<int, T>>
  {
    private readonly Comparison<T> comparison_0;

    public Class42(Comparison<T> comparison_1) => this.comparison_0 = comparison_1;

    public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
    {
      int num = this.comparison_0(x.Value, y.Value);
      return num == 0 ? y.Key.CompareTo(x.Key) : num;
    }
  }

  private delegate object Delegate2(object object_0, object[] object_1);

  private sealed class Class43
  {
    public Class17 class17_0;
    public Class39.Delegate1 delegate1_0;

    public Class43(Class17 class17_1, Class39.Delegate1 delegate1_1)
    {
      this.class17_0 = class17_1;
      this.delegate1_0 = delegate1_1;
    }
  }
}
