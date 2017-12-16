using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neta_suggestor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void バージョン情報VToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Version beta.\n" +
				"\n" +
				"I have started blog site before 3 month.\n" +
				"But, I can't earn article idea.\n" +
				"So I start create an app that may suggest idea a little.\n" +
				"I wish this app can complete.\n" +
				"\n" +
				"\n" +
				"This App was created by jskny at 2017."
				, "Version info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void groupBoxInputsResultButton1_Click(object sender, EventArgs e)
		{

		}

		private void groupBoxInputsCanButton1_Click(object sender, EventArgs e)
		{
			if (this.groupBoxInputsCanTextBox1.Text.Length <= 0)
			{
				MessageBox.Show("できることを記入してから登録してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.groupBoxInputsResultCanListBox1.Items.Add(this.groupBoxInputsCanTextBox1.Text);
			this.groupBoxInputsCanTextBox1.Text = "";
		}

		private void groupBoxInputsInterestButton1_Click(object sender, EventArgs e)
		{
			if (this.groupBoxInputsInterestTextBox1.Text.Length <= 0)
			{
				MessageBox.Show("興味を持ったことを記入してから登録してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.groupBoxInputsResultInterestListBox1.Items.Add(this.groupBoxInputsInterestTextBox1.Text);
			this.groupBoxInputsInterestTextBox1.Text = "";
		}


		private void resetInputedListBox()
		{
			this.groupBoxInputsResultCanListBox1.Items.Clear();
			this.groupBoxInputsResultInterestListBox1.Items.Clear();
		}
		private void showResetInputedListBoxDialog()
		{
			DialogResult ret = MessageBox.Show("初期化しますがよろしいでしょうか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ret == DialogResult.Cancel)
			{
				return;
			}
			else
			{
				this.resetInputedListBox();
				MessageBox.Show("初期化いたしました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void groupBoxInputsResultButtonReset_Click(object sender, EventArgs e)
		{
			this.showResetInputedListBoxDialog();
		}

		private void 初期化ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.showResetInputedListBoxDialog();
		}
	}
}
