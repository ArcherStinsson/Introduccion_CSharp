# INTRODUCCION A C#

## EJERCICIO 1
En el ejercicio 1 se nos pide que a 3 cubos se les asigne un color y un tamaño diferente a cada uno. 
Luego hacer que uno de los cubos cambie el tamaño y que otro cambie la posición. 

![Captura del código](Imagenes/Ejercicio1final.png)

Creé como variables el color del cubo indicando que por defecto sea rojo y una variable float para el tamaño. Así, también coloque variables apra el rigidbody, transform y renderer. En Strat obtuve así el color rojo y el tamaño que le puse por defecto.

Para cambiarlo, creé acciones para el transform y el rigidbody. Active el transform de uno de los cubos en el inspector, y a otro cubo le hice lo mismo pero con el rigidbody.Si el tamaño es menos al valor de la variable de tamaño máximo que puse, este crecerá hasta ese tamaño. Al cubo con rigidbody activado simplemente lo desplacé a la derecha con un valor de 10.

![Gif](Imagenes/Ejercicio1.gif)







