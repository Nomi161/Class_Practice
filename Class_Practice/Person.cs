using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Person
    {
        // 変数
        protected string name;                // キャラの名前
        protected int level;                  // レベル
        protected int hp;                      // 体力
        protected string info = "ただの村人";  // キャラ属性の特徴

        // 実体化した際に基本的な情報は入るように設計
        // 引数なしコンストラクタ
        public Person()
        {
            name = "イッパンジーン";
            level = 1;
            hp = 100;
        }

        // 引数ありコンストラクタ
        public Person(string n, int h)
        {
            name = n;
            level = 1;
            hp = h;
        }

        // 命令(メソッド)
        // そのキャラの情報を表示するメソッド
        public void InfoDisplay()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("名前：" + name);
            Console.WriteLine("レベル：" + level);
            Console.WriteLine("体力：" + hp);
            Console.WriteLine(info);
        }

        // メンバ変数に干渉するためのメソッド達
        // 名前を変更するメソッド
        public void NameSet(string value)
        {
            name = value;
        }

        // HPを変更するメソッド
        public void HPSet(int value)
        {
            hp = value;
        }

        // メンバ変数に干渉するためのプロパティ
        // Nameという言い方ならnameに干渉できるように設計
        public string Name
        {
            get { return name; }    // 読み取り機能 本来不干渉のnameの値をリターン(ゲット)します
            set { name = value; }   // 書き込み機能 本来不干渉のnameに「Nameに代入された値」を代入
        }

        // 技をひとつ公表するメソッド
        // オーバーロードして引数あり、引数なし 2種類作っておく
        // 継承先でオーバーライドされるメソッドの予定なのでvirtual宣言も加えておく
        public virtual void AttackInfo(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("技：必殺の右ストレート");
                    break;
                default:
                    Console.WriteLine("技：渾身のタックル");
                    break;
            }
        }

        public virtual void AttackInfo()
        {
            Console.WriteLine("技：渾身のタックル");
        }
    }
}
