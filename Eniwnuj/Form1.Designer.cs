namespace Eniwnuj
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
            dataGridView1 = new DataGridView();
            Box1 = new TextBox();
            Box2 = new TextBox();
            Box3 = new TextBox();
            age = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            sear = new TextBox();
            button2 = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)age).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 150);
            dataGridView1.TabIndex = 2;
            // 
            // Box1
            // 
            Box1.Location = new Point(31, 33);
            Box1.Name = "Box1";
            Box1.Size = new Size(100, 23);
            Box1.TabIndex = 3;
            // 
            // Box2
            // 
            Box2.Location = new Point(31, 62);
            Box2.Name = "Box2";
            Box2.Size = new Size(100, 23);
            Box2.TabIndex = 4;
            // 
            // Box3
            // 
            Box3.Location = new Point(31, 91);
            Box3.Name = "Box3";
            Box3.Size = new Size(100, 23);
            Box3.TabIndex = 5;
            // 
            // age
            // 
            age.Location = new Point(31, 120);
            age.Name = "age";
            age.Size = new Size(88, 23);
            age.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 258);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 287);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(264, 248);
            button1.Name = "button1";
            button1.Size = new Size(151, 47);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sear
            // 
            sear.Location = new Point(449, 34);
            sear.Name = "sear";
            sear.Size = new Size(359, 23);
            sear.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(826, 33);
            button2.Name = "button2";
            button2.Size = new Size(68, 23);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(848, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(68, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 450);
            Controls.Add(btnDelete);
            Controls.Add(button2);
            Controls.Add(sear);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(age);
            Controls.Add(Box3);
            Controls.Add(Box2);
            Controls.Add(Box1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Box1;
        private TextBox Box2;
        private TextBox Box3;
        private NumericUpDown age;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private TextBox sear;
        private Button button2;
        private Button btnDelete;
    }
}
