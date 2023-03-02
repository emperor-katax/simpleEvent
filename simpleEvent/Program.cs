using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleEvent {
    internal class Program {
        static void Main(string[] args) {

            // from Cat
            //Cat ct = new Cat();
            //ct.CatAttention_Handler += ReportCat;
            //ct.Attracted();

            // from CatOwner
            CatOwner co = new CatOwner();
            co.Cat_01.CatAttention_Handler += ReportCat;
            co.Cat_01.CatAttention_Handler += KO;
            co.Cat_01.CatAttention_Handler += PrintGameDetail;
            //co.Cat_02.CatAttention_Handler += ReportCat;
            co.CheckCat(1);
            co.Cat_01.CatAttention_Handler += KO;
            co.Cat_01.CatAttention_Handler -= ReportCat;
            co.Cat_01.CatAttention_Handler -= PrintGameDetail;
            co.CheckCat(1);


            Console.ReadLine();
        }
        static void ReportCat(object sender, EventArgs er) {//love this test clifff mark was here
            Console.WriteLine("Cat is here ... !");// cats love meowwing
        }        
        static void KO(object sender, EventArgs er) {
            Console.WriteLine("KOe ... !");
        }        
        static void PrintGameDetail(object sender, EventArgs er) {
            Console.WriteLine("Cat  ,, , , ,, ,  ... !");
        }
    }
}
