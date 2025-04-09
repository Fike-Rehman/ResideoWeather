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
            rtbJsonViewer = new RichTextBox();
            lblAppTitle = new Label();
            SuspendLayout();
            // 
            // btnGetWeather
            // 
            btnGetWeather.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetWeather.Location = new Point(205, 662);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(161, 39);
            btnGetWeather.TabIndex = 0;
            btnGetWeather.Text = "Get Weather";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // rtbJsonViewer
            // 
            rtbJsonViewer.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbJsonViewer.Location = new Point(53, 73);
            rtbJsonViewer.Margin = new Padding(2);
            rtbJsonViewer.Name = "rtbJsonViewer";
            rtbJsonViewer.Size = new Size(472, 561);
            rtbJsonViewer.TabIndex = 2;
            rtbJsonViewer.Text = "";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppTitle.Location = new Point(53, 24);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(0, 22);
            lblAppTitle.TabIndex = 3;
            // 
            // ResideoWeather
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(569, 719);
            Controls.Add(lblAppTitle);
            Controls.Add(rtbJsonViewer);
            Controls.Add(btnGetWeather);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ResideoWeather";
            Text = "Resideo Weather";
            Load += ResideoWeather_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetWeather;
        private RichTextBox rtbJsonViewer;
        private Label lblAppTitle;
    }
}
