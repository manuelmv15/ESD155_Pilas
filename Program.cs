namespace Pilas
{
    internal class program{
 static void Main(string[] args)
        {
            Pila<int> miPila = new Pila<int>(); 

            
            miPila.Apilar(10);
            miPila.Apilar(20);
            miPila.Apilar(30);

            
            Console.WriteLine("Elementos en la pila:");
            miPila.Mostrar();

            
            Console.WriteLine($"Elemento en la cima: {miPila.acceder(1)}"); // Debe mostrar 30

            // Desapilar un elemento
            miPila.Desapilar();

            // Mostrar elementos de la pila después de desapilar
            
            miPila.Mostrar();

            // Acceder al elemento en la cima después de desapilar
            Console.WriteLine($"Elemento en la cima: {miPila.acceder(0)}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cola");
        }
        }
}