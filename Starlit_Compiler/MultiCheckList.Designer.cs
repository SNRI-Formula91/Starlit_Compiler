
namespace Starlit_Compiler
{
    partial class MultiCheckList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAll = new System.Windows.Forms.Button();
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(24, 19);
            this.btnAll.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(76, 23);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Select All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // checkList
            // 
            this.checkList.CheckOnClick = true;
            this.checkList.FormattingEnabled = true;
            this.checkList.Location = new System.Drawing.Point(2, 46);
            this.checkList.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(120, 199);
            this.checkList.TabIndex = 2;
            this.checkList.SelectedIndexChanged += new System.EventHandler(this.CheckList_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MultiCheckList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.checkList);
            this.Name = "MultiCheckList";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(124, 247);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckedListBox checkList;
        private System.Windows.Forms.Label lblTitle;
    }
}
