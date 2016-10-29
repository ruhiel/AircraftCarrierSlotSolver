using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AircraftCarrierSlotSolver.Controls
{
	public partial class DataGridViewVerticalScroll : DataGridView
	{
		private bool alwaysVScroll = true;

		/// <summary>
		/// 垂直スクロールバーを常に表示するか否かを設定します。 
		/// </summary>
		[Category("表示")]
		[Description("垂直スクロールバーを常に表示するか否かを設定します。")]
		[DefaultValue("false")]
		public bool AlwaysVScroll
		{
			get { return alwaysVScroll; }
			set { alwaysVScroll = value; }
		}

		/// <summary>
		/// コンストラクタ 
		/// </summary>
		public DataGridViewVerticalScroll()
		{
			FindVScrollBar();
		}

		/// <summary>
		/// コンストラクタ 
		/// </summary>
		public DataGridViewVerticalScroll(IContainer container)
		{
			FindVScrollBar();
			container.Add(this);
		}

		// 垂直スクロールバーオブジェクトの検索とイベントハンドラの登録
		private void FindVScrollBar()
		{
			foreach (Control control in this.Controls)
			{
				if (control is VScrollBar)
				{
					VScrollBar vsb = (VScrollBar)control;
					vsb.Visible = true;
					vsb.VisibleChanged += new EventHandler(VBar_VisibleChanged);
				}
			}
		}
		// 垂直スクロールバーを表示する。
		void VBar_VisibleChanged(object sender, EventArgs e)
		{
			// 常に表示する設定か？
			if (AlwaysVScroll)
			{
				VScrollBar vsBar = (VScrollBar)sender;
				if (!vsBar.Visible)    //縦クロースバーを常に表示する。
				{
					vsBar.Location = new Point(this.ClientRectangle.Width - vsBar.Width, 0);
					vsBar.Size = new Size(vsBar.Width, this.ClientRectangle.Height);
					vsBar.Show();
				}
			}
		}

		// Enterキー押下時の動作をTabキーと同じにする
		protected override bool ProcessDialogKey(Keys keyData)
		{
			//Enterキーが押された時は、Tabキーが押されたようにする
			if ((keyData & Keys.KeyCode) == Keys.Enter)
			{
				return this.ProcessTabKey(keyData);
			}
			return base.ProcessDialogKey(keyData);
		}

		// Enterキー押下時の動作をTabキーと同じにする
		protected override bool ProcessDataGridViewKey(KeyEventArgs e)
		{
			//Enterキーが押された時は、Tabキーが押されたようにする
			if (e.KeyCode == Keys.Enter)
			{
				return this.ProcessTabKey(e.KeyCode);
			}
			return base.ProcessDataGridViewKey(e);
		}
	}
}
