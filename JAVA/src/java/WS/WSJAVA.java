/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import Funciones.CRUD_Clientes;
import Funciones.CRUD_Libros;
import Hibernate_Class.*;

/**
 *
 * @author leito
 */
@WebService(serviceName = "WSJAVA")
public class WSJAVA {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "creaUsuario")
    public boolean creaUsuario(@WebParam(name = "nameUser") final String nameUser, @WebParam(name = "lastUser") final String lastUser) {
        try{
            int numRandom = (int)(Math.random()*10000+1);
            
            CRUD_Clientes funcionesCliente = new CRUD_Clientes();
            Cliente cliente = new Cliente(numRandom,nameUser,lastUser);

            funcionesCliente.crearCliente(cliente);
            
            return true;
        }catch(Exception ex){
            return false;
        }
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "editaUser")
    public boolean editaUser(@WebParam(name = "idUserEdit") final int idUserEdit, @WebParam(name = "nameUserEdit") final String nameUserEdit, @WebParam(name = "lastUserEdit") final String lastUserEdit) {
        try{
            CRUD_Clientes funcionesCliente = new CRUD_Clientes();
            Cliente cliente = null;
            cliente = funcionesCliente.obtieneCliente(idUserEdit);
            
            cliente.setNombre(nameUserEdit);     
            cliente.setApellido(lastUserEdit);
            
            funcionesCliente.actualizaCliente(cliente);
            
            return true;
        }catch(Exception ex){
            return false;
        }
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "eliminaUser")
    public boolean eliminaUser(@WebParam(name = "idUserDelete") final int idUserDelete) {
        try{
            CRUD_Clientes funcionesCliente = new CRUD_Clientes();
            Cliente cliente = null;
            cliente = funcionesCliente.obtieneCliente(idUserDelete);

            funcionesCliente.eliminaCliente(cliente);
            
            return true;
        }catch(Exception ex){
            return false;
        }
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "creaLibro")
    public boolean creaLibro(@WebParam(name = "nameLibro") final String nameLibro, @WebParam(name = "autorLibro") final String autorLibro, @WebParam(name = "annoLibro") final String annoLibro) {
        try{
            int numRandom = (int)(Math.random()*10000+1);
            int estado = 0;
            
            CRUD_Libros funcionesLibro = new CRUD_Libros();
            Libros libro = new Libros(numRandom,nameLibro,autorLibro,annoLibro,estado);

            funcionesLibro.crearLibro(libro);
            
            return true;
        }catch(Exception ex){
            return false;
        }
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "editaLibro")
    public boolean editaLibro(@WebParam(name = "idLibroEdit") final int idLibroEdit, @WebParam(name = "nameLibroEdit") final String nameLibroEdit, @WebParam(name = "autorLibroEdit") final String autorLibroEdit, @WebParam(name = "annoLibroEdit") final String annoLibroEdit, @WebParam(name = "estadoLibroEdit") final int estadoLibroEdit) {
        try{
            CRUD_Libros funcionesLibro = new CRUD_Libros();
            Libros libro = null;
            libro = funcionesLibro.obtieneLibro(idLibroEdit);
            
            libro.setNombre(nameLibroEdit);            
            libro.setAutor(autorLibroEdit);     
            libro.setAnno(annoLibroEdit);     
            libro.setEstado(estadoLibroEdit); 
      
            funcionesLibro.actualizaLibro(libro);
            
            return true;
        }catch(Exception ex){
            return false;
        }
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "eliminaLibro")
    public boolean eliminaLibro(@WebParam(name = "idLibroDelete") final int idLibroDelete) {
        try{
            CRUD_Libros funcionesLibro = new CRUD_Libros();
            Libros libro = null;
            libro = funcionesLibro.obtieneLibro(idLibroDelete);

            funcionesLibro.eliminaLibro(libro);
            
            return true;
        }catch(Exception ex){
            return false;
        }
    }
    
}
