namespace ColorPicker
{
    partial class ColorPickerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.RedTrack = new System.Windows.Forms.TrackBar();
            this.GreenTrack = new System.Windows.Forms.TrackBar();
            this.BlueTrack = new System.Windows.Forms.TrackBar();
            this.Red_0_label = new System.Windows.Forms.Label();
            this.Green_0_Label = new System.Windows.Forms.Label();
            this.Blue_0_Label = new System.Windows.Forms.Label();
            this.Red_255_Label = new System.Windows.Forms.Label();
            this.Green_255_Label = new System.Windows.Forms.Label();
            this.Blue_255_Label = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.Color = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrack)).BeginInit();
            this.ColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.Blue_255_Label);
            this.ToolPanel.Controls.Add(this.Green_255_Label);
            this.ToolPanel.Controls.Add(this.Red_255_Label);
            this.ToolPanel.Controls.Add(this.Blue_0_Label);
            this.ToolPanel.Controls.Add(this.Green_0_Label);
            this.ToolPanel.Controls.Add(this.Red_0_label);
            this.ToolPanel.Controls.Add(this.BlueTrack);
            this.ToolPanel.Controls.Add(this.GreenTrack);
            this.ToolPanel.Controls.Add(this.RedTrack);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolPanel.Location = new System.Drawing.Point(239, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(232, 225);
            this.ToolPanel.TabIndex = 3;
            // 
            // RedTrack
            // 
            this.RedTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedTrack.Location = new System.Drawing.Point(3, 45);
            this.RedTrack.Maximum = 255;
            this.RedTrack.Name = "RedTrack";
            this.RedTrack.Size = new System.Drawing.Size(226, 45);
            this.RedTrack.TabIndex = 1;
            this.RedTrack.TickFrequency = 20;
            this.RedTrack.Value = 125;
            this.RedTrack.Scroll += new System.EventHandler(this.OnScroll);
            // 
            // GreenTrack
            // 
            this.GreenTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GreenTrack.Location = new System.Drawing.Point(3, 89);
            this.GreenTrack.Maximum = 255;
            this.GreenTrack.Name = "GreenTrack";
            this.GreenTrack.Size = new System.Drawing.Size(226, 45);
            this.GreenTrack.TabIndex = 1;
            this.GreenTrack.TickFrequency = 20;
            this.GreenTrack.Value = 125;
            this.GreenTrack.Scroll += new System.EventHandler(this.OnScroll);
            // 
            // BlueTrack
            // 
            this.BlueTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueTrack.Location = new System.Drawing.Point(3, 135);
            this.BlueTrack.Maximum = 255;
            this.BlueTrack.Name = "BlueTrack";
            this.BlueTrack.Size = new System.Drawing.Size(226, 45);
            this.BlueTrack.TabIndex = 1;
            this.BlueTrack.TickFrequency = 20;
            this.BlueTrack.Value = 125;
            this.BlueTrack.Scroll += new System.EventHandler(this.OnScroll);
            // 
            // Red_0_label
            // 
            this.Red_0_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Red_0_label.AutoSize = true;
            this.Red_0_label.Location = new System.Drawing.Point(6, 75);
            this.Red_0_label.Name = "Red_0_label";
            this.Red_0_label.Size = new System.Drawing.Size(13, 13);
            this.Red_0_label.TabIndex = 2;
            this.Red_0_label.Text = "0";
            // 
            // Green_0_Label
            // 
            this.Green_0_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Green_0_Label.AutoSize = true;
            this.Green_0_Label.Location = new System.Drawing.Point(6, 122);
            this.Green_0_Label.Name = "Green_0_Label";
            this.Green_0_Label.Size = new System.Drawing.Size(13, 13);
            this.Green_0_Label.TabIndex = 3;
            this.Green_0_Label.Text = "0";
            // 
            // Blue_0_Label
            // 
            this.Blue_0_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Blue_0_Label.AutoSize = true;
            this.Blue_0_Label.Location = new System.Drawing.Point(6, 167);
            this.Blue_0_Label.Name = "Blue_0_Label";
            this.Blue_0_Label.Size = new System.Drawing.Size(13, 13);
            this.Blue_0_Label.TabIndex = 4;
            this.Blue_0_Label.Text = "0";
            // 
            // Red_255_Label
            // 
            this.Red_255_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Red_255_Label.AutoSize = true;
            this.Red_255_Label.Location = new System.Drawing.Point(204, 75);
            this.Red_255_Label.Name = "Red_255_Label";
            this.Red_255_Label.Size = new System.Drawing.Size(25, 13);
            this.Red_255_Label.TabIndex = 5;
            this.Red_255_Label.Text = "255";
            // 
            // Green_255_Label
            // 
            this.Green_255_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Green_255_Label.AutoSize = true;
            this.Green_255_Label.Location = new System.Drawing.Point(204, 122);
            this.Green_255_Label.Name = "Green_255_Label";
            this.Green_255_Label.Size = new System.Drawing.Size(25, 13);
            this.Green_255_Label.TabIndex = 6;
            this.Green_255_Label.Text = "255";
            // 
            // Blue_255_Label
            // 
            this.Blue_255_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Blue_255_Label.AutoSize = true;
            this.Blue_255_Label.Location = new System.Drawing.Point(204, 167);
            this.Blue_255_Label.Name = "Blue_255_Label";
            this.Blue_255_Label.Size = new System.Drawing.Size(25, 13);
            this.Blue_255_Label.TabIndex = 7;
            this.Blue_255_Label.Text = "255";
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.Color);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(239, 225);
            this.ColorPanel.TabIndex = 4;
            // 
            // Color
            // 
            this.Color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Color.Location = new System.Drawing.Point(12, 12);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(212, 201);
            this.Color.TabIndex = 0;
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 225);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.ToolPanel);
            this.MinimumSize = new System.Drawing.Size(487, 264);
            this.Name = "ColorPickerForm";
            this.Text = "Color Picker";
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrack)).EndInit();
            this.ColorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.TrackBar BlueTrack;
        private System.Windows.Forms.TrackBar GreenTrack;
        private System.Windows.Forms.TrackBar RedTrack;
        private System.Windows.Forms.Label Blue_255_Label;
        private System.Windows.Forms.Label Green_255_Label;
        private System.Windows.Forms.Label Red_255_Label;
        private System.Windows.Forms.Label Blue_0_Label;
        private System.Windows.Forms.Label Green_0_Label;
        private System.Windows.Forms.Label Red_0_label;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel Color;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

