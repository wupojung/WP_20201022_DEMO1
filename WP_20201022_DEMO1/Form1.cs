using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_20201022_DEMO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Poker p = new Poker();

            List<int> poker = p.GetPoker(52);

            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";
            }

            rtbMsg.Text = msg + "\n";
        }

        int id = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            //模擬連線到DB 取得ID 
            id = 46715464;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //更新畫面
            labId.Text = "ID:" + id;
            //labId.Text = $"ID:{id}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
