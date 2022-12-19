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
public class CRUD_Libros {
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
    
    public int crearLibro(Libros libro){
        int id = 0;
        IniciaSQL();
        id = (int)session.save(libro);
        TerminaSQL();
        return id;
    }
    
    public void actualizaLibro(Libros libro){
        IniciaSQL();
        session.update(libro);
        TerminaSQL();
    }
    
    public void eliminaLibro(Libros libro){
        IniciaSQL ();
        session.delete(libro);
        TerminaSQL();
    }
    
    public Libros obtieneLibro(int idlibro){
        Libros libro = null;
        IniciaSQL();
        libro = (Libros) session.get(Libros.class, idlibro);
        TerminaSQL();
        return libro;
    }
}
