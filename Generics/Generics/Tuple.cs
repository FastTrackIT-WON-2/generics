namespace Generics
{
    public class Tuple<T1, T2>
    {
        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }
    }

    public class Tuple<T1, T2, T3> : Tuple<T1, T2>
    {
        public T3 Item3 { get; set; }
    }
}
