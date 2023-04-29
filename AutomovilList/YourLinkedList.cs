using System;
namespace AutomovilList

{
    public class YourLinkedList<T>
    {
        private DoubleNode<Car>? _first;

        private DoubleNode<Car>? _last;
        

        public YourLinkedList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public int Count { get; set; }
        public Car Data { get; set; }
        public AutomovilList.Car Brand { get; set; }  
        public bool IsEmpty => Count == 0;


        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }
        public void Add(Car item)
        {
            var node = new DoubleNode<Car>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }
        public string GetBrand(string brand)
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                if (brand.Equals(pointer.Data?.Brand))
                {
                    output += $"{pointer.Data}\n";
                }                
                pointer = pointer.Right;
            }
            return output;
        }
        public string GetYear(int lower, int upper)
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data?.Year > lower && pointer.Data?.Year < upper)
                {
                    output += $"{pointer.Data}\n";
                }
                pointer = pointer.Right;
            }
            return output;

        }
        public string GetPrice(decimal lower, decimal upper)
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data?.Price > lower && pointer.Data?.Price < upper)
                {
                    output += $"{pointer.Data}\n";
                }
                pointer = pointer.Right;
            }
            return output;

        }
        public string GetSeveralFilters(string brand, string model, string color, int minimunYear,
                                                        decimal maximunYear)
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                if (brand.Equals(pointer.Data?.Brand) && model == pointer.Data.Model && color == pointer.Data.Color &&
                    pointer.Data.Year >= minimunYear && pointer.Data.Year <= maximunYear)
                {
                    output += $"{pointer.Data}\n";
                }
                pointer = pointer.Right;
            }
            return output;
        }
        public Car[] ToArray()
        {
            var array = new Car[2];
            int i = 0;
            var pointer = _first;
            while (pointer != null)
            {
                array[i] = pointer.Data!;
                
                pointer = pointer.Right;

                //if (array[i] < pointer.Data.Price)
                //{

                //}
            }
            return array;
        }

    }
}


