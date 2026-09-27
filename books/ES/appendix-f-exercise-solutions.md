# Apéndice F — Soluciones de los ejercicios

Soluciones a los ejercicios guiados del Apéndice E. Cada una muestra la petición en
lenguaje normal y el DAX que produce el asistente.

## Ejercicio 1 — Leer el modelo

**Petición:** «Lista cada tabla con su recuento de filas.»
**Qué pasa:** el asistente lee el modelo en vivo y devuelve cada tabla con su tipo,
recuento de filas y recuento de columnas. No hace falta DAX: es una llamada de
descubrimiento.

## Ejercicio 2 — Perfilar una tabla

**Petición:** «Perfilado de la tabla Products.»
**Qué pasa:** el asistente devuelve una tabla de perfil con Distinct, Blanks, Min,
Max y Top por columna. El recuento distinto de Category es 3; los huecos se muestran
por columna.

## Ejercicio 3 — Limpiar texto

**Petición:** «Añade una columna con la categoría en mayúsculas.»
**DAX:** `UPPER(Products[Category])`
**Resultado:** una nueva columna calculada `Products[CategoryUpper]`.

## Ejercicio 4 — Encajonar un número

**Petición:** «Agrupa los productos en Alto / Medio / Bajo por precio.»
**DAX:**
```
SWITCH(TRUE(),
  Products[Price] >= 200, "High",
  Products[Price] >= 50, "Mid",
  "Low")
```
**Resultado:** una nueva columna calculada `Products[PriceBand]`.

## Ejercicio 5 — Cablear una relación

**Petición:** «Conecta Sales con Products en ProductID.»
**Resultado:** una relación muchos-a-uno, de una sola dirección, activa
`Sales[ProductID] → Products[ProductID]`.

## Ejercicio 6 — Construir una medida

**Petición:** «Crea una medida de Ventas Totales con formato de euro.»
**DAX:** `SUM(Sales[Amount])` con formato `#,##0.00 €`.
**Resultado:** una nueva medida `Sales[Total Sales]`.

## Ejercicio 7 — Filtrar una medida

**Petición:** «Cuenta solo ventas por encima de 300.»
**DAX:** `COUNTROWS(FILTER(Sales, Sales[Amount] > 300))`
**Resultado:** una nueva medida `Sales[Big Sales Count]`.

## Ejercicio 8 — Participación del total

**Petición:** «La participación de cada categoría en las ventas totales.»
**DAX:** `DIVIDE([Total Sales], CALCULATE([Total Sales], ALL(Sales)))`
**Resultado:** una nueva medida `Sales[Pct Of Total]` con formato de porcentaje.

## Ejercicio 9 — Clasificar

**Petición:** «Clasifica productos por ventas.»
**DAX:** `RANKX(ALL(Products), [Total Sales])`
**Resultado:** una tabla de clasificación con el puesto de cada producto.

## Ejercicio 10 — Validar antes de guardar

**Petición:** «¿Es esta una medida válida? SUM(Sales[Amount])»
**Qué pasa:** el asistente valida y devuelve "Valid" con un valor de muestra (22023).
Solo entonces creas la medida.

## Ejercicio 11 — Lint

**Petición:** «Pasa el linter por este DAX: SUM(a)/SUM(b)»
**Qué pasa:** el linter marca el `/` y sugiere `DIVIDE()` para manejar la división por
cero de forma segura.

## Ejercicio 12 — Documentar

**Petición:** «Genera un diccionario de datos de todo el modelo.»
**Qué pasa:** el asistente devuelve un diccionario markdown listando cada tabla, su
tipo y recuento de filas, y cada medida con su formato y expresión.

## El patrón en cada solución

Pide con normalidad → el asistente escribe DAX correcto → aplica el cambio en vivo →
reporta exactamente qué hizo. Ese bucle es toda la habilidad. Cuando se sienta natural,
has interiorizado el libro.
