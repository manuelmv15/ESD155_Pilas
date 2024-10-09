namespace Pilas
{
    class Pila<T>
    {
        private Nodo<T> cima;     

        public Pila()
        {
            cima = null;          
        }

        
        public void Apilar(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(); 
            nuevoNodo.info = valor;            
            nuevoNodo.siguiente = cima;        
            cima = nuevoNodo;                  
        }

        // Eliminar el elemento en la cima de la pila (desapilar)
        public void Desapilar()
        {
            if (cima == null)
            {
                Console.WriteLine("Pila vacía");
            }
            else
            {
                cima = cima.siguiente;
            }
        }

        // Mostrar todos los elementos de la pila
        public void Mostrar()
        {
            if (cima == null)
            {
                Console.WriteLine("Pila vacía");
            }
            else
            {
                Nodo<T> puntero = cima; 
                while (puntero != null) 
                {
                    Console.WriteLine($"{puntero.info}"); 
                    puntero = puntero.siguiente; 
                }
            }
        }

            // Acceder al elemento en la cima de la pila
            public T acceder(int indx)
            {
                Nodo<T> puntero = cima;
                int i = 0;
                while (puntero != null && i < indx)
                {
                    puntero = puntero.siguiente;
                    i++;
                }
                if (puntero != null)
                {
                    return puntero.info;
                }
                else return default(T);

            }
        }

}