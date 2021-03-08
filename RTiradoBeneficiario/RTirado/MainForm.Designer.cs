/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 26/09/2019
 * Time: 4:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RTirado
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCarpetaOrigen;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCarpetaDestino;
		private System.Windows.Forms.TextBox txtCarpetaOrigen;
		private System.Windows.Forms.TextBox txtCarpetaDestino;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ListBox lstArchivosOrigen;
		private System.Windows.Forms.ListBox lstDestino;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem procesarToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCarpetaOrigen = new System.Windows.Forms.Button();
			this.txtCarpetaOrigen = new System.Windows.Forms.TextBox();
			this.lstArchivosOrigen = new System.Windows.Forms.ListBox();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCarpetaDestino = new System.Windows.Forms.Button();
			this.lstDestino = new System.Windows.Forms.ListBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.procesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(829, 461);
			this.splitContainer1.SplitterDistance = 412;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.lstArchivosOrigen);
			this.splitContainer2.Size = new System.Drawing.Size(412, 461);
			this.splitContainer2.SplitterDistance = 27;
			this.splitContainer2.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.62136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.37864F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCarpetaOrigen, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCarpetaOrigen, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 27);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Origen";
			// 
			// btnCarpetaOrigen
			// 
			this.btnCarpetaOrigen.Location = new System.Drawing.Point(364, 3);
			this.btnCarpetaOrigen.Name = "btnCarpetaOrigen";
			this.btnCarpetaOrigen.Size = new System.Drawing.Size(37, 21);
			this.btnCarpetaOrigen.TabIndex = 1;
			this.btnCarpetaOrigen.Text = "...";
			this.btnCarpetaOrigen.UseVisualStyleBackColor = true;
			this.btnCarpetaOrigen.Click += new System.EventHandler(this.BtnCarpetaOrigenClick);
			// 
			// txtCarpetaOrigen
			// 
			this.txtCarpetaOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCarpetaOrigen.Location = new System.Drawing.Point(48, 3);
			this.txtCarpetaOrigen.Name = "txtCarpetaOrigen";
			this.txtCarpetaOrigen.ReadOnly = true;
			this.txtCarpetaOrigen.Size = new System.Drawing.Size(310, 20);
			this.txtCarpetaOrigen.TabIndex = 2;
			// 
			// lstArchivosOrigen
			// 
			this.lstArchivosOrigen.ContextMenuStrip = this.contextMenuStrip1;
			this.lstArchivosOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstArchivosOrigen.FormattingEnabled = true;
			this.lstArchivosOrigen.Location = new System.Drawing.Point(0, 0);
			this.lstArchivosOrigen.Name = "lstArchivosOrigen";
			this.lstArchivosOrigen.Size = new System.Drawing.Size(412, 430);
			this.lstArchivosOrigen.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.lstDestino);
			this.splitContainer3.Size = new System.Drawing.Size(413, 461);
			this.splitContainer3.SplitterDistance = 28;
			this.splitContainer3.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.09214F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.90786F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.Controls.Add(this.txtCarpetaDestino, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCarpetaDestino, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 28);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// txtCarpetaDestino
			// 
			this.txtCarpetaDestino.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCarpetaDestino.Location = new System.Drawing.Point(54, 3);
			this.txtCarpetaDestino.Name = "txtCarpetaDestino";
			this.txtCarpetaDestino.ReadOnly = true;
			this.txtCarpetaDestino.Size = new System.Drawing.Size(305, 20);
			this.txtCarpetaDestino.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Destino";
			// 
			// btnCarpetaDestino
			// 
			this.btnCarpetaDestino.Location = new System.Drawing.Point(365, 3);
			this.btnCarpetaDestino.Name = "btnCarpetaDestino";
			this.btnCarpetaDestino.Size = new System.Drawing.Size(37, 22);
			this.btnCarpetaDestino.TabIndex = 1;
			this.btnCarpetaDestino.Text = "...";
			this.btnCarpetaDestino.UseVisualStyleBackColor = true;
			this.btnCarpetaDestino.Click += new System.EventHandler(this.BtnCarpetaDestinoClick);
			// 
			// lstDestino
			// 
			this.lstDestino.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstDestino.FormattingEnabled = true;
			this.lstDestino.Location = new System.Drawing.Point(0, 0);
			this.lstDestino.Name = "lstDestino";
			this.lstDestino.Size = new System.Drawing.Size(413, 429);
			this.lstDestino.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.procesarToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
			// 
			// procesarToolStripMenuItem
			// 
			this.procesarToolStripMenuItem.Name = "procesarToolStripMenuItem";
			this.procesarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.procesarToolStripMenuItem.Text = "Procesar";
			this.procesarToolStripMenuItem.Click += new System.EventHandler(this.ProcesarToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 461);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "RTirado";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
