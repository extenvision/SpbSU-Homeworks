﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._4
{
    class Stack : IStack
    {
        class StackElement
        {
            public StackElement pNext { get; private set; } 
            public object value { get; private set; }

            public StackElement(object value, StackElement pNext)
            {
                this.pNext = pNext;
                this.value = value;
            }
        }

        private StackElement top;
        private int size;

        /// <summary>
        ///  Добавление элемента
        /// </summary>
        public void Push(object value)
        {
            StackElement newElement = new StackElement(value, this.top);
            this.top = newElement;
            this.size++;
        }

        /// <summary>
        ///  Чтение верхнего элемента
        /// </summary>
        public object Top()
        {
            return this.top.value;
        }

        /// <summary>
        ///  Проверка на пустоту
        /// </summary>
        public bool IsEmpty()
        {
            return this.top == null;
        }

        /// <summary>
        ///  Удаление последнего элемента
        /// </summary>
        public object Pop()
        {
            if (IsEmpty())
            {
                return 1;
            }

            object result = this.top.value;
            this.top = this.top.pNext;
            this.size--;
            return result;
        }

        /// <summary>
        ///  Возвращает размер стека
        /// </summary>
        public int Size()
        {
            return this.size;
        }
    }
}
