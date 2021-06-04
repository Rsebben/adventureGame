
namespace LostAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.Black;
            this.option1.FlatAppearance.BorderSize = 0;
            this.option1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.White;
            this.option1.Location = new System.Drawing.Point(133, 12);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(154, 39);
            this.option1.TabIndex = 0;
            this.option1.Text = "Option 1";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.Black;
            this.option2.FlatAppearance.BorderSize = 0;
            this.option2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.option2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.White;
            this.option2.Location = new System.Drawing.Point(604, 12);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(125, 39);
            this.option2.TabIndex = 1;
            this.option2.Text = "Option 2";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.option2_Click_1);
            // 
            // questionBox
            // 
            this.questionBox.BackColor = System.Drawing.Color.Transparent;
            this.questionBox.ForeColor = System.Drawing.Color.White;
            this.questionBox.Location = new System.Drawing.Point(268, 217);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(401, 185);
            this.questionBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::adventureGame.Properties.Resources._216d22c9accece715a20c4c3436e657d;
            this.ClientSize = new System.Drawing.Size(907, 606);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jumanji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Label questionBox;
    }
}

