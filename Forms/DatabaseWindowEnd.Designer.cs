﻿namespace LinuxMTAInstaller.Forms {
	partial class DatabaseWindowEnd {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( ) {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseWindowEnd));
			this.label1 = new System.Windows.Forms.Label();
			this.mainmenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 120);
			this.label1.TabIndex = 0;
			this.label1.Text = Languages.GetLang ( "database_installed_form" );
			// 
			// mainmenu
			// 
			this.mainmenu.Location = new System.Drawing.Point(106, 150);
			this.mainmenu.Name = "mainmenu";
			this.mainmenu.Size = new System.Drawing.Size(82, 28);
			this.mainmenu.TabIndex = 1;
			this.mainmenu.Text = "Back";
			this.mainmenu.UseVisualStyleBackColor = true;
			this.mainmenu.Click += new System.EventHandler(this.mainmenu_Click);
			// 
			// DatabaseWindowEnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 190);
			this.Controls.Add(this.mainmenu);
			this.Controls.Add(this.label1);
			this.Name = "DatabaseWindowEnd";
			this.Text = "Datenbank end";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button mainmenu;
	}
}