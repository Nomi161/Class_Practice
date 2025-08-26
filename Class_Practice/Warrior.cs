using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Warrior : Person
    {
        // コンストラクタ
        public Warrior(string n, int h)
        {
            name = n;
            hp = h;
            info = "強い剣士";
        }

        // コンストラクタ(引数なし)
        public Warrior() : this("タンジーロ", 500) { }

        // 継承したメソッドをオーバーライド(上書き)して違う機能に書き換える
        public override void AttackInfo(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("技：縦斬り");
                    break;
                case 2:
                    Console.WriteLine("技：横斬");
                    break;
                case 3:
                    Console.WriteLine("技：連続斬り");
                    break;
                default:
                    Console.WriteLine("みねうち");
                    break;
            }
        }

        // 引数なしメソッドも継承して上書きするオーバーライド
        public override void AttackInfo()
        {
            Console.WriteLine("技：みねうち");
        }

        // まったく新しい独自の命令(戻り値ありメソッド)
        public string Special()
        {
            string message = "家族を絶対に守る！";
            return message; // 変数messageの中身を戻す
        }
    }
}
