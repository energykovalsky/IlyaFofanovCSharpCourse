namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);

        //void Clear();
    }

    //public abstract class IBaseCollection
    //{
    //    public abstract void Add(object obj);
    //    public abstract void Remove(object obj);

    //    public virtual void Clear()
    //    {
    //        Console.WriteLine("Default implementation");
    //    }
    //}

    public class BaseList : IBaseCollection
    {
        private readonly object[] items;
        private int count = 0;
        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
