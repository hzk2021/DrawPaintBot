
namespace DrawBot
{
    partial class Bot
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
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_LoadedConfig = new System.Windows.Forms.Label();
            this.lbl_urlOption = new System.Windows.Forms.Label();
            this.lbl_ImageDir = new System.Windows.Forms.Label();
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.lbl_loadSavedConfig = new System.Windows.Forms.Label();
            this.lbl_CreateColoursPreset = new System.Windows.Forms.Label();
            this.btn_DeleteConfig = new System.Windows.Forms.Button();
            this.lbl_ColourIndex = new System.Windows.Forms.Label();
            this.panel_Colour = new System.Windows.Forms.Panel();
            this.txt_imageURL = new System.Windows.Forms.TextBox();
            this.btn_RemoveColour = new System.Windows.Forms.Button();
            this.LBox_configs = new System.Windows.Forms.ListBox();
            this.btn_LoadConfig = new System.Windows.Forms.Button();
            this.txt_configName = new System.Windows.Forms.TextBox();
            this.btn_SaveConfig = new System.Windows.Forms.Button();
            this.btn_addColour = new System.Windows.Forms.Button();
            this.lbl_LoadImage = new System.Windows.Forms.Label();
            this.lbl_BottomRightPos = new System.Windows.Forms.Label();
            this.lbl_TopLeftPos = new System.Windows.Forms.Label();
            this.btn_BottomRight = new System.Windows.Forms.Button();
            this.btn_TopLeft = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_ConfigureCanvas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_PresetName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "Image";
            // 
            // lbl_LoadedConfig
            // 
            this.lbl_LoadedConfig.AutoSize = true;
            this.lbl_LoadedConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoadedConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LoadedConfig.Location = new System.Drawing.Point(14, 113);
            this.lbl_LoadedConfig.Name = "lbl_LoadedConfig";
            this.lbl_LoadedConfig.Size = new System.Drawing.Size(87, 15);
            this.lbl_LoadedConfig.TabIndex = 33;
            this.lbl_LoadedConfig.Text = "Loaded Config";
            // 
            // lbl_urlOption
            // 
            this.lbl_urlOption.AutoSize = true;
            this.lbl_urlOption.BackColor = System.Drawing.Color.Transparent;
            this.lbl_urlOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_urlOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_urlOption.Location = new System.Drawing.Point(164, 20);
            this.lbl_urlOption.Name = "lbl_urlOption";
            this.lbl_urlOption.Size = new System.Drawing.Size(70, 15);
            this.lbl_urlOption.TabIndex = 37;
            this.lbl_urlOption.Text = "Image URL";
            // 
            // lbl_ImageDir
            // 
            this.lbl_ImageDir.AutoSize = true;
            this.lbl_ImageDir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ImageDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ImageDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ImageDir.Location = new System.Drawing.Point(7, 73);
            this.lbl_ImageDir.Name = "lbl_ImageDir";
            this.lbl_ImageDir.Size = new System.Drawing.Size(87, 15);
            this.lbl_ImageDir.TabIndex = 35;
            this.lbl_ImageDir.Text = "Loaded Image";
            this.lbl_ImageDir.TextChanged += new System.EventHandler(this.lbl_ImageDir_TextChanged);
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.BackColor = System.Drawing.Color.White;
            this.btn_loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_loadImage.Location = new System.Drawing.Point(10, 20);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(114, 44);
            this.btn_loadImage.TabIndex = 38;
            this.btn_loadImage.Text = "Select Local Image";
            this.btn_loadImage.UseVisualStyleBackColor = false;
            this.btn_loadImage.Click += new System.EventHandler(this.btn_loadImage_Click);
            // 
            // lbl_loadSavedConfig
            // 
            this.lbl_loadSavedConfig.AutoSize = true;
            this.lbl_loadSavedConfig.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loadSavedConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_loadSavedConfig.ForeColor = System.Drawing.Color.Black;
            this.lbl_loadSavedConfig.Location = new System.Drawing.Point(325, 133);
            this.lbl_loadSavedConfig.Name = "lbl_loadSavedConfig";
            this.lbl_loadSavedConfig.Size = new System.Drawing.Size(169, 18);
            this.lbl_loadSavedConfig.TabIndex = 28;
            this.lbl_loadSavedConfig.Text = "4. Load Saved Config";
            // 
            // lbl_CreateColoursPreset
            // 
            this.lbl_CreateColoursPreset.AutoSize = true;
            this.lbl_CreateColoursPreset.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreateColoursPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CreateColoursPreset.ForeColor = System.Drawing.Color.Black;
            this.lbl_CreateColoursPreset.Location = new System.Drawing.Point(71, 133);
            this.lbl_CreateColoursPreset.Name = "lbl_CreateColoursPreset";
            this.lbl_CreateColoursPreset.Size = new System.Drawing.Size(131, 18);
            this.lbl_CreateColoursPreset.TabIndex = 27;
            this.lbl_CreateColoursPreset.Text = "3. Create Config";
            // 
            // btn_DeleteConfig
            // 
            this.btn_DeleteConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btn_DeleteConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_DeleteConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DeleteConfig.Location = new System.Drawing.Point(124, 76);
            this.btn_DeleteConfig.Name = "btn_DeleteConfig";
            this.btn_DeleteConfig.Size = new System.Drawing.Size(107, 30);
            this.btn_DeleteConfig.TabIndex = 48;
            this.btn_DeleteConfig.Text = "Delete";
            this.btn_DeleteConfig.UseVisualStyleBackColor = false;
            this.btn_DeleteConfig.Click += new System.EventHandler(this.btn_DeleteConfig_Click);
            // 
            // lbl_ColourIndex
            // 
            this.lbl_ColourIndex.AutoSize = true;
            this.lbl_ColourIndex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ColourIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ColourIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ColourIndex.Location = new System.Drawing.Point(45, 55);
            this.lbl_ColourIndex.Name = "lbl_ColourIndex";
            this.lbl_ColourIndex.Size = new System.Drawing.Size(46, 15);
            this.lbl_ColourIndex.TabIndex = 26;
            this.lbl_ColourIndex.Text = "Color 0";
            this.lbl_ColourIndex.Click += new System.EventHandler(this.lbl_ColourIndex_Click);
            // 
            // panel_Colour
            // 
            this.panel_Colour.BackColor = System.Drawing.Color.Black;
            this.panel_Colour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Colour.Location = new System.Drawing.Point(41, 76);
            this.panel_Colour.Name = "panel_Colour";
            this.panel_Colour.Size = new System.Drawing.Size(53, 35);
            this.panel_Colour.TabIndex = 25;
            this.panel_Colour.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Colour_Paint);
            // 
            // txt_imageURL
            // 
            this.txt_imageURL.BackColor = System.Drawing.Color.White;
            this.txt_imageURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_imageURL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_imageURL.Location = new System.Drawing.Point(152, 39);
            this.txt_imageURL.Name = "txt_imageURL";
            this.txt_imageURL.Size = new System.Drawing.Size(96, 20);
            this.txt_imageURL.TabIndex = 39;
            this.txt_imageURL.TextChanged += new System.EventHandler(this.txt_imageURL_TextChanged);
            // 
            // btn_RemoveColour
            // 
            this.btn_RemoveColour.BackColor = System.Drawing.Color.White;
            this.btn_RemoveColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveColour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RemoveColour.Location = new System.Drawing.Point(71, 16);
            this.btn_RemoveColour.Name = "btn_RemoveColour";
            this.btn_RemoveColour.Size = new System.Drawing.Size(53, 29);
            this.btn_RemoveColour.TabIndex = 43;
            this.btn_RemoveColour.Text = "x";
            this.btn_RemoveColour.UseVisualStyleBackColor = false;
            this.btn_RemoveColour.Click += new System.EventHandler(this.btn_RemoveColour_Click);
            // 
            // LBox_configs
            // 
            this.LBox_configs.BackColor = System.Drawing.Color.White;
            this.LBox_configs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBox_configs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBox_configs.FormattingEnabled = true;
            this.LBox_configs.Location = new System.Drawing.Point(17, 16);
            this.LBox_configs.Name = "LBox_configs";
            this.LBox_configs.Size = new System.Drawing.Size(214, 54);
            this.LBox_configs.TabIndex = 46;
            // 
            // btn_LoadConfig
            // 
            this.btn_LoadConfig.BackColor = System.Drawing.Color.White;
            this.btn_LoadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_LoadConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_LoadConfig.Location = new System.Drawing.Point(17, 76);
            this.btn_LoadConfig.Name = "btn_LoadConfig";
            this.btn_LoadConfig.Size = new System.Drawing.Size(101, 30);
            this.btn_LoadConfig.TabIndex = 47;
            this.btn_LoadConfig.Text = "Load";
            this.btn_LoadConfig.UseVisualStyleBackColor = false;
            this.btn_LoadConfig.Click += new System.EventHandler(this.btn_LoadConfig_Click);
            // 
            // txt_configName
            // 
            this.txt_configName.BackColor = System.Drawing.Color.White;
            this.txt_configName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_configName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_configName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_configName.Location = new System.Drawing.Point(143, 47);
            this.txt_configName.Name = "txt_configName";
            this.txt_configName.Size = new System.Drawing.Size(90, 21);
            this.txt_configName.TabIndex = 44;
            this.txt_configName.Tag = "";
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.BackColor = System.Drawing.Color.White;
            this.btn_SaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SaveConfig.Location = new System.Drawing.Point(143, 71);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(90, 26);
            this.btn_SaveConfig.TabIndex = 45;
            this.btn_SaveConfig.Text = "Save";
            this.btn_SaveConfig.UseVisualStyleBackColor = false;
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // btn_addColour
            // 
            this.btn_addColour.BackColor = System.Drawing.Color.White;
            this.btn_addColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_addColour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addColour.Location = new System.Drawing.Point(10, 16);
            this.btn_addColour.Name = "btn_addColour";
            this.btn_addColour.Size = new System.Drawing.Size(53, 29);
            this.btn_addColour.TabIndex = 42;
            this.btn_addColour.Text = "+";
            this.btn_addColour.UseVisualStyleBackColor = false;
            this.btn_addColour.Click += new System.EventHandler(this.btn_addColour_Click);
            // 
            // lbl_LoadImage
            // 
            this.lbl_LoadImage.AutoSize = true;
            this.lbl_LoadImage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoadImage.ForeColor = System.Drawing.Color.Black;
            this.lbl_LoadImage.Location = new System.Drawing.Point(81, 1);
            this.lbl_LoadImage.Name = "lbl_LoadImage";
            this.lbl_LoadImage.Size = new System.Drawing.Size(114, 18);
            this.lbl_LoadImage.TabIndex = 22;
            this.lbl_LoadImage.Text = "1. Load Image";
            // 
            // lbl_BottomRightPos
            // 
            this.lbl_BottomRightPos.AutoSize = true;
            this.lbl_BottomRightPos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BottomRightPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_BottomRightPos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_BottomRightPos.Location = new System.Drawing.Point(157, 65);
            this.lbl_BottomRightPos.Name = "lbl_BottomRightPos";
            this.lbl_BottomRightPos.Size = new System.Drawing.Size(35, 15);
            this.lbl_BottomRightPos.TabIndex = 20;
            this.lbl_BottomRightPos.Text = "(0, 0)";
            // 
            // lbl_TopLeftPos
            // 
            this.lbl_TopLeftPos.AutoSize = true;
            this.lbl_TopLeftPos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TopLeftPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_TopLeftPos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TopLeftPos.Location = new System.Drawing.Point(157, 28);
            this.lbl_TopLeftPos.Name = "lbl_TopLeftPos";
            this.lbl_TopLeftPos.Size = new System.Drawing.Size(35, 15);
            this.lbl_TopLeftPos.TabIndex = 19;
            this.lbl_TopLeftPos.Text = "(0, 0)";
            // 
            // btn_BottomRight
            // 
            this.btn_BottomRight.BackColor = System.Drawing.Color.White;
            this.btn_BottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_BottomRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BottomRight.Location = new System.Drawing.Point(18, 57);
            this.btn_BottomRight.Name = "btn_BottomRight";
            this.btn_BottomRight.Size = new System.Drawing.Size(118, 31);
            this.btn_BottomRight.TabIndex = 41;
            this.btn_BottomRight.Text = "Calibrate Bottom Right";
            this.btn_BottomRight.UseVisualStyleBackColor = false;
            this.btn_BottomRight.Click += new System.EventHandler(this.btn_BottomLeft_Click);
            // 
            // btn_TopLeft
            // 
            this.btn_TopLeft.BackColor = System.Drawing.Color.White;
            this.btn_TopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_TopLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TopLeft.Location = new System.Drawing.Point(18, 20);
            this.btn_TopLeft.Name = "btn_TopLeft";
            this.btn_TopLeft.Size = new System.Drawing.Size(118, 31);
            this.btn_TopLeft.TabIndex = 40;
            this.btn_TopLeft.Text = "Calibrate Top Left";
            this.btn_TopLeft.UseVisualStyleBackColor = false;
            this.btn_TopLeft.Click += new System.EventHandler(this.btn_TopLeft_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Start.Location = new System.Drawing.Point(12, 304);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(508, 50);
            this.btn_Start.TabIndex = 55;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_ConfigureCanvas
            // 
            this.lbl_ConfigureCanvas.AutoSize = true;
            this.lbl_ConfigureCanvas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ConfigureCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ConfigureCanvas.ForeColor = System.Drawing.Color.Black;
            this.lbl_ConfigureCanvas.Location = new System.Drawing.Point(340, 3);
            this.lbl_ConfigureCanvas.Name = "lbl_ConfigureCanvas";
            this.lbl_ConfigureCanvas.Size = new System.Drawing.Size(128, 18);
            this.lbl_ConfigureCanvas.TabIndex = 56;
            this.lbl_ConfigureCanvas.Text = "2. Calibrate Box";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_loadImage);
            this.panel1.Controls.Add(this.lbl_urlOption);
            this.panel1.Controls.Add(this.txt_imageURL);
            this.panel1.Controls.Add(this.lbl_ImageDir);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 103);
            this.panel1.TabIndex = 57;
            this.panel1.Tag = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_BottomRight);
            this.panel2.Controls.Add(this.btn_TopLeft);
            this.panel2.Controls.Add(this.lbl_BottomRightPos);
            this.panel2.Controls.Add(this.lbl_TopLeftPos);
            this.panel2.Location = new System.Drawing.Point(283, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 103);
            this.panel2.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_PresetName);
            this.panel3.Controls.Add(this.txt_configName);
            this.panel3.Controls.Add(this.lbl_ColourIndex);
            this.panel3.Controls.Add(this.btn_addColour);
            this.panel3.Controls.Add(this.panel_Colour);
            this.panel3.Controls.Add(this.btn_RemoveColour);
            this.panel3.Controls.Add(this.btn_SaveConfig);
            this.panel3.Location = new System.Drawing.Point(12, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 144);
            this.panel3.TabIndex = 59;
            // 
            // lbl_PresetName
            // 
            this.lbl_PresetName.AutoSize = true;
            this.lbl_PresetName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PresetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_PresetName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_PresetName.Location = new System.Drawing.Point(168, 24);
            this.lbl_PresetName.Name = "lbl_PresetName";
            this.lbl_PresetName.Size = new System.Drawing.Size(44, 15);
            this.lbl_PresetName.TabIndex = 46;
            this.lbl_PresetName.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.LBox_configs);
            this.panel4.Controls.Add(this.lbl_LoadedConfig);
            this.panel4.Controls.Add(this.btn_LoadConfig);
            this.panel4.Controls.Add(this.btn_DeleteConfig);
            this.panel4.Location = new System.Drawing.Point(284, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 144);
            this.panel4.TabIndex = 60;
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 375);
            this.Controls.Add(this.lbl_loadSavedConfig);
            this.Controls.Add(this.lbl_ConfigureCanvas);
            this.Controls.Add(this.lbl_LoadImage);
            this.Controls.Add(this.lbl_CreateColoursPreset);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Bot";
            this.Text = "Drawing Bot";
            this.Load += new System.EventHandler(this.Bot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Label lbl_LoadedConfig;
        private System.Windows.Forms.Label lbl_urlOption;
        private System.Windows.Forms.Label lbl_ImageDir;
        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.Label lbl_loadSavedConfig;
        private System.Windows.Forms.Label lbl_CreateColoursPreset;
        private System.Windows.Forms.Button btn_DeleteConfig;
        private System.Windows.Forms.Label lbl_ColourIndex;
        private System.Windows.Forms.Panel panel_Colour;
        private System.Windows.Forms.TextBox txt_imageURL;
        private System.Windows.Forms.Button btn_RemoveColour;
        private System.Windows.Forms.ListBox LBox_configs;
        private System.Windows.Forms.Button btn_LoadConfig;
        private System.Windows.Forms.TextBox txt_configName;
        private System.Windows.Forms.Button btn_SaveConfig;
        private System.Windows.Forms.Button btn_addColour;
        private System.Windows.Forms.Label lbl_LoadImage;
        private System.Windows.Forms.Label lbl_BottomRightPos;
        private System.Windows.Forms.Label lbl_TopLeftPos;
        private System.Windows.Forms.Button btn_BottomRight;
        private System.Windows.Forms.Button btn_TopLeft;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_ConfigureCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_PresetName;
        private System.Windows.Forms.Panel panel4;
    }
}