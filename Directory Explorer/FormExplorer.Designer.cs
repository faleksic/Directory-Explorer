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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplorer));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btFavorite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(171, 85);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(324, 26);
            this.tbPath.TabIndex = 0;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPath.ForeColor = System.Drawing.Color.Olive;
            this.lbPath.Location = new System.Drawing.Point(87, 78);
            this.lbPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(76, 36);
            this.lbPath.TabIndex = 2;
            this.lbPath.Text = "Path:";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(531, 78);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(114, 42);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lbLista
            // 
            this.lbLista.ForeColor = System.Drawing.Color.Olive;
            this.lbLista.FormattingEnabled = true;
            this.lbLista.HorizontalScrollbar = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(171, 172);
            this.lbLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbLista.Name = "lbLista";
            this.lbLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLista.Size = new System.Drawing.Size(324, 364);
            this.lbLista.TabIndex = 4;
            // 
            // btFavorite
            // 
            this.btFavorite.Location = new System.Drawing.Point(531, 178);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(114, 33);
            this.btFavorite.TabIndex = 5;
            this.btFavorite.Text = "Favorite";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // FormExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(687, 698);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btFavorite;
    }
}

