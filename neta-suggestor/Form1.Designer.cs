namespace neta_suggestor
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.初期化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.使い方UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxInputs = new System.Windows.Forms.GroupBox();
			this.groupBoxInputsResult = new System.Windows.Forms.GroupBox();
			this.groupBoxInputsCan = new System.Windows.Forms.GroupBox();
			this.groupBoxInputsCanTextBox1 = new System.Windows.Forms.TextBox();
			this.groupBoxInputsCanButton1 = new System.Windows.Forms.Button();
			this.groupBoxInputsInterestButton1 = new System.Windows.Forms.Button();
			this.groupBoxInputsInterestTextBox1 = new System.Windows.Forms.TextBox();
			this.groupBoxInputsInterest = new System.Windows.Forms.GroupBox();
			this.groupBoxInputsResultCan = new System.Windows.Forms.GroupBox();
			this.groupBoxInputsResultCanListBox1 = new System.Windows.Forms.ListBox();
			this.groupBoxInputsResultInterest = new System.Windows.Forms.GroupBox();
			this.groupBoxInputsResultInterestListBox1 = new System.Windows.Forms.ListBox();
			this.groupBoxInputsResultButton1 = new System.Windows.Forms.Button();
			this.groupBoxInputsResultButtonReset = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBoxInputs.SuspendLayout();
			this.groupBoxInputsResult.SuspendLayout();
			this.groupBoxInputsCan.SuspendLayout();
			this.groupBoxInputsInterest.SuspendLayout();
			this.groupBoxInputsResultCan.SuspendLayout();
			this.groupBoxInputsResultInterest.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileFToolStripMenuItem
			// 
			this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初期化ToolStripMenuItem,
            this.終了XToolStripMenuItem});
			this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
			this.fileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.fileFToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// 初期化ToolStripMenuItem
			// 
			this.初期化ToolStripMenuItem.Name = "初期化ToolStripMenuItem";
			this.初期化ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.初期化ToolStripMenuItem.Text = "初期化";
			// 
			// 終了XToolStripMenuItem
			// 
			this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
			this.終了XToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.終了XToolStripMenuItem.Text = "終了(&X)";
			this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
			// 
			// ヘルプHToolStripMenuItem
			// 
			this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使い方UToolStripMenuItem,
            this.バージョン情報VToolStripMenuItem});
			this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
			this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
			// 
			// 使い方UToolStripMenuItem
			// 
			this.使い方UToolStripMenuItem.Name = "使い方UToolStripMenuItem";
			this.使い方UToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.使い方UToolStripMenuItem.Text = "使い方(&U)";
			// 
			// バージョン情報VToolStripMenuItem
			// 
			this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
			this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
			this.バージョン情報VToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報VToolStripMenuItem_Click);
			// 
			// groupBoxInputs
			// 
			this.groupBoxInputs.Controls.Add(this.groupBoxInputsInterest);
			this.groupBoxInputs.Controls.Add(this.groupBoxInputsCan);
			this.groupBoxInputs.Location = new System.Drawing.Point(12, 27);
			this.groupBoxInputs.Name = "groupBoxInputs";
			this.groupBoxInputs.Size = new System.Drawing.Size(266, 173);
			this.groupBoxInputs.TabIndex = 1;
			this.groupBoxInputs.TabStop = false;
			this.groupBoxInputs.Text = "基本入力フォーム";
			// 
			// groupBoxInputsResult
			// 
			this.groupBoxInputsResult.Controls.Add(this.groupBoxInputsResultButtonReset);
			this.groupBoxInputsResult.Controls.Add(this.groupBoxInputsResultButton1);
			this.groupBoxInputsResult.Controls.Add(this.groupBoxInputsResultInterest);
			this.groupBoxInputsResult.Controls.Add(this.groupBoxInputsResultCan);
			this.groupBoxInputsResult.Location = new System.Drawing.Point(285, 28);
			this.groupBoxInputsResult.Name = "groupBoxInputsResult";
			this.groupBoxInputsResult.Size = new System.Drawing.Size(327, 172);
			this.groupBoxInputsResult.TabIndex = 2;
			this.groupBoxInputsResult.TabStop = false;
			this.groupBoxInputsResult.Text = "入力結果";
			// 
			// groupBoxInputsCan
			// 
			this.groupBoxInputsCan.Controls.Add(this.groupBoxInputsCanButton1);
			this.groupBoxInputsCan.Controls.Add(this.groupBoxInputsCanTextBox1);
			this.groupBoxInputsCan.Location = new System.Drawing.Point(7, 19);
			this.groupBoxInputsCan.Name = "groupBoxInputsCan";
			this.groupBoxInputsCan.Size = new System.Drawing.Size(253, 74);
			this.groupBoxInputsCan.TabIndex = 0;
			this.groupBoxInputsCan.TabStop = false;
			this.groupBoxInputsCan.Text = "できること";
			// 
			// groupBoxInputsCanTextBox1
			// 
			this.groupBoxInputsCanTextBox1.Location = new System.Drawing.Point(7, 19);
			this.groupBoxInputsCanTextBox1.Name = "groupBoxInputsCanTextBox1";
			this.groupBoxInputsCanTextBox1.Size = new System.Drawing.Size(240, 19);
			this.groupBoxInputsCanTextBox1.TabIndex = 0;
			// 
			// groupBoxInputsCanButton1
			// 
			this.groupBoxInputsCanButton1.Location = new System.Drawing.Point(7, 44);
			this.groupBoxInputsCanButton1.Name = "groupBoxInputsCanButton1";
			this.groupBoxInputsCanButton1.Size = new System.Drawing.Size(240, 23);
			this.groupBoxInputsCanButton1.TabIndex = 1;
			this.groupBoxInputsCanButton1.Text = "登録";
			this.groupBoxInputsCanButton1.UseVisualStyleBackColor = true;
			// 
			// groupBoxInputsInterestButton1
			// 
			this.groupBoxInputsInterestButton1.Location = new System.Drawing.Point(7, 44);
			this.groupBoxInputsInterestButton1.Name = "groupBoxInputsInterestButton1";
			this.groupBoxInputsInterestButton1.Size = new System.Drawing.Size(240, 23);
			this.groupBoxInputsInterestButton1.TabIndex = 1;
			this.groupBoxInputsInterestButton1.Text = "登録";
			this.groupBoxInputsInterestButton1.UseVisualStyleBackColor = true;
			// 
			// groupBoxInputsInterestTextBox1
			// 
			this.groupBoxInputsInterestTextBox1.Location = new System.Drawing.Point(7, 19);
			this.groupBoxInputsInterestTextBox1.Name = "groupBoxInputsInterestTextBox1";
			this.groupBoxInputsInterestTextBox1.Size = new System.Drawing.Size(240, 19);
			this.groupBoxInputsInterestTextBox1.TabIndex = 0;
			// 
			// groupBoxInputsInterest
			// 
			this.groupBoxInputsInterest.Controls.Add(this.groupBoxInputsInterestButton1);
			this.groupBoxInputsInterest.Controls.Add(this.groupBoxInputsInterestTextBox1);
			this.groupBoxInputsInterest.Location = new System.Drawing.Point(7, 99);
			this.groupBoxInputsInterest.Name = "groupBoxInputsInterest";
			this.groupBoxInputsInterest.Size = new System.Drawing.Size(253, 74);
			this.groupBoxInputsInterest.TabIndex = 2;
			this.groupBoxInputsInterest.TabStop = false;
			this.groupBoxInputsInterest.Text = "興味を持ったこと";
			// 
			// groupBoxInputsResultCan
			// 
			this.groupBoxInputsResultCan.Controls.Add(this.groupBoxInputsResultCanListBox1);
			this.groupBoxInputsResultCan.Location = new System.Drawing.Point(7, 19);
			this.groupBoxInputsResultCan.Name = "groupBoxInputsResultCan";
			this.groupBoxInputsResultCan.Size = new System.Drawing.Size(150, 116);
			this.groupBoxInputsResultCan.TabIndex = 0;
			this.groupBoxInputsResultCan.TabStop = false;
			this.groupBoxInputsResultCan.Text = "できること";
			// 
			// groupBoxInputsResultCanListBox1
			// 
			this.groupBoxInputsResultCanListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.groupBoxInputsResultCanListBox1.FormattingEnabled = true;
			this.groupBoxInputsResultCanListBox1.ItemHeight = 12;
			this.groupBoxInputsResultCanListBox1.Location = new System.Drawing.Point(6, 18);
			this.groupBoxInputsResultCanListBox1.MultiColumn = true;
			this.groupBoxInputsResultCanListBox1.Name = "groupBoxInputsResultCanListBox1";
			this.groupBoxInputsResultCanListBox1.ScrollAlwaysVisible = true;
			this.groupBoxInputsResultCanListBox1.Size = new System.Drawing.Size(138, 86);
			this.groupBoxInputsResultCanListBox1.TabIndex = 0;
			// 
			// groupBoxInputsResultInterest
			// 
			this.groupBoxInputsResultInterest.Controls.Add(this.groupBoxInputsResultInterestListBox1);
			this.groupBoxInputsResultInterest.Location = new System.Drawing.Point(163, 19);
			this.groupBoxInputsResultInterest.Name = "groupBoxInputsResultInterest";
			this.groupBoxInputsResultInterest.Size = new System.Drawing.Size(158, 117);
			this.groupBoxInputsResultInterest.TabIndex = 1;
			this.groupBoxInputsResultInterest.TabStop = false;
			this.groupBoxInputsResultInterest.Text = "興味を持ったこと";
			// 
			// groupBoxInputsResultInterestListBox1
			// 
			this.groupBoxInputsResultInterestListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.groupBoxInputsResultInterestListBox1.FormattingEnabled = true;
			this.groupBoxInputsResultInterestListBox1.ItemHeight = 12;
			this.groupBoxInputsResultInterestListBox1.Location = new System.Drawing.Point(6, 18);
			this.groupBoxInputsResultInterestListBox1.MultiColumn = true;
			this.groupBoxInputsResultInterestListBox1.Name = "groupBoxInputsResultInterestListBox1";
			this.groupBoxInputsResultInterestListBox1.ScrollAlwaysVisible = true;
			this.groupBoxInputsResultInterestListBox1.Size = new System.Drawing.Size(146, 86);
			this.groupBoxInputsResultInterestListBox1.TabIndex = 0;
			// 
			// groupBoxInputsResultButton1
			// 
			this.groupBoxInputsResultButton1.Location = new System.Drawing.Point(7, 142);
			this.groupBoxInputsResultButton1.Name = "groupBoxInputsResultButton1";
			this.groupBoxInputsResultButton1.Size = new System.Drawing.Size(150, 23);
			this.groupBoxInputsResultButton1.TabIndex = 2;
			this.groupBoxInputsResultButton1.Text = "生成";
			this.groupBoxInputsResultButton1.UseVisualStyleBackColor = true;
			this.groupBoxInputsResultButton1.Click += new System.EventHandler(this.groupBoxInputsResultButton1_Click);
			// 
			// groupBoxInputsResultButtonReset
			// 
			this.groupBoxInputsResultButtonReset.Location = new System.Drawing.Point(163, 142);
			this.groupBoxInputsResultButtonReset.Name = "groupBoxInputsResultButtonReset";
			this.groupBoxInputsResultButtonReset.Size = new System.Drawing.Size(158, 23);
			this.groupBoxInputsResultButtonReset.TabIndex = 3;
			this.groupBoxInputsResultButtonReset.Text = "初期化";
			this.groupBoxInputsResultButtonReset.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 209);
			this.Controls.Add(this.groupBoxInputsResult);
			this.Controls.Add(this.groupBoxInputs);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ネタサジェスター";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxInputs.ResumeLayout(false);
			this.groupBoxInputsResult.ResumeLayout(false);
			this.groupBoxInputsCan.ResumeLayout(false);
			this.groupBoxInputsCan.PerformLayout();
			this.groupBoxInputsInterest.ResumeLayout(false);
			this.groupBoxInputsInterest.PerformLayout();
			this.groupBoxInputsResultCan.ResumeLayout(false);
			this.groupBoxInputsResultInterest.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 初期化ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 使い方UToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxInputs;
		private System.Windows.Forms.GroupBox groupBoxInputsResult;
		private System.Windows.Forms.GroupBox groupBoxInputsCan;
		private System.Windows.Forms.Button groupBoxInputsCanButton1;
		private System.Windows.Forms.TextBox groupBoxInputsCanTextBox1;
		private System.Windows.Forms.GroupBox groupBoxInputsInterest;
		private System.Windows.Forms.Button groupBoxInputsInterestButton1;
		private System.Windows.Forms.TextBox groupBoxInputsInterestTextBox1;
		private System.Windows.Forms.GroupBox groupBoxInputsResultCan;
		private System.Windows.Forms.ListBox groupBoxInputsResultCanListBox1;
		private System.Windows.Forms.GroupBox groupBoxInputsResultInterest;
		private System.Windows.Forms.ListBox groupBoxInputsResultInterestListBox1;
		private System.Windows.Forms.Button groupBoxInputsResultButton1;
		private System.Windows.Forms.Button groupBoxInputsResultButtonReset;
	}
}

