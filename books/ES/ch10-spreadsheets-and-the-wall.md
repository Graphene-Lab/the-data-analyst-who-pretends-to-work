# 10. Hojas de cálculo, Excel y chocar con el muro

Ningún libro sobre análisis de datos puede saltarse la hoja de cálculo. Es donde
casi todo el mundo empieza, y con buena razón: es brillante. Pero es también donde
la gente choca con un muro, y saber dónde está ese muro te dice cuándo seguir
adelante.

## Por qué ganaron las hojas de cálculo

La hoja de cálculo es uno de los programas de software más exitosos jamás hechos. Su
genio es que es **manipulación directa**: escribes un número en una casilla, y las
casillas que dependen de él se actualizan al instante. Sin código, sin compilar, sin
esperar. Ves tu trabajo y tu resultado lado a lado.

Las hojas de cálculo dieron a la gente corriente el poder de modelar: presupuestos,
previsiones, calendarios, listas de precios. Antes de la hoja de cálculo, ese poder
vivía solo en mainframes y solo con programadores. Después, cualquiera con un PC
podía hacerlo.

## La tabla dinámica: análisis en una caja

La **tabla dinámica** es el superpoder de la hoja de cálculo. Arrastras unos campos
y resume miles de filas: ventas por mes, por producto, por región. Para una enorme
parte del análisis de negocio, una tabla dinámica es todo el trabajo. Si sabes hacer
una tabla dinámica, sabes analizar.

## El muro

Pero las hojas de cálculo tienen un techo, y todo analista lo acaba chocando:

- **Tamaño** — pasado el millón de filas, Excel gime, se ralentiza y se cae.
- **Fragilidad** — una celda borrada, una fórmula rota, y todo el libro está en
  silencio equivocado. No hay red de seguridad.
- **Sin relaciones** — unir dos tablas significa BUSCARV, y BUSCARV se rompe en
  cuanto los datos se mueven.
- **Caos de versiones** — "Budget_FINAL_v3_really_final.xlsx" editado por cinco
  personas, todas en desacuerdo.
- **Sin refresco** — un informe que se actualiza a copiar-y-pegar cada lunes es un
  informe que está mal cada martes.
- **Sin historia compartida** — una hoja de cálculo es un archivo, no un panel en
  vivo en el que otros puedan confiar y explorar.

Si tu lunes por la mañana es «abrir el archivo, pegar los datos nuevos, arrastrar
las fórmulas, re-guardar, enviarlo por correo», estás haciendo a mano lo que un
modelo decente hace solo.

## La hoja de cálculo frente al modelo

Aquí está la diferencia en una línea:

> Una hoja de cálculo guarda números en celdas. Un modelo guarda *lógica* y calcula
> los números frescos cada vez.

En una hoja de cálculo, el número *es* la respuesta, sentado en una celda,
pudriéndose. En un modelo, la respuesta se recalcula desde los datos y las reglas,
cada vez que miras, siempre al día.

## La misma pregunta, dos maneras

En Excel, «ventas totales» significa una fórmula SUM sobre una columna, correcta
solo mientras nadie toque las filas. En un modelo, es una medida —`SUM(Sales[Amount])`—
que se recalcula bajo demanda y puede cortarse por cualquier dimensión sin una sola
fórmula nueva:

> «¿Cuál es el total de la columna Amount?»

![Total de Amount como medida](../../assets/examples/e021.png)

Mismo número, pero ahora vive en un modelo que puede responder «por región», «por
mes», «por cliente» sin trabajo extra: porque la lógica está guardada, no el
resultado.

## Una curiosidad: la hoja de cálculo que perdió un billón

En 1998, un error de hoja de cálculo ayudó a causar una pérdida de $1.2 billion en
un gran fondo financiero (LTCM), e incontables empresas se han quemado por una sola
celda errónea. En 2008, se descubrió que un famoso paper de investigación sobre
deuda y crecimiento tenía un error de hoja de cálculo: un conjunto de filas
excluido por accidente, que invirtió su conclusión y había influido en políticas
reales durante años. Las hojas de cálculo son poderosas, y por eso mismo sus errores
son peligrosos. Un modelo con lógica probada es más seguro que una hoja de cálculo
con un `+` oculto donde debía ir un `-`.

## Cuándo quedarse, cuándo irse

Quédate en la hoja de cálculo cuando: los datos son pequeños, el trabajo es único,
estás haciendo un boceto. Pasa a un modelo cuando: los datos son grandes, el
informe se repite, más de una persona lo toca, o necesitas que esté *bien* y *al
día*. El asistente y Power BI son la forma de cruzar ese puente sin dolor.

---

## Lo que te llevarás de este capítulo

- Las hojas de cálculo son brillantes para trabajo pequeño, directo y único.
- La tabla dinámica es un superpoder genuino.
- El muro: tamaño, fragilidad, sin relaciones, caos de versiones, sin refresco.
- Un modelo guarda lógica, no resultados congelados.
- Sigue adelante cuando el informe se repite o los datos crecen.

La Parte II está hecha: sabes de dónde vienen los datos, cómo limpiarlos, cómo
cablearlos y cómo hacerles preguntas. Ahora convertimos los datos en significado:
las métricas y los tipos de análisis que impulsan las decisiones.
