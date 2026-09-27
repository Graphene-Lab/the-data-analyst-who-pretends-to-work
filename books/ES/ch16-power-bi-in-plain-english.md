# 16. Power BI en cristiano

Has oído el nombre. Este capítulo reduce Power BI a lo que realmente es, sin la
niebla de márketing, y muestra cómo el asistente le habla directamente.

## Qué es Power BI de verdad

Power BI es la herramienta de Microsoft para convertir datos en **paneles e
informes** que la gente puede mirar, en los que puede hacer clic y explorar. Tiene
tres partes principales:

- **Power BI Desktop** — el programa gratis en tu PC donde construyes el modelo y el
  informe. Aquí es donde trabaja el asistente.
- **Power BI Service** — el sitio online donde publicas paneles para que otros los
  vean en un navegador o en el móvil.
- **Power BI Mobile** — la app para revisar paneles sobre la marcha.

Construyes en Desktop. Compartes a través del Service. Esa es toda la imagen.

## Las tres capas de dentro

Todo proyecto de Power BI tiene tres capas, y ayuda saber sus nombres:

1. **Datos** — a qué te conectas (una base de datos, un archivo, una fuente web).
2. **Modelo** — las tablas, relaciones y medidas que construyes encima de los datos.
3. **Informe** — las páginas visuales que la gente realmente mira.

El asistente trabaja casi por completo en la capa del **modelo**: las tablas, las
medidas y las relaciones. La capa del informe (los visuales bonitos) es donde un
humano dispone las cosas en el lienzo. El modelo es el motor; el informe es el
panel.

## Ver el modelo, en vivo

El asistente puede leer todo el modelo y reportarlo:

> «Dame un resumen del modelo.»

![Resumen del modelo](../../assets/examples/e002.png)

Tablas, medidas, relaciones, recuentos de filas: todo el motor en una vista. Esto es
lo primero que haces al abrir cualquier proyecto de Power BI: entender el modelo.

> «Lista cada tabla con su recuento de filas.»

![Listar tablas](../../assets/examples/e005.png)

Los bloques de construcción, contados y listos.

## El diccionario de datos: documentación gratis

Uno de los trucos más útiles del asistente es escribir un **diccionario de datos**:
un documento que lista cada tabla, columna y medida con lo que significa.

> «Genera un diccionario de datos de todo el modelo.»

![Diccionario de datos](../../assets/examples/e044.png)

Documentación que a un analista le costaría una tarde aparece en un segundo. Esto es
importante: una buena documentación es la diferencia entre un modelo en el que un
equipo puede confiar y un modelo que solo entiende una persona.

## Ver las medidas

> «¿Qué medidas existen en Sales?»

![Medidas en Sales](../../assets/examples/e079.png)

Cada medida con su fórmula y formato. Cuando alguien pregunta «¿cómo se calcula
Ventas Totales?», la respuesta está ahí mismo.

## Una curiosidad: el improbable ascenso de Power BI

Power BI empezó en 2015 como un pequeño complemento y corrió a lo más alto del mundo
analítico, en gran parte porque Microsoft lo empaquetó con herramientas que las
empresas ya tenían y lo puso a un precio lo bastante bajo para que casi cualquiera
pudiera probarlo. Su superpoder silencioso es que se sienta dentro del ecosistema
Microsoft: Excel, Azure, Office, así que para millones de negocios fue el camino de
menor resistencia. La mejor herramienta a menudo no es la mejor herramienta; es la
que ya está ahí.

## Por qué importa el asistente aquí

Power BI es potente pero tiene una curva de aprendizaje: DAX, la vista de modelo, la
cinta de botones. El asistente elimina esa curva para el trabajo de modelo: describes
lo que quieres, y él edita el modelo en vivo. Tú sigues disponiendo los visuales tú
mismo, pero la parte difícil: las medidas y el cableado, se vuelve una conversación.

---

## Lo que te llevarás de este capítulo

- Power BI = Desktop (construir), Service (compartir), Mobile (ver).
- Tres capas: datos, modelo, informe.
- El asistente trabaja en la capa del modelo.
- Puede resumir, listar y documentar el modelo bajo demanda.
- El asistente elimina la curva de aprendizaje de la parte difícil.

Siguiente: cómo el asistente encuentra y se conecta a tu Power BI Desktop: el momento
en que los dos se encuentran.
