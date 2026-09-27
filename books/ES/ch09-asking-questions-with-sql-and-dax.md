# 9. Hacer preguntas con SQL y DAX

Una vez que los datos están dentro y cableados, les haces preguntas. Hay dos
lenguajes que deberías reconocer: **SQL** para bases de datos, y **DAX** para Power
BI. Ya no necesitas escribirlos a mano: el asistente lo hace. Pero deberías
entender qué hacen, para poder preguntar bien y leer las respuestas.

## SQL: el lenguaje de las bases de datos

**SQL** (Structured Query Language) es la forma de hablar con las bases de datos
desde los años 1970. Se lee casi como inglés:

- `SELECT` — qué columnas quieres
- `FROM` — de qué tabla
- `WHERE` — qué filas conservar
- `GROUP BY` — cómo agrupar y totalizar

Un clásico: *«ventas totales por región»* es un SELECT, un JOIN a la tabla de
región y un GROUP BY. SQL está en todas partes: si tu empresa tiene una base de
datos, SQL es como la lees.

## DAX: el lenguaje de Power BI

**DAX** (Data Analysis Expressions) es el lenguaje dentro de Power BI. Parece
distinto de SQL pero hace el mismo trabajo: pedir un número, obtener un número. DAX
se construye alrededor de **medidas**: cálculos con nombre que puedes reutilizar.
`SUM`, `AVERAGE`, `COUNT`, `CALCULATE` son sus caballos de batalla.

Lo hermoso: no tienes que escribir DAX. Describes la respuesta que quieres, y el
asistente escribe y ejecuta el DAX por ti. Veámoslo.

## Contar y sumar

> «¿Cuántas filas hay en Sales?»

![Contar filas](../../assets/examples/e020.png)

Sesenta registros de ventas. Simple, instantáneo.

> «¿Cuál es el total de la columna Amount?»

![Sumar Amount](../../assets/examples/e021.png)

€22,023 en ventas totales. El tipo de número que antes significaba una tabla
dinámica y diez minutos; ahora es una frase.

## Clasificar y filtrar

> «Top 3 productos por ventas totales.»

![Top productos](../../assets/examples/e022.png)

El asistente los clasifica por ti. (Fíjate en que devuelve la clasificación completa
para que veas el panorama entero, no solo la franja de arriba.)

> «Muéstrame ventas mayores de 500.»

![Ventas sobre 500](../../assets/examples/e023.png)

Un filtro, ejecutado en vivo, que devuelve cada venta grande. Así es como
encuentras los atípicos y las ballenas.

## Agrupar a través de una relación

> «Ventas totales por ciudad de la tienda.»

![Ventas por ciudad](../../assets/examples/e024.png)

Este es el momento en que el modelo rinde: el asistente cruza la relación
Sales→Stores y totaliza por ciudad, sin fusión manual.

## Sacar un valor relacionado

> «Para cada venta, muestra el nombre del producto.»

![Nombre de producto relacionado](../../assets/examples/e025.png)

Usando `RELATED`, el asistente trae el nombre del producto a cada venta: el tipo de
cosa que en Excel significa un BUSCARV y una plegaria.

## Unas cuantas más, porque son fáciles

> «Cantidad total vendida en total.»

![Cantidad total](../../assets/examples/e074.png)

> «Cuenta ventas con cantidad por encima de 3.»

![Contar ventas de cantidad grande](../../assets/examples/e088.png)

Cada una una frase normal, cada una una consulta DAX real ejecutada contra el modelo
en vivo.

## Una curiosidad: la fama temible de DAX

DAX tiene fama de ser difícil. No es difícil de *usar*: es difícil *dominar el
contexto de filtro*, la regla sutil sobre qué datos ve un cálculo en cada momento.
Pero aquí está el secreto de este libro: no tienes que dominarlo. Describes la
respuesta; el asistente escribe el DAX y maneja el contexto. La dificultad pasa de
tus hombros a los de la herramienta.

---

## Lo que te llevarás de este capítulo

- SQL habla con bases de datos; DAX habla con Power BI.
- Ambos se leen cerca del inglés: seleccionar, filtrar, agrupar, totalizar.
- Tú describes la respuesta; el asistente escribe y ejecuta la consulta.
- Las relaciones hacen triviales las preguntas entre tablas.
- La parte difícil de DAX ahora es problema de la herramienta, no tuyo.

Siguiente: la hoja de cálculo: donde casi todos empiezan, y el muro donde casi todos
necesitan algo más.
