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
public class Examen {
    public static void main(String args[]) {
            Tapiz tapiz1 = new Tapiz(3.5f);
            Habitacion  habitacion1=new Habitacion(2.5f, 4.0f);
            Calculadora calculadora =  new Calculadora(habitacion1, tapiz1);
            System.out.println("Area: "+habitacion1.getArea());
            System.out.println("Costo total: "+calculadora.getTotalCost());
                }
}
