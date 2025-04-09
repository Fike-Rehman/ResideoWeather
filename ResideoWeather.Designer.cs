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
            dgvWeatherData = new DataGridView();
            dgvDateColumn = new DataGridViewTextBoxColumn();
            dgvMinTempColumn = new DataGridViewTextBoxColumn();
            dgvMaxTempColumn = new DataGridViewTextBoxColumn();
            dgvCityColumn = new DataGridViewTextBoxColumn();
            rtbJsonReport = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherData).BeginInit();
            SuspendLayout();
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(77, 77);
            btnGetWeather.Margin = new Padding(5, 6, 5, 6);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(276, 78);
            btnGetWeather.TabIndex = 0;
            btnGetWeather.Text = "Get Weatther";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // dgvWeatherData
            // 
            dgvWeatherData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeatherData.Columns.AddRange(new DataGridViewColumn[] { dgvDateColumn, dgvMinTempColumn, dgvMaxTempColumn, dgvCityColumn });
            dgvWeatherData.Location = new Point(77, 212);
            dgvWeatherData.Name = "dgvWeatherData";
            dgvWeatherData.RowHeadersWidth = 72;
            dgvWeatherData.Size = new Size(801, 262);
            dgvWeatherData.TabIndex = 1;
            // 
            // dgvDateColumn
            // 
            dgvDateColumn.HeaderText = "Date";
            dgvDateColumn.MinimumWidth = 9;
            dgvDateColumn.Name = "dgvDateColumn";
            dgvDateColumn.Width = 175;
            // 
            // dgvMinTempColumn
            // 
            dgvMinTempColumn.HeaderText = "Min. Temp";
            dgvMinTempColumn.MinimumWidth = 9;
            dgvMinTempColumn.Name = "dgvMinTempColumn";
            dgvMinTempColumn.Width = 175;
            // 
            // dgvMaxTempColumn
            // 
            dgvMaxTempColumn.HeaderText = "Max. Temp";
            dgvMaxTempColumn.MinimumWidth = 9;
            dgvMaxTempColumn.Name = "dgvMaxTempColumn";
            dgvMaxTempColumn.Width = 175;
            // 
            // dgvCityColumn
            // 
            dgvCityColumn.HeaderText = "City";
            dgvCityColumn.MinimumWidth = 9;
            dgvCityColumn.Name = "dgvCityColumn";
            dgvCityColumn.Width = 175;
            // 
            // rtbJsonReport
            // 
            rtbJsonReport.Location = new Point(77, 522);
            rtbJsonReport.Name = "rtbJsonReport";
            rtbJsonReport.Size = new Size(807, 336);
            rtbJsonReport.TabIndex = 2;
            rtbJsonReport.Text = "";
            // 
            // ResideoWeather
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 900);
            Controls.Add(rtbJsonReport);
            Controls.Add(dgvWeatherData);
            Controls.Add(btnGetWeather);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ResideoWeather";
            Text = "Resideo Weather";
            Load += ResideoWeather_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWeatherData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetWeather;
        private DataGridView dgvWeatherData;
        private DataGridViewTextBoxColumn dgvDateColumn;
        private DataGridViewTextBoxColumn dgvMinTempColumn;
        private DataGridViewTextBoxColumn dgvMaxTempColumn;
        private DataGridViewTextBoxColumn dgvCityColumn;
        private RichTextBox rtbJsonReport;
    }
}
