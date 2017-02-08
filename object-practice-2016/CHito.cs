using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CHito : CIkimono
    {
        /** 人の人数*/
        private static int count = 0;

        /** コンストラクター*/
        public CHito(string nm) : base(nm)
        {
            count++;
        }

        /** 人数を返す*/
        public static int getCount()
        {
            return count;
        }

        /** 行動*/
        public string action()
        {
            return "テクテク";
        }
    }
}
