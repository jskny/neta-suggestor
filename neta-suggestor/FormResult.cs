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
	public partial class FormResult : Form
	{
		protected MainForm m_mainForm = null;
		public void setMainFormPointer(MainForm a)
		{
			this.m_mainForm = a;
		}


		public FormResult()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormResult_Load(object sender, EventArgs e)
		{
			MessageBox.Show(this.m_mainForm.getListBoxCan().Items.Count.ToString(), "情報");
		}
	}
}
