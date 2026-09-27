# Apéndice A — Glosario de términos

Definiciones en cristiano de los términos usados en este libro.

**Agente / agéntico.** Software que toma *acciones* hacia un objetivo, no solo
responde preguntas. Un agente cierra el bucle de la intención al resultado.

**AgentBridge.** El asistente local de IA en lenguaje normal que planifica y actúa a
través de herramientas. El «cerebro» en este libro.

**PowerBITool.** El plugin de AgentBridge que opera Microsoft Power BI Desktop. Las
«manos» en este libro.

**Power BI Desktop.** La herramienta de Microsoft para construir modelos de datos e
informes.

**Modelo.** El conjunto de tablas, columnas, medidas y relaciones que Power BI usa
para responder preguntas.

**Tabla.** Un conjunto de filas y columnas. El contenedor básico de datos.

**Columna.** Un solo campo en una tabla, con un tipo de dato (texto, número, fecha).

**Medida.** Un valor calculado (normalmente un agregado como una suma o una media) que
responde a los filtros de un informe.

**Columna calculada.** Una columna nueva añadida a una tabla, calculada con una fórmula
para cada fila.

**Tabla calculada.** Una tabla nueva creada a partir de una fórmula, calculada sobre la
marcha.

**Relación.** Un enlace entre dos tablas (p. ej. Sales → Products) para que los datos
fluyan entre ellas.

**Cardinalidad.** La naturaleza «uno-a-muchos» o «muchos-a-uno» de una relación.

**DAX.** Data Analysis Expressions: el lenguaje de fórmulas de Power BI.

**SQL.** Structured Query Language: el lenguaje estándar para consultar bases de datos.

**SUM / AVERAGE / COUNT.** Agregados básicos: total, media y recuento.

**DISTINCTCOUNT.** Recuento de valores únicos.

**CALCULATE.** Una función DAX que cambia el contexto de filtro de una medida.

**FILTER.** Una función DAX que conserva las filas que cumplen una condición.

**RELATED.** Una función DAX que saca un valor de una tabla relacionada.

**DIVIDE.** Una función de división segura que maneja la división por cero.

**ALL.** Una función DAX que quita los filtros (usada a menudo para el «% del total»).

**RANKX.** Una función DAX que clasifica filas por un valor.

**TOPN.** Una función DAX que devuelve las N filas superiores.

**Contexto de filtro.** El conjunto de filtros aplicados actualmente cuando una medida
se calcula.

**Contexto de fila.** La «fila actual» cuando una columna calculada o un iterador se
calcula.

**Iterador.** Una función DAX (SUMX, AVERAGEX) que evalúa fila por fila.

**Diccionario de datos.** Documentación de cada tabla, columna y medida de un modelo.

**Perfilado.** Inspeccionar los valores distintos, huecos, mínimo/máximo y muestras de
una tabla.

**Linting.** Comprobaciones estáticas que marcan patrones arriesgados (p. ej. `/` en vez
de `DIVIDE`).

**Buenas prácticas.** Una comprobación de salud del modelo contra patrones buenos
conocidos.

**Guarda de fallo cerrado.** Una regla de seguridad que bloquea cualquier cosa no
claramente permitida.

**Calidad de datos.** Lo limpios, completos y fiables que son los datos.

**Segmentación.** Dividir clientes o datos en grupos para el análisis.

**Estacionalidad.** Patrones regulares y repetitivos en el tiempo.

**KPI.** Key Performance Indicator: una métrica que importa al negocio.

**Panel.** Una vista de los KPI clave, normalmente en una pantalla.

**Informe.** Un conjunto detallado e interactivo de visuales construido sobre un
modelo.

**Gobernanza de datos.** Las reglas, la propiedad y los controles alrededor de un
activo de datos.

**Paradoja de Jevons.** Cuando algo se abarata, usamos más de él, no menos.
