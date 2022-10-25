# Unity3D
Curso de Unity 3D

## NOTAS

En la carpeta WIP está todo el material pendiente de terminar para que el resultado sea el esperado.

## GDD básico:

Personajes/Elementos:

    • Escenario: Fondo monocromático o fondo de interior escuela
    • Jugador
    • Elementos de escenario: sillas y mesas apiladas
    • Hoja de papel
    • Bolas 
        ◦ De resultados (4 bolas blancas)
      	1 bola con el resultado correcto
              3 bolas con resultados incorrectos
          Bolas rojas de "multiplicar x 0"
    • Cerebros

Canvas:

    • Marcador: Mostrar los puntos conseguidos por el jugador
	

Mecánicas de esos personajes/Elementos:
	
	Jugador:

    • Va hacia derecha
    • Va hacia izquierda
    • El personaje gira su posición dependiendo hacia dónde se dirija.
    • Salta
    • Sube encima de las sillas o mesas


	Que hace el jugador:

    • Recoge bolas de resultados
    • Evita bolas de resultados incorrectos
    • Evita bolas rojas
    • Recoge cerebros
      

	Sillas y mesas:
	
    • Son las plataformas de juego, tendrán un collider

	Hoja de papel:

    • Problema matemático a resolver por el jugador
    • Aparece al principio del juego
    • Desaparece cuando se ha acertado el resultado del problema.
    • Aparece el siguiente cuando se ha acertado el anterior.

	Bolas
      
    • Aparecer
    • Moverse
    • Chocar con otra bola
    • Chocar con la superficies
    • Chocar con la niña

       Las 4 bolas en el escenario cada vez que aparece un problema moviéndose, chocándose con la superficies y rebotando.

		Bola con el resultado correcto

    • Si es tocada la primera, suma 200 puntos y desaparece
    • Si es tocada la segunda, suma 100 puntos y desaparece
    • Si es tocada la tercera, suma 50 puntos y desaparece
    • Al tercer fallo explota y desaparece

		Bolas con el resultado incorrecto

    • Si es tocada por el jugador, explota y desaparece
      

	Bolas rojas de "multiplicar x 0"

    • Aparecen en el escenario aleatoriamente cada vez mas rápido
    • Si es tocada por el jugador resta 25 puntos, explota y desaparece


	Cerebros

    • Aparecen aleatoriamente por la escenario.
    • Si es tocado por el jugador suma 25 puntos y desaparece.
    • Si no es tocado se mueve por la escena chocando con las superficies y rebotando.
      
Controladas por el jugador/Máquina (lógica de juego)

	Jugador
	
    • Con las teclas A / flecha izquierda se moverá hacia la izquierda
    • Con las teclas D / flecha derecha se moverá hacia la derecha
    • Con la tecla espacio, saltará



