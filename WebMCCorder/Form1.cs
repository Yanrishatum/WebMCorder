using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMCCorder
{
    public partial class Main : Form
    {
        private const string REGISTRY_ROOT = @"HKEY_CURRENT_USER\Software\WebMCorder";
        private const string SCREENCAP_ROOT = @"HKEY_CURRENT_USER\Software\screen-capture-recorder";
        private const string FFMPEG_PARAMS = " -codec:v libvpx -quality realtime -cpu-used 0 -b:v 3000k -qmin 4 -qmax 63 -maxrate 3000k -bufsize 6000k -threads 4 -codec:a libvorbis";
        private const string FFMPEG_AUDIO = ":audio=\"virtual-audio-capturer\"";
        private const string FFMPEG_VIDEO = "-f dshow -i video=\"screen-capture-recorder\"";
        private const string FFMPEG_ALWAYS_ON_PARAMS = " -y";
        private const string FFMPEG_DISABLER = "";
        private PositioningWindow posSettings;

        private bool recording;
        private Process ffmpegProcess;
        private SaveFileDialog saveDialog;
        private int preShowSeconds;
        
        
        public Main()
        {
          InitializeComponent();
          Rectangle clientRect = this.ClientRectangle;
          Rectangle dispRect = this.Bounds;
          int left = this.mainDisplay.Left + (dispRect.Width - clientRect.Width) / 2;
          int top = this.mainDisplay.Top + (dispRect.Height - clientRect.Height - left);

          posSettings = new PositioningWindow(this, left, top);
        }

        public T GetValue<T>(string registryKeyPath, string value, T defaultValue = default(T))
        {
            T retVal = default(T);

            object regVal = Registry.GetValue(registryKeyPath, value, defaultValue);
            if (regVal != null) retVal = (T)regVal;

            return retVal;
        }

        private void initDisplay(object sender, EventArgs e)
        {
            int x = GetValue<int>(REGISTRY_ROOT, "winX", Bounds.X);
            int y = GetValue<int>(REGISTRY_ROOT, "winY", Bounds.Y);
            int w = GetValue<int>(REGISTRY_ROOT, "winW", Bounds.Width);
            int h = GetValue<int>(REGISTRY_ROOT, "winH", Bounds.Height);
            SetDesktopBounds(x, y, w, h);
            soundCheckbox.Checked = GetValue<int>(REGISTRY_ROOT, "recordAudio", 1) == 1;
            mp4_preset.Checked = GetValue<int>(REGISTRY_ROOT, "mp4", 0) == 1;
            recordMouse.Checked = GetValue<int>(REGISTRY_ROOT, "recordMouse", 1) == 1;
        }

        private void positioningButton_Click(object sender, EventArgs e)
        {
            posSettings.ShowDialog();
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            saveBorders();
        }

        public void saveBorders()
        {
            Rectangle bounds = this.Bounds;
            Registry.SetValue(REGISTRY_ROOT, "winX", bounds.X);
            Registry.SetValue(REGISTRY_ROOT, "winY", bounds.Y);
            Registry.SetValue(REGISTRY_ROOT, "winW", bounds.Width);
            Registry.SetValue(REGISTRY_ROOT, "winH", bounds.Height);
        }

        private void startRecording()
        {
          if (recording)
          {
            if (preShowTimer.Enabled)
            {
              preShowTimer.Stop();
              soundCheckbox.Enabled = true;
              positioningButton.Enabled = true;
              recordButton.Text = "Record";
            }
            else
            {
              postShowTimer.Start();
              statusLabel.Text = "Finishing...";
              recordButton.Enabled = false;
            }
            recording = false;
          }
          else
          {
            saveDialog = new SaveFileDialog();
            if (mp4_preset.Checked)
            {
              saveDialog.Filter = "MPEG Layer 4 files (*.mp4)|*.mp4|All files|*.*";
              saveDialog.FileName = "output.mp4";
            }
            else
            {
              saveDialog.Filter = "WebM files (*.webm)|*.webm|All files|*.*";
              saveDialog.FileName = "output.webm";
            }
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            recording = true;

            this.ControlBox = false;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            recordButton.Text = "Stop";
            soundCheckbox.Enabled = false;
            positioningButton.Enabled = false;

            preShowSeconds = 3;
            preShowTimer.Start();
          }
          
        }
        
      private void startRecord()
        {
          string output = " \"" + saveDialog.FileName + "\"";

          Rectangle bounds = this.Bounds;
          Registry.SetValue(SCREENCAP_ROOT, "start_x", bounds.X + this.posSettings.offsetX);
          Registry.SetValue(SCREENCAP_ROOT, "start_y", bounds.Y + this.posSettings.offsetY);
          Registry.SetValue(SCREENCAP_ROOT, "capture_width", mainDisplay.Width);
          Registry.SetValue(SCREENCAP_ROOT, "capture_height", mainDisplay.Height);
          Registry.SetValue(SCREENCAP_ROOT, "capture_mouse_default_1", recordMouse.Checked ? 1 : 0);

          string args = FFMPEG_VIDEO;
          if (soundCheckbox.Checked) args += FFMPEG_AUDIO;
          if (!mp4_preset.Checked) args += FFMPEG_PARAMS;
          args += FFMPEG_ALWAYS_ON_PARAMS + output;
          
          ffmpegProcess = new Process();
          ffmpegProcess.StartInfo.CreateNoWindow = true;
          ffmpegProcess.StartInfo.RedirectStandardInput = true;  
          //ffmpegProcess.StartInfo.RedirectStandardError = true;
          //ffmpegProcess.StartInfo.RedirectStandardOutput = true;
          ffmpegProcess.StartInfo.UseShellExecute = false;
          ffmpegProcess.StartInfo.Arguments = args;
          ffmpegProcess.StartInfo.FileName = "ffmpeg";
          ffmpegProcess.Start();

          statusLabel.Text = "Recording";
        }
        
        protected override void WndProc(ref Message message)
        {
          if (recording)
          {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
              case WM_SYSCOMMAND:
                int command = message.WParam.ToInt32() & 0xfff0;
                if (command == SC_MOVE)
                  return;
                break;
            }
          }

          base.WndProc(ref message);
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
          startRecording();
        }

        private void soundCheckbox_CheckedChanged(object sender, EventArgs e)
        {
          Registry.SetValue(REGISTRY_ROOT, "recordAudio", soundCheckbox.Checked ? 1 : 0);
        }

        private void preShowSecond(object sender, EventArgs e)
        {
          preShowSeconds--;
          if (preShowSeconds == 0)
          {
            preShowTimer.Stop();
            startRecord();
          }
          else statusLabel.Text = "Preshow: " + preShowSeconds;
        }

        private void postShowTimer_Tick(object sender, EventArgs e)
        {
          postShowTimer.Stop();
          ffmpegProcess.StandardInput.Write("q");
          ffmpegProcess.StandardInput.Flush();
          //ffmpegProcess.Kill();
          statusLabel.Text = "";
          recordButton.Text = "Record";
          recordButton.Enabled = true;
          soundCheckbox.Enabled = true;
          positioningButton.Enabled = true;
          this.ControlBox = true;
          this.TopMost = false;
          this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          Registry.SetValue(REGISTRY_ROOT, "mp4", mp4_preset.Checked ? 1 : 0);
        }

    }
}
