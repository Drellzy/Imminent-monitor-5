// Decompiled with JetBrains decompiler
// Type: Class35
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

internal sealed class Class35
{
  public readonly Class17 class17_0;
  public readonly Class17 class17_1;
  public readonly Class17 class17_2;
  public readonly Class17 class17_3;
  public readonly Class17 class17_4;
  public readonly Class17 class17_5;
  public readonly Class17 class17_6;
  public readonly Class17 class17_7;
  public readonly Class17 class17_8;
  public readonly Class17 class17_9;
  public readonly Class17 class17_10;
  public readonly Class17 class17_11;
  public readonly Class17 class17_12;
  public readonly Class17 class17_13;
  public readonly Class17 class17_14;
  public readonly Class17 class17_15;
  public readonly Class17 class17_16;
  public readonly Class17 class17_17;
  public readonly Class17 class17_18;
  public readonly Class17 class17_19;
  public readonly Class17 class17_20;
  public readonly Class17 class17_21;
  public readonly Class17 class17_22;
  public readonly Class17 class17_23;
  public readonly Class17 class17_24;
  public readonly Class17 class17_25;
  public readonly Class17 class17_26;
  public readonly Class17 class17_27;
  public readonly Class17 class17_28;
  public readonly Class17 class17_29;
  public readonly Class17 class17_30;
  public readonly Class17 class17_31;
  public readonly Class17 class17_32;
  public readonly Class17 class17_33;
  public readonly Class17 class17_34;
  public readonly Class17 class17_35;
  public readonly Class17 class17_36;
  public readonly Class17 class17_37;
  public readonly Class17 class17_38;
  public readonly Class17 class17_39;
  public readonly Class17 class17_40;
  public readonly Class17 class17_41;
  public readonly Class17 class17_42;
  public readonly Class17 class17_43;
  public readonly Class17 class17_44;
  public readonly Class17 class17_45;
  public readonly Class17 class17_46;
  public readonly Class17 class17_47;
  public readonly Class17 class17_48;
  public readonly Class17 class17_49;
  public readonly Class17 class17_50;
  public readonly Class17 class17_51;
  public readonly Class17 class17_52;
  public readonly Class17 class17_53;
  public readonly Class17 class17_54;
  public readonly Class17 class17_55;
  public readonly Class17 class17_56;
  public readonly Class17 class17_57;
  public readonly Class17 class17_58;
  public readonly Class17 class17_59;
  public readonly Class17 class17_60;
  public readonly Class17 class17_61;
  public readonly Class17 class17_62;
  public readonly Class17 class17_63;
  public readonly Class17 class17_64;
  public readonly Class17 class17_65;
  public readonly Class17 class17_66;
  public readonly Class17 class17_67;
  public readonly Class17 class17_68;
  public readonly Class17 class17_69;
  public readonly Class17 class17_70;
  public readonly Class17 class17_71;
  public readonly Class17 class17_72;
  public readonly Class17 class17_73;
  public readonly Class17 class17_74;
  public readonly Class17 class17_75;
  public readonly Class17 class17_76;
  public readonly Class17 class17_77;
  public readonly Class17 class17_78;
  private bool bool_0;
  public readonly Class17 class17_79;
  public readonly Class17 class17_80;
  public readonly Class17 class17_81;
  public readonly Class17 class17_82;
  public readonly Class17 class17_83;
  public readonly Class17 class17_84;
  public readonly Class17 class17_85;
  public readonly Class17 class17_86;
  public readonly Class17 class17_87;
  public readonly Class17 class17_88;
  public readonly Class17 class17_89;
  public readonly Class17 class17_90;
  public readonly Class17 class17_91;
  public readonly Class17 class17_92;
  public readonly Class17 class17_93;
  public readonly Class17 class17_94;
  public readonly Class17 class17_95;
  public readonly Class17 class17_96;
  public readonly Class17 class17_97;
  private Class17[] class17_98;
  public readonly Class17 class17_99;
  public readonly Class17 class17_100;
  public readonly Class17 class17_101;
  public readonly Class17 class17_102;
  public readonly Class17 class17_103;
  public readonly Class17 class17_104;
  public readonly Class17 class17_105;
  public readonly Class17 class17_106;
  public readonly Class17 class17_107;
  public readonly Class17 class17_108;
  public readonly Class17 class17_109;
  public readonly Class17 class17_110;
  public readonly Class17 class17_111;
  public readonly Class17 class17_112;
  public readonly Class17 class17_113;
  public readonly Class17 class17_114;
  public readonly Class17 class17_115;
  public readonly Class17 class17_116;
  public readonly Class17 class17_117;
  public readonly Class17 class17_118;
  public readonly Class17 class17_119;
  public readonly Class17 class17_120;
  public readonly Class17 class17_121;
  public readonly Class17 class17_122;
  public readonly Class17 class17_123;
  public readonly Class17 class17_124;
  public readonly Class17 class17_125;
  public readonly Class17 class17_126;
  public readonly Class17 class17_127;
  public readonly Class17 class17_128;
  public readonly Class17 class17_129;
  public readonly Class17 class17_130;
  public readonly Class17 class17_131;
  public readonly Class17 class17_132;
  public readonly Class17 class17_133;
  public readonly Class17 class17_134;
  public readonly Class17 class17_135;
  public readonly Class17 class17_136;
  public readonly Class17 class17_137;
  public readonly Class17 class17_138;
  public readonly Class17 class17_139;
  public readonly Class17 class17_140;
  public readonly Class17 class17_141;
  public readonly Class17 class17_142;
  public readonly Class17 class17_143;
  public readonly Class17 class17_144;
  public readonly Class17 class17_145;
  public readonly Class17 class17_146;
  public readonly Class17 class17_147;
  public readonly Class17 class17_148;
  public readonly Class17 class17_149;
  public readonly Class17 class17_150;
  public readonly Class17 class17_151;
  public readonly Class17 class17_152;
  public readonly Class17 class17_153;
  public readonly Class17 class17_154;
  public readonly Class17 class17_155;
  public readonly Class17 class17_156;
  public readonly Class17 class17_157;
  public readonly Class17 class17_158;
  public readonly Class17 class17_159;
  public readonly Class17 class17_160;
  public readonly Class17 class17_161;
  public readonly Class17 class17_162;
  public readonly Class17 class17_163;
  public readonly Class17 class17_164;
  public readonly Class17 class17_165;
  public readonly Class17 class17_166;
  public readonly Class17 class17_167;
  public readonly Class17 class17_168;
  public readonly Class17 class17_169;
  public readonly Class17 class17_170;
  public readonly Class17 class17_171;
  public readonly Class17 class17_172;
  public readonly Class17 class17_173;
  public readonly Class17 class17_174;
  public readonly Class17 class17_175;
  public readonly Class17 class17_176;
  public readonly Class17 class17_177;
  public readonly Class17 class17_178;
  public readonly Class17 class17_179;
  public readonly Class17 class17_180;
  public readonly Class17 class17_181;
  public readonly Class17 class17_182;
  public readonly Class17 class17_183;
  public readonly Class17 class17_184;
  public readonly Class17 class17_185;
  public readonly Class17 class17_186;
  public readonly Class17 class17_187;
  public readonly Class17 class17_188;
  public readonly Class17 class17_189;
  public readonly Class17 class17_190;
  public readonly Class17 class17_191;
  public readonly Class17 class17_192;
  public readonly Class17 class17_193;
  public readonly Class17 class17_194;
  public readonly Class17 class17_195;
  public readonly Class17 class17_196;
  public readonly Class17 class17_197;
  public readonly Class17 class17_198;
  public readonly Class17 class17_199;
  public readonly Class17 class17_200;
  public readonly Class17 class17_201;
  public readonly Class17 class17_202;
  public readonly Class17 class17_203;
  public readonly Class17 class17_204;
  public readonly Class17 class17_205;
  public readonly Class17 class17_206;
  public readonly Class17 class17_207;
  public readonly Class17 class17_208;
  public readonly Class17 class17_209;
  public readonly Class17 class17_210;
  public readonly Class17 class17_211;
  public readonly Class17 class17_212;
  public readonly Class17 class17_213;

