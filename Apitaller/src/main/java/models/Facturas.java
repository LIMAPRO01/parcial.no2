/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package models;

/**
 *
 * @author Windows
 */
public class Facturas {
        private int id;
    private String nombreCliente;
    private String nombreRepuesto;
    

    // Getters y Setters
    public int getid() { return id; }
    public String getnombreCliente() { return nombreCliente; }
    public String getnombreRepuesto() { return nombreRepuesto; }
  

    public void setid(int id) { this.id = id; }
    public void setnombreCliente(String nombrecliente) { this.nombreCliente = nombreCliente; }
    public void setnombreRepuesto(String nombrerepuesto) { this.nombreRepuesto = nombreRepuesto; }
    
    
}
