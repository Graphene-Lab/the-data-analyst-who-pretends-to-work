# 14. Tendencias, tiempo y estacionalidad

Un número es una instantánea. Añade tiempo, y se convierte en una historia. Ventas
de €11,000 significan poco hasta que sabes si es al alza o a la baja, y si es
normal para esta época del año. El tiempo es la dimensión que convierte una foto en
una película, y casi toda pregunta importante de negocio vive en él.

## Por qué el tiempo es especial

El tiempo es la única dimensión que no puedes evitar. Cada venta, cada clic, cada
registro ocurre *en* un momento. Y el tiempo tiene una propiedad que otras
dimensiones no: **las cosas se repiten.** El helado se vende en verano. El comercio
minorista se dispara en Navidad. El software de impuestos ruge en abril. Esta
repetición es la **estacionalidad**, y detectarla te impide entrar en pánico por un
«hundimiento» que ocurre cada enero sin falta.

## Convertir la fecha en piezas útiles

Las fechas crudas son torpes. Para analizar el tiempo, rompes la fecha en piezas:
año, mes, día, como columnas por las que agrupar:

> «Añade una columna Año a partir de la fecha.»

![Columna Año](../../assets/examples/e039.png)

> «Añade una columna Mes a partir de la fecha.»

![Columna Mes](../../assets/examples/e040.png)

Ahora puedes agrupar por año o por mes y ver la forma del tiempo.

## La vista interanual

> «Ventas totales por año.»

![Ventas por año](../../assets/examples/e041.png)

Dos años, lado a lado. ¿Es 2025 mejor que 2024? La comparación es todo el sentido:
un solo año no te dice nada, pero dos años te dicen la dirección.

La comparación interanual, como gráfico:

![Ventas por año — gráfico de barras](../../assets/examples/chart-yearly.png)

## La tendencia mensual

> «Ventas totales por mes.»

![Ventas por mes](../../assets/examples/e042.png)

Doce meses de datos. Puedes ver los picos y los valles: los meses ocupados y los
tranquilos. Esta es la forma cruda del latido de tu negocio.

El latido mensual, dibujado como línea:

![Ventas por mes — gráfico de líneas](../../assets/examples/chart-monthly.png)

## Filtrar un periodo

> «Ventas en 2025 solo.»

![Ventas de 2025](../../assets/examples/e043.png)

> «Ventas de la primera mitad de un año.»

![Primera mitad de 2025](../../assets/examples/e078.png)

Cortar una ventana concreta de tiempo es como respondes «¿cómo nos fue el trimestre
pasado?» en una frase.

## Encontrar el periodo lento

> «Mes con menos ventas.»

![Mes con menos ventas](../../assets/examples/e091.png)

Conocer tu mes más lento es tan útil como conocer el más ocupado: es cuando planificas
promociones, programas mantenimiento o te preparas para una racha tranquila.

## Medias móviles: suavizar el ruido

Los números mensuales son irregulares. Una **media móvil** (digamos, la media de los
últimos 3 meses) suavede los bultos para que se vea la tendencia subyacente. Es la
diferencia entre ver una cámara de mano temblorosa y un plano suave de steadicam.
La tendencia es lo que quieres ver; la media móvil la revela.

## Una curiosidad: el «efecto enero» que no lo es

Un gestor ve las ventas de enero un 30% abajo y convoca una reunión de emergencia.
Pero enero *siempre* está abajo tras la avalancha de fiestas de diciembre. Sin
comparar con el enero pasado, la caída no significa nada: es la temporada, no un
problema. Por eso los analistas comparan **interanual** (este enero contra el enero
pasado) en vez de **mes a mes** (enero contra diciembre). La comparación correcta
convierte una falsa alarma en una no-noticia.

---

## Lo que te llevarás de este capítulo

- El tiempo convierte una instantánea en una historia.
- Rompe las fechas en año/mes/día para agrupar y ver tendencias.
- La estacionalidad significa que las cosas se repiten: no entres en pánico por el
  hundimiento esperado.
- Compara interanual, no solo mes a mes.
- Las medias móviles suavizan el ruido para revelar la tendencia.

Siguiente: ¿cómo sabes que una diferencia es real y no solo suerte? Una suave visita
a las pruebas y el azar.
