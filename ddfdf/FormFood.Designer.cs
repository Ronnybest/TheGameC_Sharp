namespace ddfdf
{
    partial class FormFood
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
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.LabelFreeWorker = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialSlider1.Location = new System.Drawing.Point(36, 57);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 10;
            this.materialSlider1.Size = new System.Drawing.Size(344, 40);
            this.materialSlider1.TabIndex = 0;
            this.materialSlider1.Text = "Кол-во людей на добычу";
            this.materialSlider1.Value = 0;
            this.materialSlider1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.materialSlider1_MouseUp);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(138, 121);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(129, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Подтвердить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // LabelFreeWorker
            // 
            this.LabelFreeWorker.AutoSize = true;
            this.LabelFreeWorker.Depth = 0;
            this.LabelFreeWorker.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFreeWorker.Location = new System.Drawing.Point(119, 21);
            this.LabelFreeWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFreeWorker.Name = "LabelFreeWorker";
            this.LabelFreeWorker.Size = new System.Drawing.Size(160, 19);
            this.LabelFreeWorker.TabIndex = 2;
            this.LabelFreeWorker.Text = "Свободные рабочие: ";
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 197);
            this.Controls.Add(this.LabelFreeWorker);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialSlider1);
            this.Name = "FormFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добыча еды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel LabelFreeWorker;
    }
}