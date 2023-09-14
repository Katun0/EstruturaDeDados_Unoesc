using System;

namespace QueueClass
{
    public class Queue
    {
        static readonly int MAX = 4;
        int top = -1;
        int[] queue = new int[MAX];

        public bool IsEmpty()
        {
            return (top < 0);            
        }

        public bool EnQueue(int data)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Queue Overflow");
                return false;
            }
            top += 1;
            queue[top] = data;
            return true;
        }

        public int DeQueue()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow");
                return 0;
            }

            int valor = queue[top];            
            top--;

            return valor;
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine($"O topo da fila é: {queue[top]}" );
        }

        public void PrintQueue()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine("Itens da Fila:");
            for(int i = top; i >= 0; i-- )
            {
                string texto = $"Queue[{ queue[i] }]";
                Console.WriteLine(texto);
            }
        }
    }
}