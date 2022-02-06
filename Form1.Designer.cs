namespace activity14
{
    partial class Form1
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
            this.CheckListItems = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Person = new System.Windows.Forms.ListBox();
            this.Age = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Symptoms = new System.Windows.Forms.Label();
            this.Yes_btn = new System.Windows.Forms.RadioButton();
            this.No_btn = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.CheckListItems.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckListItems
            // 
            this.CheckListItems.Controls.Add(this.button1);
            this.CheckListItems.Controls.Add(this.checkBox3);
            this.CheckListItems.Controls.Add(this.checkBox2);
            this.CheckListItems.Controls.Add(this.groupBox1);
            this.CheckListItems.Controls.Add(this.checkBox1);
            this.CheckListItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckListItems.Location = new System.Drawing.Point(147, 170);
            this.CheckListItems.Name = "CheckListItems";
            this.CheckListItems.Size = new System.Drawing.Size(357, 136);
            this.CheckListItems.TabIndex = 0;
            this.CheckListItems.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 26);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Under 50";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 26);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Under 25";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 26);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Under 15";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Person
            // 
            this.Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person.FormattingEnabled = true;
            this.Person.ItemHeight = 26;
            this.Person.Items.AddRange(new object[] {
            "Athlete",
            "Staff ",
            "Student",
            "Child ",
            ""});
            this.Person.Location = new System.Drawing.Point(243, 79);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(200, 56);
            this.Person.TabIndex = 3;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(310, 142);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(48, 25);
            this.Age.TabIndex = 4;
            this.Age.Text = "Age";
            this.Age.Click += new System.EventHandler(this.Age_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scroll and Select";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Input Age";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Input Age";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Symptoms
            // 
            this.Symptoms.AutoSize = true;
            this.Symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptoms.Location = new System.Drawing.Point(269, 320);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(185, 25);
            this.Symptoms.TabIndex = 4;
            this.Symptoms.Text = "Feeling Symptoms?";
            // 
            // Yes_btn
            // 
            this.Yes_btn.AutoSize = true;
            this.Yes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes_btn.Location = new System.Drawing.Point(154, 360);
            this.Yes_btn.Name = "Yes_btn";
            this.Yes_btn.Size = new System.Drawing.Size(62, 24);
            this.Yes_btn.TabIndex = 6;
            this.Yes_btn.TabStop = true;
            this.Yes_btn.Text = "Yes";
            this.Yes_btn.UseVisualStyleBackColor = true;
            // 
            // No_btn
            // 
            this.No_btn.AutoSize = true;
            this.No_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_btn.Location = new System.Drawing.Point(154, 390);
            this.No_btn.Name = "No_btn";
            this.No_btn.Size = new System.Drawing.Size(54, 24);
            this.No_btn.TabIndex = 6;
            this.No_btn.TabStop = true;
            this.No_btn.Text = "No";
            this.No_btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(288, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Input Health Conditions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.No_btn);
            this.Controls.Add(this.Yes_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Symptoms);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.CheckListItems);
            this.Name = "Form1";
            this.Text = "Covid 19 Questionare";
            this.CheckListItems.ResumeLayout(false);
            this.CheckListItems.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CheckListItems;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox Person;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Symptoms;
        private System.Windows.Forms.RadioButton Yes_btn;
        private System.Windows.Forms.RadioButton No_btn;
        private System.Windows.Forms.Button button3;
    }
}

