using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab3
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Dictionary<int, Cart> carts = new Dictionary<int, Cart>();
            Goods g1 = new Goods(1001, "볼펜", 2000);
            Goods g2 = new Goods(1002, "연필", 500);
            Goods g3 = new Goods(1003, "딸기", 6000);
            carts.Add(1, new Cart(g1, 2));
            carts.Add(2, new Cart(g2, 3));
            carts.Add(3, new Cart(g3, 2));

            Console.WriteLine("CartNo\t 상품코드\t 상품명\t 단가\t 수량\t 합계금액");
            Console.WriteLine("------------------------------------------------------------");
            int cno = 1;
            foreach (KeyValuePair<int, Cart> d in carts)
            {
                //Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
                Console.WriteLine(cno++ + "\t  " + d.Value.goods.goodsno + "\t\t  " + d.Value.goods.gname
                    + "\t " + d.Value.goods.danga + "\t " + d.Value.count + "\t " + d.Value.sum);
            }
            Goods g4 = new Goods(1004, "공책", 3000);
            carts.Add(4, new Cart(g4, 5));
            carts.Remove(3);

            cno = 1;
            Console.WriteLine("------------------------------------------------------------");
            foreach (KeyValuePair<int, Cart> d in carts)
            {
                //Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
                Console.WriteLine(cno++ + "\t  " + d.Value.goods.goodsno + "\t\t  " + d.Value.goods.gname
                    + "\t " + d.Value.goods.danga + "\t " + d.Value.count + "\t " + d.Value.sum);
            }
        }
    }
}
