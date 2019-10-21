/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Examen;

public class Habitacion {

    public static float dAncho;
    public static float dLargo;
    public Habitacion(float dAncho, float dLargo) {
        this.dAncho = dAncho;
        this.dLargo = dLargo;
    }

    public float getArea() {
    return dLargo*dAncho;
    }
    
}
