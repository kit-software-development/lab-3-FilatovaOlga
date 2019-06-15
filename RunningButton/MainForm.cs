using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class RunButtonForm : Form
    {
        int speed = 20;
        public RunButtonForm()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void OnMoveCursor(object sender, MouseEventArgs e)
        {
            if (e.X > button.Left - speed && e.X < button.Left + button.Width + speed)
            {
                if (e.X >= (button.Left + button.Width/2))
                {
                    button.Left -= speed;
                }
                else
                {
                    button.Left += speed;
                }    
            }

            if (e.Y > button.Top - speed && e.Y < button.Top + button.Height + speed)
            {
                if (e.Y >= (button.Top + button.Height/2))
                {
                    button.Top -= speed;
                }
                else
                {
                    button.Top += speed;
                }
            }

            if (button.Left < 0)
            {
                button.Left = 0;
            }
            if (button.Left + button.Width > ClientSize.Width)
            {
                button.Left = ClientSize.Width - button.Width;
            }
            if (button.Top < 0)
            {
                button.Top = 0;
            }
            if (button.Top + button.Height > ClientSize.Height)
            {
                button.Top = ClientSize.Height - button.Height;
            }
        }
    }
}
