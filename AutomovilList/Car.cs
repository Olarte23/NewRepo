namespace AutomovilList
{
    public class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Year} - {Color} - {Price:C2}";
        }

    }

    //// Retorna los carros de una marca
    //YourLinkedList<Car> GetBrand(string brand);

    //// Retorna los carros de entre el rango de modelos 
    //YourLinkedList<Car> GetModel(int lower, int upper);

    //// Retorna los carros de entre el rango de precios 
    //YourLinkedList<Car> GetPrice(decimal lower, decimal upper);

    //// Retorna los carros dependiendo de los siguientes criterios. 
    //// Nota si en los criterios de marca, color y modelo 
    //// se envía * significa que son todos 
    //YourLinkedList<Car> GetSeveralFilters(string brand, string model, string color, int minimunModel, decimal maximunPrice);

    //// Retorna el carro con menor precio y el carro con mayor 
    //// precio en un array
    //// En la posición 0 el carro con menor precio
    //// En la posición 1 el carro con mayor precio 
    //// Dada una llista de carros
    //Car[] GetMinMax(YourLinkedList<Car> list)

}