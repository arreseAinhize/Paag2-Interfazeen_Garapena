package com.ainhize.books_api.model.base;

public class Liburua {
    private String id;
    private String titulo;
    private String autor_id;
    private String saga;
    private int numero_saga;
    private int anio_publicacion;
    private int paginas;
    private String isbn;
    private double valoracion_promedio;
    private String sinopsis;

    public Liburua(){}

    public Liburua(String id, String titulo, String autor_id, String saga, int numero_saga, int anio_publicacion, int paginas, String isbn, double valoracion_promedio, String sinopsis){
        this.id = id;
        this.titulo = titulo;
        this.autor_id = autor_id;
        this.saga = saga;
        this.numero_saga = numero_saga;
        this.anio_publicacion = anio_publicacion;
        this.paginas = paginas;
        this.isbn = isbn;
        this.valoracion_promedio = valoracion_promedio;
        this.sinopsis = sinopsis;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getAutor_id() {
        return autor_id;
    }

    public void setAutor_id(String autor_id) {
        this.autor_id = autor_id;
    }

    public String getSaga() {
        return saga;
    }

    public void setSaga(String saga) {
        this.saga = saga;
    }

    public int getNumero_saga() {
        return numero_saga;
    }

    public void setNumero_saga(int numero_saga) {
        this.numero_saga = numero_saga;
    }

    public int getAnio_publicacion() {
        return anio_publicacion;
    }

    public void setAnio_publicacion(int anio_publicacion) {
        this.anio_publicacion = anio_publicacion;
    }

    public int getPaginas() {
        return paginas;
    }

    public void setPaginas(int paginas) {
        this.paginas = paginas;
    }

    public String getIsbn() {
        return isbn;
    }

    public void setIsbn(String isbn) {
        this.isbn = isbn;
    }

    public double getValoracion_promedio() {
        return valoracion_promedio;
    }

    public void setValoracion_promedio(double valoracion_promedio) {
        this.valoracion_promedio = valoracion_promedio;
    }

    public String getSinopsis() {
        return sinopsis;
    }

    public void setSinopsis(String sinopsis) {
        this.sinopsis = sinopsis;
    }
}