  public Class35()
  {
    this.class17_43 = new Class17(-406830620, 1);
    this.class17_85 = new Class17(569245362, 1);
    this.class17_212 = new Class17(2087443724, 1);
    this.class17_204 = new Class17(1468447000, 1);
    this.class17_86 = new Class17(1918161193, 6);
    this.class17_103 = new Class17(-1346230269, 1);
    this.class17_165 = new Class17(-308281485, 1);
    this.class17_119 = new Class17(1489450613, 1);
    this.class17_31 = new Class17(649258900, 10);
    this.class17_106 = new Class17(855381591, 1);
    this.class17_87 = new Class17(-1076017795, 1);
    this.class17_141 = new Class17(246671837, 1);
    this.class17_104 = new Class17(1035731275, 1);
    this.class17_121 = new Class17(1218206656, 1);
    this.class17_107 = new Class17(-666527581, 1);
    this.class17_153 = new Class17(-1797393393, 1);
    this.class17_24 = new Class17(1415935531, 1);
    this.class17_82 = new Class17(-360085655, 1);
    this.class17_207 = new Class17(1578131279, 1);
    this.class17_186 = new Class17(1572279836, 1);
    this.class17_20 = new Class17(-1268231959, 1);
    this.class17_91 = new Class17(60569667, 5);
    this.class17_90 = new Class17(-368399072, 3);
    this.class17_192 = new Class17(-399636439, 6);
    this.class17_3 = new Class17(1338008850, 6);
    this.class17_51 = new Class17(-861863967, 1);
    this.class17_156 = new Class17(1979086341, 1);
    this.class17_210 = new Class17(-1407926109, 1);
    this.class17_181 = new Class17(-1960240495, 1);
    this.class17_8 = new Class17(1987509687, 6);
    this.class17_174 = new Class17(1876297304, 1);
    this.class17_38 = new Class17(1597308913, 1);
    this.class17_12 = new Class17(-2089294243, 7);
    this.class17_176 = new Class17(1842203673, 1);
    this.class17_67 = new Class17(-1869297460, 1);
    this.class17_6 = new Class17(-73206976, 1);
    this.class17_34 = new Class17(-648112088, 1);
    this.class17_112 = new Class17(-1648851301, 1);
    this.class17_163 = new Class17(-775971567, 5);
    this.class17_52 = new Class17(2011395636, 0);
    this.class17_61 = new Class17(-1057908583, 1);
    this.class17_173 = new Class17(696592259, 1);
    this.class17_128 = new Class17(-941551601, 5);
    this.class17_64 = new Class17(-1309540691, 1);
    this.class17_110 = new Class17(1214671157, 6);
    this.class17_73 = new Class17(-1324582863, 5);
    this.class17_60 = new Class17(-187283357, 6);
    this.class17_151 = new Class17(-43007505, 1);
    this.class17_132 = new Class17(1194873121, 1);
    this.class17_167 = new Class17(-1198154025, 1);
    this.class17_211 = new Class17(1625928288, 1);
    this.class17_158 = new Class17(1094958061, 1);
    this.class17_136 = new Class17(495535393, 1);
    this.class17_160 = new Class17(-733590880, 5);
    this.class17_188 = new Class17(320908652, 1);
    this.class17_139 = new Class17(-471449065, 1);
    this.class17_172 = new Class17(-1235448984, 1);
    this.class17_4 = new Class17(-1840998412, 3);
    this.class17_179 = new Class17(-14007260, 6);
    this.class17_46 = new Class17(368242808, 1);
    this.class17_193 = new Class17(-108705861, 1);
    this.class17_205 = new Class17(1049296157, 6);
    this.class17_7 = new Class17(317411028, 1);
    this.class17_122 = new Class17(1732896279, 1);
    this.class17_200 = new Class17(1487376155, 1);
    this.class17_118 = new Class17(1020184408, 1);
    this.class17_83 = new Class17(116405822, 1);
    this.class17_80 = new Class17(-441260059, 3);
    this.class17_145 = new Class17(-2070095517, 1);
    this.class17_5 = new Class17(1320132267, 1);
    this.class17_213 = new Class17(496980502, 6);
    this.class17_120 = new Class17(160771596, 1);
    this.class17_44 = new Class17(1104112394, 6);
    this.class17_32 = new Class17(-780805175, 1);
    this.class17_147 = new Class17(-233676992, 6);
    this.class17_208 = new Class17(-1021464049, 1);
    this.class17_185 = new Class17(1681157071, 1);
    this.class17_36 = new Class17(665200358, 1);
    this.class17_35 = new Class17(-1017893567, 1);
    this.class17_189 = new Class17(340111517, 5);
    this.class17_78 = new Class17(1830118541, 1);
    this.class17_33 = new Class17(-1844166881, 1);
    this.class17_133 = new Class17(-1300263875, 6);
    this.class17_195 = new Class17(-1430573264, 7);
    this.class17_149 = new Class17(-1850988981, 1);
    this.class17_180 = new Class17(-433725485, 1);
    this.class17_56 = new Class17(-1041493202, 6);
    this.class17_66 = new Class17(116411347, 1);
    this.class17_190 = new Class17(-1572860516, 1);
    this.class17_187 = new Class17(-67484523, 1);
    this.class17_57 = new Class17(1160040411, 2);
    this.class17_111 = new Class17(-112649168, 1);
    this.class17_58 = new Class17(-592274722, 1);
    this.class17_47 = new Class17(656522910, 1);
    this.class17_161 = new Class17(-1945237283, 1);
    this.class17_140 = new Class17(2031895987, 3);
    this.class17_117 = new Class17(511421776, 1);
    this.class17_49 = new Class17(406521069, 1);
    this.class17_170 = new Class17(-261215620, 1);
    this.class17_99 = new Class17(-123398846, 1);
    this.class17_17 = new Class17(-1006263539, 1);
    this.class17_175 = new Class17(943576895, 1);
    this.class17_114 = new Class17(1122723345, 1);
    this.class17_144 = new Class17(787634882, 6);
    this.class17_142 = new Class17(497615932, 1);
    this.class17_162 = new Class17(-1573116041, 1);
    this.class17_13 = new Class17(-194079381, 1);
    this.class17_21 = new Class17(-1024372347, 6);
    this.class17_202 = new Class17(-1742000632, 1);
    this.class17_22 = new Class17(-864690155, 1);
    this.class17_125 = new Class17(-298359179, 6);
    this.class17_124 = new Class17(-1745007600, 5);
    this.class17_154 = new Class17(-826347234, 1);
    this.class17_1 = new Class17(159746859, 1);
    this.class17_196 = new Class17(293275588, 6);
    this.class17_84 = new Class17(1032443871, 1);
    this.class17_129 = new Class17(2091555041, 1);
    this.class17_201 = new Class17(-2127423797, 1);
    this.class17_102 = new Class17(-895829076, 1);
    this.class17_69 = new Class17(-1845113489, 1);
    this.class17_169 = new Class17(408792669, 1);
    this.class17_68 = new Class17(-926284703, 1);
    this.class17_182 = new Class17(-234024552, 1);
    this.class17_115 = new Class17(-702636665, 1);
    this.class17_48 = new Class17(-1645117434, 1);
    this.class17_183 = new Class17(-1861718439, 1);
    this.class17_39 = new Class17(-721394150, 1);
    this.class17_138 = new Class17(1817714731, 1);
    this.class17_197 = new Class17(401708155, 1);
    this.class17_65 = new Class17(-588330506, 1);
    this.class17_157 = new Class17(574092747, 1);
    this.class17_30 = new Class17(-1179462520, 1);
    this.class17_79 = new Class17(-85616036, 1);
    this.class17_81 = new Class17(1675057932, 6);
    this.class17_14 = new Class17(-2102409929, 1);
    this.class17_113 = new Class17(1372404311, 6);
    this.class17_2 = new Class17(-215841614, 4);
    this.class17_166 = new Class17(-409580163, 1);
    this.class17_109 = new Class17(-491234889, 1);
    this.class17_178 = new Class17(1354436239, 1);
    this.class17_92 = new Class17(1571266635, 6);
    this.class17_97 = new Class17(-370835851, 10);
    this.class17_62 = new Class17(645365503, 6);
    this.class17_143 = new Class17(-1523028854, 1);
    this.class17_50 = new Class17(1180767865, 1);
    this.class17_96 = new Class17(604182150, 5);
    this.class17_89 = new Class17(-2110980653, 1);
    this.class17_203 = new Class17(-1212504756, 5);
    this.class17_29 = new Class17(257274892, 1);
    this.class17_146 = new Class17(1546283913, 5);
    this.class17_123 = new Class17(119093362, 1);
    this.class17_53 = new Class17(-719207358, 1);
    this.class17_100 = new Class17(-650166183, 3);
    this.class17_108 = new Class17(-1262110186, 7);
    this.class17_45 = new Class17(1865388379, 1);
    this.class17_41 = new Class17(599550326, 12);
    this.class17_40 = new Class17(795688329, 9);
    this.class17_134 = new Class17(50746717, 1);
    this.class17_54 = new Class17(1394178940, 6);
    this.class17_75 = new Class17(-264979549, 3);
    this.class17_150 = new Class17(-935910112, 1);
    this.class17_74 = new Class17(429661695, 1);
    this.class17_206 = new Class17(1291614893, 1);
    this.class17_42 = new Class17(-2030698737, 6);
    this.class17_168 = new Class17(-236013107, 1);
    this.class17_135 = new Class17(-1764961264, 1);
    this.class17_95 = new Class17(1650898031, 6);
    this.class17_76 = new Class17(974216414, 5);
    this.class17_94 = new Class17(1181598972, 1);
    this.class17_25 = new Class17(-237996330, 7);
    this.class17_164 = new Class17(876381938, 1);
    this.class17_184 = new Class17(-1285944482, 1);
    this.class17_28 = new Class17(-555505942, 1);
    this.class17_72 = new Class17(-1188534800, 6);
    this.class17_105 = new Class17(-1827268908, 1);
    this.class17_37 = new Class17(-1160241808, 5);
    this.class17_159 = new Class17(1233881249, 1);
    this.class17_19 = new Class17(-1656296192, 6);
    this.class17_131 = new Class17(1728068677, 1);
    this.class17_130 = new Class17(-77205863, 5);
    this.class17_116 = new Class17(-1570897451, 1);
    this.class17_9 = new Class17(942110363, 1);
    this.class17_155 = new Class17(191362183, 6);
    this.class17_101 = new Class17(-1618314170, 1);
    this.class17_198 = new Class17(1736928614, 1);
    this.class17_77 = new Class17(-1873117171, 6);
    this.class17_148 = new Class17(-1660331465, 9);
    this.class17_63 = new Class17(-1353112978, 1);
    this.class17_55 = new Class17(1472167396, 1);
    this.class17_26 = new Class17(-388422019, 1);
    this.class17_11 = new Class17(-1674807901, 7);
    this.class17_0 = new Class17(1574245332, 1);
    this.class17_191 = new Class17(-1617400574, 1);
    this.class17_194 = new Class17(-429394028, 1);
    this.class17_18 = new Class17(1630049663, 6);
    this.class17_15 = new Class17(1731235137, 1);
    this.class17_27 = new Class17(-619325950, 1);
    this.class17_16 = new Class17(163644177, 1);
    this.class17_171 = new Class17(-604579424, 1);
    this.class17_71 = new Class17(-691662884, 7);
    this.class17_127 = new Class17(587936721, 1);
    this.class17_59 = new Class17(1248035167, 1);
    this.class17_93 = new Class17(843096592, 6);
    this.class17_10 = new Class17(710545672, 1);
    this.class17_70 = new Class17(-306026148, 1);
    this.class17_177 = new Class17(-1755829732, 1);
    this.class17_137 = new Class17(1748324312, 1);
    this.class17_23 = new Class17(-1878160288, 1);
    this.class17_199 = new Class17(1011715227, 6);
    this.class17_126 = new Class17(-1239642172, 6);
    this.class17_152 = new Class17(810301353, 1);
    this.class17_209 = new Class17(772459271, 1);
    // ISSUE: explicit constructor call
    base.\u002Ector();
  }

