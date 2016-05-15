namespace MyAppSabre
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._btnCleanFolder = new System.Windows.Forms.Button();
            this._btnCopyFile = new System.Windows.Forms.Button();
            this._btnCompile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._txtPath = new System.Windows.Forms.TextBox();
            this._lblPath = new System.Windows.Forms.Label();
            this._lockPath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _btnCleanFolder
            // 
            this._btnCleanFolder.Location = new System.Drawing.Point(22, 94);
            this._btnCleanFolder.Name = "_btnCleanFolder";
            this._btnCleanFolder.Size = new System.Drawing.Size(75, 45);
            this._btnCleanFolder.TabIndex = 0;
            this._btnCleanFolder.Text = "Clean";
            this._btnCleanFolder.UseVisualStyleBackColor = true;
            this._btnCleanFolder.Click += new System.EventHandler(this._btnCleanFolder_Click);
            // 
            // _btnCopyFile
            // 
            this._btnCopyFile.Location = new System.Drawing.Point(210, 94);
            this._btnCopyFile.Name = "_btnCopyFile";
            this._btnCopyFile.Size = new System.Drawing.Size(75, 45);
            this._btnCopyFile.TabIndex = 1;
            this._btnCopyFile.Text = "Copy File";
            this._btnCopyFile.UseVisualStyleBackColor = true;
            // 
            // _btnCompile
            // 
            this._btnCompile.Location = new System.Drawing.Point(116, 94);
            this._btnCompile.Name = "_btnCompile";
            this._btnCompile.Size = new System.Drawing.Size(75, 45);
            this._btnCompile.TabIndex = 2;
            this._btnCompile.Text = "Compile";
            this._btnCompile.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // _txtPath
            // 
            this._txtPath.Location = new System.Drawing.Point(20, 54);
            this._txtPath.Name = "_txtPath";
            this._txtPath.Size = new System.Drawing.Size(363, 20);
            this._txtPath.TabIndex = 4;
            // 
            // _lblPath
            // 
            this._lblPath.AutoSize = true;
            this._lblPath.Location = new System.Drawing.Point(20, 35);
            this._lblPath.Name = "_lblPath";
            this._lblPath.Size = new System.Drawing.Size(29, 13);
            this._lblPath.TabIndex = 5;
            this._lblPath.Text = "Path";
            // 
            // _lockPath
            // 
            this._lockPath.AutoSize = true;
            this._lockPath.Location = new System.Drawing.Point(339, 35);
            this._lockPath.Name = "_lockPath";
            this._lockPath.Size = new System.Drawing.Size(50, 17);
            this._lockPath.TabIndex = 6;
            this._lockPath.Text = "Lock";
            this._lockPath.UseVisualStyleBackColor = true;
            this._lockPath.CheckedChanged += new System.EventHandler(this._lockPath_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(397, 152);
            this.Controls.Add(this._lockPath);
            this.Controls.Add(this._lblPath);
            this.Controls.Add(this._txtPath);
            this.Controls.Add(this.button4);
            this.Controls.Add(this._btnCompile);
            this.Controls.Add(this._btnCopyFile);
            this.Controls.Add(this._btnCleanFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MyAppSabre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnCleanFolder;
        private System.Windows.Forms.Button _btnCopyFile;
        private System.Windows.Forms.Button _btnCompile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox _txtPath;
        private System.Windows.Forms.Label _lblPath;
        private System.Windows.Forms.CheckBox _lockPath;
    }
}

