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
            this.Anket = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dadname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anket
            // 
            this.Anket.Controls.Add(this.save);
            this.Anket.Controls.Add(this.female);
            this.Anket.Controls.Add(this.male);
            this.Anket.Controls.Add(this.label10);
            this.Anket.Controls.Add(this.label9);
            this.Anket.Controls.Add(this.dateTimePicker1);
            this.Anket.Controls.Add(this.number);
            this.Anket.Controls.Add(this.label5);
            this.Anket.Controls.Add(this.label6);
            this.Anket.Controls.Add(this.city);
            this.Anket.Controls.Add(this.label7);
            this.Anket.Controls.Add(this.country);
            this.Anket.Controls.Add(this.label8);
            this.Anket.Controls.Add(this.dadname);
            this.Anket.Controls.Add(this.label4);
            this.Anket.Controls.Add(this.label3);
            this.Anket.Controls.Add(this.name);
            this.Anket.Controls.Add(this.label2);
            this.Anket.Controls.Add(this.surname);
            this.Anket.Controls.Add(this.label1);
            this.Anket.Location = new System.Drawing.Point(12, 79);
            this.Anket.Name = "Anket";
            this.Anket.Size = new System.Drawing.Size(334, 464);
            this.Anket.TabIndex = 0;
            this.Anket.TabStop = false;
            this.Anket.Text = "Anket";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(14, 426);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(305, 23);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(234, 391);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(63, 19);
            this.female.TabIndex = 18;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(160, 391);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(51, 19);
            this.male.TabIndex = 17;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(47, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 30);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 323);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(169, 258);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(150, 23);
            this.number.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 11;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(169, 225);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(150, 23);
            this.city.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(71, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "City :";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(169, 193);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(150, 23);
            this.country.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(27, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country :";
            // 
            // dadname
            // 
            this.dadname.Location = new System.Drawing.Point(169, 117);
            this.dadname.Name = "dadname";
            this.dadname.Size = new System.Drawing.Size(150, 23);
            this.dadname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dad\'s name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(169, 86);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 23);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(169, 54);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(150, 23);
            this.surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(49, 27);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(150, 23);
            this.search.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(234, 26);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 555);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Anket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Anket.ResumeLayout(false);
            this.Anket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Anket;
        private Label label1;
        private TextBox surname;
        private TextBox name;
        private Label label2;
        private TextBox dadname;
        private Label label4;
        private Label label3;
        private TextBox number;
        private Label label5;
        private Label label6;
        private TextBox city;
        private Label label7;
        private TextBox country;
        private Label label8;
        private Button save;
        private RadioButton female;
        private RadioButton male;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox search;
        private Button searchbutton;
    }
}