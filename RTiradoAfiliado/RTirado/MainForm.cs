/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 26/09/2019
 * Time: 4:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace RTirado
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string extension = ".PDF";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ListAllFiles()
		{
			foreach (string path in Directory.EnumerateFiles(Directory.GetCurrentDirectory()))
	        {
				lstArchivosOrigen.Items.Add(path);
	        }
			
		}
		void CreateDirectoryAndCopyFile()
		{
			Directory.CreateDirectory(txtCarpetaDestino.Text);
			
			foreach (string fileName in lstArchivosOrigen.Items) {
				string result = Path.GetFileNameWithoutExtension(fileName);
				string result2 = Path.GetFileName(fileName);
				
				string newFolder = string.Format("{0}\\{1}",txtCarpetaDestino.Text , result);
				string e = Path.GetExtension(fileName);
				Directory.CreateDirectory(newFolder);
				lstDestino.Items.Add(newFolder);
				File.Copy(fileName,string.Format("{0}\\{1}", newFolder, result2), true);
			}
		}
		void BtnCarpetaOrigenClick(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				txtCarpetaOrigen.Text = folderBrowserDialog1.SelectedPath;
				txtCarpetaDestino.Text = folderBrowserDialog1.SelectedPath + "\\RESULTADO";
				Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
				//Debug.Print(Directory.GetCurrentDirectory());
				ListAllFiles();
				
			}
		}
		void BtnCarpetaDestinoClick(object sender, EventArgs e)
		{
			if(folderBrowserDialog2.ShowDialog() == DialogResult.OK)
			{
				txtCarpetaDestino.Text = folderBrowserDialog1.SelectedPath ;
			}
		}
		void ProcesarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Desea procesar los archivos", "PROCESAR ARCHIVOS", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				CreateDirectoryAndCopyFile();
			}
		}
	}
}
