namespace WindowsFormsApp9
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
            this.components = new System.ComponentModel.Container();
            this.X_Button = new System.Windows.Forms.Label();
            this.minimize_Button = new System.Windows.Forms.Label();
            this.PB_Ground = new System.Windows.Forms.PictureBox();
            this.PB_Player = new System.Windows.Forms.PictureBox();
            this.timer_Gravy = new System.Windows.Forms.Timer(this.components);
            this.timer_up = new System.Windows.Forms.Timer(this.components);
            this.timer_left = new System.Windows.Forms.Timer(this.components);
            this.timer_right = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // X_Button
            // 
            this.X_Button.AutoSize = true;
            this.X_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_Button.Location = new System.Drawing.Point(813, 9);
            this.X_Button.Name = "X_Button";
            this.X_Button.Size = new System.Drawing.Size(23, 22);
            this.X_Button.TabIndex = 0;
            this.X_Button.Text = "X";
            this.X_Button.Click += new System.EventHandler(this.X_Button_Click);
            // 
            // minimize_Button
            // 
            this.minimize_Button.AutoSize = true;
            this.minimize_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize_Button.Location = new System.Drawing.Point(786, 9);
            this.minimize_Button.Name = "minimize_Button";
            this.minimize_Button.Size = new System.Drawing.Size(21, 22);
            this.minimize_Button.TabIndex = 1;
            this.minimize_Button.Text = "_";
            this.minimize_Button.Click += new System.EventHandler(this.minimize_Button_Click);
            // 
            // PB_Ground
            // 
            this.PB_Ground.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PB_Ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_Ground.InitialImage = null;
            this.PB_Ground.Location = new System.Drawing.Point(0, 492);
            this.PB_Ground.Name = "PB_Ground";
            this.PB_Ground.Size = new System.Drawing.Size(848, 137);
            this.PB_Ground.TabIndex = 2;
            this.PB_Ground.TabStop = false;
            // 
            // PB_Player
            // 
            this.PB_Player.BackColor = System.Drawing.Color.Transparent;
            this.PB_Player.ErrorImage = null;
            this.PB_Player.Location = new System.Drawing.Point(49, 392);
            this.PB_Player.Name = "PB_Player";
            this.PB_Player.Size = new System.Drawing.Size(63, 79);
            this.PB_Player.TabIndex = 4;
            this.PB_Player.TabStop = false;
            // 
            // timer_Gravy
            // 
            this.timer_Gravy.Enabled = true;
            this.timer_Gravy.Interval = 10;
            this.timer_Gravy.Tick += new System.EventHandler(this.timer_Gravy_Tick);
            // 
            // timer_up
            // 
            this.timer_up.Interval = 10;
            this.timer_up.Tick += new System.EventHandler(this.timer_up_Tick);
            // 
            // timer_left
            // 
            this.timer_left.Interval = 10;
            this.timer_left.Tick += new System.EventHandler(this.timer_left_Tick);
            // 
            // timer_right
            // 
            this.timer_right.Interval = 10;
            this.timer_right.Tick += new System.EventHandler(this.timer_right_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(848, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Player);
            this.Controls.Add(this.PB_Ground);
            this.Controls.Add(this.minimize_Button);
            this.Controls.Add(this.X_Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.SaddleBrown;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_Button;
        private System.Windows.Forms.Label minimize_Button;
        private System.Windows.Forms.PictureBox PB_Ground;
        private System.Windows.Forms.PictureBox PB_Player;
        private System.Windows.Forms.Timer timer_Gravy;
        private System.Windows.Forms.Timer timer_up;
        private System.Windows.Forms.Timer timer_left;
        private System.Windows.Forms.Timer timer_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

