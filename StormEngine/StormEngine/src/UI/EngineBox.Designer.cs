
namespace StormEngine.src.UI
{
    partial class EngineBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLabel = new System.Windows.Forms.Label();
            this.txtLabel2 = new System.Windows.Forms.Label();
            this.unleashedRoundButton1 = new UnleashUIFramework.Source.Buttons.UnleashedRoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.unleashedRoundButton1);
            this.panel1.Controls.Add(this.txtLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 40);
            this.panel1.TabIndex = 0;
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.ForeColor = System.Drawing.Color.White;
            this.txtLabel.Location = new System.Drawing.Point(3, 9);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(56, 30);
            this.txtLabel.TabIndex = 0;
            this.txtLabel.Text = "Title";
            // 
            // txtLabel2
            // 
            this.txtLabel2.AutoSize = true;
            this.txtLabel2.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.txtLabel2.ForeColor = System.Drawing.Color.White;
            this.txtLabel2.Location = new System.Drawing.Point(4, 53);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(70, 20);
            this.txtLabel2.TabIndex = 1;
            this.txtLabel2.Text = "Message";
            // 
            // unleashedRoundButton1
            // 
            this.unleashedRoundButton1.BorderColor = System.Drawing.Color.Silver;
            this.unleashedRoundButton1.ButtonColor = System.Drawing.Color.Red;
            this.unleashedRoundButton1.ForeColor = System.Drawing.Color.White;
            this.unleashedRoundButton1.Location = new System.Drawing.Point(416, 0);
            this.unleashedRoundButton1.Name = "unleashedRoundButton1";
            this.unleashedRoundButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.unleashedRoundButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.unleashedRoundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.unleashedRoundButton1.Size = new System.Drawing.Size(18, 21);
            this.unleashedRoundButton1.TabIndex = 1;
            this.unleashedRoundButton1.Text = "X";
            this.unleashedRoundButton1.TextColor = System.Drawing.Color.White;
            this.unleashedRoundButton1.UseVisualStyleBackColor = true;
            this.unleashedRoundButton1.Click += new System.EventHandler(this.unleashedRoundButton1_Click);
            // 
            // EngineBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(437, 143);
            this.Controls.Add(this.txtLabel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EngineBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Label txtLabel2;
        private UnleashUIFramework.Source.Buttons.UnleashedRoundButton unleashedRoundButton1;
    }
}