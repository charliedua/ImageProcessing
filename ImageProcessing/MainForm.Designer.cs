namespace ImageProcessing
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
            this.PicOriginal = new System.Windows.Forms.PictureBox();
            this.PicLater = new System.Windows.Forms.PictureBox();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnTransform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLater)).BeginInit();
            this.SuspendLayout();
            // 
            // PicOriginal
            // 
            this.PicOriginal.Location = new System.Drawing.Point(24, 25);
            this.PicOriginal.Name = "PicOriginal";
            this.PicOriginal.Size = new System.Drawing.Size(311, 291);
            this.PicOriginal.TabIndex = 0;
            this.PicOriginal.TabStop = false;
            // 
            // PicLater
            // 
            this.PicLater.Location = new System.Drawing.Point(458, 25);
            this.PicLater.Name = "PicLater";
            this.PicLater.Size = new System.Drawing.Size(311, 291);
            this.PicLater.TabIndex = 1;
            this.PicLater.TabStop = false;
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(105, 349);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(125, 57);
            this.BtnImport.TabIndex = 2;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnTransform
            // 
            this.BtnTransform.Location = new System.Drawing.Point(557, 349);
            this.BtnTransform.Name = "BtnTransform";
            this.BtnTransform.Size = new System.Drawing.Size(125, 57);
            this.BtnTransform.TabIndex = 3;
            this.BtnTransform.Text = "Transform";
            this.BtnTransform.UseVisualStyleBackColor = true;
            this.BtnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTransform);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.PicLater);
            this.Controls.Add(this.PicOriginal);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicOriginal;
        private System.Windows.Forms.PictureBox PicLater;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnTransform;
    }
}

