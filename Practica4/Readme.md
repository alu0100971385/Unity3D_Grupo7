![funcionamiento del juego](Gifs/funcionamiento.gif)
 
 Esta práctica la hemos hecho en conjunto:
 
 Jiaqi Jin
 
 Daniel Suárez Labena
 
 Daniel Eduardo González Marrero
 
 
 Hemos intentado enfocar el desarrollo a lo que queremos realizar en nuestro videojuego, en el cual el objetivo del jugador es intentar conseguir la mayor cantidad de monedas posibles. Estas monedas incrementan su poder y por le contrario, las momias lo disminuyen.
 
 
 Para empezar hemos hecho el script de movimiento de "Moonboy", nuestro protagonista, Que no dista en nada del que hemos hecho en la anterior práctica. Reconoce WASD y las teclas de dirección.
 
 
 Hemos creado un segundo script que le hemos asociado al player principal. En este script se crea una variable que es el contador de poder. El asset que hemos usado para el player principal ya viene con un colisionador asociado, por lo tanto solo nos tuvimos que centrar en los demás objetos. Hemos creado la función "OnCollisionEnter", y si reconoce que el objeto con el que colisiona es del tag "coin", aumenta el contador de poder. Si por el contrario, es del tag "mummy", lo disminuye. Si el poder es 0, no lo puede disminuir más.
 
 
 Por último, le hemos acoplado un foco a modo de linterna al jugador principal, y lo hemos hecho "hijo" del mismo. Luego hemos creado un script spotLightController en el que creamos una variable. En unity, asociamos esa variable al gameobject del foco y gracias a la propiedad "enabled" podemos apagarla y encenderla utilizando la letra F.
