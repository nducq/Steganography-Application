using System.Windows.Forms;

namespace SteganographyProject
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.decodeMessage = new System.Windows.Forms.Button();
            this.saveKeyButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oaepPadding = new System.Windows.Forms.CheckBox();
            this.encryptedOutputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createKeyButton = new System.Windows.Forms.Button();
            this.loadKeyButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createKeyPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeyPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageHashingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA512ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.26316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.73684F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.69675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.303249F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.decodeMessage);
            this.panel1.Controls.Add(this.saveKeyButton);
            this.panel1.Controls.Add(this.loadImageButton);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(237, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 29);
            this.panel1.TabIndex = 1;
            // 
            // decodeMessage
            // 
            this.decodeMessage.Location = new System.Drawing.Point(3, 0);
            this.decodeMessage.Name = "decodeMessage";
            this.decodeMessage.Size = new System.Drawing.Size(109, 29);
            this.decodeMessage.TabIndex = 3;
            this.decodeMessage.Text = "Decode Message";
            this.decodeMessage.UseVisualStyleBackColor = true;
            this.decodeMessage.Click += new System.EventHandler(this.decodeMessageButtonClick);
            // 
            // saveKeyButton
            // 
            this.saveKeyButton.Location = new System.Drawing.Point(298, 0);
            this.saveKeyButton.Name = "saveKeyButton";
            this.saveKeyButton.Size = new System.Drawing.Size(75, 29);
            this.saveKeyButton.TabIndex = 2;
            this.saveKeyButton.Text = "Save Key";
            this.saveKeyButton.UseVisualStyleBackColor = true;
            this.saveKeyButton.Click += new System.EventHandler(this.saveKeyClick);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(118, 0);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(75, 29);
            this.loadImageButton.TabIndex = 2;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButtonClick);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(379, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 29);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(460, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 29);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(237, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 345);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.oaepPadding);
            this.panel3.Controls.Add(this.encryptedOutputTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.outputTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.inputTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 372);
            this.panel3.TabIndex = 4;
            // 
            // oaepPadding
            // 
            this.oaepPadding.AutoSize = true;
            this.oaepPadding.Location = new System.Drawing.Point(4, 275);
            this.oaepPadding.Name = "oaepPadding";
            this.oaepPadding.Size = new System.Drawing.Size(97, 17);
            this.oaepPadding.TabIndex = 6;
            this.oaepPadding.Text = "OAEP Padding";
            this.oaepPadding.UseVisualStyleBackColor = true;
            // 
            // encryptedOutputTextBox
            // 
            this.encryptedOutputTextBox.Location = new System.Drawing.Point(4, 175);
            this.encryptedOutputTextBox.Multiline = true;
            this.encryptedOutputTextBox.Name = "encryptedOutputTextBox";
            this.encryptedOutputTextBox.ReadOnly = true;
            this.encryptedOutputTextBox.Size = new System.Drawing.Size(209, 93);
            this.encryptedOutputTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted Message:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(4, 63);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(209, 93);
            this.outputTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted Message:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(4, 23);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(209, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.createKeyButton);
            this.panel4.Controls.Add(this.loadKeyButton);
            this.panel4.Location = new System.Drawing.Point(3, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 29);
            this.panel4.TabIndex = 5;
            // 
            // createKeyButton
            // 
            this.createKeyButton.Location = new System.Drawing.Point(81, 0);
            this.createKeyButton.Name = "createKeyButton";
            this.createKeyButton.Size = new System.Drawing.Size(75, 29);
            this.createKeyButton.TabIndex = 1;
            this.createKeyButton.Text = "Create Key";
            this.createKeyButton.UseVisualStyleBackColor = true;
            this.createKeyButton.Click += new System.EventHandler(this.createKeyClick);
            // 
            // loadKeyButton
            // 
            this.loadKeyButton.Location = new System.Drawing.Point(6, 0);
            this.loadKeyButton.Name = "loadKeyButton";
            this.loadKeyButton.Size = new System.Drawing.Size(75, 29);
            this.loadKeyButton.TabIndex = 0;
            this.loadKeyButton.Text = "Load Key";
            this.loadKeyButton.UseVisualStyleBackColor = true;
            this.loadKeyButton.Click += new System.EventHandler(this.loadKeyClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.menuStrip1);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(773, 31);
            this.panel5.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPrivateKeyToolStripMenuItem,
            this.createKeyPairToolStripMenuItem,
            this.saveKeyPairToolStripMenuItem,
            this.exportPublicKeyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPrivateKeyToolStripMenuItem
            // 
            this.loadPrivateKeyToolStripMenuItem.Name = "loadPrivateKeyToolStripMenuItem";
            this.loadPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.loadPrivateKeyToolStripMenuItem.Text = "Load Key";
            this.loadPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.loadPrivateKeyToolStripMenuItem_Click);
            // 
            // createKeyPairToolStripMenuItem
            // 
            this.createKeyPairToolStripMenuItem.Name = "createKeyPairToolStripMenuItem";
            this.createKeyPairToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.createKeyPairToolStripMenuItem.Text = "Create Key Pair";
            this.createKeyPairToolStripMenuItem.Click += new System.EventHandler(this.createKeyPairToolStripMenuItem_Click);
            // 
            // saveKeyPairToolStripMenuItem
            // 
            this.saveKeyPairToolStripMenuItem.Name = "saveKeyPairToolStripMenuItem";
            this.saveKeyPairToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveKeyPairToolStripMenuItem.Text = "Export Private Key";
            this.saveKeyPairToolStripMenuItem.Click += new System.EventHandler(this.saveKeyPairToolStripMenuItem_Click);
            // 
            // exportPublicKeyToolStripMenuItem
            // 
            this.exportPublicKeyToolStripMenuItem.Name = "exportPublicKeyToolStripMenuItem";
            this.exportPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exportPublicKeyToolStripMenuItem.Text = "Export Public Key";
            this.exportPublicKeyToolStripMenuItem.Click += new System.EventHandler(this.exportPublicKeyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptionAlgorithmToolStripMenuItem,
            this.encodingAlgorithmToolStripMenuItem,
            this.messageHashingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.settingsToolStripMenuItem.Text = "Settings ";
            // 
            // encryptionAlgorithmToolStripMenuItem
            // 
            this.encryptionAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAToolStripMenuItem});
            this.encryptionAlgorithmToolStripMenuItem.Name = "encryptionAlgorithmToolStripMenuItem";
            this.encryptionAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.encryptionAlgorithmToolStripMenuItem.Text = "Encryption Algorithm";
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rSAToolStripMenuItem.Text = "Asymmetric RSA";
            // 
            // encodingAlgorithmToolStripMenuItem
            // 
            this.encodingAlgorithmToolStripMenuItem.Name = "encodingAlgorithmToolStripMenuItem";
            this.encodingAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.encodingAlgorithmToolStripMenuItem.Text = "Encoding Algorithm";
            // 
            // messageHashingToolStripMenuItem
            // 
            this.messageHashingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.mD5ToolStripMenuItem,
            this.sHA256ToolStripMenuItem,
            this.sHA512ToolStripMenuItem});
            this.messageHashingToolStripMenuItem.Name = "messageHashingToolStripMenuItem";
            this.messageHashingToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.messageHashingToolStripMenuItem.Text = "Message Hashing";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mD5ToolStripMenuItem.Text = "MD5";
            this.mD5ToolStripMenuItem.Click += new System.EventHandler(this.mD5ToolStripMenuItem_Click);
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sHA256ToolStripMenuItem.Text = "SHA 256";
            this.sHA256ToolStripMenuItem.Click += new System.EventHandler(this.sHA256ToolStripMenuItem_Click);
            // 
            // sHA512ToolStripMenuItem
            // 
            this.sHA512ToolStripMenuItem.Name = "sHA512ToolStripMenuItem";
            this.sHA512ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sHA512ToolStripMenuItem.Text = "SHA 512";
            this.sHA512ToolStripMenuItem.Click += new System.EventHandler(this.sHA512ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 451);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Panel panel2;
        private Panel panel3;
        private TextBox inputTextBox;
        private Label label1;
        private Panel panel4;
        private Button createKeyButton;
        private Button loadKeyButton;
        private TextBox outputTextBox;
        private Label label2;
        private TextBox encryptedOutputTextBox;
        private Label label3;
        private CheckBox oaepPadding;
        private Button saveKeyButton;
        private Panel panel5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadPrivateKeyToolStripMenuItem;
        private ToolStripMenuItem createKeyPairToolStripMenuItem;
        private ToolStripMenuItem saveKeyPairToolStripMenuItem;
        private ToolStripMenuItem exportPublicKeyToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button decodeMessage;
        private ToolStripMenuItem encryptionAlgorithmToolStripMenuItem;
        private ToolStripMenuItem rSAToolStripMenuItem;
        private ToolStripMenuItem encodingAlgorithmToolStripMenuItem;
        private ToolStripMenuItem messageHashingToolStripMenuItem;
        private ToolStripMenuItem noneToolStripMenuItem;
        private ToolStripMenuItem mD5ToolStripMenuItem;
        private ToolStripMenuItem sHA256ToolStripMenuItem;
        private ToolStripMenuItem sHA512ToolStripMenuItem;
    }
}

