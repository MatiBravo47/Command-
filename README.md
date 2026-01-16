# Patrón Command en C#

Este repositorio contiene una implementación simple del **patrón de diseño Command** utilizando **C#** y una aplicación de consola.

El ejemplo simula un **control remoto** que ejecuta distintas acciones sobre un **televisor** sin conocer los detalles de su implementación.

---

## 🧠 ¿Qué es el patrón Command?

El patrón Command convierte una solicitud en un objeto independiente que contiene toda la información sobre la acción a realizar.

Este patrón permite:
- Desacoplar el emisor de la acción del receptor
- Cambiar comandos dinámicamente
- Agregar nuevos comandos sin modificar el código existente

---

## 📺 Ejemplo del proyecto

- **Televisor**  
  Es el receptor que conoce cómo realizar las acciones reales (encender, apagar, subir volumen).

- **ICommand**  
  Interfaz que define el método `Ejecutar()` para todos los comandos.

- **EncenderTVCommand / ApagarTVCommand / SubirVolumenCommand**  
  Comandos concretos que encapsulan una acción sobre el televisor.

- **ControlRemoto**  
  Actúa como el invocador. Ejecuta el comando asignado sin saber qué acción realiza.

---

## 🧩 Estructura del código

- `ICommand`: Interfaz común para los comandos
- `Televisor`: Receptor de las acciones
- `EncenderTVCommand`, `ApagarTVCommand`, `SubirVolumenCommand`: Comandos concretos
- `ControlRemoto`: Invocador
- `Program`: Cliente que configura y ejecuta los comandos

---

## ▶️ Flujo de ejecución

1. El cliente crea el televisor
2. Se asigna un comando al control remoto
3. El control remoto ejecuta el comando
4. El comando delega la acción al televisor
5. El cliente puede cambiar el comando en tiempo de ejecución

---

## ✅ Beneficios del patrón Command

- Bajo acoplamiento entre invocador y receptor
- Facilita la extensión del sistema
- Permite implementar colas, historial o deshacer acciones
- Cumple con el principio **Open/Closed**

---

## 🛠️ Tecnologías utilizadas

- Lenguaje: **C#**
- Tipo de proyecto: **Aplicación de consola**
- Paradigma: **Programación Orientada a Objetos**

---

## 📚 Uso educativo

Este proyecto fue desarrollado con fines **educativos**, como ejemplo práctico del patrón Command aplicado a un caso real y fácil de comprender.

