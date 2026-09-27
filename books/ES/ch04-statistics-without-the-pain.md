# 4. Estadística sin dolor

No necesitas mucha estadística para ser un buen analista. Necesitas un puñado de
ideas entendidas a fondo, y la sabiduría para saber cuándo te engañan. Aquí está
todo el equipo, en palabras llanas.

## Los tres promedios: media, mediana y moda

La gente dice «promedio» como si solo hubiera uno. Hay tres, y elegir el equivocado
puede mentir sin estar técnicamente equivocado.

- **Media** — suma todo y divide por el número de elementos. El promedio clásico.
- **Mediana** — el valor del medio cuando los ordenas todos. La mitad queda por
  encima, la mitad por debajo.
- **Moda** — el valor más frecuente.

¿Por qué importa? Imagina una empresa pequeña. Diez empleados ganan €30,000, y el
jefe gana €500,000.

- El salario **medio** es €72,727: «¡pagamos bien!»
- El salario **mediano** es €30,000: la realidad del trabajador típico.

Un número es «correcto» y el otro también es «correcto», y cuentan historias
completamente distintas. Cuando hay unos pocos valores extremos (atípicos) en la
mezcla, la **mediana** suele ser la honesta. Cuando alguien cita un promedio,
pregunta: *¿media o mediana?*

## Dispersión: ¿las cosas son estables o salvajes?

Un promedio esconde cuán repartidos están los números. Dos servicios de entrega dan
ambos un promedio de 3 días. Uno siempre tarda 3 días. El otro tarda 1 día o 5
días al azar. Mismo promedio, experiencia totalmente distinta.

La medida de dispersión que más usarás es la **desviación estándar**:
aproximadamente, «lo lejos que están las cosas del promedio normalmente». Desviación
estándar pequeña = estable, predecible. Grande = salvaje, poco fiable. Los promedios
te dicen el centro; la dispersión te dice el riesgo.

## La campana de Gauss (y por qué aparece en todas partes)

Muchas cosas reales —estaturas, notas de exámenes, errores de medición— se amontonan
alrededor del medio y se afinan en los extremos, formando una campana. Esta es la
**distribución normal**, y está en todas partes por un hecho precioso: cuando muchas
pequeñas influencias aleatorias se suman, el resultado tiende a una campana. No
necesitas las matemáticas. Necesitas el instinto: la mayoría de los casos están cerca
del centro, los extremos son raros, y un valor muy lejos en la cola merece
investigarse.

## Valores atípicos: el número raro

Un **valor atípico** (outlier) es un valor lejos del resto. Un cliente compra
€50,000 mientras todos los demás compran €50. Una entrega tarda 30 días mientras
el resto tarda 3. Los atípicos pueden ser:
- **Errores** — una errata, un registro de prueba, un decimal mal puesto.
- **Reales pero raros** — un cliente ballena, un desastre auténtico.

Mira siempre los atípicos antes de fiarte de un promedio. Un solo cliente gordo
puede hacer que un mes entero parezca estupendo y esconder que los otros 200
clientes se están yendo.

## La gran trampa: correlación no es causalidad

Esta es la frase más importante de todo el libro.

**Correlación** significa que dos cosas se mueven juntas. **Causalidad** significa
que una cosa *causa* la otra. No son lo mismo, y confundirlas provoca tonterías
caras.

Ejemplo clásico: **las ventas de helados y las muertes por ahogamiento suben juntas**
cada verano. ¿Causan los helados los ahogamientos? No. Una tercera cosa, el calor,
mueve ambas. Cuando veas dos cosas moverse juntas, pregunta siempre:
- ¿A causa a B?
- ¿B causa a A?
- ¿Una C oculta causa ambas?
- ¿Es solo coincidencia?

«Los clientes que usan más nuestra app son más felices» podría significar que la
app los hace felices, o que los clientes ya felices la usan más. La correlación te
señala una pista. No te da la respuesta.

## Una curiosidad: el coeficiente de correlación

Los estadísticos exprimen «lo fuerte que dos cosas se mueven juntas» en un número de
**-1 a +1**. +1 significa que suben en perfecto paso; -1 significa que una sube
mientras la otra baja; 0 significa ninguna relación. Es un termómetro útil para una
relación, pero recuerda: incluso un +1 perfecto sigue sin ser prueba de causa.

---

## Lo que te llevarás de este capítulo

- Sabe qué promedio estás usando; la mediana suele decir la verdad.
- Los promedios esconden la dispersión: vigila la desviación estándar.
- Los atípicos pueden fingir una historia entera; míralos primero.
- La correlación es una pista, nunca una prueba. Busca siempre la tercera cosa oculta.

Siguiente: cómo convertir una preocupación difusa del negocio en una pregunta
afilada que de verdad puedas responder con datos.
