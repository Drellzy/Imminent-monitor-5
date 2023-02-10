// Decompiled with JetBrains decompiler
// Type: GClass17
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Windows.Forms;

public sealed class GClass17 : SplitContainer
{
  protected override void OnPaint(PaintEventArgs e) => base.OnPaint(e);

  protected override void OnMouseDown(MouseEventArgs e)
  {
    this.IsSplitterFixed = true;
    base.OnMouseDown(e);
  }

  protected override void OnMouseUp(MouseEventArgs e)
  {
    this.IsSplitterFixed = false;
    base.OnMouseUp(e);
  }

  protected override void OnMouseMove(MouseEventArgs e)
  {
    if (this.IsSplitterFixed)
    {
      if (e.Button.Equals((object) MouseButtons.Left))
      {
        if (this.Orientation.Equals((object) Orientation.Vertical))
        {
          if (e.X > 0 && e.X < this.Width)
          {
            this.SplitterDistance = e.X;
            this.Refresh();
          }
        }
        else if (e.Y > 0 && e.Y < this.Height)
        {
          this.SplitterDistance = e.Y;
          this.Refresh();
        }
      }
      else
        this.IsSplitterFixed = false;
    }
    base.OnMouseMove(e);
  }
}
