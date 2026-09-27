# 15. Pruebas, azar y tener razón

Cambiaste la web y las conversiones subieron un 2%. ¿Funcionó tu cambio, o fue solo
suerte? Esta es la pregunta que separa el análisis real del pensamiento ilusorio, y
la respuesta vive en el mundo poco glamuroso de las pruebas y el azar. No te
preocupes: lo mantendremos sin dolor.

## El problema: ¿fue el cambio o la suerte?

Cualquier número puede rebotar por azar. Si lanzas una moneda 10 veces y salen 7
caras, no concluyes que la moneda está trucada. Igual con el negocio: si un anuncio
nuevo consigue unos clics más, quizá sea mejor, o quizá sea ruido. La pregunta es:
**¿qué tan confiado puedes estar de que la diferencia es real?**

## La idea de una muestra

Casi nunca ves a toda la población: ves una **muestra**. 1.000 visitantes a tu web,
no toda la gente que podría visitarla. Una muestra es una pequeña prueba de una olla
mucho más grande. El truco es que una pequeña prueba puede decirte sobre la olla
entera, *si* es bastante grande e imparcial.

Muestra grande + selección aleatoria = fiable. Muestra diminuta o elegida a dedo =
peligroso. Las pruebas A/B funcionan porque dividen a los visitantes al azar en dos
grupos y comparan.

## Prueba A/B: el experimento honesto

El estándar de oro para «¿funciona esto?»:

1. Divide tu audiencia **aleatoriamente** en dos grupos.
2. El grupo A ve la versión vieja; el grupo B ve la versión nueva.
3. Mide el resultado en ambos.
4. Compara. Si B supera a A en más de lo que el azar explica, el cambio es real.

La aleatoriedad es todo el truco. Hace que los dos grupos sean idénticos salvo por la
única cosa que cambiaste, así que cualquier diferencia debe ser el cambio.

## Significancia: ¿es real la diferencia?

Los estadísticos usan un **valor p** para responder «¿podría esto ser azar?». Un
valor p por debajo de 0.05 es el listón habitual: significa «si de verdad no
hubiera diferencia, veríamos algo tan extremo menos del 5% de las veces». Por debajo
del listón lo llamas **estadísticamente significativo**: probablemente real. Por
encima, te encoges de hombros y dices «no hay suficiente evidencia».

No necesitas calcular valores p a mano. Necesitas el instinto: **una diferencia
pequeña en una muestra pequeña es probablemente ruido; una diferencia clara en una
muestra grande es probablemente real.**

## Las dos formas de equivocarse

- **Error de tipo I (falso positivo):** dices que el cambio funcionó cuando no lo
  hizo. Sacas un cambio inútil. El listón del 5% controla esto.
- **Error de tipo II (falso negativo):** dices que el cambio no funcionó cuando sí lo
  hizo. Tiras una buena idea. Suele deberse a una muestra demasiado pequeña.

Ambas ocurren. Una buena prueba los equilibra: datos suficientes para cazar efectos
reales, un listón bastante estricto para no perseguir fantasmas.

## Comparar dos grupos, en vivo

No necesitas un laboratorio para ver la forma de una comparación. El asistente puede
poner dos grupos lado a lado en una consulta:

> «Compara ventas del Norte contra el Centro.»

![Comparar dos grupos](../../assets/examples/e033.png)

Escala esto con asignación aleatoria y una muestra grande, y tienes una prueba A/B.
La lógica es idéntica: dos grupos, una diferencia, medir y comparar.

## Una curiosidad: la galleta que engañó a todos

Una empresa corrió una prueba A/B, vio un gran impulso y celebró. La trampa: los dos
grupos no eran en realidad aleatorios: un fallo puso a todos los usuarios de móvil en
un grupo. La «victoria» era en realidad solo usuarios de móvil comportándose de otra
manera. La prueba era sólida en teoría y rota en la práctica. **La aleatorización lo
es todo.** Una prueba es tan buena como la división detrás de ella.

## Cuando no necesitas una prueba formal

No toda decisión necesita un valor p. Si cambias el precio de un artículo y miras una
semana de ventas, no estás corriendo un experimento: estás observando. La prueba
formal es para las decisiones que importan y que pueden correrse bien. Para todo lo
demás, sé honesto en que estás adivinando, y mantén la decisión reversible.

---

## Lo que te llevarás de este capítulo

- Una diferencia puede ser suerte; pregunta qué tan confiado estás.
- Las muestras dejan que una pequeña prueba te hable de la olla entera, si son
  grandes y aleatorias.
- Prueba A/B = división aleatoria, cambia una cosa, compara.
- «Significativo» significa «poco probable que sea puro azar».
- La aleatorización lo es todo; una mala división finge una victoria.

La Parte III está hecha: puedes construir métricas, distinguir los tipos de análisis,
conocer a tus clientes, leer tendencias y separar lo real del ruido. Ahora lo hacemos
todo visible: Power BI y el arte de mostrar tus datos.
