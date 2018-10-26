## UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO
   ## Ténicas de programación 🤷‍♂️
 ## Ordenamiento de inserción directa 😢
   ## Jimenez Arellano Carlos

---
  # Ordenamiento de inserción directa
    
Este método recibe también el se conoce con el nombre de "Método de la baraja". 
Es usado por los jugadores de cartas cuando ordenan éstas, de ahí el nombre. 

---
La idea central de este algoritmo consiste en realizar varias iteraciones sobre un arreglo.
En cada iteración se analiza un elemento, y se intenta encontrar su orden entre todos los elementos del arreglo.

---

1. El primer elemento A[0] se considera ordenado; es decir, la lista inicial consta de un
elemento.
2. Se inserta A[1] en la posición correcta, delante o detrás de A[0], dependiendo de que sea
menor o mayor.

--- 

3. Por cada iteración i (desde i=1 hasta n-1) se explora una sublista buscando la posición correcta de inserción; a la vez se mueve a la derecha en la sublista una posición todos los elementos mayores que el elemento a insertar A[i], para dejar vacía esa posición.
4. Insertar el elemento a la posición correcta.

---
![Flux Explained](http://2.bp.blogspot.com/-MUDQRWsUSec/UeVTVcx0NPI/AAAAAAAABUU/Mx2kc5b_knk/s1600/insercion+directa+c%23+1.jpg)

---
## Ejemplo

### Arreglo: 15 67 08 16 44 27 12 35


PRIMERA ITERACIÓN

A[1]<A[0] (67<15) no hay intercambio

A: 15 67 08 16 44 27 12 35 

---

SEGUNDA ITERACIÓN 

A[2]<A[1] (08<67) sí hay intercambio

A[1]<A[0] (08<15) sí hay intercambio

A: *08 *15 *67 16 44 27 12 35 

---

## Análisis de eficiencia de Inserción directa

#• Comparaciones:

Cmin= n-1

Cmáx =(n2-n)/2

Cmed=(n2*n-2)/4
---
## • Intercambios o Movimientos:

Mmin= 0

Mmáx =(n2-n)/2

Mmed=(n2-n)/4

---
# Codigo 

```
        int[] datos = { 5, 3, 14, 20, 8, 9, 1 };
        int i, j, datoTemporal;
        int n = 7; // Numero de datos

        // INSERCION DIRECTA:
        // (Comparar cada elemento con los anteriores -que ya están ordenados- 
        // y desplazarlo hasta su posición correcta).
        // Para i=2 hasta n
        //      j=i-1
        //      mientras (j>=1) y (A[j] > A[j+1])
        //          Intercambiar ( A[j], A[j+1])
        //          j = j - 1
        Console.WriteLine("\n Espere en la linea... ");
        Console.WriteLine("\n ");
        int[] datos3 = { 5, 3, 14, 20, 8, 9, 1 };
        for (i = 1; i < n; i++)
        {
            foreach (int dato in datos3)  // Muestro datos
                Console.Write("{0} ", dato);
            Console.WriteLine();

            j = i - 1;
            while ((j >= 0) && (datos3[j] > datos3[j + 1]))
            {
                datoTemporal = datos3[j];
                datos3[j] = datos3[j + 1];
                datos3[j + 1] = datoTemporal;
                j--;
            }

        }
        Console.Write("\n Ya bien ordenado paps:");

        foreach (int dato in datos3)  // Muestra datos finales
            Console.Write("{0} ", dato);
        Console.WriteLine();
        Console.ReadKey();
   ```
---

## Ventajas.
* Fácil implemetnación
* Requerimientos mínimos de memoria

## Desventajas 
* Lento 
* Realizanumerosas comparaciones 

--- 
# Eso, eso, eso es todo amigos. 
🙉🙉🙊
---
## Fuentes consultadas
* file:///C:/Users/alumnos/Downloads/A06.pdf
* http://mapaches.itz.edu.mx/~mbarajas/edinf/Ordenamiento.pdf
* https://es.slideshare.net/tavo_3315_/insercin-directa-algoritmos-41637040
