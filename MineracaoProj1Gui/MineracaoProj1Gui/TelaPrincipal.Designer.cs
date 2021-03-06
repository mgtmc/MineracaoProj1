﻿namespace MineracaoProj1Gui
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
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.bn_search = new System.Windows.Forms.Button();
            this.dropdownlist = new System.Windows.Forms.ComboBox();
            this.labelResults = new System.Windows.Forms.Label();
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
            this.listViewResult.BackColor = System.Drawing.SystemColors.Window;
            this.listViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Result});
            this.listViewResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listViewResult.Location = new System.Drawing.Point(2, 49);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(801, 309);
            this.listViewResult.TabIndex = 1;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // Result
            // 
            this.Result.Text = "";
            this.Result.Width = 799;
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(29, 18);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(436, 20);
            this.searchQuery.TabIndex = 2;
            this.searchQuery.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // bn_search
            // 
            this.bn_search.BackColor = System.Drawing.Color.White;
            this.bn_search.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.bn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bn_search.Location = new System.Drawing.Point(637, 15);
            this.bn_search.Name = "bn_search";
            this.bn_search.Size = new System.Drawing.Size(64, 28);
            this.bn_search.TabIndex = 3;
            this.bn_search.Text = "Buscar";
            this.bn_search.UseVisualStyleBackColor = false;
            this.bn_search.Click += new System.EventHandler(this.bn_search_Click);
            // 
            // dropdownlist
            // 
            this.dropdownlist.FormattingEnabled = true;
            this.dropdownlist.Items.AddRange(new object[] {
            "Normal",
            "Com stoplist",
            "Com stemming",
            "Stoplist e  stemming"});
            this.dropdownlist.Location = new System.Drawing.Point(483, 18);
            this.dropdownlist.Name = "dropdownlist";
            this.dropdownlist.Size = new System.Drawing.Size(142, 21);
            this.dropdownlist.TabIndex = 4;
            this.dropdownlist.SelectedIndexChanged += new System.EventHandler(this.dropdownlist_SelectedIndexChanged);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(486, 49);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(62, 13);
            this.labelResults.TabIndex = 6;
            this.labelResults.Text = "Retornados";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 358);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.dropdownlist);
            this.Controls.Add(this.bn_search);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Gago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Button bn_search;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.ComboBox dropdownlist;
        private System.Windows.Forms.Label labelResults;
    }
}

