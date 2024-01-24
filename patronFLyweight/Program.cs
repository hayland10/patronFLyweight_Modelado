namespace patronFLyweight {
    class Program { 
        static void Main(string[] args)
        {
            

            List<int> America = new List<int>(); 
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flywf = new CFlyweightFactory();
            int i = 0;

            i = flywf.Add("Hamburguesa");
            if (i != -1) {
                America.Add(i);
                Carnes.Add(i);
                Rapida.Add(i);
            }
           

            i = flywf.Add("Wisconsin cheese");
            if (i != -1)
            {
                America.Add(i);
                Ensaladas.Add(i);
            }
            

            i = flywf.Add("Antipasto");
            if (i != -1)
            {
                Italiana.Add(i);
                Ensaladas.Add(i);
            }
            

            i = flywf.Add("Tacos");
            if (i != -1)
            {
                Mexicana.Add(i);
                Carnes.Add(i);
                Rapida.Add(i);
            }
            

            i = flywf.Add("Minestrone");
            if (i != -1)
            {
                Italiana.Add(i);
                Sopas.Add(i);
            }
            

            i = flywf.Add("Coditos");
            if(i != -1)
            {
                Mexicana.Add(i);
                Sopas.Add(i);
            }
           

            i = flywf.Add("Nopales");
            if (i != -1) { 
            Mexicana.Add(i);
            Ensaladas.Add(i);
            }
           
            

            i = flywf.Add("Pizza");
            if (i != -1) { 
            Italiana .Add(i);
            Rapida .Add(i);
            }
            

            Console.WriteLine("----Comida Rapida-------");
            foreach (int n in Rapida) {
                CRecetacs receta = (CRecetacs)flywf.get_Item(n);
                receta.CalcularCosto();
                receta.Mostrar();
            }

            Console.WriteLine("----------------");

            foreach (int n in America)
            {
                CRecetacs receta = (CRecetacs)flywf.get_Item(n);
                receta.CalcularCosto();
                receta.Mostrar();
            }
            Console.WriteLine("----------------");





        }
    
    }


}