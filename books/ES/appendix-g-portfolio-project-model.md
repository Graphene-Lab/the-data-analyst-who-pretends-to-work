# Apéndice G — Un modelo de proyecto de portafolio

Un portafolio prueba que puedes hacer el trabajo. Este modelo te da un proyecto para
construir, documentar y mostrar. Haz uno o dos de estos y tendrás algo a lo que señalar
en una entrevista.

## El proyecto: un panel de análisis de ventas

Construye un pequeño análisis de punta a punta sobre un conjunto de datos de ventas de
muestra (la misma forma usada a lo largo de este libro: Sales, Products, Customers,
Stores).

### Paso 1 — Entender los datos

- Perfilado de cada tabla.
- Anota valores distintos, huecos y rangos.
- Escribe una frase por tabla: qué guarda.

### Paso 2 — Limpiar y modelar

- Estandariza el texto desordenado (columnas UPPER/LOWER).
- Encajona números en bandas (bandas de precio).
- Cablea las relaciones (Sales → Products, Customers, Stores).

### Paso 3 — Construir las métricas

- Ventas Totales, Cantidad Total, Pedidos.
- Valor Medio del Pedido, Ventas por Cliente.
- Una medida de margen (ingreso menos coste).
- Una medida de participación del total.

### Paso 4 — Segmentar

- Mejores clientes por gasto.
- Ventas por segmento (Retail / Business / Online).
- Ventas por región y por mes.

### Paso 5 — Validar y documentar

- Valida cada medida antes de guardar.
- Pasa el linter al DAX por antipatrones.
- Genera el diccionario de datos.
- Corre el informe de buenas prácticas.

### Paso 6 — Visualizar

- Una fila de tarjetas KPI (ventas totales, pedidos, pedido medio).
- Un gráfico de barras de ventas por categoría.
- Un gráfico de líneas de la tendencia mensual.
- Una tabla de clasificación de top productos.

## Qué mostrar en el portafolio

Para cada proyecto, presenta:

1. **La pregunta.** Qué problema de negocio estabas resolviendo.
2. **El modelo.** Una captura de las tablas y relaciones.
3. **Las métricas.** Las medidas que construiste, con su DAX.
4. **El panel.** Los visuales finales.
5. **La historia.** Qué encontraste y qué harías al respecto.
6. **El utillaje.** Una nota de que lo construiste con AgentBridge + PowerBITool, y
   cómo ayudó el asistente (validación, documentación, buenas prácticas).

## Por qué funciona

A un entrevistador no le importa que la herramienta lo hiciera rápido. Le importa que
puedas: plantear un problema, construir un modelo limpio, validar tu trabajo,
documentarlo y contar una historia. Este proyecto ejercita los seis. La herramienta es
un extra que muestra que estás al día, no un atajo que reemplaza el pensamiento.

## Hazlo tuyo

Cambia los datos de muestra por un conjunto que te importe: un hobby, un dataset
público, un proyecto paralelo. Cuanto más te importe el tema, mejores preguntas harás, y
mejor se verá el portafolio. El patrón es el mismo; los datos son tuyos para elegir.
