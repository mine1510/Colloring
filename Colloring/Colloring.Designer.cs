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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colloring));
            this.panel1 = new System.Windows.Forms.Panel();
            this.papperPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.blueInt = new System.Windows.Forms.Label();
            this.greenInt = new System.Windows.Forms.Label();
            this.redInt = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.addRed = new System.Windows.Forms.Button();
            this.addGreen = new System.Windows.Forms.Button();
            this.addBlue = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.redHelp = new System.Windows.Forms.Label();
            this.greenHelp = new System.Windows.Forms.Label();
            this.blueHelp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Colloring.Properties.Resources.Wall;
            this.panel1.Controls.Add(this.blueHelp);
            this.panel1.Controls.Add(this.greenHelp);
            this.panel1.Controls.Add(this.redHelp);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.winLabel);
            this.panel1.Controls.Add(this.addBlue);
            this.panel1.Controls.Add(this.addGreen);
            this.panel1.Controls.Add(this.addRed);
            this.panel1.Controls.Add(this.papperPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 642);
            this.panel1.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(147, 423);
            this.panel2.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(13, 380);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(123, 40);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(13, 334);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(123, 40);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(14, 193);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(123, 100);
            this.colorPanel.TabIndex = 6;
            // 
            // blueInt
            // 
            this.blueInt.AutoSize = true;
            this.blueInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueInt.Location = new System.Drawing.Point(86, 132);
            this.blueInt.Name = "blueInt";
            this.blueInt.Size = new System.Drawing.Size(51, 26);
            this.blueInt.TabIndex = 5;
            this.blueInt.Text = "000";
            // 
            // greenInt
            // 
            this.greenInt.AutoSize = true;
            this.greenInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenInt.Location = new System.Drawing.Point(85, 79);
            this.greenInt.Name = "greenInt";
            this.greenInt.Size = new System.Drawing.Size(51, 26);
            this.greenInt.TabIndex = 4;
            this.greenInt.Text = "000";
            // 
            // redInt
            // 
            this.redInt.AutoSize = true;
            this.redInt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redInt.Location = new System.Drawing.Point(86, 29);
            this.redInt.Name = "redInt";
            this.redInt.Size = new System.Drawing.Size(51, 26);
            this.redInt.TabIndex = 3;
            this.redInt.Text = "000";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabel.Location = new System.Drawing.Point(8, 132);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(58, 26);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.Text = "Blue";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenLabel.Location = new System.Drawing.Point(8, 79);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(72, 26);
            this.greenLabel.TabIndex = 1;
            this.greenLabel.Text = "Green";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redLabel.Location = new System.Drawing.Point(8, 29);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(51, 26);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "Red";
            // 
            // addRed
            // 
            this.addRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRed.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRed.Location = new System.Drawing.Point(164, 41);
            this.addRed.Name = "addRed";
            this.addRed.Size = new System.Drawing.Size(27, 32);
            this.addRed.TabIndex = 2;
            this.addRed.Text = "+";
            this.addRed.UseVisualStyleBackColor = true;
            this.addRed.Click += new System.EventHandler(this.addRed_Click);
            // 
            // addGreen
            // 
            this.addGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGreen.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGreen.Location = new System.Drawing.Point(164, 91);
            this.addGreen.Name = "addGreen";
            this.addGreen.Size = new System.Drawing.Size(27, 31);
            this.addGreen.TabIndex = 3;
            this.addGreen.Text = "+";
            this.addGreen.UseVisualStyleBackColor = true;
            this.addGreen.Click += new System.EventHandler(this.addGreen_Click);
            // 
            // addBlue
            // 
            this.addBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBlue.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBlue.Location = new System.Drawing.Point(164, 141);
            this.addBlue.Name = "addBlue";
            this.addBlue.Size = new System.Drawing.Size(27, 32);
            this.addBlue.TabIndex = 4;
            this.addBlue.Text = "+";
            this.addBlue.UseVisualStyleBackColor = true;
            this.addBlue.Click += new System.EventHandler(this.addBlue_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.White;
            this.winLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winLabel.Location = new System.Drawing.Point(552, 64);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 44);
            this.winLabel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "HELP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redHelp
            // 
            this.redHelp.AutoSize = true;
            this.redHelp.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redHelp.Location = new System.Drawing.Point(12, 501);
            this.redHelp.Name = "redHelp";
            this.redHelp.Size = new System.Drawing.Size(0, 18);
            this.redHelp.TabIndex = 7;
            // 
            // greenHelp
            // 
            this.greenHelp.AutoSize = true;
            this.greenHelp.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenHelp.Location = new System.Drawing.Point(12, 529);
            this.greenHelp.Name = "greenHelp";
            this.greenHelp.Size = new System.Drawing.Size(0, 18);
            this.greenHelp.TabIndex = 8;
            // 
            // blueHelp
            // 
            this.blueHelp.AutoSize = true;
            this.blueHelp.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueHelp.Location = new System.Drawing.Point(12, 556);
            this.blueHelp.Name = "blueHelp";
            this.blueHelp.Size = new System.Drawing.Size(0, 18);
            this.blueHelp.TabIndex = 9;
            // 
            // Colloring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 642);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Colloring";
            this.Text = "Colloring";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button addBlue;
        private System.Windows.Forms.Button addGreen;
        private System.Windows.Forms.Button addRed;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label blueHelp;
        private System.Windows.Forms.Label greenHelp;
        private System.Windows.Forms.Label redHelp;
        private System.Windows.Forms.Button button1;
    }
}

