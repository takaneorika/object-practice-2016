namespace object_practice_2016
{
    class CSakana : CIkimono
    {
        /** 魚の数*/
        private static int count = 0;

        /** コンストラクター*/
        public CSakana(string nm)
            : base(nm)
        {
            count++;
        }

        /** 魚の数を返す*/
        public static int getCount()
        {
            return count;
        }

        /** 行動*/
        public string action()
        {
            return "スイスイ";
        }
    }
}
