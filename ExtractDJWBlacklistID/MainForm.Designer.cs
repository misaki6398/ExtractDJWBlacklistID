namespace ExtractDJWBlacklistID
{
    partial class MainForm
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
            this.buttonRunExtract = new System.Windows.Forms.Button();
            this.textBox936ExcelFilePath = new System.Windows.Forms.TextBox();
            this.textBoxDJWListFilePath = new System.Windows.Forms.TextBox();
            this.textBoxOutputExcelPath = new System.Windows.Forms.TextBox();
            this.button936ExcelFilePath = new System.Windows.Forms.Button();
            this.buttonDJWListFilePath = new System.Windows.Forms.Button();
            this.buttonOutputExcelPath = new System.Windows.Forms.Button();
            this.labe936ExcelFilePath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutputExcelPath = new System.Windows.Forms.Label();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.groupBoxPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRunExtract
            // 
            this.buttonRunExtract.BackColor = System.Drawing.Color.Transparent;
            this.buttonRunExtract.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunExtract.Location = new System.Drawing.Point(510, 248);
            this.buttonRunExtract.Name = "buttonRunExtract";
            this.buttonRunExtract.Size = new System.Drawing.Size(124, 41);
            this.buttonRunExtract.TabIndex = 0;
            this.buttonRunExtract.Text = "執行";
            this.buttonRunExtract.UseVisualStyleBackColor = false;
            this.buttonRunExtract.Click += new System.EventHandler(this.buttonRunExtract_Click);
            // 
            // textBox936ExcelFilePath
            // 
            this.textBox936ExcelFilePath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox936ExcelFilePath.Location = new System.Drawing.Point(19, 48);
            this.textBox936ExcelFilePath.Name = "textBox936ExcelFilePath";
            this.textBox936ExcelFilePath.Size = new System.Drawing.Size(514, 22);
            this.textBox936ExcelFilePath.TabIndex = 1;
            this.textBox936ExcelFilePath.Text = "D:\\CsProject\\ExtractDJWBlacklistID\\936list.xlsx";
            // 
            // textBoxDJWListFilePath
            // 
            this.textBoxDJWListFilePath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDJWListFilePath.Location = new System.Drawing.Point(19, 106);
            this.textBoxDJWListFilePath.Name = "textBoxDJWListFilePath";
            this.textBoxDJWListFilePath.Size = new System.Drawing.Size(514, 22);
            this.textBoxDJWListFilePath.TabIndex = 2;
            this.textBoxDJWListFilePath.Text = "D:\\CsProject\\ExtractDJWBlacklistID\\PFA2_201906022200_D.xml";
            // 
            // textBoxOutputExcelPath
            // 
            this.textBoxOutputExcelPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputExcelPath.Location = new System.Drawing.Point(19, 166);
            this.textBoxOutputExcelPath.Name = "textBoxOutputExcelPath";
            this.textBoxOutputExcelPath.Size = new System.Drawing.Size(514, 22);
            this.textBoxOutputExcelPath.TabIndex = 3;
            this.textBoxOutputExcelPath.Text = "D:\\GenExcel";
            // 
            // button936ExcelFilePath
            // 
            this.button936ExcelFilePath.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button936ExcelFilePath.Location = new System.Drawing.Point(546, 47);
            this.button936ExcelFilePath.Name = "button936ExcelFilePath";
            this.button936ExcelFilePath.Size = new System.Drawing.Size(75, 23);
            this.button936ExcelFilePath.TabIndex = 4;
            this.button936ExcelFilePath.Text = "選擇";
            this.button936ExcelFilePath.UseVisualStyleBackColor = true;
            this.button936ExcelFilePath.Click += new System.EventHandler(this.button936ExcelFilePath_Click);
            // 
            // buttonDJWListFilePath
            // 
            this.buttonDJWListFilePath.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDJWListFilePath.Location = new System.Drawing.Point(546, 104);
            this.buttonDJWListFilePath.Name = "buttonDJWListFilePath";
            this.buttonDJWListFilePath.Size = new System.Drawing.Size(75, 23);
            this.buttonDJWListFilePath.TabIndex = 5;
            this.buttonDJWListFilePath.Text = "選擇";
            this.buttonDJWListFilePath.UseVisualStyleBackColor = true;
            this.buttonDJWListFilePath.Click += new System.EventHandler(this.buttonDJWListFilePath_Click);
            // 
            // buttonOutputExcelPath
            // 
            this.buttonOutputExcelPath.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutputExcelPath.Location = new System.Drawing.Point(547, 165);
            this.buttonOutputExcelPath.Name = "buttonOutputExcelPath";
            this.buttonOutputExcelPath.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputExcelPath.TabIndex = 6;
            this.buttonOutputExcelPath.Text = "選擇";
            this.buttonOutputExcelPath.UseVisualStyleBackColor = true;
            this.buttonOutputExcelPath.Click += new System.EventHandler(this.buttonOutputExcelPath_Click);
            // 
            // labe936ExcelFilePath
            // 
            this.labe936ExcelFilePath.AutoSize = true;
            this.labe936ExcelFilePath.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe936ExcelFilePath.Location = new System.Drawing.Point(19, 30);
            this.labe936ExcelFilePath.Name = "labe936ExcelFilePath";
            this.labe936ExcelFilePath.Size = new System.Drawing.Size(85, 16);
            this.labe936ExcelFilePath.TabIndex = 7;
            this.labe936ExcelFilePath.Text = "洗防Excel位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "道瓊名單位置";
            // 
            // labelOutputExcelPath
            // 
            this.labelOutputExcelPath.AutoSize = true;
            this.labelOutputExcelPath.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputExcelPath.Location = new System.Drawing.Point(19, 149);
            this.labelOutputExcelPath.Name = "labelOutputExcelPath";
            this.labelOutputExcelPath.Size = new System.Drawing.Size(56, 16);
            this.labelOutputExcelPath.TabIndex = 9;
            this.labelOutputExcelPath.Text = "輸出位置";
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.textBoxOutputExcelPath);
            this.groupBoxPath.Controls.Add(this.labelOutputExcelPath);
            this.groupBoxPath.Controls.Add(this.textBox936ExcelFilePath);
            this.groupBoxPath.Controls.Add(this.label2);
            this.groupBoxPath.Controls.Add(this.textBoxDJWListFilePath);
            this.groupBoxPath.Controls.Add(this.labe936ExcelFilePath);
            this.groupBoxPath.Controls.Add(this.button936ExcelFilePath);
            this.groupBoxPath.Controls.Add(this.buttonOutputExcelPath);
            this.groupBoxPath.Controls.Add(this.buttonDJWListFilePath);
            this.groupBoxPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxPath.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(647, 219);
            this.groupBoxPath.TabIndex = 10;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "選擇位置";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.buttonRunExtract);
            this.Name = "MainForm";
            this.Text = "Extract DJW Blacklist ID";
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunExtract;
        private System.Windows.Forms.TextBox textBox936ExcelFilePath;
        private System.Windows.Forms.TextBox textBoxDJWListFilePath;
        private System.Windows.Forms.TextBox textBoxOutputExcelPath;
        private System.Windows.Forms.Button button936ExcelFilePath;
        private System.Windows.Forms.Button buttonDJWListFilePath;
        private System.Windows.Forms.Button buttonOutputExcelPath;
        private System.Windows.Forms.Label labe936ExcelFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutputExcelPath;
        private System.Windows.Forms.GroupBox groupBoxPath;
    }
}

