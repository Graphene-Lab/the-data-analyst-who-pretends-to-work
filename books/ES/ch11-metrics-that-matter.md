# 11. Las métricas que importan

Una métrica es un número que vigilas para saber cómo le va al negocio. Elige las
correctas y puedes gobernar el rumbo. Elige las equivocadas y puedes estrellarte
contra un acantilado mientras el panel brilla en verde. Este capítulo trata de
elegir los números que de verdad importan, y de construirlos con el asistente.

## Qué hace que una métrica merezca la pena

Una buena métrica pasa tres pruebas:

1. **Se mueve cuando el negocio se mueve.** Si el negocio empeora, el número debería
   empeorar.
2. **Puedes actuar sobre ella.** Un número que solo puedes admirar es decoración.
3. **Es honesta.** No se puede manipular para que parezca bien mientras las cosas se
   pudren.

Una **métrica de vanidad** suspende estas. «Usuarios registrados totales desde 2010»
solo sube. Sienta de maravilla y no significa nada. Vigila tasas y cambios, no
totales que siempre crecen.

## Las métricas core de ventas

Todo negocio que vende cosas vigila un conjunto parecido:

- **Ventas totales** — el ingreso titular.
- **Unidades vendidas** — cuánto material se movió.
- **Pedidos** — cuántas transacciones.
- **Valor medio del pedido** — ingreso por pedido.
- **Clientes activos** — cuánta gente compró de verdad.
- **Venta más grande** — la línea individual más grande (para detectar ballenas).

El asistente construye cada una de estas a partir de una petición normal. Mira
aparecer un conjunto:

> «Crea una medida de Ventas Totales con formato de euro.»

![Medida de Ventas Totales](../../assets/examples/e026.png)

> «Crea una medida para unidades vendidas.»

![Medida de Unidades Vendidas](../../assets/examples/e027.png)

> «Crea una medida de valor medio del pedido.»

![Valor medio del pedido](../../assets/examples/e028.png)

Fíjate en que el valor medio del pedido usa `DIVIDE`, no una barra. Es deliberado:
`DIVIDE` maneja el caso en que el denominador es cero sin romperse. Un pequeño
hábito de seguridad que te salva de errores `#DIV/0!` más tarde.

> «¿Cuántos clientes activos tenemos?»

![Clientes activos](../../assets/examples/e029.png)

> «¿Cuál es la venta más grande?»

![Venta más grande](../../assets/examples/e030.png)

En un puñado de frases, todo el conjunto core de KPI existe, en vivo en el modelo.

## Métricas de dinero: margen y participación

El ingreso es vanidad; el beneficio es cordura. Para saber lo que *conservas*,
necesitas el coste:

> «Añade una columna de coste y una medida de margen.»

![Columna de coste](../../assets/examples/e056.png)

> «Margen total de todas las ventas.»

![Margen total](../../assets/examples/e057.png)

Y para ver cómo se compara una porción con el todo:

> «Participación de las ventas totales, como porcentaje.»

![Porcentaje del total](../../assets/examples/e058.png)

Un porcentaje-del-total es una de las métricas más usadas en reporting: convierte
cualquier número en «¿qué tan grande es esto comparado con todo?».

## Unas cuantas rápidas más

> «Precio unitario medio pagado.»

![Precio unitario medio](../../assets/examples/e075.png)

> «Ventas totales excluyendo una categoría.»

![Ventas excluyendo una categoría](../../assets/examples/e089.png)

Cada una una frase normal, cada una una medida real en el modelo en vivo.

## Una curiosidad: la métrica que salió por detrás

Cuando la Unión Soviética midió la producción de clavos por **cantidad**, las
fábricas hacían clavos diminutos e inútiles por millones. Cuando cambiaron a medir
por **peso**, hicieron unos pocos clavos enormes. Mismo objetivo, distinta métrica,
distinto absurdo. La lección que todo analista debe aprender: **obtienes lo que
mides**, así que mide con cuidado: idealmente una métrica que solo pueda mejorar si
el negocio realmente mejora.

---

## Lo que te llevarás de este capítulo

- Elige métricas que se muevan con el negocio, en las que puedas actuar y que no se
  puedan manipular.
- Evita las métricas de vanidad (totales que siempre crecen).
- El conjunto core de ventas: ingreso, unidades, pedidos, pedido medio, clientes
  activos.
- El margen y la participación-del-total convierten el ingreso en significado.
- Obtienes lo que mides: mide con sabiduría.

Siguiente: los cuatro tipos de análisis, desde «qué pasó» hasta «qué deberíamos
hacer».
