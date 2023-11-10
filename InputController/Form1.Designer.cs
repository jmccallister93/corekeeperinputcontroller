namespace InputController
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
            this.btnOpenChrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenChrome
            // 
            this.btnOpenChrome.Location = new System.Drawing.Point(264, 283);
            this.btnOpenChrome.Name = "btnOpenChrome";
            this.btnOpenChrome.Size = new System.Drawing.Size(183, 65);
            this.btnOpenChrome.TabIndex = 0;
            this.btnOpenChrome.Text = "Open Core Keeper";
            this.btnOpenChrome.UseVisualStyleBackColor = true;
            this.btnOpenChrome.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenChrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenChrome;
    }
}

