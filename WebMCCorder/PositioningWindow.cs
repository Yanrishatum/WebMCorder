using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WebMCCorder
{
    public partial class PositioningWindow : Form
    {

        private Main root;
        private Rectangle cancelBounds;
        public int offsetX;
        public int offsetY;

        private List<Process> processes;

        public PositioningWindow(Main main, int offX, int offY)
        {
            InitializeComponent();
            this.root = main;
            this.offsetX = offX;
            this.offsetY = offY;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.cancelBounds = root.Bounds;
            this.xInput.Value = cancelBounds.X + this.offsetX;
            this.yInput.Value = cancelBounds.Y + this.offsetY;
            this.wInput.Value = cancelBounds.Width - 8;
            this.hInput.Value = cancelBounds.Height - 58;
            refreshProcessList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.SetBounds(cancelBounds.X, cancelBounds.Y, cancelBounds.Width, cancelBounds.Height);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyBounds();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            applyBounds();
            this.Hide();
        }

        private void applyBounds()
        {
            root.SetBounds(Decimal.ToInt32(this.xInput.Value) - this.offsetX,
                           Decimal.ToInt32(this.yInput.Value) - this.offsetY,
                           Decimal.ToInt32(this.wInput.Value) + 8,
                           Decimal.ToInt32(this.hInput.Value) + 58);
            root.saveBorders();
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
          refreshProcessList();
        }

      private void refreshProcessList()
      {
         Process[] list = Process.GetProcesses();
         processes = new List<Process>();
         processList.Items.Clear();
         foreach (Process proc in list)
         {
           if (!String.IsNullOrEmpty(proc.MainWindowTitle))
           {
             processList.Items.Add(proc.MainWindowTitle + " (" + proc.ProcessName + ".exe)");
             processes.Add(proc);
           }
         }
      }

      private void snapToWindowButton_Click(object sender, EventArgs e)
      {
        if (processList.SelectedIndex >= 0)
        {
          Process proc = processes[processList.SelectedIndex];

          RECT rct;

          if (!GetWindowRect(new HandleRef(this, proc.MainWindowHandle), out rct))
          {
            MessageBox.Show("ERROR");
            return;
          }

          this.xInput.Value = rct.Left + this.offsetX;
          this.yInput.Value = rct.Top + this.offsetY - 2;
          this.wInput.Value = rct.Right - rct.Left - 8;
          this.hInput.Value = rct.Bottom - rct.Top - 27;
          applyBounds();
        }
      }

      [DllImport("user32.dll")]
      [return: MarshalAs(UnmanagedType.Bool)]
      static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

      [StructLayout(LayoutKind.Sequential)]
      public struct RECT
      {
        public int Left;        // x position of upper-left corner
        public int Top;         // y position of upper-left corner
        public int Right;       // x position of lower-right corner
        public int Bottom;      // y position of lower-right corner
      }
    }
}
