namespace ddfdf
{
    partial class CityHallForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SliderSetNalog = new MaterialSkin.Controls.MaterialSlider();
            this.LabelCurrentNalog = new MaterialSkin.Controls.MaterialLabel();
            this.LabelMaxNalog = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonConfirm = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // SliderSetNalog
            // 
            this.SliderSetNalog.Depth = 0;
            this.SliderSetNalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SliderSetNalog.Location = new System.Drawing.Point(160, 153);
            this.SliderSetNalog.MouseState = MaterialSkin.MouseState.HOVER;
            this.SliderSetNalog.Name = "SliderSetNalog";
            this.SliderSetNalog.Size = new System.Drawing.Size(250, 40);
            this.SliderSetNalog.TabIndex = 0;
            this.SliderSetNalog.Text = "materialSlider1";
            this.SliderSetNalog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderSetNalog_MouseUp);
            // 
            // LabelCurrentNalog
            // 
            this.LabelCurrentNalog.AutoSize = true;
            this.LabelCurrentNalog.Depth = 0;
            this.LabelCurrentNalog.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCurrentNalog.Location = new System.Drawing.Point(157, 30);
            this.LabelCurrentNalog.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCurrentNalog.Name = "LabelCurrentNalog";
            this.LabelCurrentNalog.Size = new System.Drawing.Size(107, 19);
            this.LabelCurrentNalog.TabIndex = 1;
            this.LabelCurrentNalog.Text = "materialLabel1";
            // 
            // LabelMaxNalog
            // 
            this.LabelMaxNalog.AutoSize = true;
            this.LabelMaxNalog.Depth = 0;
            this.LabelMaxNalog.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMaxNalog.Location = new System.Drawing.Point(157, 70);
            this.LabelMaxNalog.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMaxNalog.Name = "LabelMaxNalog";
            this.LabelMaxNalog.Size = new System.Drawing.Size(107, 19);
            this.LabelMaxNalog.TabIndex = 2;
            this.LabelMaxNalog.Text = "materialLabel2";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonConfirm.Depth = 0;
            this.ButtonConfirm.HighEmphasis = true;
            this.ButtonConfirm.Icon = null;
            this.ButtonConfirm.Location = new System.Drawing.Point(160, 233);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonConfirm.Size = new System.Drawing.Size(129, 36);
            this.ButtonConfirm.TabIndex = 3;
            this.ButtonConfirm.Text = "Подтвердить";
            this.ButtonConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonConfirm.UseAccentColor = false;
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // CityHallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 342);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.LabelMaxNalog);
            this.Controls.Add(this.LabelCurrentNalog);
            this.Controls.Add(this.SliderSetNalog);
            this.Name = "CityHallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мэрия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSlider SliderSetNalog;
        private MaterialSkin.Controls.MaterialLabel LabelCurrentNalog;
        private MaterialSkin.Controls.MaterialLabel LabelMaxNalog;
        private MaterialSkin.Controls.MaterialButton ButtonConfirm;
    }
}