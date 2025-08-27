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
            w1.items.Add("薬草");
            w1.items.Add("毒消し");
            w1.items.Add("煙玉");

            Console.WriteLine(w1.Name + "の所持品");
            
            for (int i = 0; i <w1.items.Count; i++)
            {
                Console.WriteLine(w1.items[i]);
            }

            Person w2 = new Warrior("イモスケ", 800);
            w2.InfoDisplay();
            w2.AttackInfo(3);
        }
    }
}
