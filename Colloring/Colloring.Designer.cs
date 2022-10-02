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
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redInt = new System.Windows.Forms.Label();
            this.greenInt = new System.Windows.Forms.Label();
            this.blueInt = new System.Windows.Forms.Label();
            this.papperPanel = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.changeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Colloring.Properties.Resources.Wall;
            this.panel1.Controls.Add(this.papperPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 642);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.changeButton);
            this.panel2.Controls.Add(this.colorPanel);
            this.panel2.Controls.Add(this.blueInt);
            this.panel2.Controls.Add(this.greenInt);
            this.panel2.Controls.Add(this.redInt);
            this.panel2.Controls.Add(this.blueLabel);
            this.panel2.Controls.Add(this.greenLabel);
            this.panel2.Controls.Add(this.redLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 362);
            this.panel2.TabIndex = 0;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redLabel.Location = new System.Drawing.Point(8, 23);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(51, 26);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenLabel.Location = new System.Drawing.Point(8, 60);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(72, 26);
            this.greenLabel.TabIndex = 1;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabel.Location = new System.Drawing.Point(8, 97);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(58, 26);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.Text = "Blue";
            // 
            // redInt
            // 
            this.redInt.AutoSize = true;
            this.redInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redInt.Location = new System.Drawing.Point(86, 23);
            this.redInt.Name = "redInt";
            this.redInt.Size = new System.Drawing.Size(51, 26);
            this.redInt.TabIndex = 3;
            this.redInt.Text = "000";
            // 
            // greenInt
            // 
            this.greenInt.AutoSize = true;
            this.greenInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenInt.Location = new System.Drawing.Point(86, 60);
            this.greenInt.Name = "greenInt";
            this.greenInt.Size = new System.Drawing.Size(51, 26);
            this.greenInt.TabIndex = 4;
            this.greenInt.Text = "000";
            // 
            // blueInt
            // 
            this.blueInt.AutoSize = true;
            this.blueInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueInt.Location = new System.Drawing.Point(86, 97);
            this.blueInt.Name = "blueInt";
            this.blueInt.Size = new System.Drawing.Size(51, 26);
            this.blueInt.TabIndex = 5;
            this.blueInt.Text = "000";
            // 
            // papperPanel
            // 
            this.papperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.papperPanel.BackColor = System.Drawing.Color.White;
            this.papperPanel.Location = new System.Drawing.Point(410, 138);
            this.papperPanel.MinimumSize = new System.Drawing.Size(200, 150);
            this.papperPanel.Name = "papperPanel";
            this.papperPanel.Size = new System.Drawing.Size(400, 350);
            this.papperPanel.TabIndex = 1;
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(13, 141);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(123, 100);
            this.colorPanel.TabIndex = 6;
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(13, 262);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(123, 40);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(13, 308);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(123, 40);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // Colloring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 642);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
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
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueInt;
        private System.Windows.Forms.Label greenInt;
        private System.Windows.Forms.Label redInt;
        private System.Windows.Forms.Panel papperPanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button resetButton;
    }
}

