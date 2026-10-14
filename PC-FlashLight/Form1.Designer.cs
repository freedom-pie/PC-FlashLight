namespace PC_FlashLight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPower = new Button();
            trackBarBrightness = new TrackBar();
            lblBrightness = new Label();
            btnChooseColor = new Button();
            panelLightPreview = new Panel();
            btnFullScreen = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            SuspendLayout();
            // 
            // btnPower
            // 
            btnPower.Location = new Point(113, 506);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(223, 84);
            btnPower.TabIndex = 0;
            btnPower.Text = "开启手电筒";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.Location = new Point(149, 656);
            trackBarBrightness.Maximum = 100;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(894, 69);
            trackBarBrightness.TabIndex = 1;
            trackBarBrightness.Value = 100;
            trackBarBrightness.ValueChanged += trackBarBrightness_ValueChanged;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.Location = new Point(68, 615);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(149, 24);
            lblBrightness.TabIndex = 2;
            lblBrightness.Text = "当前亮度：100%";
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(489, 506);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(223, 84);
            btnChooseColor.TabIndex = 1;
            btnChooseColor.Text = "选择灯光颜色";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // panelLightPreview
            // 
            panelLightPreview.BackColor = Color.Black;
            panelLightPreview.Location = new Point(113, 60);
            panelLightPreview.Name = "panelLightPreview";
            panelLightPreview.Size = new Size(946, 421);
            panelLightPreview.TabIndex = 3;
            // 
            // btnFullScreen
            // 
            btnFullScreen.Location = new Point(836, 506);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(223, 84);
            btnFullScreen.TabIndex = 3;
            btnFullScreen.Text = "打开全屏手电筒";
            btnFullScreen.UseVisualStyleBackColor = true;
            btnFullScreen.Click += btnFullScreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1204, 759);
            Controls.Add(btnFullScreen);
            Controls.Add(panelLightPreview);
            Controls.Add(btnChooseColor);
            Controls.Add(lblBrightness);
            Controls.Add(trackBarBrightness);
            Controls.Add(btnPower);
            Name = "Form1";
            Text = "PC-FlashLight";
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPower;
        private TrackBar trackBarBrightness;
        private Label lblBrightness;
        private Button btnChooseColor;
        private Panel panelLightPreview;
        private Button btnFullScreen;
    }
}
