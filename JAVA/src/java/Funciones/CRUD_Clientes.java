/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Funciones;

import Hibernate_Class.*;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.AnnotationConfiguration;

/**
 *
 * @author leito
 */
public class CRUD_Clientes {
    private Session session;
    
    private void IniciaSQL(){
        SessionFactory sessionFactory = new AnnotationConfiguration().configure().buildSessionFactory();
        session = sessionFactory.openSession(); 
        session.getTransaction().begin();
    }
        
    private void TerminaSQL(){
        session.getTransaction().commit();
        session.close();
    }
    
    public int crearCliente(Cliente cliente){
        int id = 0;
        IniciaSQL();
        id = (int)session.save(cliente);
        TerminaSQL();
        return id;
    }
    
    public void actualizaCliente(Cliente cliente){
        IniciaSQL();
        session.update(cliente);
        TerminaSQL();
    }
    
    public void eliminaCliente(Cliente cliente){
        IniciaSQL ();
        session.delete(cliente);
        TerminaSQL();
    }
    
    public Cliente obtieneCliente(int idcliente){
        Cliente cliente = null;
        IniciaSQL();
        cliente = (Cliente) session.get(Cliente.class, idcliente);
        TerminaSQL();
        return cliente;
    }
}
