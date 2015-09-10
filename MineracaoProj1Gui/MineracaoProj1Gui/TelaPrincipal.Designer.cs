namespace MineracaoProj1Gui
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.search = new System.Windows.Forms.TextBox();
            this.bn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // listViewResult
            // 
            this.listViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listViewResult.Location = new System.Drawing.Point(0, 49);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(779, 309);
            this.listViewResult.TabIndex = 1;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(176, 16);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(436, 20);
            this.search.TabIndex = 2;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // bn_search
            // 
            this.bn_search.BackColor = System.Drawing.Color.White;
            this.bn_search.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.bn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_search.Location = new System.Drawing.Point(627, 12);
            this.bn_search.Name = "bn_search";
            this.bn_search.Size = new System.Drawing.Size(64, 28);
            this.bn_search.TabIndex = 3;
            this.bn_search.Text = "Buscar";
            this.bn_search.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 358);
            this.Controls.Add(this.bn_search);
            this.Controls.Add(this.search);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button bn_search;
    }
}

