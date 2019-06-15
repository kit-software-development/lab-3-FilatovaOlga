namespace Lab3
{
    partial class RunButtonForm
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button.Location = new System.Drawing.Point(133, 147);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(106, 29);
            this.button.TabIndex = 0;
            this.button.Text = "Push me";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.OnClick);
            // 
            // RunButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 320);
            this.Controls.Add(this.button);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "RunButtonForm";
            this.Text = "Running Button";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMoveCursor);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
    }
}

