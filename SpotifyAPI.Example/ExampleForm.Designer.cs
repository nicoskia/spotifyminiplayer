namespace SpotifyAPI.Example
{
    partial class ExampleForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExampleForm));
            this.localControl1 = new SpotifyAPI.Example.LocalControl();
            this.SuspendLayout();
            // 
            // localControl1
            // 
            this.localControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.localControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localControl1.Location = new System.Drawing.Point(0, 0);
            this.localControl1.Margin = new System.Windows.Forms.Padding(5);
            this.localControl1.Name = "localControl1";
            this.localControl1.Size = new System.Drawing.Size(240, 106);
            this.localControl1.TabIndex = 1;
            this.localControl1.Load += new System.EventHandler(this.localControl1_Load);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(240, 106);
            this.Controls.Add(this.localControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExampleForm";
            this.Text = "SpoitfyAPI .NET Example";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExampleForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExampleForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExampleForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private LocalControl localControl1;
    }
}

