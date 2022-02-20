namespace CSRunningMedianSample
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.sClrButton2 = new System.Windows.Forms.Button();
            this.sClrButton1 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.selectAll1 = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.copyButton1 = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.selectAll2 = new System.Windows.Forms.Button();
            this.copyButton2 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sClrButton2
            // 
            this.sClrButton2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.sClrButton2.Location = new System.Drawing.Point(104, 305);
            this.sClrButton2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sClrButton2.Name = "sClrButton2";
            this.sClrButton2.Size = new System.Drawing.Size(77, 26);
            this.sClrButton2.TabIndex = 26;
            this.sClrButton2.Text = "Sel. Clear";
            this.sClrButton2.UseVisualStyleBackColor = true;
            // 
            // sClrButton1
            // 
            this.sClrButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.sClrButton1.Location = new System.Drawing.Point(102, 305);
            this.sClrButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sClrButton1.Name = "sClrButton1";
            this.sClrButton1.Size = new System.Drawing.Size(77, 26);
            this.sClrButton1.TabIndex = 25;
            this.sClrButton1.Text = "Sel. Clear";
            this.sClrButton1.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.sClrButton1);
            this.GroupBox2.Controls.Add(this.selectAll1);
            this.GroupBox2.Controls.Add(this.pasteButton);
            this.GroupBox2.Controls.Add(this.deleteButton1);
            this.GroupBox2.Controls.Add(this.clearButton1);
            this.GroupBox2.Controls.Add(this.copyButton1);
            this.GroupBox2.Controls.Add(this.ListBox1);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(13, 42);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox2.Size = new System.Drawing.Size(186, 337);
            this.GroupBox2.TabIndex = 32;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Original Data";
            // 
            // selectAll1
            // 
            this.selectAll1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.selectAll1.Location = new System.Drawing.Point(8, 305);
            this.selectAll1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.selectAll1.Name = "selectAll1";
            this.selectAll1.Size = new System.Drawing.Size(77, 26);
            this.selectAll1.TabIndex = 24;
            this.selectAll1.Text = "Select All";
            this.selectAll1.UseVisualStyleBackColor = true;
            // 
            // pasteButton
            // 
            this.pasteButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.pasteButton.Location = new System.Drawing.Point(102, 277);
            this.pasteButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(77, 26);
            this.pasteButton.TabIndex = 23;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton1
            // 
            this.deleteButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.deleteButton1.Location = new System.Drawing.Point(102, 250);
            this.deleteButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(77, 26);
            this.deleteButton1.TabIndex = 22;
            this.deleteButton1.Text = "Delete";
            this.deleteButton1.UseVisualStyleBackColor = true;
            // 
            // clearButton1
            // 
            this.clearButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.clearButton1.Location = new System.Drawing.Point(8, 250);
            this.clearButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(77, 26);
            this.clearButton1.TabIndex = 18;
            this.clearButton1.Text = "Clear";
            this.clearButton1.UseVisualStyleBackColor = true;
            // 
            // copyButton1
            // 
            this.copyButton1.Enabled = false;
            this.copyButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.copyButton1.Location = new System.Drawing.Point(8, 277);
            this.copyButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.copyButton1.Name = "copyButton1";
            this.copyButton1.Size = new System.Drawing.Size(77, 26);
            this.copyButton1.TabIndex = 16;
            this.copyButton1.Text = "Copy";
            this.copyButton1.UseVisualStyleBackColor = true;
            // 
            // ListBox1
            // 
            this.ListBox1.AllowDrop = true;
            this.ListBox1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(8, 19);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox1.Size = new System.Drawing.Size(168, 212);
            this.ListBox1.TabIndex = 0;
            // 
            // selectAll2
            // 
            this.selectAll2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.selectAll2.Location = new System.Drawing.Point(13, 305);
            this.selectAll2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.selectAll2.Name = "selectAll2";
            this.selectAll2.Size = new System.Drawing.Size(77, 26);
            this.selectAll2.TabIndex = 25;
            this.selectAll2.Text = "Select All";
            this.selectAll2.UseVisualStyleBackColor = true;
            // 
            // copyButton2
            // 
            this.copyButton2.Enabled = false;
            this.copyButton2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.copyButton2.Location = new System.Drawing.Point(13, 277);
            this.copyButton2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.copyButton2.Name = "copyButton2";
            this.copyButton2.Size = new System.Drawing.Size(169, 26);
            this.copyButton2.TabIndex = 20;
            this.copyButton2.Text = "Copy";
            this.copyButton2.UseVisualStyleBackColor = true;
            // 
            // clearButton2
            // 
            this.clearButton2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.clearButton2.Location = new System.Drawing.Point(13, 250);
            this.clearButton2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(169, 26);
            this.clearButton2.TabIndex = 19;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(13, 382);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox1.Size = new System.Drawing.Size(385, 42);
            this.GroupBox1.TabIndex = 31;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButton2.Location = new System.Drawing.Point(74, 14);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(82, 20);
            this.RadioButton2.TabIndex = 11;
            this.RadioButton2.Text = "All Median";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButton1.Location = new System.Drawing.Point(189, 14);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(105, 20);
            this.RadioButton1.TabIndex = 10;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Middle Median";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(313, 11);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 22);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.TextBox1.Location = new System.Drawing.Point(13, 11);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(292, 23);
            this.TextBox1.TabIndex = 29;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.calcButton.Location = new System.Drawing.Point(13, 434);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(385, 43);
            this.calcButton.TabIndex = 28;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // ListBox2
            // 
            this.ListBox2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 16;
            this.ListBox2.Location = new System.Drawing.Point(13, 19);
            this.ListBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox2.Size = new System.Drawing.Size(168, 212);
            this.ListBox2.TabIndex = 1;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.sClrButton2);
            this.GroupBox3.Controls.Add(this.selectAll2);
            this.GroupBox3.Controls.Add(this.copyButton2);
            this.GroupBox3.Controls.Add(this.clearButton2);
            this.GroupBox3.Controls.Add(this.ListBox2);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(205, 42);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox3.Size = new System.Drawing.Size(192, 337);
            this.GroupBox3.TabIndex = 33;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Calibrated Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 490);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.GroupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button sClrButton2;
        internal System.Windows.Forms.Button sClrButton1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button selectAll1;
        internal System.Windows.Forms.Button pasteButton;
        internal System.Windows.Forms.Button deleteButton1;
        internal System.Windows.Forms.Button clearButton1;
        internal System.Windows.Forms.Button copyButton1;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button selectAll2;
        internal System.Windows.Forms.Button copyButton2;
        internal System.Windows.Forms.Button clearButton2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button calcButton;
        internal System.Windows.Forms.ListBox ListBox2;
        internal System.Windows.Forms.GroupBox GroupBox3;
    }
}

