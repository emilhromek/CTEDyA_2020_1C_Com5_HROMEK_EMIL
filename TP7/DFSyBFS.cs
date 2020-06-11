        public void DFS(Vertice<T> origen)
        {
            bool[] visitados = new bool[vertices.Count];

            DFSUtil(origen, visitados);
        }

        public void DFSUtil(Vertice<T> origen, bool[] visitados)
        {
            visitados[origen.getPosicion() - 1] = true;

            Console.WriteLine(origen.getDato() + " ");

            foreach (Arista<T> a in origen.getAdyacentes())
            {
                if (visitados[a.getDestino().getPosicion() - 1] != true)
                {
                    DFSUtil(a.getDestino(), visitados);
                }
            }


        }



        public void BFS(Vertice<T> origen) {

            Cola<Vertice<T>> cola = new Cola<Vertice<T>>();

            bool[] visitados = new bool[vertices.Count];

            cola.encolar(origen);

            visitados[origen.getPosicion() - 1] = true;

            while (!cola.esVacia())
            {
                Vertice<T> auxiliar = cola.desencolar();

                Console.WriteLine(auxiliar.getDato() + " ");

                foreach (Arista<T> a in auxiliar.getAdyacentes())
                {
                    if (visitados[a.getDestino().getPosicion() - 1] != true)
                    {
                        cola.encolar(a.getDestino());

                        visitados[a.getDestino().getPosicion() - 1] = true;
                    }
                }


            }


        }
