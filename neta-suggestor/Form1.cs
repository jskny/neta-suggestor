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
				, "Version info", MessageBoxButtons.OK);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void groupBoxInputsResultButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
