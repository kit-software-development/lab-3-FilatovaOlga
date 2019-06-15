using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorPickerForm : Form
    {
        public ColorPickerForm()
        {
            InitializeComponent();
            NewColor();
        }

        private void NewColor()
        {
            Color.BackColor = System.Drawing.Color.FromArgb(RedTrack.Value, GreenTrack.Value, BlueTrack.Value);
            Clipboard.Clear();
            Clipboard.SetText($"#{RedTrack.Value:X}{GreenTrack.Value:X}{BlueTrack.Value:X}");
            toolTip.SetToolTip(Color, Clipboard.GetText());
        }

        private void OnScroll(object sender, EventArgs e)
        {
            NewColor();
        }
    }
}
