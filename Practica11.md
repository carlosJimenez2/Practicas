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
1. Desarrollar una herramienta que permita sumar Y restar el conjunto de números reales.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
 
2. El resultado se debe de desplegar una vez que se presionó el botón de "resultado" en la aplicación y no debe de ser mayor a 4 digitos.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
3. Se debe de realizar la operacion de acuerdo a la opcion seleccionada. 
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [x] No es ambiguo
    
4. Ambos campos deben de contener informacion parapoder realizar la operacion.
    - [x] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
5. La aplicacion debe de desplegar un mensaje de que faltan datos, mostrando en que parte falta el dato.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
6. Los datos de entrada no deben de ser mayores a 3 digitos. 
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
7. El tamaño de letra debe ser de 16px para los campos de entrada y el resultado.
    - [X] Unico
    - [X] No es contradictorio
    - [X] Se puede probar 
    - [X] No es ambiguo
    
8. Los campos en la forma solo deben de aceptar numeros. 
    - [x] Unico
    - [x] No es contradictorio
    - [x] Se puede probar 
    - [x] No es ambiguo
    
   
   /*
 * Copyright 2017 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.android.instantapps.samples.hello.feature;

import android.content.Intent;
import android.os.Bundle;
import android.provider.MediaStore;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

/**
 * This Activity displays a simple hello world text and a button to open the GoodbyeActivity.
 */
public class HelloActivity extends AppCompatActivity {

    private EditText editText1;
    private EditText editText2;
    private TextView textView1;
    private RadioButton rBurron1;
    private RadioButton rBuutton2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hello);
        findViewById(R.id.button).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(HelloActivity.this, GoodbyeActivity.class));
            }
        });

        editText1 = (EditText)findViewById(R.id.txt_num1);
        editText2 = (EditText)findViewById(R.id.txt_num2);
        textView1 = (TextView)findViewById(R.id.txt_Resultado);
        rBurron1 = (RadioButton)findViewById(R.id.radioButtonResta);
        rBuutton2 = (RadioButton)findViewById(R.id.radioButtonSuma);
    }

    public void Suma(View view)
    {

        String Val1T = editText1.getText().toString();
        String Val2T = editText2.getText().toString();

        double Val1Int = Double.parseDouble(Val1T);
        double  Val2Int = Double.parseDouble(Val2T);

        double Result =0;

        if (rBuutton2.isChecked() == true)
        {
            Result= Val1Int + Val2Int;
        }

       else
        {
            Result= Val1Int - Val2Int;
        }

       // Result= Val1Int + Val2Int;

        String ResStrig = String.valueOf(Result);

        textView1.setText(ResStrig);

    }

    public void Quitar(View view)
    {

        editText1.setText(null);
        editText2.setText(null);
        String ResStrig = "";
        textView1.setText(ResStrig);
    }

}

   
   
