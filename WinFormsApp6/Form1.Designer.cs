namespace WinFormsApp6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbl_keycode = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_font = new System.Windows.Forms.Button();
            this.lbl_font = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_open
            // 
            this.btn_open.AutoSize = true;
            this.btn_open.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_open.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_open.Location = new System.Drawing.Point(123, 369);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(88, 35);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(217, 369);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 35);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 186);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.AutoSize = true;
            this.btn_open_folder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_open_folder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_open_folder.Location = new System.Drawing.Point(689, 87);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(123, 35);
            this.btn_open_folder.TabIndex = 4;
            this.btn_open_folder.Text = "Open folder";
            this.btn_open_folder.UseVisualStyleBackColor = false;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder Path";
            // 
            // btn_color
            // 
            this.btn_color.AutoSize = true;
            this.btn_color.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_color.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_color.Location = new System.Drawing.Point(689, 271);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(123, 35);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "Select Color";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(689, 233);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(134, 25);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Selected Color";
            // 
            // lbl_keycode
            // 
            this.lbl_keycode.AutoSize = true;
            this.lbl_keycode.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_keycode.Location = new System.Drawing.Point(70, 495);
            this.lbl_keycode.Name = "lbl_keycode";
            this.lbl_keycode.Size = new System.Drawing.Size(150, 45);
            this.lbl_keycode.TabIndex = 6;
            this.lbl_keycode.Text = "Key code";
            // 
            // btn_font
            // 
            this.btn_font.AutoSize = true;
            this.btn_font.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_font.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_font.Location = new System.Drawing.Point(689, 488);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(123, 35);
            this.btn_font.TabIndex = 4;
            this.btn_font.Text = "Select Font";
            this.btn_font.UseVisualStyleBackColor = false;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Location = new System.Drawing.Point(689, 450);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(125, 25);
            this.lbl_font.TabIndex = 5;
            this.lbl_font.Text = "Selected Font";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 613);
            this.Controls.Add(this.lbl_keycode);
            this.Controls.Add(this.lbl_font);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.btn_font);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_open_folder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog1;
        private Button btn_open;
        private Button btn_save;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_open_folder;
        private Label label1;
        private Button btn_color;
        private Label lbl_color;
        private ColorDialog colorDialog1;
        private Label lbl_keycode;
        private FontDialog fontDialog1;
        private Button btn_font;
        private Label lbl_font;
    }
}