/**
El patrón Strategy permite que el cliente elija una estrategia entre varias sin alterar su código. 
*/
Personaje jugador = new Personaje();
// Atacar con espada
jugador.EstrategiaAtaque(new AtaqueEspada());
jugador.RealizarAtaque();
// Atacar con Arco
jugador.EstrategiaAtaque(new AtaqueArco());
jugador.RealizarAtaque();
