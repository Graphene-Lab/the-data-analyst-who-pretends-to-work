# Apéndice B — Lista de comprobación de calidad de datos

Usa esto antes de fiarte de cualquier análisis. Cada ítem puede comprobarse con el
asistente.

## Completitud

- [ ] Sin valores en blanco inesperados en columnas clave. *(Perfilado de la tabla; mira
      la columna Blanks.)*
- [ ] Cada fila esperada está presente (sin periodos, regiones o productos faltantes).
- [ ] Los recuentos de filas coinciden con el sistema de origen.

## Exactitud

- [ ] Los totales concilian con la fuente de verdad.
- [ ] Los números están en la unidad correcta (euros contra céntimos, unidades contra
      cajas).
- [ ] Sin valores obviamente erróneos (cantidades negativas, fechas en el futuro).

## Consistencia

- [ ] El texto está estandarizado (sin "Milan" contra "milan" contra "MILAN"). *(Añade
      una columna UPPER/LOWER para comprobarlo.)*
- [ ] La misma entidad tiene el mismo nombre en todas partes.
- [ ] Los códigos coinciden entre tablas (cada ProductID en Sales existe en Products).

## Unicidad

- [ ] Las columnas clave son únicas donde deben serlo (una fila por SaleId).
- [ ] Sin clientes, productos o tiendas duplicados.

## Validez

- [ ] Los valores caen dentro de los rangos esperados (precio > 0, fechas válidas).
- [ ] Las categorías vienen de una lista permitida.
- [ ] Los formatos son correctos (las fechas son fechas, no texto).

## Oportunidad

- [ ] Los datos están lo bastante al día para la decisión.
- [ ] El refresco ocurrió cuando debía.

## Integridad

- [ ] Las relaciones están cableadas correctamente (muchos-a-uno, activas).
- [ ] Sin filas huérfanas (ventas apuntando a un producto que falta).
- [ ] El modelo pasa la comprobación de buenas prácticas.

## Cómo ayuda el asistente

- **Perfilado** de cada tabla para ver valores distintos, huecos, mínimo/máximo,
  muestras.
- **Validación** de fórmulas antes de guardarlas.
- **Linting** del DAX para cazar patrones arriesgados.
- **Informe de buenas prácticas** para comprobar todo el modelo de una vez.

Un modelo limpio no es un capricho. Cada número aguas abajo hereda la calidad de los
datos aguas arriba. Compruébalo una vez, fíate en todas partes.
