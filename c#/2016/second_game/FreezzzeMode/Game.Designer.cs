namespace FreezzzeMode
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.te1 = new System.Windows.Forms.TextBox();
            this.te2 = new System.Windows.Forms.TextBox();
            this.te3 = new System.Windows.Forms.TextBox();
            this.te4 = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Interval = 1000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Black;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.Enabled = false;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b1.Location = new System.Drawing.Point(379, 455);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(148, 65);
            this.b1.TabIndex = 4;
            this.b1.Text = "Answer";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Black;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b2.Location = new System.Drawing.Point(163, 455);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(148, 65);
            this.b2.TabIndex = 5;
            this.b2.Text = "Start";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.White;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(74, 98);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(200, 117);
            this.l1.TabIndex = 6;
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l1.Visible = false;
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.Color.White;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(415, 97);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(200, 117);
            this.l2.TabIndex = 7;
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l2.Visible = false;
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.Color.White;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l3.Location = new System.Drawing.Point(74, 260);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(200, 117);
            this.l3.TabIndex = 8;
            this.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l3.Visible = false;
            // 
            // l4
            // 
            this.l4.BackColor = System.Drawing.Color.White;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l4.Location = new System.Drawing.Point(415, 259);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(200, 117);
            this.l4.TabIndex = 9;
            this.l4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l4.Visible = false;
            // 
            // te1
            // 
            this.te1.BackColor = System.Drawing.Color.White;
            this.te1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.te1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.te1.Location = new System.Drawing.Point(73, 96);
            this.te1.Multiline = true;
            this.te1.Name = "te1";
            this.te1.Size = new System.Drawing.Size(201, 119);
            this.te1.TabIndex = 10;
            this.te1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.te1.Visible = false;
            // 
            // te2
            // 
            this.te2.BackColor = System.Drawing.Color.White;
            this.te2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.te2.Location = new System.Drawing.Point(412, 96);
            this.te2.Multiline = true;
            this.te2.Name = "te2";
            this.te2.Size = new System.Drawing.Size(203, 118);
            this.te2.TabIndex = 11;
            this.te2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.te2.Visible = false;
            // 
            // te3
            // 
            this.te3.BackColor = System.Drawing.Color.White;
            this.te3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.te3.Location = new System.Drawing.Point(73, 260);
            this.te3.Multiline = true;
            this.te3.Name = "te3";
            this.te3.Size = new System.Drawing.Size(201, 117);
            this.te3.TabIndex = 12;
            this.te3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.te3.Visible = false;
            // 
            // te4
            // 
            this.te4.BackColor = System.Drawing.Color.White;
            this.te4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.te4.Location = new System.Drawing.Point(412, 257);
            this.te4.Multiline = true;
            this.te4.Name = "te4";
            this.te4.Size = new System.Drawing.Size(203, 120);
            this.te4.TabIndex = 13;
            this.te4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.te4.Visible = false;
            // 
            // l5
            // 
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l5.Location = new System.Drawing.Point(245, 22);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(195, 50);
            this.l5.TabIndex = 14;
            this.l5.Text = "GREAT!";
            this.l5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l5.Visible = false;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l6.Location = new System.Drawing.Point(10, 9);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(63, 13);
            this.l6.TabIndex = 15;
            this.l6.Text = "Your points:";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l7.Location = new System.Drawing.Point(79, 9);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(0, 13);
            this.l7.TabIndex = 16;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l8.Location = new System.Drawing.Point(291, 30);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(99, 31);
            this.l8.TabIndex = 17;
            this.l8.Text = "LOSE!";
            this.l8.Visible = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b3.Location = new System.Drawing.Point(593, 513);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 32);
            this.b3.TabIndex = 18;
            this.b3.Text = "Back";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 557);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.te4);
            this.Controls.Add(this.te3);
            this.Controls.Add(this.te2);
            this.Controls.Add(this.te1);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "FreezzzeMode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox te1;
        private System.Windows.Forms.TextBox te2;
        private System.Windows.Forms.TextBox te3;
        private System.Windows.Forms.TextBox te4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Button b3;
    }
}

