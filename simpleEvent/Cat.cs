using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleEvent {   
    class Cat {
        public EventHandler CatAttention_Handler;

        public Cat() { }

        public void Attracted() {
            Console.WriteLine(" meaooowwwwwwHHHH  ... !");
            Console.WriteLine(" meaooowwwwwwHHHH  ... !");
            Console.WriteLine(" meaooowwwwwwHHHH  ... !");
            Console.WriteLine(" meaooowwwwwwHHHH  ... !");
            Console.WriteLine(" hihihihihihihihi  ... !");
            CatAttention_Handler?.Invoke(this, EventArgs.Empty);
        }

    }
}
