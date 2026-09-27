# 25. Narrar historias, ética y gobernanza

Aquí está la parte que la herramienta no puede hacer por ti. Puede construir la
medida, validar el DAX y documentar el modelo. No puede decidir qué significa la
historia, si el número es honesto, o si el modelo es seguro de fiar. Eso es tuyo.
Este capítulo trata de las tres cosas que se quedan humanas.

## Narrar historias: el número no es el asunto

Un panel lleno de números correctos que no cuenta ninguna historia es un muro de
ruido. El valor del análisis es la decisión que impulsa. Así que el trabajo real del
analista es convertir números en una historia que alguien pueda accionar.

Una estructura simple funciona:

- **Qué pasó.** El hecho, llanamente. «Las ventas de cocina cayeron este trimestre.»
- **Por qué importa.** Lo que está en juego. «La cocina es el 40% de nuestro ingreso.»
- **Qué hacer.** La acción. «Revisa el precio del proveedor en el SKU principal.»

El asistente te da la primera línea al instante. La segunda y la tercera son criterio:
contexto que la herramienta no tiene.

> Una curiosidad: la palabra «data» viene del latín *dare*, «dar». Los datos están
> hechos para ser dados, no acaparados. Un número que nunca llega a una decisión nunca
> fue realmente dado.

## La honestidad de un gráfico

Los mismos datos pueden contar historias opuestas según cómo los dibujes. Un eje
truncado hace que un cambio pequeño parezca enorme. Una ventana temporal elegida a
dedo hace que un hundimiento parezca una tendencia. Esto no es nuevo: es tan viejo
como los gráficos mismos, pero una herramienta que hace los gráficos sin esfuerzo
también hace los engañosos sin esfuerzo.

La regla es simple: **dibuja el gráfico honesto, y luego cuenta la historia honesta.**
Si te sentirías incómodo explicando por qué cortaste el eje en ese punto, no lo cortes.

> Una advertencia famosa: «Hay tres clases de mentiras: mentiras, malditas mentiras y
> estadísticas.» El chiste perdura porque un número lleva un aire de verdad que las
> palabras no tienen. Ese aire es una responsabilidad, no un truco.

## Ética: tres preguntas antes de publicar

Antes de que cualquier análisis llegue a un tomador de decisiones, pregunta:

1. **¿Es verdad?** ¿El número significa de verdad lo que la etiqueta afirma? (La
   validación del asistente ayuda aquí, pero el significado es tuyo.)
2. **¿Es justo?** ¿Podría usarse este análisis para dañar a alguien de forma injusta:
   señalar a una persona, penalizar a un grupo u ocultar una verdad incómoda?
3. **¿Es privado?** ¿Incluyen los datos información personal que debería protegerse o
   agregarse?

Una herramienta que hace el análisis rápido también hace fácil saltarse estas
preguntas. No lo hagas. La velocidad no es excusa para una conclusión descuidada o
dañina.

## Gobernanza: el modelo es un activo

Un modelo que impulsa decisiones es un activo de negocio, y los activos necesitan
gobernanza:

- **¿Quién lo posee?** Alguien debe ser responsable de los números.
- **¿De dónde vino?** La fuente de datos y las transformaciones deben ser trazables.
- **¿Está documentado?** Un modelo que nadie entiende es un modelo en el que nadie
  puede confiar, ni cambiar con seguridad.
- **¿Está comprobado?** Revisiones regulares de buenas prácticas y de calidad mantienen
  la deriva a raya.

Aquí es donde el asistente brilla en silencio. Cada medida que crea puede llevar una
descripción. Cada modelo puede obtener un diccionario de datos generado y un informe
de buenas prácticas. La gobernanza suele ser la cosa que los equipos se saltan porque
es tediosa, y tedioso es exactamente lo que un asistente elimina.

> Una curiosidad: el término «gobernanza» en datos viene de la misma raíz que
> «gobierno». No es burocracia por sí misma: es el estado de derecho para tus
> números. Sin él, los datos son un estado fallido.

## La ventaja humana, reafirmada

El asistente puede hacer el *cómo*. Tú posees el *qué*, el *por qué* y el *debería*.
Esa división no es una limitación: es toda la razón por la que un humano sigue en el
bucle. El analista del futuro no es reemplazado por la herramienta; el analista es
quien hace a la herramienta las preguntas correctas y responde las preguntas éticas
que la herramienta no puede.

## Un breve listado para el humano

Antes de publicar nada que el asistente ayudó a construir:

- [ ] El gráfico es honesto (sin eje engañoso, sin ventana elegida a dedo).
- [ ] El número significa lo que dice la etiqueta.
- [ ] La historia responde «¿y qué?» y «¿y ahora qué?».
- [ ] El modelo está documentado y tiene un dueño.
- [ ] El análisis no podría usarse para dañar de forma injusta.
- [ ] Los datos personales están protegidos o agregados.

Seis casillas. La herramienta hizo las horas de trabajo; estas seis comprobaciones son
la parte humana que lo mantiene fiable.

---

## Lo que te llevarás de este capítulo

- El número no es el asunto: lo es la decisión.
- Dibuja el gráfico honesto, cuenta la historia honesta.
- Pregunta: ¿es verdad, justo, privado?
- El modelo es un activo: dueño, trazabilidad, documentación, comprobaciones.
- La herramienta hace el *cómo*; tú posees el *qué*, el *por qué* y el *debería*.

Siguiente: tu carrera como analista de datos en la era del asistente.
