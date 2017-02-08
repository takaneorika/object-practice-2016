using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CTori : CIkimono
    {
        /** 鳥の数*/
        private static int count = 0;

        /** コンストラクター*/
        public CTori(string nm)
            : base(nm)
        {
            count++;
        }

        /** 鳥の数を返す*/
        public static int getCount()
        {
            return count;
        }

        /** 行動*/
        public override string action()
        {
            return "パタパタ";
        }
    }
}
