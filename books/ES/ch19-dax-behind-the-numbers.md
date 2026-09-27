# 19. DAX: el lenguaje detrás de los números

DAX es el lenguaje de cálculo dentro de Power BI. Tiene fama de dar miedo. Este
capítulo trata de por qué importa, y por qué, con el asistente, puedes usarlo sin
pelear nunca con él.

## Para qué sirve DAX

DAX (Data Analysis Expressions) calcula los números de tus informes: totales,
medias, porcentajes, interanual, totales acumulados, clasificaciones. Cada medida
que ves en un panel de Power BI es DAX bajo el capó.

Las funciones core son simples: `SUM`, `AVERAGE`, `COUNT`, `MIN`, `MAX`, y el
poderoso `CALCULATE`, que te deja calcular un número *bajo un filtro específico*.

## El asistente lo escribe; tú lo lees

No escribes DAX. Describes el número que quieres, y el asistente escribe el DAX y
crea la medida en vivo. Pero deberías poder *leer* lo que hizo, para fiarte de él.

> «Crea una medida de ventas solo de Milán.»

![Medida de ventas de Milán](../../assets/examples/e053.png)

Bajo el capó eso es `CALCULATE([Total Sales], Stores[City] = "Milan")`: las ventas
totales, pero solo donde la ciudad es Milán. Una vez ves el patrón, DAX deja de ser
magia.

## Valida antes de fiarte

El asistente puede probar una fórmula sin crear nada:

> «¿Es esta una medida válida? SUM(Sales[Amount])»

![Validar buena medida](../../assets/examples/e049.png)

> «Comprueba esta fórmula rota: SUMX(Sales[Amount])»

![Validar medida rota](../../assets/examples/e050.png)

Una pasa, una falla, y aprendes qué está mal *antes* de que se convierta en una
medida rota en el modelo. Este hábito de «comprobar primero» ahorra horas de
depuración.

> «Valida una medida CALCULATE.»

![Validar CALCULATE](../../assets/examples/e081.png)

> «Valida una medida de porcentaje.»

![Validar porcentaje](../../assets/examples/e094.png)

## Linting: el agente de estilo para DAX

Más allá de «¿se ejecuta?», el asistente puede comprobar «¿está *bien escrito*?»:
un proceso llamado **linting**. Detecta errores comunes y patrones arriesgados.

> «Pasa el linter por este DAX: SUM(a)/SUM(b)»

![Lint de división con barra](../../assets/examples/e051.png)

Advierte: no uses una `/` a secas: usa `DIVIDE`, que maneja la división por cero de
forma segura. Un pequeño empujón que previene toda una clase de errores `#DIV/0!`.

> «Pasa el linter por este DAX limpio con DIVIDE.»

![Lint de DAX limpio](../../assets/examples/e052.png)

La versión limpia pasa. Aprendes el buen patrón al verlo recompensado.

> «Pasa el linter por una medida que usa IFERROR.»

![Lint de IFERROR](../../assets/examples/e082.png)

Marca `IFERROR` como un mal olor: envolver errores puede esconder fallos reales en
vez de arreglarlos. El linter enseña buenos hábitos un aviso a la vez.

## Editar medidas

Las medidas evolucionan. El asistente puede actualizarlas y borrarlas:

> «Cambia el formato de Ventas Totales a euros enteros.»

![Actualizar formato](../../assets/examples/e054.png)

> «Borra la medida de Ventas de Milán.»

![Borrar medida](../../assets/examples/e055.png)

Renombrar, reformatear, quitar: todo en vivo, todo reversible hasta que guardes.

## Una curiosidad: la bestia del contexto de filtro

La razón por la que se llama difícil a DAX es un concepto: el **contexto de filtro**:
el conjunto invisible de filtros que un cálculo ve en cada momento (la fila actual,
la selección actual del segmentador, el visual actual). Domínalo y DAX es tu amigo;
malentiéndelo y los números parecen mal de formas difíciles de rastrear. Aquí está la
verdad liberadora de este libro: **tú describes la respuesta, y el asistente maneja
el contexto de filtro.** La bestia pasa a ser problema de la herramienta, no tuyo.

---

## Lo que te llevarás de este capítulo

- DAX calcula los números; `CALCULATE` es su palabra más poderosa.
- Tú describes la respuesta; el asistente escribe el DAX.
- Valida una fórmula antes de crearla.
- Pasa el linter para cazar malos patrones (`/` a secas, `IFERROR` escondiendo
  fallos).
- La parte difícil, el contexto de filtro, ahora es trabajo de la herramienta.

Siguiente: ver es creer: cómo elegir el gráfico correcto y no mentir con visuales.
