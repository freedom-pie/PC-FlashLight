namespace PC_FlashLight
{
    public partial class Form1 : Form
    {
        private bool isLightOn = false;
        private Color selectedColor = Color.White;
        public Form1()
        {

            InitializeComponent();
            UpdateLightUI();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            isLightOn = !isLightOn;

            UpdateLightUI();
        }

        private void UpdateLightUI()
        {
            Color displayColor = LightColorCalculator.Calculate(selectedColor, trackBarBrightness.Value);

            if (isLightOn)
            {
                panelLightPreview.BackColor = displayColor;

                btnPower.Text = "关闭手电筒";


            }
            else
            {
                panelLightPreview.BackColor = Color.Black;
                btnPower.Text = "打开手电筒";
            }
            lblBrightness.Text = $"当前亮度：{trackBarBrightness.Value}%";
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            UpdateLightUI();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new ColorDialog();

            dialog.Color = selectedColor;

            dialog.AllowFullOpen = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = dialog.Color;

                UpdateLightUI();
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            Color lightColor = panelLightPreview.BackColor;

            FlashlightForm light = new FlashlightForm(lightColor);

            light.Show();
        }


    }
}
