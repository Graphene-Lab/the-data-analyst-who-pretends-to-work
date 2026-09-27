# 18. Modelar datos en Power BI

Modelar es donde el análisis se gana o se pierde. Un buen modelo hace fácil cada
pregunta; un mal modelo hace de cada pregunta una pelea. Este capítulo muestra al
asistente como un modelador cuidadoso: uno que no solo construye el modelo, sino que
lo documenta y lo comprueba contra las buenas prácticas.

## Cómo se ve un buen modelo

Conociste el esquema de estrella en el Capítulo 8. En Power BI, un buen modelo
significa:

- Una **tabla de hechos** limpia (los números: ventas, transacciones).
- **Tablas de dimensión** ordenadas (las descripciones: productos, clientes, fechas).
- **Relaciones** cableadas correctamente (muchos-a-uno, sin ambigüedad).
- **Medidas** con nombres, formatos y descripciones claros.
- **Documentación** para que la siguiente persona (o tú, en seis meses) lo entienda.

El asistente ayuda con todo esto, en vivo.

## Documentar sobre la marcha

Los buenos modelos son modelos documentados. El asistente puede añadir descripciones
a tablas y columnas bajo petición:

> «Añade una descripción a la tabla Sales.»

![Descripción de tabla](../../assets/examples/e046.png)

> «Describe la columna Amount.»

![Descripción de columna](../../assets/examples/e047.png)

Estas pequeñas notas aparecen en el modelo y en el diccionario de datos. Son la
diferencia entre un modelo que es una caja negra y uno que es un activo compartido.

> «Pon una descripción en la tabla Products.»

![Descripción de Products](../../assets/examples/e080.png)

## El diccionario de datos, tabla por tabla

Puedes documentar todo el modelo o una sola tabla:

> «Genera un diccionario de datos solo para Products.»

![Diccionario de Products](../../assets/examples/e045.png)

Un diccionario enfocado en una tabla: útil cuando entregas un trozo del modelo a un
colega.

## El reconocimiento médico: buenas prácticas

Este es uno de los movimientos más valiosos del asistente. Escanea todo el modelo y
reporta problemas y consejos:

> «Comprueba el modelo contra las buenas prácticas.»

![Informe de buenas prácticas](../../assets/examples/e048.png)

Marca medidas sin cadena de formato, tablas sin descripción, tablas desconectadas:
los pequeños pecados que hacen un modelo difícil de usar. Esto es como un linter
para tu modelo de datos: no te impide trabajar, pero te dice dónde el modelo está
desordenado antes de que el desastre te muerda.

## Revisar tras los cambios

Mientras construyes, el modelo deriva. Volver a correr la comprobación lo mantiene
honesto:

> «Buenas prácticas tras añadir medidas.»

![Buenas prácticas tras cambios](../../assets/examples/e093.png)

Un re-escaneo rápido muestra qué introdujeron tus últimos cambios. Construir,
comprobar, arreglar, repetir: el ritmo de un modelo limpio.

## Una curiosidad: el factor autobús

En los equipos de software hay una métrica llamada el **factor autobús**: cuántas
personas tendrían que ser «atareadas por un autobús» antes de que un proyecto se
atasque porque solo una persona lo entiende. Un modelo sin documentación tiene un
factor autobús de uno: aterrador. Cada descripción y entrada de diccionario que
escribe el asistente sube ese número. No estás solo ordenando; estás haciendo el
modelo superviviente.

## Por qué el asistente es un buen modelador

Un modelador humano bajo presión de plazo se salta la documentación y las buenas
prácticas. El asistente no se cansa, no se salta pasos y lo comprueba todo. Une el
criterio humano sobre *qué* modelar con la diligencia del asistente sobre
*documentar y comprobar*, y obtienes modelos que se mantienen limpios.

---

## Lo que te llevarás de este capítulo

- Un buen modelo: hechos + dimensiones limpios, cableado bien, documentado.
- Añade descripciones a tablas, columnas y medidas sobre la marcha.
- Genera diccionarios de datos para documentar todo el modelo o una tabla.
- Corre la comprobación de buenas prácticas como un linter: a menudo.
- La documentación sube el factor autobús; hace el modelo superviviente.

Siguiente: DAX, el lenguaje detrás de los números, y por qué no tienes que
escribirlo.
