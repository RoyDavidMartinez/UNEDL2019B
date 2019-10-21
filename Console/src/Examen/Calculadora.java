/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Examen;


public class Calculadora {
    
       private static float resultado;
    public Calculadora(Habitacion habitacion,Tapiz tapizl){
    resultado = habitacion.getArea() * tapizl.getCost();
        }
  
        public float getTotalCost(){
            return resultado;
        }
        

    
    
}
