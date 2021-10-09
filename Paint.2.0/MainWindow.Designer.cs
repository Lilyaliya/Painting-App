
namespace Paint._2._0
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rectanControl = new System.Windows.Forms.Button();
            this.squareControl = new System.Windows.Forms.Button();
            this.circleControl = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.itemList = new System.Windows.Forms.CheckedListBox();
            this.additional = new System.Windows.Forms.Button();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.boxHeigth = new System.Windows.Forms.TextBox();
            this.trashBtn = new System.Windows.Forms.Button();
            this.canva = new System.Windows.Forms.PictureBox();
            this.moveBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rectanControl);
            this.panel1.Controls.Add(this.squareControl);
            this.panel1.Controls.Add(this.circleControl);
            this.panel1.Location = new System.Drawing.Point(740, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 222);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(26, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 36);
            this.button1.TabIndex = 5;
            this.button1.Tag = "random";
            this.button1.Text = "СЛУЧАЙНО";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rectanControl
            // 
            this.rectanControl.BackColor = System.Drawing.Color.Transparent;
            this.rectanControl.BackgroundImage = global::Paint._2._0.Properties.Resources.rectangle_icon_172928;
            this.rectanControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectanControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectanControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rectanControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rectanControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rectanControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectanControl.Location = new System.Drawing.Point(26, 107);
            this.rectanControl.Name = "rectanControl";
            this.rectanControl.Size = new System.Drawing.Size(186, 67);
            this.rectanControl.TabIndex = 4;
            this.rectanControl.Tag = "button";
            this.rectanControl.Text = "ПРЯМОУГОЛЬНИК";
            this.rectanControl.UseVisualStyleBackColor = false;
            this.rectanControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // squareControl
            // 
            this.squareControl.BackColor = System.Drawing.Color.Transparent;
            this.squareControl.BackgroundImage = global::Paint._2._0.Properties.Resources.square_icon_184667;
            this.squareControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.squareControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.squareControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.squareControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.squareControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareControl.Location = new System.Drawing.Point(26, 11);
            this.squareControl.Name = "squareControl";
            this.squareControl.Size = new System.Drawing.Size(90, 90);
            this.squareControl.TabIndex = 3;
            this.squareControl.Tag = "button";
            this.squareControl.Text = "КВАДРАТ";
            this.squareControl.UseVisualStyleBackColor = false;
            this.squareControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // circleControl
            // 
            this.circleControl.BackColor = System.Drawing.Color.Transparent;
            this.circleControl.BackgroundImage = global::Paint._2._0.Properties.Resources.circle_icon_144418;
            this.circleControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circleControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleControl.Location = new System.Drawing.Point(122, 11);
            this.circleControl.Name = "circleControl";
            this.circleControl.Size = new System.Drawing.Size(90, 90);
            this.circleControl.TabIndex = 2;
            this.circleControl.Tag = "button";
            this.circleControl.Text = "КРУГ";
            this.circleControl.UseVisualStyleBackColor = false;
            this.circleControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.ForeColor = System.Drawing.Color.Maroon;
            this.message.Location = new System.Drawing.Point(3, 2);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(131, 21);
            this.message.TabIndex = 2;
            this.message.Text = "ПРЯМОУГОЛЬНИК";
            // 
            // timerMessage
            // 
            this.timerMessage.Tick += new System.EventHandler(this.timerMessage_Tick);
            // 
            // itemList
            // 
            this.itemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemList.CheckOnClick = true;
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(747, 232);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(226, 156);
            this.itemList.TabIndex = 3;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // additional
            // 
            this.additional.BackColor = System.Drawing.Color.Transparent;
            this.additional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.additional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.additional.Enabled = false;
            this.additional.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.additional.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.additional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.additional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additional.Location = new System.Drawing.Point(822, 394);
            this.additional.Name = "additional";
            this.additional.Size = new System.Drawing.Size(151, 51);
            this.additional.TabIndex = 5;
            this.additional.Tag = "button";
            this.additional.Text = "ДОПОЛНИТЕЛЬНО";
            this.additional.UseVisualStyleBackColor = false;
            this.additional.Visible = false;
            this.additional.Click += new System.EventHandler(this.additional_Click);
            // 
            // boxWidth
            // 
            this.boxWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.boxWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxWidth.Enabled = false;
            this.boxWidth.ForeColor = System.Drawing.Color.Black;
            this.boxWidth.Location = new System.Drawing.Point(7, 2);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(77, 27);
            this.boxWidth.TabIndex = 6;
            this.boxWidth.Text = "ДЛИНА";
            this.boxWidth.Visible = false;
            this.boxWidth.TextChanged += new System.EventHandler(this.boxWidth_TextChanged);
            // 
            // boxHeigth
            // 
            this.boxHeigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.boxHeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxHeigth.Enabled = false;
            this.boxHeigth.ForeColor = System.Drawing.Color.Black;
            this.boxHeigth.Location = new System.Drawing.Point(7, 35);
            this.boxHeigth.Name = "boxHeigth";
            this.boxHeigth.Size = new System.Drawing.Size(77, 27);
            this.boxHeigth.TabIndex = 7;
            this.boxHeigth.Text = "ВЫСОТА";
            this.boxHeigth.Visible = false;
            this.boxHeigth.TextChanged += new System.EventHandler(this.boxHeigth_TextChanged);
            // 
            // trashBtn
            // 
            this.trashBtn.BackColor = System.Drawing.Color.Transparent;
            this.trashBtn.BackgroundImage = global::Paint._2._0.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.trashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashBtn.Enabled = false;
            this.trashBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trashBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trashBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trashBtn.Location = new System.Drawing.Point(747, 394);
            this.trashBtn.Name = "trashBtn";
            this.trashBtn.Size = new System.Drawing.Size(55, 51);
            this.trashBtn.TabIndex = 8;
            this.trashBtn.Tag = "button";
            this.trashBtn.UseVisualStyleBackColor = false;
            this.trashBtn.Visible = false;
            this.trashBtn.Click += new System.EventHandler(this.trashBtn_Click);
            // 
            // canva
            // 
            this.canva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canva.Dock = System.Windows.Forms.DockStyle.Left;
            this.canva.Location = new System.Drawing.Point(0, 0);
            this.canva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.canva.Name = "canva";
            this.canva.Size = new System.Drawing.Size(740, 572);
            this.canva.TabIndex = 0;
            this.canva.TabStop = false;
            this.canva.Paint += new System.Windows.Forms.PaintEventHandler(this.canva_Paint);
            this.canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canva_MouseClick);
            this.canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canva_MouseDown);
            this.canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canva_MouseMove);
            this.canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canva_MouseUp);
            // 
            // moveBtn
            // 
            this.moveBtn.BackColor = System.Drawing.Color.Transparent;
            this.moveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveBtn.Enabled = false;
            this.moveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.moveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.moveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.moveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveBtn.Location = new System.Drawing.Point(747, 509);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(226, 51);
            this.moveBtn.TabIndex = 9;
            this.moveBtn.Tag = "button";
            this.moveBtn.Text = "ПЕРЕМЕСТИТЬ";
            this.moveBtn.UseVisualStyleBackColor = false;
            this.moveBtn.Visible = false;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(7, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "РАДИУС";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 572);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.trashBtn);
            this.Controls.Add(this.boxHeigth);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.additional);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canva);
            this.Font = new System.Drawing.Font("Pacifico", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button circleControl;
        private System.Windows.Forms.Button rectanControl;
        private System.Windows.Forms.Button squareControl;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Timer timerMessage;
        private System.Windows.Forms.CheckedListBox itemList;
        private System.Windows.Forms.Button additional;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.TextBox boxHeigth;
        private System.Windows.Forms.Button trashBtn;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

