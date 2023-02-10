﻿// Decompiled with JetBrains decompiler
// Type: Class93
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class93
{
  public static FormLogin formLogin_0;

  public enum LicensePacket : byte
  {
    Register,
    Login,
    ChangeKey,
    Update,
    Variable,
    GetSalt,
    Ping,
    Deny,
    UpdateNotification,
    Session,
    ErrorMessage,
  }

  public enum LoginMessage : byte
  {
    Success,
    IncorrectUsernameOrPassword,
    YourHardwareIdHasBeenChangedPleaseCreateASupportTicket,
    LicenseBannedFor,
  }

  public enum RegisterMessage : byte
  {
    RegistrationSuccessYouCanNowLogIn,
    ThisEmailIsInUse,
    ThisUsernameIsInUse,
    SerialAlreadyRegisteredOrInvalid,
    TransactionIdInvalid,
  }

  public enum RegisterPacket : byte
  {
    Normal,
    PayPal,
    Bitcoin,
  }

  public enum SessionPacket : byte
  {
    Key,
    Login,
    Refresh,
    ValidLogin,
    InvalidLogin,
    ValidRefresh,
    InvalidRefresh,
  }

  public enum UpdatePacket : byte
  {
    NoUpdateRequired,
    Update,
  }
}