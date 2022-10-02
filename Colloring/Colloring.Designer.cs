namespace Colloring
{
    partial class Colloring
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.RedInt = new System.Windows.Forms.Label();
            this.GreenInt = new System.Windows.Forms.Label();
            this.BlueInt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Colloring.Properties.Resources.Wall;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 642);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BlueInt);
            this.panel2.Controls.Add(this.GreenInt);
            this.panel2.Controls.Add(this.RedInt);
            this.panel2.Controls.Add(this.BlueLabel);
            this.panel2.Controls.Add(this.GreenLabel);
            this.panel2.Controls.Add(this.RedLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 262);
            this.panel2.TabIndex = 0;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedLabel.Location = new System.Drawing.Point(8, 23);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(51, 26);
            this.RedLabel.TabIndex = 0;
            this.RedLabel.Text = "Red";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenLabel.Location = new System.Drawing.Point(8, 60);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(72, 26);
            this.GreenLabel.TabIndex = 1;
            this.GreenLabel.Text = "Green";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueLabel.Location = new System.Drawing.Point(8, 97);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(58, 26);
            this.BlueLabel.TabIndex = 2;
            this.BlueLabel.Text = "Blue";
            // 
            // RedInt
            // 
            this.RedInt.AutoSize = true;
            this.RedInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedInt.Location = new System.Drawing.Point(86, 23);
            this.RedInt.Name = "RedInt";
            this.RedInt.Size = new System.Drawing.Size(51, 26);
            this.RedInt.TabIndex = 3;
            this.RedInt.Text = "000";
            // 
            // GreenInt
            // 
            this.GreenInt.AutoSize = true;
            this.GreenInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenInt.Location = new System.Drawing.Point(86, 60);
            this.GreenInt.Name = "GreenInt";
            this.GreenInt.Size = new System.Drawing.Size(51, 26);
            this.GreenInt.TabIndex = 4;
            this.GreenInt.Text = "000";
            // 
            // BlueInt
            // 
            this.BlueInt.AutoSize = true;
            this.BlueInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueInt.Location = new System.Drawing.Point(86, 97);
            this.BlueInt.Name = "BlueInt";
            this.BlueInt.Size = new System.Drawing.Size(51, 26);
            this.BlueInt.TabIndex = 5;
            this.BlueInt.Text = "000";
            // 
            // Colloring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 642);
            this.Controls.Add(this.panel1);
            this.Name = "Colloring";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label BlueInt;
        private System.Windows.Forms.Label GreenInt;
        private System.Windows.Forms.Label RedInt;
    }
}

