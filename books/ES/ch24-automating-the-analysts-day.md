# 24. Automatizar el día del analista

Pasemos un día dentro del trabajo del analista y miremos cómo el asistente lo maneja.
Este capítulo encadena los ejemplos como va un día de trabajo real: construir,
validar, documentar, comprobar, terminar. Cada imagen es una acción real sobre un
modelo en vivo.

## Mañana: construir las piezas de reporting

El día empieza convirtiendo tablas crudas en piezas de reporting. En vez de hacer
clic durante una hora, pides lo que el panel necesita.

> «Construye una tabla de rendimiento por categoría con ventas y recuento de
> productos.»

![Tabla de rendimiento por categoría](../../assets/examples/e065.png)

Una petición, una tabla nueva: ventas y recuento de productos por categoría,
calculado y en vivo.

Luego los KPI que el panel necesita:

> «Crea un conjunto de medidas KPI para el panel.»

![Conjunto de medidas KPI](../../assets/examples/e066.png)

Una medida de ingreso por cliente, creada y aplicada. El tipo de pequeña métrica que
antes se tomaba un minuto cuidadoso cada una, ahora llega en una frase.

## Antes de la reunión: validarlo todo

Antes de construir el informe, compruebas que los números están bien. El asistente
valida un lote entero de golpe:

> «Valida un lote de medidas antes de que construya el informe.»

![Validación por lotes](../../assets/examples/e067.png)

Cada medida devuelve OK con su valor. Sin sorpresas delante del jefe.

## Media mañana: cazar los huecos

Un buen analista busca lo que *falta*, no solo lo que está:

> «¿Qué productos nunca se vendieron?»

![Productos que nunca se vendieron](../../assets/examples/e070.png)

La consulta corre y devuelve cero filas: cada producto se vendió al menos una vez.
Esa también es una respuesta útil: ningún stock muerto escondido en el catálogo.

## Última mañana: comportamiento del modelo

Quieres marcar comportamiento repetido sin etiquetar filas a mano:

> «Crea una marca de cliente recurrente.»

![Marca de cliente recurrente](../../assets/examples/e085.png)

Una columna booleana que marca cada venta como repetida o no: calculada sobre toda la
tabla de una vez.

Y el mejor rendimiento:

> «Dame la mejor tienda por ventas.»

![Mejor tienda por ventas](../../assets/examples/e087.png)

Milan Central lidera. La clasificación que antes necesitaba una tabla dinámica y un
ordenado, ahora es una sola pregunta.

## Tarde: segmentación de objetivos

El equipo de marketing quiere clientes de alto valor:

> «Crea una medida de cliente de alto valor.»

![Medida de cliente de alto valor](../../assets/examples/e095.png)

Una marca para clientes por encima de un umbral de gasto, en vivo en el modelo, lista
para filtrar.

Y para ver cómo rinden las bandas de precio que hicimos antes:

> «Ventas por banda de precio.»

![Ventas por banda de precio](../../assets/examples/e097.png)

Alto, Medio, Bajo: la columna de banda del Capítulo 7 ahora impulsa un desglose real.
Esta es la recompensa de construir piezas pequeñas: luego se combinan.

## Fin del día: documentar y comprobar

Antes de cerrar, documentas el trabajo y compruebas su salud. El asistente escribe el
diccionario de todo el modelo:

> «Documenta el modelo final.»

![Diccionario de datos final](../../assets/examples/e099.png)

Cada tabla, cada medida, con su formato y expresión: documentación que nunca habrías
escrito a mano, hecha por ti.

Luego la comprobación de salud:

> «Comprobación de salud final de todo el modelo.»

![Comprobación de salud final](../../assets/examples/e100.png)

Cero advertencias. Las dos notas de «info» son solo tablas resumen desconectadas, lo
cual es esperado. El modelo está limpio.

## Cierre: el modelo terminado

Al final del día, miras lo que construiste:

> «Muestra la lista final de tablas.»

![Lista final de tablas](../../assets/examples/e102.png)

Seis tablas, catorce medidas, tres relaciones: un modelo analítico funcional,
construido y documentado en un solo día de peticiones en lenguaje normal.

## Qué muestra el día

Un día de trabajo completo: construir, validar, cazar huecos, modelar comportamiento,
segmentar objetivos, documentar, comprobar: hecho describiendo cada paso. Las manos
del analista no hicieron ninguno de los clics. La cabeza del analista tomó todas las
decisiones.

Ese es el intercambio que este libro no para de hacer: **tú conservas el criterio, la
herramienta se lleva la esclavitud.**

---

## Lo que te llevarás de este capítulo

- Un día entero de trabajo de analista se corresponde con una secuencia de peticiones
  en lenguaje normal.
- Construye piezas (tablas, medidas), valídalas, caza huecos, documenta, comprueba.
- Las piezas pequeñas se combinan luego (la banda de precio impulsa un desglose).
- El modelo termina limpio, documentado y listo, sin ninguno de los clics manuales.

Siguiente: narrar historias, ética y gobernanza: la parte que la herramienta no puede
hacer por ti.
