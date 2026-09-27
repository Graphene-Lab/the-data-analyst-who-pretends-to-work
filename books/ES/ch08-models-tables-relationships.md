# 8. Modelos, tablas y relaciones

Un montón de tablas no es un modelo. Un **modelo** es lo que obtienes cuando le dices
al ordenador cómo las tablas se *relacionan* entre sí. Esas conexiones, el cableado,
son lo que te permite hacer una pregunta en un sitio y obtener una respuesta que
abarca muchas tablas. Este capítulo trata de ese cableado.

## Tablas, filas y claves

Toda tabla tiene **filas** (un registro cada una) y **columnas** (un atributo cada
una). La magia está en la **clave**: una columna que identifica de forma única cada
fila. Un ID de cliente, un código de producto, un número de pedido. Las claves son
cómo las tablas se reconocen entre sí.

- Una **clave primaria** es el ID único en una tabla (una fila por cliente).
- Una **clave foránea** es una columna en otra tabla que apunta a ese ID (cada venta
  guarda el ID del cliente).

## La relación: cómo dos tablas hablan

Una **relación** conecta una clave foránea con una clave primaria. Una vez
conectadas, el ordenador puede responder preguntas que cruzan tablas: «¿qué producto
estaba en esta venta?», «¿en qué ciudad vivía este cliente?», sin que tú nunca
fusiones archivos a mano.

El tipo más común es **muchos-a-uno**: muchas ventas apuntan a un producto. Cada
venta tiene un ID de producto; la tabla de productos tiene una fila por producto.
Muchas ventas, un producto. Esa es la espina dorsal de casi todo modelo de negocio.

## Cablearlo, en vivo

Aquí está el asistente creando una relación a partir de una petición normal:

> «Conecta Sales con Products en ProductID.»

![Relación de Sales a Products](../../assets/examples/e015.png)

La herramienta reporta la dirección (Many→One) y confirma que está activa en Power
BI Desktop. Luego el enlace de clientes:

> «Conecta Sales con Customers en CustomerID.»

![Relación de Sales a Customers](../../assets/examples/e016.png)

Y el enlace de tiendas:

> «Conecta Sales con Stores en StoreID.»

![Relación de Sales a Stores](../../assets/examples/e017.png)

Tres frases, y el modelo ya tiene espina dorsal. Toda pregunta posterior sobre
«ventas por producto», «ventas por cliente», «ventas por tienda» funciona gracias a
estas tres líneas.

## Ver todo el cableado

> «Muestra todas las relaciones del modelo.»

![Todas las relaciones](../../assets/examples/e018.png)

Tres relaciones Many→One limpias, todas activas. Este es el diagrama de cableado:
la cosa que compruebas primero cuando un número parece raro.

## El esquema de estrella: la forma que quieres

Únelo todo y obtienes la forma más famosa del dato de negocio: el **esquema de
estrella**. Una tabla de hechos en el centro (Sales), rodeada de tablas de dimensión
(Products, Customers, Stores, Date). La tabla de hechos guarda los números; las
dimensiones guardan el detalle descriptivo. Dibujado, parece una estrella.

¿Por qué se lo quiere tanto? Porque es simple, rápido y encaja con cómo la gente hace
preguntas. «Ventas por categoría» es solo la tabla de hechos estirándose hacia la
dimensión de producto. Casi todo buen modelo de BI es una estrella, o un campo de
estrellas.

## Una tabla calculada: resumir sobre la marcha

A veces quieres una pequeña tabla resumen construida desde el propio modelo:

> «Construye una pequeña tabla de ventas totales por categoría.»

![Tabla de ventas por categoría](../../assets/examples/e019.png)

Una tabla nueva, calculada en vivo, que enrolla el detalle en un resumen ordenado.
Útil para un informe rápido o una instantánea.

## Una curiosidad: la trampa muchos-a-muchos

La relación más peligrosa es **muchos-a-muchos** sin cuidado: muchos productos en
muchas promociones, muchos alumnos en muchas clases. Si la haces mal, tus totales
cuentan de más o desaparecen. El arreglo es una tabla «puente» en el medio. Si tus
números de pronto parecen inflados, un muchos-a-muchos chapucero es el primer
sospechoso.

---

## Pruébalo tú mismo

> «¿Cuántas relaciones hay ahora?»

![Contar relaciones](../../assets/examples/e073.png)

Una comprobación rápida de que todo el cableado está ahí.

## Lo que te llevarás de este capítulo

- Un modelo son tablas más las relaciones entre ellas.
- Las claves (primaria y foránea) son cómo las tablas se reconocen.
- Muchos-a-uno es la espina dorsal del dato de negocio.
- El esquema de estrella es la forma que normalmente quieres.
- Cuidado con el muchos-a-muchos chapucero: infla los totales.

Siguiente: hacer preguntas al dato directamente: SQL y DAX, los dos lenguajes para
obtener respuestas.
