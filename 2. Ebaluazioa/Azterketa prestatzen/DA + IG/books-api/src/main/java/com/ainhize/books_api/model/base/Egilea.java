package com.ainhize.books_api.model.base;

public class Egilea {
    private String id;
    private String nombre_completo;
    private String nacionalidad;
    private int anio_nacimiento;
    private int libros_publicados;
    
    public Egilea(){}

    public Egilea(String id, String nombre_completo, String nacionalidad, int anio_nacimiento, int libros_publicados) {
        this.id = id;
        this.nombre_completo = nombre_completo;
        this.nacionalidad = nacionalidad;
        this.anio_nacimiento = anio_nacimiento;
        this.libros_publicados = libros_publicados;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getNombre_completo() {
        return nombre_completo;
    }

    public void setNombre_completo(String nombre_completo) {
        this.nombre_completo = nombre_completo;
    }

    public String getNacionalidad() {
        return nacionalidad;
    }

    public void setNacionalidad(String nacionalidad) {
        this.nacionalidad = nacionalidad;
    }

    public int getAnio_nacimiento() {
        return anio_nacimiento;
    }

    public void setAnio_nacimiento(int anio_nacimiento) {
        this.anio_nacimiento = anio_nacimiento;
    }

    public int getLibros_publicados() {
        return libros_publicados;
    }

    public void setLibros_publicados(int libros_publicados) {
        this.libros_publicados = libros_publicados;
    }
}
