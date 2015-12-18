using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA9_JingLi
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player = new Players();
            player.GenerateHand();
            Stack<string> card = new Stack<string>();
            for (int i = 0; i < 52; i++)
            {
                // putting face in one array and putting suit in another array and also put together in one array

                card.Push(player.hand[i].Face.ToString() +" of " + player.hand[i].Suits.ToString()); 

            }
            while(card.Count>0)
            {
                Console.WriteLine(card.Pop());
            }
           /* foreach (string i in card)
                Console.WriteLine(i);*/
            Console.ReadKey();
        }
    }
}
