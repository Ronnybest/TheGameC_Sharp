namespace ddfdf
{
    partial class Form1
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelGold = new MaterialSkin.Controls.MaterialLabel();
            this.LabelWood = new MaterialSkin.Controls.MaterialLabel();
            this.LabelStone = new MaterialSkin.Controls.MaterialLabel();
            this.LabelHuman = new MaterialSkin.Controls.MaterialLabel();
            this.LabelFood = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonFood = new MaterialSkin.Controls.MaterialButton();
            this.LabelMinusFood = new MaterialSkin.Controls.MaterialLabel();
            this.LabelMoves = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonWood = new MaterialSkin.Controls.MaterialButton();
            this.ButtonStone = new MaterialSkin.Controls.MaterialButton();
            this.LabelFreeWorker = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonBuildings = new MaterialSkin.Controls.MaterialButton();
            this.ButtonShop = new MaterialSkin.Controls.MaterialButton();
            this.ButtonCityHall = new MaterialSkin.Controls.MaterialButton();
            this.ButtonBank = new MaterialSkin.Controls.MaterialButton();
            this.ButtonForge = new MaterialSkin.Controls.MaterialButton();
            this.ButtonBarracks = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(852, 519);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(152, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Закончить день";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(6, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "День ";
            // 
            // LabelGold
            // 
            this.LabelGold.AutoSize = true;
            this.LabelGold.Depth = 0;
            this.LabelGold.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelGold.Location = new System.Drawing.Point(559, 82);
            this.LabelGold.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelGold.Name = "LabelGold";
            this.LabelGold.Size = new System.Drawing.Size(55, 19);
            this.LabelGold.TabIndex = 2;
            this.LabelGold.Text = "Золото";
            // 
            // LabelWood
            // 
            this.LabelWood.AutoSize = true;
            this.LabelWood.Depth = 0;
            this.LabelWood.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelWood.Location = new System.Drawing.Point(705, 82);
            this.LabelWood.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelWood.Name = "LabelWood";
            this.LabelWood.Size = new System.Drawing.Size(56, 19);
            this.LabelWood.TabIndex = 3;
            this.LabelWood.Text = "Дерево";
            // 
            // LabelStone
            // 
            this.LabelStone.AutoSize = true;
            this.LabelStone.Depth = 0;
            this.LabelStone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStone.Location = new System.Drawing.Point(849, 82);
            this.LabelStone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStone.Name = "LabelStone";
            this.LabelStone.Size = new System.Drawing.Size(58, 19);
            this.LabelStone.TabIndex = 4;
            this.LabelStone.Text = "Камень";
            // 
            // LabelHuman
            // 
            this.LabelHuman.AutoSize = true;
            this.LabelHuman.Depth = 0;
            this.LabelHuman.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelHuman.Location = new System.Drawing.Point(200, 82);
            this.LabelHuman.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelHuman.Name = "LabelHuman";
            this.LabelHuman.Size = new System.Drawing.Size(80, 19);
            this.LabelHuman.TabIndex = 5;
            this.LabelHuman.Text = "Население";
            // 
            // LabelFood
            // 
            this.LabelFood.AutoSize = true;
            this.LabelFood.Depth = 0;
            this.LabelFood.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFood.Location = new System.Drawing.Point(353, 82);
            this.LabelFood.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFood.Name = "LabelFood";
            this.LabelFood.Size = new System.Drawing.Size(74, 19);
            this.LabelFood.TabIndex = 6;
            this.LabelFood.Text = "Провизия";
            // 
            // ButtonFood
            // 
            this.ButtonFood.AutoSize = false;
            this.ButtonFood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonFood.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonFood.Depth = 0;
            this.ButtonFood.HighEmphasis = true;
            this.ButtonFood.Icon = null;
            this.ButtonFood.Location = new System.Drawing.Point(7, 154);
            this.ButtonFood.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonFood.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonFood.Name = "ButtonFood";
            this.ButtonFood.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonFood.Size = new System.Drawing.Size(140, 36);
            this.ButtonFood.TabIndex = 7;
            this.ButtonFood.Text = "Добыча еды";
            this.ButtonFood.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonFood.UseAccentColor = false;
            this.ButtonFood.UseVisualStyleBackColor = true;
            this.ButtonFood.Click += new System.EventHandler(this.ButtonFood_Click);
            // 
            // LabelMinusFood
            // 
            this.LabelMinusFood.AutoSize = true;
            this.LabelMinusFood.Depth = 0;
            this.LabelMinusFood.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMinusFood.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.LabelMinusFood.ForeColor = System.Drawing.Color.Red;
            this.LabelMinusFood.Location = new System.Drawing.Point(433, 101);
            this.LabelMinusFood.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMinusFood.Name = "LabelMinusFood";
            this.LabelMinusFood.Size = new System.Drawing.Size(6, 17);
            this.LabelMinusFood.TabIndex = 8;
            this.LabelMinusFood.Text = "-";
            // 
            // LabelMoves
            // 
            this.LabelMoves.AutoSize = true;
            this.LabelMoves.Depth = 0;
            this.LabelMoves.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMoves.Location = new System.Drawing.Point(849, 481);
            this.LabelMoves.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMoves.Name = "LabelMoves";
            this.LabelMoves.Size = new System.Drawing.Size(107, 19);
            this.LabelMoves.TabIndex = 9;
            this.LabelMoves.Text = "materialLabel2";
            // 
            // ButtonWood
            // 
            this.ButtonWood.AutoSize = false;
            this.ButtonWood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonWood.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonWood.Depth = 0;
            this.ButtonWood.HighEmphasis = true;
            this.ButtonWood.Icon = null;
            this.ButtonWood.Location = new System.Drawing.Point(7, 202);
            this.ButtonWood.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonWood.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonWood.Name = "ButtonWood";
            this.ButtonWood.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonWood.Size = new System.Drawing.Size(140, 36);
            this.ButtonWood.TabIndex = 10;
            this.ButtonWood.Text = "Добыча дерева";
            this.ButtonWood.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonWood.UseAccentColor = false;
            this.ButtonWood.UseVisualStyleBackColor = true;
            this.ButtonWood.Click += new System.EventHandler(this.ButtonWood_Click);
            // 
            // ButtonStone
            // 
            this.ButtonStone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonStone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonStone.Depth = 0;
            this.ButtonStone.HighEmphasis = true;
            this.ButtonStone.Icon = null;
            this.ButtonStone.Location = new System.Drawing.Point(7, 250);
            this.ButtonStone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonStone.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonStone.Name = "ButtonStone";
            this.ButtonStone.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonStone.Size = new System.Drawing.Size(140, 36);
            this.ButtonStone.TabIndex = 11;
            this.ButtonStone.Text = "Добыча камня";
            this.ButtonStone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonStone.UseAccentColor = false;
            this.ButtonStone.UseVisualStyleBackColor = true;
            this.ButtonStone.Click += new System.EventHandler(this.ButtonStone_Click);
            // 
            // LabelFreeWorker
            // 
            this.LabelFreeWorker.AutoSize = true;
            this.LabelFreeWorker.Depth = 0;
            this.LabelFreeWorker.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFreeWorker.Location = new System.Drawing.Point(200, 113);
            this.LabelFreeWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFreeWorker.Name = "LabelFreeWorker";
            this.LabelFreeWorker.Size = new System.Drawing.Size(86, 19);
            this.LabelFreeWorker.TabIndex = 12;
            this.LabelFreeWorker.Text = "Свободных";
            // 
            // ButtonBuildings
            // 
            this.ButtonBuildings.AutoSize = false;
            this.ButtonBuildings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonBuildings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonBuildings.Depth = 0;
            this.ButtonBuildings.HighEmphasis = true;
            this.ButtonBuildings.Icon = null;
            this.ButtonBuildings.Location = new System.Drawing.Point(180, 154);
            this.ButtonBuildings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonBuildings.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonBuildings.Name = "ButtonBuildings";
            this.ButtonBuildings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonBuildings.Size = new System.Drawing.Size(140, 36);
            this.ButtonBuildings.TabIndex = 13;
            this.ButtonBuildings.Text = "Строительство";
            this.ButtonBuildings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonBuildings.UseAccentColor = false;
            this.ButtonBuildings.UseVisualStyleBackColor = true;
            this.ButtonBuildings.Click += new System.EventHandler(this.ButtonBuildings_Click);
            // 
            // ButtonShop
            // 
            this.ButtonShop.AutoSize = false;
            this.ButtonShop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonShop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonShop.Depth = 0;
            this.ButtonShop.HighEmphasis = true;
            this.ButtonShop.Icon = null;
            this.ButtonShop.Location = new System.Drawing.Point(180, 202);
            this.ButtonShop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonShop.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonShop.Name = "ButtonShop";
            this.ButtonShop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonShop.Size = new System.Drawing.Size(140, 36);
            this.ButtonShop.TabIndex = 14;
            this.ButtonShop.Text = "Рынок";
            this.ButtonShop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonShop.UseAccentColor = false;
            this.ButtonShop.UseVisualStyleBackColor = true;
            this.ButtonShop.Visible = false;
            // 
            // ButtonCityHall
            // 
            this.ButtonCityHall.AutoSize = false;
            this.ButtonCityHall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCityHall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonCityHall.Depth = 0;
            this.ButtonCityHall.HighEmphasis = true;
            this.ButtonCityHall.Icon = null;
            this.ButtonCityHall.Location = new System.Drawing.Point(180, 250);
            this.ButtonCityHall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonCityHall.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCityHall.Name = "ButtonCityHall";
            this.ButtonCityHall.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonCityHall.Size = new System.Drawing.Size(140, 36);
            this.ButtonCityHall.TabIndex = 15;
            this.ButtonCityHall.Text = "Мэрия";
            this.ButtonCityHall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonCityHall.UseAccentColor = false;
            this.ButtonCityHall.UseVisualStyleBackColor = true;
            this.ButtonCityHall.Visible = false;
            // 
            // ButtonBank
            // 
            this.ButtonBank.AutoSize = false;
            this.ButtonBank.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonBank.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonBank.Depth = 0;
            this.ButtonBank.HighEmphasis = true;
            this.ButtonBank.Icon = null;
            this.ButtonBank.Location = new System.Drawing.Point(356, 154);
            this.ButtonBank.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonBank.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonBank.Name = "ButtonBank";
            this.ButtonBank.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonBank.Size = new System.Drawing.Size(140, 36);
            this.ButtonBank.TabIndex = 16;
            this.ButtonBank.Text = "Банк";
            this.ButtonBank.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonBank.UseAccentColor = false;
            this.ButtonBank.UseVisualStyleBackColor = true;
            this.ButtonBank.Visible = false;
            // 
            // ButtonForge
            // 
            this.ButtonForge.AutoSize = false;
            this.ButtonForge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonForge.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonForge.Depth = 0;
            this.ButtonForge.HighEmphasis = true;
            this.ButtonForge.Icon = null;
            this.ButtonForge.Location = new System.Drawing.Point(356, 202);
            this.ButtonForge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonForge.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonForge.Name = "ButtonForge";
            this.ButtonForge.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonForge.Size = new System.Drawing.Size(140, 36);
            this.ButtonForge.TabIndex = 17;
            this.ButtonForge.Text = "Кузница";
            this.ButtonForge.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonForge.UseAccentColor = false;
            this.ButtonForge.UseVisualStyleBackColor = true;
            this.ButtonForge.Visible = false;
            // 
            // ButtonBarracks
            // 
            this.ButtonBarracks.AutoSize = false;
            this.ButtonBarracks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonBarracks.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonBarracks.Depth = 0;
            this.ButtonBarracks.HighEmphasis = true;
            this.ButtonBarracks.Icon = null;
            this.ButtonBarracks.Location = new System.Drawing.Point(356, 250);
            this.ButtonBarracks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonBarracks.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonBarracks.Name = "ButtonBarracks";
            this.ButtonBarracks.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonBarracks.Size = new System.Drawing.Size(140, 36);
            this.ButtonBarracks.TabIndex = 18;
            this.ButtonBarracks.Text = "Казармы";
            this.ButtonBarracks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonBarracks.UseAccentColor = false;
            this.ButtonBarracks.UseVisualStyleBackColor = true;
            this.ButtonBarracks.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 564);
            this.Controls.Add(this.ButtonBarracks);
            this.Controls.Add(this.ButtonForge);
            this.Controls.Add(this.ButtonBank);
            this.Controls.Add(this.ButtonCityHall);
            this.Controls.Add(this.ButtonShop);
            this.Controls.Add(this.ButtonBuildings);
            this.Controls.Add(this.LabelFreeWorker);
            this.Controls.Add(this.ButtonStone);
            this.Controls.Add(this.ButtonWood);
            this.Controls.Add(this.LabelMoves);
            this.Controls.Add(this.LabelMinusFood);
            this.Controls.Add(this.ButtonFood);
            this.Controls.Add(this.LabelFood);
            this.Controls.Add(this.LabelHuman);
            this.Controls.Add(this.LabelStone);
            this.Controls.Add(this.LabelWood);
            this.Controls.Add(this.LabelGold);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LabelGold;
        private MaterialSkin.Controls.MaterialLabel LabelWood;
        private MaterialSkin.Controls.MaterialLabel LabelStone;
        private MaterialSkin.Controls.MaterialLabel LabelHuman;
        private MaterialSkin.Controls.MaterialLabel LabelFood;
        private MaterialSkin.Controls.MaterialButton ButtonFood;
        private MaterialSkin.Controls.MaterialLabel LabelMinusFood;
        private MaterialSkin.Controls.MaterialLabel LabelMoves;
        private MaterialSkin.Controls.MaterialButton ButtonWood;
        private MaterialSkin.Controls.MaterialButton ButtonStone;
        private MaterialSkin.Controls.MaterialLabel LabelFreeWorker;
        private MaterialSkin.Controls.MaterialButton ButtonBuildings;
        private MaterialSkin.Controls.MaterialButton ButtonShop;
        private MaterialSkin.Controls.MaterialButton ButtonCityHall;
        private MaterialSkin.Controls.MaterialButton ButtonBank;
        private MaterialSkin.Controls.MaterialButton ButtonForge;
        private MaterialSkin.Controls.MaterialButton ButtonBarracks;
    }
}

