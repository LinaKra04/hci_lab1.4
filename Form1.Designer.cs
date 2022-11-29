
namespace lab1._4
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
            this.drawTool = new System.Windows.Forms.GroupBox();
            this.myFigure = new System.Windows.Forms.RadioButton();
            this.brusH = new System.Windows.Forms.RadioButton();
            this.peN = new System.Windows.Forms.RadioButton();
            this.drawShape = new System.Windows.Forms.GroupBox();
            this.square = new System.Windows.Forms.RadioButton();
            this.linE = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.ColoR = new System.Windows.Forms.GroupBox();
            this.blue_ = new System.Windows.Forms.RadioButton();
            this.black_ = new System.Windows.Forms.RadioButton();
            this.white_ = new System.Windows.Forms.RadioButton();
            this.yellow_ = new System.Windows.Forms.RadioButton();
            this.magenta_ = new System.Windows.Forms.RadioButton();
            this.red_ = new System.Windows.Forms.RadioButton();
            this.cyan_ = new System.Windows.Forms.RadioButton();
            this.green_ = new System.Windows.Forms.RadioButton();
            this.showShape = new System.Windows.Forms.GroupBox();
            this.soundOptions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voicE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speeD = new System.Windows.Forms.TrackBar();
            this.volumE = new System.Windows.Forms.TrackBar();
            this.starT = new System.Windows.Forms.Button();
            this.exiT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawTool.SuspendLayout();
            this.drawShape.SuspendLayout();
            this.ColoR.SuspendLayout();
            this.showShape.SuspendLayout();
            this.soundOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speeD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawTool
            // 
            this.drawTool.Controls.Add(this.myFigure);
            this.drawTool.Controls.Add(this.brusH);
            this.drawTool.Controls.Add(this.peN);
            this.drawTool.Location = new System.Drawing.Point(158, 22);
            this.drawTool.Name = "drawTool";
            this.drawTool.Size = new System.Drawing.Size(153, 203);
            this.drawTool.TabIndex = 0;
            this.drawTool.TabStop = false;
            this.drawTool.Text = "Drawing Tool";
            // 
            // myFigure
            // 
            this.myFigure.AutoSize = true;
            this.myFigure.Location = new System.Drawing.Point(6, 153);
            this.myFigure.Name = "myFigure";
            this.myFigure.Size = new System.Drawing.Size(87, 21);
            this.myFigure.TabIndex = 2;
            this.myFigure.TabStop = true;
            this.myFigure.Text = "My figure";
            this.myFigure.UseVisualStyleBackColor = true;
            this.myFigure.CheckedChanged += new System.EventHandler(this.myFigure_CheckedChanged);
            // 
            // brusH
            // 
            this.brusH.AutoSize = true;
            this.brusH.Location = new System.Drawing.Point(6, 97);
            this.brusH.Name = "brusH";
            this.brusH.Size = new System.Drawing.Size(66, 21);
            this.brusH.TabIndex = 1;
            this.brusH.TabStop = true;
            this.brusH.Text = "Brush";
            this.brusH.UseVisualStyleBackColor = true;
            this.brusH.CheckedChanged += new System.EventHandler(this.brusH_CheckedChanged);
            // 
            // peN
            // 
            this.peN.AutoSize = true;
            this.peN.Location = new System.Drawing.Point(6, 42);
            this.peN.Name = "peN";
            this.peN.Size = new System.Drawing.Size(54, 21);
            this.peN.TabIndex = 0;
            this.peN.TabStop = true;
            this.peN.Text = "Pen";
            this.peN.UseVisualStyleBackColor = true;
            this.peN.CheckedChanged += new System.EventHandler(this.pen_CheckedChanged);
            // 
            // drawShape
            // 
            this.drawShape.Controls.Add(this.square);
            this.drawShape.Controls.Add(this.linE);
            this.drawShape.Controls.Add(this.circle);
            this.drawShape.Location = new System.Drawing.Point(158, 245);
            this.drawShape.Name = "drawShape";
            this.drawShape.Size = new System.Drawing.Size(153, 203);
            this.drawShape.TabIndex = 0;
            this.drawShape.TabStop = false;
            this.drawShape.Text = "Drawing Shape";
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Location = new System.Drawing.Point(6, 161);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 21);
            this.square.TabIndex = 5;
            this.square.TabStop = true;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.CheckedChanged += new System.EventHandler(this.square_CheckedChanged);
            // 
            // linE
            // 
            this.linE.AutoSize = true;
            this.linE.Location = new System.Drawing.Point(6, 48);
            this.linE.Name = "linE";
            this.linE.Size = new System.Drawing.Size(56, 21);
            this.linE.TabIndex = 3;
            this.linE.TabStop = true;
            this.linE.Text = "Line";
            this.linE.UseVisualStyleBackColor = true;
            this.linE.CheckedChanged += new System.EventHandler(this.linE_CheckedChanged);
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(6, 107);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(64, 21);
            this.circle.TabIndex = 4;
            this.circle.TabStop = true;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.CheckedChanged += new System.EventHandler(this.circle_CheckedChanged);
            // 
            // ColoR
            // 
            this.ColoR.Controls.Add(this.blue_);
            this.ColoR.Controls.Add(this.black_);
            this.ColoR.Controls.Add(this.white_);
            this.ColoR.Controls.Add(this.yellow_);
            this.ColoR.Controls.Add(this.magenta_);
            this.ColoR.Controls.Add(this.red_);
            this.ColoR.Controls.Add(this.cyan_);
            this.ColoR.Controls.Add(this.green_);
            this.ColoR.Location = new System.Drawing.Point(338, 22);
            this.ColoR.Name = "ColoR";
            this.ColoR.Size = new System.Drawing.Size(147, 426);
            this.ColoR.TabIndex = 0;
            this.ColoR.TabStop = false;
            this.ColoR.Text = "Color";
            // 
            // blue_
            // 
            this.blue_.AutoSize = true;
            this.blue_.Location = new System.Drawing.Point(6, 88);
            this.blue_.Name = "blue_";
            this.blue_.Size = new System.Drawing.Size(57, 21);
            this.blue_.TabIndex = 7;
            this.blue_.TabStop = true;
            this.blue_.Text = "Blue";
            this.blue_.UseVisualStyleBackColor = true;
            this.blue_.CheckedChanged += new System.EventHandler(this.blue__CheckedChanged);
            // 
            // black_
            // 
            this.black_.AutoSize = true;
            this.black_.Location = new System.Drawing.Point(6, 42);
            this.black_.Name = "black_";
            this.black_.Size = new System.Drawing.Size(63, 21);
            this.black_.TabIndex = 6;
            this.black_.TabStop = true;
            this.black_.Text = "Black";
            this.black_.UseVisualStyleBackColor = true;
            this.black_.CheckedChanged += new System.EventHandler(this.black__CheckedChanged);
            // 
            // white_
            // 
            this.white_.AutoSize = true;
            this.white_.Location = new System.Drawing.Point(6, 384);
            this.white_.Name = "white_";
            this.white_.Size = new System.Drawing.Size(65, 21);
            this.white_.TabIndex = 13;
            this.white_.TabStop = true;
            this.white_.Text = "White";
            this.white_.UseVisualStyleBackColor = true;
            this.white_.CheckedChanged += new System.EventHandler(this.white__CheckedChanged);
            // 
            // yellow_
            // 
            this.yellow_.AutoSize = true;
            this.yellow_.Location = new System.Drawing.Point(6, 330);
            this.yellow_.Name = "yellow_";
            this.yellow_.Size = new System.Drawing.Size(69, 21);
            this.yellow_.TabIndex = 12;
            this.yellow_.TabStop = true;
            this.yellow_.Text = "Yellow";
            this.yellow_.UseVisualStyleBackColor = true;
            this.yellow_.CheckedChanged += new System.EventHandler(this.yellow__CheckedChanged);
            // 
            // magenta_
            // 
            this.magenta_.AutoSize = true;
            this.magenta_.Location = new System.Drawing.Point(6, 280);
            this.magenta_.Name = "magenta_";
            this.magenta_.Size = new System.Drawing.Size(84, 21);
            this.magenta_.TabIndex = 11;
            this.magenta_.TabStop = true;
            this.magenta_.Text = "Magenta";
            this.magenta_.UseVisualStyleBackColor = true;
            this.magenta_.CheckedChanged += new System.EventHandler(this.magenta__CheckedChanged);
            // 
            // red_
            // 
            this.red_.AutoSize = true;
            this.red_.Location = new System.Drawing.Point(6, 233);
            this.red_.Name = "red_";
            this.red_.Size = new System.Drawing.Size(55, 21);
            this.red_.TabIndex = 10;
            this.red_.TabStop = true;
            this.red_.Text = "Red";
            this.red_.UseVisualStyleBackColor = true;
            this.red_.CheckedChanged += new System.EventHandler(this.red__CheckedChanged);
            // 
            // cyan_
            // 
            this.cyan_.AutoSize = true;
            this.cyan_.Location = new System.Drawing.Point(6, 182);
            this.cyan_.Name = "cyan_";
            this.cyan_.Size = new System.Drawing.Size(61, 21);
            this.cyan_.TabIndex = 9;
            this.cyan_.TabStop = true;
            this.cyan_.Text = "Cyan";
            this.cyan_.UseVisualStyleBackColor = true;
            this.cyan_.CheckedChanged += new System.EventHandler(this.cyan__CheckedChanged);
            // 
            // green_
            // 
            this.green_.AutoSize = true;
            this.green_.Location = new System.Drawing.Point(6, 137);
            this.green_.Name = "green_";
            this.green_.Size = new System.Drawing.Size(69, 21);
            this.green_.TabIndex = 8;
            this.green_.TabStop = true;
            this.green_.Text = "Green";
            this.green_.UseVisualStyleBackColor = true;
            this.green_.CheckedChanged += new System.EventHandler(this.green__CheckedChanged);
            // 
            // showShape
            // 
            this.showShape.Controls.Add(this.pictureBox1);
            this.showShape.Location = new System.Drawing.Point(516, 22);
            this.showShape.Name = "showShape";
            this.showShape.Size = new System.Drawing.Size(702, 426);
            this.showShape.TabIndex = 0;
            this.showShape.TabStop = false;
            this.showShape.Text = "Show Shape";
            this.showShape.Enter += new System.EventHandler(this.showShape_Enter);
            // 
            // soundOptions
            // 
            this.soundOptions.Controls.Add(this.label3);
            this.soundOptions.Controls.Add(this.label1);
            this.soundOptions.Controls.Add(this.voicE);
            this.soundOptions.Controls.Add(this.label2);
            this.soundOptions.Controls.Add(this.speeD);
            this.soundOptions.Controls.Add(this.volumE);
            this.soundOptions.Controls.Add(this.starT);
            this.soundOptions.Location = new System.Drawing.Point(164, 482);
            this.soundOptions.Name = "soundOptions";
            this.soundOptions.Size = new System.Drawing.Size(744, 132);
            this.soundOptions.TabIndex = 0;
            this.soundOptions.TabStop = false;
            this.soundOptions.Text = "Sound options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Voice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volume";
            // 
            // voicE
            // 
            this.voicE.FormattingEnabled = true;
            this.voicE.Items.AddRange(new object[] {
            "Born to die",
            "Love me again",
            "Smells like teen spirit",
            "Alien blues",
            "Щедрик"});
            this.voicE.Location = new System.Drawing.Point(84, 82);
            this.voicE.Name = "voicE";
            this.voicE.Size = new System.Drawing.Size(201, 24);
            this.voicE.TabIndex = 6;
            this.voicE.SelectedIndexChanged += new System.EventHandler(this.voicE_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Speed";
            // 
            // speeD
            // 
            this.speeD.Location = new System.Drawing.Point(472, 31);
            this.speeD.Name = "speeD";
            this.speeD.Size = new System.Drawing.Size(201, 56);
            this.speeD.TabIndex = 5;
            // 
            // volumE
            // 
            this.volumE.Location = new System.Drawing.Point(84, 31);
            this.volumE.Name = "volumE";
            this.volumE.Size = new System.Drawing.Size(201, 56);
            this.volumE.TabIndex = 4;
            // 
            // starT
            // 
            this.starT.Location = new System.Drawing.Point(640, 94);
            this.starT.Name = "starT";
            this.starT.Size = new System.Drawing.Size(98, 32);
            this.starT.TabIndex = 0;
            this.starT.Text = "Start";
            this.starT.UseVisualStyleBackColor = true;
            this.starT.Click += new System.EventHandler(this.starT_Click);
            // 
            // exiT
            // 
            this.exiT.Location = new System.Drawing.Point(457, 648);
            this.exiT.Name = "exiT";
            this.exiT.Size = new System.Drawing.Size(98, 32);
            this.exiT.TabIndex = 1;
            this.exiT.Text = "Exit";
            this.exiT.UseVisualStyleBackColor = true;
            this.exiT.Click += new System.EventHandler(this.exiT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 405);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1409, 723);
            this.Controls.Add(this.exiT);
            this.Controls.Add(this.soundOptions);
            this.Controls.Add(this.drawShape);
            this.Controls.Add(this.ColoR);
            this.Controls.Add(this.showShape);
            this.Controls.Add(this.drawTool);
            this.Name = "Form1";
            this.Text = "Form1";
            this.drawTool.ResumeLayout(false);
            this.drawTool.PerformLayout();
            this.drawShape.ResumeLayout(false);
            this.drawShape.PerformLayout();
            this.ColoR.ResumeLayout(false);
            this.ColoR.PerformLayout();
            this.showShape.ResumeLayout(false);
            this.soundOptions.ResumeLayout(false);
            this.soundOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speeD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox drawTool;
        private System.Windows.Forms.RadioButton myFigure;
        private System.Windows.Forms.RadioButton brusH;
        private System.Windows.Forms.RadioButton peN;
        private System.Windows.Forms.GroupBox drawShape;
        private System.Windows.Forms.RadioButton square;
        private System.Windows.Forms.RadioButton linE;
        private System.Windows.Forms.RadioButton circle;
        private System.Windows.Forms.GroupBox ColoR;
        private System.Windows.Forms.GroupBox showShape;
        private System.Windows.Forms.RadioButton black_;
        private System.Windows.Forms.RadioButton blue_;
        private System.Windows.Forms.RadioButton green_;
        private System.Windows.Forms.RadioButton cyan_;
        private System.Windows.Forms.RadioButton red_;
        private System.Windows.Forms.RadioButton magenta_;
        private System.Windows.Forms.RadioButton yellow_;
        private System.Windows.Forms.RadioButton white_;
        private System.Windows.Forms.GroupBox soundOptions;
        private System.Windows.Forms.Button starT;
        private System.Windows.Forms.Button exiT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox voicE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar speeD;
        private System.Windows.Forms.TrackBar volumE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

