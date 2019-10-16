/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Examen;


public class Calculadora {
    
    private Tapiz t;
    private Habitacion h;
    private double dCostoPorMetro;
    private static double dCostoTotal;
    public Calculadora(){
                          
        }
        public double getTotalCost(){
            dCostoTotal=t.getCost()*h.getdArea();
           return dCostoTotal;
        }
        public static void main(String args[]) {
        Calculadora calculadora1 = new Calculadora();
        calculadora1.getTotalCost();
//            calculadora1.getTotalCost();
                }

    
    
}
