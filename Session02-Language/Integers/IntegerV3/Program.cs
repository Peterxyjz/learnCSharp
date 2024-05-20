namespace IntegerV3
{
    //IN OUT REF
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3979;
            PlayRef(ref n);
            Console.WriteLine(n);

        }

        //REF: tao không hứa sẽ trả về; luôn phải có defaul khi dùng ref
        static void PlayRef(ref int x)
        {
            x = 6789;
        }
    }

}
