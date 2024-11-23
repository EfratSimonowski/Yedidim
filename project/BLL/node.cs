using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    class node<T>
    {
        private T Value;
        private node<T> next;

        public node(T value)
        {
            this.Value = value;
        }
        public node(T value, node<T> next) : this(value)
        {
            this.next = next;
        }
        public T GetValue() { return Value; }
        public void setvalue(T value) { this.Value = value; }
        public node<T> Getnext() { return next; }
        public void Setnext(node<T> next) { this.next = next; }
        public bool Hasnext() { return next != null; }
        public override string ToString()
        {
            return Value.ToString();
        }
        public static void Add(node<TblVolanteer> list, TblVolanteer volanteer)
        {
            node<TblVolanteer> addpos = new node<TblVolanteer>(volanteer);
            node<TblVolanteer> pos = list;
            while (pos != null)
            {
                pos = pos.Getnext();
            }
            pos.Setnext(addpos);
        }
    }
}
