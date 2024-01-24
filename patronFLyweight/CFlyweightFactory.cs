using System;
using System.Collections.Generic;

namespace patronFLyweight
{
    class CFlyweightFactory
    {
        private List<FlyWeight> _flyweightList = new List<FlyWeight>();
        private int cont = 0;

        public int conteo { get => cont; set => cont = value; }  // Corregido el nombre de la propiedad

        public int Add(string nombre)
        {
            bool existe = false;

            foreach (FlyWeight f in _flyweightList)
            {
                if (f.ObtenerNombre() == nombre)
                {
                    existe = true;
                    break;  // Agregado para salir del bucle una vez que se encuentra el objeto
                }
            }

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                CRecetacs miReceta = new CRecetacs();
                miReceta.ColcaNombre(nombre);
                _flyweightList.Add(miReceta);
                cont = _flyweightList.Count;
                return cont;  // Cambiado para devolver el nuevo conteo después de agregar
            }
        }

        public FlyWeight get_Item(int index)
        {
            if (index >= 0 && index < _flyweightList.Count)
            {
                return _flyweightList[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango");
            }
        }
        
    }
}
