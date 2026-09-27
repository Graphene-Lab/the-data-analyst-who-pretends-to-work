# Una nota sobre la herramienta detrás de este libro

Este libro trata de un trabajo: el analista de datos. Trata de lo que ese trabajo
es de verdad, de dónde vino y a dónde va. Usa palabras sencillas. No necesitas un
título en matemáticas ni en informática para seguirlo. Si llevas un pequeño
negocio, controlas tus propias cifras, o simplemente te gusta entender cómo
funcionan las cosas, este libro es para ti.

Y aquí va la parte honesta. Cada uno de los ejemplos que verás en este libro —cada
tabla, cada medida, cada gráfico, cada momento de «mira esto»— se hizo con una
herramienta real, no escrito a mano. Esa herramienta es **PowerBITool**,
funcionando dentro de **AgentBridge**.

## Qué son AgentBridge y PowerBITool

**AgentBridge** es un asistente de IA que funciona en tu propio ordenador. Le
hablas como le hablarías a un compañero: en frases normales. Escucha, piensa y
hace el trabajo.

**PowerBITool** es un plugin que le da a AgentBridge manos dentro de
**Microsoft Power BI Desktop** —el programa popular con el que la gente construye
paneles e informes. Con PowerBITool, el asistente puede abrir tu modelo de datos,
añadir tablas, crear medidas, conectar tablas entre sí, ejecutar consultas,
comprobar tu trabajo y hacer una captura de pantalla de lo que hizo, todo mientras
lo ves ocurrir en tu propia pantalla.

Sin nube. Sin subir los datos de tu empresa al servidor de un desconocido.
Funciona con el Power BI Desktop que ya tienes en tu máquina.

```
You  →  AgentBridge  →  PowerBITool  →  your Power BI Desktop (on your PC)
```

## Cómo conseguirlo (es gratis)

PowerBITool es gratis y abierto. Para probarlo tú mismo:

1. Instala **AgentBridge** (gratis) desde la página de GitHub de abajo.
2. Añádele el plugin **PowerBITool**.
3. Abre un informe en **Power BI Desktop**.
4. Empieza a hablarle a tu asistente.

Escanea este código con la cámara del móvil para abrir la página de PowerBITool,
donde encontrarás la descarga y unas instrucciones de instalación sencillas, paso
a paso:

![PowerBITool en GitHub](../../assets/qr-powerbitool-repo.png)

**github.com/Graphene-Lab/PowerBITool**

También puedes simplemente escribir esa dirección en un navegador.

## ¿Atascado? Personas de verdad responden en 24 horas, y gratis

Aquí hay algo de lo que estamos orgullosos. PowerBITool es gratis, y gratis es
también la ayuda que lo acompaña. Si algo no funciona, o quieres una función, o
simplemente has encontrado un fallo, abres un **issue** en la misma página de
GitHub y nuestros técnicos responden, normalmente en **24 horas** y con una
solución real, no una respuesta enlatada.

Escanea este código para llegar a la página de incidencias y ver cómo funciona:

![Reportar un problema a PowerBITool](../../assets/qr-powerbitool-issues.png)

**github.com/Graphene-Lab/PowerBITool/issues**

Esa es toda la promesa: una herramienta gratis, soporte gratis, personas de
verdad, respuestas rápidas.

## Cómo leer este libro

No necesitas instalar nada para disfrutar de este libro. Léelo como una historia si
te apetece. Pero si quieres probar las cosas sobre la marcha, y esperamos que lo
hagas, cada ejemplo práctico muestra dos cosas:

- **Lo que una persona escribió** al asistente (una o dos frases normales).
- **Lo que devolvió** (el resultado real, de la herramienta real).

Las imágenes de este libro muestran ese intercambio: la pregunta a la derecha, la
respuesta de PowerBITool a la izquierda, tal cual aparece en AgentBridge.

## Sobre las imágenes de este libro

Verás dos tipos de imágenes.

**Los paneles de chat** muestran el intercambio en sí: lo que una persona escribió
y el resultado real que PowerBITool devolvió del modelo en vivo.

**Las imágenes de gráficos** muestran esos mismos datos reales *visualizados*:
gráficos de barras, de líneas y de anillo dibujados a partir de los números reales
que devolvió la herramienta (ventas por categoría, mejores clientes, la tendencia
mensual, etc.). Son visualizaciones generadas de la salida real capturada, para que
puedas ver los datos como una imagen, no solo como texto.

Una nota honesta sobre Power BI Desktop en sí. Power BI representa estos mismos
datos en su propio lienzo de informe, y la herramienta puede capturar ese lienzo
como PNG (`CaptureReportScreenshot`, a través del Power BI Desktop Bridge). Esa
captura necesita un informe con visuales ya construidos en la ventana de Power BI
Desktop. Este libro se produjo en un entorno sin un informe construido con la
interfaz gráfica, así que las imágenes de gráficos de aquí se generaron a partir de
los datos reales, no capturadas de la pantalla de Power BI. El procedimiento para
capturar capturas auténticas de Power BI Desktop viene con la herramienta, y puedes
soltar esas capturas directamente en estos mismos sitios.

Empecemos por el trabajo en sí.

*— Graphene Lab*
