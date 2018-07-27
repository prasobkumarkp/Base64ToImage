namespace Base64ToImage
{
	partial class formMain
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnClearImage = new System.Windows.Forms.Button();
			this.pbOut = new System.Windows.Forms.PictureBox();
			this.btnConvertBase64ToImage = new System.Windows.Forms.Button();
			this.btnClearText = new System.Windows.Forms.Button();
			this.btnConvertImageToBase64 = new System.Windows.Forms.Button();
			this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
			this.btnBrowseFile = new System.Windows.Forms.Button();
			this.txtFileUrl = new System.Windows.Forms.TextBox();
			this.pnlConatiner = new System.Windows.Forms.Panel();
			this.btnImageNormal = new System.Windows.Forms.Button();
			this.btnImageStretch = new System.Windows.Forms.Button();
			this.btnImageCenter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbOut)).BeginInit();
			this.pnlConatiner.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInput.Location = new System.Drawing.Point(512, 12);
			this.txtInput.MaxLength = 1000000;
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(335, 495);
			this.txtInput.TabIndex = 0;
			this.txtInput.TextChanged += new System.EventHandler(this.txtInput_Changed);
			// 
			// btnClearImage
			// 
			this.btnClearImage.Location = new System.Drawing.Point(25, 38);
			this.btnClearImage.Name = "btnClearImage";
			this.btnClearImage.Size = new System.Drawing.Size(270, 23);
			this.btnClearImage.TabIndex = 1;
			this.btnClearImage.Text = "Clear";
			this.btnClearImage.UseVisualStyleBackColor = true;
			this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
			// 
			// pbOut
			// 
			this.pbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbOut.Location = new System.Drawing.Point(9, 12);
			this.pbOut.Name = "pbOut";
			this.pbOut.Size = new System.Drawing.Size(493, 495);
			this.pbOut.TabIndex = 2;
			this.pbOut.TabStop = false;
			this.pbOut.WaitOnLoad = true;
			this.pbOut.BackgroundImageChanged += new System.EventHandler(this.pbOut_BackgroundImageChanged);
			// 
			// btnConvertBase64ToImage
			// 
			this.btnConvertBase64ToImage.Location = new System.Drawing.Point(313, 9);
			this.btnConvertBase64ToImage.Name = "btnConvertBase64ToImage";
			this.btnConvertBase64ToImage.Size = new System.Drawing.Size(215, 23);
			this.btnConvertBase64ToImage.TabIndex = 3;
			this.btnConvertBase64ToImage.Text = "Convert to image";
			this.btnConvertBase64ToImage.UseVisualStyleBackColor = true;
			this.btnConvertBase64ToImage.Click += new System.EventHandler(this.btnConvertBase64ToImage_Click);
			// 
			// btnClearText
			// 
			this.btnClearText.Location = new System.Drawing.Point(546, 9);
			this.btnClearText.Name = "btnClearText";
			this.btnClearText.Size = new System.Drawing.Size(266, 23);
			this.btnClearText.TabIndex = 4;
			this.btnClearText.Text = "Clear";
			this.btnClearText.UseVisualStyleBackColor = true;
			this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
			// 
			// btnConvertImageToBase64
			// 
			this.btnConvertImageToBase64.Location = new System.Drawing.Point(313, 38);
			this.btnConvertImageToBase64.Name = "btnConvertImageToBase64";
			this.btnConvertImageToBase64.Size = new System.Drawing.Size(215, 23);
			this.btnConvertImageToBase64.TabIndex = 5;
			this.btnConvertImageToBase64.Text = "Convert to base64";
			this.btnConvertImageToBase64.UseVisualStyleBackColor = true;
			this.btnConvertImageToBase64.Click += new System.EventHandler(this.btnConvertImageToBase64_Click);
			// 
			// FileBrowser
			// 
			this.FileBrowser.FileName = "ofdInputImage";
			// 
			// btnBrowseFile
			// 
			this.btnBrowseFile.Location = new System.Drawing.Point(220, 10);
			this.btnBrowseFile.Name = "btnBrowseFile";
			this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseFile.TabIndex = 6;
			this.btnBrowseFile.Text = "Browse";
			this.btnBrowseFile.UseVisualStyleBackColor = true;
			this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
			// 
			// txtFileUrl
			// 
			this.txtFileUrl.Location = new System.Drawing.Point(25, 11);
			this.txtFileUrl.Name = "txtFileUrl";
			this.txtFileUrl.Size = new System.Drawing.Size(189, 20);
			this.txtFileUrl.TabIndex = 7;
			// 
			// pnlConatiner
			// 
			this.pnlConatiner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlConatiner.Controls.Add(this.btnImageNormal);
			this.pnlConatiner.Controls.Add(this.btnImageStretch);
			this.pnlConatiner.Controls.Add(this.btnImageCenter);
			this.pnlConatiner.Controls.Add(this.btnBrowseFile);
			this.pnlConatiner.Controls.Add(this.btnClearText);
			this.pnlConatiner.Controls.Add(this.btnClearImage);
			this.pnlConatiner.Controls.Add(this.btnConvertImageToBase64);
			this.pnlConatiner.Controls.Add(this.btnConvertBase64ToImage);
			this.pnlConatiner.Controls.Add(this.txtFileUrl);
			this.pnlConatiner.Location = new System.Drawing.Point(12, 519);
			this.pnlConatiner.Name = "pnlConatiner";
			this.pnlConatiner.Size = new System.Drawing.Size(835, 72);
			this.pnlConatiner.TabIndex = 8;
			this.pnlConatiner.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnImageNormal
			// 
			this.btnImageNormal.Location = new System.Drawing.Point(546, 38);
			this.btnImageNormal.Name = "btnImageNormal";
			this.btnImageNormal.Size = new System.Drawing.Size(75, 23);
			this.btnImageNormal.TabIndex = 10;
			this.btnImageNormal.Text = "Normal";
			this.btnImageNormal.UseVisualStyleBackColor = true;
			this.btnImageNormal.Click += new System.EventHandler(this.btnImageNormal_Click);
			// 
			// btnImageStretch
			// 
			this.btnImageStretch.Location = new System.Drawing.Point(737, 38);
			this.btnImageStretch.Name = "btnImageStretch";
			this.btnImageStretch.Size = new System.Drawing.Size(75, 23);
			this.btnImageStretch.TabIndex = 9;
			this.btnImageStretch.Text = "Stretch";
			this.btnImageStretch.UseVisualStyleBackColor = true;
			this.btnImageStretch.Click += new System.EventHandler(this.btnImageStretch_Click);
			// 
			// btnImageCenter
			// 
			this.btnImageCenter.Location = new System.Drawing.Point(647, 38);
			this.btnImageCenter.Name = "btnImageCenter";
			this.btnImageCenter.Size = new System.Drawing.Size(75, 23);
			this.btnImageCenter.TabIndex = 8;
			this.btnImageCenter.Text = "Center";
			this.btnImageCenter.UseVisualStyleBackColor = true;
			this.btnImageCenter.Click += new System.EventHandler(this.btnImageCenter_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 603);
			this.Controls.Add(this.pnlConatiner);
			this.Controls.Add(this.pbOut);
			this.Controls.Add(this.txtInput);
			this.Name = "formMain";
			this.Text = "Base64 to image converter";
			this.Load += new System.EventHandler(this.formMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbOut)).EndInit();
			this.pnlConatiner.ResumeLayout(false);
			this.pnlConatiner.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnClearImage;
		private System.Windows.Forms.PictureBox pbOut;
		private System.Windows.Forms.Button btnConvertBase64ToImage;
		private System.Windows.Forms.Button btnClearText;
		private System.Windows.Forms.Button btnConvertImageToBase64;
		private System.Windows.Forms.OpenFileDialog FileBrowser;
		private System.Windows.Forms.Button btnBrowseFile;
		private System.Windows.Forms.TextBox txtFileUrl;
		private System.Windows.Forms.Panel pnlConatiner;
		private System.Windows.Forms.Button btnImageNormal;
		private System.Windows.Forms.Button btnImageStretch;
		private System.Windows.Forms.Button btnImageCenter;
	}
}

