namespace Directory_Explorer
{
    partial class FormExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplorer));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbPath = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(114, 55);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(217, 20);
            this.tbPath.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPath.ForeColor = System.Drawing.Color.Olive;
            this.lbPath.Location = new System.Drawing.Point(58, 51);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(50, 23);
            this.lbPath.TabIndex = 2;
            this.lbPath.Text = "Path:";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(354, 51);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(76, 27);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lbLista
            // 
            this.lbLista.ForeColor = System.Drawing.Color.Olive;
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(114, 112);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(217, 238);
            this.lbLista.TabIndex = 4;
            // 
            // FormExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(458, 454);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.ListBox lbLista;
    }
}

