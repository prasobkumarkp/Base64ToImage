using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Base64ToImage
{
	public partial class formMain : Form
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();

		public formMain()
		{
			InitializeComponent();
			openFileDialog.FileOk += OpenFileDialog_FileOk;
			ValidateControls();
			txtInput.ScrollBars = ScrollBars.Vertical;
		}


		private void formMain_Load(object sender, EventArgs e)
		{

		}

		private void btnClearImage_Click(object sender, EventArgs e)
		{
			pbOut.Image = null;
		}

		private void btnClearText_Click(object sender, EventArgs e)
		{
			txtInput.Clear();
		}

		private void txtInput_Changed(object sender, EventArgs e)
		{
			ValidateControls();
		}

		private void ValidateControls()
		{
			if (string.IsNullOrEmpty(txtInput.Text))
			{
				btnConvertBase64ToImage.Enabled = false;
			}
			else
			{
				btnConvertBase64ToImage.Enabled = true;
			}

			if (string.IsNullOrEmpty(txtFileUrl.Text))
			{
				btnConvertImageToBase64.Enabled = false;
			}
			else {
				btnConvertImageToBase64.Enabled = true;
			}
		}

		private void ValidatePbOut()
		{
			if (pbOut.Image == null)
			{
				btnConvertImageToBase64.Enabled = false;
			}
		}

		private void btnConvertBase64ToImage_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				if (!String.IsNullOrEmpty(txtInput.Text))
				{
					byte[] bytes = Convert.FromBase64String(txtInput.Text);
					using (MemoryStream ms = new MemoryStream(bytes))
					{
						pbOut.Image = Image.FromStream(ms);
					}
				}
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnConvertImageToBase64_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			var text = btnConvertImageToBase64.Text;
			btnConvertImageToBase64.Text = "...";
			var bytes = File.ReadAllBytes(openFileDialog.FileName);
			txtInput.Text = Convert.ToBase64String(bytes);
			btnConvertImageToBase64.Text = text;
			Cursor.Current = Cursors.Default;
		}

		private void btnBrowseFile_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
			openFileDialog.RestoreDirectory = true;
			openFileDialog.InitialDirectory = @"c:\Downloads\";
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			txtFileUrl.Text = openFileDialog.FileName;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FitImageToScreen(ImageStyle imageStyle )
		{
			switch (imageStyle)
			{
				case ImageStyle.Normal:
					pbOut.SizeMode = PictureBoxSizeMode.Normal;
					break;
				case ImageStyle.Center:
					pbOut.SizeMode = PictureBoxSizeMode.CenterImage;
					break;
				case ImageStyle.Stretch:
					pbOut.SizeMode = PictureBoxSizeMode.StretchImage;
					break;
				default:
					break;
			}
			
		}


		private void btnImageNormal_Click(object sender, EventArgs e)
		{
			FitImageToScreen(ImageStyle.Normal);
		}

		private void btnImageCenter_Click(object sender, EventArgs e)
		{
			FitImageToScreen(ImageStyle.Center);
		}

		private void btnImageStretch_Click(object sender, EventArgs e)
		{
			FitImageToScreen(ImageStyle.Stretch);
		}

		private void pbOut_BackgroundImageChanged(object sender, EventArgs e)
		{
			ValidateControls();
		}

		private void txtFileUrl_TextChanged(object sender, EventArgs e)
		{
			ValidateControls();
		}
	}

	enum ImageStyle {
		Normal,
		Center,
		Stretch
	}
}
