namespace tringleVorm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Run_button2 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            angA = new TextBox();
            angB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Run_button2
            // 
            Run_button2.BackColor = Color.LightGreen;
            Run_button2.Cursor = Cursors.Hand;
            Run_button2.FlatAppearance.BorderColor = Color.DarkGreen;
            Run_button2.FlatAppearance.BorderSize = 7;
            Run_button2.FlatStyle = FlatStyle.Flat;
            Run_button2.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            Run_button2.Location = new Point(284, 236);
            Run_button2.Name = "Run_button2";
            Run_button2.Size = new Size(204, 113);
            Run_button2.TabIndex = 1;
            Run_button2.Text = "Start";
            Run_button2.UseVisualStyleBackColor = false;
            Run_button2.Click += Run_button2_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView2.Location = new Point(332, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(440, 204);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "pole";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "value";
            columnHeader2.Width = 220;
            // 
            // angA
            // 
            angA.Location = new Point(627, 250);
            angA.Name = "angA";
            angA.Size = new Size(100, 23);
            angA.TabIndex = 4;
            // 
            // angB
            // 
            angB.Location = new Point(627, 290);
            angB.Name = "angB";
            angB.Size = new Size(100, 23);
            angB.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 253);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "angle A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 293);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 8;
            label2.Text = "angle B";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 204);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(angB);
            Controls.Add(angA);
            Controls.Add(listView2);
            Controls.Add(Run_button2);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Run_button2;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox angA;
        private TextBox angB;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}