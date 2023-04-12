namespace MoveOrPass
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SourceButton = new Button();
            StartButton = new Button();
            folderSourceDialog = new FolderBrowserDialog();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            DestinationButton = new Button();
            folderDestinationDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 0;
            // 
            // SourceButton
            // 
            SourceButton.Location = new Point(326, 13);
            SourceButton.Name = "SourceButton";
            SourceButton.Size = new Size(75, 23);
            SourceButton.TabIndex = 1;
            SourceButton.Text = "Choose...";
            SourceButton.UseVisualStyleBackColor = true;
            SourceButton.Click += OpenSourceButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(497, 51);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Source";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Destination";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 23);
            textBox2.TabIndex = 5;
            // 
            // DestinationButton
            // 
            DestinationButton.Location = new Point(326, 52);
            DestinationButton.Name = "DestinationButton";
            DestinationButton.Size = new Size(75, 23);
            DestinationButton.TabIndex = 6;
            DestinationButton.Text = "Choose...";
            DestinationButton.UseVisualStyleBackColor = true;
            DestinationButton.Click += OpenDestinationButton_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 86);
            Controls.Add(DestinationButton);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Controls.Add(SourceButton);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Start";
            Text = "Move or Pass (Start)";
            FormClosed += Start_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button SourceButton;
        private Button StartButton;
        private FolderBrowserDialog folderSourceDialog;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button DestinationButton;
        private FolderBrowserDialog folderDestinationDialog;
    }
}