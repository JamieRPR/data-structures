using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class LinkGen<T>
    {
        private T data;
        private LinkGen<T> next;

        public LinkGen(T item)
        {
            data = item;
            next = null;
        }
        public LinkGen(T item, LinkGen<T> list)
        {
            data = item;
            next = list;
        }
        public LinkGen<T> Next
        {
        }

        public T Data
        {
        }
    }

}
