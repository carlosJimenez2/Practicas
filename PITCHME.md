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
