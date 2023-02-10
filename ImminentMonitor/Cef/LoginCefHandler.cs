// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.LoginCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

namespace ImminentMonitor.Cef
{
  public class LoginCefHandler
  {
    public FormLogin LoginForm;

    public LoginCefHandler(FormLogin loginForm) => this.LoginForm = loginForm;

    public void handleLoginClick(string username, string password, bool remember)
    {
      LoginCefHandler loginCefHandler = this;
      this.LoginForm.Invoke((Delegate) (() => loginCefHandler.Login(username, password, remember)));
    }

    public void handleRegisterClick(
      string code,
      string email,
      string password,
      string confirmPassword,
      string username)
    {
      LoginCefHandler loginCefHandler = this;
      this.LoginForm.Invoke((Delegate) (() => loginCefHandler.Register(code, email, password, confirmPassword, username)));
    }

    private void Login(string username, string password, bool remember)
    {
      object[] object_3 = new object[4]
      {
        (object) this,
        (object) username,
        (object) password,
        (object) remember
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "akr8FPa.Q$", object_3);
    }

    private void Register(
      string code,
      string email,
      string password,
      string confirmPassword,
      string username)
    {
      object[] object_3 = new object[6]
      {
        (object) this,
        (object) code,
        (object) email,
        (object) password,
        (object) confirmPassword,
        (object) username
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "Do\\$)Pa.Q$", object_3);
    }

    private bool CheckRegister(RegistrationDetails registrationDetails)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) registrationDetails
      };
      return (bool) Class86.smethod_0().method_270(Class86.smethod_1(), ",k@+^Pa.Q$", object_3);
    }
  }
}
