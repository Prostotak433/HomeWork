﻿using System;

namespace Task_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Collection<T>
    {
        T[] data;   // массив с данными
        public Collection()
        {
            data = new T[0];
        }
        // добавление данных
        public void Add(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            newData[data.Length] = item;
            data = newData;
        }
        // удаление данных - удаляем первое вхождение элемента при его наличии
        public void Remove(T item)
        {
            // находим индекс элемента
            int index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            // удаляем элемент по индексу
            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];
                for (int i = 0, j = 0; i < data.Length; i++)
                {
                    if (i == index) continue;
                    newData[j] = data[i];
                    j++;
                }
                data = newData;
            }
        }
        // получение элемента по индексу
        public T GetItem(int index)
        {
            if (index > -1 && index < data.Length)
            {
                return data[index];
            }
            else
                throw new IndexOutOfRangeException();
        }
        public int Count()
        {
            return data.Length;
        }
    }
}
