package com.ainhize.books_api.model;

import java.util.List;

import com.ainhize.books_api.model.base.Egilea;

public interface AuthorRepository {
    List<Egilea> findAll(); 
    Egilea findEgilea(String id);
    Egilea save(Egilea egilea);
    long delete(String id);
}
