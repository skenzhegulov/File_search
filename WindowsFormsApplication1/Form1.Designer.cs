namespace WindowsFormsApplication1
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
            this.data_results = new System.Windows.Forms.DataGridView();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.lbl_folder = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.f_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_results)).BeginInit();
            this.SuspendLayout();
            // 
            // data_results
            // 
            this.data_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_results.Location = new System.Drawing.Point(12, 133);
            this.data_results.Name = "data_results";
            this.data_results.Size = new System.Drawing.Size(554, 216);
            this.data_results.TabIndex = 13;
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.Location = new System.Drawing.Point(-135, 18);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(48, 13);
            this.lbl_keyword.TabIndex = 12;
            this.lbl_keyword.Text = "Keyword";
            // 
            // lbl_folder
            // 
            this.lbl_folder.AutoSize = true;
            this.lbl_folder.Location = new System.Drawing.Point(-135, -34);
            this.lbl_folder.Name = "lbl_folder";
            this.lbl_folder.Size = new System.Drawing.Size(29, 13);
            this.lbl_folder.TabIndex = 11;
            this.lbl_folder.Text = "Path";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(486, 88);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 20);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(12, 88);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(443, 20);
            this.txt_keyword.TabIndex = 9;
            // 
            // f_path
            // 
            this.f_path.Location = new System.Drawing.Point(12, 36);
            this.f_path.Name = "f_path";
            this.f_path.Size = new System.Drawing.Size(443, 20);
            this.f_path.TabIndex = 8;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(486, 36);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(80, 20);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Keyword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_results);
            this.Controls.Add(this.lbl_keyword);
            this.Controls.Add(this.lbl_folder);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_keyword);
            this.Controls.Add(this.f_path);
            this.Controls.Add(this.btn_browse);
            this.Name = "Form1";
            this.Text = "File Search";
            ((System.ComponentModel.ISupportInitialize)(this.data_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_results;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.Label lbl_folder;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.TextBox f_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

