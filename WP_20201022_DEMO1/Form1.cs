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
            List<int> poker = GetPoker(52);

            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";
            }

            rtbMsg.Text = msg + "\n";
        }


        public List<int> GetPoker(int count)
        {
            List<int> result = new List<int>();
            try
            {
                //新增N筆資料
                for (int i = 0; i < count; i++)
                {
                    result.Add(i);
                }

                //模擬發牌
                for (int i = count - 2; i > 0; i--)
                {
                    int lastIndex = i + 1;                    //方便閱讀
                    int randomIndex = (new Random()).Next(i); //抽牌

                    //交換
                    int temp = result[lastIndex];
                    result[lastIndex] = result[randomIndex];
                    result[randomIndex] = temp;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }

    }
}
