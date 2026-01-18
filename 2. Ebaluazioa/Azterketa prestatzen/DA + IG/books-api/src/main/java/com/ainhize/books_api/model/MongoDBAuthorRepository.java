package com.ainhize.books_api.model;

import static com.mongodb.client.model.Filters.eq;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.ainhize.books_api.model.base.Egilea;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoCollection;

import jakarta.annotation.PostConstruct;

@Repository
public class MongoDBAuthorRepository implements AuthorRepository {
    @Autowired
    private MongoClient mongoClient;

    private MongoCollection<Egilea> egileaCollection;

    @PostConstruct
    public void init() {
        egileaCollection = mongoClient.getDatabase("bookDB").getCollection("egileak", Egilea.class);
    }

    @Override
    public List<Egilea> findAll(){
        return egileaCollection.find().into(new ArrayList<>());
    }

    @Override
    public Egilea findEgilea(String id){
        return egileaCollection.find(eq("_id", id)).first();
    }

    @Override
    public Egilea save(Egilea pertsona){
        String id = String.valueOf(egileaCollection.countDocuments() + 1);
        pertsona.setId(id);
        egileaCollection.insertOne(pertsona);
        return pertsona;
    }

    @Override
    public long delete(String id){
        return egileaCollection.deleteMany(eq("_id",id)).getDeletedCount();
    }
}
