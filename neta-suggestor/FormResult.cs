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


		protected Random m_rnd= null;
		public string getTextWhen()
		{
			string[] tmp = {
				"関心を持った時", "現在",
				"１年前", "１年後",
				"１０年前", "１０年後",
				"小学生のころ", "中学生のころ", "高校生のころ", "大学生／専門学校生のころ",
				"今とは別の物事が専門分野だった頃" };
			return (tmp[this.m_rnd.Next() % tmp.Length]);
		}

		public string getTextWhere()
		{
			string[] tmp = {
				"自宅で", "勤務先／学校で",
				"カフェで", "飲食店で",
				"ベットの上で", "電車の中で", "バスの中で",
				"映画館の中で", "カラオケ店で",
				"友人の家で", "路上で", "公園で", "図書館で", "橋の上で", "けもの道の中で",
				"ショッピングセンターで", "スポーツセンターで",
				"夢の中で"
			};
			return (tmp[this.m_rnd.Next() % tmp.Length]);
		}

		public string getTextWho()
		{
			string[] tmp = {
				"あなたが",
				"小学生のころの友人が",
				"中学生のころの友人が",
				"高校生のころの友人が",
				"大学／専門学校生のころの友人が",
				"学友・仕事仲間が",
				"ご両親が", "おじいちゃんやおばあちゃんが",
				"親戚が", "外国人が", "外国人留学生が",
				"SNSでの知り合いが",
				"５年前の自分が", "５年後の自分が"
			};
			return (tmp[this.m_rnd.Next() % tmp.Length]);
		}

		public string getTextWhy()
		{
			string[] tmp = {
				"震災で", "交通事故で", "自然災害で", "感染症で",
				"事件に巻き込まれて", "病で", "役割に没頭し過ぎて",
				"誰かのことを顧みないで", "自己中心的で", "優先順位を正確に定めて",
				"勘違いで", "真意を読み間違えて", "真価を図り損ねて",
				"確約を得ないで", "十分確認をしないで", "大事なところを見落として"
			};
			return (tmp[this.m_rnd.Next() % tmp.Length]);
		}

		public string getTextWhat()
		{
			//this.m_rnd.Next()
			string tmp = this.m_mainForm.getListBoxInterest().Items[this.m_rnd.Next()%this.m_mainForm.getListBoxInterest().Items.Count].ToString();
			return (tmp);
		}
		public string getTextHow()
		{
			//this.m_rnd.Next()
			string tmp = this.m_mainForm.getListBoxCan().Items[this.m_rnd.Next() % this.m_mainForm.getListBoxCan().Items.Count].ToString();
			return (tmp);
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
			this.m_rnd = new Random();

			this.resultLabel1.Text = this.getTextWhen();
			this.resultLabel2.Text = this.getTextWhere();
			this.resultLabel3.Text = this.getTextWho();
			this.resultLabel4.Text = this.getTextWhat();
			this.resultLabel5.Text = this.getTextWhy();
			this.resultLabel6.Text = this.getTextHow();
		}
	}
}
