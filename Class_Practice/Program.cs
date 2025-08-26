using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 自作したPersonクラス(Person型)の実体化(インスタンス)
            Person p1 = new Person("ムラビート", 150);
            p1.InfoDisplay();   // p1にメソッドを使わせてみる
            p1.AttackInfo();    // 技名を調べてみる(引数なし)

            // 自作したPersonクラス(Person型)の実体化(インスタンス)
            Person p2 = new Person();
            p2.NameSet("マチビート");
            p2.HPSet(180);
            p2.InfoDisplay();   // p1にメソッドを使わせてみる
            p2.AttackInfo(1);   // 技名を調べてみる(引数なし)

            // 自作したPersonクラス(Person型)の実体化(インスタンス)
            Person p3 = new Person();
            p3.InfoDisplay();   // p1にメソッドを使わせてみる
            p3.AttackInfo(99);   // 技名を調べてみる(引数なし)

            //////////////////////////////////////////////////////////
            ///

            // Personを継承したWarriorを試してみる
            Warrior w1 = new Warrior(); /// 引数なしでインスタンス
            w1.InfoDisplay();   // Personのメソッドを使ってみる
            w1.AttackInfo(2);   // オーバーライドしたメソッドを使ってみる
            string ikigomi = w1.Special();  // Specialメソッドで得た値を変数に代入
            Console.WriteLine(ikigomi);

            Person w2 = new Warrior("イモスケ", 800);
            w2.InfoDisplay();
            w2.AttackInfo(3);
        }
    }
}
