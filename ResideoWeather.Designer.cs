namespace ResideoWeather
{
    partial class ResideoWeather
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
            btnGetWeather = new Button();
            SuspendLayout();
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(47, 84);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(161, 39);
            btnGetWeather.TabIndex = 0;
            btnGetWeather.Text = "Get Weatther";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // ResideoWeather
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetWeather);
            Name = "ResideoWeather";
            Text = "Resideo Weather";
            Load += ResideoWeather_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetWeather;
    }
}
