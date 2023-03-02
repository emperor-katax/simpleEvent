using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace simpleEvent {
    class CatOwner {
        public Cat Cat_01 = new Cat();
        public Cat Cat_02 = new Cat();

        public CatOwner() { }

        public void CheckCat(int i) {
            switch (i) {
                case 1:
                    Cat_01.Attracted();
                    break;
                case 2:
                    Cat_02.Attracted();
                    break;
                default:
                    // .. 
                break;
            }
        }
    }
}
