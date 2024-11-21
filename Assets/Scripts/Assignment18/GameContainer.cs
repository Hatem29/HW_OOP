using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContainer<T>
{
    private T item;
    
    public void setItem(T item) {  this.item = item; }
    public T getItem() 
    {
        Debug.Log("Stored item : " + this.item); 
        return this.item;
    }
}
