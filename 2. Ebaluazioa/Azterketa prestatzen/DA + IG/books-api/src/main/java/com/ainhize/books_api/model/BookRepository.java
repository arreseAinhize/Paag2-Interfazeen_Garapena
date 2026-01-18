package com.ainhize.books_api.model;

import java.util.List;

import org.springframework.stereotype.Repository;

import com.ainhize.books_api.model.base.*;

@Repository
public interface BookRepository {
    public List<Liburua> findAll();
    public Liburua findLiburua(String id);
    public List<Liburua> findLiburuaByAutor(String id);
    public Liburua save(Liburua book);
    public long delete(String autor_id);
}
