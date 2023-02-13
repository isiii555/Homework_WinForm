namespace WinFormsApp2
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
            this.font_combo = new System.Windows.Forms.ComboBox();
            this.size_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bold_button = new System.Windows.Forms.Button();
            this.under_button = new System.Windows.Forms.Button();
            this.italic_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.color_combo = new System.Windows.Forms.ComboBox();
            this.load_text = new System.Windows.Forms.TextBox();
            this.save_text = new System.Windows.Forms.TextBox();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.right_button = new System.Windows.Forms.Button();
            this.center_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // font_combo
            // 
            this.font_combo.FormattingEnabled = true;
            this.font_combo.Location = new System.Drawing.Point(12, 39);
            this.font_combo.Name = "font_combo";
            this.font_combo.Size = new System.Drawing.Size(121, 23);
            this.font_combo.TabIndex = 0;
            this.font_combo.SelectedIndexChanged += new System.EventHandler(this.font_combo_SelectedIndexChanged);
            // 
            // size_combo
            // 
            this.size_combo.FormattingEnabled = true;
            this.size_combo.Location = new System.Drawing.Point(139, 39);
            this.size_combo.Name = "size_combo";
            this.size_combo.Size = new System.Drawing.Size(66, 23);
            this.size_combo.TabIndex = 1;
            this.size_combo.SelectedIndexChanged += new System.EventHandler(this.size_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // bold_button
            // 
            this.bold_button.AutoSize = true;
            this.bold_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bold_button.Location = new System.Drawing.Point(217, 37);
            this.bold_button.Name = "bold_button";
            this.bold_button.Size = new System.Drawing.Size(27, 25);
            this.bold_button.TabIndex = 4;
            this.bold_button.Text = "B";
            this.bold_button.UseVisualStyleBackColor = true;
            this.bold_button.Click += new System.EventHandler(this.bold_button_Click);
            // 
            // under_button
            // 
            this.under_button.AutoSize = true;
            this.under_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.under_button.Location = new System.Drawing.Point(250, 37);
            this.under_button.Name = "under_button";
            this.under_button.Size = new System.Drawing.Size(27, 25);
            this.under_button.TabIndex = 5;
            this.under_button.Text = "U";
            this.under_button.UseVisualStyleBackColor = true;
            this.under_button.Click += new System.EventHandler(this.under_button_Click);
            // 
            // italic_button
            // 
            this.italic_button.AutoSize = true;
            this.italic_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italic_button.Location = new System.Drawing.Point(283, 37);
            this.italic_button.Name = "italic_button";
            this.italic_button.Size = new System.Drawing.Size(27, 25);
            this.italic_button.TabIndex = 6;
            this.italic_button.Text = "I";
            this.italic_button.UseVisualStyleBackColor = true;
            this.italic_button.Click += new System.EventHandler(this.italic_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Font Style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // color_combo
            // 
            this.color_combo.FormattingEnabled = true;
            this.color_combo.Location = new System.Drawing.Point(417, 37);
            this.color_combo.Name = "color_combo";
            this.color_combo.Size = new System.Drawing.Size(121, 23);
            this.color_combo.TabIndex = 9;
            this.color_combo.SelectedIndexChanged += new System.EventHandler(this.color_combo_SelectedIndexChanged);
            // 
            // load_text
            // 
            this.load_text.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.load_text.Location = new System.Drawing.Point(544, 19);
            this.load_text.Name = "load_text";
            this.load_text.Size = new System.Drawing.Size(198, 22);
            this.load_text.TabIndex = 11;
            this.load_text.Text = "Enter name and load file...";
            this.load_text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.load_text_MouseDown);
            // 
            // save_text
            // 
            this.save_text.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.save_text.Location = new System.Drawing.Point(544, 48);
            this.save_text.Name = "save_text";
            this.save_text.Size = new System.Drawing.Size(198, 22);
            this.save_text.TabIndex = 12;
            this.save_text.Text = "Tap to enter name and save";
            this.save_text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.save_text_MouseDown);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(748, 19);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(81, 23);
            this.load_button.TabIndex = 13;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(748, 48);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(81, 23);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alignment";
            // 
            // right_button
            // 
            this.right_button.AutoSize = true;
            this.right_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.right_button.Location = new System.Drawing.Point(384, 37);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(27, 25);
            this.right_button.TabIndex = 17;
            this.right_button.Text = "R";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // center_button
            // 
            this.center_button.AutoSize = true;
            this.center_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.center_button.Location = new System.Drawing.Point(351, 37);
            this.center_button.Name = "center_button";
            this.center_button.Size = new System.Drawing.Size(27, 25);
            this.center_button.TabIndex = 16;
            this.center_button.Text = "C";
            this.center_button.UseVisualStyleBackColor = true;
            this.center_button.Click += new System.EventHandler(this.center_button_Click);
            // 
            // left_button
            // 
            this.left_button.AutoSize = true;
            this.left_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left_button.Location = new System.Drawing.Point(318, 37);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(27, 25);
            this.left_button.TabIndex = 15;
            this.left_button.Text = "L";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(12, 77);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(817, 361);
            this.text.TabIndex = 19;
            this.text.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.center_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_text);
            this.Controls.Add(this.load_text);
            this.Controls.Add(this.color_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.italic_button);
            this.Controls.Add(this.under_button);
            this.Controls.Add(this.bold_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size_combo);
            this.Controls.Add(this.font_combo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox font_combo;
        private ComboBox size_combo;
        private Label label1;
        private Label label2;
        private Button bold_button;
        private Button under_button;
        private Button italic_button;
        private Label label3;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private Label label4;
        private ComboBox color_combo;
        private TextBox load_text;
        private TextBox save_text;
        private Button load_button;
        private Button save_button;
        private Label label5;
        private Button right_button;
        private Button center_button;
        private Button left_button;
        private RichTextBox text;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}