# Space Shooter de Unity 🚀

¡Bienvenido a **Space Shooter**! Este es un juego simple de disparos en el espacio, desarrollado en Unity. Controlas una nave que debe eliminar enemigos (hamburguesas espaciales 🍔) mientras evitas colisiones.

## Características del Proyecto

- **Control de Nave**: Usa las teclas de dirección para mover la nave en diferentes direcciones.
- **Disparo de Bala**: La nave dispara balas cuando presionas la barra espaciadora.
- **Enemigos**: Las hamburguesas aparecen y se mueven hacia la nave. La nave puede destruirlas al dispararles.
- **Colisiones**: Si una hamburguesa toca la nave, el juego se pausa automáticamente.
- **Script de Movimiento**: La nave y las balas están controladas por scripts en C#.

## Instalación y Ejecución

Sigue estos pasos para ejecutar el proyecto localmente:

1. Clona el repositorio en tu máquina local:

   ```bash
   git clone https://github.com/tu-usuario/space-shooter.git
2. Abre Unity Hub y selecciona Abrir proyecto.
3. Navega hasta la carpeta del proyecto clonado y selecciónalo.
4. Una vez cargado en Unity, abre la escena principal para comenzar a jugar.
5. Controles del Juego
    Mover la nave: Usa las teclas de flecha (⬅️➡️⬆️⬇️) o WASD.
    Disparar: Presiona la barra espaciadora (Space).

Archivos y Estructura del Proyecto
Assets/: Contiene todos los recursos y scripts de Unity, incluyendo los prefabs y scripts.
Scripts:
PlayerController.cs: Controla el movimiento y disparo de la nave.
BalaScript.cs: Controla el comportamiento de las balas disparadas.
HamburguesaScript.cs: Controla el movimiento de las hamburguesas enemigas y la colisión con la nave.
Prefabs:
Bala1: Prefab de la bala.
Hamburguesa: Prefab del enemigo (hamburguesa).
Requisitos
Unity: Version 2021.3 o superior.
Git: Si deseas clonar y versionar el proyecto.
Notas Adicionales
Gitignore: El archivo .gitignore está configurado para ignorar archivos generados automáticamente por Unity, manteniendo el repositorio limpio.
Contribución: Si deseas contribuir, puedes hacer un fork del repositorio y enviar tus mejoras a través de un Pull Request.
