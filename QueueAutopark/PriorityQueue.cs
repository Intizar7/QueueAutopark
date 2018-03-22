using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
   public class PriorityQueue : IQueueCar 
    {
        private Car[] Queue;
        private int front= -1;
        private int size = 0;
        private int count = 0;

        //ben burayı yorum satırına aldım

        //public PriorityQueue(int size)
        //{
        //    this.size = size;
        //    Queue = new Car[size];
        //}

        public void Insert(Car c)
        {
            if(count== size)
            {
                throw new Exception("Queue is full");
            }
            if (IsEmpty())
            {
                front++;
                Queue[front] = c;
                count++;
            }
            else
            {
                int i;
                for (i =count-1; i >=0; i--)
                {
                    if ((int)c.WaitingPeriod >(int)Queue[i].WaitingPeriod)
                    {
                        Queue[i + 1] = Queue[i];
                    }
                    else
                    {
                        break;
                    }
                }
                Queue[i + 1] = c;
                front++;
                count++;
            }
        }

        public Car Remove()
        {
            if(this.IsEmpty())
            {
              throw new NotImplementedException();
            }
            Car temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public Car Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

    }
}
