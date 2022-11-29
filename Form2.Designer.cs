namespace WindowsFormsApp9
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
            this.figuri_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // figuri_Button
            // 
            this.figuri_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figuri_Button.BackgroundImage")));
            this.figuri_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.figuri_Button.Location = new System.Drawing.Point(13, 13);
            this.figuri_Button.Name = "figuri_Button";
            this.figuri_Button.Size = new System.Drawing.Size(93, 47);
            this.figuri_Button.TabIndex = 0;
            this.figuri_Button.Text = "Figuri";
            this.figuri_Button.UseVisualStyleBackColor = true;
            this.figuri_Button.Click += new System.EventHandler(this.figuri_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 593);
            this.Controls.Add(this.figuri_Button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button figuri_Button;
    }
}