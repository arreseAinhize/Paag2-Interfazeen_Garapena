package com.ainhize.books_api.model;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.ainhize.books_api.model.base.*;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.model.Sorts;

import jakarta.annotation.PostConstruct;

import static com.mongodb.client.model.Filters.eq;

@Repository
public class MongoDBBookRepository implements BookRepository {
    @Autowired
    private MongoClient mongoClient;

    private MongoCollection<Liburua> liburuaCollection;

    @PostConstruct
    public void init() {
        liburuaCollection = mongoClient.getDatabase("bookDB").getCollection("liburuak", Liburua.class);
    }
    
    @Override
    public List<Liburua> findAll(){
        return liburuaCollection.find().into(new ArrayList<>());
        //--> .find() metodoa erabiliz <-- IntinerableList bueltatzen du
                // --> .into(new ArrayList<>()) erabiliz List bilakatzen dugu.
    }

    @Override
    public Liburua findLiburua(String id){
        return liburuaCollection.find(eq("_id",id)).first();
        // --> .first() listako lehen objetua itzuliko du.
    } 

    @Override
    public List<Liburua> findLiburuaByAutor(String id){
        return liburuaCollection.find(eq("autor_id",id)).into(new ArrayList<>());
    }

    @Override
    public Liburua save(Liburua book){
        String id = String.valueOf(liburuaCollection.countDocuments() + 1);
        book.setId("L0"+id);
        liburuaCollection.insertOne(book);
        return book;
    }

    @Override
    public long delete(String id){
        return liburuaCollection.deleteMany(eq("autor_id",id)).getDeletedCount();
    }
}