  public IEnumerable<Class17> method_0() => (IEnumerable<Class17>) new Class35.Class37(-2)
  {
    class35_0 = this
  };

  public bool method_1() => this.bool_0;

  public void method_2(bool bool_1) => this.bool_0 = bool_1;

  public Class17[] method_3()
  {
    if (this.class17_98 == null)
    {
      lock (this)
      {
        if (this.class17_98 == null)
        {
          List<Class17> class17List = new List<Class17>(256);
          foreach (Class17 class17 in this.method_0())
            class17List.Add(class17);
          class17List.Sort(Class35.Class36.comparison_0 ?? (Class35.Class36.comparison_0 = new Comparison<Class17>(Class35.Class36.class36_0.method_0)));
          this.class17_98 = class17List.ToArray();
        }
      }
    }
    return this.class17_98;
  }

  [Serializable]
  private sealed class Class36
  {
    public static readonly Class35.Class36 class36_0 = new Class35.Class36();
    public static Comparison<Class17> comparison_0;

    internal int method_0(Class17 class17_0, Class17 class17_1) => class17_0.method_0().CompareTo(class17_1.method_0());
  }

  private sealed class Class37 : 
    IDisposable,
    IEnumerable<Class17>,
    IEnumerator<Class17>,
    IEnumerable,
    IEnumerator
  {
    private int int_0;
    private Class17 class17_0;
    private int int_1;
    public Class35 class35_0;
    private FieldInfo[] fieldInfo_0;
    private int int_2;

    [DebuggerHidden]
    public Class37(int int_3)
    {
      this.int_0 = int_3;
      this.int_1 = Thread.CurrentThread.ManagedThreadId;
    }

    [DebuggerHidden]
    void IDisposable.Dispose()
    {
    }

    bool IEnumerator.MoveNext()
    {
      int int0 = this.int_0;
      Class35 class350 = this.class35_0;
      switch (int0)
      {
        case 0:
          this.int_0 = -1;
          this.fieldInfo_0 = typeof (Class35).GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
          this.int_2 = 0;
          break;
        case 1:
          this.int_0 = -1;
          ++this.int_2;
          break;
        default:
          return false;
      }
      if (this.int_2 >= this.fieldInfo_0.Length)
      {
        this.fieldInfo_0 = (FieldInfo[]) null;
        return false;
      }
      this.class17_0 = (Class17) this.fieldInfo_0[this.int_2].GetValue((object) class350);
      this.int_0 = 1;
      return true;
    }

    [DebuggerHidden]
    Class17 IEnumerator<Class17>.get_Current() => this.class17_0;

    [DebuggerHidden]
    void IEnumerator.Reset() => throw new NotSupportedException();

    [DebuggerHidden]
    object IEnumerator.get_Current() => (object) this.class17_0;

    [DebuggerHidden]
    IEnumerator<Class17> IEnumerable<Class17>.GetEnumerator()
    {
      Class35.Class37 enumerator;
      if (this.int_0 == -2 && this.int_1 == Thread.CurrentThread.ManagedThreadId)
      {
        this.int_0 = 0;
        enumerator = this;
      }
      else
      {
        enumerator = new Class35.Class37(0);
        enumerator.class35_0 = this.class35_0;
      }
      return (IEnumerator<Class17>) enumerator;
    }

    [DebuggerHidden]
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CClass17\u003E\u002EGetEnumerator();

    public virtual long Length
    {
      [SpecialName] get => this.method_0().Length;
    }

    public virtual long Position
    {
      [SpecialName] get => this.method_0().Position;
      [SpecialName] set => this.method_0().Position = value;
    }
  }
}
