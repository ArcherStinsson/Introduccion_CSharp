# INTRODUCCION A C#

## EJERCICIO 1
En el ejercicio 1 se nos pide que a 3 cubos se les asigne un color y un tama�o diferente a cada uno. 
Luego hacer que uno de los cubos cambie el tama�o y que otro cambie la posici�n. 

![Captura del c�digo](Imagenes/Ejercicio1final.png)

Cre� como variables el color del cubo indicando que por defecto sea rojo y una variable float para el tama�o. As�, tambi�n coloque variables apra el rigidbody, transform y renderer. En Strat obtuve as� el color rojo y el tama�o que le puse por defecto.

Para cambiarlo, cre� acciones para el transform y el rigidbody. Active el transform de uno de los cubos en el inspector, y a otro cubo le hice lo mismo pero con el rigidbody.Si el tama�o es menos al valor de la variable de tama�o m�ximo que puse, este crecer� hasta ese tama�o. Al cubo con rigidbody activado simplemente lo desplac� a la derecha con un valor de 10.

![Gif](Imagenes/Ejercicio1.gif)







