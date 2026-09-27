# 23. Conoce AgentBridge y PowerBITool

Cada ejemplo de este libro se hizo con dos herramientas trabajando juntas. Este
capítulo las presenta como es debido: qué es cada una, cómo encajan y qué pueden hacer.

## AgentBridge: el asistente

**AgentBridge** es un asistente de IA que funciona en tu propio ordenador. Le hablas
en palabras normales, y hace trabajo a través de tus herramientas. No es un chatbot
que solo habla: actúa. Puede escribir documentos, construir hojas de cálculo, enviar
correo, investigar en la web y, con el plugin correcto, operar Power BI.

Las propiedades clave:

- **Local.** Funciona en tu máquina. Tus datos se quedan contigo.
- **En lenguaje normal.** Describes lo que quieres; no escribes código.
- **Extensible.** Los plugins le dan nuevas habilidades. PowerBITool es una de ellas.

## PowerBITool: las manos dentro de Power BI

**PowerBITool** es el plugin que da a AgentBridge manos dentro de Microsoft Power BI
Desktop. A través de él, el asistente puede:

- **Conectarse** al modelo en vivo de un informe abierto.
- **Inspeccionar**: resumen del modelo, tablas, esquema, medidas, relaciones.
- **Editar el modelo**: crear y borrar tablas, columnas, medidas, relaciones; poner
  descripciones.
- **Ejecutar y validar DAX**: con una guarda de seguridad que bloquea cualquier cosa
  peligrosa.
- **Perfilar y documentar**: perfilar tablas, generar un diccionario de datos, pasar
  el linter de buenas prácticas.

Aquí está el asistente presentándose a un modelo:

> «Conoce PowerBITool: ¿qué puedes hacer con mi modelo?»

![Conoce PowerBITool](../../assets/examples/e064.png)

El resumen que devuelve es toda la superficie: tablas, medidas, relaciones, recuentos
de filas: todo lo que puede ver y con lo que puede trabajar.

## Cómo encajan

```
You  →  AgentBridge (the brain)  →  PowerBITool (the hands)  →  Power BI Desktop (the model)
```

AgentBridge entiende tus palabras y planifica la acción. PowerBITool lleva a cabo esa
acción sobre el modelo en vivo de Power BI. Ves el resultado de inmediato en Power BI
Desktop. El bucle es: preguntar → pensar → actuar → ver.

## La guarda de seguridad

Una cosa que merece la pena destacar: PowerBITool pasa el DAX por una **guarda de
fallo cerrado**. Permite consultas de solo lectura (`EVALUATE`, vistas de sistema) y
bloquea cualquier cosa que pueda modificar el modelo por la puerta de la consulta: ni
`DROP`, ni `INSERT`, ni `DELETE`, ni trucos de múltiples sentencias. Si una consulta
no está claramente segura, se rechaza. Esto es lo que hace responsable dejar que una
IA toque un modelo en vivo.

## Gratis, y respaldado por gente de verdad

Ambas herramientas son gratis. PowerBITool es abierto en GitHub, y, como prometía el
prefacio, el soporte también es gratis: abre un issue y un técnico de verdad responde
en unas 24 horas con una solución real. Esa combinación (herramienta gratis, soporte
humano gratis, respuestas rápidas) es la promesa detrás de cada ejemplo que has visto.

## Una curiosidad: el modelo de plugins

PowerBITool no se compila dentro de AgentBridge. Es un **plugin** soltado en una
carpeta `Tools`, descubierto al arrancar. Eso significa que las habilidades del
asistente pueden crecer sin cambiar el núcleo: hoy Power BI, mañana otras herramientas.
El modelo de plugins es por qué el asistente puede seguir ganando nuevas «manos» sin
hincharse.

## Qué puedes hacer con ellas, juntas

Todo en este libro, y más: conectarte a un informe, entender el modelo, limpiar datos
con columnas calculadas, construir medidas, cablear relaciones, validar y pasar el
linter al DAX, generar documentación y comprobar buenas prácticas: todo hablando.

---

## Lo que te llevarás de este capítulo

- AgentBridge es el asistente local, en lenguaje normal (el cerebro).
- PowerBITool es el plugin que opera Power BI Desktop (las manos).
- El bucle: preguntar → pensar → actuar → ver, todo local.
- Una guarda de fallo cerrado mantiene el modelo en vivo a salvo.
- Herramienta gratis, soporte gratis, gente de verdad, respuestas rápidas.

Siguiente: un día entero del trabajo del analista, automatizado.
