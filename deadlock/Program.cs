using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace deadlock
{
    class Program
    {
        private static object obj_lock1 = new object();
        private static object obj_lock2 = new object();
        private static int count = 0;

        //本示例用来展示死锁
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();

            while (true)
            {
                int pre_count = count;
                Thread.Sleep(0);
                if (pre_count == count)
                {
                    Console.WriteLine("死锁！count:{0}", count);
                }
            }
        }

        private static void Thread1()
        {
            while (true)
            {
                //Monitor.Enter(obj_lock2);
                //Monitor.Enter(obj_lock1);
                Monitor.Enter(obj_lock1);
                Monitor.Enter(obj_lock2);
                count++;

                Monitor.Exit(obj_lock1);
                Monitor.Exit(obj_lock2);

            }
        }

        private static void Thread2()
        {
            while (true)
            {
                Monitor.Enter(obj_lock1);
                Monitor.Enter(obj_lock2);

                count++;

                Monitor.Exit(obj_lock1);
                Monitor.Exit(obj_lock2);

            }
        }
    }
}
