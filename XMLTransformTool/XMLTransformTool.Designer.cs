namespace XMLTransformTool
{
    partial class XMLTransformTool
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Schema = new System.Windows.Forms.TextBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Execute = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_Path = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label_Schema = new System.Windows.Forms.Label();
            this.textBox_Extension = new System.Windows.Forms.TextBox();
            this.label_Extension = new System.Windows.Forms.Label();
            this.comboBox_FilesNameRule = new System.Windows.Forms.ComboBox();
            this.label_FilesNameRule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Schema
            // 
            this.textBox_Schema.AcceptsReturn = true;
            this.textBox_Schema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Schema.Location = new System.Drawing.Point(12, 24);
            this.textBox_Schema.Multiline = true;
            this.textBox_Schema.Name = "textBox_Schema";
            this.textBox_Schema.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Schema.Size = new System.Drawing.Size(225, 225);
            this.textBox_Schema.TabIndex = 0;
            this.textBox_Schema.TextChanged += new System.EventHandler(this.textBox_Schema_TextChanged);
            // 
            // button_Browse
            // 
            this.button_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Browse.Location = new System.Drawing.Point(409, 280);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 22);
            this.button_Browse.TabIndex = 1;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Path.Location = new System.Drawing.Point(12, 280);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(391, 22);
            this.textBox_Path.TabIndex = 2;
            // 
            // button_Execute
            // 
            this.button_Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Execute.Location = new System.Drawing.Point(409, 334);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(75, 22);
            this.button_Execute.TabIndex = 3;
            this.button_Execute.Text = "Execute";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Excute_Click);
            // 
            // label_Message
            // 
            this.label_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Message.Location = new System.Drawing.Point(10, 370);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(44, 12);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "Message";
            // 
            // label_Path
            // 
            this.label_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(10, 265);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(25, 12);
            this.label_Path.TabIndex = 5;
            this.label_Path.Text = "Path";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(250, 9);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(26, 12);
            this.label_Data.TabIndex = 6;
            this.label_Data.Text = "Data";
            // 
            // textBox_Message
            // 
            this.textBox_Message.AcceptsReturn = true;
            this.textBox_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Message.Location = new System.Drawing.Point(12, 385);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Message.Size = new System.Drawing.Size(472, 71);
            this.textBox_Message.TabIndex = 7;
            // 
            // textBox_Data
            // 
            this.textBox_Data.AcceptsReturn = true;
            this.textBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Data.Location = new System.Drawing.Point(252, 24);
            this.textBox_Data.Multiline = true;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Data.Size = new System.Drawing.Size(232, 225);
            this.textBox_Data.TabIndex = 8;
            // 
            // label_Schema
            // 
            this.label_Schema.AutoSize = true;
            this.label_Schema.Location = new System.Drawing.Point(10, 9);
            this.label_Schema.Name = "label_Schema";
            this.label_Schema.Size = new System.Drawing.Size(41, 12);
            this.label_Schema.TabIndex = 9;
            this.label_Schema.Text = "Schema";
            // 
            // textBox_Extension
            // 
            this.textBox_Extension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Extension.Location = new System.Drawing.Point(296, 334);
            this.textBox_Extension.Name = "textBox_Extension";
            this.textBox_Extension.Size = new System.Drawing.Size(107, 22);
            this.textBox_Extension.TabIndex = 10;
            // 
            // label_Extension
            // 
            this.label_Extension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Extension.AutoSize = true;
            this.label_Extension.Location = new System.Drawing.Point(294, 319);
            this.label_Extension.Name = "label_Extension";
            this.label_Extension.Size = new System.Drawing.Size(51, 12);
            this.label_Extension.TabIndex = 11;
            this.label_Extension.Text = "Extension";
            // 
            // comboBox_FilesNameRule
            // 
            this.comboBox_FilesNameRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_FilesNameRule.FormattingEnabled = true;
            this.comboBox_FilesNameRule.Location = new System.Drawing.Point(12, 334);
            this.comboBox_FilesNameRule.Name = "comboBox_FilesNameRule";
            this.comboBox_FilesNameRule.Size = new System.Drawing.Size(278, 20);
            this.comboBox_FilesNameRule.TabIndex = 12;
            // 
            // label_FilesNameRule
            // 
            this.label_FilesNameRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_FilesNameRule.AutoSize = true;
            this.label_FilesNameRule.Location = new System.Drawing.Point(10, 319);
            this.label_FilesNameRule.Name = "label_FilesNameRule";
            this.label_FilesNameRule.Size = new System.Drawing.Size(75, 12);
            this.label_FilesNameRule.TabIndex = 13;
            this.label_FilesNameRule.Text = "FilesNameRule";
            // 
            // XMLTransformTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 468);
            this.Controls.Add(this.label_FilesNameRule);
            this.Controls.Add(this.comboBox_FilesNameRule);
            this.Controls.Add(this.label_Extension);
            this.Controls.Add(this.textBox_Extension);
            this.Controls.Add(this.label_Schema);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.textBox_Schema);
            this.Name = "XMLTransformTool";
            this.Text = "XMLTransformTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Schema;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Label label_Schema;
        private System.Windows.Forms.TextBox textBox_Extension;
        private System.Windows.Forms.Label label_Extension;
        private System.Windows.Forms.ComboBox comboBox_FilesNameRule;
        private System.Windows.Forms.Label label_FilesNameRule;
    }
}

