/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Examen;

/**
 *
 * @author USER
 */
public class Tapiz {
    public static double dCostoPorMetro=8.98;

    public Tapiz(double dCostoPorMetro){
        
        this.dCostoPorMetro= dCostoPorMetro;
    }

    public double getdCostoPorMetro() {
        return dCostoPorMetro;
    }

    public void setdCostoPorMetro(double dCostoPorMetro) {
        this.dCostoPorMetro = dCostoPorMetro;
    }
    
    public double getCost(){
        return dCostoPorMetro;
//        System.out.println("El costo del tapiz es: "+dCostoPorMetro);
    }
    
}
