using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CHito
    {
        /** 人の人数*/
        private int count = 0;
        /** 自分の名前*/
        private string name = "";

        /** コンストラクター*/
        public CHito(string nm)
        {
            name = nm;
            count++;
        }

        /** 人数を返す*/
        public int getCount()
        {
            return count;
        }

        /** 挨拶*/
        public string hello()
        {
            return "私は" + name + "です。";
        }

        /** 行動*/
        public string action()
        {
            return "テクテク";
        }
    }
}
