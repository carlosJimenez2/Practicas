**Objetivo:** Desarrollar una herramienta que permita sumar o restar dos números. Mostrar el resultado una vez que se presiona un botón.

Requisitos: 
-¿Qué tipo de números?
Todos los números reales

-¿Qué rango de dígitos?
3

-¿Las operaciones se hacen al mismo tiempo?
No

-¿Se necesitan guardar?
No

-¿Que pasa una vez que se realizó la operación?
Muestra el resultado y mantiene los datos con los que se realizó la operación.

-¿Como se van a desplegar los errores?
Que marque dónde está el error, cuál es el error y que no mande el resultado.

-¿Hay alguna preferencia con las etiquetas?
Las etiquetas deben estar ajustadas al máximo número de caracteres permitidos.

-¿Qué tamaño de letra?
16

Notas: 
Agregar un botón de borrar.

**Objetivo**
Desarrollar una herramienta que permita sumar el conjunto de números reales, enteros y con punto decimal con un rango máximo de 4 dígitos.
El resultado se debe de desplegar una vez que se presionó el botón de "resultado" en la aplicación.
Se debe realizar la operacion de acuerdo a la operacion seleccionada.
Ambos campos deben de contener informacaon parapoder realizar la operacion, en caso contrario la aplicacion la aplicacion debe de desplegar un mensaje de que faltan datos, mostrando en que parte falta el dato.
Los datos introducidos no deben de ser mayores a 3 digitos. 
El tamaño de letra debe ser de 16px para los campos de entrada y el resultado.
Los campos en la forma solo deben de aceptar numeros. 

**Analisis de requisitos** 
R1. Desarrollar una herramienta que permita sumar Y restar el conjunto de números reales.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
 
R2. El resultado se debe de desplegar una vez que se presionó el botón de "resultado" en la aplicación y no debe de ser mayor a 4 digitos.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
R3. Se debe de realizar la operacion de acuerdo a la opcion seleccionada. 
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [x] No es ambiguo
    
R4. Ambos campos deben de contener informacion parapoder realizar la operacion.
    - [x] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
R5. La aplicacion debe de desplegar un mensaje de que faltan datos, mostrando en que parte falta el dato.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
R6. Los datos de entrada no deben de ser mayores a 3 digitos. 
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
R7. El tamaño de letra debe ser de 16px para los campos de entrada y el resultado.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
R8. Los campos en la forma solo deben de aceptar numeros. 
    - [x] Unico
    - [x] No es contradictorio
    - [x] Se puede probar 
    - [x] No es ambiguo
    
### **Casos de prueba**

Condiciones previas: 
El dispositivo de prueba debe de ser un disposititvo con sistema operativo addrioid IceScream Sandwich o mayor. 
La herramienta debe de estar previamente instalada. 

*TestCase ID/* TC1R1
*TestCaseScenario/* Probar que la herramienta permita sumar y restar un conjunto de numero reales enteros. 
1. Ingresar 100 en el primer caso. 
2. Ingresar 25 en el segundo caso.
3. Seleccionar la operación Suma.
4. Precionar el boton de Resultado. 
*Expected Results/* 
La aplicación debe de desplegar el resultado igual a 125.
*Pass/Fail:*


*TestCase ID/* TC2R1
*TestCaseScenario/* Probar que la herramienta permita sumar y restar un conjunto de numero reales enteros. 
1. Ingresar 100 en el primer caso. 
2. Ingresar 25 en el segundo caso.
3. Seleccionar la operación Resta.
4. Precionar el boton de Resultado. 
*Expected Results/* 
La aplicación debe de desplegar el resultado igual a 75.
*Pass/Fail:*

*TestCase ID/* TC3R1
*TestCaseScenario/* Probar que la herramienta permita sumar y restar un conjunto de numero reales enteros. 
1. Ingresar -100 en el primer caso. 
2. Ingresar -25 en el segundo caso.
3. Seleccionar la operación Suma.
4. Precionar el boton de Resultado. 
*Expected Results/* 
La aplicación debe de desplegar el resultado igual a -125.
*Pass/Fail:*

*TestCase ID/* TC4R1
*TestCaseScenario/* Probar que la herramienta permita sumar y restar un conjunto de numero reales enteros. 
1. Ingresar -100 en el primer caso. 
2. Ingresar -25 en el segundo caso.
3. Seleccionar la operación Resta.
4. Precionar el boton de Resultado. 
*Expected Results/* 
La aplicación debe de desplegar el resultado igual a -75.
*Pass/Fail:*


*TestCase ID/* TC5R1
*TestCaseScenario/* Probar que la herramienta permita sumar y restar un conjunto de numero reales enteros. 
1. Ingresar 100 en el primer caso. 
2. Ingresar -25 en el segundo caso.
3. Seleccionar la operación Suma.
4. Precionar el boton de Resultado. 
*Expected Results/* 
La aplicación debe de desplegar el resultado igual a -75.
*Pass/Fail:*

