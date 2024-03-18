namespace Slot_Machine
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            spinButton = new Button();
            stopButton2 = new Button();
            exitButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(81, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(284, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(487, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(136, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // spinButton
            // 
            spinButton.Location = new Point(127, 273);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(75, 23);
            spinButton.TabIndex = 4;
            spinButton.Text = "Spin";
            spinButton.UseVisualStyleBackColor = true;
            spinButton.Click += spinButton_Click;
            // 
            // stopButton2
            // 
            stopButton2.Location = new Point(284, 273);
            stopButton2.Name = "stopButton2";
            stopButton2.Size = new Size(75, 23);
            stopButton2.TabIndex = 5;
            stopButton2.Text = "Stop";
            stopButton2.UseVisualStyleBackColor = true;
            stopButton2.Click += stopButton2_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(464, 273);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 241);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 7;
            label1.Text = "Amount inserted: $";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Apple.bmp");
            imageList1.Images.SetKeyName(1, "Banana.bmp");
            imageList1.Images.SetKeyName(2, "Cherries.bmp");
            imageList1.Images.SetKeyName(3, "Grapes.bmp");
            imageList1.Images.SetKeyName(4, "Lemon.bmp");
            imageList1.Images.SetKeyName(5, "Lime.bmp");
            imageList1.Images.SetKeyName(6, "Orange.bmp");
            imageList1.Images.SetKeyName(7, "Pear.bmp");
            imageList1.Images.SetKeyName(8, "Strawberry.bmp");
            imageList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(stopButton2);
            Controls.Add(spinButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button spinButton;
        private Button stopButton2;
        private Button exitButton;
        private Label label1;
        private TextBox textBox1;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}