using System;
using System.Windows.Forms;

namespace IdleCalculationAppDemo
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private const string IdleText = "The keyboard or mouse have not been touched in this application since ";
    private TimeSpan _idleTimeSpan;
    
    private void Form1_Load(object sender, EventArgs e)
    {
      labelIdleTime.Text = IdleText + TimeToString(new TimeSpan(0, 0, 1));
    }

    private void timerIdle_Tick(object sender, EventArgs e)
    {
      _idleTimeSpan = _idleTimeSpan.Add(new TimeSpan(0, 0, 1));
      labelIdleTime.Text = IdleText + TimeToString(_idleTimeSpan);
    }

    private static string TimeToString(TimeSpan timeSpan)
    {
      string result = string.Empty;
      if (timeSpan.Days > 0)
      {
        result = timeSpan.Days + " day" + Plural(timeSpan.Days) + " ";
      }

      if (timeSpan.Hours > 0)
      {
        result += timeSpan.Hours + " hour" + Plural(timeSpan.Hours) + " ";
      }

      if (timeSpan.Minutes > 0)
      {
        result += timeSpan.Minutes + " minute" + Plural(timeSpan.Minutes) + " ";
      }

      if (timeSpan.Seconds > 0)
      {
        result += timeSpan.Seconds + " second" + Plural(timeSpan.Seconds) + " ";
      }

      if (timeSpan.Milliseconds > 0)
      {
        result += timeSpan.Milliseconds + " millisecond" + Plural(timeSpan.Milliseconds);
      }

      return result;
    }

    private static string Plural(int number)
    {
      return number > 1 ? "s" : string.Empty;
    }

    private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
    {
      _idleTimeSpan = new TimeSpan();
    }

    private void FormMain_MouseMove(object sender, MouseEventArgs e)
    {
      _idleTimeSpan = new TimeSpan();
    }

    private void FormMain_MouseDown(object sender, MouseEventArgs e)
    {
      _idleTimeSpan = new TimeSpan();
    }

    private void FormMain_MouseEnter(object sender, EventArgs e)
    {
      _idleTimeSpan = new TimeSpan();
    }

    private void FormMain_MouseClick(object sender, MouseEventArgs e)
    {
      _idleTimeSpan = new TimeSpan();
    }

    private void FormMain_MouseUp(object sender, MouseEventArgs e)
    {
      _idleTimeSpan = new TimeSpan();
    }
  }
}