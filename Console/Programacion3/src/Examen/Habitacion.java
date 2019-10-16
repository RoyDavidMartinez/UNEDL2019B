/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Examen;

public class Habitacion {

    public static double dAncho=5.65;
    public static double dLargo=8.45;
    public static double dArea;
    public Habitacion(double dAncho, double dLargo, double dArea) {
        this.dAncho = dAncho;
        this.dLargo = dLargo;
        this.dArea = dArea;
    }

    public double getdArea() {
        return dArea;
    }

    public void setdArea(double dArea) {
        this.dArea = dArea;
    }

    public double getdAncho() {
        return dAncho;
    }

    public void setdAncho(double dAncho) {
        this.dAncho = dAncho;
    }

    public double getdLargo() {
        return dLargo;
    }

    public void setdLargo(double dLargo) {
        this.dLargo = dLargo;
    }

    public double getArea() {
        dArea = dLargo * dAncho;
    return dArea;
    }
    
}
