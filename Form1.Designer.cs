namespace WeAreDevs_API
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtScript = new RichTextBox();
            btnExecute = new Button();
            labelStatus = new Label();
            timerAttachChecker = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            Clear = new Button();
            OpenFile = new Button();
            SaveFile = new Button();
            ScriptHub = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtScript
            // 
            txtScript.BackColor = Color.FromArgb(35, 35, 35);
            txtScript.ForeColor = Color.White;
            txtScript.Location = new Point(11, 52);
            txtScript.Margin = new Padding(2);
            txtScript.Name = "txtScript";
            txtScript.Size = new Size(700, 235);
            txtScript.TabIndex = 0;
            txtScript.Text = "print(\"Hello, World!\")";
            // 
            // btnExecute
            // 
            btnExecute.FlatStyle = FlatStyle.Popup;
            btnExecute.ForeColor = Color.White;
            btnExecute.Image = Properties.Resources._232323;
            btnExecute.Location = new Point(629, 15);
            btnExecute.Margin = new Padding(2);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(78, 25);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(66, 20);
            labelStatus.Margin = new Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(70, 14);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status: null";
            labelStatus.Click += labelStatus_Click;
            // 
            // timerAttachChecker
            // 
            timerAttachChecker.Enabled = true;
            timerAttachChecker.Tick += timerAttachChecker_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.King_Executer_icon;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Clear
            // 
            Clear.FlatStyle = FlatStyle.Popup;
            Clear.ForeColor = Color.White;
            Clear.Image = Properties.Resources._232323;
            Clear.Location = new Point(549, 15);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 25);
            Clear.TabIndex = 4;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // OpenFile
            // 
            OpenFile.FlatStyle = FlatStyle.Popup;
            OpenFile.ForeColor = Color.White;
            OpenFile.Image = Properties.Resources._232323;
            OpenFile.Location = new Point(468, 15);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(75, 25);
            OpenFile.TabIndex = 5;
            OpenFile.Text = "Open File";
            OpenFile.UseVisualStyleBackColor = true;
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.FlatStyle = FlatStyle.Popup;
            SaveFile.ForeColor = Color.White;
            SaveFile.Image = Properties.Resources._232323;
            SaveFile.Location = new Point(387, 15);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(75, 25);
            SaveFile.TabIndex = 6;
            SaveFile.Text = "Save File";
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += SaveFile_Click;
            // 
            // ScriptHub
            // 
            ScriptHub.FlatStyle = FlatStyle.Popup;
            ScriptHub.ForeColor = Color.White;
            ScriptHub.Image = Properties.Resources._232323;
            ScriptHub.Location = new Point(306, 15);
            ScriptHub.Name = "ScriptHub";
            ScriptHub.Size = new Size(75, 25);
            ScriptHub.TabIndex = 7;
            ScriptHub.Text = "Script Hub";
            ScriptHub.UseVisualStyleBackColor = true;
            ScriptHub.Click += ScriptHub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(718, 294);
            Controls.Add(ScriptHub);
            Controls.Add(SaveFile);
            Controls.Add(OpenFile);
            Controls.Add(Clear);
            Controls.Add(pictureBox1);
            Controls.Add(labelStatus);
            Controls.Add(btnExecute);
            Controls.Add(txtScript);
            Font = new Font("Simona Pro Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "King Executer v1.1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtScript;
        private Button btnExecute;
        private Button btnAttach;
        private Label labelStatus;
        private System.Windows.Forms.Timer timerAttachChecker;
        private PictureBox pictureBox1;
        private Button Clear;
        private Button OpenFile;
        private Button SaveFile;
        private Button ScriptHub;
    }
}
