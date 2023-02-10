// Decompiled with JetBrains decompiler
// Type: Class132
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[HideModuleName]
[GeneratedCode("MyTemplate", "12.0.0.0")]
[StandardModule]
internal sealed class Class132
{
  private static readonly Class132.Class134<Class110> class134_0 = new Class132.Class134<Class110>();
  private static readonly Class132.Class134<Form0> class134_1 = new Class132.Class134<Form0>();
  private static readonly Class132.Class134<User> class134_2 = new Class132.Class134<User>();
  private static Class132.Class134<Class132.Class135> class134_3 = new Class132.Class134<Class132.Class135>();
  private static readonly Class132.Class134<Class132.Class133> class134_4 = new Class132.Class134<Class132.Class133>();

  [DebuggerHidden]
  internal static Class110 smethod_0() => Class132.class134_0.method_0();

  [DebuggerHidden]
  internal static Form0 smethod_1() => Class132.class134_1.method_0();

  [DebuggerHidden]
  internal static User smethod_2() => Class132.class134_2.method_0();

  [DebuggerHidden]
  internal static Class132.Class135 smethod_3() => Class132.class134_3.method_0();

  [DebuggerHidden]
  internal static Class132.Class133 smethod_4() => Class132.class134_4.method_0();

  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class Class133
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public Class133()
    {
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => base.Equals(RuntimeHelpers.GetObjectValue(obj));

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override int GetHashCode() => base.GetHashCode();

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal System.Type method_0() => typeof (Class132.Class133);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T smethod_0<T>(T gparam_0) where T : new() => (object) gparam_0 == null ? new T() : gparam_0;

    [DebuggerHidden]
    private void method_1<T>(ref T gparam_0) => gparam_0 = default (T);
  }

  [ComVisible(false)]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class Class134<T> where T : new()
  {
    [ThreadStatic]
    private static T gparam_0;

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Class134()
    {
    }

    [DebuggerHidden]
    internal T method_0()
    {
      if ((object) Class132.Class134<T>.gparam_0 == null)
        Class132.Class134<T>.gparam_0 = new T();
      return Class132.Class134<T>.gparam_0;
    }
  }

  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class Class135
  {
    public FormDediSettings formDediSettings_0;
    public FormGenerateSwiftCode formGenerateSwiftCode_0;
    public FormGeoIPHandler formGeoIPHandler_0;
    public FormHWIDWarning formHWIDWarning_0;
    public FormMain formMain_0;
    public FormProfiles formProfiles_0;
    [ThreadStatic]
    private static Hashtable hashtable_0;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public Class135()
    {
    }

    public FormDediSettings method_0()
    {
      this.formDediSettings_0 = Class132.Class135.smethod_0<FormDediSettings>(this.formDediSettings_0);
      return this.formDediSettings_0;
    }

    public FormGenerateSwiftCode method_1()
    {
      this.formGenerateSwiftCode_0 = Class132.Class135.smethod_0<FormGenerateSwiftCode>(this.formGenerateSwiftCode_0);
      return this.formGenerateSwiftCode_0;
    }

    public FormGeoIPHandler method_2()
    {
      this.formGeoIPHandler_0 = Class132.Class135.smethod_0<FormGeoIPHandler>(this.formGeoIPHandler_0);
      return this.formGeoIPHandler_0;
    }

    public FormHWIDWarning method_3()
    {
      this.formHWIDWarning_0 = Class132.Class135.smethod_0<FormHWIDWarning>(this.formHWIDWarning_0);
      return this.formHWIDWarning_0;
    }

    public FormMain method_4()
    {
      this.formMain_0 = Class132.Class135.smethod_0<FormMain>(this.formMain_0);
      return this.formMain_0;
    }

    public FormProfiles method_5()
    {
      this.formProfiles_0 = Class132.Class135.smethod_0<FormProfiles>(this.formProfiles_0);
      return this.formProfiles_0;
    }

    public void method_6(FormDediSettings formDediSettings_1)
    {
      if (formDediSettings_1 == this.formDediSettings_0)
        return;
      if (formDediSettings_1 != null)
        throw new ArgumentException("Property can only be set to Nothing");
      this.method_12<FormDediSettings>(ref this.formDediSettings_0);
    }

    public void method_7(FormGenerateSwiftCode formGenerateSwiftCode_1)
    {
      if (formGenerateSwiftCode_1 == this.formGenerateSwiftCode_0)
        return;
      if (formGenerateSwiftCode_1 != null)
        throw new ArgumentException("Property can only be set to Nothing");
      this.method_12<FormGenerateSwiftCode>(ref this.formGenerateSwiftCode_0);
    }

    public void method_8(FormGeoIPHandler formGeoIPHandler_1)
    {
      if (formGeoIPHandler_1 == this.formGeoIPHandler_0)
        return;
      if (formGeoIPHandler_1 != null)
        throw new ArgumentException("Property can only be set to Nothing");
      this.method_12<FormGeoIPHandler>(ref this.formGeoIPHandler_0);
    }

    public void method_9(FormHWIDWarning formHWIDWarning_1)
    {
      if (formHWIDWarning_1 == this.formHWIDWarning_0)
        return;
      if (formHWIDWarning_1 != null)
        throw new ArgumentException("Property can only be set to Nothing");
      this.method_12<FormHWIDWarning>(ref this.formHWIDWarning_0);
    }

    public void method_10(FormMain formMain_1)
    {
      if (formMain_1 == this.formMain_0)
        return;
      if (formMain_1 != null)
        throw new ArgumentException("Property can only be set to Nothing");
      this.method_12<FormMain>(ref this.formMain_0);
    }

    public void method_11(FormProfiles formProfiles_1)
    {
      if (formProfiles_1 == this.formProfiles_0)
        return;
      if (formProfiles_1 != null)
        throw new ArgumentException("Property can only be set to Nothing");
      this.method_12<FormProfiles>(ref this.formProfiles_0);
    }

    [DebuggerHidden]
    private static T smethod_0<T>(T gparam_0) where T : Form, new()
    {
      if ((object) gparam_0 != null && !gparam_0.IsDisposed)
        return gparam_0;
      if (Class132.Class135.hashtable_0 != null)
      {
        if (Class132.Class135.hashtable_0.ContainsKey((object) typeof (T)))
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
      }
      else
        Class132.Class135.hashtable_0 = new Hashtable();
      Class132.Class135.hashtable_0.Add((object) typeof (T), (object) null);
      try
      {
        return new T();
      }
      catch (TargetInvocationException ex) when (
      {
        // ISSUE: unable to correctly present filter
        ProjectData.SetProjectError((Exception) ex);
        if (ex.InnerException != null)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
      }
      finally
      {
        Class132.Class135.hashtable_0.Remove((object) typeof (T));
      }
    }

    [DebuggerHidden]
    private void method_12<T>(ref T gparam_0) where T : Form
    {
      gparam_0.Dispose();
      gparam_0 = default (T);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) => base.Equals(RuntimeHelpers.GetObjectValue(obj));

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal System.Type method_13() => typeof (Class132.Class135);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();
  }
}
