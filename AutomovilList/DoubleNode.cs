
namespace AutomovilList
{
    public class DoubleNode<T>
    {
        public Car? Data { get; set; }

        public DoubleNode<T>? Left { get; set; }

        public DoubleNode<T>? Right { get; set; }

        public DoubleNode(Car data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}