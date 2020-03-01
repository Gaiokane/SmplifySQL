namespace SmplifySQL
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richtxtboxOld = new System.Windows.Forms.RichTextBox();
            this.richtxtboxNew = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtxtboxOld
            // 
            this.richtxtboxOld.Location = new System.Drawing.Point(12, 12);
            this.richtxtboxOld.Name = "richtxtboxOld";
            this.richtxtboxOld.Size = new System.Drawing.Size(776, 210);
            this.richtxtboxOld.TabIndex = 0;
            this.richtxtboxOld.Text = "";
            // 
            // richtxtboxNew
            // 
            this.richtxtboxNew.Location = new System.Drawing.Point(12, 228);
            this.richtxtboxNew.Name = "richtxtboxNew";
            this.richtxtboxNew.Size = new System.Drawing.Size(776, 210);
            this.richtxtboxNew.TabIndex = 1;
            this.richtxtboxNew.Text = "";
            this.richtxtboxNew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richtxtboxNew_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtxtboxNew);
            this.Controls.Add(this.richtxtboxOld);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简化SQL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtboxOld;
        private System.Windows.Forms.RichTextBox richtxtboxNew;
    }
}

