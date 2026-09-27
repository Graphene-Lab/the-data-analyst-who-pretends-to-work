# Apéndice H — Preguntas frecuentes de entrevistas

Preguntas comunes de entrevista para analista de datos, con respuestas cortas que muestran
que entiendes tanto el oficio como el utillaje moderno.

## «¿Qué hace de verdad un analista de datos?»

Convierte preguntas de negocio en respuestas de datos. Encuentra y limpia datos, los
modela, calcula métricas y cuenta una historia que impulsa una decisión. La herramienta
maneja el hacer; el analista posee la pregunta y el criterio.

## «¿SQL o DAX?»

Ambos. SQL para consultar bases de datos; DAX para modelar y medidas en Power BI. Se
complementan. Saber cuándo usar cada uno es la habilidad real.

## «¿Cuál es la diferencia entre una columna calculada y una medida?»

Una columna calculada se calcula una vez por fila y se guarda. Una medida se calcula en
el momento de la consulta, respondiendo a los filtros. Usa una columna para atributos a
nivel de fila; usa una medida para agregaciones que deben reaccionar a los filtros del
informe.

## «Explica CALCULATE.»

CALCULATE cambia el contexto de filtro de una medida. Es la función más poderosa de DAX
porque te deja calcular un valor bajo un conjunto específico de filtros: por ejemplo,
ventas de una categoría, o excluyendo una región.

## «¿Cómo manejas la división por cero?»

Usa DIVIDE en vez de `/`. DIVIDE devuelve un resultado seguro (en blanco o un valor de
respaldo) cuando el denominador es cero. Nunca uses `/` crudo en una medida.

## «¿Cómo compruebas la calidad de datos?»

Perfilado de las tablas: valores distintos, huecos, mínimo/máximo, duplicados. Concilia
totales con la fuente. Corre una comprobación de buenas prácticas sobre el modelo. Un
modelo limpio es la base de cada número fiable.

## «¿Qué es un esquema de estrella?»

Una tabla de hechos central (p. ej. Sales) conectada a tablas de dimensión (Products,
Customers, Stores) por relaciones muchos-a-uno. Es la forma estándar y eficiente para
modelos analíticos.

## «¿Cómo lidias con un gráfico engañoso?»

Redibújalo con honestidad. Revisa el eje, la ventana temporal y la agregación. Si un
gráfico puede leerse de dos maneras, el trabajo del analista es hacer que la lectura
honesta sea la obvia.

## «¿Qué haces cuando los datos contradicen la respuesta esperada?»

Fíate de los datos, y luego investiga por qué. Un resultado sorprendente suele ser el
más valioso. Revisa la fuente, los filtros y las definiciones antes de concluir.

## «¿Cómo usas las herramientas de IA en tu flujo de trabajo?»

Como un acelerador, no un reemplazo. Uso un asistente (AgentBridge + PowerBITool) para
construir y validar medidas, documentar el modelo y correr comprobaciones de buenas
prácticas: así paso mi tiempo en las preguntas y la historia, no en la sintaxis. Reviso
cada número antes de publicarlo. La herramienta hace el cómo; yo poseo el qué y el por
qué.

## «Háblame de un proyecto que construiste.»

Usa el proyecto de portafolio del Apéndice G: la pregunta, el modelo, las métricas, el
panel, la historia y cómo ayudó el asistente. Muestra que puedes hacer toda la cadena y
que entiendes cada paso.

## La meta-respuesta

Casi toda buena respuesta vuelve a la misma idea: **la herramienta hace el trabajo
rápido; el analista lo hace bien.** Muestra que conoces ambas mitades y destacas sobre la
gente que solo conoce una.
