using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyFileManager
{
	public partial class AttributeForm : Form
	{
		public AttributeForm(string filePath)
		{
			InitializeComponent();


			// Zainicjuj interfejs
			InitDisplay(filePath);
		}


		//Zamknij okno
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			this.Close();
		}








		//Zainicjuj interfejs
		private void InitDisplay(string filePath)
		{
			//Jeśli filePath jest ścieżką do pliku
			if (File.Exists(filePath))
			{
				FileInfo fileInfo = new FileInfo(filePath);

				txtFileName.Text = fileInfo.Name;
				txtFileType.Text = fileInfo.Extension;
				txtFileLocation.Text = (fileInfo.DirectoryName != null) ? fileInfo.DirectoryName : null;
				txtFileSize.Text = ShowFileSize(fileInfo.Length);
				txtFileCreateTime.Text = fileInfo.CreationTime.ToString();
				txtFileModifyTime.Text = fileInfo.LastWriteTime.ToString();
				txtFileAccessTime.Text = fileInfo.LastAccessTime.ToString();
			}
			//Jeśli filePath jest ścieżką do folderu
			else if (Directory.Exists(filePath))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

				txtFileName.Text = directoryInfo.Name;
				txtFileType.Text = "文件夹";
				txtFileLocation.Text = (directoryInfo.Parent != null) ? directoryInfo.Parent.FullName : null;
				txtFileSize.Text = ShowFileSize(GetDirectoryLength(filePath));
				txtFileCreateTime.Text = directoryInfo.CreationTime.ToString();
				txtFileModifyTime.Text = directoryInfo.LastWriteTime.ToString();
				txtFileAccessTime.Text = directoryInfo.LastAccessTime.ToString();
			}
		}


		//Uzyskaj rozmiar katalogu
		private long GetDirectoryLength(string dirPath)
		{
			long length = 0;
			DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);

		
			//Uzyskaj rozmiar wszystkich plików w katalogu
			FileInfo[] fileInfos = directoryInfo.GetFiles();
			if (fileInfos.Length > 0)
			{
				foreach (FileInfo fileInfo in fileInfos)
				{
					length += fileInfo.Length;
				}
			}


			//Rekurencyjnie pobierz rozmiar wszystkich folderów w katalogu
			DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
			if(directoryInfos.Length > 0)
			{
				foreach(DirectoryInfo dirInfo in directoryInfos)
				{
					length += GetDirectoryLength(dirInfo.FullName);
				}
			}

			return length;
		}


		//Wyświetla rozmiar pliku w określonym formacie
		//Math.Round(num,2,MidpointRounding.AwayFromZero)，中国式的四舍五入，num保留2位小数
		public static string ShowFileSize(long fileSize)
		{
			string fileSizeStr = "";

			if (fileSize < 1024)
			{
				fileSizeStr = fileSize + " bajt";
			}
			else if (fileSize >= 1024 && fileSize < 1024 * 1024)
			{
				fileSizeStr = Math.Round(fileSize * 1.0 / 1024, 2, MidpointRounding.AwayFromZero) + " KB(" + fileSize + "bajt)";
			}
			else if (fileSize >= 1024 * 1024 && fileSize < 1024 * 1024 * 1024)
			{
				fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024), 2, MidpointRounding.AwayFromZero) + " MB(" + fileSize + "bajt)";
			}
			else if (fileSize >= 1024 * 1024 * 1024)
			{
				fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024 * 1024), 2, MidpointRounding.AwayFromZero) + " GB(" + fileSize + "bajt)";
			}

			return fileSizeStr;
		}
		
		private void AttributeForm_Load(object sender, EventArgs e)
		{

		}
	}
}
