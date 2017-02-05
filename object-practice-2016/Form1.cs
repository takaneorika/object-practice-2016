using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace object_practice_2016
{
    public partial class Form1 : Form
    {
        /** 人の名前*/
        private string[] HITO_NAMES = { "佐藤", "鈴木", "高橋" };
        /** 鳥の名前*/
        private string[] TORI_NAMES = { "スズメ", "カラス", "ハト", "トビ"};
        /** 魚の名前*/
        private string[] SAKANA_NAMES = { "グッピー", "メダカ"};

        /** 生き物の種類*/
        private enum IKIMONO_TYPE
        {
            IKIMONO_HITO,
            IKIMONO_TORI,
            IKIMONO_SAKANA
        }
        /** 自分の種類*/
        private IKIMONO_TYPE[] types;

        /** 名前*/
        private string[] names;

        /** 人の数*/
        private int iHitoCount;
        /** 鳥の数*/
        private int iToriCount;
        /** 魚の数*/
        private int iSakanaCount;
        /** 生き物の数*/
        private int iIkimonoCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 数を算出
            iHitoCount = HITO_NAMES.Length;
            iToriCount = TORI_NAMES.Length;
            iSakanaCount = SAKANA_NAMES.Length;
            iIkimonoCount = iHitoCount + iToriCount + iSakanaCount;

            // 変数の領域を確保
            names = new string[iIkimonoCount];
            types = new IKIMONO_TYPE[iIkimonoCount];

            // 人を登録
            for (int i = 0; i < iHitoCount; i++)
            {
                types[i] = IKIMONO_TYPE.IKIMONO_HITO;
                names[i] = HITO_NAMES[i];
                // 名前リストを表示
                textBox1.AppendText("" + i + ":" + HITO_NAMES[i] + "\r\n");
            }
            // 鳥を登録
            for (int i = 0; i < iToriCount; i++)
            {
                types[i + iHitoCount] = IKIMONO_TYPE.IKIMONO_TORI;
                names[i + iHitoCount] = TORI_NAMES[i];
                // 名前リストを表示
                textBox1.AppendText("" + (i + iHitoCount) + ":" + TORI_NAMES[i] + "\r\n");
            }
            // 魚を登録
            for (int i = 0; i < iSakanaCount; i++)
            {
                types[i + iHitoCount + iToriCount] = IKIMONO_TYPE.IKIMONO_SAKANA;
                names[i + iHitoCount + iToriCount] = SAKANA_NAMES[i];
                // 名前リストを表示
                textBox1.AppendText("" + (i + iHitoCount + iToriCount) + ":" + SAKANA_NAMES[i] + "\r\n");
            }
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            // 選択されているインデックスを取得
            int index = int.Parse(txtIndex.Text);

            // 挨拶
            textBox1.AppendText("私は" + names[index] + "です。\r\n");
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            // 選択されているインデックスを取得
            int index = int.Parse(txtIndex.Text);

            // 行動
            switch (types[index])
            {
                case IKIMONO_TYPE.IKIMONO_HITO:
                    textBox1.AppendText("テクテク\r\n");
                    break;
                case IKIMONO_TYPE.IKIMONO_TORI:
                    textBox1.AppendText("パタパタ\r\n");
                    break;
                case IKIMONO_TYPE.IKIMONO_SAKANA:
                    textBox1.AppendText("スイスイ\r\n");
                    break;
            }
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("人は"+iHitoCount+"人\r\n");
            textBox1.AppendText("鳥は" + iToriCount + "羽\r\n");
            textBox1.AppendText("魚は" + iSakanaCount + "匹\r\n");
            textBox1.AppendText("生き物は" + iIkimonoCount + "体。\r\n");
        }
    }
}
