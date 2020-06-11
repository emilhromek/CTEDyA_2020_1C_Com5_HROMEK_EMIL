//Este el metodo altura, que va en la clase ArbolGeneral

public int altura() {

            if (this.esHoja())
            {
                return 0;
            }

            else
            {
                int alturaMax = 0;
                foreach (var hijo in getHijos())
                    if (hijo.altura() > alturaMax)
                        alturaMax = hijo.altura();
                return alturaMax + 1;
            }
        }
