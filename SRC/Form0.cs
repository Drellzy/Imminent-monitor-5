// Decompiled with JetBrains decompiler
// Type: Form0
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[GeneratedCode("MyTemplate", "12.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class Form0 : WindowsFormsApplicationBase
{
  [DebuggerStepThrough]
  public Form0()
    : base(AuthenticationMode.Windows)
  {
    this.IsSingleInstance = false;
    this.EnableVisualStyles = true;
    this.SaveMySettingsOnExit = true;
    this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
  }

  [DebuggerHidden]
  [STAThread]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [MethodImpl(MethodImplOptions.NoOptimization)]
  internal static void smethod_0(string[] string_0)
  {
    try
    {
      Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
    }
    finally
    {
    }
    Class132.smethod_1().Run(string_0);
  }

  [DebuggerStepThrough]
  protected override void OnCreateMainForm() => this.MainForm = (Form) Class132.smethod_3().method_4();
}
